\ TEMPLATE FILE for STM32L15xC
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$40012700 constant C_ADC ( Common ADC registers ) 
C_ADC $0 + constant C_ADC-CSR ( ADC Common status register ) 
C_ADC $4 + constant C_ADC-CCR ( ADC common control register ) 
: C_ADC-CSR. ." C_ADC-CSR (read-only) $" C_ADC-CSR @ hex. C_ADC-CSR 1b. ;
: C_ADC-CCR. ." C_ADC-CCR (read-write) $" C_ADC-CCR @ hex. C_ADC-CCR 1b. ;
: C_ADC.
C_ADC-CSR.
C_ADC-CCR.
;

$40007C00 constant COMP ( Comparators ) 
COMP $0 + constant COMP-CSR ( comparator control and status  register ) 
: COMP-CSR. ." COMP-CSR () $" COMP-CSR @ hex. COMP-CSR 1b. ;
: COMP.
COMP-CSR.
;

$40023000 constant CRC ( CRC calculation unit ) 
CRC $0 + constant CRC-DR ( Data register ) 
CRC $4 + constant CRC-IDR ( Independent data register ) 
CRC $8 + constant CRC-CR ( Control register ) 
: CRC-DR. ." CRC-DR (read-write) $" CRC-DR @ hex. CRC-DR 1b. ;
: CRC-IDR. ." CRC-IDR (read-write) $" CRC-IDR @ hex. CRC-IDR 1b. ;
: CRC-CR. ." CRC-CR (write-only) $" CRC-CR @ hex. CRC-CR 1b. ;
: CRC.
CRC-DR.
CRC-IDR.
CRC-CR.
;

$40007400 constant DAC ( Digital-to-analog converter ) 
DAC $0 + constant DAC-CR ( control register ) 
DAC $4 + constant DAC-SWTRIGR ( software trigger register ) 
DAC $8 + constant DAC-DHR12R1 ( channel1 12-bit right-aligned data holding  register ) 
DAC $C + constant DAC-DHR12L1 ( channel1 12-bit left aligned data holding  register ) 
DAC $10 + constant DAC-DHR8R1 ( channel1 8-bit right aligned data holding  register ) 
DAC $14 + constant DAC-DHR12R2 ( channel2 12-bit right aligned data holding  register ) 
DAC $18 + constant DAC-DHR12L2 ( channel2 12-bit left aligned data holding  register ) 
DAC $1C + constant DAC-DHR8R2 ( channel2 8-bit right-aligned data holding  register ) 
DAC $20 + constant DAC-DHR12RD ( Dual DAC 12-bit right-aligned data holding  register ) 
DAC $24 + constant DAC-DHR12LD ( DUAL DAC 12-bit left aligned data holding  register ) 
DAC $28 + constant DAC-DHR8RD ( DUAL DAC 8-bit right aligned data holding  register ) 
DAC $2C + constant DAC-DOR1 ( channel1 data output register ) 
DAC $30 + constant DAC-DOR2 ( channel2 data output register ) 
DAC $34 + constant DAC-SR ( status register ) 
: DAC-CR. ." DAC-CR (read-write) $" DAC-CR @ hex. DAC-CR 1b. ;
: DAC-SWTRIGR. ." DAC-SWTRIGR (write-only) $" DAC-SWTRIGR @ hex. DAC-SWTRIGR 1b. ;
: DAC-DHR12R1. ." DAC-DHR12R1 (read-write) $" DAC-DHR12R1 @ hex. DAC-DHR12R1 1b. ;
: DAC-DHR12L1. ." DAC-DHR12L1 (read-write) $" DAC-DHR12L1 @ hex. DAC-DHR12L1 1b. ;
: DAC-DHR8R1. ." DAC-DHR8R1 (read-write) $" DAC-DHR8R1 @ hex. DAC-DHR8R1 1b. ;
: DAC-DHR12R2. ." DAC-DHR12R2 (read-write) $" DAC-DHR12R2 @ hex. DAC-DHR12R2 1b. ;
: DAC-DHR12L2. ." DAC-DHR12L2 (read-write) $" DAC-DHR12L2 @ hex. DAC-DHR12L2 1b. ;
: DAC-DHR8R2. ." DAC-DHR8R2 (read-write) $" DAC-DHR8R2 @ hex. DAC-DHR8R2 1b. ;
: DAC-DHR12RD. ." DAC-DHR12RD (read-write) $" DAC-DHR12RD @ hex. DAC-DHR12RD 1b. ;
: DAC-DHR12LD. ." DAC-DHR12LD (read-write) $" DAC-DHR12LD @ hex. DAC-DHR12LD 1b. ;
: DAC-DHR8RD. ." DAC-DHR8RD (read-write) $" DAC-DHR8RD @ hex. DAC-DHR8RD 1b. ;
: DAC-DOR1. ." DAC-DOR1 (read-only) $" DAC-DOR1 @ hex. DAC-DOR1 1b. ;
: DAC-DOR2. ." DAC-DOR2 (read-only) $" DAC-DOR2 @ hex. DAC-DOR2 1b. ;
: DAC-SR. ." DAC-SR (read-write) $" DAC-SR @ hex. DAC-SR 1b. ;
: DAC.
DAC-CR.
DAC-SWTRIGR.
DAC-DHR12R1.
DAC-DHR12L1.
DAC-DHR8R1.
DAC-DHR12R2.
DAC-DHR12L2.
DAC-DHR8R2.
DAC-DHR12RD.
DAC-DHR12LD.
DAC-DHR8RD.
DAC-DOR1.
DAC-DOR2.
DAC-SR.
;

$40026000 constant DMA1 ( Direct memory access controller ) 
DMA1 $0 + constant DMA1-ISR ( interrupt status register ) 
DMA1 $4 + constant DMA1-IFCR ( interrupt flag clear register ) 
DMA1 $8 + constant DMA1-CCR1 ( channel x configuration  register ) 
DMA1 $C + constant DMA1-CNDTR1 ( channel x number of data  register ) 
DMA1 $10 + constant DMA1-CPAR1 ( channel x peripheral address  register ) 
DMA1 $14 + constant DMA1-CMAR1 ( channel x memory address  register ) 
DMA1 $1C + constant DMA1-CCR2 ( channel x configuration  register ) 
DMA1 $20 + constant DMA1-CNDTR2 ( channel x number of data  register ) 
DMA1 $24 + constant DMA1-CPAR2 ( channel x peripheral address  register ) 
DMA1 $28 + constant DMA1-CMAR2 ( channel x memory address  register ) 
DMA1 $30 + constant DMA1-CCR3 ( channel x configuration  register ) 
DMA1 $34 + constant DMA1-CNDTR3 ( channel x number of data  register ) 
DMA1 $38 + constant DMA1-CPAR3 ( channel x peripheral address  register ) 
DMA1 $3C + constant DMA1-CMAR3 ( channel x memory address  register ) 
DMA1 $44 + constant DMA1-CCR4 ( channel x configuration  register ) 
DMA1 $48 + constant DMA1-CNDTR4 ( channel x number of data  register ) 
DMA1 $4C + constant DMA1-CPAR4 ( channel x peripheral address  register ) 
DMA1 $50 + constant DMA1-CMAR4 ( channel x memory address  register ) 
DMA1 $58 + constant DMA1-CCR5 ( channel x configuration  register ) 
DMA1 $5C + constant DMA1-CNDTR5 ( channel x number of data  register ) 
DMA1 $60 + constant DMA1-CPAR5 ( channel x peripheral address  register ) 
DMA1 $64 + constant DMA1-CMAR5 ( channel x memory address  register ) 
DMA1 $6C + constant DMA1-CCR6 ( channel x configuration  register ) 
DMA1 $70 + constant DMA1-CNDTR6 ( channel x number of data  register ) 
DMA1 $74 + constant DMA1-CPAR6 ( channel x peripheral address  register ) 
DMA1 $78 + constant DMA1-CMAR6 ( channel x memory address  register ) 
DMA1 $80 + constant DMA1-CCR7 ( channel x configuration  register ) 
DMA1 $84 + constant DMA1-CNDTR7 ( channel x number of data  register ) 
DMA1 $88 + constant DMA1-CPAR7 ( channel x peripheral address  register ) 
DMA1 $8C + constant DMA1-CMAR7 ( channel x memory address  register ) 
: DMA1-ISR. ." DMA1-ISR (read-only) $" DMA1-ISR @ hex. DMA1-ISR 1b. ;
: DMA1-IFCR. ." DMA1-IFCR (write-only) $" DMA1-IFCR @ hex. DMA1-IFCR 1b. ;
: DMA1-CCR1. ." DMA1-CCR1 (read-write) $" DMA1-CCR1 @ hex. DMA1-CCR1 1b. ;
: DMA1-CNDTR1. ." DMA1-CNDTR1 (read-write) $" DMA1-CNDTR1 @ hex. DMA1-CNDTR1 1b. ;
: DMA1-CPAR1. ." DMA1-CPAR1 (read-write) $" DMA1-CPAR1 @ hex. DMA1-CPAR1 1b. ;
: DMA1-CMAR1. ." DMA1-CMAR1 (read-write) $" DMA1-CMAR1 @ hex. DMA1-CMAR1 1b. ;
: DMA1-CCR2. ." DMA1-CCR2 (read-write) $" DMA1-CCR2 @ hex. DMA1-CCR2 1b. ;
: DMA1-CNDTR2. ." DMA1-CNDTR2 (read-write) $" DMA1-CNDTR2 @ hex. DMA1-CNDTR2 1b. ;
: DMA1-CPAR2. ." DMA1-CPAR2 (read-write) $" DMA1-CPAR2 @ hex. DMA1-CPAR2 1b. ;
: DMA1-CMAR2. ." DMA1-CMAR2 (read-write) $" DMA1-CMAR2 @ hex. DMA1-CMAR2 1b. ;
: DMA1-CCR3. ." DMA1-CCR3 (read-write) $" DMA1-CCR3 @ hex. DMA1-CCR3 1b. ;
: DMA1-CNDTR3. ." DMA1-CNDTR3 (read-write) $" DMA1-CNDTR3 @ hex. DMA1-CNDTR3 1b. ;
: DMA1-CPAR3. ." DMA1-CPAR3 (read-write) $" DMA1-CPAR3 @ hex. DMA1-CPAR3 1b. ;
: DMA1-CMAR3. ." DMA1-CMAR3 (read-write) $" DMA1-CMAR3 @ hex. DMA1-CMAR3 1b. ;
: DMA1-CCR4. ." DMA1-CCR4 (read-write) $" DMA1-CCR4 @ hex. DMA1-CCR4 1b. ;
: DMA1-CNDTR4. ." DMA1-CNDTR4 (read-write) $" DMA1-CNDTR4 @ hex. DMA1-CNDTR4 1b. ;
: DMA1-CPAR4. ." DMA1-CPAR4 (read-write) $" DMA1-CPAR4 @ hex. DMA1-CPAR4 1b. ;
: DMA1-CMAR4. ." DMA1-CMAR4 (read-write) $" DMA1-CMAR4 @ hex. DMA1-CMAR4 1b. ;
: DMA1-CCR5. ." DMA1-CCR5 (read-write) $" DMA1-CCR5 @ hex. DMA1-CCR5 1b. ;
: DMA1-CNDTR5. ." DMA1-CNDTR5 (read-write) $" DMA1-CNDTR5 @ hex. DMA1-CNDTR5 1b. ;
: DMA1-CPAR5. ." DMA1-CPAR5 (read-write) $" DMA1-CPAR5 @ hex. DMA1-CPAR5 1b. ;
: DMA1-CMAR5. ." DMA1-CMAR5 (read-write) $" DMA1-CMAR5 @ hex. DMA1-CMAR5 1b. ;
: DMA1-CCR6. ." DMA1-CCR6 (read-write) $" DMA1-CCR6 @ hex. DMA1-CCR6 1b. ;
: DMA1-CNDTR6. ." DMA1-CNDTR6 (read-write) $" DMA1-CNDTR6 @ hex. DMA1-CNDTR6 1b. ;
: DMA1-CPAR6. ." DMA1-CPAR6 (read-write) $" DMA1-CPAR6 @ hex. DMA1-CPAR6 1b. ;
: DMA1-CMAR6. ." DMA1-CMAR6 (read-write) $" DMA1-CMAR6 @ hex. DMA1-CMAR6 1b. ;
: DMA1-CCR7. ." DMA1-CCR7 (read-write) $" DMA1-CCR7 @ hex. DMA1-CCR7 1b. ;
: DMA1-CNDTR7. ." DMA1-CNDTR7 (read-write) $" DMA1-CNDTR7 @ hex. DMA1-CNDTR7 1b. ;
: DMA1-CPAR7. ." DMA1-CPAR7 (read-write) $" DMA1-CPAR7 @ hex. DMA1-CPAR7 1b. ;
: DMA1-CMAR7. ." DMA1-CMAR7 (read-write) $" DMA1-CMAR7 @ hex. DMA1-CMAR7 1b. ;
: DMA1.
DMA1-ISR.
DMA1-IFCR.
DMA1-CCR1.
DMA1-CNDTR1.
DMA1-CPAR1.
DMA1-CMAR1.
DMA1-CCR2.
DMA1-CNDTR2.
DMA1-CPAR2.
DMA1-CMAR2.
DMA1-CCR3.
DMA1-CNDTR3.
DMA1-CPAR3.
DMA1-CMAR3.
DMA1-CCR4.
DMA1-CNDTR4.
DMA1-CPAR4.
DMA1-CMAR4.
DMA1-CCR5.
DMA1-CNDTR5.
DMA1-CPAR5.
DMA1-CMAR5.
DMA1-CCR6.
DMA1-CNDTR6.
DMA1-CPAR6.
DMA1-CMAR6.
DMA1-CCR7.
DMA1-CNDTR7.
DMA1-CPAR7.
DMA1-CMAR7.
;

$40026400 constant DMA2 ( Direct memory access controller ) 
DMA2 $0 + constant DMA2-ISR ( interrupt status register ) 
DMA2 $4 + constant DMA2-IFCR ( interrupt flag clear register ) 
DMA2 $8 + constant DMA2-CCR1 ( channel x configuration  register ) 
DMA2 $C + constant DMA2-CNDTR1 ( channel x number of data  register ) 
DMA2 $10 + constant DMA2-CPAR1 ( channel x peripheral address  register ) 
DMA2 $14 + constant DMA2-CMAR1 ( channel x memory address  register ) 
DMA2 $1C + constant DMA2-CCR2 ( channel x configuration  register ) 
DMA2 $20 + constant DMA2-CNDTR2 ( channel x number of data  register ) 
DMA2 $24 + constant DMA2-CPAR2 ( channel x peripheral address  register ) 
DMA2 $28 + constant DMA2-CMAR2 ( channel x memory address  register ) 
DMA2 $30 + constant DMA2-CCR3 ( channel x configuration  register ) 
DMA2 $34 + constant DMA2-CNDTR3 ( channel x number of data  register ) 
DMA2 $38 + constant DMA2-CPAR3 ( channel x peripheral address  register ) 
DMA2 $3C + constant DMA2-CMAR3 ( channel x memory address  register ) 
DMA2 $44 + constant DMA2-CCR4 ( channel x configuration  register ) 
DMA2 $48 + constant DMA2-CNDTR4 ( channel x number of data  register ) 
DMA2 $4C + constant DMA2-CPAR4 ( channel x peripheral address  register ) 
DMA2 $50 + constant DMA2-CMAR4 ( channel x memory address  register ) 
DMA2 $58 + constant DMA2-CCR5 ( channel x configuration  register ) 
DMA2 $5C + constant DMA2-CNDTR5 ( channel x number of data  register ) 
DMA2 $60 + constant DMA2-CPAR5 ( channel x peripheral address  register ) 
DMA2 $64 + constant DMA2-CMAR5 ( channel x memory address  register ) 
DMA2 $6C + constant DMA2-CCR6 ( channel x configuration  register ) 
DMA2 $70 + constant DMA2-CNDTR6 ( channel x number of data  register ) 
DMA2 $74 + constant DMA2-CPAR6 ( channel x peripheral address  register ) 
DMA2 $78 + constant DMA2-CMAR6 ( channel x memory address  register ) 
DMA2 $80 + constant DMA2-CCR7 ( channel x configuration  register ) 
DMA2 $84 + constant DMA2-CNDTR7 ( channel x number of data  register ) 
DMA2 $88 + constant DMA2-CPAR7 ( channel x peripheral address  register ) 
DMA2 $8C + constant DMA2-CMAR7 ( channel x memory address  register ) 
: DMA2-ISR. ." DMA2-ISR (read-only) $" DMA2-ISR @ hex. DMA2-ISR 1b. ;
: DMA2-IFCR. ." DMA2-IFCR (write-only) $" DMA2-IFCR @ hex. DMA2-IFCR 1b. ;
: DMA2-CCR1. ." DMA2-CCR1 (read-write) $" DMA2-CCR1 @ hex. DMA2-CCR1 1b. ;
: DMA2-CNDTR1. ." DMA2-CNDTR1 (read-write) $" DMA2-CNDTR1 @ hex. DMA2-CNDTR1 1b. ;
: DMA2-CPAR1. ." DMA2-CPAR1 (read-write) $" DMA2-CPAR1 @ hex. DMA2-CPAR1 1b. ;
: DMA2-CMAR1. ." DMA2-CMAR1 (read-write) $" DMA2-CMAR1 @ hex. DMA2-CMAR1 1b. ;
: DMA2-CCR2. ." DMA2-CCR2 (read-write) $" DMA2-CCR2 @ hex. DMA2-CCR2 1b. ;
: DMA2-CNDTR2. ." DMA2-CNDTR2 (read-write) $" DMA2-CNDTR2 @ hex. DMA2-CNDTR2 1b. ;
: DMA2-CPAR2. ." DMA2-CPAR2 (read-write) $" DMA2-CPAR2 @ hex. DMA2-CPAR2 1b. ;
: DMA2-CMAR2. ." DMA2-CMAR2 (read-write) $" DMA2-CMAR2 @ hex. DMA2-CMAR2 1b. ;
: DMA2-CCR3. ." DMA2-CCR3 (read-write) $" DMA2-CCR3 @ hex. DMA2-CCR3 1b. ;
: DMA2-CNDTR3. ." DMA2-CNDTR3 (read-write) $" DMA2-CNDTR3 @ hex. DMA2-CNDTR3 1b. ;
: DMA2-CPAR3. ." DMA2-CPAR3 (read-write) $" DMA2-CPAR3 @ hex. DMA2-CPAR3 1b. ;
: DMA2-CMAR3. ." DMA2-CMAR3 (read-write) $" DMA2-CMAR3 @ hex. DMA2-CMAR3 1b. ;
: DMA2-CCR4. ." DMA2-CCR4 (read-write) $" DMA2-CCR4 @ hex. DMA2-CCR4 1b. ;
: DMA2-CNDTR4. ." DMA2-CNDTR4 (read-write) $" DMA2-CNDTR4 @ hex. DMA2-CNDTR4 1b. ;
: DMA2-CPAR4. ." DMA2-CPAR4 (read-write) $" DMA2-CPAR4 @ hex. DMA2-CPAR4 1b. ;
: DMA2-CMAR4. ." DMA2-CMAR4 (read-write) $" DMA2-CMAR4 @ hex. DMA2-CMAR4 1b. ;
: DMA2-CCR5. ." DMA2-CCR5 (read-write) $" DMA2-CCR5 @ hex. DMA2-CCR5 1b. ;
: DMA2-CNDTR5. ." DMA2-CNDTR5 (read-write) $" DMA2-CNDTR5 @ hex. DMA2-CNDTR5 1b. ;
: DMA2-CPAR5. ." DMA2-CPAR5 (read-write) $" DMA2-CPAR5 @ hex. DMA2-CPAR5 1b. ;
: DMA2-CMAR5. ." DMA2-CMAR5 (read-write) $" DMA2-CMAR5 @ hex. DMA2-CMAR5 1b. ;
: DMA2-CCR6. ." DMA2-CCR6 (read-write) $" DMA2-CCR6 @ hex. DMA2-CCR6 1b. ;
: DMA2-CNDTR6. ." DMA2-CNDTR6 (read-write) $" DMA2-CNDTR6 @ hex. DMA2-CNDTR6 1b. ;
: DMA2-CPAR6. ." DMA2-CPAR6 (read-write) $" DMA2-CPAR6 @ hex. DMA2-CPAR6 1b. ;
: DMA2-CMAR6. ." DMA2-CMAR6 (read-write) $" DMA2-CMAR6 @ hex. DMA2-CMAR6 1b. ;
: DMA2-CCR7. ." DMA2-CCR7 (read-write) $" DMA2-CCR7 @ hex. DMA2-CCR7 1b. ;
: DMA2-CNDTR7. ." DMA2-CNDTR7 (read-write) $" DMA2-CNDTR7 @ hex. DMA2-CNDTR7 1b. ;
: DMA2-CPAR7. ." DMA2-CPAR7 (read-write) $" DMA2-CPAR7 @ hex. DMA2-CPAR7 1b. ;
: DMA2-CMAR7. ." DMA2-CMAR7 (read-write) $" DMA2-CMAR7 @ hex. DMA2-CMAR7 1b. ;
: DMA2.
DMA2-ISR.
DMA2-IFCR.
DMA2-CCR1.
DMA2-CNDTR1.
DMA2-CPAR1.
DMA2-CMAR1.
DMA2-CCR2.
DMA2-CNDTR2.
DMA2-CPAR2.
DMA2-CMAR2.
DMA2-CCR3.
DMA2-CNDTR3.
DMA2-CPAR3.
DMA2-CMAR3.
DMA2-CCR4.
DMA2-CNDTR4.
DMA2-CPAR4.
DMA2-CMAR4.
DMA2-CCR5.
DMA2-CNDTR5.
DMA2-CPAR5.
DMA2-CMAR5.
DMA2-CCR6.
DMA2-CNDTR6.
DMA2-CPAR6.
DMA2-CMAR6.
DMA2-CCR7.
DMA2-CNDTR7.
DMA2-CPAR7.
DMA2-CMAR7.
;

