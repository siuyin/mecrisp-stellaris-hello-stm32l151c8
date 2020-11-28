# Demostration programs with mecrisp-stellaris forth for STM32L151C8

## mecrips-stellaris on STM32L151C8
- wireup all Vdd and Vss pins, including VddA and VssA
- connect a 0.1uF capacitor between nRst and Gnd
- connect Boot0 to Gnd
- use mecrisp-stellaris for STM32L152RB and modify the memory settings for L151C8.
- generate memmap.fs and bitfields.fs from mecrips-stellaris/common/svd2fth v3.

## Forth demo code
1. led.fs drives LED on PB7 (pin 43). LED is active high.
1. gpio.fs provides GPIO 'headers' for led.fs .
1. blink.fs list 'main' program to blink the LED.
 It also defines a busy loop delay.
