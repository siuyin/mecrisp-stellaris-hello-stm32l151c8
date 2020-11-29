\ btndur.fs measures time button is pushed in milliseconds.
\ button bounce makes this measurement tricky as there is no debounce implemented.

forgetram

compiletoram

#require pdur.fs

compiletoram

\ main
: main ( -- )
    PDInit

    cr ." Push the button on PA6 to display button-down duration" cr
    PDMeas .
;

main