$40010400 constant EXTI ( External interrupt/event  controller ) 
EXTI $0 + constant EXTI-IMR ( IMR ) 
EXTI $4 + constant EXTI-EMR ( EMR ) 
EXTI $8 + constant EXTI-RTSR ( RTSR ) 
EXTI $C + constant EXTI-FTSR ( FTSR ) 
EXTI $10 + constant EXTI-SWIER ( SWIER ) 
EXTI $14 + constant EXTI-PR ( PR ) 
: EXTI-IMR. ." EXTI-IMR (read-write) $" EXTI-IMR @ hex. EXTI-IMR 1b. ;
: EXTI-EMR. ." EXTI-EMR (read-write) $" EXTI-EMR @ hex. EXTI-EMR 1b. ;
: EXTI-RTSR. ." EXTI-RTSR (read-write) $" EXTI-RTSR @ hex. EXTI-RTSR 1b. ;
: EXTI-FTSR. ." EXTI-FTSR (read-write) $" EXTI-FTSR @ hex. EXTI-FTSR 1b. ;
: EXTI-SWIER. ." EXTI-SWIER (read-write) $" EXTI-SWIER @ hex. EXTI-SWIER 1b. ;
: EXTI-PR. ." EXTI-PR (read-write) $" EXTI-PR @ hex. EXTI-PR 1b. ;
: EXTI.
EXTI-IMR.
EXTI-EMR.
EXTI-RTSR.
EXTI-FTSR.
EXTI-SWIER.
EXTI-PR.
;

$40023C00 constant Flash ( Flash ) 
Flash $0 + constant Flash-ACR ( Access control register ) 
Flash $4 + constant Flash-PECR ( Program/erase control register ) 
Flash $8 + constant Flash-PDKEYR ( Power down key register ) 
Flash $C + constant Flash-PEKEYR ( Program/erase key register ) 
Flash $10 + constant Flash-PRGKEYR ( Program memory key register ) 
Flash $14 + constant Flash-OPTKEYR ( Option byte key register ) 
Flash $18 + constant Flash-SR ( Status register ) 
Flash $1C + constant Flash-OBR ( Option byte register ) 
Flash $20 + constant Flash-WRPR1 ( Write protection register ) 
Flash $80 + constant Flash-WRPR2 ( Write protection register ) 
Flash $84 + constant Flash-WRPR3 ( Write protection register ) 
: Flash-ACR. ." Flash-ACR (read-write) $" Flash-ACR @ hex. Flash-ACR 1b. ;
: Flash-PECR. ." Flash-PECR (read-write) $" Flash-PECR @ hex. Flash-PECR 1b. ;
: Flash-PDKEYR. ." Flash-PDKEYR (write-only) $" Flash-PDKEYR @ hex. Flash-PDKEYR 1b. ;
: Flash-PEKEYR. ." Flash-PEKEYR (write-only) $" Flash-PEKEYR @ hex. Flash-PEKEYR 1b. ;
: Flash-PRGKEYR. ." Flash-PRGKEYR (write-only) $" Flash-PRGKEYR @ hex. Flash-PRGKEYR 1b. ;
: Flash-OPTKEYR. ." Flash-OPTKEYR (write-only) $" Flash-OPTKEYR @ hex. Flash-OPTKEYR 1b. ;
: Flash-SR. ." Flash-SR () $" Flash-SR @ hex. Flash-SR 1b. ;
: Flash-OBR. ." Flash-OBR (read-only) $" Flash-OBR @ hex. Flash-OBR 1b. ;
: Flash-WRPR1. ." Flash-WRPR1 (read-write) $" Flash-WRPR1 @ hex. Flash-WRPR1 1b. ;
: Flash-WRPR2. ." Flash-WRPR2 (read-write) $" Flash-WRPR2 @ hex. Flash-WRPR2 1b. ;
: Flash-WRPR3. ." Flash-WRPR3 (read-write) $" Flash-WRPR3 @ hex. Flash-WRPR3 1b. ;
: Flash.
Flash-ACR.
Flash-PECR.
Flash-PDKEYR.
Flash-PEKEYR.
Flash-PRGKEYR.
Flash-OPTKEYR.
Flash-SR.
Flash-OBR.
Flash-WRPR1.
Flash-WRPR2.
Flash-WRPR3.
;

$40020000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA-MODER ( GPIO port mode register ) 
GPIOA $4 + constant GPIOA-OTYPER ( GPIO port output type register ) 
GPIOA $8 + constant GPIOA-OSPEEDER ( GPIO port output speed  register ) 
GPIOA $C + constant GPIOA-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOA $10 + constant GPIOA-IDR ( GPIO port input data register ) 
GPIOA $14 + constant GPIOA-ODR ( GPIO port output data register ) 
GPIOA $18 + constant GPIOA-BSRR ( GPIO port bit set/reset  register ) 
GPIOA $1C + constant GPIOA-LCKR ( GPIO port configuration lock  register ) 
GPIOA $20 + constant GPIOA-AFRL ( AFRL ) 
GPIOA $24 + constant GPIOA-AFRH ( GPIO alternate function high  register ) 
: GPIOA-MODER. ." GPIOA-MODER (read-write) $" GPIOA-MODER @ hex. GPIOA-MODER 1b. ;
: GPIOA-OTYPER. ." GPIOA-OTYPER (read-write) $" GPIOA-OTYPER @ hex. GPIOA-OTYPER 1b. ;
: GPIOA-OSPEEDER. ." GPIOA-OSPEEDER (read-write) $" GPIOA-OSPEEDER @ hex. GPIOA-OSPEEDER 1b. ;
: GPIOA-PUPDR. ." GPIOA-PUPDR (read-write) $" GPIOA-PUPDR @ hex. GPIOA-PUPDR 1b. ;
: GPIOA-IDR. ." GPIOA-IDR (read-only) $" GPIOA-IDR @ hex. GPIOA-IDR 1b. ;
: GPIOA-ODR. ." GPIOA-ODR (read-write) $" GPIOA-ODR @ hex. GPIOA-ODR 1b. ;
: GPIOA-BSRR. ." GPIOA-BSRR (write-only) $" GPIOA-BSRR @ hex. GPIOA-BSRR 1b. ;
: GPIOA-LCKR. ." GPIOA-LCKR (read-write) $" GPIOA-LCKR @ hex. GPIOA-LCKR 1b. ;
: GPIOA-AFRL. ." GPIOA-AFRL (read-write) $" GPIOA-AFRL @ hex. GPIOA-AFRL 1b. ;
: GPIOA-AFRH. ." GPIOA-AFRH (read-write) $" GPIOA-AFRH @ hex. GPIOA-AFRH 1b. ;
: GPIOA.
GPIOA-MODER.
GPIOA-OTYPER.
GPIOA-OSPEEDER.
GPIOA-PUPDR.
GPIOA-IDR.
GPIOA-ODR.
GPIOA-BSRR.
GPIOA-LCKR.
GPIOA-AFRL.
GPIOA-AFRH.
;

$40020400 constant GPIOB ( General-purpose I/Os ) 
GPIOB $0 + constant GPIOB-MODER ( GPIO port mode register ) 
GPIOB $4 + constant GPIOB-OTYPER ( GPIO port output type register ) 
GPIOB $8 + constant GPIOB-OSPEEDER ( GPIO port output speed  register ) 
GPIOB $C + constant GPIOB-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOB $10 + constant GPIOB-IDR ( GPIO port input data register ) 
GPIOB $14 + constant GPIOB-ODR ( GPIO port output data register ) 
GPIOB $18 + constant GPIOB-BSRR ( GPIO port bit set/reset  register ) 
GPIOB $1C + constant GPIOB-LCKR ( GPIO port configuration lock  register ) 
GPIOB $20 + constant GPIOB-AFRL ( AFRL ) 
GPIOB $24 + constant GPIOB-AFRH ( GPIO alternate function high  register ) 
: GPIOB-MODER. ." GPIOB-MODER (read-write) $" GPIOB-MODER @ hex. GPIOB-MODER 1b. ;
: GPIOB-OTYPER. ." GPIOB-OTYPER (read-write) $" GPIOB-OTYPER @ hex. GPIOB-OTYPER 1b. ;
: GPIOB-OSPEEDER. ." GPIOB-OSPEEDER (read-write) $" GPIOB-OSPEEDER @ hex. GPIOB-OSPEEDER 1b. ;
: GPIOB-PUPDR. ." GPIOB-PUPDR (read-write) $" GPIOB-PUPDR @ hex. GPIOB-PUPDR 1b. ;
: GPIOB-IDR. ." GPIOB-IDR (read-only) $" GPIOB-IDR @ hex. GPIOB-IDR 1b. ;
: GPIOB-ODR. ." GPIOB-ODR (read-write) $" GPIOB-ODR @ hex. GPIOB-ODR 1b. ;
: GPIOB-BSRR. ." GPIOB-BSRR (write-only) $" GPIOB-BSRR @ hex. GPIOB-BSRR 1b. ;
: GPIOB-LCKR. ." GPIOB-LCKR (read-write) $" GPIOB-LCKR @ hex. GPIOB-LCKR 1b. ;
: GPIOB-AFRL. ." GPIOB-AFRL (read-write) $" GPIOB-AFRL @ hex. GPIOB-AFRL 1b. ;
: GPIOB-AFRH. ." GPIOB-AFRH (read-write) $" GPIOB-AFRH @ hex. GPIOB-AFRH 1b. ;
: GPIOB.
GPIOB-MODER.
GPIOB-OTYPER.
GPIOB-OSPEEDER.
GPIOB-PUPDR.
GPIOB-IDR.
GPIOB-ODR.
GPIOB-BSRR.
GPIOB-LCKR.
GPIOB-AFRL.
GPIOB-AFRH.
;

$40020800 constant GPIOC ( General-purpose I/Os ) 
GPIOC $0 + constant GPIOC-MODER ( GPIO port mode register ) 
GPIOC $4 + constant GPIOC-OTYPER ( GPIO port output type register ) 
GPIOC $8 + constant GPIOC-OSPEEDER ( GPIO port output speed  register ) 
GPIOC $C + constant GPIOC-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOC $10 + constant GPIOC-IDR ( GPIO port input data register ) 
GPIOC $14 + constant GPIOC-ODR ( GPIO port output data register ) 
GPIOC $18 + constant GPIOC-BSRR ( GPIO port bit set/reset  register ) 
GPIOC $1C + constant GPIOC-LCKR ( GPIO port configuration lock  register ) 
GPIOC $20 + constant GPIOC-AFRL ( AFRL ) 
GPIOC $24 + constant GPIOC-AFRH ( GPIO alternate function high  register ) 
: GPIOC-MODER. ." GPIOC-MODER (read-write) $" GPIOC-MODER @ hex. GPIOC-MODER 1b. ;
: GPIOC-OTYPER. ." GPIOC-OTYPER (read-write) $" GPIOC-OTYPER @ hex. GPIOC-OTYPER 1b. ;
: GPIOC-OSPEEDER. ." GPIOC-OSPEEDER (read-write) $" GPIOC-OSPEEDER @ hex. GPIOC-OSPEEDER 1b. ;
: GPIOC-PUPDR. ." GPIOC-PUPDR (read-write) $" GPIOC-PUPDR @ hex. GPIOC-PUPDR 1b. ;
: GPIOC-IDR. ." GPIOC-IDR (read-only) $" GPIOC-IDR @ hex. GPIOC-IDR 1b. ;
: GPIOC-ODR. ." GPIOC-ODR (read-write) $" GPIOC-ODR @ hex. GPIOC-ODR 1b. ;
: GPIOC-BSRR. ." GPIOC-BSRR (write-only) $" GPIOC-BSRR @ hex. GPIOC-BSRR 1b. ;
: GPIOC-LCKR. ." GPIOC-LCKR (read-write) $" GPIOC-LCKR @ hex. GPIOC-LCKR 1b. ;
: GPIOC-AFRL. ." GPIOC-AFRL (read-write) $" GPIOC-AFRL @ hex. GPIOC-AFRL 1b. ;
: GPIOC-AFRH. ." GPIOC-AFRH (read-write) $" GPIOC-AFRH @ hex. GPIOC-AFRH 1b. ;
: GPIOC.
GPIOC-MODER.
GPIOC-OTYPER.
GPIOC-OSPEEDER.
GPIOC-PUPDR.
GPIOC-IDR.
GPIOC-ODR.
GPIOC-BSRR.
GPIOC-LCKR.
GPIOC-AFRL.
GPIOC-AFRH.
;

$40020C00 constant GPIOD ( General-purpose I/Os ) 
GPIOD $0 + constant GPIOD-MODER ( GPIO port mode register ) 
GPIOD $4 + constant GPIOD-OTYPER ( GPIO port output type register ) 
GPIOD $8 + constant GPIOD-OSPEEDER ( GPIO port output speed  register ) 
GPIOD $C + constant GPIOD-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOD $10 + constant GPIOD-IDR ( GPIO port input data register ) 
GPIOD $14 + constant GPIOD-ODR ( GPIO port output data register ) 
GPIOD $18 + constant GPIOD-BSRR ( GPIO port bit set/reset  register ) 
GPIOD $1C + constant GPIOD-LCKR ( GPIO port configuration lock  register ) 
GPIOD $20 + constant GPIOD-AFRL ( AFRL ) 
GPIOD $24 + constant GPIOD-AFRH ( GPIO alternate function high  register ) 
: GPIOD-MODER. ." GPIOD-MODER (read-write) $" GPIOD-MODER @ hex. GPIOD-MODER 1b. ;
: GPIOD-OTYPER. ." GPIOD-OTYPER (read-write) $" GPIOD-OTYPER @ hex. GPIOD-OTYPER 1b. ;
: GPIOD-OSPEEDER. ." GPIOD-OSPEEDER (read-write) $" GPIOD-OSPEEDER @ hex. GPIOD-OSPEEDER 1b. ;
: GPIOD-PUPDR. ." GPIOD-PUPDR (read-write) $" GPIOD-PUPDR @ hex. GPIOD-PUPDR 1b. ;
: GPIOD-IDR. ." GPIOD-IDR (read-only) $" GPIOD-IDR @ hex. GPIOD-IDR 1b. ;
: GPIOD-ODR. ." GPIOD-ODR (read-write) $" GPIOD-ODR @ hex. GPIOD-ODR 1b. ;
: GPIOD-BSRR. ." GPIOD-BSRR (write-only) $" GPIOD-BSRR @ hex. GPIOD-BSRR 1b. ;
: GPIOD-LCKR. ." GPIOD-LCKR (read-write) $" GPIOD-LCKR @ hex. GPIOD-LCKR 1b. ;
: GPIOD-AFRL. ." GPIOD-AFRL (read-write) $" GPIOD-AFRL @ hex. GPIOD-AFRL 1b. ;
: GPIOD-AFRH. ." GPIOD-AFRH (read-write) $" GPIOD-AFRH @ hex. GPIOD-AFRH 1b. ;
: GPIOD.
GPIOD-MODER.
GPIOD-OTYPER.
GPIOD-OSPEEDER.
GPIOD-PUPDR.
GPIOD-IDR.
GPIOD-ODR.
GPIOD-BSRR.
GPIOD-LCKR.
GPIOD-AFRL.
GPIOD-AFRH.
;

