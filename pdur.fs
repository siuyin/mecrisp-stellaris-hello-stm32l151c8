\ pdur.fs provides pulse duration measurement functions at timer 10 channel 1 input (PA6, pin 16).

#require rcc.fs
#require gpio.fs
#require tim.fs
: tClkEn ( -- ) \ enable clock to timer 10
    1 3 lshift RCC-APB2ENR bis! \ enable clock to Tim10
;
: pa6Alt ( -- ) \ configure PA6 to Tim10_Ch1
    %10 6 2* lshift GPIOA-MODER bis! \ configure PA6 to alternate function mode
    %0011 6 4 * lshift GPIOA-AFRL bis! \ configure PA6 to alternate function 3 (Tim10_Ch1)
;
: capEdge ( 0/1 -- ) \ 0: capture on rising edge, 1: capture on falling edge
    0= if
        %101 1 lshift TIM10-CCER bic! \ capture on rising edge
    else
        1  3 lshift TIM10-CCER bic!
        %1 1 lshift TIM10-CCER bis! \ capture on falling edge
    then
;
\ PDInit initialises Tim10 on PA6 to capture button push duration.
\ Initial trigger on falling edge as Btn push is active low.
: PDInit ( -- )
    tClkEn \ enable clock to timer 10
    pa6Alt \ configure PA6 to Tim10_Ch1

    16000 1- TIM10-PSC h! \ set timer 10 prescaler to divide by 16000 to give a clock period of 1ms

    %01 TIM10-CCMR1_Input bis! \ link timer channel 1 pin to input 1
    1 capEdge \ capture on falling edge as button is pushed
    1 TIM10-CCER bis! \ enable capture

    1 TIM10-CR1 h! \ enable counting on timer 10
;

: waitICF ( -- flag ) \ wait for input capture flag to be raised
    begin
        1 1 lshift TIM10-SR hbit@ \ wait for input capture flag to be raised
    until
;
: waitCap ( -- n ) \ waits for button press and outputs button-down duration
    waitICF 
    TIM10-CCR1 h@ >r \ push start time to return stack (temporary variable)

    0 capEdge \ change to capture on rising edge
    waitICF
    TIM10-CCR1 h@ r> - \ end time - start time (milliseconds)

    1 capEdge \ reset for next button push
;
\ PDMeas outputs the duration of the button push in milliseconds.
: PDMeas ( -- n )
    TIM10-CCR1 h@ drop
    waitCap \ wait for timer input duration capture
;

