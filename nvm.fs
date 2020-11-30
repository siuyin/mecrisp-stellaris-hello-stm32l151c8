\ nvm.fs defines constants relating to non-volatile memory: flash and eeprom.

$40023C00 constant Flash ( Flash ) 
Flash $C + constant Flash-PEKEYR ( Program/erase key register ) 
Flash $4 + constant Flash-PECR ( Program/erase control register ) 
Flash $18 + constant Flash-SR ( Status register ) 

$08080000 constant EEPROM

\ NVBsy? checks if non-volatile memory write is in progress.
: NVBsy? ( -- flag )
    1 Flash-SR bit@
;