$40021000 constant GPIOE ( General-purpose I/Os ) 
GPIOE $0 + constant GPIOE-MODER ( GPIO port mode register ) 
GPIOE $4 + constant GPIOE-OTYPER ( GPIO port output type register ) 
GPIOE $8 + constant GPIOE-OSPEEDER ( GPIO port output speed  register ) 
GPIOE $C + constant GPIOE-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOE $10 + constant GPIOE-IDR ( GPIO port input data register ) 
GPIOE $14 + constant GPIOE-ODR ( GPIO port output data register ) 
GPIOE $18 + constant GPIOE-BSRR ( GPIO port bit set/reset  register ) 
GPIOE $1C + constant GPIOE-LCKR ( GPIO port configuration lock  register ) 
GPIOE $20 + constant GPIOE-AFRL ( AFRL ) 
GPIOE $24 + constant GPIOE-AFRH ( GPIO alternate function high  register ) 
: GPIOE-MODER. ." GPIOE-MODER (read-write) $" GPIOE-MODER @ hex. GPIOE-MODER 1b. ;
: GPIOE-OTYPER. ." GPIOE-OTYPER (read-write) $" GPIOE-OTYPER @ hex. GPIOE-OTYPER 1b. ;
: GPIOE-OSPEEDER. ." GPIOE-OSPEEDER (read-write) $" GPIOE-OSPEEDER @ hex. GPIOE-OSPEEDER 1b. ;
: GPIOE-PUPDR. ." GPIOE-PUPDR (read-write) $" GPIOE-PUPDR @ hex. GPIOE-PUPDR 1b. ;
: GPIOE-IDR. ." GPIOE-IDR (read-only) $" GPIOE-IDR @ hex. GPIOE-IDR 1b. ;
: GPIOE-ODR. ." GPIOE-ODR (read-write) $" GPIOE-ODR @ hex. GPIOE-ODR 1b. ;
: GPIOE-BSRR. ." GPIOE-BSRR (write-only) $" GPIOE-BSRR @ hex. GPIOE-BSRR 1b. ;
: GPIOE-LCKR. ." GPIOE-LCKR (read-write) $" GPIOE-LCKR @ hex. GPIOE-LCKR 1b. ;
: GPIOE-AFRL. ." GPIOE-AFRL (read-write) $" GPIOE-AFRL @ hex. GPIOE-AFRL 1b. ;
: GPIOE-AFRH. ." GPIOE-AFRH (read-write) $" GPIOE-AFRH @ hex. GPIOE-AFRH 1b. ;
: GPIOE.
GPIOE-MODER.
GPIOE-OTYPER.
GPIOE-OSPEEDER.
GPIOE-PUPDR.
GPIOE-IDR.
GPIOE-ODR.
GPIOE-BSRR.
GPIOE-LCKR.
GPIOE-AFRL.
GPIOE-AFRH.
;

$40021800 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF-MODER ( GPIO port mode register ) 
GPIOF $4 + constant GPIOF-OTYPER ( GPIO port output type register ) 
GPIOF $8 + constant GPIOF-OSPEEDER ( GPIO port output speed  register ) 
GPIOF $C + constant GPIOF-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOF $10 + constant GPIOF-IDR ( GPIO port input data register ) 
GPIOF $14 + constant GPIOF-ODR ( GPIO port output data register ) 
GPIOF $18 + constant GPIOF-BSRR ( GPIO port bit set/reset  register ) 
GPIOF $1C + constant GPIOF-LCKR ( GPIO port configuration lock  register ) 
GPIOF $20 + constant GPIOF-AFRL ( AFRL ) 
GPIOF $24 + constant GPIOF-AFRH ( GPIO alternate function high  register ) 
: GPIOF-MODER. ." GPIOF-MODER (read-write) $" GPIOF-MODER @ hex. GPIOF-MODER 1b. ;
: GPIOF-OTYPER. ." GPIOF-OTYPER (read-write) $" GPIOF-OTYPER @ hex. GPIOF-OTYPER 1b. ;
: GPIOF-OSPEEDER. ." GPIOF-OSPEEDER (read-write) $" GPIOF-OSPEEDER @ hex. GPIOF-OSPEEDER 1b. ;
: GPIOF-PUPDR. ." GPIOF-PUPDR (read-write) $" GPIOF-PUPDR @ hex. GPIOF-PUPDR 1b. ;
: GPIOF-IDR. ." GPIOF-IDR (read-only) $" GPIOF-IDR @ hex. GPIOF-IDR 1b. ;
: GPIOF-ODR. ." GPIOF-ODR (read-write) $" GPIOF-ODR @ hex. GPIOF-ODR 1b. ;
: GPIOF-BSRR. ." GPIOF-BSRR (write-only) $" GPIOF-BSRR @ hex. GPIOF-BSRR 1b. ;
: GPIOF-LCKR. ." GPIOF-LCKR (read-write) $" GPIOF-LCKR @ hex. GPIOF-LCKR 1b. ;
: GPIOF-AFRL. ." GPIOF-AFRL (read-write) $" GPIOF-AFRL @ hex. GPIOF-AFRL 1b. ;
: GPIOF-AFRH. ." GPIOF-AFRH (read-write) $" GPIOF-AFRH @ hex. GPIOF-AFRH 1b. ;
: GPIOF.
GPIOF-MODER.
GPIOF-OTYPER.
GPIOF-OSPEEDER.
GPIOF-PUPDR.
GPIOF-IDR.
GPIOF-ODR.
GPIOF-BSRR.
GPIOF-LCKR.
GPIOF-AFRL.
GPIOF-AFRH.
;

$40021C00 constant GPIOG ( General-purpose I/Os ) 
GPIOG $0 + constant GPIOG-MODER ( GPIO port mode register ) 
GPIOG $4 + constant GPIOG-OTYPER ( GPIO port output type register ) 
GPIOG $8 + constant GPIOG-OSPEEDER ( GPIO port output speed  register ) 
GPIOG $C + constant GPIOG-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOG $10 + constant GPIOG-IDR ( GPIO port input data register ) 
GPIOG $14 + constant GPIOG-ODR ( GPIO port output data register ) 
GPIOG $18 + constant GPIOG-BSRR ( GPIO port bit set/reset  register ) 
GPIOG $1C + constant GPIOG-LCKR ( GPIO port configuration lock  register ) 
GPIOG $20 + constant GPIOG-AFRL ( AFRL ) 
GPIOG $24 + constant GPIOG-AFRH ( GPIO alternate function high  register ) 
: GPIOG-MODER. ." GPIOG-MODER (read-write) $" GPIOG-MODER @ hex. GPIOG-MODER 1b. ;
: GPIOG-OTYPER. ." GPIOG-OTYPER (read-write) $" GPIOG-OTYPER @ hex. GPIOG-OTYPER 1b. ;
: GPIOG-OSPEEDER. ." GPIOG-OSPEEDER (read-write) $" GPIOG-OSPEEDER @ hex. GPIOG-OSPEEDER 1b. ;
: GPIOG-PUPDR. ." GPIOG-PUPDR (read-write) $" GPIOG-PUPDR @ hex. GPIOG-PUPDR 1b. ;
: GPIOG-IDR. ." GPIOG-IDR (read-only) $" GPIOG-IDR @ hex. GPIOG-IDR 1b. ;
: GPIOG-ODR. ." GPIOG-ODR (read-write) $" GPIOG-ODR @ hex. GPIOG-ODR 1b. ;
: GPIOG-BSRR. ." GPIOG-BSRR (write-only) $" GPIOG-BSRR @ hex. GPIOG-BSRR 1b. ;
: GPIOG-LCKR. ." GPIOG-LCKR (read-write) $" GPIOG-LCKR @ hex. GPIOG-LCKR 1b. ;
: GPIOG-AFRL. ." GPIOG-AFRL (read-write) $" GPIOG-AFRL @ hex. GPIOG-AFRL 1b. ;
: GPIOG-AFRH. ." GPIOG-AFRH (read-write) $" GPIOG-AFRH @ hex. GPIOG-AFRH 1b. ;
: GPIOG.
GPIOG-MODER.
GPIOG-OTYPER.
GPIOG-OSPEEDER.
GPIOG-PUPDR.
GPIOG-IDR.
GPIOG-ODR.
GPIOG-BSRR.
GPIOG-LCKR.
GPIOG-AFRL.
GPIOG-AFRH.
;

$40021400 constant GPIOH ( General-purpose I/Os ) 
GPIOH $0 + constant GPIOH-MODER ( GPIO port mode register ) 
GPIOH $4 + constant GPIOH-OTYPER ( GPIO port output type register ) 
GPIOH $8 + constant GPIOH-OSPEEDER ( GPIO port output speed  register ) 
GPIOH $C + constant GPIOH-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOH $10 + constant GPIOH-IDR ( GPIO port input data register ) 
GPIOH $14 + constant GPIOH-ODR ( GPIO port output data register ) 
GPIOH $18 + constant GPIOH-BSRR ( GPIO port bit set/reset  register ) 
GPIOH $1C + constant GPIOH-LCKR ( GPIO port configuration lock  register ) 
GPIOH $20 + constant GPIOH-AFRL ( AFRL ) 
GPIOH $24 + constant GPIOH-AFRH ( GPIO alternate function high  register ) 
: GPIOH-MODER. ." GPIOH-MODER (read-write) $" GPIOH-MODER @ hex. GPIOH-MODER 1b. ;
: GPIOH-OTYPER. ." GPIOH-OTYPER (read-write) $" GPIOH-OTYPER @ hex. GPIOH-OTYPER 1b. ;
: GPIOH-OSPEEDER. ." GPIOH-OSPEEDER (read-write) $" GPIOH-OSPEEDER @ hex. GPIOH-OSPEEDER 1b. ;
: GPIOH-PUPDR. ." GPIOH-PUPDR (read-write) $" GPIOH-PUPDR @ hex. GPIOH-PUPDR 1b. ;
: GPIOH-IDR. ." GPIOH-IDR (read-only) $" GPIOH-IDR @ hex. GPIOH-IDR 1b. ;
: GPIOH-ODR. ." GPIOH-ODR (read-write) $" GPIOH-ODR @ hex. GPIOH-ODR 1b. ;
: GPIOH-BSRR. ." GPIOH-BSRR (write-only) $" GPIOH-BSRR @ hex. GPIOH-BSRR 1b. ;
: GPIOH-LCKR. ." GPIOH-LCKR (read-write) $" GPIOH-LCKR @ hex. GPIOH-LCKR 1b. ;
: GPIOH-AFRL. ." GPIOH-AFRL (read-write) $" GPIOH-AFRL @ hex. GPIOH-AFRL 1b. ;
: GPIOH-AFRH. ." GPIOH-AFRH (read-write) $" GPIOH-AFRH @ hex. GPIOH-AFRH 1b. ;
: GPIOH.
GPIOH-MODER.
GPIOH-OTYPER.
GPIOH-OSPEEDER.
GPIOH-PUPDR.
GPIOH-IDR.
GPIOH-ODR.
GPIOH-BSRR.
GPIOH-LCKR.
GPIOH-AFRL.
GPIOH-AFRH.
;

$40005400 constant I2C1 ( Inter-integrated circuit ) 
I2C1 $0 + constant I2C1-CR1 ( CR1 ) 
I2C1 $4 + constant I2C1-CR2 ( CR2 ) 
I2C1 $8 + constant I2C1-OAR1 ( OAR1 ) 
I2C1 $C + constant I2C1-OAR2 ( OAR2 ) 
I2C1 $10 + constant I2C1-DR ( DR ) 
I2C1 $14 + constant I2C1-SR1 ( SR1 ) 
I2C1 $18 + constant I2C1-SR2 ( SR2 ) 
I2C1 $1C + constant I2C1-CCR ( CCR ) 
I2C1 $20 + constant I2C1-TRISE ( TRISE ) 
: I2C1-CR1. ." I2C1-CR1 (read-write) $" I2C1-CR1 @ hex. I2C1-CR1 1b. ;
: I2C1-CR2. ." I2C1-CR2 (read-write) $" I2C1-CR2 @ hex. I2C1-CR2 1b. ;
: I2C1-OAR1. ." I2C1-OAR1 (read-write) $" I2C1-OAR1 @ hex. I2C1-OAR1 1b. ;
: I2C1-OAR2. ." I2C1-OAR2 (read-write) $" I2C1-OAR2 @ hex. I2C1-OAR2 1b. ;
: I2C1-DR. ." I2C1-DR (read-write) $" I2C1-DR @ hex. I2C1-DR 1b. ;
: I2C1-SR1. ." I2C1-SR1 () $" I2C1-SR1 @ hex. I2C1-SR1 1b. ;
: I2C1-SR2. ." I2C1-SR2 (read-only) $" I2C1-SR2 @ hex. I2C1-SR2 1b. ;
: I2C1-CCR. ." I2C1-CCR (read-write) $" I2C1-CCR @ hex. I2C1-CCR 1b. ;
: I2C1-TRISE. ." I2C1-TRISE (read-write) $" I2C1-TRISE @ hex. I2C1-TRISE 1b. ;
: I2C1.
I2C1-CR1.
I2C1-CR2.
I2C1-OAR1.
I2C1-OAR2.
I2C1-DR.
I2C1-SR1.
I2C1-SR2.
I2C1-CCR.
I2C1-TRISE.
;

$40005800 constant I2C2 ( Inter-integrated circuit ) 
I2C2 $0 + constant I2C2-CR1 ( CR1 ) 
I2C2 $4 + constant I2C2-CR2 ( CR2 ) 
I2C2 $8 + constant I2C2-OAR1 ( OAR1 ) 
I2C2 $C + constant I2C2-OAR2 ( OAR2 ) 
I2C2 $10 + constant I2C2-DR ( DR ) 
I2C2 $14 + constant I2C2-SR1 ( SR1 ) 
I2C2 $18 + constant I2C2-SR2 ( SR2 ) 
I2C2 $1C + constant I2C2-CCR ( CCR ) 
I2C2 $20 + constant I2C2-TRISE ( TRISE ) 
: I2C2-CR1. ." I2C2-CR1 (read-write) $" I2C2-CR1 @ hex. I2C2-CR1 1b. ;
: I2C2-CR2. ." I2C2-CR2 (read-write) $" I2C2-CR2 @ hex. I2C2-CR2 1b. ;
: I2C2-OAR1. ." I2C2-OAR1 (read-write) $" I2C2-OAR1 @ hex. I2C2-OAR1 1b. ;
: I2C2-OAR2. ." I2C2-OAR2 (read-write) $" I2C2-OAR2 @ hex. I2C2-OAR2 1b. ;
: I2C2-DR. ." I2C2-DR (read-write) $" I2C2-DR @ hex. I2C2-DR 1b. ;
: I2C2-SR1. ." I2C2-SR1 () $" I2C2-SR1 @ hex. I2C2-SR1 1b. ;
: I2C2-SR2. ." I2C2-SR2 (read-only) $" I2C2-SR2 @ hex. I2C2-SR2 1b. ;
: I2C2-CCR. ." I2C2-CCR (read-write) $" I2C2-CCR @ hex. I2C2-CCR 1b. ;
: I2C2-TRISE. ." I2C2-TRISE (read-write) $" I2C2-TRISE @ hex. I2C2-TRISE 1b. ;
: I2C2.
I2C2-CR1.
I2C2-CR2.
I2C2-OAR1.
I2C2-OAR2.
I2C2-DR.
I2C2-SR1.
I2C2-SR2.
I2C2-CCR.
I2C2-TRISE.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG-KR ( Key register ) 
IWDG $4 + constant IWDG-PR ( Prescaler register ) 
IWDG $8 + constant IWDG-RLR ( Reload register ) 
IWDG $C + constant IWDG-SR ( Status register ) 
: IWDG-KR. ." IWDG-KR (write-only) $" IWDG-KR @ hex. IWDG-KR 1b. ;
: IWDG-PR. ." IWDG-PR (read-write) $" IWDG-PR @ hex. IWDG-PR 1b. ;
: IWDG-RLR. ." IWDG-RLR (read-write) $" IWDG-RLR @ hex. IWDG-RLR 1b. ;
: IWDG-SR. ." IWDG-SR (read-only) $" IWDG-SR @ hex. IWDG-SR 1b. ;
: IWDG.
IWDG-KR.
IWDG-PR.
IWDG-RLR.
IWDG-SR.
;

$40002400 constant LCD ( Liquid crystal display controller ) 
LCD $0 + constant LCD-CR ( control register ) 
LCD $4 + constant LCD-FCR ( frame control register ) 
LCD $8 + constant LCD-SR ( status register ) 
LCD $C + constant LCD-CLR ( clear register ) 
LCD $14 + constant LCD-RAM_COM0 ( display memory ) 
LCD $1C + constant LCD-RAM_COM1 ( display memory ) 
LCD $24 + constant LCD-RAM_COM2 ( display memory ) 
LCD $2C + constant LCD-RAM_COM3 ( display memory ) 
LCD $34 + constant LCD-RAM_COM4 ( display memory ) 
LCD $3C + constant LCD-RAM_COM5 ( display memory ) 
LCD $44 + constant LCD-RAM_COM6 ( display memory ) 
LCD $4C + constant LCD-RAM_COM7 ( display memory ) 
: LCD-CR. ." LCD-CR (read-write) $" LCD-CR @ hex. LCD-CR 1b. ;
: LCD-FCR. ." LCD-FCR (read-write) $" LCD-FCR @ hex. LCD-FCR 1b. ;
: LCD-SR. ." LCD-SR () $" LCD-SR @ hex. LCD-SR 1b. ;
: LCD-CLR. ." LCD-CLR (write-only) $" LCD-CLR @ hex. LCD-CLR 1b. ;
: LCD-RAM_COM0. ." LCD-RAM_COM0 (read-write) $" LCD-RAM_COM0 @ hex. LCD-RAM_COM0 1b. ;
: LCD-RAM_COM1. ." LCD-RAM_COM1 (read-write) $" LCD-RAM_COM1 @ hex. LCD-RAM_COM1 1b. ;
: LCD-RAM_COM2. ." LCD-RAM_COM2 (read-write) $" LCD-RAM_COM2 @ hex. LCD-RAM_COM2 1b. ;
: LCD-RAM_COM3. ." LCD-RAM_COM3 (read-write) $" LCD-RAM_COM3 @ hex. LCD-RAM_COM3 1b. ;
: LCD-RAM_COM4. ." LCD-RAM_COM4 (read-write) $" LCD-RAM_COM4 @ hex. LCD-RAM_COM4 1b. ;
: LCD-RAM_COM5. ." LCD-RAM_COM5 (read-write) $" LCD-RAM_COM5 @ hex. LCD-RAM_COM5 1b. ;
: LCD-RAM_COM6. ." LCD-RAM_COM6 (read-write) $" LCD-RAM_COM6 @ hex. LCD-RAM_COM6 1b. ;
: LCD-RAM_COM7. ." LCD-RAM_COM7 (read-write) $" LCD-RAM_COM7 @ hex. LCD-RAM_COM7 1b. ;
: LCD.
LCD-CR.
LCD-FCR.
LCD-SR.
LCD-CLR.
LCD-RAM_COM0.
LCD-RAM_COM1.
LCD-RAM_COM2.
LCD-RAM_COM3.
LCD-RAM_COM4.
LCD-RAM_COM5.
LCD-RAM_COM6.
LCD-RAM_COM7.
;

