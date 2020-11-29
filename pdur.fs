\ pdur.fs provides pulse duration measurement functions.

#require rcc.fs
#require gpio.fs
#require tim.fs
\ PDBtnInit initialises Tim10 on PA6 to capture button push duration.
\ Initial trigger on falling edge as Btn push is active low.
: PDBtnInit ( -- )
    1 3 lshift RCC-APB2ENR bis! \ enable clock to Tim10
    %0011 6 4 * lshift GPIOA-AFRL bis! \ configure PA6 to alternate function 3 (Tim10_Ch1)
    16000 1- TIM10-PSC h! \ set timer 10 prescaler to divide by 16000 to give a clock period of 1ms
    1 TIM10-CR1 h! \ enable counting on timer 10
;

\ PDBtn outputs the duration of the button push in milliseconds.
: PDBtn ( -- n )
;
