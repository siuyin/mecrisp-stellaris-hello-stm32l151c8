\ blink.fs blinks LED on PB7 (pin 43).

forgetram
compiletoram

#require led.fs

: dly 0 do i drop loop ;
\ Blink blinks LED on PB7 (pin 43).
: Blink
    cr ." Press <Enter> key to stop."
    LEDInit
    begin
        0 LED
        200000 dly
        1 LED
        200000 dly
        key?
    until
;

compiletoram

\ main
Blink