$40007C5C constant OPAMP ( Operational amplifiers ) 
OPAMP $0 + constant OPAMP-CSR ( control/status register ) 
OPAMP $4 + constant OPAMP-OTR ( offset trimming register for normal  mode ) 
OPAMP $8 + constant OPAMP-LPOTR ( OPAMP offset trimming register for low power  mode ) 
: OPAMP-CSR. ." OPAMP-CSR (read-write) $" OPAMP-CSR @ hex. OPAMP-CSR 1b. ;
: OPAMP-OTR. ." OPAMP-OTR (read-write) $" OPAMP-OTR @ hex. OPAMP-OTR 1b. ;
: OPAMP-LPOTR. ." OPAMP-LPOTR (read-write) $" OPAMP-LPOTR @ hex. OPAMP-LPOTR 1b. ;
: OPAMP.
OPAMP-CSR.
OPAMP-OTR.
OPAMP-LPOTR.
;

$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR-CR ( power control register ) 
PWR $4 + constant PWR-CSR ( power control/status register ) 
: PWR-CR. ." PWR-CR (read-write) $" PWR-CR @ hex. PWR-CR 1b. ;
: PWR-CSR. ." PWR-CSR () $" PWR-CSR @ hex. PWR-CSR 1b. ;
: PWR.
PWR-CR.
PWR-CSR.
;

$40023800 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC-CR ( Clock control register ) 
RCC $4 + constant RCC-ICSCR ( Internal clock sources calibration  register ) 
RCC $8 + constant RCC-CFGR ( Clock configuration register ) 
RCC $C + constant RCC-CIR ( Clock interrupt register ) 
RCC $10 + constant RCC-AHBRSTR ( AHB peripheral reset register ) 
RCC $14 + constant RCC-APB2RSTR ( APB2 peripheral reset register ) 
RCC $18 + constant RCC-APB1RSTR ( APB1 peripheral reset register ) 
RCC $1C + constant RCC-AHBENR ( AHB peripheral clock enable  register ) 
RCC $20 + constant RCC-APB2ENR ( APB2 peripheral clock enable  register ) 
RCC $24 + constant RCC-APB1ENR ( APB1 peripheral clock enable  register ) 
RCC $28 + constant RCC-AHBLPENR ( AHB peripheral clock enable in low power  mode register ) 
RCC $2C + constant RCC-APB2LPENR ( APB2 peripheral clock enable in low power  mode register ) 
RCC $30 + constant RCC-APB1LPENR ( APB1 peripheral clock enable in low power  mode register ) 
RCC $34 + constant RCC-CSR ( Control/status register ) 
: RCC-CR. ." RCC-CR () $" RCC-CR @ hex. RCC-CR 1b. ;
: RCC-ICSCR. ." RCC-ICSCR () $" RCC-ICSCR @ hex. RCC-ICSCR 1b. ;
: RCC-CFGR. ." RCC-CFGR () $" RCC-CFGR @ hex. RCC-CFGR 1b. ;
: RCC-CIR. ." RCC-CIR () $" RCC-CIR @ hex. RCC-CIR 1b. ;
: RCC-AHBRSTR. ." RCC-AHBRSTR (read-write) $" RCC-AHBRSTR @ hex. RCC-AHBRSTR 1b. ;
: RCC-APB2RSTR. ." RCC-APB2RSTR (read-write) $" RCC-APB2RSTR @ hex. RCC-APB2RSTR 1b. ;
: RCC-APB1RSTR. ." RCC-APB1RSTR (read-write) $" RCC-APB1RSTR @ hex. RCC-APB1RSTR 1b. ;
: RCC-AHBENR. ." RCC-AHBENR (read-write) $" RCC-AHBENR @ hex. RCC-AHBENR 1b. ;
: RCC-APB2ENR. ." RCC-APB2ENR (read-write) $" RCC-APB2ENR @ hex. RCC-APB2ENR 1b. ;
: RCC-APB1ENR. ." RCC-APB1ENR (read-write) $" RCC-APB1ENR @ hex. RCC-APB1ENR 1b. ;
: RCC-AHBLPENR. ." RCC-AHBLPENR (read-write) $" RCC-AHBLPENR @ hex. RCC-AHBLPENR 1b. ;
: RCC-APB2LPENR. ." RCC-APB2LPENR (read-write) $" RCC-APB2LPENR @ hex. RCC-APB2LPENR 1b. ;
: RCC-APB1LPENR. ." RCC-APB1LPENR (read-write) $" RCC-APB1LPENR @ hex. RCC-APB1LPENR 1b. ;
: RCC-CSR. ." RCC-CSR () $" RCC-CSR @ hex. RCC-CSR 1b. ;
: RCC.
RCC-CR.
RCC-ICSCR.
RCC-CFGR.
RCC-CIR.
RCC-AHBRSTR.
RCC-APB2RSTR.
RCC-APB1RSTR.
RCC-AHBENR.
RCC-APB2ENR.
RCC-APB1ENR.
RCC-AHBLPENR.
RCC-APB2LPENR.
RCC-APB1LPENR.
RCC-CSR.
;

$40007C04 constant RI ( Routing interface ) 
RI $0 + constant RI-ICR ( RI input capture register ) 
RI $4 + constant RI-ASCR1 ( RI analog switches control register  1 ) 
RI $8 + constant RI-ASCR2 ( RI analog switches control register  2 ) 
RI $C + constant RI-HYSCR1 ( RI hysteresis control register  1 ) 
RI $10 + constant RI-HYSCR2 ( RI hysteresis control register  2 ) 
RI $14 + constant RI-HYSCR3 ( RI hysteresis control register  3 ) 
RI $18 + constant RI-HYSCR4 ( Hysteresis control register ) 
RI $1C + constant RI-ASMR1 ( Analog switch mode register ) 
RI $20 + constant RI-CMR1 ( Channel mask register ) 
RI $24 + constant RI-CICR1 ( Channel identification for capture  register ) 
RI $28 + constant RI-ASMR2 ( Analog switch mode register ) 
RI $2C + constant RI-CMR2 ( Channel mask register ) 
RI $30 + constant RI-CICR2 ( Channel identification for capture  register ) 
RI $34 + constant RI-ASMR3 ( Analog switch mode register ) 
RI $38 + constant RI-CMR3 ( Channel mask register ) 
RI $3C + constant RI-CICR3 ( Channel identification for capture  register ) 
RI $40 + constant RI-ASMR4 ( Analog switch mode register ) 
RI $44 + constant RI-CMR4 ( Channel mask register ) 
RI $48 + constant RI-CICR4 ( Channel identification for capture  register ) 
RI $4C + constant RI-ASMR5 ( Analog switch mode register ) 
RI $50 + constant RI-CMR5 ( Channel mask register ) 
RI $54 + constant RI-CICR5 ( Channel identification for capture  register ) 
: RI-ICR. ." RI-ICR (read-write) $" RI-ICR @ hex. RI-ICR 1b. ;
: RI-ASCR1. ." RI-ASCR1 (read-write) $" RI-ASCR1 @ hex. RI-ASCR1 1b. ;
: RI-ASCR2. ." RI-ASCR2 (read-write) $" RI-ASCR2 @ hex. RI-ASCR2 1b. ;
: RI-HYSCR1. ." RI-HYSCR1 (read-write) $" RI-HYSCR1 @ hex. RI-HYSCR1 1b. ;
: RI-HYSCR2. ." RI-HYSCR2 (read-write) $" RI-HYSCR2 @ hex. RI-HYSCR2 1b. ;
: RI-HYSCR3. ." RI-HYSCR3 (read-write) $" RI-HYSCR3 @ hex. RI-HYSCR3 1b. ;
: RI-HYSCR4. ." RI-HYSCR4 (read-write) $" RI-HYSCR4 @ hex. RI-HYSCR4 1b. ;
: RI-ASMR1. ." RI-ASMR1 (read-write) $" RI-ASMR1 @ hex. RI-ASMR1 1b. ;
: RI-CMR1. ." RI-CMR1 (read-write) $" RI-CMR1 @ hex. RI-CMR1 1b. ;
: RI-CICR1. ." RI-CICR1 (read-write) $" RI-CICR1 @ hex. RI-CICR1 1b. ;
: RI-ASMR2. ." RI-ASMR2 (read-write) $" RI-ASMR2 @ hex. RI-ASMR2 1b. ;
: RI-CMR2. ." RI-CMR2 (read-write) $" RI-CMR2 @ hex. RI-CMR2 1b. ;
: RI-CICR2. ." RI-CICR2 (read-write) $" RI-CICR2 @ hex. RI-CICR2 1b. ;
: RI-ASMR3. ." RI-ASMR3 (read-write) $" RI-ASMR3 @ hex. RI-ASMR3 1b. ;
: RI-CMR3. ." RI-CMR3 (read-write) $" RI-CMR3 @ hex. RI-CMR3 1b. ;
: RI-CICR3. ." RI-CICR3 (read-write) $" RI-CICR3 @ hex. RI-CICR3 1b. ;
: RI-ASMR4. ." RI-ASMR4 (read-write) $" RI-ASMR4 @ hex. RI-ASMR4 1b. ;
: RI-CMR4. ." RI-CMR4 (read-write) $" RI-CMR4 @ hex. RI-CMR4 1b. ;
: RI-CICR4. ." RI-CICR4 (read-write) $" RI-CICR4 @ hex. RI-CICR4 1b. ;
: RI-ASMR5. ." RI-ASMR5 (read-write) $" RI-ASMR5 @ hex. RI-ASMR5 1b. ;
: RI-CMR5. ." RI-CMR5 (read-write) $" RI-CMR5 @ hex. RI-CMR5 1b. ;
: RI-CICR5. ." RI-CICR5 (read-write) $" RI-CICR5 @ hex. RI-CICR5 1b. ;
: RI.
RI-ICR.
RI-ASCR1.
RI-ASCR2.
RI-HYSCR1.
RI-HYSCR2.
RI-HYSCR3.
RI-HYSCR4.
RI-ASMR1.
RI-CMR1.
RI-CICR1.
RI-ASMR2.
RI-CMR2.
RI-CICR2.
RI-ASMR3.
RI-CMR3.
RI-CICR3.
RI-ASMR4.
RI-CMR4.
RI-CICR4.
RI-ASMR5.
RI-CMR5.
RI-CICR5.
;

$40002800 constant RTC ( Real-time clock ) 
RTC $0 + constant RTC-TR ( time register ) 
RTC $4 + constant RTC-DR ( date register ) 
RTC $8 + constant RTC-CR ( control register ) 
RTC $C + constant RTC-ISR ( initialization and status  register ) 
RTC $10 + constant RTC-PRER ( prescaler register ) 
RTC $14 + constant RTC-WUTR ( wakeup timer register ) 
RTC $18 + constant RTC-CALIBR ( calibration register ) 
RTC $1C + constant RTC-ALRMAR ( alarm A register ) 
RTC $20 + constant RTC-ALRMBR ( alarm B register ) 
RTC $24 + constant RTC-WPR ( write protection register ) 
RTC $28 + constant RTC-SSR ( sub second register ) 
RTC $2C + constant RTC-SHIFTR ( shift control register ) 
RTC $30 + constant RTC-TSTR ( TSTR ) 
RTC $34 + constant RTC-TSDR ( time stamp date register ) 
RTC $38 + constant RTC-TSSSR ( timestamp sub second register ) 
RTC $3C + constant RTC-CALR ( calibration register ) 
RTC $40 + constant RTC-TAFCR ( tamper and alternate function configuration  register ) 
RTC $44 + constant RTC-ALRMASSR ( alarm A sub second register ) 
RTC $48 + constant RTC-ALRMBSSR ( alarm B sub second register ) 
RTC $50 + constant RTC-BKP0R ( backup register ) 
RTC $54 + constant RTC-BKP1R ( backup register ) 
RTC $58 + constant RTC-BKP2R ( backup register ) 
RTC $5C + constant RTC-BKP3R ( backup register ) 
RTC $60 + constant RTC-BKP4R ( backup register ) 
RTC $64 + constant RTC-BKP5R ( backup register ) 
RTC $68 + constant RTC-BKP6R ( backup register ) 
RTC $6C + constant RTC-BKP7R ( backup register ) 
RTC $70 + constant RTC-BKP8R ( backup register ) 
RTC $74 + constant RTC-BKP9R ( backup register ) 
RTC $78 + constant RTC-BKP10R ( backup register ) 
RTC $7C + constant RTC-BKP11R ( backup register ) 
RTC $80 + constant RTC-BKP12R ( backup register ) 
RTC $84 + constant RTC-BKP13R ( backup register ) 
RTC $88 + constant RTC-BKP14R ( backup register ) 
RTC $8C + constant RTC-BKP15R ( backup register ) 
RTC $90 + constant RTC-BKP16R ( backup register ) 
RTC $94 + constant RTC-BKP17R ( backup register ) 
RTC $98 + constant RTC-BKP18R ( backup register ) 
RTC $9C + constant RTC-BKP19R ( backup register ) 
RTC $A0 + constant RTC-BKP20R ( backup register ) 
RTC $A4 + constant RTC-BKP21R ( backup register ) 
RTC $A8 + constant RTC-BKP22R ( backup register ) 
RTC $AC + constant RTC-BKP23R ( backup register ) 
RTC $B0 + constant RTC-BKP24R ( backup register ) 
RTC $B4 + constant RTC-BKP25R ( backup register ) 
RTC $B8 + constant RTC-BKP26R ( backup register ) 
RTC $BC + constant RTC-BKP27R ( backup register ) 
RTC $C0 + constant RTC-BKP28R ( backup register ) 
RTC $C4 + constant RTC-BKP29R ( backup register ) 
RTC $C8 + constant RTC-BKP30R ( backup register ) 
RTC $CC + constant RTC-BKP31R ( backup register ) 
: RTC-TR. ." RTC-TR (read-write) $" RTC-TR @ hex. RTC-TR 1b. ;
: RTC-DR. ." RTC-DR (read-write) $" RTC-DR @ hex. RTC-DR 1b. ;
: RTC-CR. ." RTC-CR (read-write) $" RTC-CR @ hex. RTC-CR 1b. ;
: RTC-ISR. ." RTC-ISR () $" RTC-ISR @ hex. RTC-ISR 1b. ;
: RTC-PRER. ." RTC-PRER (read-write) $" RTC-PRER @ hex. RTC-PRER 1b. ;
: RTC-WUTR. ." RTC-WUTR (read-write) $" RTC-WUTR @ hex. RTC-WUTR 1b. ;
: RTC-CALIBR. ." RTC-CALIBR (read-write) $" RTC-CALIBR @ hex. RTC-CALIBR 1b. ;
: RTC-ALRMAR. ." RTC-ALRMAR (read-write) $" RTC-ALRMAR @ hex. RTC-ALRMAR 1b. ;
: RTC-ALRMBR. ." RTC-ALRMBR (read-write) $" RTC-ALRMBR @ hex. RTC-ALRMBR 1b. ;
: RTC-WPR. ." RTC-WPR (write-only) $" RTC-WPR @ hex. RTC-WPR 1b. ;
: RTC-SSR. ." RTC-SSR (read-only) $" RTC-SSR @ hex. RTC-SSR 1b. ;
: RTC-SHIFTR. ." RTC-SHIFTR (write-only) $" RTC-SHIFTR @ hex. RTC-SHIFTR 1b. ;
: RTC-TSTR. ." RTC-TSTR (read-only) $" RTC-TSTR @ hex. RTC-TSTR 1b. ;
: RTC-TSDR. ." RTC-TSDR (read-only) $" RTC-TSDR @ hex. RTC-TSDR 1b. ;
: RTC-TSSSR. ." RTC-TSSSR (read-only) $" RTC-TSSSR @ hex. RTC-TSSSR 1b. ;
: RTC-CALR. ." RTC-CALR (read-write) $" RTC-CALR @ hex. RTC-CALR 1b. ;
: RTC-TAFCR. ." RTC-TAFCR (read-write) $" RTC-TAFCR @ hex. RTC-TAFCR 1b. ;
: RTC-ALRMASSR. ." RTC-ALRMASSR (read-write) $" RTC-ALRMASSR @ hex. RTC-ALRMASSR 1b. ;
: RTC-ALRMBSSR. ." RTC-ALRMBSSR (read-write) $" RTC-ALRMBSSR @ hex. RTC-ALRMBSSR 1b. ;
: RTC-BKP0R. ." RTC-BKP0R (read-write) $" RTC-BKP0R @ hex. RTC-BKP0R 1b. ;
: RTC-BKP1R. ." RTC-BKP1R (read-write) $" RTC-BKP1R @ hex. RTC-BKP1R 1b. ;
: RTC-BKP2R. ." RTC-BKP2R (read-write) $" RTC-BKP2R @ hex. RTC-BKP2R 1b. ;
: RTC-BKP3R. ." RTC-BKP3R (read-write) $" RTC-BKP3R @ hex. RTC-BKP3R 1b. ;
: RTC-BKP4R. ." RTC-BKP4R (read-write) $" RTC-BKP4R @ hex. RTC-BKP4R 1b. ;
: RTC-BKP5R. ." RTC-BKP5R (read-write) $" RTC-BKP5R @ hex. RTC-BKP5R 1b. ;
: RTC-BKP6R. ." RTC-BKP6R (read-write) $" RTC-BKP6R @ hex. RTC-BKP6R 1b. ;
: RTC-BKP7R. ." RTC-BKP7R (read-write) $" RTC-BKP7R @ hex. RTC-BKP7R 1b. ;
: RTC-BKP8R. ." RTC-BKP8R (read-write) $" RTC-BKP8R @ hex. RTC-BKP8R 1b. ;
: RTC-BKP9R. ." RTC-BKP9R (read-write) $" RTC-BKP9R @ hex. RTC-BKP9R 1b. ;
: RTC-BKP10R. ." RTC-BKP10R (read-write) $" RTC-BKP10R @ hex. RTC-BKP10R 1b. ;
: RTC-BKP11R. ." RTC-BKP11R (read-write) $" RTC-BKP11R @ hex. RTC-BKP11R 1b. ;
: RTC-BKP12R. ." RTC-BKP12R (read-write) $" RTC-BKP12R @ hex. RTC-BKP12R 1b. ;
: RTC-BKP13R. ." RTC-BKP13R (read-write) $" RTC-BKP13R @ hex. RTC-BKP13R 1b. ;
: RTC-BKP14R. ." RTC-BKP14R (read-write) $" RTC-BKP14R @ hex. RTC-BKP14R 1b. ;
: RTC-BKP15R. ." RTC-BKP15R (read-write) $" RTC-BKP15R @ hex. RTC-BKP15R 1b. ;
: RTC-BKP16R. ." RTC-BKP16R (read-write) $" RTC-BKP16R @ hex. RTC-BKP16R 1b. ;
: RTC-BKP17R. ." RTC-BKP17R (read-write) $" RTC-BKP17R @ hex. RTC-BKP17R 1b. ;
: RTC-BKP18R. ." RTC-BKP18R (read-write) $" RTC-BKP18R @ hex. RTC-BKP18R 1b. ;
: RTC-BKP19R. ." RTC-BKP19R (read-write) $" RTC-BKP19R @ hex. RTC-BKP19R 1b. ;
: RTC-BKP20R. ." RTC-BKP20R (read-write) $" RTC-BKP20R @ hex. RTC-BKP20R 1b. ;
: RTC-BKP21R. ." RTC-BKP21R (read-write) $" RTC-BKP21R @ hex. RTC-BKP21R 1b. ;
: RTC-BKP22R. ." RTC-BKP22R (read-write) $" RTC-BKP22R @ hex. RTC-BKP22R 1b. ;
: RTC-BKP23R. ." RTC-BKP23R (read-write) $" RTC-BKP23R @ hex. RTC-BKP23R 1b. ;
: RTC-BKP24R. ." RTC-BKP24R (read-write) $" RTC-BKP24R @ hex. RTC-BKP24R 1b. ;
: RTC-BKP25R. ." RTC-BKP25R (read-write) $" RTC-BKP25R @ hex. RTC-BKP25R 1b. ;
: RTC-BKP26R. ." RTC-BKP26R (read-write) $" RTC-BKP26R @ hex. RTC-BKP26R 1b. ;
: RTC-BKP27R. ." RTC-BKP27R (read-write) $" RTC-BKP27R @ hex. RTC-BKP27R 1b. ;
: RTC-BKP28R. ." RTC-BKP28R (read-write) $" RTC-BKP28R @ hex. RTC-BKP28R 1b. ;
: RTC-BKP29R. ." RTC-BKP29R (read-write) $" RTC-BKP29R @ hex. RTC-BKP29R 1b. ;
: RTC-BKP30R. ." RTC-BKP30R (read-write) $" RTC-BKP30R @ hex. RTC-BKP30R 1b. ;
: RTC-BKP31R. ." RTC-BKP31R (read-write) $" RTC-BKP31R @ hex. RTC-BKP31R 1b. ;
: RTC.
RTC-TR.
RTC-DR.
RTC-CR.
RTC-ISR.
RTC-PRER.
RTC-WUTR.
RTC-CALIBR.
RTC-ALRMAR.
RTC-ALRMBR.
RTC-WPR.
RTC-SSR.
RTC-SHIFTR.
RTC-TSTR.
RTC-TSDR.
RTC-TSSSR.
RTC-CALR.
RTC-TAFCR.
RTC-ALRMASSR.
RTC-ALRMBSSR.
RTC-BKP0R.
RTC-BKP1R.
RTC-BKP2R.
RTC-BKP3R.
RTC-BKP4R.
RTC-BKP5R.
RTC-BKP6R.
RTC-BKP7R.
RTC-BKP8R.
RTC-BKP9R.
RTC-BKP10R.
RTC-BKP11R.
RTC-BKP12R.
RTC-BKP13R.
RTC-BKP14R.
RTC-BKP15R.
RTC-BKP16R.
RTC-BKP17R.
RTC-BKP18R.
RTC-BKP19R.
RTC-BKP20R.
RTC-BKP21R.
RTC-BKP22R.
RTC-BKP23R.
RTC-BKP24R.
RTC-BKP25R.
RTC-BKP26R.
RTC-BKP27R.
RTC-BKP28R.
RTC-BKP29R.
RTC-BKP30R.
RTC-BKP31R.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1-CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1-CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1-SR ( status register ) 
SPI1 $C + constant SPI1-DR ( data register ) 
SPI1 $10 + constant SPI1-CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1-RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1-TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1-I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1-I2SPR ( I2S prescaler register ) 
: SPI1-CR1. ." SPI1-CR1 (read-write) $" SPI1-CR1 @ hex. SPI1-CR1 1b. ;
: SPI1-CR2. ." SPI1-CR2 (read-write) $" SPI1-CR2 @ hex. SPI1-CR2 1b. ;
: SPI1-SR. ." SPI1-SR () $" SPI1-SR @ hex. SPI1-SR 1b. ;
: SPI1-DR. ." SPI1-DR (read-write) $" SPI1-DR @ hex. SPI1-DR 1b. ;
: SPI1-CRCPR. ." SPI1-CRCPR (read-write) $" SPI1-CRCPR @ hex. SPI1-CRCPR 1b. ;
: SPI1-RXCRCR. ." SPI1-RXCRCR (read-only) $" SPI1-RXCRCR @ hex. SPI1-RXCRCR 1b. ;
: SPI1-TXCRCR. ." SPI1-TXCRCR (read-only) $" SPI1-TXCRCR @ hex. SPI1-TXCRCR 1b. ;
: SPI1-I2SCFGR. ." SPI1-I2SCFGR (read-write) $" SPI1-I2SCFGR @ hex. SPI1-I2SCFGR 1b. ;
: SPI1-I2SPR. ." SPI1-I2SPR (read-write) $" SPI1-I2SPR @ hex. SPI1-I2SPR 1b. ;
: SPI1.
SPI1-CR1.
SPI1-CR2.
SPI1-SR.
SPI1-DR.
SPI1-CRCPR.
SPI1-RXCRCR.
SPI1-TXCRCR.
SPI1-I2SCFGR.
SPI1-I2SPR.
;

