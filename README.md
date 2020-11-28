# Demostration programs with mecrisp-stellaris forth for STM32L151C8

## mecrips-stellaris on STM32L151C8

My "evaluation board" comprises a bare STM32L141C8 chip
soldered on to a LQFP48 breakout board. The following connections
were made on the board.
- wireup all Vdd and Vss pins, including VddA and VssA
- add decoupling capacitors. I used 2uF ceramic for VDD/VSS 1 and 0.1uF
 ceramic for the other VDD/VSS pairs and VDDA/VSSA.
- connect a 0.1uF capacitor between nRst and Gnd
- connect Boot0 to Gnd

Use mecrisp-stellaris for STM32L152RB and modify the memory settings for L151C8.
Tweak the .s (assembler) file in the sources folder.

Generate memmap.fs and bitfields.fs from mecrips-stellaris/common/svd2fth v3.

## Forth demo code
1. led.fs drives LED on PB7 (pin 43). LED is active high.
1. gpio.fs provides GPIO 'headers' for led.fs .
1. blink.fs list 'main' program to blink the LED.
 It also defines a busy loop delay.
