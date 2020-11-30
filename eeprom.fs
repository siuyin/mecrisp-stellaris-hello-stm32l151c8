\ eeprom.fs implements EEPROM functions.
\ The EEPROM is unlocked after this file is included. Use EELock to lock it again.
\ To write to an eeprom word location 3 (byte 12) : $deadbeef EEPROM 3 4 * + !

#require nvm.fs

: ftdw ( 0/1 -- ) \ fixed time data write to EEPROM
    0= if
        1 8 lshift Flash-PECR bic! \ enable 'fast' write, EEPROM location must previously be erased
    else
        1 8 lshift Flash-PECR bis! \ fixed time write, EEPROM location is first erase then written to. Takes two programming cycles
    then
;
\ EEUnlock unlocks access to EEPROM and the flash program/erase control register.
: EEUnlock ( -- )
    $89ABCDEF Flash-PEKEYR ! \ write key1
    $02030405 Flash-PEKEYR ! \ write key2

    1 ftdw \ fixed time eeprom data write. Location is automatically erased before write.
;

\ EELock locks access to EEPROM and the flash program/erase control register.
: EELock ( -- )
    1 Flash-PECR bis! \ disable access to flash
;


EEUnlock