$40003800 constant SPI2 ( Serial peripheral interface ) 
SPI2 $0 + constant SPI2-CR1 ( control register 1 ) 
SPI2 $4 + constant SPI2-CR2 ( control register 2 ) 
SPI2 $8 + constant SPI2-SR ( status register ) 
SPI2 $C + constant SPI2-DR ( data register ) 
SPI2 $10 + constant SPI2-CRCPR ( CRC polynomial register ) 
SPI2 $14 + constant SPI2-RXCRCR ( RX CRC register ) 
SPI2 $18 + constant SPI2-TXCRCR ( TX CRC register ) 
SPI2 $1C + constant SPI2-I2SCFGR ( I2S configuration register ) 
SPI2 $20 + constant SPI2-I2SPR ( I2S prescaler register ) 
: SPI2-CR1. ." SPI2-CR1 (read-write) $" SPI2-CR1 @ hex. SPI2-CR1 1b. ;
: SPI2-CR2. ." SPI2-CR2 (read-write) $" SPI2-CR2 @ hex. SPI2-CR2 1b. ;
: SPI2-SR. ." SPI2-SR () $" SPI2-SR @ hex. SPI2-SR 1b. ;
: SPI2-DR. ." SPI2-DR (read-write) $" SPI2-DR @ hex. SPI2-DR 1b. ;
: SPI2-CRCPR. ." SPI2-CRCPR (read-write) $" SPI2-CRCPR @ hex. SPI2-CRCPR 1b. ;
: SPI2-RXCRCR. ." SPI2-RXCRCR (read-only) $" SPI2-RXCRCR @ hex. SPI2-RXCRCR 1b. ;
: SPI2-TXCRCR. ." SPI2-TXCRCR (read-only) $" SPI2-TXCRCR @ hex. SPI2-TXCRCR 1b. ;
: SPI2-I2SCFGR. ." SPI2-I2SCFGR (read-write) $" SPI2-I2SCFGR @ hex. SPI2-I2SCFGR 1b. ;
: SPI2-I2SPR. ." SPI2-I2SPR (read-write) $" SPI2-I2SPR @ hex. SPI2-I2SPR 1b. ;
: SPI2.
SPI2-CR1.
SPI2-CR2.
SPI2-SR.
SPI2-DR.
SPI2-CRCPR.
SPI2-RXCRCR.
SPI2-TXCRCR.
SPI2-I2SCFGR.
SPI2-I2SPR.
;

$40003C00 constant SPI3 ( Serial peripheral interface ) 
SPI3 $0 + constant SPI3-CR1 ( control register 1 ) 
SPI3 $4 + constant SPI3-CR2 ( control register 2 ) 
SPI3 $8 + constant SPI3-SR ( status register ) 
SPI3 $C + constant SPI3-DR ( data register ) 
SPI3 $10 + constant SPI3-CRCPR ( CRC polynomial register ) 
SPI3 $14 + constant SPI3-RXCRCR ( RX CRC register ) 
SPI3 $18 + constant SPI3-TXCRCR ( TX CRC register ) 
SPI3 $1C + constant SPI3-I2SCFGR ( I2S configuration register ) 
SPI3 $20 + constant SPI3-I2SPR ( I2S prescaler register ) 
: SPI3-CR1. ." SPI3-CR1 (read-write) $" SPI3-CR1 @ hex. SPI3-CR1 1b. ;
: SPI3-CR2. ." SPI3-CR2 (read-write) $" SPI3-CR2 @ hex. SPI3-CR2 1b. ;
: SPI3-SR. ." SPI3-SR () $" SPI3-SR @ hex. SPI3-SR 1b. ;
: SPI3-DR. ." SPI3-DR (read-write) $" SPI3-DR @ hex. SPI3-DR 1b. ;
: SPI3-CRCPR. ." SPI3-CRCPR (read-write) $" SPI3-CRCPR @ hex. SPI3-CRCPR 1b. ;
: SPI3-RXCRCR. ." SPI3-RXCRCR (read-only) $" SPI3-RXCRCR @ hex. SPI3-RXCRCR 1b. ;
: SPI3-TXCRCR. ." SPI3-TXCRCR (read-only) $" SPI3-TXCRCR @ hex. SPI3-TXCRCR 1b. ;
: SPI3-I2SCFGR. ." SPI3-I2SCFGR (read-write) $" SPI3-I2SCFGR @ hex. SPI3-I2SCFGR 1b. ;
: SPI3-I2SPR. ." SPI3-I2SPR (read-write) $" SPI3-I2SPR @ hex. SPI3-I2SPR 1b. ;
: SPI3.
SPI3-CR1.
SPI3-CR2.
SPI3-SR.
SPI3-DR.
SPI3-CRCPR.
SPI3-RXCRCR.
SPI3-TXCRCR.
SPI3-I2SCFGR.
SPI3-I2SPR.
;

$40010000 constant SYSCFG ( System configuration controller ) 
SYSCFG $0 + constant SYSCFG-MEMRMP ( memory remap register ) 
SYSCFG $4 + constant SYSCFG-PMC ( peripheral mode configuration  register ) 
SYSCFG $8 + constant SYSCFG-EXTICR1 ( external interrupt configuration register  1 ) 
SYSCFG $C + constant SYSCFG-EXTICR2 ( external interrupt configuration register  2 ) 
SYSCFG $10 + constant SYSCFG-EXTICR3 ( external interrupt configuration register  3 ) 
SYSCFG $14 + constant SYSCFG-EXTICR4 ( external interrupt configuration register  4 ) 
: SYSCFG-MEMRMP. ." SYSCFG-MEMRMP () $" SYSCFG-MEMRMP @ hex. SYSCFG-MEMRMP 1b. ;
: SYSCFG-PMC. ." SYSCFG-PMC (read-write) $" SYSCFG-PMC @ hex. SYSCFG-PMC 1b. ;
: SYSCFG-EXTICR1. ." SYSCFG-EXTICR1 (read-write) $" SYSCFG-EXTICR1 @ hex. SYSCFG-EXTICR1 1b. ;
: SYSCFG-EXTICR2. ." SYSCFG-EXTICR2 (read-write) $" SYSCFG-EXTICR2 @ hex. SYSCFG-EXTICR2 1b. ;
: SYSCFG-EXTICR3. ." SYSCFG-EXTICR3 (read-write) $" SYSCFG-EXTICR3 @ hex. SYSCFG-EXTICR3 1b. ;
: SYSCFG-EXTICR4. ." SYSCFG-EXTICR4 (read-write) $" SYSCFG-EXTICR4 @ hex. SYSCFG-EXTICR4 1b. ;
: SYSCFG.
SYSCFG-MEMRMP.
SYSCFG-PMC.
SYSCFG-EXTICR1.
SYSCFG-EXTICR2.
SYSCFG-EXTICR3.
SYSCFG-EXTICR4.
;

$40010C00 constant TIM10 ( General-purpose timers ) 
TIM10 $0 + constant TIM10-CR1 ( control register 1 ) 
TIM10 $C + constant TIM10-DIER ( Interrupt enable register ) 
TIM10 $10 + constant TIM10-SR ( status register ) 
TIM10 $14 + constant TIM10-EGR ( event generation register ) 
TIM10 $18 + constant TIM10-CCMR1_Output ( capture/compare mode register ) 
TIM10 $18 + constant TIM10-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM10 $20 + constant TIM10-CCER ( capture/compare enable  register ) 
TIM10 $24 + constant TIM10-CNT ( counter ) 
TIM10 $28 + constant TIM10-PSC ( prescaler ) 
TIM10 $2C + constant TIM10-ARR ( auto-reload register ) 
TIM10 $34 + constant TIM10-CCR1 ( capture/compare register 1 ) 
TIM10 $50 + constant TIM10-OR ( option register ) 
: TIM10-CR1. ." TIM10-CR1 (read-write) $" TIM10-CR1 @ hex. TIM10-CR1 1b. ;
: TIM10-DIER. ." TIM10-DIER (write-only) $" TIM10-DIER @ hex. TIM10-DIER 1b. ;
: TIM10-SR. ." TIM10-SR (read-write) $" TIM10-SR @ hex. TIM10-SR 1b. ;
: TIM10-EGR. ." TIM10-EGR (read-write) $" TIM10-EGR @ hex. TIM10-EGR 1b. ;
: TIM10-CCMR1_Output. ." TIM10-CCMR1_Output (read-write) $" TIM10-CCMR1_Output @ hex. TIM10-CCMR1_Output 1b. ;
: TIM10-CCMR1_Input. ." TIM10-CCMR1_Input (read-write) $" TIM10-CCMR1_Input @ hex. TIM10-CCMR1_Input 1b. ;
: TIM10-CCER. ." TIM10-CCER (read-write) $" TIM10-CCER @ hex. TIM10-CCER 1b. ;
: TIM10-CNT. ." TIM10-CNT (read-write) $" TIM10-CNT @ hex. TIM10-CNT 1b. ;
: TIM10-PSC. ." TIM10-PSC (read-write) $" TIM10-PSC @ hex. TIM10-PSC 1b. ;
: TIM10-ARR. ." TIM10-ARR (read-write) $" TIM10-ARR @ hex. TIM10-ARR 1b. ;
: TIM10-CCR1. ." TIM10-CCR1 (read-write) $" TIM10-CCR1 @ hex. TIM10-CCR1 1b. ;
: TIM10-OR. ." TIM10-OR (read-write) $" TIM10-OR @ hex. TIM10-OR 1b. ;
: TIM10.
TIM10-CR1.
TIM10-DIER.
TIM10-SR.
TIM10-EGR.
TIM10-CCMR1_Output.
TIM10-CCMR1_Input.
TIM10-CCER.
TIM10-CNT.
TIM10-PSC.
TIM10-ARR.
TIM10-CCR1.
TIM10-OR.
;

$40011000 constant TIM11 ( General-purpose timers ) 
TIM11 $0 + constant TIM11-CR1 ( control register 1 ) 
TIM11 $C + constant TIM11-DIER ( Interrupt enable register ) 
TIM11 $10 + constant TIM11-SR ( status register ) 
TIM11 $14 + constant TIM11-EGR ( event generation register ) 
TIM11 $18 + constant TIM11-CCMR1_Output ( capture/compare mode register ) 
TIM11 $18 + constant TIM11-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM11 $20 + constant TIM11-CCER ( capture/compare enable  register ) 
TIM11 $24 + constant TIM11-CNT ( counter ) 
TIM11 $28 + constant TIM11-PSC ( prescaler ) 
TIM11 $2C + constant TIM11-ARR ( auto-reload register ) 
TIM11 $34 + constant TIM11-CCR1 ( capture/compare register 1 ) 
TIM11 $50 + constant TIM11-OR ( option register ) 
: TIM11-CR1. ." TIM11-CR1 (read-write) $" TIM11-CR1 @ hex. TIM11-CR1 1b. ;
: TIM11-DIER. ." TIM11-DIER (write-only) $" TIM11-DIER @ hex. TIM11-DIER 1b. ;
: TIM11-SR. ." TIM11-SR (read-write) $" TIM11-SR @ hex. TIM11-SR 1b. ;
: TIM11-EGR. ." TIM11-EGR (read-write) $" TIM11-EGR @ hex. TIM11-EGR 1b. ;
: TIM11-CCMR1_Output. ." TIM11-CCMR1_Output (read-write) $" TIM11-CCMR1_Output @ hex. TIM11-CCMR1_Output 1b. ;
: TIM11-CCMR1_Input. ." TIM11-CCMR1_Input (read-write) $" TIM11-CCMR1_Input @ hex. TIM11-CCMR1_Input 1b. ;
: TIM11-CCER. ." TIM11-CCER (read-write) $" TIM11-CCER @ hex. TIM11-CCER 1b. ;
: TIM11-CNT. ." TIM11-CNT (read-write) $" TIM11-CNT @ hex. TIM11-CNT 1b. ;
: TIM11-PSC. ." TIM11-PSC (read-write) $" TIM11-PSC @ hex. TIM11-PSC 1b. ;
: TIM11-ARR. ." TIM11-ARR (read-write) $" TIM11-ARR @ hex. TIM11-ARR 1b. ;
: TIM11-CCR1. ." TIM11-CCR1 (read-write) $" TIM11-CCR1 @ hex. TIM11-CCR1 1b. ;
: TIM11-OR. ." TIM11-OR (read-write) $" TIM11-OR @ hex. TIM11-OR 1b. ;
: TIM11.
TIM11-CR1.
TIM11-DIER.
TIM11-SR.
TIM11-EGR.
TIM11-CCMR1_Output.
TIM11-CCMR1_Input.
TIM11-CCER.
TIM11-CNT.
TIM11-PSC.
TIM11-ARR.
TIM11-CCR1.
TIM11-OR.
;

