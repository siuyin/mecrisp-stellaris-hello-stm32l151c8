\ led.fs provides functions related to LED on PB7 (pin 43).
\ LED is active high.

#require gpio.fs

\ LEDInit initialises LED's GPIO hardware.
: LEDInit ( -- )
    %01 7 2* lshift GPIOB-MODER bis! \ PB7 configured to output
;

\ LED turns off or on LED on PB7
: LED ( 0/1 -- )
    0= if
        1 7 16 + lshift GPIOB-BSRR bis! \ reset LED on PB7
    else
        1 7 lshift GPIOB-BSRR bis! \ set LET on PB7
    then
;
