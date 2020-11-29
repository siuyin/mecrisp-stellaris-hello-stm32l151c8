\ btn.fs supports a push button (active low) on PA6, pin 16.

#require gpio.fs

\ BtnInit initialises the button on PA6
: BtnInit ( -- )
    %01 6 2* lshift GPIOA-PUPDR bis! \ enable pull-up on PA6
;

\ BtnPushed? outputs if the button on PA6 is pushed.
: BtnPushed? ( -- flag )
    1 6 lshift GPIOA-IDR bit@ not
;