$40000000 constant TIM2 ( General-purpose timers ) 
TIM2 $0 + constant TIM2-CR1 ( control register 1 ) 
TIM2 $4 + constant TIM2-CR2 ( control register 2 ) 
TIM2 $8 + constant TIM2-SMCR ( slave mode control register ) 
TIM2 $C + constant TIM2-DIER ( Interrupt enable register ) 
TIM2 $10 + constant TIM2-SR ( status register ) 
TIM2 $14 + constant TIM2-EGR ( event generation register ) 
TIM2 $18 + constant TIM2-CCMR1_Output ( capture/compare mode register  1 ) 
TIM2 $18 + constant TIM2-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM2 $1C + constant TIM2-CCMR2_Output ( capture/compare mode register  2 ) 
TIM2 $1C + constant TIM2-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM2 $20 + constant TIM2-CCER ( capture/compare enable  register ) 
TIM2 $24 + constant TIM2-CNT ( counter ) 
TIM2 $28 + constant TIM2-PSC ( prescaler ) 
TIM2 $2C + constant TIM2-ARR ( auto-reload register ) 
TIM2 $34 + constant TIM2-CCR1 ( capture/compare register 1 ) 
TIM2 $38 + constant TIM2-CCR2 ( capture/compare register 1 ) 
TIM2 $3C + constant TIM2-CCR3 ( capture/compare register 1 ) 
TIM2 $40 + constant TIM2-CCR4 ( capture/compare register 1 ) 
TIM2 $48 + constant TIM2-DCR ( DMA control register ) 
TIM2 $4C + constant TIM2-DMAR ( DMA address for full transfer ) 
: TIM2-CR1. ." TIM2-CR1 (read-write) $" TIM2-CR1 @ hex. TIM2-CR1 1b. ;
: TIM2-CR2. ." TIM2-CR2 (read-write) $" TIM2-CR2 @ hex. TIM2-CR2 1b. ;
: TIM2-SMCR. ." TIM2-SMCR (read-write) $" TIM2-SMCR @ hex. TIM2-SMCR 1b. ;
: TIM2-DIER. ." TIM2-DIER (write-only) $" TIM2-DIER @ hex. TIM2-DIER 1b. ;
: TIM2-SR. ." TIM2-SR (read-write) $" TIM2-SR @ hex. TIM2-SR 1b. ;
: TIM2-EGR. ." TIM2-EGR (read-write) $" TIM2-EGR @ hex. TIM2-EGR 1b. ;
: TIM2-CCMR1_Output. ." TIM2-CCMR1_Output (read-write) $" TIM2-CCMR1_Output @ hex. TIM2-CCMR1_Output 1b. ;
: TIM2-CCMR1_Input. ." TIM2-CCMR1_Input (read-write) $" TIM2-CCMR1_Input @ hex. TIM2-CCMR1_Input 1b. ;
: TIM2-CCMR2_Output. ." TIM2-CCMR2_Output (read-write) $" TIM2-CCMR2_Output @ hex. TIM2-CCMR2_Output 1b. ;
: TIM2-CCMR2_Input. ." TIM2-CCMR2_Input (read-write) $" TIM2-CCMR2_Input @ hex. TIM2-CCMR2_Input 1b. ;
: TIM2-CCER. ." TIM2-CCER (read-write) $" TIM2-CCER @ hex. TIM2-CCER 1b. ;
: TIM2-CNT. ." TIM2-CNT (read-write) $" TIM2-CNT @ hex. TIM2-CNT 1b. ;
: TIM2-PSC. ." TIM2-PSC (read-write) $" TIM2-PSC @ hex. TIM2-PSC 1b. ;
: TIM2-ARR. ." TIM2-ARR (read-write) $" TIM2-ARR @ hex. TIM2-ARR 1b. ;
: TIM2-CCR1. ." TIM2-CCR1 (read-write) $" TIM2-CCR1 @ hex. TIM2-CCR1 1b. ;
: TIM2-CCR2. ." TIM2-CCR2 (read-write) $" TIM2-CCR2 @ hex. TIM2-CCR2 1b. ;
: TIM2-CCR3. ." TIM2-CCR3 (read-write) $" TIM2-CCR3 @ hex. TIM2-CCR3 1b. ;
: TIM2-CCR4. ." TIM2-CCR4 (read-write) $" TIM2-CCR4 @ hex. TIM2-CCR4 1b. ;
: TIM2-DCR. ." TIM2-DCR (read-write) $" TIM2-DCR @ hex. TIM2-DCR 1b. ;
: TIM2-DMAR. ." TIM2-DMAR (read-write) $" TIM2-DMAR @ hex. TIM2-DMAR 1b. ;
: TIM2.
TIM2-CR1.
TIM2-CR2.
TIM2-SMCR.
TIM2-DIER.
TIM2-SR.
TIM2-EGR.
TIM2-CCMR1_Output.
TIM2-CCMR1_Input.
TIM2-CCMR2_Output.
TIM2-CCMR2_Input.
TIM2-CCER.
TIM2-CNT.
TIM2-PSC.
TIM2-ARR.
TIM2-CCR1.
TIM2-CCR2.
TIM2-CCR3.
TIM2-CCR4.
TIM2-DCR.
TIM2-DMAR.
;

$40000400 constant TIM3 ( General-purpose timers ) 
TIM3 $0 + constant TIM3-CR1 ( control register 1 ) 
TIM3 $4 + constant TIM3-CR2 ( control register 2 ) 
TIM3 $8 + constant TIM3-SMCR ( slave mode control register ) 
TIM3 $C + constant TIM3-DIER ( Interrupt enable register ) 
TIM3 $10 + constant TIM3-SR ( status register ) 
TIM3 $14 + constant TIM3-EGR ( event generation register ) 
TIM3 $18 + constant TIM3-CCMR1_Output ( capture/compare mode register  1 ) 
TIM3 $18 + constant TIM3-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $1C + constant TIM3-CCMR2_Output ( capture/compare mode register  2 ) 
TIM3 $1C + constant TIM3-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 $20 + constant TIM3-CCER ( capture/compare enable  register ) 
TIM3 $24 + constant TIM3-CNT ( counter ) 
TIM3 $28 + constant TIM3-PSC ( prescaler ) 
TIM3 $2C + constant TIM3-ARR ( auto-reload register ) 
TIM3 $34 + constant TIM3-CCR1 ( capture/compare register 1 ) 
TIM3 $38 + constant TIM3-CCR2 ( capture/compare register 1 ) 
TIM3 $3C + constant TIM3-CCR3 ( capture/compare register 1 ) 
TIM3 $40 + constant TIM3-CCR4 ( capture/compare register 1 ) 
TIM3 $48 + constant TIM3-DCR ( DMA control register ) 
TIM3 $4C + constant TIM3-DMAR ( DMA address for full transfer ) 
: TIM3-CR1. ." TIM3-CR1 (read-write) $" TIM3-CR1 @ hex. TIM3-CR1 1b. ;
: TIM3-CR2. ." TIM3-CR2 (read-write) $" TIM3-CR2 @ hex. TIM3-CR2 1b. ;
: TIM3-SMCR. ." TIM3-SMCR (read-write) $" TIM3-SMCR @ hex. TIM3-SMCR 1b. ;
: TIM3-DIER. ." TIM3-DIER (write-only) $" TIM3-DIER @ hex. TIM3-DIER 1b. ;
: TIM3-SR. ." TIM3-SR (read-write) $" TIM3-SR @ hex. TIM3-SR 1b. ;
: TIM3-EGR. ." TIM3-EGR (read-write) $" TIM3-EGR @ hex. TIM3-EGR 1b. ;
: TIM3-CCMR1_Output. ." TIM3-CCMR1_Output (read-write) $" TIM3-CCMR1_Output @ hex. TIM3-CCMR1_Output 1b. ;
: TIM3-CCMR1_Input. ." TIM3-CCMR1_Input (read-write) $" TIM3-CCMR1_Input @ hex. TIM3-CCMR1_Input 1b. ;
: TIM3-CCMR2_Output. ." TIM3-CCMR2_Output (read-write) $" TIM3-CCMR2_Output @ hex. TIM3-CCMR2_Output 1b. ;
: TIM3-CCMR2_Input. ." TIM3-CCMR2_Input (read-write) $" TIM3-CCMR2_Input @ hex. TIM3-CCMR2_Input 1b. ;
: TIM3-CCER. ." TIM3-CCER (read-write) $" TIM3-CCER @ hex. TIM3-CCER 1b. ;
: TIM3-CNT. ." TIM3-CNT (read-write) $" TIM3-CNT @ hex. TIM3-CNT 1b. ;
: TIM3-PSC. ." TIM3-PSC (read-write) $" TIM3-PSC @ hex. TIM3-PSC 1b. ;
: TIM3-ARR. ." TIM3-ARR (read-write) $" TIM3-ARR @ hex. TIM3-ARR 1b. ;
: TIM3-CCR1. ." TIM3-CCR1 (read-write) $" TIM3-CCR1 @ hex. TIM3-CCR1 1b. ;
: TIM3-CCR2. ." TIM3-CCR2 (read-write) $" TIM3-CCR2 @ hex. TIM3-CCR2 1b. ;
: TIM3-CCR3. ." TIM3-CCR3 (read-write) $" TIM3-CCR3 @ hex. TIM3-CCR3 1b. ;
: TIM3-CCR4. ." TIM3-CCR4 (read-write) $" TIM3-CCR4 @ hex. TIM3-CCR4 1b. ;
: TIM3-DCR. ." TIM3-DCR (read-write) $" TIM3-DCR @ hex. TIM3-DCR 1b. ;
: TIM3-DMAR. ." TIM3-DMAR (read-write) $" TIM3-DMAR @ hex. TIM3-DMAR 1b. ;
: TIM3.
TIM3-CR1.
TIM3-CR2.
TIM3-SMCR.
TIM3-DIER.
TIM3-SR.
TIM3-EGR.
TIM3-CCMR1_Output.
TIM3-CCMR1_Input.
TIM3-CCMR2_Output.
TIM3-CCMR2_Input.
TIM3-CCER.
TIM3-CNT.
TIM3-PSC.
TIM3-ARR.
TIM3-CCR1.
TIM3-CCR2.
TIM3-CCR3.
TIM3-CCR4.
TIM3-DCR.
TIM3-DMAR.
;

$40000800 constant TIM4 ( General-purpose timers ) 
TIM4 $0 + constant TIM4-CR1 ( control register 1 ) 
TIM4 $4 + constant TIM4-CR2 ( control register 2 ) 
TIM4 $8 + constant TIM4-SMCR ( slave mode control register ) 
TIM4 $C + constant TIM4-DIER ( Interrupt enable register ) 
TIM4 $10 + constant TIM4-SR ( status register ) 
TIM4 $14 + constant TIM4-EGR ( event generation register ) 
TIM4 $18 + constant TIM4-CCMR1_Output ( capture/compare mode register  1 ) 
TIM4 $18 + constant TIM4-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM4 $1C + constant TIM4-CCMR2_Output ( capture/compare mode register  2 ) 
TIM4 $1C + constant TIM4-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM4 $20 + constant TIM4-CCER ( capture/compare enable  register ) 
TIM4 $24 + constant TIM4-CNT ( counter ) 
TIM4 $28 + constant TIM4-PSC ( prescaler ) 
TIM4 $2C + constant TIM4-ARR ( auto-reload register ) 
TIM4 $34 + constant TIM4-CCR1 ( capture/compare register 1 ) 
TIM4 $38 + constant TIM4-CCR2 ( capture/compare register 1 ) 
TIM4 $3C + constant TIM4-CCR3 ( capture/compare register 1 ) 
TIM4 $40 + constant TIM4-CCR4 ( capture/compare register 1 ) 
TIM4 $48 + constant TIM4-DCR ( DMA control register ) 
TIM4 $4C + constant TIM4-DMAR ( DMA address for full transfer ) 
: TIM4-CR1. ." TIM4-CR1 (read-write) $" TIM4-CR1 @ hex. TIM4-CR1 1b. ;
: TIM4-CR2. ." TIM4-CR2 (read-write) $" TIM4-CR2 @ hex. TIM4-CR2 1b. ;
: TIM4-SMCR. ." TIM4-SMCR (read-write) $" TIM4-SMCR @ hex. TIM4-SMCR 1b. ;
: TIM4-DIER. ." TIM4-DIER (write-only) $" TIM4-DIER @ hex. TIM4-DIER 1b. ;
: TIM4-SR. ." TIM4-SR (read-write) $" TIM4-SR @ hex. TIM4-SR 1b. ;
: TIM4-EGR. ." TIM4-EGR (read-write) $" TIM4-EGR @ hex. TIM4-EGR 1b. ;
: TIM4-CCMR1_Output. ." TIM4-CCMR1_Output (read-write) $" TIM4-CCMR1_Output @ hex. TIM4-CCMR1_Output 1b. ;
: TIM4-CCMR1_Input. ." TIM4-CCMR1_Input (read-write) $" TIM4-CCMR1_Input @ hex. TIM4-CCMR1_Input 1b. ;
: TIM4-CCMR2_Output. ." TIM4-CCMR2_Output (read-write) $" TIM4-CCMR2_Output @ hex. TIM4-CCMR2_Output 1b. ;
: TIM4-CCMR2_Input. ." TIM4-CCMR2_Input (read-write) $" TIM4-CCMR2_Input @ hex. TIM4-CCMR2_Input 1b. ;
: TIM4-CCER. ." TIM4-CCER (read-write) $" TIM4-CCER @ hex. TIM4-CCER 1b. ;
: TIM4-CNT. ." TIM4-CNT (read-write) $" TIM4-CNT @ hex. TIM4-CNT 1b. ;
: TIM4-PSC. ." TIM4-PSC (read-write) $" TIM4-PSC @ hex. TIM4-PSC 1b. ;
: TIM4-ARR. ." TIM4-ARR (read-write) $" TIM4-ARR @ hex. TIM4-ARR 1b. ;
: TIM4-CCR1. ." TIM4-CCR1 (read-write) $" TIM4-CCR1 @ hex. TIM4-CCR1 1b. ;
: TIM4-CCR2. ." TIM4-CCR2 (read-write) $" TIM4-CCR2 @ hex. TIM4-CCR2 1b. ;
: TIM4-CCR3. ." TIM4-CCR3 (read-write) $" TIM4-CCR3 @ hex. TIM4-CCR3 1b. ;
: TIM4-CCR4. ." TIM4-CCR4 (read-write) $" TIM4-CCR4 @ hex. TIM4-CCR4 1b. ;
: TIM4-DCR. ." TIM4-DCR (read-write) $" TIM4-DCR @ hex. TIM4-DCR 1b. ;
: TIM4-DMAR. ." TIM4-DMAR (read-write) $" TIM4-DMAR @ hex. TIM4-DMAR 1b. ;
: TIM4.
TIM4-CR1.
TIM4-CR2.
TIM4-SMCR.
TIM4-DIER.
TIM4-SR.
TIM4-EGR.
TIM4-CCMR1_Output.
TIM4-CCMR1_Input.
TIM4-CCMR2_Output.
TIM4-CCMR2_Input.
TIM4-CCER.
TIM4-CNT.
TIM4-PSC.
TIM4-ARR.
TIM4-CCR1.
TIM4-CCR2.
TIM4-CCR3.
TIM4-CCR4.
TIM4-DCR.
TIM4-DMAR.
;

$40000C00 constant TIM5 ( General-purpose timers ) 
TIM5 $0 + constant TIM5-CR1 ( control register 1 ) 
TIM5 $4 + constant TIM5-CR2 ( control register 2 ) 
TIM5 $8 + constant TIM5-SMCR ( slave mode control register ) 
TIM5 $C + constant TIM5-DIER ( Interrupt enable register ) 
TIM5 $10 + constant TIM5-SR ( status register ) 
TIM5 $14 + constant TIM5-EGR ( event generation register ) 
TIM5 $18 + constant TIM5-CCMR1_Output ( capture/compare mode register  1 ) 
TIM5 $18 + constant TIM5-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM5 $1C + constant TIM5-CCMR2_Output ( capture/compare mode register  2 ) 
TIM5 $1C + constant TIM5-CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM5 $20 + constant TIM5-CCER ( capture/compare enable  register ) 
TIM5 $24 + constant TIM5-CNT ( counter ) 
TIM5 $28 + constant TIM5-PSC ( prescaler ) 
TIM5 $2C + constant TIM5-ARR ( auto-reload register ) 
TIM5 $34 + constant TIM5-CCR1 ( capture/compare register 1 ) 
TIM5 $38 + constant TIM5-CCR2 ( capture/compare register 1 ) 
TIM5 $3C + constant TIM5-CCR3 ( capture/compare register 1 ) 
TIM5 $40 + constant TIM5-CCR4 ( capture/compare register 1 ) 
TIM5 $48 + constant TIM5-DCR ( DMA control register ) 
TIM5 $4C + constant TIM5-DMAR ( DMA address for full transfer ) 
: TIM5-CR1. ." TIM5-CR1 (read-write) $" TIM5-CR1 @ hex. TIM5-CR1 1b. ;
: TIM5-CR2. ." TIM5-CR2 (read-write) $" TIM5-CR2 @ hex. TIM5-CR2 1b. ;
: TIM5-SMCR. ." TIM5-SMCR (read-write) $" TIM5-SMCR @ hex. TIM5-SMCR 1b. ;
: TIM5-DIER. ." TIM5-DIER (write-only) $" TIM5-DIER @ hex. TIM5-DIER 1b. ;
: TIM5-SR. ." TIM5-SR (read-write) $" TIM5-SR @ hex. TIM5-SR 1b. ;
: TIM5-EGR. ." TIM5-EGR (read-write) $" TIM5-EGR @ hex. TIM5-EGR 1b. ;
: TIM5-CCMR1_Output. ." TIM5-CCMR1_Output (read-write) $" TIM5-CCMR1_Output @ hex. TIM5-CCMR1_Output 1b. ;
: TIM5-CCMR1_Input. ." TIM5-CCMR1_Input (read-write) $" TIM5-CCMR1_Input @ hex. TIM5-CCMR1_Input 1b. ;
: TIM5-CCMR2_Output. ." TIM5-CCMR2_Output (read-write) $" TIM5-CCMR2_Output @ hex. TIM5-CCMR2_Output 1b. ;
: TIM5-CCMR2_Input. ." TIM5-CCMR2_Input (read-write) $" TIM5-CCMR2_Input @ hex. TIM5-CCMR2_Input 1b. ;
: TIM5-CCER. ." TIM5-CCER (read-write) $" TIM5-CCER @ hex. TIM5-CCER 1b. ;
: TIM5-CNT. ." TIM5-CNT (read-write) $" TIM5-CNT @ hex. TIM5-CNT 1b. ;
: TIM5-PSC. ." TIM5-PSC (read-write) $" TIM5-PSC @ hex. TIM5-PSC 1b. ;
: TIM5-ARR. ." TIM5-ARR (read-write) $" TIM5-ARR @ hex. TIM5-ARR 1b. ;
: TIM5-CCR1. ." TIM5-CCR1 (read-write) $" TIM5-CCR1 @ hex. TIM5-CCR1 1b. ;
: TIM5-CCR2. ." TIM5-CCR2 (read-write) $" TIM5-CCR2 @ hex. TIM5-CCR2 1b. ;
: TIM5-CCR3. ." TIM5-CCR3 (read-write) $" TIM5-CCR3 @ hex. TIM5-CCR3 1b. ;
: TIM5-CCR4. ." TIM5-CCR4 (read-write) $" TIM5-CCR4 @ hex. TIM5-CCR4 1b. ;
: TIM5-DCR. ." TIM5-DCR (read-write) $" TIM5-DCR @ hex. TIM5-DCR 1b. ;
: TIM5-DMAR. ." TIM5-DMAR (read-write) $" TIM5-DMAR @ hex. TIM5-DMAR 1b. ;
: TIM5.
TIM5-CR1.
TIM5-CR2.
TIM5-SMCR.
TIM5-DIER.
TIM5-SR.
TIM5-EGR.
TIM5-CCMR1_Output.
TIM5-CCMR1_Input.
TIM5-CCMR2_Output.
TIM5-CCMR2_Input.
TIM5-CCER.
TIM5-CNT.
TIM5-PSC.
TIM5-ARR.
TIM5-CCR1.
TIM5-CCR2.
TIM5-CCR3.
TIM5-CCR4.
TIM5-DCR.
TIM5-DMAR.
;

