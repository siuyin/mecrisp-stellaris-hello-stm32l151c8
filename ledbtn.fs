\ ledbtn.fs lights the LED on PB7 when the button on PA6 is pushed.

forgetram
compiletoram

#require led.fs
#require btn.fs

: LEDBtn ( -- )
    cr ." Press <enter> to stop."
    LEDInit BtnInit
    begin
        BtnPushed? if
            1 LED
        else
            0 LED
        then
        key?
    until
;

compiletoram

\ main

LEDBtn