$40001000 constant TIM6 ( Basic timers ) 
TIM6 $0 + constant TIM6-CR1 ( TIM6 control register 1 ) 
TIM6 $4 + constant TIM6-CR2 ( TIM6 control register 2 ) 
TIM6 $C + constant TIM6-DIER ( TIM6 DMA/Interrupt enable  register ) 
TIM6 $10 + constant TIM6-SR ( TIM6 status register ) 
TIM6 $14 + constant TIM6-EGR ( TIM6 event generation register ) 
TIM6 $24 + constant TIM6-CNT ( TIM6 counter ) 
TIM6 $28 + constant TIM6-PSC ( TIM6 prescaler ) 
TIM6 $2C + constant TIM6-ARR ( TIM6 auto-reload register ) 
: TIM6-CR1. ." TIM6-CR1 (read-write) $" TIM6-CR1 @ hex. TIM6-CR1 1b. ;
: TIM6-CR2. ." TIM6-CR2 (read-write) $" TIM6-CR2 @ hex. TIM6-CR2 1b. ;
: TIM6-DIER. ." TIM6-DIER (read-write) $" TIM6-DIER @ hex. TIM6-DIER 1b. ;
: TIM6-SR. ." TIM6-SR (read-write) $" TIM6-SR @ hex. TIM6-SR 1b. ;
: TIM6-EGR. ." TIM6-EGR (write-only) $" TIM6-EGR @ hex. TIM6-EGR 1b. ;
: TIM6-CNT. ." TIM6-CNT (read-write) $" TIM6-CNT @ hex. TIM6-CNT 1b. ;
: TIM6-PSC. ." TIM6-PSC (read-write) $" TIM6-PSC @ hex. TIM6-PSC 1b. ;
: TIM6-ARR. ." TIM6-ARR (read-write) $" TIM6-ARR @ hex. TIM6-ARR 1b. ;
: TIM6.
TIM6-CR1.
TIM6-CR2.
TIM6-DIER.
TIM6-SR.
TIM6-EGR.
TIM6-CNT.
TIM6-PSC.
TIM6-ARR.
;

$40001400 constant TIM7 ( Basic timers ) 
TIM7 $0 + constant TIM7-CR1 ( TIM6 control register 1 ) 
TIM7 $4 + constant TIM7-CR2 ( TIM6 control register 2 ) 
TIM7 $C + constant TIM7-DIER ( TIM6 DMA/Interrupt enable  register ) 
TIM7 $10 + constant TIM7-SR ( TIM6 status register ) 
TIM7 $14 + constant TIM7-EGR ( TIM6 event generation register ) 
TIM7 $24 + constant TIM7-CNT ( TIM6 counter ) 
TIM7 $28 + constant TIM7-PSC ( TIM6 prescaler ) 
TIM7 $2C + constant TIM7-ARR ( TIM6 auto-reload register ) 
: TIM7-CR1. ." TIM7-CR1 (read-write) $" TIM7-CR1 @ hex. TIM7-CR1 1b. ;
: TIM7-CR2. ." TIM7-CR2 (read-write) $" TIM7-CR2 @ hex. TIM7-CR2 1b. ;
: TIM7-DIER. ." TIM7-DIER (read-write) $" TIM7-DIER @ hex. TIM7-DIER 1b. ;
: TIM7-SR. ." TIM7-SR (read-write) $" TIM7-SR @ hex. TIM7-SR 1b. ;
: TIM7-EGR. ." TIM7-EGR (write-only) $" TIM7-EGR @ hex. TIM7-EGR 1b. ;
: TIM7-CNT. ." TIM7-CNT (read-write) $" TIM7-CNT @ hex. TIM7-CNT 1b. ;
: TIM7-PSC. ." TIM7-PSC (read-write) $" TIM7-PSC @ hex. TIM7-PSC 1b. ;
: TIM7-ARR. ." TIM7-ARR (read-write) $" TIM7-ARR @ hex. TIM7-ARR 1b. ;
: TIM7.
TIM7-CR1.
TIM7-CR2.
TIM7-DIER.
TIM7-SR.
TIM7-EGR.
TIM7-CNT.
TIM7-PSC.
TIM7-ARR.
;

$40010800 constant TIM9 ( General-purpose timers ) 
TIM9 $0 + constant TIM9-CR1 ( control register 1 ) 
TIM9 $4 + constant TIM9-CR2 ( control register 2 ) 
TIM9 $8 + constant TIM9-SMCR ( slave mode control register ) 
TIM9 $C + constant TIM9-DIER ( Interrupt enable register ) 
TIM9 $10 + constant TIM9-SR ( status register ) 
TIM9 $14 + constant TIM9-EGR ( event generation register ) 
TIM9 $18 + constant TIM9-CCMR1_Output ( capture/compare mode register  1 ) 
TIM9 $18 + constant TIM9-CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM9 $24 + constant TIM9-CNT ( counter ) 
TIM9 $28 + constant TIM9-PSC ( prescaler ) 
TIM9 $2C + constant TIM9-ARR ( auto-reload register ) 
TIM9 $34 + constant TIM9-CCR1 ( capture/compare register 1 ) 
TIM9 $38 + constant TIM9-CCR2 ( capture/compare register 2 ) 
TIM9 $50 + constant TIM9-OR ( option register ) 
: TIM9-CR1. ." TIM9-CR1 (read-write) $" TIM9-CR1 @ hex. TIM9-CR1 1b. ;
: TIM9-CR2. ." TIM9-CR2 (read-write) $" TIM9-CR2 @ hex. TIM9-CR2 1b. ;
: TIM9-SMCR. ." TIM9-SMCR (read-write) $" TIM9-SMCR @ hex. TIM9-SMCR 1b. ;
: TIM9-DIER. ." TIM9-DIER (write-only) $" TIM9-DIER @ hex. TIM9-DIER 1b. ;
: TIM9-SR. ." TIM9-SR (read-write) $" TIM9-SR @ hex. TIM9-SR 1b. ;
: TIM9-EGR. ." TIM9-EGR (read-write) $" TIM9-EGR @ hex. TIM9-EGR 1b. ;
: TIM9-CCMR1_Output. ." TIM9-CCMR1_Output (read-write) $" TIM9-CCMR1_Output @ hex. TIM9-CCMR1_Output 1b. ;
: TIM9-CCMR1_Input. ." TIM9-CCMR1_Input (read-write) $" TIM9-CCMR1_Input @ hex. TIM9-CCMR1_Input 1b. ;
: TIM9-CNT. ." TIM9-CNT (read-write) $" TIM9-CNT @ hex. TIM9-CNT 1b. ;
: TIM9-PSC. ." TIM9-PSC (read-write) $" TIM9-PSC @ hex. TIM9-PSC 1b. ;
: TIM9-ARR. ." TIM9-ARR (read-write) $" TIM9-ARR @ hex. TIM9-ARR 1b. ;
: TIM9-CCR1. ." TIM9-CCR1 (read-write) $" TIM9-CCR1 @ hex. TIM9-CCR1 1b. ;
: TIM9-CCR2. ." TIM9-CCR2 (read-write) $" TIM9-CCR2 @ hex. TIM9-CCR2 1b. ;
: TIM9-OR. ." TIM9-OR (read-write) $" TIM9-OR @ hex. TIM9-OR 1b. ;
: TIM9.
TIM9-CR1.
TIM9-CR2.
TIM9-SMCR.
TIM9-DIER.
TIM9-SR.
TIM9-EGR.
TIM9-CCMR1_Output.
TIM9-CCMR1_Input.
TIM9-CNT.
TIM9-PSC.
TIM9-ARR.
TIM9-CCR1.
TIM9-CCR2.
TIM9-OR.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1-SR ( Status register ) 
USART1 $4 + constant USART1-DR ( Data register ) 
USART1 $8 + constant USART1-BRR ( Baud rate register ) 
USART1 $C + constant USART1-CR1 ( Control register 1 ) 
USART1 $10 + constant USART1-CR2 ( Control register 2 ) 
USART1 $14 + constant USART1-CR3 ( Control register 3 ) 
USART1 $18 + constant USART1-GTPR ( Guard time and prescaler  register ) 
: USART1-SR. ." USART1-SR () $" USART1-SR @ hex. USART1-SR 1b. ;
: USART1-DR. ." USART1-DR (read-write) $" USART1-DR @ hex. USART1-DR 1b. ;
: USART1-BRR. ." USART1-BRR (read-write) $" USART1-BRR @ hex. USART1-BRR 1b. ;
: USART1-CR1. ." USART1-CR1 (read-write) $" USART1-CR1 @ hex. USART1-CR1 1b. ;
: USART1-CR2. ." USART1-CR2 (read-write) $" USART1-CR2 @ hex. USART1-CR2 1b. ;
: USART1-CR3. ." USART1-CR3 (read-write) $" USART1-CR3 @ hex. USART1-CR3 1b. ;
: USART1-GTPR. ." USART1-GTPR (read-write) $" USART1-GTPR @ hex. USART1-GTPR 1b. ;
: USART1.
USART1-SR.
USART1-DR.
USART1-BRR.
USART1-CR1.
USART1-CR2.
USART1-CR3.
USART1-GTPR.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 $0 + constant USART2-SR ( Status register ) 
USART2 $4 + constant USART2-DR ( Data register ) 
USART2 $8 + constant USART2-BRR ( Baud rate register ) 
USART2 $C + constant USART2-CR1 ( Control register 1 ) 
USART2 $10 + constant USART2-CR2 ( Control register 2 ) 
USART2 $14 + constant USART2-CR3 ( Control register 3 ) 
USART2 $18 + constant USART2-GTPR ( Guard time and prescaler  register ) 
: USART2-SR. ." USART2-SR () $" USART2-SR @ hex. USART2-SR 1b. ;
: USART2-DR. ." USART2-DR (read-write) $" USART2-DR @ hex. USART2-DR 1b. ;
: USART2-BRR. ." USART2-BRR (read-write) $" USART2-BRR @ hex. USART2-BRR 1b. ;
: USART2-CR1. ." USART2-CR1 (read-write) $" USART2-CR1 @ hex. USART2-CR1 1b. ;
: USART2-CR2. ." USART2-CR2 (read-write) $" USART2-CR2 @ hex. USART2-CR2 1b. ;
: USART2-CR3. ." USART2-CR3 (read-write) $" USART2-CR3 @ hex. USART2-CR3 1b. ;
: USART2-GTPR. ." USART2-GTPR (read-write) $" USART2-GTPR @ hex. USART2-GTPR 1b. ;
: USART2.
USART2-SR.
USART2-DR.
USART2-BRR.
USART2-CR1.
USART2-CR2.
USART2-CR3.
USART2-GTPR.
;

$40004800 constant USART3 ( Universal synchronous asynchronous receiver  transmitter ) 
USART3 $0 + constant USART3-SR ( Status register ) 
USART3 $4 + constant USART3-DR ( Data register ) 
USART3 $8 + constant USART3-BRR ( Baud rate register ) 
USART3 $C + constant USART3-CR1 ( Control register 1 ) 
USART3 $10 + constant USART3-CR2 ( Control register 2 ) 
USART3 $14 + constant USART3-CR3 ( Control register 3 ) 
USART3 $18 + constant USART3-GTPR ( Guard time and prescaler  register ) 
: USART3-SR. ." USART3-SR () $" USART3-SR @ hex. USART3-SR 1b. ;
: USART3-DR. ." USART3-DR (read-write) $" USART3-DR @ hex. USART3-DR 1b. ;
: USART3-BRR. ." USART3-BRR (read-write) $" USART3-BRR @ hex. USART3-BRR 1b. ;
: USART3-CR1. ." USART3-CR1 (read-write) $" USART3-CR1 @ hex. USART3-CR1 1b. ;
: USART3-CR2. ." USART3-CR2 (read-write) $" USART3-CR2 @ hex. USART3-CR2 1b. ;
: USART3-CR3. ." USART3-CR3 (read-write) $" USART3-CR3 @ hex. USART3-CR3 1b. ;
: USART3-GTPR. ." USART3-GTPR (read-write) $" USART3-GTPR @ hex. USART3-GTPR 1b. ;
: USART3.
USART3-SR.
USART3-DR.
USART3-BRR.
USART3-CR1.
USART3-CR2.
USART3-CR3.
USART3-GTPR.
;

$40005C00 constant USB ( Universal serial bus full-speed device  interface ) 
USB $0 + constant USB-USB_EP0R ( endpoint 0 register ) 
USB $4 + constant USB-USB_EP1R ( endpoint 1 register ) 
USB $8 + constant USB-USB_EP2R ( endpoint 2 register ) 
USB $C + constant USB-USB_EP3R ( endpoint 3 register ) 
USB $10 + constant USB-USB_EP4R ( endpoint 4 register ) 
USB $14 + constant USB-USB_EP5R ( endpoint 5 register ) 
USB $18 + constant USB-USB_EP6R ( endpoint 6 register ) 
USB $1C + constant USB-USB_EP7R ( endpoint 7 register ) 
USB $40 + constant USB-USB_CNTR ( control register ) 
USB $44 + constant USB-ISTR ( interrupt status register ) 
USB $48 + constant USB-FNR ( frame number register ) 
USB $4C + constant USB-DADDR ( device address ) 
USB $50 + constant USB-BTABLE ( Buffer table address ) 
: USB-USB_EP0R. ." USB-USB_EP0R (read-write) $" USB-USB_EP0R @ hex. USB-USB_EP0R 1b. ;
: USB-USB_EP1R. ." USB-USB_EP1R (read-write) $" USB-USB_EP1R @ hex. USB-USB_EP1R 1b. ;
: USB-USB_EP2R. ." USB-USB_EP2R (read-write) $" USB-USB_EP2R @ hex. USB-USB_EP2R 1b. ;
: USB-USB_EP3R. ." USB-USB_EP3R (read-write) $" USB-USB_EP3R @ hex. USB-USB_EP3R 1b. ;
: USB-USB_EP4R. ." USB-USB_EP4R (read-write) $" USB-USB_EP4R @ hex. USB-USB_EP4R 1b. ;
: USB-USB_EP5R. ." USB-USB_EP5R (read-write) $" USB-USB_EP5R @ hex. USB-USB_EP5R 1b. ;
: USB-USB_EP6R. ." USB-USB_EP6R (read-write) $" USB-USB_EP6R @ hex. USB-USB_EP6R 1b. ;
: USB-USB_EP7R. ." USB-USB_EP7R (read-write) $" USB-USB_EP7R @ hex. USB-USB_EP7R 1b. ;
: USB-USB_CNTR. ." USB-USB_CNTR (read-write) $" USB-USB_CNTR @ hex. USB-USB_CNTR 1b. ;
: USB-ISTR. ." USB-ISTR (read-write) $" USB-ISTR @ hex. USB-ISTR 1b. ;
: USB-FNR. ." USB-FNR (read-only) $" USB-FNR @ hex. USB-FNR 1b. ;
: USB-DADDR. ." USB-DADDR (read-write) $" USB-DADDR @ hex. USB-DADDR 1b. ;
: USB-BTABLE. ." USB-BTABLE (read-write) $" USB-BTABLE @ hex. USB-BTABLE 1b. ;
: USB.
USB-USB_EP0R.
USB-USB_EP1R.
USB-USB_EP2R.
USB-USB_EP3R.
USB-USB_EP4R.
USB-USB_EP5R.
USB-USB_EP6R.
USB-USB_EP7R.
USB-USB_CNTR.
USB-ISTR.
USB-FNR.
USB-DADDR.
USB-BTABLE.
;

$40006000 constant USB_SRAM ( Universal serial bus full-speed device  interface ) 
USB_SRAM $0 + constant USB_SRAM-USB_EP0R ( endpoint 0 register ) 
USB_SRAM $4 + constant USB_SRAM-USB_EP1R ( endpoint 1 register ) 
USB_SRAM $8 + constant USB_SRAM-USB_EP2R ( endpoint 2 register ) 
USB_SRAM $C + constant USB_SRAM-USB_EP3R ( endpoint 3 register ) 
USB_SRAM $10 + constant USB_SRAM-USB_EP4R ( endpoint 4 register ) 
USB_SRAM $14 + constant USB_SRAM-USB_EP5R ( endpoint 5 register ) 
USB_SRAM $18 + constant USB_SRAM-USB_EP6R ( endpoint 6 register ) 
USB_SRAM $1C + constant USB_SRAM-USB_EP7R ( endpoint 7 register ) 
USB_SRAM $40 + constant USB_SRAM-USB_CNTR ( control register ) 
USB_SRAM $44 + constant USB_SRAM-ISTR ( interrupt status register ) 
USB_SRAM $48 + constant USB_SRAM-FNR ( frame number register ) 
USB_SRAM $4C + constant USB_SRAM-DADDR ( device address ) 
USB_SRAM $50 + constant USB_SRAM-BTABLE ( Buffer table address ) 
: USB_SRAM-USB_EP0R. ." USB_SRAM-USB_EP0R (read-write) $" USB_SRAM-USB_EP0R @ hex. USB_SRAM-USB_EP0R 1b. ;
: USB_SRAM-USB_EP1R. ." USB_SRAM-USB_EP1R (read-write) $" USB_SRAM-USB_EP1R @ hex. USB_SRAM-USB_EP1R 1b. ;
: USB_SRAM-USB_EP2R. ." USB_SRAM-USB_EP2R (read-write) $" USB_SRAM-USB_EP2R @ hex. USB_SRAM-USB_EP2R 1b. ;
: USB_SRAM-USB_EP3R. ." USB_SRAM-USB_EP3R (read-write) $" USB_SRAM-USB_EP3R @ hex. USB_SRAM-USB_EP3R 1b. ;
: USB_SRAM-USB_EP4R. ." USB_SRAM-USB_EP4R (read-write) $" USB_SRAM-USB_EP4R @ hex. USB_SRAM-USB_EP4R 1b. ;
: USB_SRAM-USB_EP5R. ." USB_SRAM-USB_EP5R (read-write) $" USB_SRAM-USB_EP5R @ hex. USB_SRAM-USB_EP5R 1b. ;
: USB_SRAM-USB_EP6R. ." USB_SRAM-USB_EP6R (read-write) $" USB_SRAM-USB_EP6R @ hex. USB_SRAM-USB_EP6R 1b. ;
: USB_SRAM-USB_EP7R. ." USB_SRAM-USB_EP7R (read-write) $" USB_SRAM-USB_EP7R @ hex. USB_SRAM-USB_EP7R 1b. ;
: USB_SRAM-USB_CNTR. ." USB_SRAM-USB_CNTR (read-write) $" USB_SRAM-USB_CNTR @ hex. USB_SRAM-USB_CNTR 1b. ;
: USB_SRAM-ISTR. ." USB_SRAM-ISTR (read-write) $" USB_SRAM-ISTR @ hex. USB_SRAM-ISTR 1b. ;
: USB_SRAM-FNR. ." USB_SRAM-FNR (read-only) $" USB_SRAM-FNR @ hex. USB_SRAM-FNR 1b. ;
: USB_SRAM-DADDR. ." USB_SRAM-DADDR (read-write) $" USB_SRAM-DADDR @ hex. USB_SRAM-DADDR 1b. ;
: USB_SRAM-BTABLE. ." USB_SRAM-BTABLE (read-write) $" USB_SRAM-BTABLE @ hex. USB_SRAM-BTABLE 1b. ;
: USB_SRAM.
USB_SRAM-USB_EP0R.
USB_SRAM-USB_EP1R.
USB_SRAM-USB_EP2R.
USB_SRAM-USB_EP3R.
USB_SRAM-USB_EP4R.
USB_SRAM-USB_EP5R.
USB_SRAM-USB_EP6R.
USB_SRAM-USB_EP7R.
USB_SRAM-USB_CNTR.
USB_SRAM-ISTR.
USB_SRAM-FNR.
USB_SRAM-DADDR.
USB_SRAM-BTABLE.
;

$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG-CR ( Control register ) 
WWDG $4 + constant WWDG-CFR ( Configuration register ) 
WWDG $8 + constant WWDG-SR ( SR ) 
: WWDG-CR. ." WWDG-CR () $" WWDG-CR @ hex. WWDG-CR 1b. ;
: WWDG-CFR. ." WWDG-CFR () $" WWDG-CFR @ hex. WWDG-CFR 1b. ;
: WWDG-SR. ." WWDG-SR (read-write) $" WWDG-SR @ hex. WWDG-SR 1b. ;
: WWDG.
WWDG-CR.
WWDG-CFR.
WWDG-SR.
;

$40012400 constant ADC ( Analog-to-digital converter ) 
ADC $0 + constant ADC-SR ( status register ) 
ADC $4 + constant ADC-CR1 ( control register 1 ) 
ADC $8 + constant ADC-CR2 ( control register 2 ) 
ADC $C + constant ADC-SMPR1 ( sample time register 1 ) 
ADC $10 + constant ADC-SMPR2 ( sample time register 2 ) 
ADC $14 + constant ADC-SMPR3 ( sample time register 3 ) 
ADC $18 + constant ADC-JOFR1 ( injected channel data offset register  x ) 
ADC $1C + constant ADC-JOFR2 ( injected channel data offset register  x ) 
ADC $20 + constant ADC-JOFR3 ( injected channel data offset register  x ) 
ADC $24 + constant ADC-JOFR4 ( injected channel data offset register  x ) 
ADC $28 + constant ADC-HTR ( watchdog higher threshold  register ) 
ADC $2C + constant ADC-LTR ( watchdog lower threshold  register ) 
ADC $30 + constant ADC-SQR1 ( regular sequence register 1 ) 
ADC $34 + constant ADC-SQR2 ( regular sequence register 2 ) 
ADC $38 + constant ADC-SQR3 ( regular sequence register 3 ) 
ADC $3C + constant ADC-SQR4 ( regular sequence register 4 ) 
ADC $40 + constant ADC-SQR5 ( regular sequence register 5 ) 
ADC $44 + constant ADC-JSQR ( injected sequence register ) 
ADC $48 + constant ADC-JDR1 ( injected data register x ) 
ADC $4C + constant ADC-JDR2 ( injected data register x ) 
ADC $50 + constant ADC-JDR3 ( injected data register x ) 
ADC $54 + constant ADC-JDR4 ( injected data register x ) 
ADC $58 + constant ADC-DR ( regular data register ) 
ADC $5C + constant ADC-SMPR0 ( sample time register 0 ) 
: ADC-SR. ." ADC-SR () $" ADC-SR @ hex. ADC-SR 1b. ;
: ADC-CR1. ." ADC-CR1 (read-write) $" ADC-CR1 @ hex. ADC-CR1 1b. ;
: ADC-CR2. ." ADC-CR2 (read-write) $" ADC-CR2 @ hex. ADC-CR2 1b. ;
: ADC-SMPR1. ." ADC-SMPR1 (read-write) $" ADC-SMPR1 @ hex. ADC-SMPR1 1b. ;
: ADC-SMPR2. ." ADC-SMPR2 (read-write) $" ADC-SMPR2 @ hex. ADC-SMPR2 1b. ;
: ADC-SMPR3. ." ADC-SMPR3 (read-write) $" ADC-SMPR3 @ hex. ADC-SMPR3 1b. ;
: ADC-JOFR1. ." ADC-JOFR1 (read-write) $" ADC-JOFR1 @ hex. ADC-JOFR1 1b. ;
: ADC-JOFR2. ." ADC-JOFR2 (read-write) $" ADC-JOFR2 @ hex. ADC-JOFR2 1b. ;
: ADC-JOFR3. ." ADC-JOFR3 (read-write) $" ADC-JOFR3 @ hex. ADC-JOFR3 1b. ;
: ADC-JOFR4. ." ADC-JOFR4 (read-write) $" ADC-JOFR4 @ hex. ADC-JOFR4 1b. ;
: ADC-HTR. ." ADC-HTR (read-write) $" ADC-HTR @ hex. ADC-HTR 1b. ;
: ADC-LTR. ." ADC-LTR (read-write) $" ADC-LTR @ hex. ADC-LTR 1b. ;
: ADC-SQR1. ." ADC-SQR1 (read-write) $" ADC-SQR1 @ hex. ADC-SQR1 1b. ;
: ADC-SQR2. ." ADC-SQR2 (read-write) $" ADC-SQR2 @ hex. ADC-SQR2 1b. ;
: ADC-SQR3. ." ADC-SQR3 (read-write) $" ADC-SQR3 @ hex. ADC-SQR3 1b. ;
: ADC-SQR4. ." ADC-SQR4 (read-write) $" ADC-SQR4 @ hex. ADC-SQR4 1b. ;
: ADC-SQR5. ." ADC-SQR5 (read-write) $" ADC-SQR5 @ hex. ADC-SQR5 1b. ;
: ADC-JSQR. ." ADC-JSQR (read-write) $" ADC-JSQR @ hex. ADC-JSQR 1b. ;
: ADC-JDR1. ." ADC-JDR1 (read-only) $" ADC-JDR1 @ hex. ADC-JDR1 1b. ;
: ADC-JDR2. ." ADC-JDR2 (read-only) $" ADC-JDR2 @ hex. ADC-JDR2 1b. ;
: ADC-JDR3. ." ADC-JDR3 (read-only) $" ADC-JDR3 @ hex. ADC-JDR3 1b. ;
: ADC-JDR4. ." ADC-JDR4 (read-only) $" ADC-JDR4 @ hex. ADC-JDR4 1b. ;
: ADC-DR. ." ADC-DR (read-only) $" ADC-DR @ hex. ADC-DR 1b. ;
: ADC-SMPR0. ." ADC-SMPR0 (read-write) $" ADC-SMPR0 @ hex. ADC-SMPR0 1b. ;
: ADC.
ADC-SR.
ADC-CR1.
ADC-CR2.
ADC-SMPR1.
ADC-SMPR2.
ADC-SMPR3.
ADC-JOFR1.
ADC-JOFR2.
ADC-JOFR3.
ADC-JOFR4.
ADC-HTR.
ADC-LTR.
ADC-SQR1.
ADC-SQR2.
ADC-SQR3.
ADC-SQR4.
ADC-SQR5.
ADC-JSQR.
ADC-JDR1.
ADC-JDR2.
ADC-JDR3.
ADC-JDR4.
ADC-DR.
ADC-SMPR0.
;

$E000E000 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $4 + constant NVIC-ICTR ( Interrupt Controller Type  Register ) 
NVIC $F00 + constant NVIC-STIR ( Software Triggered Interrupt  Register ) 
NVIC $100 + constant NVIC-ISER0 ( Interrupt Set-Enable Register ) 
NVIC $104 + constant NVIC-ISER1 ( Interrupt Set-Enable Register ) 
NVIC $180 + constant NVIC-ICER0 ( Interrupt Clear-Enable  Register ) 
NVIC $184 + constant NVIC-ICER1 ( Interrupt Clear-Enable  Register ) 
NVIC $200 + constant NVIC-ISPR0 ( Interrupt Set-Pending Register ) 
NVIC $204 + constant NVIC-ISPR1 ( Interrupt Set-Pending Register ) 
NVIC $280 + constant NVIC-ICPR0 ( Interrupt Clear-Pending  Register ) 
NVIC $284 + constant NVIC-ICPR1 ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC-IABR0 ( Interrupt Active Bit Register ) 
NVIC $304 + constant NVIC-IABR1 ( Interrupt Active Bit Register ) 
NVIC $400 + constant NVIC-IPR0 ( Interrupt Priority Register ) 
NVIC $404 + constant NVIC-IPR1 ( Interrupt Priority Register ) 
NVIC $408 + constant NVIC-IPR2 ( Interrupt Priority Register ) 
NVIC $40C + constant NVIC-IPR3 ( Interrupt Priority Register ) 
NVIC $410 + constant NVIC-IPR4 ( Interrupt Priority Register ) 
NVIC $414 + constant NVIC-IPR5 ( Interrupt Priority Register ) 
NVIC $418 + constant NVIC-IPR6 ( Interrupt Priority Register ) 
NVIC $41C + constant NVIC-IPR7 ( Interrupt Priority Register ) 
NVIC $420 + constant NVIC-IPR8 ( Interrupt Priority Register ) 
NVIC $424 + constant NVIC-IPR9 ( Interrupt Priority Register ) 
NVIC $428 + constant NVIC-IPR10 ( Interrupt Priority Register ) 
NVIC $42C + constant NVIC-IPR11 ( Interrupt Priority Register ) 
NVIC $430 + constant NVIC-IPR12 ( Interrupt Priority Register ) 
NVIC $434 + constant NVIC-IPR13 ( Interrupt Priority Register ) 
: NVIC-ICTR. ." NVIC-ICTR (read-only) $" NVIC-ICTR @ hex. NVIC-ICTR 1b. ;
: NVIC-STIR. ." NVIC-STIR (write-only) $" NVIC-STIR @ hex. NVIC-STIR 1b. ;
: NVIC-ISER0. ." NVIC-ISER0 (read-write) $" NVIC-ISER0 @ hex. NVIC-ISER0 1b. ;
: NVIC-ISER1. ." NVIC-ISER1 (read-write) $" NVIC-ISER1 @ hex. NVIC-ISER1 1b. ;
: NVIC-ICER0. ." NVIC-ICER0 (read-write) $" NVIC-ICER0 @ hex. NVIC-ICER0 1b. ;
: NVIC-ICER1. ." NVIC-ICER1 (read-write) $" NVIC-ICER1 @ hex. NVIC-ICER1 1b. ;
: NVIC-ISPR0. ." NVIC-ISPR0 (read-write) $" NVIC-ISPR0 @ hex. NVIC-ISPR0 1b. ;
: NVIC-ISPR1. ." NVIC-ISPR1 (read-write) $" NVIC-ISPR1 @ hex. NVIC-ISPR1 1b. ;
: NVIC-ICPR0. ." NVIC-ICPR0 (read-write) $" NVIC-ICPR0 @ hex. NVIC-ICPR0 1b. ;
: NVIC-ICPR1. ." NVIC-ICPR1 (read-write) $" NVIC-ICPR1 @ hex. NVIC-ICPR1 1b. ;
: NVIC-IABR0. ." NVIC-IABR0 (read-only) $" NVIC-IABR0 @ hex. NVIC-IABR0 1b. ;
: NVIC-IABR1. ." NVIC-IABR1 (read-only) $" NVIC-IABR1 @ hex. NVIC-IABR1 1b. ;
: NVIC-IPR0. ." NVIC-IPR0 (read-write) $" NVIC-IPR0 @ hex. NVIC-IPR0 1b. ;
: NVIC-IPR1. ." NVIC-IPR1 (read-write) $" NVIC-IPR1 @ hex. NVIC-IPR1 1b. ;
: NVIC-IPR2. ." NVIC-IPR2 (read-write) $" NVIC-IPR2 @ hex. NVIC-IPR2 1b. ;
: NVIC-IPR3. ." NVIC-IPR3 (read-write) $" NVIC-IPR3 @ hex. NVIC-IPR3 1b. ;
: NVIC-IPR4. ." NVIC-IPR4 (read-write) $" NVIC-IPR4 @ hex. NVIC-IPR4 1b. ;
: NVIC-IPR5. ." NVIC-IPR5 (read-write) $" NVIC-IPR5 @ hex. NVIC-IPR5 1b. ;
: NVIC-IPR6. ." NVIC-IPR6 (read-write) $" NVIC-IPR6 @ hex. NVIC-IPR6 1b. ;
: NVIC-IPR7. ." NVIC-IPR7 (read-write) $" NVIC-IPR7 @ hex. NVIC-IPR7 1b. ;
: NVIC-IPR8. ." NVIC-IPR8 (read-write) $" NVIC-IPR8 @ hex. NVIC-IPR8 1b. ;
: NVIC-IPR9. ." NVIC-IPR9 (read-write) $" NVIC-IPR9 @ hex. NVIC-IPR9 1b. ;
: NVIC-IPR10. ." NVIC-IPR10 (read-write) $" NVIC-IPR10 @ hex. NVIC-IPR10 1b. ;
: NVIC-IPR11. ." NVIC-IPR11 (read-write) $" NVIC-IPR11 @ hex. NVIC-IPR11 1b. ;
: NVIC-IPR12. ." NVIC-IPR12 (read-write) $" NVIC-IPR12 @ hex. NVIC-IPR12 1b. ;
: NVIC-IPR13. ." NVIC-IPR13 (read-write) $" NVIC-IPR13 @ hex. NVIC-IPR13 1b. ;
: NVIC.
NVIC-ICTR.
NVIC-STIR.
NVIC-ISER0.
NVIC-ISER1.
NVIC-ICER0.
NVIC-ICER1.
NVIC-ISPR0.
NVIC-ISPR1.
NVIC-ICPR0.
NVIC-ICPR1.
NVIC-IABR0.
NVIC-IABR1.
NVIC-IPR0.
NVIC-IPR1.
NVIC-IPR2.
NVIC-IPR3.
NVIC-IPR4.
NVIC-IPR5.
NVIC-IPR6.
NVIC-IPR7.
NVIC-IPR8.
NVIC-IPR9.
NVIC-IPR10.
NVIC-IPR11.
NVIC-IPR12.
NVIC-IPR13.
;

$E0042000 constant DBG ( Debug support ) 
DBG $0 + constant DBG-DBGMCU_IDCODE ( IDCODE ) 
DBG $4 + constant DBG-DBGMCU_CR ( Control Register ) 
DBG $8 + constant DBG-DBGMCU_APB1_FZ ( Debug MCU APB1 Freeze registe ) 
DBG $C + constant DBG-DBGMCU_APB2_FZ ( Debug MCU APB2 Freeze registe ) 
: DBG-DBGMCU_IDCODE. ." DBG-DBGMCU_IDCODE (read-only) $" DBG-DBGMCU_IDCODE @ hex. DBG-DBGMCU_IDCODE 1b. ;
: DBG-DBGMCU_CR. ." DBG-DBGMCU_CR (read-write) $" DBG-DBGMCU_CR @ hex. DBG-DBGMCU_CR 1b. ;
: DBG-DBGMCU_APB1_FZ. ." DBG-DBGMCU_APB1_FZ (read-write) $" DBG-DBGMCU_APB1_FZ @ hex. DBG-DBGMCU_APB1_FZ 1b. ;
: DBG-DBGMCU_APB2_FZ. ." DBG-DBGMCU_APB2_FZ (read-write) $" DBG-DBGMCU_APB2_FZ @ hex. DBG-DBGMCU_APB2_FZ 1b. ;
: DBG.
DBG-DBGMCU_IDCODE.
DBG-DBGMCU_CR.
DBG-DBGMCU_APB1_FZ.
DBG-DBGMCU_APB2_FZ.
;


compiletoram
