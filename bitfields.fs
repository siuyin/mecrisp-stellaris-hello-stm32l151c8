\ STM32L15xC Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2018 and released under the GPL V2.
\ Replace 'bis!' (set bit) with 'bic!' to CLEAR bit, 'bit@' to test bit etc.


\ C_ADC-CSR (read-only)
: C_ADC-CSR_ADONS1   %1 6 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_ADONS1    ADON Status of ADC
: C_ADC-CSR_OVR1   %1 5 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_OVR1    Overrun flag of ADC 1
: C_ADC-CSR_STRT1   %1 4 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_STRT1    Regular channel Start flag of ADC  1
: C_ADC-CSR_JSTRT1   %1 3 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_JSTRT1    Injected channel Start flag of ADC  1
: C_ADC-CSR_JEOC1   %1 2 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_JEOC1    Injected channel end of conversion of  ADC 1
: C_ADC-CSR_EOC1   %1 1 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_EOC1    End of conversion of ADC 1
: C_ADC-CSR_AWD1   %1 0 lshift C_ADC-CSR bis! ;  \ C_ADC-CSR_AWD1    Analog watchdog flag of ADC  1

\ C_ADC-CCR (read-write)
: C_ADC-CCR_TSVREFE   %1 23 lshift C_ADC-CCR bis! ;  \ C_ADC-CCR_TSVREFE    Temperature sensor and VREFINT  enable
: C_ADC-CCR_ADCPRE   ( %XX -- ) 16 lshift C_ADC-CCR bis! ;  \ C_ADC-CCR_ADCPRE    ADC prescaler

\ COMP-CSR ()
: COMP-CSR_TSUSP   %1 31 lshift COMP-CSR bis! ;  \ COMP-CSR_TSUSP    Suspend Timer Mode
: COMP-CSR_CAIF   %1 30 lshift COMP-CSR bis! ;  \ COMP-CSR_CAIF    Channel acquisition interrupt  flag
: COMP-CSR_CAIE   %1 29 lshift COMP-CSR bis! ;  \ COMP-CSR_CAIE    Channel Acquisition Interrupt Enable /  Clear
: COMP-CSR_RCH13   %1 28 lshift COMP-CSR bis! ;  \ COMP-CSR_RCH13    Select GPIO port PC3 as re-routed ADC  input channel CH13.
: COMP-CSR_FCH8   %1 27 lshift COMP-CSR bis! ;  \ COMP-CSR_FCH8    Select GPIO port PB0 as fast ADC input  channel CH8.
: COMP-CSR_FCH3   %1 26 lshift COMP-CSR bis! ;  \ COMP-CSR_FCH3    Select GPIO port PA3 as fast ADC input  channel CH3.
: COMP-CSR_OUTSEL   ( %XXX -- ) 21 lshift COMP-CSR bis! ;  \ COMP-CSR_OUTSEL    Comparator 2 output  selection
: COMP-CSR_INSEL   ( %XXX -- ) 18 lshift COMP-CSR bis! ;  \ COMP-CSR_INSEL    Inverted input selection
: COMP-CSR_WNDWE   %1 17 lshift COMP-CSR bis! ;  \ COMP-CSR_WNDWE    Window mode enable
: COMP-CSR_VREFOUTEN   %1 16 lshift COMP-CSR bis! ;  \ COMP-CSR_VREFOUTEN    VREFINT output enable
: COMP-CSR_CMP2OUT   %1 13 lshift COMP-CSR bis! ;  \ COMP-CSR_CMP2OUT    Comparator 2 output
: COMP-CSR_SPEED   %1 12 lshift COMP-CSR bis! ;  \ COMP-CSR_SPEED    Comparator 2 speed mode
: COMP-CSR_CMP1OUT   %1 7 lshift COMP-CSR bis! ;  \ COMP-CSR_CMP1OUT    Comparator 1 output
: COMP-CSR_SW1   %1 5 lshift COMP-CSR bis! ;  \ COMP-CSR_SW1    SW1 analog switch enable
: COMP-CSR_CMP1EN   %1 4 lshift COMP-CSR bis! ;  \ COMP-CSR_CMP1EN    Comparator 1 enable
: COMP-CSR_PD400K   %1 3 lshift COMP-CSR bis! ;  \ COMP-CSR_PD400K    400 kO pull-down resistor
: COMP-CSR_PD10K   %1 2 lshift COMP-CSR bis! ;  \ COMP-CSR_PD10K    10 kO pull-down resistor
: COMP-CSR_PU400K   %1 1 lshift COMP-CSR bis! ;  \ COMP-CSR_PU400K    400 kO pull-up resistor
: COMP-CSR_PU10K   %1 0 lshift COMP-CSR bis! ;  \ COMP-CSR_PU10K    10 kO pull-up resistor

\ CRC-DR (read-write)
: CRC-DR_Data_register   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC-DR bis! ;  \ CRC-DR_Data_register    Data Register

\ CRC-IDR (read-write)
: CRC-IDR_Independent_data_register   ( %XXXXXXX -- ) 0 lshift CRC-IDR bis! ;  \ CRC-IDR_Independent_data_register    Independent data register

\ CRC-CR (write-only)
: CRC-CR_RESET   %1 0 lshift CRC-CR bis! ;  \ CRC-CR_RESET    RESET

\ DAC-CR (read-write)
: DAC-CR_DMAUDRIE2   %1 29 lshift DAC-CR bis! ;  \ DAC-CR_DMAUDRIE2    DAC channel2 DMA underrun interrupt  enable
: DAC-CR_DMAEN2   %1 28 lshift DAC-CR bis! ;  \ DAC-CR_DMAEN2    DAC channel2 DMA enable
: DAC-CR_MAMP2   ( %XXXX -- ) 24 lshift DAC-CR bis! ;  \ DAC-CR_MAMP2    DAC channel2 mask/amplitude  selector
: DAC-CR_WAVE2   ( %XX -- ) 22 lshift DAC-CR bis! ;  \ DAC-CR_WAVE2    DAC channel2 noise/triangle wave  generation enable
: DAC-CR_TSEL2   ( %XXX -- ) 19 lshift DAC-CR bis! ;  \ DAC-CR_TSEL2    DAC channel2 trigger  selection
: DAC-CR_TEN2   %1 18 lshift DAC-CR bis! ;  \ DAC-CR_TEN2    DAC channel2 trigger  enable
: DAC-CR_BOFF2   %1 17 lshift DAC-CR bis! ;  \ DAC-CR_BOFF2    DAC channel2 output buffer  disable
: DAC-CR_EN2   %1 16 lshift DAC-CR bis! ;  \ DAC-CR_EN2    DAC channel2 enable
: DAC-CR_DMAUDRIE1   %1 13 lshift DAC-CR bis! ;  \ DAC-CR_DMAUDRIE1    DAC channel1 DMA Underrun Interrupt  enable
: DAC-CR_DMAEN1   %1 12 lshift DAC-CR bis! ;  \ DAC-CR_DMAEN1    DAC channel1 DMA enable
: DAC-CR_MAMP1   ( %XXXX -- ) 8 lshift DAC-CR bis! ;  \ DAC-CR_MAMP1    DAC channel1 mask/amplitude  selector
: DAC-CR_WAVE1   ( %XX -- ) 6 lshift DAC-CR bis! ;  \ DAC-CR_WAVE1    DAC channel1 noise/triangle wave  generation enable
: DAC-CR_TSEL1   ( %XXX -- ) 3 lshift DAC-CR bis! ;  \ DAC-CR_TSEL1    DAC channel1 trigger  selection
: DAC-CR_TEN1   %1 2 lshift DAC-CR bis! ;  \ DAC-CR_TEN1    DAC channel1 trigger  enable
: DAC-CR_BOFF1   %1 1 lshift DAC-CR bis! ;  \ DAC-CR_BOFF1    DAC channel1 output buffer  disable
: DAC-CR_EN1   %1 0 lshift DAC-CR bis! ;  \ DAC-CR_EN1    DAC channel1 enable

\ DAC-SWTRIGR (write-only)
: DAC-SWTRIGR_SWTRIG2   %1 1 lshift DAC-SWTRIGR bis! ;  \ DAC-SWTRIGR_SWTRIG2    DAC channel2 software  trigger
: DAC-SWTRIGR_SWTRIG1   %1 0 lshift DAC-SWTRIGR bis! ;  \ DAC-SWTRIGR_SWTRIG1    DAC channel1 software  trigger

\ DAC-DHR12R1 (read-write)
: DAC-DHR12R1_DACC1DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12R1 bis! ;  \ DAC-DHR12R1_DACC1DHR    DAC channel1 12-bit right-aligned  data

\ DAC-DHR12L1 (read-write)
: DAC-DHR12L1_DACC1DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12L1 bis! ;  \ DAC-DHR12L1_DACC1DHR    DAC channel1 12-bit left-aligned  data

\ DAC-DHR8R1 (read-write)
: DAC-DHR8R1_DACC1DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8R1 bis! ;  \ DAC-DHR8R1_DACC1DHR    DAC channel1 8-bit right-aligned  data

\ DAC-DHR12R2 (read-write)
: DAC-DHR12R2_DACC2DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12R2 bis! ;  \ DAC-DHR12R2_DACC2DHR    DAC channel2 12-bit right-aligned  data

\ DAC-DHR12L2 (read-write)
: DAC-DHR12L2_DACC2DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12L2 bis! ;  \ DAC-DHR12L2_DACC2DHR    DAC channel2 12-bit left-aligned  data

\ DAC-DHR8R2 (read-write)
: DAC-DHR8R2_DACC2DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8R2 bis! ;  \ DAC-DHR8R2_DACC2DHR    DAC channel2 8-bit right-aligned  data

\ DAC-DHR12RD (read-write)
: DAC-DHR12RD_DACC2DHR   ( %XXXXXXXXXXX -- ) 16 lshift DAC-DHR12RD bis! ;  \ DAC-DHR12RD_DACC2DHR    DAC channel2 12-bit right-aligned  data
: DAC-DHR12RD_DACC1DHR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DHR12RD bis! ;  \ DAC-DHR12RD_DACC1DHR    DAC channel1 12-bit right-aligned  data

\ DAC-DHR12LD (read-write)
: DAC-DHR12LD_DACC2DHR   ( %XXXXXXXXXXX -- ) 20 lshift DAC-DHR12LD bis! ;  \ DAC-DHR12LD_DACC2DHR    DAC channel2 12-bit left-aligned  data
: DAC-DHR12LD_DACC1DHR   ( %XXXXXXXXXXX -- ) 4 lshift DAC-DHR12LD bis! ;  \ DAC-DHR12LD_DACC1DHR    DAC channel1 12-bit left-aligned  data

\ DAC-DHR8RD (read-write)
: DAC-DHR8RD_DACC2DHR   ( %XXXXXXXX -- ) 8 lshift DAC-DHR8RD bis! ;  \ DAC-DHR8RD_DACC2DHR    DAC channel2 8-bit right-aligned  data
: DAC-DHR8RD_DACC1DHR   ( %XXXXXXXX -- ) 0 lshift DAC-DHR8RD bis! ;  \ DAC-DHR8RD_DACC1DHR    DAC channel1 8-bit right-aligned  data

\ DAC-DOR1 (read-only)
: DAC-DOR1_DACC1DOR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DOR1 bis! ;  \ DAC-DOR1_DACC1DOR    DAC channel1 data output

\ DAC-DOR2 (read-only)
: DAC-DOR2_DACC2DOR   ( %XXXXXXXXXXX -- ) 0 lshift DAC-DOR2 bis! ;  \ DAC-DOR2_DACC2DOR    DAC channel2 data output

\ DAC-SR (read-write)
: DAC-SR_DMAUDR2   %1 29 lshift DAC-SR bis! ;  \ DAC-SR_DMAUDR2    DAC channel2 DMA underrun  flag
: DAC-SR_DMAUDR1   %1 13 lshift DAC-SR bis! ;  \ DAC-SR_DMAUDR1    DAC channel1 DMA underrun  flag

\ DMA1-ISR (read-only)
: DMA1-ISR_TEIF7   %1 27 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF7    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF7   %1 26 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF7    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF7   %1 25 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF7    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF7   %1 24 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF7    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF6   %1 23 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF6    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF6   %1 22 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF6    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF6   %1 21 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF6    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF6   %1 20 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF6    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF5   %1 19 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF5    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF5   %1 18 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF5    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF5   %1 17 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF5    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF5   %1 16 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF5    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF4   %1 15 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF4    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF4   %1 14 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF4    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF4   %1 13 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF4    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF4   %1 12 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF4    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF3   %1 11 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF3    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF3   %1 10 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF3    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF3   %1 9 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF3    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF3   %1 8 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF3    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF2   %1 7 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF2    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF2   %1 6 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF2    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF2   %1 5 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF2    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF2   %1 4 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF2    Channel x global interrupt flag x = 1  ..7
: DMA1-ISR_TEIF1   %1 3 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TEIF1    Channel x transfer error flag x = 1  ..7
: DMA1-ISR_HTIF1   %1 2 lshift DMA1-ISR bis! ;  \ DMA1-ISR_HTIF1    Channel x half transfer flag x = 1  ..7
: DMA1-ISR_TCIF1   %1 1 lshift DMA1-ISR bis! ;  \ DMA1-ISR_TCIF1    Channel x transfer complete flag x = 1  ..7
: DMA1-ISR_GIF1   %1 0 lshift DMA1-ISR bis! ;  \ DMA1-ISR_GIF1    Channel x global interrupt flag x = 1  ..7

\ DMA1-IFCR (write-only)
: DMA1-IFCR_CTEIF7   %1 27 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF7    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF7   %1 26 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF7    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF7   %1 25 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF7    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF7   %1 24 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF7    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF6   %1 23 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF6    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF6   %1 22 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF6    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF6   %1 21 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF6    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF6   %1 20 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF6    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF5   %1 19 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF5    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF5   %1 18 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF5    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF5   %1 17 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF5    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF5   %1 16 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF5    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF4   %1 15 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF4    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF4   %1 14 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF4    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF4   %1 13 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF4    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF4   %1 12 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF4    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF3   %1 11 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF3    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF3   %1 10 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF3    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF3   %1 9 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF3    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF3   %1 8 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF3    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF2   %1 7 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF2    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF2   %1 6 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF2    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF2   %1 5 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF2    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF2   %1 4 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF2    Channel x global interrupt clear x = 1  ..7
: DMA1-IFCR_CTEIF1   %1 3 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTEIF1    Channel x transfer error clear x = 1  ..7
: DMA1-IFCR_CHTIF1   %1 2 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CHTIF1    Channel x half transfer clear x = 1  ..7
: DMA1-IFCR_CTCIF1   %1 1 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CTCIF1    Channel x transfer complete clear x = 1  ..7
: DMA1-IFCR_CGIF1   %1 0 lshift DMA1-IFCR bis! ;  \ DMA1-IFCR_CGIF1    Channel x global interrupt clear x = 1  ..7

\ DMA1-CCR1 (read-write)
: DMA1-CCR1_MEM2MEM   %1 14 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MEM2MEM    Memory to memory mode
: DMA1-CCR1_PL   ( %XX -- ) 12 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PL    Channel priority level
: DMA1-CCR1_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MSIZE    Memory size
: DMA1-CCR1_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PSIZE    Peripheral size
: DMA1-CCR1_MINC   %1 7 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_MINC    Memory increment mode
: DMA1-CCR1_PINC   %1 6 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_PINC    Peripheral increment mode
: DMA1-CCR1_CIRC   %1 5 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_CIRC    Circular mode
: DMA1-CCR1_DIR   %1 4 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_DIR    Data transfer direction
: DMA1-CCR1_TEIE   %1 3 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_TEIE    Transfer error interrupt  enable
: DMA1-CCR1_HTIE   %1 2 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_HTIE    Half transfer interrupt  enable
: DMA1-CCR1_TCIE   %1 1 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_TCIE    Transfer complete interrupt  enable
: DMA1-CCR1_EN   %1 0 lshift DMA1-CCR1 bis! ;  \ DMA1-CCR1_EN    Channel enable

\ DMA1-CNDTR1 (read-write)
: DMA1-CNDTR1_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR1 bis! ;  \ DMA1-CNDTR1_NDT    Number of data to transfer

\ DMA1-CPAR1 (read-write)
: DMA1-CPAR1_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR1 bis! ;  \ DMA1-CPAR1_PA    Peripheral address

\ DMA1-CMAR1 (read-write)
: DMA1-CMAR1_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR1 bis! ;  \ DMA1-CMAR1_MA    Memory address

\ DMA1-CCR2 (read-write)
: DMA1-CCR2_MEM2MEM   %1 14 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MEM2MEM    Memory to memory mode
: DMA1-CCR2_PL   ( %XX -- ) 12 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PL    Channel priority level
: DMA1-CCR2_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MSIZE    Memory size
: DMA1-CCR2_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PSIZE    Peripheral size
: DMA1-CCR2_MINC   %1 7 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_MINC    Memory increment mode
: DMA1-CCR2_PINC   %1 6 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_PINC    Peripheral increment mode
: DMA1-CCR2_CIRC   %1 5 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_CIRC    Circular mode
: DMA1-CCR2_DIR   %1 4 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_DIR    Data transfer direction
: DMA1-CCR2_TEIE   %1 3 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_TEIE    Transfer error interrupt  enable
: DMA1-CCR2_HTIE   %1 2 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_HTIE    Half transfer interrupt  enable
: DMA1-CCR2_TCIE   %1 1 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_TCIE    Transfer complete interrupt  enable
: DMA1-CCR2_EN   %1 0 lshift DMA1-CCR2 bis! ;  \ DMA1-CCR2_EN    Channel enable

\ DMA1-CNDTR2 (read-write)
: DMA1-CNDTR2_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR2 bis! ;  \ DMA1-CNDTR2_NDT    Number of data to transfer

\ DMA1-CPAR2 (read-write)
: DMA1-CPAR2_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR2 bis! ;  \ DMA1-CPAR2_PA    Peripheral address

\ DMA1-CMAR2 (read-write)
: DMA1-CMAR2_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR2 bis! ;  \ DMA1-CMAR2_MA    Memory address

\ DMA1-CCR3 (read-write)
: DMA1-CCR3_MEM2MEM   %1 14 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MEM2MEM    Memory to memory mode
: DMA1-CCR3_PL   ( %XX -- ) 12 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PL    Channel priority level
: DMA1-CCR3_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MSIZE    Memory size
: DMA1-CCR3_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PSIZE    Peripheral size
: DMA1-CCR3_MINC   %1 7 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_MINC    Memory increment mode
: DMA1-CCR3_PINC   %1 6 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_PINC    Peripheral increment mode
: DMA1-CCR3_CIRC   %1 5 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_CIRC    Circular mode
: DMA1-CCR3_DIR   %1 4 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_DIR    Data transfer direction
: DMA1-CCR3_TEIE   %1 3 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_TEIE    Transfer error interrupt  enable
: DMA1-CCR3_HTIE   %1 2 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_HTIE    Half transfer interrupt  enable
: DMA1-CCR3_TCIE   %1 1 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_TCIE    Transfer complete interrupt  enable
: DMA1-CCR3_EN   %1 0 lshift DMA1-CCR3 bis! ;  \ DMA1-CCR3_EN    Channel enable

\ DMA1-CNDTR3 (read-write)
: DMA1-CNDTR3_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR3 bis! ;  \ DMA1-CNDTR3_NDT    Number of data to transfer

\ DMA1-CPAR3 (read-write)
: DMA1-CPAR3_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR3 bis! ;  \ DMA1-CPAR3_PA    Peripheral address

\ DMA1-CMAR3 (read-write)
: DMA1-CMAR3_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR3 bis! ;  \ DMA1-CMAR3_MA    Memory address

\ DMA1-CCR4 (read-write)
: DMA1-CCR4_MEM2MEM   %1 14 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MEM2MEM    Memory to memory mode
: DMA1-CCR4_PL   ( %XX -- ) 12 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PL    Channel priority level
: DMA1-CCR4_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MSIZE    Memory size
: DMA1-CCR4_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PSIZE    Peripheral size
: DMA1-CCR4_MINC   %1 7 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_MINC    Memory increment mode
: DMA1-CCR4_PINC   %1 6 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_PINC    Peripheral increment mode
: DMA1-CCR4_CIRC   %1 5 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_CIRC    Circular mode
: DMA1-CCR4_DIR   %1 4 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_DIR    Data transfer direction
: DMA1-CCR4_TEIE   %1 3 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_TEIE    Transfer error interrupt  enable
: DMA1-CCR4_HTIE   %1 2 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_HTIE    Half transfer interrupt  enable
: DMA1-CCR4_TCIE   %1 1 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_TCIE    Transfer complete interrupt  enable
: DMA1-CCR4_EN   %1 0 lshift DMA1-CCR4 bis! ;  \ DMA1-CCR4_EN    Channel enable

\ DMA1-CNDTR4 (read-write)
: DMA1-CNDTR4_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR4 bis! ;  \ DMA1-CNDTR4_NDT    Number of data to transfer

\ DMA1-CPAR4 (read-write)
: DMA1-CPAR4_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR4 bis! ;  \ DMA1-CPAR4_PA    Peripheral address

\ DMA1-CMAR4 (read-write)
: DMA1-CMAR4_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR4 bis! ;  \ DMA1-CMAR4_MA    Memory address

\ DMA1-CCR5 (read-write)
: DMA1-CCR5_MEM2MEM   %1 14 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MEM2MEM    Memory to memory mode
: DMA1-CCR5_PL   ( %XX -- ) 12 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PL    Channel priority level
: DMA1-CCR5_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MSIZE    Memory size
: DMA1-CCR5_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PSIZE    Peripheral size
: DMA1-CCR5_MINC   %1 7 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_MINC    Memory increment mode
: DMA1-CCR5_PINC   %1 6 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_PINC    Peripheral increment mode
: DMA1-CCR5_CIRC   %1 5 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_CIRC    Circular mode
: DMA1-CCR5_DIR   %1 4 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_DIR    Data transfer direction
: DMA1-CCR5_TEIE   %1 3 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_TEIE    Transfer error interrupt  enable
: DMA1-CCR5_HTIE   %1 2 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_HTIE    Half transfer interrupt  enable
: DMA1-CCR5_TCIE   %1 1 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_TCIE    Transfer complete interrupt  enable
: DMA1-CCR5_EN   %1 0 lshift DMA1-CCR5 bis! ;  \ DMA1-CCR5_EN    Channel enable

\ DMA1-CNDTR5 (read-write)
: DMA1-CNDTR5_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR5 bis! ;  \ DMA1-CNDTR5_NDT    Number of data to transfer

\ DMA1-CPAR5 (read-write)
: DMA1-CPAR5_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR5 bis! ;  \ DMA1-CPAR5_PA    Peripheral address

\ DMA1-CMAR5 (read-write)
: DMA1-CMAR5_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR5 bis! ;  \ DMA1-CMAR5_MA    Memory address

\ DMA1-CCR6 (read-write)
: DMA1-CCR6_MEM2MEM   %1 14 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MEM2MEM    Memory to memory mode
: DMA1-CCR6_PL   ( %XX -- ) 12 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PL    Channel priority level
: DMA1-CCR6_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MSIZE    Memory size
: DMA1-CCR6_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PSIZE    Peripheral size
: DMA1-CCR6_MINC   %1 7 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_MINC    Memory increment mode
: DMA1-CCR6_PINC   %1 6 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_PINC    Peripheral increment mode
: DMA1-CCR6_CIRC   %1 5 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_CIRC    Circular mode
: DMA1-CCR6_DIR   %1 4 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_DIR    Data transfer direction
: DMA1-CCR6_TEIE   %1 3 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_TEIE    Transfer error interrupt  enable
: DMA1-CCR6_HTIE   %1 2 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_HTIE    Half transfer interrupt  enable
: DMA1-CCR6_TCIE   %1 1 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_TCIE    Transfer complete interrupt  enable
: DMA1-CCR6_EN   %1 0 lshift DMA1-CCR6 bis! ;  \ DMA1-CCR6_EN    Channel enable

\ DMA1-CNDTR6 (read-write)
: DMA1-CNDTR6_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR6 bis! ;  \ DMA1-CNDTR6_NDT    Number of data to transfer

\ DMA1-CPAR6 (read-write)
: DMA1-CPAR6_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR6 bis! ;  \ DMA1-CPAR6_PA    Peripheral address

\ DMA1-CMAR6 (read-write)
: DMA1-CMAR6_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR6 bis! ;  \ DMA1-CMAR6_MA    Memory address

\ DMA1-CCR7 (read-write)
: DMA1-CCR7_MEM2MEM   %1 14 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MEM2MEM    Memory to memory mode
: DMA1-CCR7_PL   ( %XX -- ) 12 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PL    Channel priority level
: DMA1-CCR7_MSIZE   ( %XX -- ) 10 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MSIZE    Memory size
: DMA1-CCR7_PSIZE   ( %XX -- ) 8 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PSIZE    Peripheral size
: DMA1-CCR7_MINC   %1 7 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_MINC    Memory increment mode
: DMA1-CCR7_PINC   %1 6 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_PINC    Peripheral increment mode
: DMA1-CCR7_CIRC   %1 5 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_CIRC    Circular mode
: DMA1-CCR7_DIR   %1 4 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_DIR    Data transfer direction
: DMA1-CCR7_TEIE   %1 3 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_TEIE    Transfer error interrupt  enable
: DMA1-CCR7_HTIE   %1 2 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_HTIE    Half transfer interrupt  enable
: DMA1-CCR7_TCIE   %1 1 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_TCIE    Transfer complete interrupt  enable
: DMA1-CCR7_EN   %1 0 lshift DMA1-CCR7 bis! ;  \ DMA1-CCR7_EN    Channel enable

\ DMA1-CNDTR7 (read-write)
: DMA1-CNDTR7_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CNDTR7 bis! ;  \ DMA1-CNDTR7_NDT    Number of data to transfer

\ DMA1-CPAR7 (read-write)
: DMA1-CPAR7_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CPAR7 bis! ;  \ DMA1-CPAR7_PA    Peripheral address

\ DMA1-CMAR7 (read-write)
: DMA1-CMAR7_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA1-CMAR7 bis! ;  \ DMA1-CMAR7_MA    Memory address

\ DMA2-ISR (read-only)
: DMA2-ISR_TEIF7   %1 27 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF7    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF7   %1 26 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF7    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF7   %1 25 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF7    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF7   %1 24 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF7    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF6   %1 23 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF6    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF6   %1 22 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF6    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF6   %1 21 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF6    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF6   %1 20 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF6    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF5   %1 19 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF5    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF5   %1 18 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF5    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF5   %1 17 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF5    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF5   %1 16 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF5    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF4   %1 15 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF4    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF4   %1 14 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF4    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF4   %1 13 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF4    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF4   %1 12 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF4    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF3   %1 11 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF3    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF3   %1 10 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF3    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF3   %1 9 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF3    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF3   %1 8 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF3    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF2   %1 7 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF2    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF2   %1 6 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF2    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF2   %1 5 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF2    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF2   %1 4 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF2    Channel x global interrupt flag x = 1  ..7
: DMA2-ISR_TEIF1   %1 3 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TEIF1    Channel x transfer error flag x = 1  ..7
: DMA2-ISR_HTIF1   %1 2 lshift DMA2-ISR bis! ;  \ DMA2-ISR_HTIF1    Channel x half transfer flag x = 1  ..7
: DMA2-ISR_TCIF1   %1 1 lshift DMA2-ISR bis! ;  \ DMA2-ISR_TCIF1    Channel x transfer complete flag x = 1  ..7
: DMA2-ISR_GIF1   %1 0 lshift DMA2-ISR bis! ;  \ DMA2-ISR_GIF1    Channel x global interrupt flag x = 1  ..7

\ DMA2-IFCR (write-only)
: DMA2-IFCR_CTEIF7   %1 27 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF7    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF7   %1 26 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF7    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF7   %1 25 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF7    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF7   %1 24 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF7    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF6   %1 23 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF6    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF6   %1 22 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF6    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF6   %1 21 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF6    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF6   %1 20 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF6    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF5   %1 19 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF5    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF5   %1 18 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF5    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF5   %1 17 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF5    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF5   %1 16 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF5    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF4   %1 15 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF4    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF4   %1 14 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF4    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF4   %1 13 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF4    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF4   %1 12 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF4    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF3   %1 11 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF3    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF3   %1 10 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF3    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF3   %1 9 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF3    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF3   %1 8 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF3    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF2   %1 7 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF2    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF2   %1 6 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF2    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF2   %1 5 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF2    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF2   %1 4 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF2    Channel x global interrupt clear x = 1  ..7
: DMA2-IFCR_CTEIF1   %1 3 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTEIF1    Channel x transfer error clear x = 1  ..7
: DMA2-IFCR_CHTIF1   %1 2 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CHTIF1    Channel x half transfer clear x = 1  ..7
: DMA2-IFCR_CTCIF1   %1 1 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CTCIF1    Channel x transfer complete clear x = 1  ..7
: DMA2-IFCR_CGIF1   %1 0 lshift DMA2-IFCR bis! ;  \ DMA2-IFCR_CGIF1    Channel x global interrupt clear x = 1  ..7

\ DMA2-CCR1 (read-write)
: DMA2-CCR1_MEM2MEM   %1 14 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MEM2MEM    Memory to memory mode
: DMA2-CCR1_PL   ( %XX -- ) 12 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PL    Channel priority level
: DMA2-CCR1_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MSIZE    Memory size
: DMA2-CCR1_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PSIZE    Peripheral size
: DMA2-CCR1_MINC   %1 7 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_MINC    Memory increment mode
: DMA2-CCR1_PINC   %1 6 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_PINC    Peripheral increment mode
: DMA2-CCR1_CIRC   %1 5 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_CIRC    Circular mode
: DMA2-CCR1_DIR   %1 4 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_DIR    Data transfer direction
: DMA2-CCR1_TEIE   %1 3 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_TEIE    Transfer error interrupt  enable
: DMA2-CCR1_HTIE   %1 2 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_HTIE    Half transfer interrupt  enable
: DMA2-CCR1_TCIE   %1 1 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_TCIE    Transfer complete interrupt  enable
: DMA2-CCR1_EN   %1 0 lshift DMA2-CCR1 bis! ;  \ DMA2-CCR1_EN    Channel enable

\ DMA2-CNDTR1 (read-write)
: DMA2-CNDTR1_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR1 bis! ;  \ DMA2-CNDTR1_NDT    Number of data to transfer

\ DMA2-CPAR1 (read-write)
: DMA2-CPAR1_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR1 bis! ;  \ DMA2-CPAR1_PA    Peripheral address

\ DMA2-CMAR1 (read-write)
: DMA2-CMAR1_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR1 bis! ;  \ DMA2-CMAR1_MA    Memory address

\ DMA2-CCR2 (read-write)
: DMA2-CCR2_MEM2MEM   %1 14 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MEM2MEM    Memory to memory mode
: DMA2-CCR2_PL   ( %XX -- ) 12 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PL    Channel priority level
: DMA2-CCR2_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MSIZE    Memory size
: DMA2-CCR2_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PSIZE    Peripheral size
: DMA2-CCR2_MINC   %1 7 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_MINC    Memory increment mode
: DMA2-CCR2_PINC   %1 6 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_PINC    Peripheral increment mode
: DMA2-CCR2_CIRC   %1 5 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_CIRC    Circular mode
: DMA2-CCR2_DIR   %1 4 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_DIR    Data transfer direction
: DMA2-CCR2_TEIE   %1 3 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_TEIE    Transfer error interrupt  enable
: DMA2-CCR2_HTIE   %1 2 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_HTIE    Half transfer interrupt  enable
: DMA2-CCR2_TCIE   %1 1 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_TCIE    Transfer complete interrupt  enable
: DMA2-CCR2_EN   %1 0 lshift DMA2-CCR2 bis! ;  \ DMA2-CCR2_EN    Channel enable

\ DMA2-CNDTR2 (read-write)
: DMA2-CNDTR2_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR2 bis! ;  \ DMA2-CNDTR2_NDT    Number of data to transfer

\ DMA2-CPAR2 (read-write)
: DMA2-CPAR2_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR2 bis! ;  \ DMA2-CPAR2_PA    Peripheral address

\ DMA2-CMAR2 (read-write)
: DMA2-CMAR2_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR2 bis! ;  \ DMA2-CMAR2_MA    Memory address

\ DMA2-CCR3 (read-write)
: DMA2-CCR3_MEM2MEM   %1 14 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MEM2MEM    Memory to memory mode
: DMA2-CCR3_PL   ( %XX -- ) 12 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PL    Channel priority level
: DMA2-CCR3_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MSIZE    Memory size
: DMA2-CCR3_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PSIZE    Peripheral size
: DMA2-CCR3_MINC   %1 7 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_MINC    Memory increment mode
: DMA2-CCR3_PINC   %1 6 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_PINC    Peripheral increment mode
: DMA2-CCR3_CIRC   %1 5 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_CIRC    Circular mode
: DMA2-CCR3_DIR   %1 4 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_DIR    Data transfer direction
: DMA2-CCR3_TEIE   %1 3 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_TEIE    Transfer error interrupt  enable
: DMA2-CCR3_HTIE   %1 2 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_HTIE    Half transfer interrupt  enable
: DMA2-CCR3_TCIE   %1 1 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_TCIE    Transfer complete interrupt  enable
: DMA2-CCR3_EN   %1 0 lshift DMA2-CCR3 bis! ;  \ DMA2-CCR3_EN    Channel enable

\ DMA2-CNDTR3 (read-write)
: DMA2-CNDTR3_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR3 bis! ;  \ DMA2-CNDTR3_NDT    Number of data to transfer

\ DMA2-CPAR3 (read-write)
: DMA2-CPAR3_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR3 bis! ;  \ DMA2-CPAR3_PA    Peripheral address

\ DMA2-CMAR3 (read-write)
: DMA2-CMAR3_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR3 bis! ;  \ DMA2-CMAR3_MA    Memory address

\ DMA2-CCR4 (read-write)
: DMA2-CCR4_MEM2MEM   %1 14 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MEM2MEM    Memory to memory mode
: DMA2-CCR4_PL   ( %XX -- ) 12 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PL    Channel priority level
: DMA2-CCR4_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MSIZE    Memory size
: DMA2-CCR4_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PSIZE    Peripheral size
: DMA2-CCR4_MINC   %1 7 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_MINC    Memory increment mode
: DMA2-CCR4_PINC   %1 6 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_PINC    Peripheral increment mode
: DMA2-CCR4_CIRC   %1 5 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_CIRC    Circular mode
: DMA2-CCR4_DIR   %1 4 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_DIR    Data transfer direction
: DMA2-CCR4_TEIE   %1 3 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_TEIE    Transfer error interrupt  enable
: DMA2-CCR4_HTIE   %1 2 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_HTIE    Half transfer interrupt  enable
: DMA2-CCR4_TCIE   %1 1 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_TCIE    Transfer complete interrupt  enable
: DMA2-CCR4_EN   %1 0 lshift DMA2-CCR4 bis! ;  \ DMA2-CCR4_EN    Channel enable

\ DMA2-CNDTR4 (read-write)
: DMA2-CNDTR4_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR4 bis! ;  \ DMA2-CNDTR4_NDT    Number of data to transfer

\ DMA2-CPAR4 (read-write)
: DMA2-CPAR4_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR4 bis! ;  \ DMA2-CPAR4_PA    Peripheral address

\ DMA2-CMAR4 (read-write)
: DMA2-CMAR4_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR4 bis! ;  \ DMA2-CMAR4_MA    Memory address

\ DMA2-CCR5 (read-write)
: DMA2-CCR5_MEM2MEM   %1 14 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MEM2MEM    Memory to memory mode
: DMA2-CCR5_PL   ( %XX -- ) 12 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PL    Channel priority level
: DMA2-CCR5_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MSIZE    Memory size
: DMA2-CCR5_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PSIZE    Peripheral size
: DMA2-CCR5_MINC   %1 7 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_MINC    Memory increment mode
: DMA2-CCR5_PINC   %1 6 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_PINC    Peripheral increment mode
: DMA2-CCR5_CIRC   %1 5 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_CIRC    Circular mode
: DMA2-CCR5_DIR   %1 4 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_DIR    Data transfer direction
: DMA2-CCR5_TEIE   %1 3 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_TEIE    Transfer error interrupt  enable
: DMA2-CCR5_HTIE   %1 2 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_HTIE    Half transfer interrupt  enable
: DMA2-CCR5_TCIE   %1 1 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_TCIE    Transfer complete interrupt  enable
: DMA2-CCR5_EN   %1 0 lshift DMA2-CCR5 bis! ;  \ DMA2-CCR5_EN    Channel enable

\ DMA2-CNDTR5 (read-write)
: DMA2-CNDTR5_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR5 bis! ;  \ DMA2-CNDTR5_NDT    Number of data to transfer

\ DMA2-CPAR5 (read-write)
: DMA2-CPAR5_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR5 bis! ;  \ DMA2-CPAR5_PA    Peripheral address

\ DMA2-CMAR5 (read-write)
: DMA2-CMAR5_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR5 bis! ;  \ DMA2-CMAR5_MA    Memory address

\ DMA2-CCR6 (read-write)
: DMA2-CCR6_MEM2MEM   %1 14 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MEM2MEM    Memory to memory mode
: DMA2-CCR6_PL   ( %XX -- ) 12 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PL    Channel priority level
: DMA2-CCR6_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MSIZE    Memory size
: DMA2-CCR6_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PSIZE    Peripheral size
: DMA2-CCR6_MINC   %1 7 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_MINC    Memory increment mode
: DMA2-CCR6_PINC   %1 6 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_PINC    Peripheral increment mode
: DMA2-CCR6_CIRC   %1 5 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_CIRC    Circular mode
: DMA2-CCR6_DIR   %1 4 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_DIR    Data transfer direction
: DMA2-CCR6_TEIE   %1 3 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_TEIE    Transfer error interrupt  enable
: DMA2-CCR6_HTIE   %1 2 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_HTIE    Half transfer interrupt  enable
: DMA2-CCR6_TCIE   %1 1 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_TCIE    Transfer complete interrupt  enable
: DMA2-CCR6_EN   %1 0 lshift DMA2-CCR6 bis! ;  \ DMA2-CCR6_EN    Channel enable

\ DMA2-CNDTR6 (read-write)
: DMA2-CNDTR6_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR6 bis! ;  \ DMA2-CNDTR6_NDT    Number of data to transfer

\ DMA2-CPAR6 (read-write)
: DMA2-CPAR6_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR6 bis! ;  \ DMA2-CPAR6_PA    Peripheral address

\ DMA2-CMAR6 (read-write)
: DMA2-CMAR6_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR6 bis! ;  \ DMA2-CMAR6_MA    Memory address

\ DMA2-CCR7 (read-write)
: DMA2-CCR7_MEM2MEM   %1 14 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MEM2MEM    Memory to memory mode
: DMA2-CCR7_PL   ( %XX -- ) 12 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PL    Channel priority level
: DMA2-CCR7_MSIZE   ( %XX -- ) 10 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MSIZE    Memory size
: DMA2-CCR7_PSIZE   ( %XX -- ) 8 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PSIZE    Peripheral size
: DMA2-CCR7_MINC   %1 7 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_MINC    Memory increment mode
: DMA2-CCR7_PINC   %1 6 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_PINC    Peripheral increment mode
: DMA2-CCR7_CIRC   %1 5 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_CIRC    Circular mode
: DMA2-CCR7_DIR   %1 4 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_DIR    Data transfer direction
: DMA2-CCR7_TEIE   %1 3 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_TEIE    Transfer error interrupt  enable
: DMA2-CCR7_HTIE   %1 2 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_HTIE    Half transfer interrupt  enable
: DMA2-CCR7_TCIE   %1 1 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_TCIE    Transfer complete interrupt  enable
: DMA2-CCR7_EN   %1 0 lshift DMA2-CCR7 bis! ;  \ DMA2-CCR7_EN    Channel enable

\ DMA2-CNDTR7 (read-write)
: DMA2-CNDTR7_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CNDTR7 bis! ;  \ DMA2-CNDTR7_NDT    Number of data to transfer

\ DMA2-CPAR7 (read-write)
: DMA2-CPAR7_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CPAR7 bis! ;  \ DMA2-CPAR7_PA    Peripheral address

\ DMA2-CMAR7 (read-write)
: DMA2-CMAR7_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA2-CMAR7 bis! ;  \ DMA2-CMAR7_MA    Memory address

\ EXTI-IMR (read-write)
: EXTI-IMR_MR  0 lshift EXTI-IMR bis! ;  \ EXTI-IMR_MR    Interrupt mask on line x

\ EXTI-EMR (read-write)
: EXTI-EMR_MR  0 lshift EXTI-EMR bis! ;  \ EXTI-EMR_MR    Event mask on line x

\ EXTI-RTSR (read-write)
: EXTI-RTSR_TR  0 lshift EXTI-RTSR bis! ;  \ EXTI-RTSR_TR    Rising edge trigger event configuration  bit of line x

\ EXTI-FTSR (read-write)
: EXTI-FTSR_TR  0 lshift EXTI-FTSR bis! ;  \ EXTI-FTSR_TR    Falling edge trigger event configuration  bit of line x

\ EXTI-SWIER (read-write)
: EXTI-SWIER_SWIER  0 lshift EXTI-SWIER bis! ;  \ EXTI-SWIER_SWIER    Software interrupt on line  x

\ EXTI-PR (read-write)
: EXTI-PR_PR  0 lshift EXTI-PR bis! ;  \ EXTI-PR_PR    Pending bit

\ Flash-ACR (read-write)
: Flash-ACR_LATENCY   %1 0 lshift Flash-ACR bis! ;  \ Flash-ACR_LATENCY    Latency
: Flash-ACR_PRFTEN   %1 1 lshift Flash-ACR bis! ;  \ Flash-ACR_PRFTEN    Prefetch enable
: Flash-ACR_ACC64   %1 2 lshift Flash-ACR bis! ;  \ Flash-ACR_ACC64    64-bit access
: Flash-ACR_SLEEP_PD   %1 3 lshift Flash-ACR bis! ;  \ Flash-ACR_SLEEP_PD    Flash mode during Sleep
: Flash-ACR_RUN_PD   %1 4 lshift Flash-ACR bis! ;  \ Flash-ACR_RUN_PD    Flash mode during Run

\ Flash-PECR (read-write)
: Flash-PECR_PELOCK   %1 0 lshift Flash-PECR bis! ;  \ Flash-PECR_PELOCK    FLASH_PECR and data EEPROM  lock
: Flash-PECR_PRGLOCK   %1 1 lshift Flash-PECR bis! ;  \ Flash-PECR_PRGLOCK    Program memory lock
: Flash-PECR_OPTLOCK   %1 2 lshift Flash-PECR bis! ;  \ Flash-PECR_OPTLOCK    Option bytes block lock
: Flash-PECR_PROG   %1 3 lshift Flash-PECR bis! ;  \ Flash-PECR_PROG    Program memory selection
: Flash-PECR_DATA   %1 4 lshift Flash-PECR bis! ;  \ Flash-PECR_DATA    Data EEPROM selection
: Flash-PECR_FTDW   %1 8 lshift Flash-PECR bis! ;  \ Flash-PECR_FTDW    Fixed time data write for Byte, Half  Word and Word programming
: Flash-PECR_ERASE   %1 9 lshift Flash-PECR bis! ;  \ Flash-PECR_ERASE    Page or Double Word erase  mode
: Flash-PECR_FPRG   %1 10 lshift Flash-PECR bis! ;  \ Flash-PECR_FPRG    Half Page/Double Word programming  mode
: Flash-PECR_PARALLELBANK   %1 15 lshift Flash-PECR bis! ;  \ Flash-PECR_PARALLELBANK    Parallel bank mode
: Flash-PECR_EOPIE   %1 16 lshift Flash-PECR bis! ;  \ Flash-PECR_EOPIE    End of programming interrupt  enable
: Flash-PECR_ERRIE   %1 17 lshift Flash-PECR bis! ;  \ Flash-PECR_ERRIE    Error interrupt enable
: Flash-PECR_OBL_LAUNCH   %1 18 lshift Flash-PECR bis! ;  \ Flash-PECR_OBL_LAUNCH    Launch the option byte  loading

\ Flash-PDKEYR (write-only)
: Flash-PDKEYR_PDKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-PDKEYR bis! ;  \ Flash-PDKEYR_PDKEYR    RUN_PD in FLASH_ACR key

\ Flash-PEKEYR (write-only)
: Flash-PEKEYR_PEKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-PEKEYR bis! ;  \ Flash-PEKEYR_PEKEYR    FLASH_PEC and data EEPROM  key

\ Flash-PRGKEYR (write-only)
: Flash-PRGKEYR_PRGKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-PRGKEYR bis! ;  \ Flash-PRGKEYR_PRGKEYR    Program memory key

\ Flash-OPTKEYR (write-only)
: Flash-OPTKEYR_OPTKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-OPTKEYR bis! ;  \ Flash-OPTKEYR_OPTKEYR    Option byte key

\ Flash-SR ()
: Flash-SR_BSY   %1 0 lshift Flash-SR bis! ;  \ Flash-SR_BSY    Write/erase operations in  progress
: Flash-SR_EOP   %1 1 lshift Flash-SR bis! ;  \ Flash-SR_EOP    End of operation
: Flash-SR_ENDHV   %1 2 lshift Flash-SR bis! ;  \ Flash-SR_ENDHV    End of high voltage
: Flash-SR_READY   %1 3 lshift Flash-SR bis! ;  \ Flash-SR_READY    Flash memory module ready after low  power mode
: Flash-SR_WRPERR   %1 8 lshift Flash-SR bis! ;  \ Flash-SR_WRPERR    Write protected error
: Flash-SR_PGAERR   %1 9 lshift Flash-SR bis! ;  \ Flash-SR_PGAERR    Programming alignment  error
: Flash-SR_SIZERR   %1 10 lshift Flash-SR bis! ;  \ Flash-SR_SIZERR    Size error
: Flash-SR_OPTVERR   %1 11 lshift Flash-SR bis! ;  \ Flash-SR_OPTVERR    Option validity error
: Flash-SR_OPTVERRUSR   %1 12 lshift Flash-SR bis! ;  \ Flash-SR_OPTVERRUSR    Option UserValidity Error

\ Flash-OBR (read-only)
: Flash-OBR_RDPRT   ( %XXXXXXXX -- ) 0 lshift Flash-OBR bis! ;  \ Flash-OBR_RDPRT    Read protection
: Flash-OBR_BOR_LEV   ( %XXXX -- ) 16 lshift Flash-OBR bis! ;  \ Flash-OBR_BOR_LEV    BOR_LEV
: Flash-OBR_IWDG_SW   %1 20 lshift Flash-OBR bis! ;  \ Flash-OBR_IWDG_SW    IWDG_SW
: Flash-OBR_nRTS_STOP   %1 21 lshift Flash-OBR bis! ;  \ Flash-OBR_nRTS_STOP    nRTS_STOP
: Flash-OBR_nRST_STDBY   %1 22 lshift Flash-OBR bis! ;  \ Flash-OBR_nRST_STDBY    nRST_STDBY
: Flash-OBR_BFB2   %1 23 lshift Flash-OBR bis! ;  \ Flash-OBR_BFB2    Boot From Bank 2

\ Flash-WRPR1 (read-write)
: Flash-WRPR1_WRP1   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-WRPR1 bis! ;  \ Flash-WRPR1_WRP1    Write protection

\ Flash-WRPR2 (read-write)
: Flash-WRPR2_WRP2   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-WRPR2 bis! ;  \ Flash-WRPR2_WRP2    WRP2

\ Flash-WRPR3 (read-write)
: Flash-WRPR3_WRP3   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash-WRPR3 bis! ;  \ Flash-WRPR3_WRP3    WRP3

\ GPIOA-MODER (read-write)
: GPIOA-MODER_MODER15   ( %XX -- ) 30 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER14   ( %XX -- ) 28 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER13   ( %XX -- ) 26 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER12   ( %XX -- ) 24 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER11   ( %XX -- ) 22 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER10   ( %XX -- ) 20 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER9   ( %XX -- ) 18 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER8   ( %XX -- ) 16 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER7   ( %XX -- ) 14 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER6   ( %XX -- ) 12 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER5   ( %XX -- ) 10 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER4   ( %XX -- ) 8 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER3   ( %XX -- ) 6 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER2   ( %XX -- ) 4 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER1   ( %XX -- ) 2 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOA-MODER_MODER0   ( %XX -- ) 0 lshift GPIOA-MODER bis! ;  \ GPIOA-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOA-OTYPER (read-write)
: GPIOA-OTYPER_OT15   %1 15 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT14   %1 14 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT13   %1 13 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT12   %1 12 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT11   %1 11 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT10   %1 10 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT9   %1 9 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT8   %1 8 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT7   %1 7 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT6   %1 6 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT5   %1 5 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT4   %1 4 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT3   %1 3 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT2   %1 2 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT1   %1 1 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOA-OTYPER_OT0   %1 0 lshift GPIOA-OTYPER bis! ;  \ GPIOA-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOA-OSPEEDER (read-write)
: GPIOA-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOA-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOA-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOA-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOA-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOA-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOA-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOA-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOA-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOA-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOA-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOA-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOA-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOA-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOA-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOA-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOA-OSPEEDER bis! ;  \ GPIOA-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOA-PUPDR (read-write)
: GPIOA-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOA-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOA-PUPDR bis! ;  \ GPIOA-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOA-IDR (read-only)
: GPIOA-IDR_IDR15   %1 15 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR15    Port input data y =  0..15
: GPIOA-IDR_IDR14   %1 14 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR14    Port input data y =  0..15
: GPIOA-IDR_IDR13   %1 13 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR13    Port input data y =  0..15
: GPIOA-IDR_IDR12   %1 12 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR12    Port input data y =  0..15
: GPIOA-IDR_IDR11   %1 11 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR11    Port input data y =  0..15
: GPIOA-IDR_IDR10   %1 10 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR10    Port input data y =  0..15
: GPIOA-IDR_IDR9   %1 9 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR9    Port input data y =  0..15
: GPIOA-IDR_IDR8   %1 8 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR8    Port input data y =  0..15
: GPIOA-IDR_IDR7   %1 7 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR7    Port input data y =  0..15
: GPIOA-IDR_IDR6   %1 6 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR6    Port input data y =  0..15
: GPIOA-IDR_IDR5   %1 5 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR5    Port input data y =  0..15
: GPIOA-IDR_IDR4   %1 4 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR4    Port input data y =  0..15
: GPIOA-IDR_IDR3   %1 3 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR3    Port input data y =  0..15
: GPIOA-IDR_IDR2   %1 2 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR2    Port input data y =  0..15
: GPIOA-IDR_IDR1   %1 1 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR1    Port input data y =  0..15
: GPIOA-IDR_IDR0   %1 0 lshift GPIOA-IDR bis! ;  \ GPIOA-IDR_IDR0    Port input data y =  0..15

\ GPIOA-ODR (read-write)
: GPIOA-ODR_ODR15   %1 15 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR15    Port output data y =  0..15
: GPIOA-ODR_ODR14   %1 14 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR14    Port output data y =  0..15
: GPIOA-ODR_ODR13   %1 13 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR13    Port output data y =  0..15
: GPIOA-ODR_ODR12   %1 12 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR12    Port output data y =  0..15
: GPIOA-ODR_ODR11   %1 11 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR11    Port output data y =  0..15
: GPIOA-ODR_ODR10   %1 10 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR10    Port output data y =  0..15
: GPIOA-ODR_ODR9   %1 9 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR9    Port output data y =  0..15
: GPIOA-ODR_ODR8   %1 8 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR8    Port output data y =  0..15
: GPIOA-ODR_ODR7   %1 7 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR7    Port output data y =  0..15
: GPIOA-ODR_ODR6   %1 6 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR6    Port output data y =  0..15
: GPIOA-ODR_ODR5   %1 5 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR5    Port output data y =  0..15
: GPIOA-ODR_ODR4   %1 4 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR4    Port output data y =  0..15
: GPIOA-ODR_ODR3   %1 3 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR3    Port output data y =  0..15
: GPIOA-ODR_ODR2   %1 2 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR2    Port output data y =  0..15
: GPIOA-ODR_ODR1   %1 1 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR1    Port output data y =  0..15
: GPIOA-ODR_ODR0   %1 0 lshift GPIOA-ODR bis! ;  \ GPIOA-ODR_ODR0    Port output data y =  0..15

\ GPIOA-BSRR (write-only)
: GPIOA-BSRR_BR15   %1 31 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR14   %1 30 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR13   %1 29 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR12   %1 28 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR11   %1 27 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR10   %1 26 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR9   %1 25 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR8   %1 24 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR7   %1 23 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR6   %1 22 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR5   %1 21 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR4   %1 20 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR3   %1 19 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR2   %1 18 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR1   %1 17 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOA-BSRR_BR0   %1 16 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BR0    Port x set bit y y=  0..15
: GPIOA-BSRR_BS15   %1 15 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS15    Port x set bit y y=  0..15
: GPIOA-BSRR_BS14   %1 14 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS14    Port x set bit y y=  0..15
: GPIOA-BSRR_BS13   %1 13 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS13    Port x set bit y y=  0..15
: GPIOA-BSRR_BS12   %1 12 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS12    Port x set bit y y=  0..15
: GPIOA-BSRR_BS11   %1 11 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS11    Port x set bit y y=  0..15
: GPIOA-BSRR_BS10   %1 10 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS10    Port x set bit y y=  0..15
: GPIOA-BSRR_BS9   %1 9 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS9    Port x set bit y y=  0..15
: GPIOA-BSRR_BS8   %1 8 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS8    Port x set bit y y=  0..15
: GPIOA-BSRR_BS7   %1 7 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS7    Port x set bit y y=  0..15
: GPIOA-BSRR_BS6   %1 6 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS6    Port x set bit y y=  0..15
: GPIOA-BSRR_BS5   %1 5 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS5    Port x set bit y y=  0..15
: GPIOA-BSRR_BS4   %1 4 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS4    Port x set bit y y=  0..15
: GPIOA-BSRR_BS3   %1 3 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS3    Port x set bit y y=  0..15
: GPIOA-BSRR_BS2   %1 2 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS2    Port x set bit y y=  0..15
: GPIOA-BSRR_BS1   %1 1 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS1    Port x set bit y y=  0..15
: GPIOA-BSRR_BS0   %1 0 lshift GPIOA-BSRR bis! ;  \ GPIOA-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOA-LCKR (read-write)
: GPIOA-LCKR_LCKK   %1 16 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK15   %1 15 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK14   %1 14 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK13   %1 13 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK12   %1 12 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK11   %1 11 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK10   %1 10 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK9   %1 9 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK8   %1 8 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK7   %1 7 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK6   %1 6 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK5   %1 5 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK4   %1 4 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK3   %1 3 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK2   %1 2 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK1   %1 1 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOA-LCKR_LCK0   %1 0 lshift GPIOA-LCKR bis! ;  \ GPIOA-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOA-AFRL (read-write)
: GPIOA-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOA-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOA-AFRL bis! ;  \ GPIOA-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOA-AFRH (read-write)
: GPIOA-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOA-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOA-AFRH bis! ;  \ GPIOA-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOB-MODER (read-write)
: GPIOB-MODER_MODER15   ( %XX -- ) 30 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER14   ( %XX -- ) 28 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER13   ( %XX -- ) 26 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER12   ( %XX -- ) 24 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER11   ( %XX -- ) 22 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER10   ( %XX -- ) 20 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER9   ( %XX -- ) 18 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER8   ( %XX -- ) 16 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER7   ( %XX -- ) 14 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER6   ( %XX -- ) 12 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER5   ( %XX -- ) 10 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER4   ( %XX -- ) 8 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER3   ( %XX -- ) 6 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER2   ( %XX -- ) 4 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER1   ( %XX -- ) 2 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOB-MODER_MODER0   ( %XX -- ) 0 lshift GPIOB-MODER bis! ;  \ GPIOB-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOB-OTYPER (read-write)
: GPIOB-OTYPER_OT15   %1 15 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT14   %1 14 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT13   %1 13 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT12   %1 12 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT11   %1 11 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT10   %1 10 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT9   %1 9 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT8   %1 8 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT7   %1 7 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT6   %1 6 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT5   %1 5 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT4   %1 4 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT3   %1 3 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT2   %1 2 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT1   %1 1 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOB-OTYPER_OT0   %1 0 lshift GPIOB-OTYPER bis! ;  \ GPIOB-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOB-OSPEEDER (read-write)
: GPIOB-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOB-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOB-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOB-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOB-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOB-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOB-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOB-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOB-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOB-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOB-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOB-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOB-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOB-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOB-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOB-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOB-OSPEEDER bis! ;  \ GPIOB-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOB-PUPDR (read-write)
: GPIOB-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOB-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOB-PUPDR bis! ;  \ GPIOB-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOB-IDR (read-only)
: GPIOB-IDR_IDR15   %1 15 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR15    Port input data y =  0..15
: GPIOB-IDR_IDR14   %1 14 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR14    Port input data y =  0..15
: GPIOB-IDR_IDR13   %1 13 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR13    Port input data y =  0..15
: GPIOB-IDR_IDR12   %1 12 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR12    Port input data y =  0..15
: GPIOB-IDR_IDR11   %1 11 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR11    Port input data y =  0..15
: GPIOB-IDR_IDR10   %1 10 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR10    Port input data y =  0..15
: GPIOB-IDR_IDR9   %1 9 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR9    Port input data y =  0..15
: GPIOB-IDR_IDR8   %1 8 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR8    Port input data y =  0..15
: GPIOB-IDR_IDR7   %1 7 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR7    Port input data y =  0..15
: GPIOB-IDR_IDR6   %1 6 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR6    Port input data y =  0..15
: GPIOB-IDR_IDR5   %1 5 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR5    Port input data y =  0..15
: GPIOB-IDR_IDR4   %1 4 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR4    Port input data y =  0..15
: GPIOB-IDR_IDR3   %1 3 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR3    Port input data y =  0..15
: GPIOB-IDR_IDR2   %1 2 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR2    Port input data y =  0..15
: GPIOB-IDR_IDR1   %1 1 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR1    Port input data y =  0..15
: GPIOB-IDR_IDR0   %1 0 lshift GPIOB-IDR bis! ;  \ GPIOB-IDR_IDR0    Port input data y =  0..15

\ GPIOB-ODR (read-write)
: GPIOB-ODR_ODR15   %1 15 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR15    Port output data y =  0..15
: GPIOB-ODR_ODR14   %1 14 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR14    Port output data y =  0..15
: GPIOB-ODR_ODR13   %1 13 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR13    Port output data y =  0..15
: GPIOB-ODR_ODR12   %1 12 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR12    Port output data y =  0..15
: GPIOB-ODR_ODR11   %1 11 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR11    Port output data y =  0..15
: GPIOB-ODR_ODR10   %1 10 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR10    Port output data y =  0..15
: GPIOB-ODR_ODR9   %1 9 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR9    Port output data y =  0..15
: GPIOB-ODR_ODR8   %1 8 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR8    Port output data y =  0..15
: GPIOB-ODR_ODR7   %1 7 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR7    Port output data y =  0..15
: GPIOB-ODR_ODR6   %1 6 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR6    Port output data y =  0..15
: GPIOB-ODR_ODR5   %1 5 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR5    Port output data y =  0..15
: GPIOB-ODR_ODR4   %1 4 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR4    Port output data y =  0..15
: GPIOB-ODR_ODR3   %1 3 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR3    Port output data y =  0..15
: GPIOB-ODR_ODR2   %1 2 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR2    Port output data y =  0..15
: GPIOB-ODR_ODR1   %1 1 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR1    Port output data y =  0..15
: GPIOB-ODR_ODR0   %1 0 lshift GPIOB-ODR bis! ;  \ GPIOB-ODR_ODR0    Port output data y =  0..15

\ GPIOB-BSRR (write-only)
: GPIOB-BSRR_BR15   %1 31 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR14   %1 30 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR13   %1 29 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR12   %1 28 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR11   %1 27 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR10   %1 26 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR9   %1 25 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR8   %1 24 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR7   %1 23 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR6   %1 22 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR5   %1 21 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR4   %1 20 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR3   %1 19 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR2   %1 18 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR1   %1 17 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOB-BSRR_BR0   %1 16 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BR0    Port x set bit y y=  0..15
: GPIOB-BSRR_BS15   %1 15 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS15    Port x set bit y y=  0..15
: GPIOB-BSRR_BS14   %1 14 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS14    Port x set bit y y=  0..15
: GPIOB-BSRR_BS13   %1 13 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS13    Port x set bit y y=  0..15
: GPIOB-BSRR_BS12   %1 12 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS12    Port x set bit y y=  0..15
: GPIOB-BSRR_BS11   %1 11 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS11    Port x set bit y y=  0..15
: GPIOB-BSRR_BS10   %1 10 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS10    Port x set bit y y=  0..15
: GPIOB-BSRR_BS9   %1 9 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS9    Port x set bit y y=  0..15
: GPIOB-BSRR_BS8   %1 8 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS8    Port x set bit y y=  0..15
: GPIOB-BSRR_BS7   %1 7 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS7    Port x set bit y y=  0..15
: GPIOB-BSRR_BS6   %1 6 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS6    Port x set bit y y=  0..15
: GPIOB-BSRR_BS5   %1 5 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS5    Port x set bit y y=  0..15
: GPIOB-BSRR_BS4   %1 4 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS4    Port x set bit y y=  0..15
: GPIOB-BSRR_BS3   %1 3 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS3    Port x set bit y y=  0..15
: GPIOB-BSRR_BS2   %1 2 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS2    Port x set bit y y=  0..15
: GPIOB-BSRR_BS1   %1 1 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS1    Port x set bit y y=  0..15
: GPIOB-BSRR_BS0   %1 0 lshift GPIOB-BSRR bis! ;  \ GPIOB-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOB-LCKR (read-write)
: GPIOB-LCKR_LCKK   %1 16 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK15   %1 15 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK14   %1 14 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK13   %1 13 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK12   %1 12 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK11   %1 11 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK10   %1 10 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK9   %1 9 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK8   %1 8 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK7   %1 7 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK6   %1 6 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK5   %1 5 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK4   %1 4 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK3   %1 3 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK2   %1 2 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK1   %1 1 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOB-LCKR_LCK0   %1 0 lshift GPIOB-LCKR bis! ;  \ GPIOB-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOB-AFRL (read-write)
: GPIOB-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOB-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOB-AFRL bis! ;  \ GPIOB-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOB-AFRH (read-write)
: GPIOB-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOB-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOB-AFRH bis! ;  \ GPIOB-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOC-MODER (read-write)
: GPIOC-MODER_MODER15   ( %XX -- ) 30 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER14   ( %XX -- ) 28 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER13   ( %XX -- ) 26 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER12   ( %XX -- ) 24 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER11   ( %XX -- ) 22 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER10   ( %XX -- ) 20 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER9   ( %XX -- ) 18 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER8   ( %XX -- ) 16 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER7   ( %XX -- ) 14 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER6   ( %XX -- ) 12 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER5   ( %XX -- ) 10 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER4   ( %XX -- ) 8 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER3   ( %XX -- ) 6 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER2   ( %XX -- ) 4 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER1   ( %XX -- ) 2 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOC-MODER_MODER0   ( %XX -- ) 0 lshift GPIOC-MODER bis! ;  \ GPIOC-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOC-OTYPER (read-write)
: GPIOC-OTYPER_OT15   %1 15 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT14   %1 14 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT13   %1 13 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT12   %1 12 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT11   %1 11 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT10   %1 10 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT9   %1 9 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT8   %1 8 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT7   %1 7 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT6   %1 6 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT5   %1 5 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT4   %1 4 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT3   %1 3 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT2   %1 2 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT1   %1 1 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOC-OTYPER_OT0   %1 0 lshift GPIOC-OTYPER bis! ;  \ GPIOC-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOC-OSPEEDER (read-write)
: GPIOC-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOC-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOC-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOC-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOC-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOC-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOC-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOC-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOC-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOC-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOC-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOC-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOC-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOC-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOC-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOC-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOC-OSPEEDER bis! ;  \ GPIOC-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOC-PUPDR (read-write)
: GPIOC-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOC-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOC-PUPDR bis! ;  \ GPIOC-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOC-IDR (read-only)
: GPIOC-IDR_IDR15   %1 15 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR15    Port input data y =  0..15
: GPIOC-IDR_IDR14   %1 14 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR14    Port input data y =  0..15
: GPIOC-IDR_IDR13   %1 13 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR13    Port input data y =  0..15
: GPIOC-IDR_IDR12   %1 12 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR12    Port input data y =  0..15
: GPIOC-IDR_IDR11   %1 11 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR11    Port input data y =  0..15
: GPIOC-IDR_IDR10   %1 10 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR10    Port input data y =  0..15
: GPIOC-IDR_IDR9   %1 9 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR9    Port input data y =  0..15
: GPIOC-IDR_IDR8   %1 8 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR8    Port input data y =  0..15
: GPIOC-IDR_IDR7   %1 7 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR7    Port input data y =  0..15
: GPIOC-IDR_IDR6   %1 6 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR6    Port input data y =  0..15
: GPIOC-IDR_IDR5   %1 5 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR5    Port input data y =  0..15
: GPIOC-IDR_IDR4   %1 4 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR4    Port input data y =  0..15
: GPIOC-IDR_IDR3   %1 3 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR3    Port input data y =  0..15
: GPIOC-IDR_IDR2   %1 2 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR2    Port input data y =  0..15
: GPIOC-IDR_IDR1   %1 1 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR1    Port input data y =  0..15
: GPIOC-IDR_IDR0   %1 0 lshift GPIOC-IDR bis! ;  \ GPIOC-IDR_IDR0    Port input data y =  0..15

\ GPIOC-ODR (read-write)
: GPIOC-ODR_ODR15   %1 15 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR15    Port output data y =  0..15
: GPIOC-ODR_ODR14   %1 14 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR14    Port output data y =  0..15
: GPIOC-ODR_ODR13   %1 13 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR13    Port output data y =  0..15
: GPIOC-ODR_ODR12   %1 12 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR12    Port output data y =  0..15
: GPIOC-ODR_ODR11   %1 11 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR11    Port output data y =  0..15
: GPIOC-ODR_ODR10   %1 10 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR10    Port output data y =  0..15
: GPIOC-ODR_ODR9   %1 9 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR9    Port output data y =  0..15
: GPIOC-ODR_ODR8   %1 8 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR8    Port output data y =  0..15
: GPIOC-ODR_ODR7   %1 7 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR7    Port output data y =  0..15
: GPIOC-ODR_ODR6   %1 6 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR6    Port output data y =  0..15
: GPIOC-ODR_ODR5   %1 5 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR5    Port output data y =  0..15
: GPIOC-ODR_ODR4   %1 4 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR4    Port output data y =  0..15
: GPIOC-ODR_ODR3   %1 3 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR3    Port output data y =  0..15
: GPIOC-ODR_ODR2   %1 2 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR2    Port output data y =  0..15
: GPIOC-ODR_ODR1   %1 1 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR1    Port output data y =  0..15
: GPIOC-ODR_ODR0   %1 0 lshift GPIOC-ODR bis! ;  \ GPIOC-ODR_ODR0    Port output data y =  0..15

\ GPIOC-BSRR (write-only)
: GPIOC-BSRR_BR15   %1 31 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR14   %1 30 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR13   %1 29 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR12   %1 28 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR11   %1 27 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR10   %1 26 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR9   %1 25 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR8   %1 24 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR7   %1 23 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR6   %1 22 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR5   %1 21 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR4   %1 20 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR3   %1 19 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR2   %1 18 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR1   %1 17 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOC-BSRR_BR0   %1 16 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BR0    Port x set bit y y=  0..15
: GPIOC-BSRR_BS15   %1 15 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS15    Port x set bit y y=  0..15
: GPIOC-BSRR_BS14   %1 14 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS14    Port x set bit y y=  0..15
: GPIOC-BSRR_BS13   %1 13 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS13    Port x set bit y y=  0..15
: GPIOC-BSRR_BS12   %1 12 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS12    Port x set bit y y=  0..15
: GPIOC-BSRR_BS11   %1 11 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS11    Port x set bit y y=  0..15
: GPIOC-BSRR_BS10   %1 10 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS10    Port x set bit y y=  0..15
: GPIOC-BSRR_BS9   %1 9 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS9    Port x set bit y y=  0..15
: GPIOC-BSRR_BS8   %1 8 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS8    Port x set bit y y=  0..15
: GPIOC-BSRR_BS7   %1 7 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS7    Port x set bit y y=  0..15
: GPIOC-BSRR_BS6   %1 6 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS6    Port x set bit y y=  0..15
: GPIOC-BSRR_BS5   %1 5 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS5    Port x set bit y y=  0..15
: GPIOC-BSRR_BS4   %1 4 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS4    Port x set bit y y=  0..15
: GPIOC-BSRR_BS3   %1 3 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS3    Port x set bit y y=  0..15
: GPIOC-BSRR_BS2   %1 2 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS2    Port x set bit y y=  0..15
: GPIOC-BSRR_BS1   %1 1 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS1    Port x set bit y y=  0..15
: GPIOC-BSRR_BS0   %1 0 lshift GPIOC-BSRR bis! ;  \ GPIOC-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOC-LCKR (read-write)
: GPIOC-LCKR_LCKK   %1 16 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK15   %1 15 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK14   %1 14 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK13   %1 13 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK12   %1 12 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK11   %1 11 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK10   %1 10 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK9   %1 9 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK8   %1 8 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK7   %1 7 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK6   %1 6 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK5   %1 5 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK4   %1 4 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK3   %1 3 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK2   %1 2 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK1   %1 1 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOC-LCKR_LCK0   %1 0 lshift GPIOC-LCKR bis! ;  \ GPIOC-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOC-AFRL (read-write)
: GPIOC-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOC-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOC-AFRL bis! ;  \ GPIOC-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOC-AFRH (read-write)
: GPIOC-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOC-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOC-AFRH bis! ;  \ GPIOC-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOD-MODER (read-write)
: GPIOD-MODER_MODER15   ( %XX -- ) 30 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER14   ( %XX -- ) 28 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER13   ( %XX -- ) 26 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER12   ( %XX -- ) 24 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER11   ( %XX -- ) 22 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER10   ( %XX -- ) 20 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER9   ( %XX -- ) 18 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER8   ( %XX -- ) 16 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER7   ( %XX -- ) 14 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER6   ( %XX -- ) 12 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER5   ( %XX -- ) 10 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER4   ( %XX -- ) 8 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER3   ( %XX -- ) 6 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER2   ( %XX -- ) 4 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER1   ( %XX -- ) 2 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOD-MODER_MODER0   ( %XX -- ) 0 lshift GPIOD-MODER bis! ;  \ GPIOD-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOD-OTYPER (read-write)
: GPIOD-OTYPER_OT15   %1 15 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT14   %1 14 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT13   %1 13 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT12   %1 12 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT11   %1 11 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT10   %1 10 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT9   %1 9 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT8   %1 8 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT7   %1 7 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT6   %1 6 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT5   %1 5 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT4   %1 4 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT3   %1 3 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT2   %1 2 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT1   %1 1 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOD-OTYPER_OT0   %1 0 lshift GPIOD-OTYPER bis! ;  \ GPIOD-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOD-OSPEEDER (read-write)
: GPIOD-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOD-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOD-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOD-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOD-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOD-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOD-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOD-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOD-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOD-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOD-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOD-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOD-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOD-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOD-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOD-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOD-OSPEEDER bis! ;  \ GPIOD-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOD-PUPDR (read-write)
: GPIOD-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOD-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOD-PUPDR bis! ;  \ GPIOD-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOD-IDR (read-only)
: GPIOD-IDR_IDR15   %1 15 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR15    Port input data y =  0..15
: GPIOD-IDR_IDR14   %1 14 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR14    Port input data y =  0..15
: GPIOD-IDR_IDR13   %1 13 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR13    Port input data y =  0..15
: GPIOD-IDR_IDR12   %1 12 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR12    Port input data y =  0..15
: GPIOD-IDR_IDR11   %1 11 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR11    Port input data y =  0..15
: GPIOD-IDR_IDR10   %1 10 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR10    Port input data y =  0..15
: GPIOD-IDR_IDR9   %1 9 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR9    Port input data y =  0..15
: GPIOD-IDR_IDR8   %1 8 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR8    Port input data y =  0..15
: GPIOD-IDR_IDR7   %1 7 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR7    Port input data y =  0..15
: GPIOD-IDR_IDR6   %1 6 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR6    Port input data y =  0..15
: GPIOD-IDR_IDR5   %1 5 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR5    Port input data y =  0..15
: GPIOD-IDR_IDR4   %1 4 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR4    Port input data y =  0..15
: GPIOD-IDR_IDR3   %1 3 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR3    Port input data y =  0..15
: GPIOD-IDR_IDR2   %1 2 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR2    Port input data y =  0..15
: GPIOD-IDR_IDR1   %1 1 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR1    Port input data y =  0..15
: GPIOD-IDR_IDR0   %1 0 lshift GPIOD-IDR bis! ;  \ GPIOD-IDR_IDR0    Port input data y =  0..15

\ GPIOD-ODR (read-write)
: GPIOD-ODR_ODR15   %1 15 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR15    Port output data y =  0..15
: GPIOD-ODR_ODR14   %1 14 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR14    Port output data y =  0..15
: GPIOD-ODR_ODR13   %1 13 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR13    Port output data y =  0..15
: GPIOD-ODR_ODR12   %1 12 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR12    Port output data y =  0..15
: GPIOD-ODR_ODR11   %1 11 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR11    Port output data y =  0..15
: GPIOD-ODR_ODR10   %1 10 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR10    Port output data y =  0..15
: GPIOD-ODR_ODR9   %1 9 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR9    Port output data y =  0..15
: GPIOD-ODR_ODR8   %1 8 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR8    Port output data y =  0..15
: GPIOD-ODR_ODR7   %1 7 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR7    Port output data y =  0..15
: GPIOD-ODR_ODR6   %1 6 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR6    Port output data y =  0..15
: GPIOD-ODR_ODR5   %1 5 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR5    Port output data y =  0..15
: GPIOD-ODR_ODR4   %1 4 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR4    Port output data y =  0..15
: GPIOD-ODR_ODR3   %1 3 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR3    Port output data y =  0..15
: GPIOD-ODR_ODR2   %1 2 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR2    Port output data y =  0..15
: GPIOD-ODR_ODR1   %1 1 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR1    Port output data y =  0..15
: GPIOD-ODR_ODR0   %1 0 lshift GPIOD-ODR bis! ;  \ GPIOD-ODR_ODR0    Port output data y =  0..15

\ GPIOD-BSRR (write-only)
: GPIOD-BSRR_BR15   %1 31 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR14   %1 30 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR13   %1 29 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR12   %1 28 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR11   %1 27 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR10   %1 26 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR9   %1 25 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR8   %1 24 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR7   %1 23 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR6   %1 22 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR5   %1 21 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR4   %1 20 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR3   %1 19 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR2   %1 18 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR1   %1 17 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOD-BSRR_BR0   %1 16 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BR0    Port x set bit y y=  0..15
: GPIOD-BSRR_BS15   %1 15 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS15    Port x set bit y y=  0..15
: GPIOD-BSRR_BS14   %1 14 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS14    Port x set bit y y=  0..15
: GPIOD-BSRR_BS13   %1 13 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS13    Port x set bit y y=  0..15
: GPIOD-BSRR_BS12   %1 12 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS12    Port x set bit y y=  0..15
: GPIOD-BSRR_BS11   %1 11 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS11    Port x set bit y y=  0..15
: GPIOD-BSRR_BS10   %1 10 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS10    Port x set bit y y=  0..15
: GPIOD-BSRR_BS9   %1 9 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS9    Port x set bit y y=  0..15
: GPIOD-BSRR_BS8   %1 8 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS8    Port x set bit y y=  0..15
: GPIOD-BSRR_BS7   %1 7 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS7    Port x set bit y y=  0..15
: GPIOD-BSRR_BS6   %1 6 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS6    Port x set bit y y=  0..15
: GPIOD-BSRR_BS5   %1 5 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS5    Port x set bit y y=  0..15
: GPIOD-BSRR_BS4   %1 4 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS4    Port x set bit y y=  0..15
: GPIOD-BSRR_BS3   %1 3 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS3    Port x set bit y y=  0..15
: GPIOD-BSRR_BS2   %1 2 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS2    Port x set bit y y=  0..15
: GPIOD-BSRR_BS1   %1 1 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS1    Port x set bit y y=  0..15
: GPIOD-BSRR_BS0   %1 0 lshift GPIOD-BSRR bis! ;  \ GPIOD-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOD-LCKR (read-write)
: GPIOD-LCKR_LCKK   %1 16 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK15   %1 15 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK14   %1 14 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK13   %1 13 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK12   %1 12 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK11   %1 11 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK10   %1 10 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK9   %1 9 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK8   %1 8 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK7   %1 7 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK6   %1 6 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK5   %1 5 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK4   %1 4 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK3   %1 3 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK2   %1 2 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK1   %1 1 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOD-LCKR_LCK0   %1 0 lshift GPIOD-LCKR bis! ;  \ GPIOD-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOD-AFRL (read-write)
: GPIOD-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOD-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOD-AFRL bis! ;  \ GPIOD-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOD-AFRH (read-write)
: GPIOD-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOD-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOD-AFRH bis! ;  \ GPIOD-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOE-MODER (read-write)
: GPIOE-MODER_MODER15   ( %XX -- ) 30 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER14   ( %XX -- ) 28 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER13   ( %XX -- ) 26 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER12   ( %XX -- ) 24 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER11   ( %XX -- ) 22 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER10   ( %XX -- ) 20 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER9   ( %XX -- ) 18 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER8   ( %XX -- ) 16 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER7   ( %XX -- ) 14 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER6   ( %XX -- ) 12 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER5   ( %XX -- ) 10 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER4   ( %XX -- ) 8 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER3   ( %XX -- ) 6 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER2   ( %XX -- ) 4 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER1   ( %XX -- ) 2 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOE-MODER_MODER0   ( %XX -- ) 0 lshift GPIOE-MODER bis! ;  \ GPIOE-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOE-OTYPER (read-write)
: GPIOE-OTYPER_OT15   %1 15 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT14   %1 14 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT13   %1 13 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT12   %1 12 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT11   %1 11 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT10   %1 10 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT9   %1 9 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT8   %1 8 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT7   %1 7 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT6   %1 6 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT5   %1 5 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT4   %1 4 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT3   %1 3 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT2   %1 2 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT1   %1 1 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOE-OTYPER_OT0   %1 0 lshift GPIOE-OTYPER bis! ;  \ GPIOE-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOE-OSPEEDER (read-write)
: GPIOE-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOE-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOE-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOE-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOE-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOE-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOE-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOE-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOE-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOE-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOE-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOE-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOE-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOE-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOE-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOE-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOE-OSPEEDER bis! ;  \ GPIOE-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOE-PUPDR (read-write)
: GPIOE-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOE-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOE-PUPDR bis! ;  \ GPIOE-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOE-IDR (read-only)
: GPIOE-IDR_IDR15   %1 15 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR15    Port input data y =  0..15
: GPIOE-IDR_IDR14   %1 14 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR14    Port input data y =  0..15
: GPIOE-IDR_IDR13   %1 13 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR13    Port input data y =  0..15
: GPIOE-IDR_IDR12   %1 12 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR12    Port input data y =  0..15
: GPIOE-IDR_IDR11   %1 11 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR11    Port input data y =  0..15
: GPIOE-IDR_IDR10   %1 10 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR10    Port input data y =  0..15
: GPIOE-IDR_IDR9   %1 9 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR9    Port input data y =  0..15
: GPIOE-IDR_IDR8   %1 8 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR8    Port input data y =  0..15
: GPIOE-IDR_IDR7   %1 7 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR7    Port input data y =  0..15
: GPIOE-IDR_IDR6   %1 6 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR6    Port input data y =  0..15
: GPIOE-IDR_IDR5   %1 5 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR5    Port input data y =  0..15
: GPIOE-IDR_IDR4   %1 4 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR4    Port input data y =  0..15
: GPIOE-IDR_IDR3   %1 3 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR3    Port input data y =  0..15
: GPIOE-IDR_IDR2   %1 2 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR2    Port input data y =  0..15
: GPIOE-IDR_IDR1   %1 1 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR1    Port input data y =  0..15
: GPIOE-IDR_IDR0   %1 0 lshift GPIOE-IDR bis! ;  \ GPIOE-IDR_IDR0    Port input data y =  0..15

\ GPIOE-ODR (read-write)
: GPIOE-ODR_ODR15   %1 15 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR15    Port output data y =  0..15
: GPIOE-ODR_ODR14   %1 14 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR14    Port output data y =  0..15
: GPIOE-ODR_ODR13   %1 13 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR13    Port output data y =  0..15
: GPIOE-ODR_ODR12   %1 12 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR12    Port output data y =  0..15
: GPIOE-ODR_ODR11   %1 11 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR11    Port output data y =  0..15
: GPIOE-ODR_ODR10   %1 10 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR10    Port output data y =  0..15
: GPIOE-ODR_ODR9   %1 9 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR9    Port output data y =  0..15
: GPIOE-ODR_ODR8   %1 8 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR8    Port output data y =  0..15
: GPIOE-ODR_ODR7   %1 7 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR7    Port output data y =  0..15
: GPIOE-ODR_ODR6   %1 6 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR6    Port output data y =  0..15
: GPIOE-ODR_ODR5   %1 5 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR5    Port output data y =  0..15
: GPIOE-ODR_ODR4   %1 4 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR4    Port output data y =  0..15
: GPIOE-ODR_ODR3   %1 3 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR3    Port output data y =  0..15
: GPIOE-ODR_ODR2   %1 2 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR2    Port output data y =  0..15
: GPIOE-ODR_ODR1   %1 1 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR1    Port output data y =  0..15
: GPIOE-ODR_ODR0   %1 0 lshift GPIOE-ODR bis! ;  \ GPIOE-ODR_ODR0    Port output data y =  0..15

\ GPIOE-BSRR (write-only)
: GPIOE-BSRR_BR15   %1 31 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR14   %1 30 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR13   %1 29 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR12   %1 28 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR11   %1 27 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR10   %1 26 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR9   %1 25 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR8   %1 24 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR7   %1 23 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR6   %1 22 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR5   %1 21 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR4   %1 20 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR3   %1 19 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR2   %1 18 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR1   %1 17 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOE-BSRR_BR0   %1 16 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BR0    Port x set bit y y=  0..15
: GPIOE-BSRR_BS15   %1 15 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS15    Port x set bit y y=  0..15
: GPIOE-BSRR_BS14   %1 14 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS14    Port x set bit y y=  0..15
: GPIOE-BSRR_BS13   %1 13 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS13    Port x set bit y y=  0..15
: GPIOE-BSRR_BS12   %1 12 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS12    Port x set bit y y=  0..15
: GPIOE-BSRR_BS11   %1 11 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS11    Port x set bit y y=  0..15
: GPIOE-BSRR_BS10   %1 10 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS10    Port x set bit y y=  0..15
: GPIOE-BSRR_BS9   %1 9 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS9    Port x set bit y y=  0..15
: GPIOE-BSRR_BS8   %1 8 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS8    Port x set bit y y=  0..15
: GPIOE-BSRR_BS7   %1 7 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS7    Port x set bit y y=  0..15
: GPIOE-BSRR_BS6   %1 6 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS6    Port x set bit y y=  0..15
: GPIOE-BSRR_BS5   %1 5 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS5    Port x set bit y y=  0..15
: GPIOE-BSRR_BS4   %1 4 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS4    Port x set bit y y=  0..15
: GPIOE-BSRR_BS3   %1 3 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS3    Port x set bit y y=  0..15
: GPIOE-BSRR_BS2   %1 2 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS2    Port x set bit y y=  0..15
: GPIOE-BSRR_BS1   %1 1 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS1    Port x set bit y y=  0..15
: GPIOE-BSRR_BS0   %1 0 lshift GPIOE-BSRR bis! ;  \ GPIOE-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOE-LCKR (read-write)
: GPIOE-LCKR_LCKK   %1 16 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK15   %1 15 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK14   %1 14 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK13   %1 13 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK12   %1 12 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK11   %1 11 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK10   %1 10 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK9   %1 9 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK8   %1 8 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK7   %1 7 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK6   %1 6 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK5   %1 5 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK4   %1 4 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK3   %1 3 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK2   %1 2 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK1   %1 1 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOE-LCKR_LCK0   %1 0 lshift GPIOE-LCKR bis! ;  \ GPIOE-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOE-AFRL (read-write)
: GPIOE-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOE-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOE-AFRL bis! ;  \ GPIOE-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOE-AFRH (read-write)
: GPIOE-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOE-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOE-AFRH bis! ;  \ GPIOE-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOF-MODER (read-write)
: GPIOF-MODER_MODER15   ( %XX -- ) 30 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER14   ( %XX -- ) 28 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER13   ( %XX -- ) 26 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER12   ( %XX -- ) 24 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER11   ( %XX -- ) 22 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER10   ( %XX -- ) 20 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER9   ( %XX -- ) 18 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER8   ( %XX -- ) 16 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER7   ( %XX -- ) 14 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER6   ( %XX -- ) 12 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER5   ( %XX -- ) 10 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER4   ( %XX -- ) 8 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER3   ( %XX -- ) 6 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER2   ( %XX -- ) 4 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER1   ( %XX -- ) 2 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOF-MODER_MODER0   ( %XX -- ) 0 lshift GPIOF-MODER bis! ;  \ GPIOF-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOF-OTYPER (read-write)
: GPIOF-OTYPER_OT15   %1 15 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT14   %1 14 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT13   %1 13 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT12   %1 12 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT11   %1 11 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT10   %1 10 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT9   %1 9 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT8   %1 8 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT7   %1 7 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT6   %1 6 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT5   %1 5 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT4   %1 4 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT3   %1 3 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT2   %1 2 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT1   %1 1 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOF-OTYPER_OT0   %1 0 lshift GPIOF-OTYPER bis! ;  \ GPIOF-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOF-OSPEEDER (read-write)
: GPIOF-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOF-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOF-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOF-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOF-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOF-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOF-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOF-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOF-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOF-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOF-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOF-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOF-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOF-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOF-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOF-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOF-OSPEEDER bis! ;  \ GPIOF-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOF-PUPDR (read-write)
: GPIOF-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOF-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOF-PUPDR bis! ;  \ GPIOF-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOF-IDR (read-only)
: GPIOF-IDR_IDR15   %1 15 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR15    Port input data y =  0..15
: GPIOF-IDR_IDR14   %1 14 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR14    Port input data y =  0..15
: GPIOF-IDR_IDR13   %1 13 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR13    Port input data y =  0..15
: GPIOF-IDR_IDR12   %1 12 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR12    Port input data y =  0..15
: GPIOF-IDR_IDR11   %1 11 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR11    Port input data y =  0..15
: GPIOF-IDR_IDR10   %1 10 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR10    Port input data y =  0..15
: GPIOF-IDR_IDR9   %1 9 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR9    Port input data y =  0..15
: GPIOF-IDR_IDR8   %1 8 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR8    Port input data y =  0..15
: GPIOF-IDR_IDR7   %1 7 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR7    Port input data y =  0..15
: GPIOF-IDR_IDR6   %1 6 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR6    Port input data y =  0..15
: GPIOF-IDR_IDR5   %1 5 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR5    Port input data y =  0..15
: GPIOF-IDR_IDR4   %1 4 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR4    Port input data y =  0..15
: GPIOF-IDR_IDR3   %1 3 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR3    Port input data y =  0..15
: GPIOF-IDR_IDR2   %1 2 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR2    Port input data y =  0..15
: GPIOF-IDR_IDR1   %1 1 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR1    Port input data y =  0..15
: GPIOF-IDR_IDR0   %1 0 lshift GPIOF-IDR bis! ;  \ GPIOF-IDR_IDR0    Port input data y =  0..15

\ GPIOF-ODR (read-write)
: GPIOF-ODR_ODR15   %1 15 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR15    Port output data y =  0..15
: GPIOF-ODR_ODR14   %1 14 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR14    Port output data y =  0..15
: GPIOF-ODR_ODR13   %1 13 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR13    Port output data y =  0..15
: GPIOF-ODR_ODR12   %1 12 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR12    Port output data y =  0..15
: GPIOF-ODR_ODR11   %1 11 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR11    Port output data y =  0..15
: GPIOF-ODR_ODR10   %1 10 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR10    Port output data y =  0..15
: GPIOF-ODR_ODR9   %1 9 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR9    Port output data y =  0..15
: GPIOF-ODR_ODR8   %1 8 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR8    Port output data y =  0..15
: GPIOF-ODR_ODR7   %1 7 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR7    Port output data y =  0..15
: GPIOF-ODR_ODR6   %1 6 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR6    Port output data y =  0..15
: GPIOF-ODR_ODR5   %1 5 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR5    Port output data y =  0..15
: GPIOF-ODR_ODR4   %1 4 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR4    Port output data y =  0..15
: GPIOF-ODR_ODR3   %1 3 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR3    Port output data y =  0..15
: GPIOF-ODR_ODR2   %1 2 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR2    Port output data y =  0..15
: GPIOF-ODR_ODR1   %1 1 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR1    Port output data y =  0..15
: GPIOF-ODR_ODR0   %1 0 lshift GPIOF-ODR bis! ;  \ GPIOF-ODR_ODR0    Port output data y =  0..15

\ GPIOF-BSRR (write-only)
: GPIOF-BSRR_BR15   %1 31 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR14   %1 30 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR13   %1 29 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR12   %1 28 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR11   %1 27 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR10   %1 26 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR9   %1 25 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR8   %1 24 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR7   %1 23 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR6   %1 22 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR5   %1 21 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR4   %1 20 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR3   %1 19 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR2   %1 18 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR1   %1 17 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOF-BSRR_BR0   %1 16 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BR0    Port x set bit y y=  0..15
: GPIOF-BSRR_BS15   %1 15 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS15    Port x set bit y y=  0..15
: GPIOF-BSRR_BS14   %1 14 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS14    Port x set bit y y=  0..15
: GPIOF-BSRR_BS13   %1 13 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS13    Port x set bit y y=  0..15
: GPIOF-BSRR_BS12   %1 12 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS12    Port x set bit y y=  0..15
: GPIOF-BSRR_BS11   %1 11 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS11    Port x set bit y y=  0..15
: GPIOF-BSRR_BS10   %1 10 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS10    Port x set bit y y=  0..15
: GPIOF-BSRR_BS9   %1 9 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS9    Port x set bit y y=  0..15
: GPIOF-BSRR_BS8   %1 8 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS8    Port x set bit y y=  0..15
: GPIOF-BSRR_BS7   %1 7 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS7    Port x set bit y y=  0..15
: GPIOF-BSRR_BS6   %1 6 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS6    Port x set bit y y=  0..15
: GPIOF-BSRR_BS5   %1 5 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS5    Port x set bit y y=  0..15
: GPIOF-BSRR_BS4   %1 4 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS4    Port x set bit y y=  0..15
: GPIOF-BSRR_BS3   %1 3 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS3    Port x set bit y y=  0..15
: GPIOF-BSRR_BS2   %1 2 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS2    Port x set bit y y=  0..15
: GPIOF-BSRR_BS1   %1 1 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS1    Port x set bit y y=  0..15
: GPIOF-BSRR_BS0   %1 0 lshift GPIOF-BSRR bis! ;  \ GPIOF-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOF-LCKR (read-write)
: GPIOF-LCKR_LCKK   %1 16 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK15   %1 15 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK14   %1 14 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK13   %1 13 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK12   %1 12 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK11   %1 11 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK10   %1 10 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK9   %1 9 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK8   %1 8 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK7   %1 7 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK6   %1 6 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK5   %1 5 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK4   %1 4 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK3   %1 3 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK2   %1 2 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK1   %1 1 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOF-LCKR_LCK0   %1 0 lshift GPIOF-LCKR bis! ;  \ GPIOF-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOF-AFRL (read-write)
: GPIOF-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOF-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOF-AFRL bis! ;  \ GPIOF-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOF-AFRH (read-write)
: GPIOF-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOF-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOF-AFRH bis! ;  \ GPIOF-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOG-MODER (read-write)
: GPIOG-MODER_MODER15   ( %XX -- ) 30 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER14   ( %XX -- ) 28 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER13   ( %XX -- ) 26 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER12   ( %XX -- ) 24 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER11   ( %XX -- ) 22 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER10   ( %XX -- ) 20 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER9   ( %XX -- ) 18 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER8   ( %XX -- ) 16 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER7   ( %XX -- ) 14 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER6   ( %XX -- ) 12 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER5   ( %XX -- ) 10 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER4   ( %XX -- ) 8 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER3   ( %XX -- ) 6 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER2   ( %XX -- ) 4 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER1   ( %XX -- ) 2 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOG-MODER_MODER0   ( %XX -- ) 0 lshift GPIOG-MODER bis! ;  \ GPIOG-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOG-OTYPER (read-write)
: GPIOG-OTYPER_OT15   %1 15 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT14   %1 14 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT13   %1 13 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT12   %1 12 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT11   %1 11 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT10   %1 10 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT9   %1 9 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT8   %1 8 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT7   %1 7 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT6   %1 6 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT5   %1 5 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT4   %1 4 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT3   %1 3 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT2   %1 2 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT1   %1 1 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOG-OTYPER_OT0   %1 0 lshift GPIOG-OTYPER bis! ;  \ GPIOG-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOG-OSPEEDER (read-write)
: GPIOG-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOG-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOG-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOG-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOG-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOG-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOG-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOG-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOG-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOG-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOG-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOG-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOG-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOG-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOG-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOG-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOG-OSPEEDER bis! ;  \ GPIOG-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOG-PUPDR (read-write)
: GPIOG-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOG-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOG-PUPDR bis! ;  \ GPIOG-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOG-IDR (read-only)
: GPIOG-IDR_IDR15   %1 15 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR15    Port input data y =  0..15
: GPIOG-IDR_IDR14   %1 14 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR14    Port input data y =  0..15
: GPIOG-IDR_IDR13   %1 13 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR13    Port input data y =  0..15
: GPIOG-IDR_IDR12   %1 12 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR12    Port input data y =  0..15
: GPIOG-IDR_IDR11   %1 11 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR11    Port input data y =  0..15
: GPIOG-IDR_IDR10   %1 10 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR10    Port input data y =  0..15
: GPIOG-IDR_IDR9   %1 9 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR9    Port input data y =  0..15
: GPIOG-IDR_IDR8   %1 8 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR8    Port input data y =  0..15
: GPIOG-IDR_IDR7   %1 7 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR7    Port input data y =  0..15
: GPIOG-IDR_IDR6   %1 6 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR6    Port input data y =  0..15
: GPIOG-IDR_IDR5   %1 5 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR5    Port input data y =  0..15
: GPIOG-IDR_IDR4   %1 4 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR4    Port input data y =  0..15
: GPIOG-IDR_IDR3   %1 3 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR3    Port input data y =  0..15
: GPIOG-IDR_IDR2   %1 2 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR2    Port input data y =  0..15
: GPIOG-IDR_IDR1   %1 1 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR1    Port input data y =  0..15
: GPIOG-IDR_IDR0   %1 0 lshift GPIOG-IDR bis! ;  \ GPIOG-IDR_IDR0    Port input data y =  0..15

\ GPIOG-ODR (read-write)
: GPIOG-ODR_ODR15   %1 15 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR15    Port output data y =  0..15
: GPIOG-ODR_ODR14   %1 14 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR14    Port output data y =  0..15
: GPIOG-ODR_ODR13   %1 13 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR13    Port output data y =  0..15
: GPIOG-ODR_ODR12   %1 12 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR12    Port output data y =  0..15
: GPIOG-ODR_ODR11   %1 11 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR11    Port output data y =  0..15
: GPIOG-ODR_ODR10   %1 10 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR10    Port output data y =  0..15
: GPIOG-ODR_ODR9   %1 9 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR9    Port output data y =  0..15
: GPIOG-ODR_ODR8   %1 8 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR8    Port output data y =  0..15
: GPIOG-ODR_ODR7   %1 7 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR7    Port output data y =  0..15
: GPIOG-ODR_ODR6   %1 6 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR6    Port output data y =  0..15
: GPIOG-ODR_ODR5   %1 5 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR5    Port output data y =  0..15
: GPIOG-ODR_ODR4   %1 4 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR4    Port output data y =  0..15
: GPIOG-ODR_ODR3   %1 3 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR3    Port output data y =  0..15
: GPIOG-ODR_ODR2   %1 2 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR2    Port output data y =  0..15
: GPIOG-ODR_ODR1   %1 1 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR1    Port output data y =  0..15
: GPIOG-ODR_ODR0   %1 0 lshift GPIOG-ODR bis! ;  \ GPIOG-ODR_ODR0    Port output data y =  0..15

\ GPIOG-BSRR (write-only)
: GPIOG-BSRR_BR15   %1 31 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR14   %1 30 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR13   %1 29 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR12   %1 28 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR11   %1 27 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR10   %1 26 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR9   %1 25 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR8   %1 24 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR7   %1 23 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR6   %1 22 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR5   %1 21 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR4   %1 20 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR3   %1 19 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR2   %1 18 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR1   %1 17 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOG-BSRR_BR0   %1 16 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BR0    Port x set bit y y=  0..15
: GPIOG-BSRR_BS15   %1 15 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS15    Port x set bit y y=  0..15
: GPIOG-BSRR_BS14   %1 14 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS14    Port x set bit y y=  0..15
: GPIOG-BSRR_BS13   %1 13 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS13    Port x set bit y y=  0..15
: GPIOG-BSRR_BS12   %1 12 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS12    Port x set bit y y=  0..15
: GPIOG-BSRR_BS11   %1 11 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS11    Port x set bit y y=  0..15
: GPIOG-BSRR_BS10   %1 10 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS10    Port x set bit y y=  0..15
: GPIOG-BSRR_BS9   %1 9 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS9    Port x set bit y y=  0..15
: GPIOG-BSRR_BS8   %1 8 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS8    Port x set bit y y=  0..15
: GPIOG-BSRR_BS7   %1 7 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS7    Port x set bit y y=  0..15
: GPIOG-BSRR_BS6   %1 6 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS6    Port x set bit y y=  0..15
: GPIOG-BSRR_BS5   %1 5 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS5    Port x set bit y y=  0..15
: GPIOG-BSRR_BS4   %1 4 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS4    Port x set bit y y=  0..15
: GPIOG-BSRR_BS3   %1 3 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS3    Port x set bit y y=  0..15
: GPIOG-BSRR_BS2   %1 2 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS2    Port x set bit y y=  0..15
: GPIOG-BSRR_BS1   %1 1 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS1    Port x set bit y y=  0..15
: GPIOG-BSRR_BS0   %1 0 lshift GPIOG-BSRR bis! ;  \ GPIOG-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOG-LCKR (read-write)
: GPIOG-LCKR_LCKK   %1 16 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK15   %1 15 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK14   %1 14 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK13   %1 13 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK12   %1 12 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK11   %1 11 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK10   %1 10 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK9   %1 9 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK8   %1 8 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK7   %1 7 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK6   %1 6 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK5   %1 5 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK4   %1 4 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK3   %1 3 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK2   %1 2 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK1   %1 1 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOG-LCKR_LCK0   %1 0 lshift GPIOG-LCKR bis! ;  \ GPIOG-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOG-AFRL (read-write)
: GPIOG-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOG-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOG-AFRL bis! ;  \ GPIOG-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOG-AFRH (read-write)
: GPIOG-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOG-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOG-AFRH bis! ;  \ GPIOG-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOH-MODER (read-write)
: GPIOH-MODER_MODER15   ( %XX -- ) 30 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER15    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER14   ( %XX -- ) 28 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER14    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER13   ( %XX -- ) 26 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER13    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER12   ( %XX -- ) 24 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER12    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER11   ( %XX -- ) 22 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER11    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER10   ( %XX -- ) 20 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER10    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER9   ( %XX -- ) 18 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER9    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER8   ( %XX -- ) 16 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER8    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER7   ( %XX -- ) 14 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER7    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER6   ( %XX -- ) 12 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER6    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER5   ( %XX -- ) 10 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER5    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER4   ( %XX -- ) 8 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER4    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER3   ( %XX -- ) 6 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER3    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER2   ( %XX -- ) 4 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER2    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER1   ( %XX -- ) 2 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER1    Port x configuration bits y =  0..15
: GPIOH-MODER_MODER0   ( %XX -- ) 0 lshift GPIOH-MODER bis! ;  \ GPIOH-MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOH-OTYPER (read-write)
: GPIOH-OTYPER_OT15   %1 15 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT14   %1 14 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT13   %1 13 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT12   %1 12 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT11   %1 11 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT10   %1 10 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT9   %1 9 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT8   %1 8 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT7   %1 7 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT6   %1 6 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT5   %1 5 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT4   %1 4 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT3   %1 3 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT2   %1 2 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT1   %1 1 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOH-OTYPER_OT0   %1 0 lshift GPIOH-OTYPER bis! ;  \ GPIOH-OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOH-OSPEEDER (read-write)
: GPIOH-OSPEEDER_OSPEEDR15   ( %XX -- ) 30 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR15    OSPEEDR15
: GPIOH-OSPEEDER_OSPEEDR14   ( %XX -- ) 28 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR14    OSPEEDR14
: GPIOH-OSPEEDER_OSPEEDR13   ( %XX -- ) 26 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR13    OSPEEDR13
: GPIOH-OSPEEDER_OSPEEDR12   ( %XX -- ) 24 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR12    OSPEEDR12
: GPIOH-OSPEEDER_OSPEEDR11   ( %XX -- ) 22 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR11    OSPEEDR11
: GPIOH-OSPEEDER_OSPEEDR10   ( %XX -- ) 20 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR10    OSPEEDR10
: GPIOH-OSPEEDER_OSPEEDR9   ( %XX -- ) 18 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR9    OSPEEDR9
: GPIOH-OSPEEDER_OSPEEDR8   ( %XX -- ) 16 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR8    OSPEEDR8
: GPIOH-OSPEEDER_OSPEEDR7   ( %XX -- ) 14 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR7    OSPEEDR7
: GPIOH-OSPEEDER_OSPEEDR6   ( %XX -- ) 12 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR6    OSPEEDR6
: GPIOH-OSPEEDER_OSPEEDR5   ( %XX -- ) 10 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR5    OSPEEDR5
: GPIOH-OSPEEDER_OSPEEDR4   ( %XX -- ) 8 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR4    OSPEEDR4
: GPIOH-OSPEEDER_OSPEEDR3   ( %XX -- ) 6 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR3    OSPEEDR3
: GPIOH-OSPEEDER_OSPEEDR2   ( %XX -- ) 4 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR2    OSPEEDR2
: GPIOH-OSPEEDER_OSPEEDR1   ( %XX -- ) 2 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR1    OSPEEDR1
: GPIOH-OSPEEDER_OSPEEDR0   ( %XX -- ) 0 lshift GPIOH-OSPEEDER bis! ;  \ GPIOH-OSPEEDER_OSPEEDR0    OSPEEDR0

\ GPIOH-PUPDR (read-write)
: GPIOH-PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOH-PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOH-PUPDR bis! ;  \ GPIOH-PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOH-IDR (read-only)
: GPIOH-IDR_IDR15   %1 15 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR15    Port input data y =  0..15
: GPIOH-IDR_IDR14   %1 14 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR14    Port input data y =  0..15
: GPIOH-IDR_IDR13   %1 13 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR13    Port input data y =  0..15
: GPIOH-IDR_IDR12   %1 12 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR12    Port input data y =  0..15
: GPIOH-IDR_IDR11   %1 11 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR11    Port input data y =  0..15
: GPIOH-IDR_IDR10   %1 10 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR10    Port input data y =  0..15
: GPIOH-IDR_IDR9   %1 9 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR9    Port input data y =  0..15
: GPIOH-IDR_IDR8   %1 8 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR8    Port input data y =  0..15
: GPIOH-IDR_IDR7   %1 7 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR7    Port input data y =  0..15
: GPIOH-IDR_IDR6   %1 6 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR6    Port input data y =  0..15
: GPIOH-IDR_IDR5   %1 5 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR5    Port input data y =  0..15
: GPIOH-IDR_IDR4   %1 4 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR4    Port input data y =  0..15
: GPIOH-IDR_IDR3   %1 3 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR3    Port input data y =  0..15
: GPIOH-IDR_IDR2   %1 2 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR2    Port input data y =  0..15
: GPIOH-IDR_IDR1   %1 1 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR1    Port input data y =  0..15
: GPIOH-IDR_IDR0   %1 0 lshift GPIOH-IDR bis! ;  \ GPIOH-IDR_IDR0    Port input data y =  0..15

\ GPIOH-ODR (read-write)
: GPIOH-ODR_ODR15   %1 15 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR15    Port output data y =  0..15
: GPIOH-ODR_ODR14   %1 14 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR14    Port output data y =  0..15
: GPIOH-ODR_ODR13   %1 13 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR13    Port output data y =  0..15
: GPIOH-ODR_ODR12   %1 12 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR12    Port output data y =  0..15
: GPIOH-ODR_ODR11   %1 11 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR11    Port output data y =  0..15
: GPIOH-ODR_ODR10   %1 10 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR10    Port output data y =  0..15
: GPIOH-ODR_ODR9   %1 9 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR9    Port output data y =  0..15
: GPIOH-ODR_ODR8   %1 8 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR8    Port output data y =  0..15
: GPIOH-ODR_ODR7   %1 7 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR7    Port output data y =  0..15
: GPIOH-ODR_ODR6   %1 6 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR6    Port output data y =  0..15
: GPIOH-ODR_ODR5   %1 5 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR5    Port output data y =  0..15
: GPIOH-ODR_ODR4   %1 4 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR4    Port output data y =  0..15
: GPIOH-ODR_ODR3   %1 3 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR3    Port output data y =  0..15
: GPIOH-ODR_ODR2   %1 2 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR2    Port output data y =  0..15
: GPIOH-ODR_ODR1   %1 1 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR1    Port output data y =  0..15
: GPIOH-ODR_ODR0   %1 0 lshift GPIOH-ODR bis! ;  \ GPIOH-ODR_ODR0    Port output data y =  0..15

\ GPIOH-BSRR (write-only)
: GPIOH-BSRR_BR15   %1 31 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR15    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR14   %1 30 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR14    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR13   %1 29 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR13    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR12   %1 28 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR12    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR11   %1 27 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR11    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR10   %1 26 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR10    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR9   %1 25 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR9    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR8   %1 24 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR8    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR7   %1 23 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR7    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR6   %1 22 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR6    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR5   %1 21 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR5    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR4   %1 20 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR4    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR3   %1 19 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR3    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR2   %1 18 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR2    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR1   %1 17 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR1    Port x reset bit y y =  0..15
: GPIOH-BSRR_BR0   %1 16 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BR0    Port x set bit y y=  0..15
: GPIOH-BSRR_BS15   %1 15 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS15    Port x set bit y y=  0..15
: GPIOH-BSRR_BS14   %1 14 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS14    Port x set bit y y=  0..15
: GPIOH-BSRR_BS13   %1 13 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS13    Port x set bit y y=  0..15
: GPIOH-BSRR_BS12   %1 12 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS12    Port x set bit y y=  0..15
: GPIOH-BSRR_BS11   %1 11 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS11    Port x set bit y y=  0..15
: GPIOH-BSRR_BS10   %1 10 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS10    Port x set bit y y=  0..15
: GPIOH-BSRR_BS9   %1 9 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS9    Port x set bit y y=  0..15
: GPIOH-BSRR_BS8   %1 8 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS8    Port x set bit y y=  0..15
: GPIOH-BSRR_BS7   %1 7 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS7    Port x set bit y y=  0..15
: GPIOH-BSRR_BS6   %1 6 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS6    Port x set bit y y=  0..15
: GPIOH-BSRR_BS5   %1 5 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS5    Port x set bit y y=  0..15
: GPIOH-BSRR_BS4   %1 4 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS4    Port x set bit y y=  0..15
: GPIOH-BSRR_BS3   %1 3 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS3    Port x set bit y y=  0..15
: GPIOH-BSRR_BS2   %1 2 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS2    Port x set bit y y=  0..15
: GPIOH-BSRR_BS1   %1 1 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS1    Port x set bit y y=  0..15
: GPIOH-BSRR_BS0   %1 0 lshift GPIOH-BSRR bis! ;  \ GPIOH-BSRR_BS0    Port x set bit y y=  0..15

\ GPIOH-LCKR (read-write)
: GPIOH-LCKR_LCKK   %1 16 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK15   %1 15 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK14   %1 14 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK13   %1 13 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK12   %1 12 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK11   %1 11 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK10   %1 10 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK9   %1 9 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK8   %1 8 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK7   %1 7 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK6   %1 6 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK5   %1 5 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK4   %1 4 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK3   %1 3 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK2   %1 2 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK1   %1 1 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOH-LCKR_LCK0   %1 0 lshift GPIOH-LCKR bis! ;  \ GPIOH-LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOH-AFRL (read-write)
: GPIOH-AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOH-AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOH-AFRL bis! ;  \ GPIOH-AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOH-AFRH (read-write)
: GPIOH-AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOH-AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOH-AFRH bis! ;  \ GPIOH-AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ I2C1-CR1 (read-write)
: I2C1-CR1_SWRST   %1 15 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SWRST    Software reset
: I2C1-CR1_ALERT   %1 13 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ALERT    SMBus alert
: I2C1-CR1_PEC   %1 12 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PEC    Packet error checking
: I2C1-CR1_POS   %1 11 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_POS    Acknowledge/PEC Position for data  reception
: I2C1-CR1_ACK   %1 10 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ACK    Acknowledge enable
: I2C1-CR1_STOP   %1 9 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_STOP    Stop generation
: I2C1-CR1_START   %1 8 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_START    Start generation
: I2C1-CR1_NOSTRETCH   %1 7 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_NOSTRETCH    Clock stretching disable Slave  mode
: I2C1-CR1_ENGC   %1 6 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENGC    General call enable
: I2C1-CR1_ENPEC   %1 5 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENPEC    PEC enable
: I2C1-CR1_ENARP   %1 4 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_ENARP    ARP enable
: I2C1-CR1_SMBTYPE   %1 3 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBTYPE    SMBus type
: I2C1-CR1_SMBUS   %1 1 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_SMBUS    SMBus mode
: I2C1-CR1_PE   %1 0 lshift I2C1-CR1 bis! ;  \ I2C1-CR1_PE    Peripheral enable

\ I2C1-CR2 (read-write)
: I2C1-CR2_LAST   %1 12 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_LAST    DMA last transfer
: I2C1-CR2_DMAEN   %1 11 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_DMAEN    DMA requests enable
: I2C1-CR2_ITBUFEN   %1 10 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITBUFEN    Buffer interrupt enable
: I2C1-CR2_ITEVTEN   %1 9 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITEVTEN    Event interrupt enable
: I2C1-CR2_ITERREN   %1 8 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_ITERREN    Error interrupt enable
: I2C1-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C1-CR2 bis! ;  \ I2C1-CR2_FREQ    Peripheral clock frequency

\ I2C1-OAR1 (read-write)
: I2C1-OAR1_ADDMODE   %1 15 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADDMODE    ADDMODE
: I2C1-OAR1_ADD_8_9   ( %XX -- ) 8 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD_8_9    Interface address
: I2C1-OAR1_ADD_1_7   ( %XXXXXXX -- ) 1 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD_1_7    Interface address
: I2C1-OAR1_ADD_0   %1 0 lshift I2C1-OAR1 bis! ;  \ I2C1-OAR1_ADD_0    Interface address

\ I2C1-OAR2 (read-write)
: I2C1-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ADD2    Interface address
: I2C1-OAR2_ENDUAL   %1 0 lshift I2C1-OAR2 bis! ;  \ I2C1-OAR2_ENDUAL    Dual addressing mode  enable

\ I2C1-DR (read-write)
: I2C1-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C1-DR bis! ;  \ I2C1-DR_DR    -bit data register

\ I2C1-SR1 ()
: I2C1-SR1_SMBALERT   %1 15 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SMBALERT    SMBus alert
: I2C1-SR1_TIMEOUT   %1 14 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TIMEOUT    Timeout or Tlow error
: I2C1-SR1_PECERR   %1 12 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_PECERR    PEC Error in reception
: I2C1-SR1_OVR   %1 11 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_OVR    Overrun/Underrun
: I2C1-SR1_AF   %1 10 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_AF    Acknowledge failure
: I2C1-SR1_ARLO   %1 9 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ARLO    Arbitration lost master  mode
: I2C1-SR1_BERR   %1 8 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BERR    Bus error
: I2C1-SR1_TxE   %1 7 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_TxE    Data register empty  transmitters
: I2C1-SR1_RxNE   %1 6 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_RxNE    Data register not empty  receivers
: I2C1-SR1_STOPF   %1 4 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_STOPF    Stop detection slave  mode
: I2C1-SR1_ADD10   %1 3 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADD10    10-bit header sent Master  mode
: I2C1-SR1_BTF   %1 2 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_BTF    Byte transfer finished
: I2C1-SR1_ADDR   %1 1 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_ADDR    Address sent master mode/matched  slave mode
: I2C1-SR1_SB   %1 0 lshift I2C1-SR1 bis! ;  \ I2C1-SR1_SB    Start bit Master mode

\ I2C1-SR2 (read-only)
: I2C1-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_PEC    acket error checking  register
: I2C1-SR2_DUALF   %1 7 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_DUALF    Dual flag Slave mode
: I2C1-SR2_SMBHOST   %1 6 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBHOST    SMBus host header Slave  mode
: I2C1-SR2_SMBDEFAULT   %1 5 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_SMBDEFAULT    SMBus device default address Slave  mode
: I2C1-SR2_GENCALL   %1 4 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_GENCALL    General call address Slave  mode
: I2C1-SR2_TRA   %1 2 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_TRA    Transmitter/receiver
: I2C1-SR2_BUSY   %1 1 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_BUSY    Bus busy
: I2C1-SR2_MSL   %1 0 lshift I2C1-SR2 bis! ;  \ I2C1-SR2_MSL    Master/slave

\ I2C1-CCR (read-write)
: I2C1-CCR_F_S   %1 15 lshift I2C1-CCR bis! ;  \ I2C1-CCR_F_S    I2C master mode selection
: I2C1-CCR_DUTY   %1 14 lshift I2C1-CCR bis! ;  \ I2C1-CCR_DUTY    Fast mode duty cycle
: I2C1-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C1-CCR bis! ;  \ I2C1-CCR_CCR    Clock control register in Fast/Standard  mode Master mode

\ I2C1-TRISE (read-write)
: I2C1-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C1-TRISE bis! ;  \ I2C1-TRISE_TRISE    Maximum rise time in Fast/Standard mode  Master mode

\ I2C2-CR1 (read-write)
: I2C2-CR1_SWRST   %1 15 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SWRST    Software reset
: I2C2-CR1_ALERT   %1 13 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ALERT    SMBus alert
: I2C2-CR1_PEC   %1 12 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PEC    Packet error checking
: I2C2-CR1_POS   %1 11 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_POS    Acknowledge/PEC Position for data  reception
: I2C2-CR1_ACK   %1 10 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ACK    Acknowledge enable
: I2C2-CR1_STOP   %1 9 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_STOP    Stop generation
: I2C2-CR1_START   %1 8 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_START    Start generation
: I2C2-CR1_NOSTRETCH   %1 7 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_NOSTRETCH    Clock stretching disable Slave  mode
: I2C2-CR1_ENGC   %1 6 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENGC    General call enable
: I2C2-CR1_ENPEC   %1 5 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENPEC    PEC enable
: I2C2-CR1_ENARP   %1 4 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_ENARP    ARP enable
: I2C2-CR1_SMBTYPE   %1 3 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBTYPE    SMBus type
: I2C2-CR1_SMBUS   %1 1 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_SMBUS    SMBus mode
: I2C2-CR1_PE   %1 0 lshift I2C2-CR1 bis! ;  \ I2C2-CR1_PE    Peripheral enable

\ I2C2-CR2 (read-write)
: I2C2-CR2_LAST   %1 12 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_LAST    DMA last transfer
: I2C2-CR2_DMAEN   %1 11 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_DMAEN    DMA requests enable
: I2C2-CR2_ITBUFEN   %1 10 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITBUFEN    Buffer interrupt enable
: I2C2-CR2_ITEVTEN   %1 9 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITEVTEN    Event interrupt enable
: I2C2-CR2_ITERREN   %1 8 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_ITERREN    Error interrupt enable
: I2C2-CR2_FREQ   ( %XXXXXX -- ) 0 lshift I2C2-CR2 bis! ;  \ I2C2-CR2_FREQ    Peripheral clock frequency

\ I2C2-OAR1 (read-write)
: I2C2-OAR1_ADDMODE   %1 15 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADDMODE    ADDMODE
: I2C2-OAR1_ADD_8_9   ( %XX -- ) 8 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD_8_9    Interface address
: I2C2-OAR1_ADD_1_7   ( %XXXXXXX -- ) 1 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD_1_7    Interface address
: I2C2-OAR1_ADD_0   %1 0 lshift I2C2-OAR1 bis! ;  \ I2C2-OAR1_ADD_0    Interface address

\ I2C2-OAR2 (read-write)
: I2C2-OAR2_ADD2   ( %XXXXXXX -- ) 1 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ADD2    Interface address
: I2C2-OAR2_ENDUAL   %1 0 lshift I2C2-OAR2 bis! ;  \ I2C2-OAR2_ENDUAL    Dual addressing mode  enable

\ I2C2-DR (read-write)
: I2C2-DR_DR   ( %XXXXXXXX -- ) 0 lshift I2C2-DR bis! ;  \ I2C2-DR_DR    -bit data register

\ I2C2-SR1 ()
: I2C2-SR1_SMBALERT   %1 15 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SMBALERT    SMBus alert
: I2C2-SR1_TIMEOUT   %1 14 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TIMEOUT    Timeout or Tlow error
: I2C2-SR1_PECERR   %1 12 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_PECERR    PEC Error in reception
: I2C2-SR1_OVR   %1 11 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_OVR    Overrun/Underrun
: I2C2-SR1_AF   %1 10 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_AF    Acknowledge failure
: I2C2-SR1_ARLO   %1 9 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ARLO    Arbitration lost master  mode
: I2C2-SR1_BERR   %1 8 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BERR    Bus error
: I2C2-SR1_TxE   %1 7 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_TxE    Data register empty  transmitters
: I2C2-SR1_RxNE   %1 6 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_RxNE    Data register not empty  receivers
: I2C2-SR1_STOPF   %1 4 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_STOPF    Stop detection slave  mode
: I2C2-SR1_ADD10   %1 3 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADD10    10-bit header sent Master  mode
: I2C2-SR1_BTF   %1 2 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_BTF    Byte transfer finished
: I2C2-SR1_ADDR   %1 1 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_ADDR    Address sent master mode/matched  slave mode
: I2C2-SR1_SB   %1 0 lshift I2C2-SR1 bis! ;  \ I2C2-SR1_SB    Start bit Master mode

\ I2C2-SR2 (read-only)
: I2C2-SR2_PEC   ( %XXXXXXXX -- ) 8 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_PEC    acket error checking  register
: I2C2-SR2_DUALF   %1 7 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_DUALF    Dual flag Slave mode
: I2C2-SR2_SMBHOST   %1 6 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBHOST    SMBus host header Slave  mode
: I2C2-SR2_SMBDEFAULT   %1 5 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_SMBDEFAULT    SMBus device default address Slave  mode
: I2C2-SR2_GENCALL   %1 4 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_GENCALL    General call address Slave  mode
: I2C2-SR2_TRA   %1 2 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_TRA    Transmitter/receiver
: I2C2-SR2_BUSY   %1 1 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_BUSY    Bus busy
: I2C2-SR2_MSL   %1 0 lshift I2C2-SR2 bis! ;  \ I2C2-SR2_MSL    Master/slave

\ I2C2-CCR (read-write)
: I2C2-CCR_F_S   %1 15 lshift I2C2-CCR bis! ;  \ I2C2-CCR_F_S    I2C master mode selection
: I2C2-CCR_DUTY   %1 14 lshift I2C2-CCR bis! ;  \ I2C2-CCR_DUTY    Fast mode duty cycle
: I2C2-CCR_CCR   ( %XXXXXXXXXXX -- ) 0 lshift I2C2-CCR bis! ;  \ I2C2-CCR_CCR    Clock control register in Fast/Standard  mode Master mode

\ I2C2-TRISE (read-write)
: I2C2-TRISE_TRISE   ( %XXXXXX -- ) 0 lshift I2C2-TRISE bis! ;  \ I2C2-TRISE_TRISE    Maximum rise time in Fast/Standard mode  Master mode

\ IWDG-KR (write-only)
: IWDG-KR_KEY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift IWDG-KR bis! ;  \ IWDG-KR_KEY    Key value write only, read  0000h

\ IWDG-PR (read-write)
: IWDG-PR_PR   ( %XXX -- ) 0 lshift IWDG-PR bis! ;  \ IWDG-PR_PR    Prescaler divider

\ IWDG-RLR (read-write)
: IWDG-RLR_RL   ( %XXXXXXXXXXX -- ) 0 lshift IWDG-RLR bis! ;  \ IWDG-RLR_RL    Watchdog counter reload  value

\ IWDG-SR (read-only)
: IWDG-SR_RVU   %1 1 lshift IWDG-SR bis! ;  \ IWDG-SR_RVU    Watchdog counter reload value  update
: IWDG-SR_PVU   %1 0 lshift IWDG-SR bis! ;  \ IWDG-SR_PVU    Watchdog prescaler value  update

\ LCD-CR (read-write)
: LCD-CR_MUX_SEG   %1 7 lshift LCD-CR bis! ;  \ LCD-CR_MUX_SEG    Mux segment enable
: LCD-CR_BIAS   ( %XX -- ) 5 lshift LCD-CR bis! ;  \ LCD-CR_BIAS    Bias selector
: LCD-CR_DUTY   ( %XXX -- ) 2 lshift LCD-CR bis! ;  \ LCD-CR_DUTY    Duty selection
: LCD-CR_VSEL   %1 1 lshift LCD-CR bis! ;  \ LCD-CR_VSEL    Voltage source selection
: LCD-CR_LCDEN   %1 0 lshift LCD-CR bis! ;  \ LCD-CR_LCDEN    LCD controller enable

\ LCD-FCR (read-write)
: LCD-FCR_PS   ( %XXXX -- ) 22 lshift LCD-FCR bis! ;  \ LCD-FCR_PS    PS 16-bit prescaler
: LCD-FCR_DIV   ( %XXXX -- ) 18 lshift LCD-FCR bis! ;  \ LCD-FCR_DIV    DIV clock divider
: LCD-FCR_BLINK   ( %XX -- ) 16 lshift LCD-FCR bis! ;  \ LCD-FCR_BLINK    Blink mode selection
: LCD-FCR_BLINKF   ( %XXX -- ) 13 lshift LCD-FCR bis! ;  \ LCD-FCR_BLINKF    Blink frequency selection
: LCD-FCR_CC   ( %XXX -- ) 10 lshift LCD-FCR bis! ;  \ LCD-FCR_CC    Contrast control
: LCD-FCR_DEAD   ( %XXX -- ) 7 lshift LCD-FCR bis! ;  \ LCD-FCR_DEAD    Dead time duration
: LCD-FCR_PON   ( %XXX -- ) 4 lshift LCD-FCR bis! ;  \ LCD-FCR_PON    Pulse ON duration
: LCD-FCR_UDDIE   %1 3 lshift LCD-FCR bis! ;  \ LCD-FCR_UDDIE    Update display done interrupt  enable
: LCD-FCR_SOFIE   %1 1 lshift LCD-FCR bis! ;  \ LCD-FCR_SOFIE    Start of frame interrupt  enable
: LCD-FCR_HD   %1 0 lshift LCD-FCR bis! ;  \ LCD-FCR_HD    High drive enable

\ LCD-SR ()
: LCD-SR_FCRSF   %1 5 lshift LCD-SR bis! ;  \ LCD-SR_FCRSF    LCD Frame Control Register  Synchronization flag
: LCD-SR_RDY   %1 4 lshift LCD-SR bis! ;  \ LCD-SR_RDY    Ready flag
: LCD-SR_UDD   %1 3 lshift LCD-SR bis! ;  \ LCD-SR_UDD    Update Display Done
: LCD-SR_UDR   %1 2 lshift LCD-SR bis! ;  \ LCD-SR_UDR    Update display request
: LCD-SR_SOF   %1 1 lshift LCD-SR bis! ;  \ LCD-SR_SOF    Start of frame flag
: LCD-SR_ENS   %1 0 lshift LCD-SR bis! ;  \ LCD-SR_ENS    LCD enabled status

\ LCD-CLR (write-only)
: LCD-CLR_UDDC   %1 3 lshift LCD-CLR bis! ;  \ LCD-CLR_UDDC    Update display done clear
: LCD-CLR_SOFC   %1 1 lshift LCD-CLR bis! ;  \ LCD-CLR_SOFC    Start of frame flag clear

\ LCD-RAM_COM0 (read-write)
: LCD-RAM_COM0_S31   %1 31 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S31    S31
: LCD-RAM_COM0_S30   %1 30 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S30    S30
: LCD-RAM_COM0_S29   %1 29 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S29    S29
: LCD-RAM_COM0_S28   %1 28 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S28    S28
: LCD-RAM_COM0_S27   %1 27 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S27    S27
: LCD-RAM_COM0_S26   %1 26 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S26    S26
: LCD-RAM_COM0_S25   %1 25 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S25    S25
: LCD-RAM_COM0_S24   %1 24 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S24    S24
: LCD-RAM_COM0_S23   %1 23 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S23    S23
: LCD-RAM_COM0_S22   %1 22 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S22    S22
: LCD-RAM_COM0_S21   %1 21 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S21    S21
: LCD-RAM_COM0_S20   %1 20 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S20    S20
: LCD-RAM_COM0_S19   %1 19 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S19    S19
: LCD-RAM_COM0_S18   %1 18 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S18    S18
: LCD-RAM_COM0_S17   %1 17 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S17    S17
: LCD-RAM_COM0_S16   %1 16 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S16    S16
: LCD-RAM_COM0_S15   %1 15 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S15    S15
: LCD-RAM_COM0_S14   %1 14 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S14    S14
: LCD-RAM_COM0_S13   %1 13 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S13    S13
: LCD-RAM_COM0_S12   %1 12 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S12    S12
: LCD-RAM_COM0_S11   %1 11 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S11    S11
: LCD-RAM_COM0_S10   %1 10 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S10    S10
: LCD-RAM_COM0_S09   %1 9 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S09    S09
: LCD-RAM_COM0_S08   %1 8 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S08    S08
: LCD-RAM_COM0_S07   %1 7 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S07    S07
: LCD-RAM_COM0_S06   %1 6 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S06    S06
: LCD-RAM_COM0_S05   %1 5 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S05    S05
: LCD-RAM_COM0_S04   %1 4 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S04    S04
: LCD-RAM_COM0_S03   %1 3 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S03    S03
: LCD-RAM_COM0_S02   %1 2 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S02    S02
: LCD-RAM_COM0_S01   %1 1 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S01    S01
: LCD-RAM_COM0_S00   %1 0 lshift LCD-RAM_COM0 bis! ;  \ LCD-RAM_COM0_S00    S00

\ LCD-RAM_COM1 (read-write)
: LCD-RAM_COM1_S31   %1 31 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S31    S31
: LCD-RAM_COM1_S30   %1 30 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S30    S30
: LCD-RAM_COM1_S29   %1 29 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S29    S29
: LCD-RAM_COM1_S28   %1 28 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S28    S28
: LCD-RAM_COM1_S27   %1 27 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S27    S27
: LCD-RAM_COM1_S26   %1 26 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S26    S26
: LCD-RAM_COM1_S25   %1 25 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S25    S25
: LCD-RAM_COM1_S24   %1 24 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S24    S24
: LCD-RAM_COM1_S23   %1 23 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S23    S23
: LCD-RAM_COM1_S22   %1 22 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S22    S22
: LCD-RAM_COM1_S21   %1 21 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S21    S21
: LCD-RAM_COM1_S20   %1 20 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S20    S20
: LCD-RAM_COM1_S19   %1 19 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S19    S19
: LCD-RAM_COM1_S18   %1 18 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S18    S18
: LCD-RAM_COM1_S17   %1 17 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S17    S17
: LCD-RAM_COM1_S16   %1 16 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S16    S16
: LCD-RAM_COM1_S15   %1 15 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S15    S15
: LCD-RAM_COM1_S14   %1 14 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S14    S14
: LCD-RAM_COM1_S13   %1 13 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S13    S13
: LCD-RAM_COM1_S12   %1 12 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S12    S12
: LCD-RAM_COM1_S11   %1 11 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S11    S11
: LCD-RAM_COM1_S10   %1 10 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S10    S10
: LCD-RAM_COM1_S09   %1 9 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S09    S09
: LCD-RAM_COM1_S08   %1 8 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S08    S08
: LCD-RAM_COM1_S07   %1 7 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S07    S07
: LCD-RAM_COM1_S06   %1 6 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S06    S06
: LCD-RAM_COM1_S05   %1 5 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S05    S05
: LCD-RAM_COM1_S04   %1 4 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S04    S04
: LCD-RAM_COM1_S03   %1 3 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S03    S03
: LCD-RAM_COM1_S02   %1 2 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S02    S02
: LCD-RAM_COM1_S01   %1 1 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S01    S01
: LCD-RAM_COM1_S00   %1 0 lshift LCD-RAM_COM1 bis! ;  \ LCD-RAM_COM1_S00    S00

\ LCD-RAM_COM2 (read-write)
: LCD-RAM_COM2_S31   %1 31 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S31    S31
: LCD-RAM_COM2_S30   %1 30 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S30    S30
: LCD-RAM_COM2_S29   %1 29 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S29    S29
: LCD-RAM_COM2_S28   %1 28 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S28    S28
: LCD-RAM_COM2_S27   %1 27 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S27    S27
: LCD-RAM_COM2_S26   %1 26 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S26    S26
: LCD-RAM_COM2_S25   %1 25 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S25    S25
: LCD-RAM_COM2_S24   %1 24 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S24    S24
: LCD-RAM_COM2_S23   %1 23 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S23    S23
: LCD-RAM_COM2_S22   %1 22 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S22    S22
: LCD-RAM_COM2_S21   %1 21 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S21    S21
: LCD-RAM_COM2_S20   %1 20 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S20    S20
: LCD-RAM_COM2_S19   %1 19 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S19    S19
: LCD-RAM_COM2_S18   %1 18 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S18    S18
: LCD-RAM_COM2_S17   %1 17 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S17    S17
: LCD-RAM_COM2_S16   %1 16 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S16    S16
: LCD-RAM_COM2_S15   %1 15 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S15    S15
: LCD-RAM_COM2_S14   %1 14 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S14    S14
: LCD-RAM_COM2_S13   %1 13 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S13    S13
: LCD-RAM_COM2_S12   %1 12 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S12    S12
: LCD-RAM_COM2_S11   %1 11 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S11    S11
: LCD-RAM_COM2_S10   %1 10 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S10    S10
: LCD-RAM_COM2_S09   %1 9 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S09    S09
: LCD-RAM_COM2_S08   %1 8 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S08    S08
: LCD-RAM_COM2_S07   %1 7 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S07    S07
: LCD-RAM_COM2_S06   %1 6 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S06    S06
: LCD-RAM_COM2_S05   %1 5 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S05    S05
: LCD-RAM_COM2_S04   %1 4 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S04    S04
: LCD-RAM_COM2_S03   %1 3 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S03    S03
: LCD-RAM_COM2_S02   %1 2 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S02    S02
: LCD-RAM_COM2_S01   %1 1 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S01    S01
: LCD-RAM_COM2_S00   %1 0 lshift LCD-RAM_COM2 bis! ;  \ LCD-RAM_COM2_S00    S00

\ LCD-RAM_COM3 (read-write)
: LCD-RAM_COM3_S31   %1 31 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S31    S31
: LCD-RAM_COM3_S30   %1 30 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S30    S30
: LCD-RAM_COM3_S29   %1 29 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S29    S29
: LCD-RAM_COM3_S28   %1 28 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S28    S28
: LCD-RAM_COM3_S27   %1 27 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S27    S27
: LCD-RAM_COM3_S26   %1 26 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S26    S26
: LCD-RAM_COM3_S25   %1 25 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S25    S25
: LCD-RAM_COM3_S24   %1 24 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S24    S24
: LCD-RAM_COM3_S23   %1 23 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S23    S23
: LCD-RAM_COM3_S22   %1 22 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S22    S22
: LCD-RAM_COM3_S21   %1 21 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S21    S21
: LCD-RAM_COM3_S20   %1 20 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S20    S20
: LCD-RAM_COM3_S19   %1 19 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S19    S19
: LCD-RAM_COM3_S18   %1 18 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S18    S18
: LCD-RAM_COM3_S17   %1 17 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S17    S17
: LCD-RAM_COM3_S16   %1 16 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S16    S16
: LCD-RAM_COM3_S15   %1 15 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S15    S15
: LCD-RAM_COM3_S14   %1 14 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S14    S14
: LCD-RAM_COM3_S13   %1 13 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S13    S13
: LCD-RAM_COM3_S12   %1 12 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S12    S12
: LCD-RAM_COM3_S11   %1 11 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S11    S11
: LCD-RAM_COM3_S10   %1 10 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S10    S10
: LCD-RAM_COM3_S09   %1 9 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S09    S09
: LCD-RAM_COM3_S08   %1 8 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S08    S08
: LCD-RAM_COM3_S07   %1 7 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S07    S07
: LCD-RAM_COM3_S06   %1 6 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S06    S06
: LCD-RAM_COM3_S05   %1 5 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S05    S05
: LCD-RAM_COM3_S04   %1 4 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S04    S04
: LCD-RAM_COM3_S03   %1 3 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S03    S03
: LCD-RAM_COM3_S02   %1 2 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S02    S02
: LCD-RAM_COM3_S01   %1 1 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S01    S01
: LCD-RAM_COM3_S00   %1 0 lshift LCD-RAM_COM3 bis! ;  \ LCD-RAM_COM3_S00    S00

\ LCD-RAM_COM4 (read-write)
: LCD-RAM_COM4_S31   %1 31 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S31    S31
: LCD-RAM_COM4_S30   %1 30 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S30    S30
: LCD-RAM_COM4_S29   %1 29 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S29    S29
: LCD-RAM_COM4_S28   %1 28 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S28    S28
: LCD-RAM_COM4_S27   %1 27 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S27    S27
: LCD-RAM_COM4_S26   %1 26 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S26    S26
: LCD-RAM_COM4_S25   %1 25 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S25    S25
: LCD-RAM_COM4_S24   %1 24 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S24    S24
: LCD-RAM_COM4_S23   %1 23 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S23    S23
: LCD-RAM_COM4_S22   %1 22 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S22    S22
: LCD-RAM_COM4_S21   %1 21 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S21    S21
: LCD-RAM_COM4_S20   %1 20 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S20    S20
: LCD-RAM_COM4_S19   %1 19 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S19    S19
: LCD-RAM_COM4_S18   %1 18 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S18    S18
: LCD-RAM_COM4_S17   %1 17 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S17    S17
: LCD-RAM_COM4_S16   %1 16 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S16    S16
: LCD-RAM_COM4_S15   %1 15 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S15    S15
: LCD-RAM_COM4_S14   %1 14 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S14    S14
: LCD-RAM_COM4_S13   %1 13 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S13    S13
: LCD-RAM_COM4_S12   %1 12 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S12    S12
: LCD-RAM_COM4_S11   %1 11 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S11    S11
: LCD-RAM_COM4_S10   %1 10 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S10    S10
: LCD-RAM_COM4_S09   %1 9 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S09    S09
: LCD-RAM_COM4_S08   %1 8 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S08    S08
: LCD-RAM_COM4_S07   %1 7 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S07    S07
: LCD-RAM_COM4_S06   %1 6 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S06    S06
: LCD-RAM_COM4_S05   %1 5 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S05    S05
: LCD-RAM_COM4_S04   %1 4 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S04    S04
: LCD-RAM_COM4_S03   %1 3 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S03    S03
: LCD-RAM_COM4_S02   %1 2 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S02    S02
: LCD-RAM_COM4_S01   %1 1 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S01    S01
: LCD-RAM_COM4_S00   %1 0 lshift LCD-RAM_COM4 bis! ;  \ LCD-RAM_COM4_S00    S00

\ LCD-RAM_COM5 (read-write)
: LCD-RAM_COM5_S31   %1 31 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S31    S31
: LCD-RAM_COM5_S30   %1 30 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S30    S30
: LCD-RAM_COM5_S29   %1 29 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S29    S29
: LCD-RAM_COM5_S28   %1 28 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S28    S28
: LCD-RAM_COM5_S27   %1 27 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S27    S27
: LCD-RAM_COM5_S26   %1 26 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S26    S26
: LCD-RAM_COM5_S25   %1 25 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S25    S25
: LCD-RAM_COM5_S24   %1 24 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S24    S24
: LCD-RAM_COM5_S23   %1 23 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S23    S23
: LCD-RAM_COM5_S22   %1 22 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S22    S22
: LCD-RAM_COM5_S21   %1 21 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S21    S21
: LCD-RAM_COM5_S20   %1 20 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S20    S20
: LCD-RAM_COM5_S19   %1 19 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S19    S19
: LCD-RAM_COM5_S18   %1 18 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S18    S18
: LCD-RAM_COM5_S17   %1 17 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S17    S17
: LCD-RAM_COM5_S16   %1 16 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S16    S16
: LCD-RAM_COM5_S15   %1 15 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S15    S15
: LCD-RAM_COM5_S14   %1 14 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S14    S14
: LCD-RAM_COM5_S13   %1 13 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S13    S13
: LCD-RAM_COM5_S12   %1 12 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S12    S12
: LCD-RAM_COM5_S11   %1 11 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S11    S11
: LCD-RAM_COM5_S10   %1 10 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S10    S10
: LCD-RAM_COM5_S09   %1 9 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S09    S09
: LCD-RAM_COM5_S08   %1 8 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S08    S08
: LCD-RAM_COM5_S07   %1 7 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S07    S07
: LCD-RAM_COM5_S06   %1 6 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S06    S06
: LCD-RAM_COM5_S05   %1 5 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S05    S05
: LCD-RAM_COM5_S04   %1 4 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S04    S04
: LCD-RAM_COM5_S03   %1 3 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S03    S03
: LCD-RAM_COM5_S02   %1 2 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S02    S02
: LCD-RAM_COM5_S01   %1 1 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S01    S01
: LCD-RAM_COM5_S00   %1 0 lshift LCD-RAM_COM5 bis! ;  \ LCD-RAM_COM5_S00    S00

\ LCD-RAM_COM6 (read-write)
: LCD-RAM_COM6_S31   %1 31 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S31    S31
: LCD-RAM_COM6_S30   %1 30 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S30    S30
: LCD-RAM_COM6_S29   %1 29 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S29    S29
: LCD-RAM_COM6_S28   %1 28 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S28    S28
: LCD-RAM_COM6_S27   %1 27 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S27    S27
: LCD-RAM_COM6_S26   %1 26 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S26    S26
: LCD-RAM_COM6_S25   %1 25 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S25    S25
: LCD-RAM_COM6_S24   %1 24 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S24    S24
: LCD-RAM_COM6_S23   %1 23 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S23    S23
: LCD-RAM_COM6_S22   %1 22 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S22    S22
: LCD-RAM_COM6_S21   %1 21 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S21    S21
: LCD-RAM_COM6_S20   %1 20 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S20    S20
: LCD-RAM_COM6_S19   %1 19 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S19    S19
: LCD-RAM_COM6_S18   %1 18 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S18    S18
: LCD-RAM_COM6_S17   %1 17 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S17    S17
: LCD-RAM_COM6_S16   %1 16 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S16    S16
: LCD-RAM_COM6_S15   %1 15 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S15    S15
: LCD-RAM_COM6_S14   %1 14 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S14    S14
: LCD-RAM_COM6_S13   %1 13 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S13    S13
: LCD-RAM_COM6_S12   %1 12 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S12    S12
: LCD-RAM_COM6_S11   %1 11 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S11    S11
: LCD-RAM_COM6_S10   %1 10 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S10    S10
: LCD-RAM_COM6_S09   %1 9 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S09    S09
: LCD-RAM_COM6_S08   %1 8 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S08    S08
: LCD-RAM_COM6_S07   %1 7 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S07    S07
: LCD-RAM_COM6_S06   %1 6 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S06    S06
: LCD-RAM_COM6_S05   %1 5 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S05    S05
: LCD-RAM_COM6_S04   %1 4 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S04    S04
: LCD-RAM_COM6_S03   %1 3 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S03    S03
: LCD-RAM_COM6_S02   %1 2 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S02    S02
: LCD-RAM_COM6_S01   %1 1 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S01    S01
: LCD-RAM_COM6_S00   %1 0 lshift LCD-RAM_COM6 bis! ;  \ LCD-RAM_COM6_S00    S00

\ LCD-RAM_COM7 (read-write)
: LCD-RAM_COM7_S31   %1 31 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S31    S31
: LCD-RAM_COM7_S30   %1 30 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S30    S30
: LCD-RAM_COM7_S29   %1 29 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S29    S29
: LCD-RAM_COM7_S28   %1 28 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S28    S28
: LCD-RAM_COM7_S27   %1 27 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S27    S27
: LCD-RAM_COM7_S26   %1 26 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S26    S26
: LCD-RAM_COM7_S25   %1 25 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S25    S25
: LCD-RAM_COM7_S24   %1 24 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S24    S24
: LCD-RAM_COM7_S23   %1 23 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S23    S23
: LCD-RAM_COM7_S22   %1 22 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S22    S22
: LCD-RAM_COM7_S21   %1 21 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S21    S21
: LCD-RAM_COM7_S20   %1 20 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S20    S20
: LCD-RAM_COM7_S19   %1 19 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S19    S19
: LCD-RAM_COM7_S18   %1 18 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S18    S18
: LCD-RAM_COM7_S17   %1 17 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S17    S17
: LCD-RAM_COM7_S16   %1 16 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S16    S16
: LCD-RAM_COM7_S15   %1 15 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S15    S15
: LCD-RAM_COM7_S14   %1 14 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S14    S14
: LCD-RAM_COM7_S13   %1 13 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S13    S13
: LCD-RAM_COM7_S12   %1 12 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S12    S12
: LCD-RAM_COM7_S11   %1 11 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S11    S11
: LCD-RAM_COM7_S10   %1 10 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S10    S10
: LCD-RAM_COM7_S09   %1 9 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S09    S09
: LCD-RAM_COM7_S08   %1 8 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S08    S08
: LCD-RAM_COM7_S07   %1 7 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S07    S07
: LCD-RAM_COM7_S06   %1 6 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S06    S06
: LCD-RAM_COM7_S05   %1 5 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S05    S05
: LCD-RAM_COM7_S04   %1 4 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S04    S04
: LCD-RAM_COM7_S03   %1 3 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S03    S03
: LCD-RAM_COM7_S02   %1 2 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S02    S02
: LCD-RAM_COM7_S01   %1 1 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S01    S01
: LCD-RAM_COM7_S00   %1 0 lshift LCD-RAM_COM7 bis! ;  \ LCD-RAM_COM7_S00    S00

\ OPAMP-CSR (read-write)
: OPAMP-CSR_OPA3CALOUT   %1 31 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA3CALOUT    OPAMP3 calibration output
: OPAMP-CSR_OPA2CALOUT   %1 30 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA2CALOUT    OPAMP2 calibration output
: OPAMP-CSR_OPA1CALOUT   %1 29 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA1CALOUT    OPAMP1 calibration output
: OPAMP-CSR_AOP_RANGE   %1 28 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_AOP_RANGE    Power range selection
: OPAMP-CSR_S7SEL2   %1 27 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S7SEL2    Switch 7 for OPAMP2 enable
: OPAMP-CSR_ANAWSEL3   %1 26 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_ANAWSEL3    Switch SanA enable for  OPAMP3
: OPAMP-CSR_ANAWSEL2   %1 25 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_ANAWSEL2    Switch SanA enable for  OPAMP2
: OPAMP-CSR_ANAWSEL1   %1 24 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_ANAWSEL1    Switch SanA enable for  OPAMP1
: OPAMP-CSR_OPA3LPM   %1 23 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA3LPM    OPAMP3 low power mode
: OPAMP-CSR_OPA3CAL_H   %1 22 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA3CAL_H    OPAMP3 offset calibration for N  differential pair
: OPAMP-CSR_OPA3CAL_L   %1 21 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA3CAL_L    OPAMP3 offset Calibration for P  differential pair
: OPAMP-CSR_S6SEL3   %1 20 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S6SEL3    Switch 6 for OPAMP3 enable
: OPAMP-CSR_S5SEL3   %1 19 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S5SEL3    Switch 5 for OPAMP3 enable
: OPAMP-CSR_S4SEL3   %1 18 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S4SEL3    Switch 4 for OPAMP3 enable
: OPAMP-CSR_S3SEL3   %1 17 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S3SEL3    Switch 3 for OPAMP3 Enable
: OPAMP-CSR_OPA3PD   %1 16 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA3PD    OPAMP3 power down
: OPAMP-CSR_OPA2LPM   %1 15 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA2LPM    OPAMP2 low power mode
: OPAMP-CSR_OPA2CAL_H   %1 14 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA2CAL_H    OPAMP2 offset calibration for N  differential pair
: OPAMP-CSR_OPA2CAL_L   %1 13 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA2CAL_L    OPAMP2 offset Calibration for P  differential pair
: OPAMP-CSR_S6SEL2   %1 12 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S6SEL2    Switch 6 for OPAMP2 enable
: OPAMP-CSR_S5SEL2   %1 11 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S5SEL2    Switch 5 for OPAMP2 enable
: OPAMP-CSR_S4SEL2   %1 10 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S4SEL2    Switch 4 for OPAMP2 enable
: OPAMP-CSR_S3SEL2   %1 9 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S3SEL2    Switch 3 for OPAMP2 enable
: OPAMP-CSR_OPA2PD   %1 8 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA2PD    OPAMP2 power down
: OPAMP-CSR_OPA1LPM   %1 7 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA1LPM    OPAMP1 low power mode
: OPAMP-CSR_OPA1CAL_H   %1 6 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA1CAL_H    OPAMP1 offset calibration for N  differential pair
: OPAMP-CSR_OPA1CAL_L   %1 5 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA1CAL_L    OPAMP1 offset calibration for P  differential pair
: OPAMP-CSR_S6SEL1   %1 4 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S6SEL1    Switch 6 for OPAMP1 enable
: OPAMP-CSR_S5SEL1   %1 3 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S5SEL1    Switch 5 for OPAMP1 enable
: OPAMP-CSR_S4SEL1   %1 2 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S4SEL1    Switch 4 for OPAMP1 enable
: OPAMP-CSR_S3SEL1   %1 1 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_S3SEL1    Switch 3 for OPAMP1 enable
: OPAMP-CSR_OPA1PD   %1 0 lshift OPAMP-CSR bis! ;  \ OPAMP-CSR_OPA1PD    OPAMP1 power down

\ OPAMP-OTR (read-write)
: OPAMP-OTR_OT_USER   %1 31 lshift OPAMP-OTR bis! ;  \ OPAMP-OTR_OT_USER    Select user or factory trimming  value
: OPAMP-OTR_AO3_OPT_OFFSET_TRIM  20 lshift OPAMP-OTR bis! ;  \ OPAMP-OTR_AO3_OPT_OFFSET_TRIM    OPAMP3, 10-bit offset trim value for  normal mode
: OPAMP-OTR_AO2_OPT_OFFSET_TRIM  10 lshift OPAMP-OTR bis! ;  \ OPAMP-OTR_AO2_OPT_OFFSET_TRIM    OPAMP2, 10-bit offset trim value for  normal mode
: OPAMP-OTR_AO1_OPT_OFFSET_TRIM  0 lshift OPAMP-OTR bis! ;  \ OPAMP-OTR_AO1_OPT_OFFSET_TRIM    OPAMP1, 10-bit offset trim value for  normal mode

\ OPAMP-LPOTR (read-write)
: OPAMP-LPOTR_AO3_OPT_OFFSET_TRIM_LP  20 lshift OPAMP-LPOTR bis! ;  \ OPAMP-LPOTR_AO3_OPT_OFFSET_TRIM_LP    OPAMP3, 10-bit offset trim value for low  power mode
: OPAMP-LPOTR_AO2_OPT_OFFSET_TRIM_LP  10 lshift OPAMP-LPOTR bis! ;  \ OPAMP-LPOTR_AO2_OPT_OFFSET_TRIM_LP    OPAMP2, 10-bit offset trim value for low  power mode
: OPAMP-LPOTR_AO1_OPT_OFFSET_TRIM_LP  0 lshift OPAMP-LPOTR bis! ;  \ OPAMP-LPOTR_AO1_OPT_OFFSET_TRIM_LP    OPAMP1, 10-bit offset trim value for low  power mode

\ PWR-CR (read-write)
: PWR-CR_LPRUN   %1 14 lshift PWR-CR bis! ;  \ PWR-CR_LPRUN    Low power run mode
: PWR-CR_VOS   ( %XX -- ) 11 lshift PWR-CR bis! ;  \ PWR-CR_VOS    Voltage scaling range  selection
: PWR-CR_FWU   %1 10 lshift PWR-CR bis! ;  \ PWR-CR_FWU    Fast wakeup
: PWR-CR_ULP   %1 9 lshift PWR-CR bis! ;  \ PWR-CR_ULP    Ultralow power mode
: PWR-CR_DBP   %1 8 lshift PWR-CR bis! ;  \ PWR-CR_DBP    Disable backup domain write  protection
: PWR-CR_PLS   ( %XXX -- ) 5 lshift PWR-CR bis! ;  \ PWR-CR_PLS    PVD level selection
: PWR-CR_PVDE   %1 4 lshift PWR-CR bis! ;  \ PWR-CR_PVDE    Power voltage detector  enable
: PWR-CR_CSBF   %1 3 lshift PWR-CR bis! ;  \ PWR-CR_CSBF    Clear standby flag
: PWR-CR_CWUF   %1 2 lshift PWR-CR bis! ;  \ PWR-CR_CWUF    Clear wakeup flag
: PWR-CR_PDDS   %1 1 lshift PWR-CR bis! ;  \ PWR-CR_PDDS    Power down deepsleep
: PWR-CR_LPSDSR   %1 0 lshift PWR-CR bis! ;  \ PWR-CR_LPSDSR    Low-power deep sleep

\ PWR-CSR ()
: PWR-CSR_EWUP3   %1 10 lshift PWR-CSR bis! ;  \ PWR-CSR_EWUP3    Enable WKUP pin 3
: PWR-CSR_EWUP2   %1 9 lshift PWR-CSR bis! ;  \ PWR-CSR_EWUP2    Enable WKUP pin 2
: PWR-CSR_EWUP1   %1 8 lshift PWR-CSR bis! ;  \ PWR-CSR_EWUP1    Enable WKUP pin 1
: PWR-CSR_REGLPF   %1 5 lshift PWR-CSR bis! ;  \ PWR-CSR_REGLPF    Regulator LP flag
: PWR-CSR_VOSF   %1 4 lshift PWR-CSR bis! ;  \ PWR-CSR_VOSF    Voltage Scaling select  flag
: PWR-CSR_VREFINTRDYF   %1 3 lshift PWR-CSR bis! ;  \ PWR-CSR_VREFINTRDYF    Internal voltage reference VREFINT  ready flag
: PWR-CSR_PVDO   %1 2 lshift PWR-CSR bis! ;  \ PWR-CSR_PVDO    PVD output
: PWR-CSR_SBF   %1 1 lshift PWR-CSR bis! ;  \ PWR-CSR_SBF    Standby flag
: PWR-CSR_WUF   %1 0 lshift PWR-CSR bis! ;  \ PWR-CSR_WUF    Wakeup flag

\ RCC-CR ()
: RCC-CR_RTCPRE1   %1 30 lshift RCC-CR bis! ;  \ RCC-CR_RTCPRE1    TC/LCD prescaler
: RCC-CR_RTCPRE0   %1 29 lshift RCC-CR bis! ;  \ RCC-CR_RTCPRE0    RTCPRE0
: RCC-CR_CSSON   %1 28 lshift RCC-CR bis! ;  \ RCC-CR_CSSON    Clock security system  enable
: RCC-CR_PLLRDY   %1 25 lshift RCC-CR bis! ;  \ RCC-CR_PLLRDY    PLL clock ready flag
: RCC-CR_PLLON   %1 24 lshift RCC-CR bis! ;  \ RCC-CR_PLLON    PLL enable
: RCC-CR_HSEBYP   %1 18 lshift RCC-CR bis! ;  \ RCC-CR_HSEBYP    HSE clock bypass
: RCC-CR_HSERDY   %1 17 lshift RCC-CR bis! ;  \ RCC-CR_HSERDY    HSE clock ready flag
: RCC-CR_HSEON   %1 16 lshift RCC-CR bis! ;  \ RCC-CR_HSEON    HSE clock enable
: RCC-CR_MSIRDY   %1 9 lshift RCC-CR bis! ;  \ RCC-CR_MSIRDY    MSI clock ready flag
: RCC-CR_MSION   %1 8 lshift RCC-CR bis! ;  \ RCC-CR_MSION    MSI clock enable
: RCC-CR_HSIRDY   %1 1 lshift RCC-CR bis! ;  \ RCC-CR_HSIRDY    Internal high-speed clock ready  flag
: RCC-CR_HSION   %1 0 lshift RCC-CR bis! ;  \ RCC-CR_HSION    Internal high-speed clock  enable

\ RCC-ICSCR ()
: RCC-ICSCR_MSITRIM   ( %XXXXXXXX -- ) 24 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_MSITRIM    MSI clock trimming
: RCC-ICSCR_MSICAL   ( %XXXXXXXX -- ) 16 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_MSICAL    MSI clock calibration
: RCC-ICSCR_MSIRANGE   ( %XXX -- ) 13 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_MSIRANGE    MSI clock ranges
: RCC-ICSCR_HSITRIM   ( %XXXXX -- ) 8 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_HSITRIM    High speed internal clock  trimming
: RCC-ICSCR_HSICAL   ( %XXXXXXXX -- ) 0 lshift RCC-ICSCR bis! ;  \ RCC-ICSCR_HSICAL    nternal high speed clock  calibration

\ RCC-CFGR ()
: RCC-CFGR_MCOPRE   ( %XXX -- ) 28 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCOPRE    Microcontroller clock output  prescaler
: RCC-CFGR_MCOSEL   ( %XXX -- ) 24 lshift RCC-CFGR bis! ;  \ RCC-CFGR_MCOSEL    Microcontroller clock output  selection
: RCC-CFGR_PLLDIV   ( %XX -- ) 22 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLDIV    PLL output division
: RCC-CFGR_PLLMUL   ( %XXXX -- ) 18 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLMUL    PLL multiplication factor
: RCC-CFGR_PLLSRC   %1 16 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PLLSRC    PLL entry clock source
: RCC-CFGR_PPRE2   ( %XXX -- ) 11 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE2    APB high-speed prescaler  APB2
: RCC-CFGR_PPRE1   ( %XXX -- ) 8 lshift RCC-CFGR bis! ;  \ RCC-CFGR_PPRE1    APB low-speed prescaler  APB1
: RCC-CFGR_HPRE   ( %XXXX -- ) 4 lshift RCC-CFGR bis! ;  \ RCC-CFGR_HPRE    AHB prescaler
: RCC-CFGR_SWS   ( %XX -- ) 2 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SWS    System clock switch status
: RCC-CFGR_SW   ( %XX -- ) 0 lshift RCC-CFGR bis! ;  \ RCC-CFGR_SW    System clock switch

\ RCC-CIR ()
: RCC-CIR_CSSC   %1 23 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSC    Clock security system interrupt  clear
: RCC-CIR_LSECSSC   %1 22 lshift RCC-CIR bis! ;  \ RCC-CIR_LSECSSC    LSE CSS interrupt clear
: RCC-CIR_MSIRDYC   %1 21 lshift RCC-CIR bis! ;  \ RCC-CIR_MSIRDYC    MSI ready interrupt clear
: RCC-CIR_PLLRDYC   %1 20 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYC    PLL ready interrupt clear
: RCC-CIR_HSERDYC   %1 19 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYC    HSE ready interrupt clear
: RCC-CIR_HSIRDYC   %1 18 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYC    HSI ready interrupt clear
: RCC-CIR_LSERDYC   %1 17 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYC    LSE ready interrupt clear
: RCC-CIR_LSIRDYC   %1 16 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYC    LSI ready interrupt clear
: RCC-CIR_LSECSSIE   %1 14 lshift RCC-CIR bis! ;  \ RCC-CIR_LSECSSIE    LSE CSS interrupt enable
: RCC-CIR_MSIRDYIE   %1 13 lshift RCC-CIR bis! ;  \ RCC-CIR_MSIRDYIE    MSI ready interrupt enable
: RCC-CIR_PLLRDYIE   %1 12 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYIE    PLL ready interrupt enable
: RCC-CIR_HSERDYIE   %1 11 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYIE    HSE ready interrupt enable
: RCC-CIR_HSIRDYIE   %1 10 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYIE    HSI ready interrupt enable
: RCC-CIR_LSERDYIE   %1 9 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYIE    LSE ready interrupt enable
: RCC-CIR_LSIRDYIE   %1 8 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYIE    LSI ready interrupt enable
: RCC-CIR_CSSF   %1 7 lshift RCC-CIR bis! ;  \ RCC-CIR_CSSF    Clock security system interrupt  flag
: RCC-CIR_LSECSSF   %1 6 lshift RCC-CIR bis! ;  \ RCC-CIR_LSECSSF    LSE CSS Interrupt flag
: RCC-CIR_MSIRDYF   %1 5 lshift RCC-CIR bis! ;  \ RCC-CIR_MSIRDYF    MSI ready interrupt flag
: RCC-CIR_PLLRDYF   %1 4 lshift RCC-CIR bis! ;  \ RCC-CIR_PLLRDYF    PLL ready interrupt flag
: RCC-CIR_HSERDYF   %1 3 lshift RCC-CIR bis! ;  \ RCC-CIR_HSERDYF    HSE ready interrupt flag
: RCC-CIR_HSIRDYF   %1 2 lshift RCC-CIR bis! ;  \ RCC-CIR_HSIRDYF    HSI ready interrupt flag
: RCC-CIR_LSERDYF   %1 1 lshift RCC-CIR bis! ;  \ RCC-CIR_LSERDYF    LSE ready interrupt flag
: RCC-CIR_LSIRDYF   %1 0 lshift RCC-CIR bis! ;  \ RCC-CIR_LSIRDYF    LSI ready interrupt flag

\ RCC-AHBRSTR (read-write)
: RCC-AHBRSTR_DMA2RST   %1 25 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_DMA2RST    DMA2 reset
: RCC-AHBRSTR_DMA1RST   %1 24 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_DMA1RST    DMA1 reset
: RCC-AHBRSTR_FLITFRST   %1 15 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_FLITFRST    FLITF reset
: RCC-AHBRSTR_CRCRST   %1 12 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_CRCRST    CRC reset
: RCC-AHBRSTR_GPIOGRST   %1 7 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOGRST    IO port G reset
: RCC-AHBRSTR_GPIOFRST   %1 6 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOFRST    IO port F reset
: RCC-AHBRSTR_GPIOHRST   %1 5 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOHRST    IO port H reset
: RCC-AHBRSTR_GPIOERST   %1 4 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOERST    IO port E reset
: RCC-AHBRSTR_GPIODRST   %1 3 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIODRST    IO port D reset
: RCC-AHBRSTR_GPIOCRST   %1 2 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOCRST    IO port C reset
: RCC-AHBRSTR_GPIOBRST   %1 1 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOBRST    IO port B reset
: RCC-AHBRSTR_GPIOARST   %1 0 lshift RCC-AHBRSTR bis! ;  \ RCC-AHBRSTR_GPIOARST    IO port A reset

\ RCC-APB2RSTR (read-write)
: RCC-APB2RSTR_USART1RST   %1 14 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_USART1RST    USART1RST
: RCC-APB2RSTR_SPI1RST   %1 12 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SPI1RST    SPI1RST
: RCC-APB2RSTR_ADC1RST   %1 9 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_ADC1RST    ADC1RST
: RCC-APB2RSTR_TM11RST   %1 4 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TM11RST    TM11RST
: RCC-APB2RSTR_TM10RST   %1 3 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TM10RST    TM10RST
: RCC-APB2RSTR_TIM9RST   %1 2 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_TIM9RST    TIM9RST
: RCC-APB2RSTR_SYSCFGRST   %1 0 lshift RCC-APB2RSTR bis! ;  \ RCC-APB2RSTR_SYSCFGRST    SYSCFGRST

\ RCC-APB1RSTR (read-write)
: RCC-APB1RSTR_COMPRST   %1 31 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_COMPRST    COMP interface reset
: RCC-APB1RSTR_DACRST   %1 29 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_DACRST    DAC interface reset
: RCC-APB1RSTR_PWRRST   %1 28 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_PWRRST    Power interface reset
: RCC-APB1RSTR_USBRST   %1 23 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USBRST    USB reset
: RCC-APB1RSTR_I2C2RST   %1 22 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C2RST    I2C 2 reset
: RCC-APB1RSTR_I2C1RST   %1 21 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_I2C1RST    I2C 1 reset
: RCC-APB1RSTR_USART3RST   %1 18 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USART3RST    USART 3 reset
: RCC-APB1RSTR_USART2RST   %1 17 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_USART2RST    USART 2 reset
: RCC-APB1RSTR_SPI3RST   %1 15 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI3RST    SPI 3 reset
: RCC-APB1RSTR_SPI2RST   %1 14 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_SPI2RST    SPI 2 reset
: RCC-APB1RSTR_WWDRST   %1 11 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_WWDRST    Window watchdog reset
: RCC-APB1RSTR_LCDRST   %1 9 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_LCDRST    LCD reset
: RCC-APB1RSTR_TIM7RST   %1 5 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM7RST    Timer 7 reset
: RCC-APB1RSTR_TIM6RST   %1 4 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM6RST    Timer 6reset
: RCC-APB1RSTR_TIM5RST   %1 3 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM5RST    Timer 5 reset
: RCC-APB1RSTR_TIM4RST   %1 2 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM4RST    Timer 4 reset
: RCC-APB1RSTR_TIM3RST   %1 1 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM3RST    Timer 3 reset
: RCC-APB1RSTR_TIM2RST   %1 0 lshift RCC-APB1RSTR bis! ;  \ RCC-APB1RSTR_TIM2RST    Timer 2 reset

\ RCC-AHBENR (read-write)
: RCC-AHBENR_DMA2EN   %1 25 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_DMA2EN    DMA2 clock enable
: RCC-AHBENR_DMA1EN   %1 24 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_DMA1EN    DMA1 clock enable
: RCC-AHBENR_FLITFEN   %1 15 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_FLITFEN    FLITF clock enable
: RCC-AHBENR_CRCEN   %1 12 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_CRCEN    CRC clock enable
: RCC-AHBENR_GPIOPGEN   %1 7 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPGEN    IO port G clock enable
: RCC-AHBENR_GPIOPFEN   %1 6 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPFEN    IO port F clock enable
: RCC-AHBENR_GPIOPHEN   %1 5 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPHEN    IO port H clock enable
: RCC-AHBENR_GPIOPEEN   %1 4 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPEEN    IO port E clock enable
: RCC-AHBENR_GPIOPDEN   %1 3 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPDEN    IO port D clock enable
: RCC-AHBENR_GPIOPCEN   %1 2 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPCEN    IO port C clock enable
: RCC-AHBENR_GPIOPBEN   %1 1 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPBEN    IO port B clock enable
: RCC-AHBENR_GPIOPAEN   %1 0 lshift RCC-AHBENR bis! ;  \ RCC-AHBENR_GPIOPAEN    IO port A clock enable

\ RCC-APB2ENR (read-write)
: RCC-APB2ENR_USART1EN   %1 14 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_USART1EN    USART1 clock enable
: RCC-APB2ENR_SPI1EN   %1 12 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SPI1EN    SPI 1 clock enable
: RCC-APB2ENR_ADC1EN   %1 9 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_ADC1EN    ADC1 interface clock  enable
: RCC-APB2ENR_TIM11EN   %1 4 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM11EN    TIM11 timer clock enable
: RCC-APB2ENR_TIM10EN   %1 3 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM10EN    TIM10 timer clock enable
: RCC-APB2ENR_TIM9EN   %1 2 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_TIM9EN    TIM9 timer clock enable
: RCC-APB2ENR_SYSCFGEN   %1 0 lshift RCC-APB2ENR bis! ;  \ RCC-APB2ENR_SYSCFGEN    System configuration controller clock  enable

\ RCC-APB1ENR (read-write)
: RCC-APB1ENR_COMPEN   %1 31 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_COMPEN    COMP interface clock  enable
: RCC-APB1ENR_DACEN   %1 29 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_DACEN    DAC interface clock enable
: RCC-APB1ENR_PWREN   %1 28 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_PWREN    Power interface clock  enable
: RCC-APB1ENR_USBEN   %1 23 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USBEN    USB clock enable
: RCC-APB1ENR_I2C2EN   %1 22 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C2EN    I2C 2 clock enable
: RCC-APB1ENR_I2C1EN   %1 21 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_I2C1EN    I2C 1 clock enable
: RCC-APB1ENR_USART3EN   %1 18 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USART3EN    USART 3 clock enable
: RCC-APB1ENR_USART2EN   %1 17 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_USART2EN    USART 2 clock enable
: RCC-APB1ENR_SPI3EN   %1 15 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI3EN    SPI 3 clock enable
: RCC-APB1ENR_SPI2EN   %1 14 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_SPI2EN    SPI 2 clock enable
: RCC-APB1ENR_WWDGEN   %1 11 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_WWDGEN    Window watchdog clock  enable
: RCC-APB1ENR_LCDEN   %1 9 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_LCDEN    LCD clock enable
: RCC-APB1ENR_TIM7EN   %1 5 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM7EN    Timer 7 clock enable
: RCC-APB1ENR_TIM6EN   %1 4 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM6EN    Timer 6 clock enable
: RCC-APB1ENR_TIM5EN   %1 3 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM5EN    Timer 5 clock enable
: RCC-APB1ENR_TIM4EN   %1 2 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM4EN    Timer 4 clock enable
: RCC-APB1ENR_TIM3EN   %1 1 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM3EN    Timer 3 clock enable
: RCC-APB1ENR_TIM2EN   %1 0 lshift RCC-APB1ENR bis! ;  \ RCC-APB1ENR_TIM2EN    Timer 2 clock enable

\ RCC-AHBLPENR (read-write)
: RCC-AHBLPENR_DMA2LPEN   %1 25 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_DMA2LPEN    DMA2 clock enable during Sleep  mode
: RCC-AHBLPENR_DMA1LPEN   %1 24 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_DMA1LPEN    DMA1 clock enable during Sleep  mode
: RCC-AHBLPENR_SRAMLPEN   %1 16 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_SRAMLPEN    SRAM clock enable during Sleep  mode
: RCC-AHBLPENR_FLITFLPEN   %1 15 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_FLITFLPEN    FLITF clock enable during Sleep  mode
: RCC-AHBLPENR_CRCLPEN   %1 12 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_CRCLPEN    CRC clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOGLPEN   %1 7 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOGLPEN    IO port G clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOFLPEN   %1 6 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOFLPEN    IO port F clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOHLPEN   %1 5 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOHLPEN    IO port H clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOELPEN   %1 4 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOELPEN    IO port E clock enable during Sleep  mode
: RCC-AHBLPENR_GPIODLPEN   %1 3 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIODLPEN    IO port D clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOCLPEN   %1 2 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOCLPEN    IO port C clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOBLPEN   %1 1 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOBLPEN    IO port B clock enable during Sleep  mode
: RCC-AHBLPENR_GPIOALPEN   %1 0 lshift RCC-AHBLPENR bis! ;  \ RCC-AHBLPENR_GPIOALPEN    IO port A clock enable during Sleep  mode

\ RCC-APB2LPENR (read-write)
: RCC-APB2LPENR_USART1LPEN   %1 14 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_USART1LPEN    USART1 clock enable during Sleep  mode
: RCC-APB2LPENR_SPI1LPEN   %1 12 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SPI1LPEN    SPI 1 clock enable during Sleep  mode
: RCC-APB2LPENR_ADC1LPEN   %1 9 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_ADC1LPEN    ADC1 interface clock enable during Sleep  mode
: RCC-APB2LPENR_TIM11LPEN   %1 4 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM11LPEN    TIM11 timer clock enable during Sleep  mode
: RCC-APB2LPENR_TIM10LPEN   %1 3 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM10LPEN    TIM10 timer clock enable during Sleep  mode
: RCC-APB2LPENR_TIM9LPEN   %1 2 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_TIM9LPEN    TIM9 timer clock enable during Sleep  mode
: RCC-APB2LPENR_SYSCFGLPEN   %1 0 lshift RCC-APB2LPENR bis! ;  \ RCC-APB2LPENR_SYSCFGLPEN    System configuration controller clock  enable during Sleep mode

\ RCC-APB1LPENR (read-write)
: RCC-APB1LPENR_COMPLPEN   %1 31 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_COMPLPEN    COMP interface clock enable during Sleep  mode
: RCC-APB1LPENR_DACLPEN   %1 29 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_DACLPEN    DAC interface clock enable during Sleep  mode
: RCC-APB1LPENR_PWRLPEN   %1 28 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_PWRLPEN    Power interface clock enable during  Sleep mode
: RCC-APB1LPENR_USBLPEN   %1 23 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_USBLPEN    USB clock enable during Sleep  mode
: RCC-APB1LPENR_I2C2LPEN   %1 22 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_I2C2LPEN    I2C 2 clock enable during Sleep  mode
: RCC-APB1LPENR_I2C1LPEN   %1 21 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_I2C1LPEN    I2C 1 clock enable during Sleep  mode
: RCC-APB1LPENR_USART3LPEN   %1 18 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_USART3LPEN    USART 3 clock enable during Sleep  mode
: RCC-APB1LPENR_USART2LPEN   %1 17 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_USART2LPEN    USART 2 clock enable during Sleep  mode
: RCC-APB1LPENR_SPI2LPEN   %1 14 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_SPI2LPEN    SPI 2 clock enable during Sleep  mode
: RCC-APB1LPENR_WWDGLPEN   %1 11 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_WWDGLPEN    Window watchdog clock enable during  Sleep mode
: RCC-APB1LPENR_LCDLPEN   %1 9 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_LCDLPEN    LCD clock enable during Sleep  mode
: RCC-APB1LPENR_TIM7LPEN   %1 5 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM7LPEN    Timer 7 clock enable during Sleep  mode
: RCC-APB1LPENR_TIM6LPEN   %1 4 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM6LPEN    Timer 6 clock enable during Sleep  mode
: RCC-APB1LPENR_TIM4LPEN   %1 2 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM4LPEN    Timer 4 clock enable during Sleep  mode
: RCC-APB1LPENR_TIM3LPEN   %1 1 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM3LPEN    Timer 3 clock enable during Sleep  mode
: RCC-APB1LPENR_TIM2LPEN   %1 0 lshift RCC-APB1LPENR bis! ;  \ RCC-APB1LPENR_TIM2LPEN    Timer 2 clock enable during Sleep  mode

\ RCC-CSR ()
: RCC-CSR_LPWRSTF   %1 31 lshift RCC-CSR bis! ;  \ RCC-CSR_LPWRSTF    Low-power reset flag
: RCC-CSR_WWDGRSTF   %1 30 lshift RCC-CSR bis! ;  \ RCC-CSR_WWDGRSTF    Window watchdog reset flag
: RCC-CSR_IWDGRSTF   %1 29 lshift RCC-CSR bis! ;  \ RCC-CSR_IWDGRSTF    Independent watchdog reset  flag
: RCC-CSR_SFTRSTF   %1 28 lshift RCC-CSR bis! ;  \ RCC-CSR_SFTRSTF    Software reset flag
: RCC-CSR_PORRSTF   %1 27 lshift RCC-CSR bis! ;  \ RCC-CSR_PORRSTF    POR/PDR reset flag
: RCC-CSR_PINRSTF   %1 26 lshift RCC-CSR bis! ;  \ RCC-CSR_PINRSTF    PIN reset flag
: RCC-CSR_OBLRSTF   %1 25 lshift RCC-CSR bis! ;  \ RCC-CSR_OBLRSTF    Options bytes loading reset  flag
: RCC-CSR_RMVF   %1 24 lshift RCC-CSR bis! ;  \ RCC-CSR_RMVF    Remove reset flag
: RCC-CSR_RTCRST   %1 23 lshift RCC-CSR bis! ;  \ RCC-CSR_RTCRST    RTC software reset
: RCC-CSR_RTCEN   %1 22 lshift RCC-CSR bis! ;  \ RCC-CSR_RTCEN    RTC clock enable
: RCC-CSR_RTCSEL   ( %XX -- ) 16 lshift RCC-CSR bis! ;  \ RCC-CSR_RTCSEL    RTC and LCD clock source  selection
: RCC-CSR_LSECSSD   %1 12 lshift RCC-CSR bis! ;  \ RCC-CSR_LSECSSD    CSS on LSE failure  Detection
: RCC-CSR_LSECSSON   %1 11 lshift RCC-CSR bis! ;  \ RCC-CSR_LSECSSON    CSS on LSE enable
: RCC-CSR_LSEBYP   %1 10 lshift RCC-CSR bis! ;  \ RCC-CSR_LSEBYP    External low-speed oscillator  bypass
: RCC-CSR_LSERDY   %1 9 lshift RCC-CSR bis! ;  \ RCC-CSR_LSERDY    External low-speed oscillator  ready
: RCC-CSR_LSEON   %1 8 lshift RCC-CSR bis! ;  \ RCC-CSR_LSEON    External low-speed oscillator  enable
: RCC-CSR_LSIRDY   %1 1 lshift RCC-CSR bis! ;  \ RCC-CSR_LSIRDY    Internal low-speed oscillator  ready
: RCC-CSR_LSION   %1 0 lshift RCC-CSR bis! ;  \ RCC-CSR_LSION    Internal low-speed oscillator  enable

\ RI-ICR (read-write)
: RI-ICR_IC4   %1 21 lshift RI-ICR bis! ;  \ RI-ICR_IC4    IC4
: RI-ICR_IC3   %1 20 lshift RI-ICR bis! ;  \ RI-ICR_IC3    IC3
: RI-ICR_IC2   %1 19 lshift RI-ICR bis! ;  \ RI-ICR_IC2    IC2
: RI-ICR_IC1   %1 18 lshift RI-ICR bis! ;  \ RI-ICR_IC1    IC1
: RI-ICR_TIM   ( %XX -- ) 16 lshift RI-ICR bis! ;  \ RI-ICR_TIM    Timer select bits
: RI-ICR_IC4IOS   ( %XXXX -- ) 12 lshift RI-ICR bis! ;  \ RI-ICR_IC4IOS    Input capture 4 select  bits
: RI-ICR_IC3IOS   ( %XXXX -- ) 8 lshift RI-ICR bis! ;  \ RI-ICR_IC3IOS    Input capture 3 select  bits
: RI-ICR_IC2IOS   ( %XXXX -- ) 4 lshift RI-ICR bis! ;  \ RI-ICR_IC2IOS    Input capture 2 select  bits
: RI-ICR_IC1IOS   ( %XXXX -- ) 0 lshift RI-ICR bis! ;  \ RI-ICR_IC1IOS    Input capture 1 select  bits

\ RI-ASCR1 (read-write)
: RI-ASCR1_SCM   %1 31 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_SCM    Switch control mode
: RI-ASCR1_CH30GR11_4   %1 30 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH30GR11_4    Analog switch control
: RI-ASCR1_CH29GR11_3   %1 29 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH29GR11_3    Analog switch control
: RI-ASCR1_CH28GR11_2   %1 28 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH28GR11_2    Analog switch control
: RI-ASCR1_CH27GR11_1   %1 27 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH27GR11_1    Analog switch control
: RI-ASCR1_VCOMP   %1 26 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_VCOMP    ADC analog switch selection for internal  node to comparator 1
: RI-ASCR1_CH25   %1 25 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH25    Analog I/O switch control of channel  CH25
: RI-ASCR1_CH24   %1 24 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH24    Analog I/O switch control of channel  CH24
: RI-ASCR1_CH23   %1 23 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH23    Analog I/O switch control of channel  CH23
: RI-ASCR1_CH22   %1 22 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH22    Analog I/O switch control of channel  CH22
: RI-ASCR1_CH21GR7_4   %1 21 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH21GR7_4    Analog switch control
: RI-ASCR1_CH20GR7_3   %1 20 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH20GR7_3    Analog switch control
: RI-ASCR1_CH19GR7_2   %1 19 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH19GR7_2    Analog switch control
: RI-ASCR1_CH18GR7_1   %1 18 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH18GR7_1    Analog switch control
: RI-ASCR1_CH31GR7_1   %1 16 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH31GR7_1    Analog switch control
: RI-ASCR1_CH15GR9_2   %1 15 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH15GR9_2    Analog switch control
: RI-ASCR1_CH14GR9_1   %1 14 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH14GR9_1    Analog switch control
: RI-ASCR1_CH13GR8_4   %1 13 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH13GR8_4    Analog switch control
: RI-ASCR1_CH12GR8_3   %1 12 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH12GR8_3    Analog switch control
: RI-ASCR1_CH11GR8_2   %1 11 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH11GR8_2    Analog switch control
: RI-ASCR1_CH10GR8_1   %1 10 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH10GR8_1    Analog switch control
: RI-ASCR1_CH9GR3_2   %1 9 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH9GR3_2    Analog switch control
: RI-ASCR1_CH8GR3_1   %1 8 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH8GR3_1    Analog switch control
: RI-ASCR1_CH7GR2_2   %1 7 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH7GR2_2    Analog switch control
: RI-ASCR1_CH6GR2_1   %1 6 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH6GR2_1    Analog switch control
: RI-ASCR1_COMP1_SW1   %1 5 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_COMP1_SW1    Comparator 1 analog switch
: RI-ASCR1_CH31GR11_5   %1 4 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH31GR11_5    Analog switch control
: RI-ASCR1_CH3GR1_4   %1 3 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH3GR1_4    Analog switch control
: RI-ASCR1_CH2GR1_3   %1 2 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH2GR1_3    Analog switch control
: RI-ASCR1_CH1GR1_2   %1 1 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH1GR1_2    Analog switch control
: RI-ASCR1_CH0GR1_1   %1 0 lshift RI-ASCR1 bis! ;  \ RI-ASCR1_CH0GR1_1    Analog switch control

\ RI-ASCR2 (read-write)
: RI-ASCR2_GR5_4   %1 29 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR5_4    GR5_4 analog switch  control
: RI-ASCR2_GR6_4   %1 28 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR6_4    GR6_4 analog switch  control
: RI-ASCR2_GR6_3   %1 27 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR6_3    GR6_3 analog switch  control
: RI-ASCR2_GR7_7   %1 26 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR7_7    GR7_7 analog switch  control
: RI-ASCR2_GR7_6   %1 25 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR7_6    GR7_6 analog switch  control
: RI-ASCR2_GR7_5   %1 24 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR7_5    GR7_5 analog switch  control
: RI-ASCR2_GR2_5   %1 23 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR2_5    GR2_5 analog switch  control
: RI-ASCR2_GR2_4   %1 22 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR2_4    GR2_4 analog switch  control
: RI-ASCR2_GR2_3   %1 21 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR2_3    GR2_3 analog switch  control
: RI-ASCR2_GR9_4   %1 20 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR9_4    GR9_4 analog switch  control
: RI-ASCR2_GR9_3   %1 19 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR9_3    GR9_3 analog switch  control
: RI-ASCR2_GR3_5   %1 18 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR3_5    GR3_5 analog switch  control
: RI-ASCR2_GR3_4   %1 17 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR3_4    GR3_4 analog switch  control
: RI-ASCR2_GR3_3   %1 16 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR3_3    GR3_3 analog switch  control
: RI-ASCR2_GR4_3   %1 11 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR4_3    GR4_3 analog switch  control
: RI-ASCR2_GR4_2   %1 10 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR4_2    GR4_2 analog switch  control
: RI-ASCR2_GR4_1   %1 9 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR4_1    GR4_1 analog switch  control
: RI-ASCR2_GR5_3   %1 8 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR5_3    GR5_3 analog switch  control
: RI-ASCR2_GR5_2   %1 7 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR5_2    GR5_2 analog switch  control
: RI-ASCR2_GR5_1   %1 6 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR5_1    GR5_1 analog switch  control
: RI-ASCR2_GR6_2   %1 5 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR6_2    GR6_2 analog switch  control
: RI-ASCR2_GR6_1   %1 4 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR6_1    GR6_1 analog switch  control
: RI-ASCR2_GR10_4   %1 3 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR10_4    GR10_4 analog switch  control
: RI-ASCR2_GR10_3   %1 2 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR10_3    GR10_3 analog switch  control
: RI-ASCR2_GR10_2   %1 1 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR10_2    GR10_2 analog switch  control
: RI-ASCR2_GR10_1   %1 0 lshift RI-ASCR2 bis! ;  \ RI-ASCR2_GR10_1    GR10_1 analog switch  control

\ RI-HYSCR1 (read-write)
: RI-HYSCR1_PB   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift RI-HYSCR1 bis! ;  \ RI-HYSCR1_PB    Port B hysteresis control  on/off
: RI-HYSCR1_PA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-HYSCR1 bis! ;  \ RI-HYSCR1_PA    Port A hysteresis control  on/off

\ RI-HYSCR2 (read-write)
: RI-HYSCR2_PD   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift RI-HYSCR2 bis! ;  \ RI-HYSCR2_PD    Port D hysteresis control  on/off
: RI-HYSCR2_PC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-HYSCR2 bis! ;  \ RI-HYSCR2_PC    Port C hysteresis control  on/off

\ RI-HYSCR3 (read-write)
: RI-HYSCR3_PF   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift RI-HYSCR3 bis! ;  \ RI-HYSCR3_PF    Port F hysteresis control  on/off
: RI-HYSCR3_PE   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-HYSCR3 bis! ;  \ RI-HYSCR3_PE    Port E hysteresis control  on/off

\ RI-HYSCR4 (read-write)
: RI-HYSCR4_PG   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-HYSCR4 bis! ;  \ RI-HYSCR4_PG    Port G hysteresis control  on/off

\ RI-ASMR1 (read-write)
: RI-ASMR1_PA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-ASMR1 bis! ;  \ RI-ASMR1_PA    Port A analog switch mode  selection

\ RI-CMR1 (read-write)
: RI-CMR1_PA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CMR1 bis! ;  \ RI-CMR1_PA    Port A channel masking

\ RI-CICR1 (read-write)
: RI-CICR1_PA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CICR1 bis! ;  \ RI-CICR1_PA    Port A channel identification for  capture

\ RI-ASMR2 (read-write)
: RI-ASMR2_PB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-ASMR2 bis! ;  \ RI-ASMR2_PB    Port B analog switch mode  selection

\ RI-CMR2 (read-write)
: RI-CMR2_PB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CMR2 bis! ;  \ RI-CMR2_PB    Port B channel masking

\ RI-CICR2 (read-write)
: RI-CICR2_PB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CICR2 bis! ;  \ RI-CICR2_PB    Port B channel identification for  capture

\ RI-ASMR3 (read-write)
: RI-ASMR3_PC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-ASMR3 bis! ;  \ RI-ASMR3_PC    Port C analog switch mode  selection

\ RI-CMR3 (read-write)
: RI-CMR3_PC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CMR3 bis! ;  \ RI-CMR3_PC    Port C channel masking

\ RI-CICR3 (read-write)
: RI-CICR3_PC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CICR3 bis! ;  \ RI-CICR3_PC    Port C channel identification for  capture

\ RI-ASMR4 (read-write)
: RI-ASMR4_PF   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-ASMR4 bis! ;  \ RI-ASMR4_PF    Port F analog switch mode  selection

\ RI-CMR4 (read-write)
: RI-CMR4_PF   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CMR4 bis! ;  \ RI-CMR4_PF    Port F channel masking

\ RI-CICR4 (read-write)
: RI-CICR4_PF   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CICR4 bis! ;  \ RI-CICR4_PF    Port F channel identification for  capture

\ RI-ASMR5 (read-write)
: RI-ASMR5_PG   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-ASMR5 bis! ;  \ RI-ASMR5_PG    Port G analog switch mode  selection

\ RI-CMR5 (read-write)
: RI-CMR5_PG   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CMR5 bis! ;  \ RI-CMR5_PG    Port G channel masking

\ RI-CICR5 (read-write)
: RI-CICR5_PG   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RI-CICR5 bis! ;  \ RI-CICR5_PG    Port G channel identification for  capture

\ RTC-TR (read-write)
: RTC-TR_PM   %1 22 lshift RTC-TR bis! ;  \ RTC-TR_PM    AM/PM notation
: RTC-TR_HT   ( %XX -- ) 20 lshift RTC-TR bis! ;  \ RTC-TR_HT    Hour tens in BCD format
: RTC-TR_HU   ( %XXXX -- ) 16 lshift RTC-TR bis! ;  \ RTC-TR_HU    Hour units in BCD format
: RTC-TR_MNT   ( %XXX -- ) 12 lshift RTC-TR bis! ;  \ RTC-TR_MNT    Minute tens in BCD format
: RTC-TR_MNU   ( %XXXX -- ) 8 lshift RTC-TR bis! ;  \ RTC-TR_MNU    Minute units in BCD format
: RTC-TR_ST   ( %XXX -- ) 4 lshift RTC-TR bis! ;  \ RTC-TR_ST    Second tens in BCD format
: RTC-TR_SU   ( %XXXX -- ) 0 lshift RTC-TR bis! ;  \ RTC-TR_SU    Second units in BCD format

\ RTC-DR (read-write)
: RTC-DR_YT   ( %XXXX -- ) 20 lshift RTC-DR bis! ;  \ RTC-DR_YT    Year tens in BCD format
: RTC-DR_YU   ( %XXXX -- ) 16 lshift RTC-DR bis! ;  \ RTC-DR_YU    Year units in BCD format
: RTC-DR_WDU   ( %XXX -- ) 13 lshift RTC-DR bis! ;  \ RTC-DR_WDU    Week day units
: RTC-DR_MT   %1 12 lshift RTC-DR bis! ;  \ RTC-DR_MT    Month tens in BCD format
: RTC-DR_MU   ( %XXXX -- ) 8 lshift RTC-DR bis! ;  \ RTC-DR_MU    Month units in BCD format
: RTC-DR_DT   ( %XX -- ) 4 lshift RTC-DR bis! ;  \ RTC-DR_DT    Date tens in BCD format
: RTC-DR_DU   ( %XXXX -- ) 0 lshift RTC-DR bis! ;  \ RTC-DR_DU    Date units in BCD format

\ RTC-CR (read-write)
: RTC-CR_COE   %1 23 lshift RTC-CR bis! ;  \ RTC-CR_COE    Calibration output enable
: RTC-CR_OSEL   ( %XX -- ) 21 lshift RTC-CR bis! ;  \ RTC-CR_OSEL    Output selection
: RTC-CR_POL   %1 20 lshift RTC-CR bis! ;  \ RTC-CR_POL    Output polarity
: RTC-CR_COSEL   %1 19 lshift RTC-CR bis! ;  \ RTC-CR_COSEL    Calibration output  selection
: RTC-CR_BKP   %1 18 lshift RTC-CR bis! ;  \ RTC-CR_BKP    Backup
: RTC-CR_SUB1H   %1 17 lshift RTC-CR bis! ;  \ RTC-CR_SUB1H    Subtract 1 hour
: RTC-CR_ADD1H   %1 16 lshift RTC-CR bis! ;  \ RTC-CR_ADD1H    Add 1 hour
: RTC-CR_TSIE   %1 15 lshift RTC-CR bis! ;  \ RTC-CR_TSIE    Time-stamp interrupt  enable
: RTC-CR_WUTIE   %1 14 lshift RTC-CR bis! ;  \ RTC-CR_WUTIE    Wakeup timer interrupt  enable
: RTC-CR_ALRBIE   %1 13 lshift RTC-CR bis! ;  \ RTC-CR_ALRBIE    Alarm B interrupt enable
: RTC-CR_ALRAIE   %1 12 lshift RTC-CR bis! ;  \ RTC-CR_ALRAIE    Alarm A interrupt enable
: RTC-CR_TSE   %1 11 lshift RTC-CR bis! ;  \ RTC-CR_TSE    Time stamp enable
: RTC-CR_WUTE   %1 10 lshift RTC-CR bis! ;  \ RTC-CR_WUTE    Wakeup timer enable
: RTC-CR_ALRBE   %1 9 lshift RTC-CR bis! ;  \ RTC-CR_ALRBE    Alarm B enable
: RTC-CR_ALRAE   %1 8 lshift RTC-CR bis! ;  \ RTC-CR_ALRAE    Alarm A enable
: RTC-CR_DCE   %1 7 lshift RTC-CR bis! ;  \ RTC-CR_DCE    Coarse digital calibration  enable
: RTC-CR_FMT   %1 6 lshift RTC-CR bis! ;  \ RTC-CR_FMT    Hour format
: RTC-CR_BYPSHAD   %1 5 lshift RTC-CR bis! ;  \ RTC-CR_BYPSHAD    Bypass the shadow  registers
: RTC-CR_REFCKON   %1 4 lshift RTC-CR bis! ;  \ RTC-CR_REFCKON    Reference clock detection  enable
: RTC-CR_TSEDGE   %1 3 lshift RTC-CR bis! ;  \ RTC-CR_TSEDGE    Time-stamp event active  edge
: RTC-CR_WCKSEL   ( %XXX -- ) 0 lshift RTC-CR bis! ;  \ RTC-CR_WCKSEL    WCKSEL

\ RTC-ISR ()
: RTC-ISR_RECALPF   %1 16 lshift RTC-ISR bis! ;  \ RTC-ISR_RECALPF    Recalibration pending Flag
: RTC-ISR_TAMP3F   %1 15 lshift RTC-ISR bis! ;  \ RTC-ISR_TAMP3F    TAMPER3 detection flag
: RTC-ISR_TAMP2F   %1 14 lshift RTC-ISR bis! ;  \ RTC-ISR_TAMP2F    TAMPER2 detection flag
: RTC-ISR_TAMP1F   %1 13 lshift RTC-ISR bis! ;  \ RTC-ISR_TAMP1F    Tamper detection flag
: RTC-ISR_TSOVF   %1 12 lshift RTC-ISR bis! ;  \ RTC-ISR_TSOVF    Timestamp overflow flag
: RTC-ISR_TSF   %1 11 lshift RTC-ISR bis! ;  \ RTC-ISR_TSF    Timestamp flag
: RTC-ISR_WUTF   %1 10 lshift RTC-ISR bis! ;  \ RTC-ISR_WUTF    Wakeup timer flag
: RTC-ISR_ALRBF   %1 9 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRBF    Alarm B flag
: RTC-ISR_ALRAF   %1 8 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRAF    Alarm A flag
: RTC-ISR_INIT   %1 7 lshift RTC-ISR bis! ;  \ RTC-ISR_INIT    Initialization mode
: RTC-ISR_INITF   %1 6 lshift RTC-ISR bis! ;  \ RTC-ISR_INITF    Initialization flag
: RTC-ISR_RSF   %1 5 lshift RTC-ISR bis! ;  \ RTC-ISR_RSF    Registers synchronization  flag
: RTC-ISR_INITS   %1 4 lshift RTC-ISR bis! ;  \ RTC-ISR_INITS    Initialization status flag
: RTC-ISR_SHPF   %1 3 lshift RTC-ISR bis! ;  \ RTC-ISR_SHPF    Shift operation pending
: RTC-ISR_WUTWF   %1 2 lshift RTC-ISR bis! ;  \ RTC-ISR_WUTWF    Wakeup timer write flag
: RTC-ISR_ALRBWF   %1 1 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRBWF    Alarm B write flag
: RTC-ISR_ALRAWF   %1 0 lshift RTC-ISR bis! ;  \ RTC-ISR_ALRAWF    Alarm A write flag

\ RTC-PRER (read-write)
: RTC-PRER_PREDIV_A   ( %XXXXXXX -- ) 16 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_A    Asynchronous prescaler  factor
: RTC-PRER_PREDIV_S   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-PRER bis! ;  \ RTC-PRER_PREDIV_S    Synchronous prescaler  factor

\ RTC-WUTR (read-write)
: RTC-WUTR_WUT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-WUTR bis! ;  \ RTC-WUTR_WUT    Wakeup auto-reload value  bits

\ RTC-CALIBR (read-write)
: RTC-CALIBR_DCS   %1 7 lshift RTC-CALIBR bis! ;  \ RTC-CALIBR_DCS    Digital calibration sign
: RTC-CALIBR_DC   ( %XXXXX -- ) 0 lshift RTC-CALIBR bis! ;  \ RTC-CALIBR_DC    Digital calibration

\ RTC-ALRMAR (read-write)
: RTC-ALRMAR_MSK4   %1 31 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK4    Alarm A date mask
: RTC-ALRMAR_WDSEL   %1 30 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_WDSEL    Week day selection
: RTC-ALRMAR_DT   ( %XX -- ) 28 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DT    Date tens in BCD format.
: RTC-ALRMAR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_DU    Date units or day in BCD  format.
: RTC-ALRMAR_MSK3   %1 23 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK3    Alarm A hours mask
: RTC-ALRMAR_PM   %1 22 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_PM    AM/PM notation
: RTC-ALRMAR_HT   ( %XX -- ) 20 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HT    Hour tens in BCD format.
: RTC-ALRMAR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_HU    Hour units in BCD format.
: RTC-ALRMAR_MSK2   %1 15 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK2    Alarm A minutes mask
: RTC-ALRMAR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNT    Minute tens in BCD format.
: RTC-ALRMAR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MNU    Minute units in BCD  format.
: RTC-ALRMAR_MSK1   %1 7 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_MSK1    Alarm A seconds mask
: RTC-ALRMAR_ST   ( %XXX -- ) 4 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_ST    Second tens in BCD format.
: RTC-ALRMAR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMAR bis! ;  \ RTC-ALRMAR_SU    Second units in BCD  format.

\ RTC-ALRMBR (read-write)
: RTC-ALRMBR_MSK4   %1 31 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK4    Alarm B date mask
: RTC-ALRMBR_WDSEL   %1 30 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_WDSEL    Week day selection
: RTC-ALRMBR_DT   ( %XX -- ) 28 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DT    Date tens in BCD format
: RTC-ALRMBR_DU   ( %XXXX -- ) 24 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_DU    Date units or day in BCD  format
: RTC-ALRMBR_MSK3   %1 23 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK3    Alarm B hours mask
: RTC-ALRMBR_PM   %1 22 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_PM    AM/PM notation
: RTC-ALRMBR_HT   ( %XX -- ) 20 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HT    Hour tens in BCD format
: RTC-ALRMBR_HU   ( %XXXX -- ) 16 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_HU    Hour units in BCD format
: RTC-ALRMBR_MSK2   %1 15 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK2    Alarm B minutes mask
: RTC-ALRMBR_MNT   ( %XXX -- ) 12 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNT    Minute tens in BCD format
: RTC-ALRMBR_MNU   ( %XXXX -- ) 8 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MNU    Minute units in BCD format
: RTC-ALRMBR_MSK1   %1 7 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_MSK1    Alarm B seconds mask
: RTC-ALRMBR_ST   ( %XXX -- ) 4 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_ST    Second tens in BCD format
: RTC-ALRMBR_SU   ( %XXXX -- ) 0 lshift RTC-ALRMBR bis! ;  \ RTC-ALRMBR_SU    Second units in BCD format

\ RTC-WPR (write-only)
: RTC-WPR_KEY   ( %XXXXXXXX -- ) 0 lshift RTC-WPR bis! ;  \ RTC-WPR_KEY    Write protection key

\ RTC-SSR (read-only)
: RTC-SSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-SSR bis! ;  \ RTC-SSR_SS    Sub second value

\ RTC-SHIFTR (write-only)
: RTC-SHIFTR_ADD1S   %1 31 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_ADD1S    ADD1S
: RTC-SHIFTR_SUBFS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-SHIFTR bis! ;  \ RTC-SHIFTR_SUBFS    Subtract a fraction of a  second

\ RTC-TSTR (read-only)
: RTC-TSTR_PM   %1 22 lshift RTC-TSTR bis! ;  \ RTC-TSTR_PM    AM/PM notation
: RTC-TSTR_HT   ( %XX -- ) 20 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HT    Hour tens in BCD format.
: RTC-TSTR_HU   ( %XXXX -- ) 16 lshift RTC-TSTR bis! ;  \ RTC-TSTR_HU    Hour units in BCD format.
: RTC-TSTR_MNT   ( %XXX -- ) 12 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNT    Minute tens in BCD format.
: RTC-TSTR_MNU   ( %XXXX -- ) 8 lshift RTC-TSTR bis! ;  \ RTC-TSTR_MNU    Minute units in BCD  format.
: RTC-TSTR_ST   ( %XXX -- ) 4 lshift RTC-TSTR bis! ;  \ RTC-TSTR_ST    Second tens in BCD format.
: RTC-TSTR_SU   ( %XXXX -- ) 0 lshift RTC-TSTR bis! ;  \ RTC-TSTR_SU    Second units in BCD  format.

\ RTC-TSDR (read-only)
: RTC-TSDR_WDU   ( %XXX -- ) 13 lshift RTC-TSDR bis! ;  \ RTC-TSDR_WDU    Week day units
: RTC-TSDR_MT   %1 12 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MT    Month tens in BCD format
: RTC-TSDR_MU   ( %XXXX -- ) 8 lshift RTC-TSDR bis! ;  \ RTC-TSDR_MU    Month units in BCD format
: RTC-TSDR_DT   ( %XX -- ) 4 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DT    Date tens in BCD format
: RTC-TSDR_DU   ( %XXXX -- ) 0 lshift RTC-TSDR bis! ;  \ RTC-TSDR_DU    Date units in BCD format

\ RTC-TSSSR (read-only)
: RTC-TSSSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC-TSSSR bis! ;  \ RTC-TSSSR_SS    Sub second value

\ RTC-CALR (read-write)
: RTC-CALR_CALP   %1 15 lshift RTC-CALR bis! ;  \ RTC-CALR_CALP    Use an 8-second calibration cycle  period
: RTC-CALR_CALW8   %1 14 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW8    Use a 16-second calibration cycle  period
: RTC-CALR_CALW16   %1 13 lshift RTC-CALR bis! ;  \ RTC-CALR_CALW16    CALW16
: RTC-CALR_CALM   ( %XXXXXXXXX -- ) 0 lshift RTC-CALR bis! ;  \ RTC-CALR_CALM    Calibration minus

\ RTC-TAFCR (read-write)
: RTC-TAFCR_ALARMOUTTYPE   %1 18 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_ALARMOUTTYPE    AFO_ALARM output type
: RTC-TAFCR_TAMPPUDIS   %1 15 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPPUDIS    TAMPER pull-up disable
: RTC-TAFCR_TAMPPRCH   ( %XX -- ) 13 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPPRCH    Tamper precharge duration
: RTC-TAFCR_TAMPFLT   ( %XX -- ) 11 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPFLT    Tamper filter count
: RTC-TAFCR_TAMPFREQ   ( %XXX -- ) 8 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPFREQ    Tamper sampling frequency
: RTC-TAFCR_TAMPTS   %1 7 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPTS    Activate timestamp on tamper detection  event
: RTC-TAFCR_TAMP3TRG   %1 6 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP3TRG    TAMPER1 mapping
: RTC-TAFCR_TAMP3E   %1 5 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP3E    TIMESTAMP mapping
: RTC-TAFCR_TAMP2TRG   %1 4 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP2TRG    Active level for tamper 2
: RTC-TAFCR_TAMP2E   %1 3 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP2E    Tamper 2 detection enable
: RTC-TAFCR_TAMPIE   %1 2 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMPIE    Tamper interrupt enable
: RTC-TAFCR_TAMP1ETRG   %1 1 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP1ETRG    Active level for tamper 1
: RTC-TAFCR_TAMP1E   %1 0 lshift RTC-TAFCR bis! ;  \ RTC-TAFCR_TAMP1E    Tamper 1 detection enable

\ RTC-ALRMASSR (read-write)
: RTC-ALRMASSR_MASKSS   ( %XXXX -- ) 24 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_MASKSS    Mask the most-significant bits starting  at this bit
: RTC-ALRMASSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMASSR bis! ;  \ RTC-ALRMASSR_SS    Sub seconds value

\ RTC-ALRMBSSR (read-write)
: RTC-ALRMBSSR_MASKSS   ( %XXXX -- ) 24 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_MASKSS    Mask the most-significant bits starting  at this bit
: RTC-ALRMBSSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC-ALRMBSSR bis! ;  \ RTC-ALRMBSSR_SS    Sub seconds value

\ RTC-BKP0R (read-write)
: RTC-BKP0R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP0R bis! ;  \ RTC-BKP0R_BKP    BKP

\ RTC-BKP1R (read-write)
: RTC-BKP1R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP1R bis! ;  \ RTC-BKP1R_BKP    BKP

\ RTC-BKP2R (read-write)
: RTC-BKP2R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP2R bis! ;  \ RTC-BKP2R_BKP    BKP

\ RTC-BKP3R (read-write)
: RTC-BKP3R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP3R bis! ;  \ RTC-BKP3R_BKP    BKP

\ RTC-BKP4R (read-write)
: RTC-BKP4R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP4R bis! ;  \ RTC-BKP4R_BKP    BKP

\ RTC-BKP5R (read-write)
: RTC-BKP5R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP5R bis! ;  \ RTC-BKP5R_BKP    BKP

\ RTC-BKP6R (read-write)
: RTC-BKP6R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP6R bis! ;  \ RTC-BKP6R_BKP    BKP

\ RTC-BKP7R (read-write)
: RTC-BKP7R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP7R bis! ;  \ RTC-BKP7R_BKP    BKP

\ RTC-BKP8R (read-write)
: RTC-BKP8R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP8R bis! ;  \ RTC-BKP8R_BKP    BKP

\ RTC-BKP9R (read-write)
: RTC-BKP9R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP9R bis! ;  \ RTC-BKP9R_BKP    BKP

\ RTC-BKP10R (read-write)
: RTC-BKP10R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP10R bis! ;  \ RTC-BKP10R_BKP    BKP

\ RTC-BKP11R (read-write)
: RTC-BKP11R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP11R bis! ;  \ RTC-BKP11R_BKP    BKP

\ RTC-BKP12R (read-write)
: RTC-BKP12R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP12R bis! ;  \ RTC-BKP12R_BKP    BKP

\ RTC-BKP13R (read-write)
: RTC-BKP13R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP13R bis! ;  \ RTC-BKP13R_BKP    BKP

\ RTC-BKP14R (read-write)
: RTC-BKP14R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP14R bis! ;  \ RTC-BKP14R_BKP    BKP

\ RTC-BKP15R (read-write)
: RTC-BKP15R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP15R bis! ;  \ RTC-BKP15R_BKP    BKP

\ RTC-BKP16R (read-write)
: RTC-BKP16R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP16R bis! ;  \ RTC-BKP16R_BKP    BKP

\ RTC-BKP17R (read-write)
: RTC-BKP17R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP17R bis! ;  \ RTC-BKP17R_BKP    BKP

\ RTC-BKP18R (read-write)
: RTC-BKP18R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP18R bis! ;  \ RTC-BKP18R_BKP    BKP

\ RTC-BKP19R (read-write)
: RTC-BKP19R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP19R bis! ;  \ RTC-BKP19R_BKP    BKP

\ RTC-BKP20R (read-write)
: RTC-BKP20R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP20R bis! ;  \ RTC-BKP20R_BKP    BKP

\ RTC-BKP21R (read-write)
: RTC-BKP21R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP21R bis! ;  \ RTC-BKP21R_BKP    BKP

\ RTC-BKP22R (read-write)
: RTC-BKP22R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP22R bis! ;  \ RTC-BKP22R_BKP    BKP

\ RTC-BKP23R (read-write)
: RTC-BKP23R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP23R bis! ;  \ RTC-BKP23R_BKP    BKP

\ RTC-BKP24R (read-write)
: RTC-BKP24R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP24R bis! ;  \ RTC-BKP24R_BKP    BKP

\ RTC-BKP25R (read-write)
: RTC-BKP25R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP25R bis! ;  \ RTC-BKP25R_BKP    BKP

\ RTC-BKP26R (read-write)
: RTC-BKP26R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP26R bis! ;  \ RTC-BKP26R_BKP    BKP

\ RTC-BKP27R (read-write)
: RTC-BKP27R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP27R bis! ;  \ RTC-BKP27R_BKP    BKP

\ RTC-BKP28R (read-write)
: RTC-BKP28R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP28R bis! ;  \ RTC-BKP28R_BKP    BKP

\ RTC-BKP29R (read-write)
: RTC-BKP29R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP29R bis! ;  \ RTC-BKP29R_BKP    BKP

\ RTC-BKP30R (read-write)
: RTC-BKP30R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP30R bis! ;  \ RTC-BKP30R_BKP    BKP

\ RTC-BKP31R (read-write)
: RTC-BKP31R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC-BKP31R bis! ;  \ RTC-BKP31R_BKP    BKP

\ SPI1-CR1 (read-write)
: SPI1-CR1_BIDIMODE   %1 15 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI1-CR1_BIDIOE   %1 14 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI1-CR1_CRCEN   %1 13 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCEN    Hardware CRC calculation  enable
: SPI1-CR1_CRCNEXT   %1 12 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CRCNEXT    CRC transfer next
: SPI1-CR1_DFF   %1 11 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_DFF    Data frame format
: SPI1-CR1_RXONLY   %1 10 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_RXONLY    Receive only
: SPI1-CR1_SSM   %1 9 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSM    Software slave management
: SPI1-CR1_SSI   %1 8 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SSI    Internal slave select
: SPI1-CR1_LSBFIRST   %1 7 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_LSBFIRST    Frame format
: SPI1-CR1_SPE   %1 6 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_SPE    SPI enable
: SPI1-CR1_BR   ( %XXX -- ) 3 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_BR    Baud rate control
: SPI1-CR1_MSTR   %1 2 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_MSTR    Master selection
: SPI1-CR1_CPOL   %1 1 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPOL    Clock polarity
: SPI1-CR1_CPHA   %1 0 lshift SPI1-CR1 bis! ;  \ SPI1-CR1_CPHA    Clock phase

\ SPI1-CR2 (read-write)
: SPI1-CR2_TXEIE   %1 7 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI1-CR2_RXNEIE   %1 6 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI1-CR2_ERRIE   %1 5 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_ERRIE    Error interrupt enable
: SPI1-CR2_FRF   %1 4 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_FRF    Frame format
: SPI1-CR2_SSOE   %1 2 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_SSOE    SS output enable
: SPI1-CR2_TXDMAEN   %1 1 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_TXDMAEN    Tx buffer DMA enable
: SPI1-CR2_RXDMAEN   %1 0 lshift SPI1-CR2 bis! ;  \ SPI1-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI1-SR ()
: SPI1-SR_TIFRFE   %1 8 lshift SPI1-SR bis! ;  \ SPI1-SR_TIFRFE    TI frame format error
: SPI1-SR_BSY   %1 7 lshift SPI1-SR bis! ;  \ SPI1-SR_BSY    Busy flag
: SPI1-SR_OVR   %1 6 lshift SPI1-SR bis! ;  \ SPI1-SR_OVR    Overrun flag
: SPI1-SR_MODF   %1 5 lshift SPI1-SR bis! ;  \ SPI1-SR_MODF    Mode fault
: SPI1-SR_CRCERR   %1 4 lshift SPI1-SR bis! ;  \ SPI1-SR_CRCERR    CRC error flag
: SPI1-SR_UDR   %1 3 lshift SPI1-SR bis! ;  \ SPI1-SR_UDR    Underrun flag
: SPI1-SR_CHSIDE   %1 2 lshift SPI1-SR bis! ;  \ SPI1-SR_CHSIDE    Channel side
: SPI1-SR_TXE   %1 1 lshift SPI1-SR bis! ;  \ SPI1-SR_TXE    Transmit buffer empty
: SPI1-SR_RXNE   %1 0 lshift SPI1-SR bis! ;  \ SPI1-SR_RXNE    Receive buffer not empty

\ SPI1-DR (read-write)
: SPI1-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-DR bis! ;  \ SPI1-DR_DR    Data register

\ SPI1-CRCPR (read-write)
: SPI1-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-CRCPR bis! ;  \ SPI1-CRCPR_CRCPOLY    CRC polynomial register

\ SPI1-RXCRCR (read-only)
: SPI1-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-RXCRCR bis! ;  \ SPI1-RXCRCR_RxCRC    Rx CRC register

\ SPI1-TXCRCR (read-only)
: SPI1-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1-TXCRCR bis! ;  \ SPI1-TXCRCR_TxCRC    Tx CRC register

\ SPI1-I2SCFGR (read-write)
: SPI1-I2SCFGR_I2SMOD   %1 11 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SMOD    I2S mode selection
: SPI1-I2SCFGR_I2SE   %1 10 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SE    I2S Enable
: SPI1-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SCFG    I2S configuration mode
: SPI1-I2SCFGR_PCMSYNC   %1 7 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI1-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_I2SSTD    I2S standard selection
: SPI1-I2SCFGR_CKPOL   %1 3 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI1-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_DATLEN    Data length to be  transferred
: SPI1-I2SCFGR_CHLEN   %1 0 lshift SPI1-I2SCFGR bis! ;  \ SPI1-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI1-I2SPR (read-write)
: SPI1-I2SPR_MCKOE   %1 9 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_MCKOE    Master clock output enable
: SPI1-I2SPR_ODD   %1 8 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_ODD    Odd factor for the  prescaler
: SPI1-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI1-I2SPR bis! ;  \ SPI1-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI2-CR1 (read-write)
: SPI2-CR1_BIDIMODE   %1 15 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI2-CR1_BIDIOE   %1 14 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI2-CR1_CRCEN   %1 13 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCEN    Hardware CRC calculation  enable
: SPI2-CR1_CRCNEXT   %1 12 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CRCNEXT    CRC transfer next
: SPI2-CR1_DFF   %1 11 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_DFF    Data frame format
: SPI2-CR1_RXONLY   %1 10 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_RXONLY    Receive only
: SPI2-CR1_SSM   %1 9 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSM    Software slave management
: SPI2-CR1_SSI   %1 8 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SSI    Internal slave select
: SPI2-CR1_LSBFIRST   %1 7 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_LSBFIRST    Frame format
: SPI2-CR1_SPE   %1 6 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_SPE    SPI enable
: SPI2-CR1_BR   ( %XXX -- ) 3 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_BR    Baud rate control
: SPI2-CR1_MSTR   %1 2 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_MSTR    Master selection
: SPI2-CR1_CPOL   %1 1 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPOL    Clock polarity
: SPI2-CR1_CPHA   %1 0 lshift SPI2-CR1 bis! ;  \ SPI2-CR1_CPHA    Clock phase

\ SPI2-CR2 (read-write)
: SPI2-CR2_TXEIE   %1 7 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI2-CR2_RXNEIE   %1 6 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI2-CR2_ERRIE   %1 5 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_ERRIE    Error interrupt enable
: SPI2-CR2_FRF   %1 4 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_FRF    Frame format
: SPI2-CR2_SSOE   %1 2 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_SSOE    SS output enable
: SPI2-CR2_TXDMAEN   %1 1 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_TXDMAEN    Tx buffer DMA enable
: SPI2-CR2_RXDMAEN   %1 0 lshift SPI2-CR2 bis! ;  \ SPI2-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI2-SR ()
: SPI2-SR_TIFRFE   %1 8 lshift SPI2-SR bis! ;  \ SPI2-SR_TIFRFE    TI frame format error
: SPI2-SR_BSY   %1 7 lshift SPI2-SR bis! ;  \ SPI2-SR_BSY    Busy flag
: SPI2-SR_OVR   %1 6 lshift SPI2-SR bis! ;  \ SPI2-SR_OVR    Overrun flag
: SPI2-SR_MODF   %1 5 lshift SPI2-SR bis! ;  \ SPI2-SR_MODF    Mode fault
: SPI2-SR_CRCERR   %1 4 lshift SPI2-SR bis! ;  \ SPI2-SR_CRCERR    CRC error flag
: SPI2-SR_UDR   %1 3 lshift SPI2-SR bis! ;  \ SPI2-SR_UDR    Underrun flag
: SPI2-SR_CHSIDE   %1 2 lshift SPI2-SR bis! ;  \ SPI2-SR_CHSIDE    Channel side
: SPI2-SR_TXE   %1 1 lshift SPI2-SR bis! ;  \ SPI2-SR_TXE    Transmit buffer empty
: SPI2-SR_RXNE   %1 0 lshift SPI2-SR bis! ;  \ SPI2-SR_RXNE    Receive buffer not empty

\ SPI2-DR (read-write)
: SPI2-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-DR bis! ;  \ SPI2-DR_DR    Data register

\ SPI2-CRCPR (read-write)
: SPI2-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-CRCPR bis! ;  \ SPI2-CRCPR_CRCPOLY    CRC polynomial register

\ SPI2-RXCRCR (read-only)
: SPI2-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-RXCRCR bis! ;  \ SPI2-RXCRCR_RxCRC    Rx CRC register

\ SPI2-TXCRCR (read-only)
: SPI2-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2-TXCRCR bis! ;  \ SPI2-TXCRCR_TxCRC    Tx CRC register

\ SPI2-I2SCFGR (read-write)
: SPI2-I2SCFGR_I2SMOD   %1 11 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SMOD    I2S mode selection
: SPI2-I2SCFGR_I2SE   %1 10 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SE    I2S Enable
: SPI2-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SCFG    I2S configuration mode
: SPI2-I2SCFGR_PCMSYNC   %1 7 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI2-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_I2SSTD    I2S standard selection
: SPI2-I2SCFGR_CKPOL   %1 3 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI2-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_DATLEN    Data length to be  transferred
: SPI2-I2SCFGR_CHLEN   %1 0 lshift SPI2-I2SCFGR bis! ;  \ SPI2-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI2-I2SPR (read-write)
: SPI2-I2SPR_MCKOE   %1 9 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_MCKOE    Master clock output enable
: SPI2-I2SPR_ODD   %1 8 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_ODD    Odd factor for the  prescaler
: SPI2-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI2-I2SPR bis! ;  \ SPI2-I2SPR_I2SDIV    I2S Linear prescaler

\ SPI3-CR1 (read-write)
: SPI3-CR1_BIDIMODE   %1 15 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIMODE    Bidirectional data mode  enable
: SPI3-CR1_BIDIOE   %1 14 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BIDIOE    Output enable in bidirectional  mode
: SPI3-CR1_CRCEN   %1 13 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCEN    Hardware CRC calculation  enable
: SPI3-CR1_CRCNEXT   %1 12 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CRCNEXT    CRC transfer next
: SPI3-CR1_DFF   %1 11 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_DFF    Data frame format
: SPI3-CR1_RXONLY   %1 10 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_RXONLY    Receive only
: SPI3-CR1_SSM   %1 9 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSM    Software slave management
: SPI3-CR1_SSI   %1 8 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SSI    Internal slave select
: SPI3-CR1_LSBFIRST   %1 7 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_LSBFIRST    Frame format
: SPI3-CR1_SPE   %1 6 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_SPE    SPI enable
: SPI3-CR1_BR   ( %XXX -- ) 3 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_BR    Baud rate control
: SPI3-CR1_MSTR   %1 2 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_MSTR    Master selection
: SPI3-CR1_CPOL   %1 1 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPOL    Clock polarity
: SPI3-CR1_CPHA   %1 0 lshift SPI3-CR1 bis! ;  \ SPI3-CR1_CPHA    Clock phase

\ SPI3-CR2 (read-write)
: SPI3-CR2_TXEIE   %1 7 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI3-CR2_RXNEIE   %1 6 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI3-CR2_ERRIE   %1 5 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_ERRIE    Error interrupt enable
: SPI3-CR2_FRF   %1 4 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_FRF    Frame format
: SPI3-CR2_SSOE   %1 2 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_SSOE    SS output enable
: SPI3-CR2_TXDMAEN   %1 1 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_TXDMAEN    Tx buffer DMA enable
: SPI3-CR2_RXDMAEN   %1 0 lshift SPI3-CR2 bis! ;  \ SPI3-CR2_RXDMAEN    Rx buffer DMA enable

\ SPI3-SR ()
: SPI3-SR_TIFRFE   %1 8 lshift SPI3-SR bis! ;  \ SPI3-SR_TIFRFE    TI frame format error
: SPI3-SR_BSY   %1 7 lshift SPI3-SR bis! ;  \ SPI3-SR_BSY    Busy flag
: SPI3-SR_OVR   %1 6 lshift SPI3-SR bis! ;  \ SPI3-SR_OVR    Overrun flag
: SPI3-SR_MODF   %1 5 lshift SPI3-SR bis! ;  \ SPI3-SR_MODF    Mode fault
: SPI3-SR_CRCERR   %1 4 lshift SPI3-SR bis! ;  \ SPI3-SR_CRCERR    CRC error flag
: SPI3-SR_UDR   %1 3 lshift SPI3-SR bis! ;  \ SPI3-SR_UDR    Underrun flag
: SPI3-SR_CHSIDE   %1 2 lshift SPI3-SR bis! ;  \ SPI3-SR_CHSIDE    Channel side
: SPI3-SR_TXE   %1 1 lshift SPI3-SR bis! ;  \ SPI3-SR_TXE    Transmit buffer empty
: SPI3-SR_RXNE   %1 0 lshift SPI3-SR bis! ;  \ SPI3-SR_RXNE    Receive buffer not empty

\ SPI3-DR (read-write)
: SPI3-DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-DR bis! ;  \ SPI3-DR_DR    Data register

\ SPI3-CRCPR (read-write)
: SPI3-CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-CRCPR bis! ;  \ SPI3-CRCPR_CRCPOLY    CRC polynomial register

\ SPI3-RXCRCR (read-only)
: SPI3-RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-RXCRCR bis! ;  \ SPI3-RXCRCR_RxCRC    Rx CRC register

\ SPI3-TXCRCR (read-only)
: SPI3-TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI3-TXCRCR bis! ;  \ SPI3-TXCRCR_TxCRC    Tx CRC register

\ SPI3-I2SCFGR (read-write)
: SPI3-I2SCFGR_I2SMOD   %1 11 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SMOD    I2S mode selection
: SPI3-I2SCFGR_I2SE   %1 10 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SE    I2S Enable
: SPI3-I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SCFG    I2S configuration mode
: SPI3-I2SCFGR_PCMSYNC   %1 7 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI3-I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_I2SSTD    I2S standard selection
: SPI3-I2SCFGR_CKPOL   %1 3 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CKPOL    Steady state clock  polarity
: SPI3-I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_DATLEN    Data length to be  transferred
: SPI3-I2SCFGR_CHLEN   %1 0 lshift SPI3-I2SCFGR bis! ;  \ SPI3-I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI3-I2SPR (read-write)
: SPI3-I2SPR_MCKOE   %1 9 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_MCKOE    Master clock output enable
: SPI3-I2SPR_ODD   %1 8 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_ODD    Odd factor for the  prescaler
: SPI3-I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI3-I2SPR bis! ;  \ SPI3-I2SPR_I2SDIV    I2S Linear prescaler

\ SYSCFG-MEMRMP ()
: SYSCFG-MEMRMP_MEM_MODE   ( %XX -- ) 0 lshift SYSCFG-MEMRMP bis! ;  \ SYSCFG-MEMRMP_MEM_MODE    MEM_MODE
: SYSCFG-MEMRMP_BOOT_MODE   ( %XX -- ) 8 lshift SYSCFG-MEMRMP bis! ;  \ SYSCFG-MEMRMP_BOOT_MODE    BOOT_MODE

\ SYSCFG-PMC (read-write)
: SYSCFG-PMC_USB_PU   %1 0 lshift SYSCFG-PMC bis! ;  \ SYSCFG-PMC_USB_PU    USB pull-up

\ SYSCFG-EXTICR1 (read-write)
: SYSCFG-EXTICR1_EXTI3   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI3    EXTI x configuration x = 0 to  3
: SYSCFG-EXTICR1_EXTI2   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI2    EXTI x configuration x = 0 to  3
: SYSCFG-EXTICR1_EXTI1   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI1    EXTI x configuration x = 0 to  3
: SYSCFG-EXTICR1_EXTI0   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR1 bis! ;  \ SYSCFG-EXTICR1_EXTI0    EXTI x configuration x = 0 to  3

\ SYSCFG-EXTICR2 (read-write)
: SYSCFG-EXTICR2_EXTI7   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI7    EXTI x configuration x = 4 to  7
: SYSCFG-EXTICR2_EXTI6   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI6    EXTI x configuration x = 4 to  7
: SYSCFG-EXTICR2_EXTI5   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI5    EXTI x configuration x = 4 to  7
: SYSCFG-EXTICR2_EXTI4   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR2 bis! ;  \ SYSCFG-EXTICR2_EXTI4    EXTI x configuration x = 4 to  7

\ SYSCFG-EXTICR3 (read-write)
: SYSCFG-EXTICR3_EXTI11   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI11    EXTI x configuration x = 8 to  11
: SYSCFG-EXTICR3_EXTI10   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI10    EXTI10
: SYSCFG-EXTICR3_EXTI9   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI9    EXTI x configuration x = 8 to  11
: SYSCFG-EXTICR3_EXTI8   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR3 bis! ;  \ SYSCFG-EXTICR3_EXTI8    EXTI x configuration x = 8 to  11

\ SYSCFG-EXTICR4 (read-write)
: SYSCFG-EXTICR4_EXTI15   ( %XXXX -- ) 12 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI15    EXTI x configuration x = 12 to  15
: SYSCFG-EXTICR4_EXTI14   ( %XXXX -- ) 8 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI14    EXTI14
: SYSCFG-EXTICR4_EXTI13   ( %XXXX -- ) 4 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI13    EXTI13
: SYSCFG-EXTICR4_EXTI12   ( %XXXX -- ) 0 lshift SYSCFG-EXTICR4 bis! ;  \ SYSCFG-EXTICR4_EXTI12    EXTI12

\ TIM10-CR1 (read-write)
: TIM10-CR1_CKD   ( %XX -- ) 8 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CKD    Clock division
: TIM10-CR1_ARPE   %1 7 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_ARPE    Auto-reload preload enable
: TIM10-CR1_URS   %1 2 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_URS    Update request source
: TIM10-CR1_UDIS   %1 1 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_UDIS    Update disable
: TIM10-CR1_CEN   %1 0 lshift TIM10-CR1 bis! ;  \ TIM10-CR1_CEN    Counter enable

\ TIM10-DIER (write-only)
: TIM10-DIER_CC1IE   %1 1 lshift TIM10-DIER bis! ;  \ TIM10-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM10-DIER_UIE   %1 0 lshift TIM10-DIER bis! ;  \ TIM10-DIER_UIE    Update interrupt enable

\ TIM10-SR (read-write)
: TIM10-SR_CC1OF   %1 9 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM10-SR_CC1IF   %1 1 lshift TIM10-SR bis! ;  \ TIM10-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM10-SR_UIF   %1 0 lshift TIM10-SR bis! ;  \ TIM10-SR_UIF    Update interrupt flag

\ TIM10-EGR (read-write)
: TIM10-EGR_CC1G   %1 1 lshift TIM10-EGR bis! ;  \ TIM10-EGR_CC1G    Capture/Compare 1  generation
: TIM10-EGR_UG   %1 0 lshift TIM10-EGR bis! ;  \ TIM10-EGR_UG    Update generation

\ TIM10-CCMR1_Output (read-write)
: TIM10-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1M    Output compare 1 mode
: TIM10-CCMR1_Output_OC1PE   %1 3 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM10-CCMR1_Output_OC1FE   %1 2 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM10-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Output bis! ;  \ TIM10-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM10-CCMR1_Input (read-write)
: TIM10-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_IC1F    Input capture 1 filter
: TIM10-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM10-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM10-CCMR1_Input bis! ;  \ TIM10-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM10-CCER (read-write)
: TIM10-CCER_CC1NP   %1 3 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM10-CCER_CC1P   %1 1 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM10-CCER_CC1E   %1 0 lshift TIM10-CCER bis! ;  \ TIM10-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM10-CNT (read-write)
: TIM10-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CNT bis! ;  \ TIM10-CNT_CNT    TIM10 counter

\ TIM10-PSC (read-write)
: TIM10-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-PSC bis! ;  \ TIM10-PSC_PSC    TIM9 prescaler

\ TIM10-ARR (read-write)
: TIM10-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-ARR bis! ;  \ TIM10-ARR_ARR    Auto-reload value

\ TIM10-CCR1 (read-write)
: TIM10-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM10-CCR1 bis! ;  \ TIM10-CCR1_CCR1    Capture/Compare 1 value

\ TIM10-OR (read-write)
: TIM10-OR_TI1_RMP   ( %XX -- ) 0 lshift TIM10-OR bis! ;  \ TIM10-OR_TI1_RMP    TIM11 Input 1 remapping  capability

\ TIM11-CR1 (read-write)
: TIM11-CR1_CKD   ( %XX -- ) 8 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CKD    Clock division
: TIM11-CR1_ARPE   %1 7 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_ARPE    Auto-reload preload enable
: TIM11-CR1_URS   %1 2 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_URS    Update request source
: TIM11-CR1_UDIS   %1 1 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_UDIS    Update disable
: TIM11-CR1_CEN   %1 0 lshift TIM11-CR1 bis! ;  \ TIM11-CR1_CEN    Counter enable

\ TIM11-DIER (write-only)
: TIM11-DIER_CC1IE   %1 1 lshift TIM11-DIER bis! ;  \ TIM11-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM11-DIER_UIE   %1 0 lshift TIM11-DIER bis! ;  \ TIM11-DIER_UIE    Update interrupt enable

\ TIM11-SR (read-write)
: TIM11-SR_CC1OF   %1 9 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM11-SR_CC1IF   %1 1 lshift TIM11-SR bis! ;  \ TIM11-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM11-SR_UIF   %1 0 lshift TIM11-SR bis! ;  \ TIM11-SR_UIF    Update interrupt flag

\ TIM11-EGR (read-write)
: TIM11-EGR_CC1G   %1 1 lshift TIM11-EGR bis! ;  \ TIM11-EGR_CC1G    Capture/Compare 1  generation
: TIM11-EGR_UG   %1 0 lshift TIM11-EGR bis! ;  \ TIM11-EGR_UG    Update generation

\ TIM11-CCMR1_Output (read-write)
: TIM11-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1M    Output compare 1 mode
: TIM11-CCMR1_Output_OC1PE   %1 3 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM11-CCMR1_Output_OC1FE   %1 2 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM11-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Output bis! ;  \ TIM11-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM11-CCMR1_Input (read-write)
: TIM11-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_IC1F    Input capture 1 filter
: TIM11-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM11-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM11-CCMR1_Input bis! ;  \ TIM11-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM11-CCER (read-write)
: TIM11-CCER_CC1NP   %1 3 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM11-CCER_CC1P   %1 1 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM11-CCER_CC1E   %1 0 lshift TIM11-CCER bis! ;  \ TIM11-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM11-CNT (read-write)
: TIM11-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CNT bis! ;  \ TIM11-CNT_CNT    TIM10 counter

\ TIM11-PSC (read-write)
: TIM11-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-PSC bis! ;  \ TIM11-PSC_PSC    TIM9 prescaler

\ TIM11-ARR (read-write)
: TIM11-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-ARR bis! ;  \ TIM11-ARR_ARR    Auto-reload value

\ TIM11-CCR1 (read-write)
: TIM11-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM11-CCR1 bis! ;  \ TIM11-CCR1_CCR1    Capture/Compare 1 value

\ TIM11-OR (read-write)
: TIM11-OR_TI1_RMP   ( %XX -- ) 0 lshift TIM11-OR bis! ;  \ TIM11-OR_TI1_RMP    TIM11 Input 1 remapping  capability

\ TIM2-CR1 (read-write)
: TIM2-CR1_CKD   ( %XX -- ) 8 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CKD    Clock division
: TIM2-CR1_ARPE   %1 7 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_ARPE    Auto-reload preload enable
: TIM2-CR1_CMS   ( %XX -- ) 5 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CMS    Center-aligned mode  selection
: TIM2-CR1_DIR   %1 4 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_DIR    Direction
: TIM2-CR1_OPM   %1 3 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_OPM    One-pulse mode
: TIM2-CR1_URS   %1 2 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_URS    Update request source
: TIM2-CR1_UDIS   %1 1 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_UDIS    Update disable
: TIM2-CR1_CEN   %1 0 lshift TIM2-CR1 bis! ;  \ TIM2-CR1_CEN    Counter enable

\ TIM2-CR2 (read-write)
: TIM2-CR2_TI1S   %1 7 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_TI1S    TI1 selection
: TIM2-CR2_MMS   ( %XXX -- ) 4 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_MMS    Master mode selection
: TIM2-CR2_CCDS   %1 3 lshift TIM2-CR2 bis! ;  \ TIM2-CR2_CCDS    Capture/compare DMA  selection

\ TIM2-SMCR (read-write)
: TIM2-SMCR_ETP   %1 15 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETP    External trigger polarity
: TIM2-SMCR_ECE   %1 14 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ECE    External clock enable
: TIM2-SMCR_ETPS   ( %XX -- ) 12 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETPS    External trigger prescaler
: TIM2-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_ETF    External trigger filter
: TIM2-SMCR_MSM   %1 7 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_MSM    Master/Slave mode
: TIM2-SMCR_TS   ( %XXX -- ) 4 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_TS    Trigger selection
: TIM2-SMCR_OCCS   %1 3 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_OCCS    OCREF clear selection
: TIM2-SMCR_SMS   ( %XXX -- ) 0 lshift TIM2-SMCR bis! ;  \ TIM2-SMCR_SMS    Slave mode selection

\ TIM2-DIER (write-only)
: TIM2-DIER_TDE   %1 14 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TDE    Trigger DMA request enable
: TIM2-DIER_CC4DE   %1 12 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM2-DIER_CC3DE   %1 11 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM2-DIER_CC2DE   %1 10 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM2-DIER_CC1DE   %1 9 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM2-DIER_UDE   %1 8 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UDE    Update DMA request enable
: TIM2-DIER_TIE   %1 6 lshift TIM2-DIER bis! ;  \ TIM2-DIER_TIE    Trigger interrupt enable
: TIM2-DIER_CC4IE   %1 4 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM2-DIER_CC3IE   %1 3 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM2-DIER_CC2IE   %1 2 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM2-DIER_CC1IE   %1 1 lshift TIM2-DIER bis! ;  \ TIM2-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM2-DIER_UIE   %1 0 lshift TIM2-DIER bis! ;  \ TIM2-DIER_UIE    Update interrupt enable

\ TIM2-SR (read-write)
: TIM2-SR_CC4OF   %1 12 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4OF    Capture/compare 1 overcapture  flag
: TIM2-SR_CC3OF   %1 11 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3OF    Capture/compare 3 overcapture  flag
: TIM2-SR_CC2OF   %1 10 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM2-SR_CC1OF   %1 9 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM2-SR_TIF   %1 6 lshift TIM2-SR bis! ;  \ TIM2-SR_TIF    Trigger interrupt flag
: TIM2-SR_CC4IF   %1 4 lshift TIM2-SR bis! ;  \ TIM2-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM2-SR_CC3IF   %1 3 lshift TIM2-SR bis! ;  \ TIM2-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM2-SR_CC2IF   %1 2 lshift TIM2-SR bis! ;  \ TIM2-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM2-SR_CC1IF   %1 1 lshift TIM2-SR bis! ;  \ TIM2-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM2-SR_UIF   %1 0 lshift TIM2-SR bis! ;  \ TIM2-SR_UIF    Update interrupt flag

\ TIM2-EGR (read-write)
: TIM2-EGR_TG   %1 6 lshift TIM2-EGR bis! ;  \ TIM2-EGR_TG    Trigger generation
: TIM2-EGR_CC4G   %1 4 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC4G    Capture/compare 4  generation
: TIM2-EGR_CC3G   %1 3 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC3G    Capture/compare 3  generation
: TIM2-EGR_CC2G   %1 2 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC2G    Capture/compare 2  generation
: TIM2-EGR_CC1G   %1 1 lshift TIM2-EGR bis! ;  \ TIM2-EGR_CC1G    Capture/compare 1  generation
: TIM2-EGR_UG   %1 0 lshift TIM2-EGR bis! ;  \ TIM2-EGR_UG    Update generation

\ TIM2-CCMR1_Output (read-write)
: TIM2-CCMR1_Output_OC2CE   %1 15 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM2-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2M    Output compare 2 mode
: TIM2-CCMR1_Output_OC2PE   %1 11 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM2-CCMR1_Output_OC2FE   %1 10 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM2-CCMR1_Output_CC2S   %1 8 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM2-CCMR1_Output_OC1CE   %1 7 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM2-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1M    Output compare 1 mode
: TIM2-CCMR1_Output_OC1PE   %1 3 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM2-CCMR1_Output_OC1FE   %1 2 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM2-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Output bis! ;  \ TIM2-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM2-CCMR1_Input (read-write)
: TIM2-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2F    Input capture 2 filter
: TIM2-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM2-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM2-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_IC1F    Input capture 1 filter
: TIM2-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM2-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM2-CCMR1_Input bis! ;  \ TIM2-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM2-CCMR2_Output (read-write)
: TIM2-CCMR2_Output_OC4CE   %1 15 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM2-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4M    Output compare 4 mode
: TIM2-CCMR2_Output_OC4PE   %1 11 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM2-CCMR2_Output_OC4FE   %1 10 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM2-CCMR2_Output_CC4S   %1 8 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM2-CCMR2_Output_OC3CE   %1 7 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM2-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3M    Output compare 3 mode
: TIM2-CCMR2_Output_OC3PE   %1 3 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM2-CCMR2_Output_OC3FE   %1 2 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM2-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Output bis! ;  \ TIM2-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM2-CCMR2_Input (read-write)
: TIM2-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4F    Input capture 4 filter
: TIM2-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM2-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM2-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3F    Input capture 3 filter
: TIM2-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM2-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM2-CCMR2_Input bis! ;  \ TIM2-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM2-CCER (read-write)
: TIM2-CCER_CC4NP   %1 15 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4NP    Capture/Compare 4 output  Polarity
: TIM2-CCER_CC4P   %1 13 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4P    Capture/Compare 4 output  Polarity
: TIM2-CCER_CC4E   %1 12 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC4E    Capture/Compare 4 output  enable
: TIM2-CCER_CC3NP   %1 11 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM2-CCER_CC3P   %1 9 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM2-CCER_CC3E   %1 8 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC3E    Capture/Compare 3 output  enable
: TIM2-CCER_CC2NP   %1 7 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM2-CCER_CC2P   %1 5 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM2-CCER_CC2E   %1 4 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC2E    Capture/Compare 2 output  enable
: TIM2-CCER_CC1NP   %1 3 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM2-CCER_CC1P   %1 1 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM2-CCER_CC1E   %1 0 lshift TIM2-CCER bis! ;  \ TIM2-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM2-CNT (read-write)
: TIM2-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CNT bis! ;  \ TIM2-CNT_CNT    TIM2 counter

\ TIM2-PSC (read-write)
: TIM2-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-PSC bis! ;  \ TIM2-PSC_PSC    TIM2 prescaler

\ TIM2-ARR (read-write)
: TIM2-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-ARR bis! ;  \ TIM2-ARR_ARR    Auto-reload value

\ TIM2-CCR1 (read-write)
: TIM2-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR1 bis! ;  \ TIM2-CCR1_CCR1    Capture/Compare 1 value

\ TIM2-CCR2 (read-write)
: TIM2-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR2 bis! ;  \ TIM2-CCR2_CCR2    Capture/Compare 2 value

\ TIM2-CCR3 (read-write)
: TIM2-CCR3_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR3 bis! ;  \ TIM2-CCR3_CCR1    Capture/Compare 1 value

\ TIM2-CCR4 (read-write)
: TIM2-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-CCR4 bis! ;  \ TIM2-CCR4_CCR4    Capture/Compare 4 value

\ TIM2-DCR (read-write)
: TIM2-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBL    DMA burst length
: TIM2-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM2-DCR bis! ;  \ TIM2-DCR_DBA    DMA base address

\ TIM2-DMAR (read-write)
: TIM2-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM2-DMAR bis! ;  \ TIM2-DMAR_DMAB    DMA register for burst  accesses

\ TIM3-CR1 (read-write)
: TIM3-CR1_CKD   ( %XX -- ) 8 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CKD    Clock division
: TIM3-CR1_ARPE   %1 7 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_ARPE    Auto-reload preload enable
: TIM3-CR1_CMS   ( %XX -- ) 5 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CMS    Center-aligned mode  selection
: TIM3-CR1_DIR   %1 4 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_DIR    Direction
: TIM3-CR1_OPM   %1 3 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_OPM    One-pulse mode
: TIM3-CR1_URS   %1 2 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_URS    Update request source
: TIM3-CR1_UDIS   %1 1 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_UDIS    Update disable
: TIM3-CR1_CEN   %1 0 lshift TIM3-CR1 bis! ;  \ TIM3-CR1_CEN    Counter enable

\ TIM3-CR2 (read-write)
: TIM3-CR2_TI1S   %1 7 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_TI1S    TI1 selection
: TIM3-CR2_MMS   ( %XXX -- ) 4 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_MMS    Master mode selection
: TIM3-CR2_CCDS   %1 3 lshift TIM3-CR2 bis! ;  \ TIM3-CR2_CCDS    Capture/compare DMA  selection

\ TIM3-SMCR (read-write)
: TIM3-SMCR_ETP   %1 15 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETP    External trigger polarity
: TIM3-SMCR_ECE   %1 14 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ECE    External clock enable
: TIM3-SMCR_ETPS   ( %XX -- ) 12 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETPS    External trigger prescaler
: TIM3-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_ETF    External trigger filter
: TIM3-SMCR_MSM   %1 7 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_MSM    Master/Slave mode
: TIM3-SMCR_TS   ( %XXX -- ) 4 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_TS    Trigger selection
: TIM3-SMCR_OCCS   %1 3 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_OCCS    OCREF clear selection
: TIM3-SMCR_SMS   ( %XXX -- ) 0 lshift TIM3-SMCR bis! ;  \ TIM3-SMCR_SMS    Slave mode selection

\ TIM3-DIER (write-only)
: TIM3-DIER_TDE   %1 14 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TDE    Trigger DMA request enable
: TIM3-DIER_CC4DE   %1 12 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM3-DIER_CC3DE   %1 11 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM3-DIER_CC2DE   %1 10 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM3-DIER_CC1DE   %1 9 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM3-DIER_UDE   %1 8 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UDE    Update DMA request enable
: TIM3-DIER_TIE   %1 6 lshift TIM3-DIER bis! ;  \ TIM3-DIER_TIE    Trigger interrupt enable
: TIM3-DIER_CC4IE   %1 4 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM3-DIER_CC3IE   %1 3 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM3-DIER_CC2IE   %1 2 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM3-DIER_CC1IE   %1 1 lshift TIM3-DIER bis! ;  \ TIM3-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM3-DIER_UIE   %1 0 lshift TIM3-DIER bis! ;  \ TIM3-DIER_UIE    Update interrupt enable

\ TIM3-SR (read-write)
: TIM3-SR_CC4OF   %1 12 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4OF    Capture/compare 1 overcapture  flag
: TIM3-SR_CC3OF   %1 11 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3OF    Capture/compare 3 overcapture  flag
: TIM3-SR_CC2OF   %1 10 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM3-SR_CC1OF   %1 9 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM3-SR_TIF   %1 6 lshift TIM3-SR bis! ;  \ TIM3-SR_TIF    Trigger interrupt flag
: TIM3-SR_CC4IF   %1 4 lshift TIM3-SR bis! ;  \ TIM3-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM3-SR_CC3IF   %1 3 lshift TIM3-SR bis! ;  \ TIM3-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM3-SR_CC2IF   %1 2 lshift TIM3-SR bis! ;  \ TIM3-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM3-SR_CC1IF   %1 1 lshift TIM3-SR bis! ;  \ TIM3-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM3-SR_UIF   %1 0 lshift TIM3-SR bis! ;  \ TIM3-SR_UIF    Update interrupt flag

\ TIM3-EGR (read-write)
: TIM3-EGR_TG   %1 6 lshift TIM3-EGR bis! ;  \ TIM3-EGR_TG    Trigger generation
: TIM3-EGR_CC4G   %1 4 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC4G    Capture/compare 4  generation
: TIM3-EGR_CC3G   %1 3 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC3G    Capture/compare 3  generation
: TIM3-EGR_CC2G   %1 2 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC2G    Capture/compare 2  generation
: TIM3-EGR_CC1G   %1 1 lshift TIM3-EGR bis! ;  \ TIM3-EGR_CC1G    Capture/compare 1  generation
: TIM3-EGR_UG   %1 0 lshift TIM3-EGR bis! ;  \ TIM3-EGR_UG    Update generation

\ TIM3-CCMR1_Output (read-write)
: TIM3-CCMR1_Output_OC2CE   %1 15 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM3-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2M    Output compare 2 mode
: TIM3-CCMR1_Output_OC2PE   %1 11 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM3-CCMR1_Output_OC2FE   %1 10 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM3-CCMR1_Output_CC2S   %1 8 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM3-CCMR1_Output_OC1CE   %1 7 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM3-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1M    Output compare 1 mode
: TIM3-CCMR1_Output_OC1PE   %1 3 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM3-CCMR1_Output_OC1FE   %1 2 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM3-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Output bis! ;  \ TIM3-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM3-CCMR1_Input (read-write)
: TIM3-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2F    Input capture 2 filter
: TIM3-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM3-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM3-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_IC1F    Input capture 1 filter
: TIM3-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM3-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM3-CCMR1_Input bis! ;  \ TIM3-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM3-CCMR2_Output (read-write)
: TIM3-CCMR2_Output_OC4CE   %1 15 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM3-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4M    Output compare 4 mode
: TIM3-CCMR2_Output_OC4PE   %1 11 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM3-CCMR2_Output_OC4FE   %1 10 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM3-CCMR2_Output_CC4S   %1 8 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM3-CCMR2_Output_OC3CE   %1 7 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM3-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3M    Output compare 3 mode
: TIM3-CCMR2_Output_OC3PE   %1 3 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM3-CCMR2_Output_OC3FE   %1 2 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM3-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Output bis! ;  \ TIM3-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM3-CCMR2_Input (read-write)
: TIM3-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4F    Input capture 4 filter
: TIM3-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM3-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM3-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3F    Input capture 3 filter
: TIM3-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM3-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM3-CCMR2_Input bis! ;  \ TIM3-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM3-CCER (read-write)
: TIM3-CCER_CC4NP   %1 15 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4NP    Capture/Compare 4 output  Polarity
: TIM3-CCER_CC4P   %1 13 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4P    Capture/Compare 4 output  Polarity
: TIM3-CCER_CC4E   %1 12 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC4E    Capture/Compare 4 output  enable
: TIM3-CCER_CC3NP   %1 11 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM3-CCER_CC3P   %1 9 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM3-CCER_CC3E   %1 8 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC3E    Capture/Compare 3 output  enable
: TIM3-CCER_CC2NP   %1 7 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM3-CCER_CC2P   %1 5 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM3-CCER_CC2E   %1 4 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC2E    Capture/Compare 2 output  enable
: TIM3-CCER_CC1NP   %1 3 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM3-CCER_CC1P   %1 1 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM3-CCER_CC1E   %1 0 lshift TIM3-CCER bis! ;  \ TIM3-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM3-CNT (read-write)
: TIM3-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CNT bis! ;  \ TIM3-CNT_CNT    TIM2 counter

\ TIM3-PSC (read-write)
: TIM3-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-PSC bis! ;  \ TIM3-PSC_PSC    TIM2 prescaler

\ TIM3-ARR (read-write)
: TIM3-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-ARR bis! ;  \ TIM3-ARR_ARR    Auto-reload value

\ TIM3-CCR1 (read-write)
: TIM3-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR1 bis! ;  \ TIM3-CCR1_CCR1    Capture/Compare 1 value

\ TIM3-CCR2 (read-write)
: TIM3-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR2 bis! ;  \ TIM3-CCR2_CCR2    Capture/Compare 2 value

\ TIM3-CCR3 (read-write)
: TIM3-CCR3_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR3 bis! ;  \ TIM3-CCR3_CCR1    Capture/Compare 1 value

\ TIM3-CCR4 (read-write)
: TIM3-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-CCR4 bis! ;  \ TIM3-CCR4_CCR4    Capture/Compare 4 value

\ TIM3-DCR (read-write)
: TIM3-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBL    DMA burst length
: TIM3-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM3-DCR bis! ;  \ TIM3-DCR_DBA    DMA base address

\ TIM3-DMAR (read-write)
: TIM3-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3-DMAR bis! ;  \ TIM3-DMAR_DMAB    DMA register for burst  accesses

\ TIM4-CR1 (read-write)
: TIM4-CR1_CKD   ( %XX -- ) 8 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CKD    Clock division
: TIM4-CR1_ARPE   %1 7 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_ARPE    Auto-reload preload enable
: TIM4-CR1_CMS   ( %XX -- ) 5 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CMS    Center-aligned mode  selection
: TIM4-CR1_DIR   %1 4 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_DIR    Direction
: TIM4-CR1_OPM   %1 3 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_OPM    One-pulse mode
: TIM4-CR1_URS   %1 2 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_URS    Update request source
: TIM4-CR1_UDIS   %1 1 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_UDIS    Update disable
: TIM4-CR1_CEN   %1 0 lshift TIM4-CR1 bis! ;  \ TIM4-CR1_CEN    Counter enable

\ TIM4-CR2 (read-write)
: TIM4-CR2_TI1S   %1 7 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_TI1S    TI1 selection
: TIM4-CR2_MMS   ( %XXX -- ) 4 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_MMS    Master mode selection
: TIM4-CR2_CCDS   %1 3 lshift TIM4-CR2 bis! ;  \ TIM4-CR2_CCDS    Capture/compare DMA  selection

\ TIM4-SMCR (read-write)
: TIM4-SMCR_ETP   %1 15 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETP    External trigger polarity
: TIM4-SMCR_ECE   %1 14 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ECE    External clock enable
: TIM4-SMCR_ETPS   ( %XX -- ) 12 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETPS    External trigger prescaler
: TIM4-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_ETF    External trigger filter
: TIM4-SMCR_MSM   %1 7 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_MSM    Master/Slave mode
: TIM4-SMCR_TS   ( %XXX -- ) 4 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_TS    Trigger selection
: TIM4-SMCR_OCCS   %1 3 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_OCCS    OCREF clear selection
: TIM4-SMCR_SMS   ( %XXX -- ) 0 lshift TIM4-SMCR bis! ;  \ TIM4-SMCR_SMS    Slave mode selection

\ TIM4-DIER (write-only)
: TIM4-DIER_TDE   %1 14 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TDE    Trigger DMA request enable
: TIM4-DIER_CC4DE   %1 12 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM4-DIER_CC3DE   %1 11 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM4-DIER_CC2DE   %1 10 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM4-DIER_CC1DE   %1 9 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM4-DIER_UDE   %1 8 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UDE    Update DMA request enable
: TIM4-DIER_TIE   %1 6 lshift TIM4-DIER bis! ;  \ TIM4-DIER_TIE    Trigger interrupt enable
: TIM4-DIER_CC4IE   %1 4 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM4-DIER_CC3IE   %1 3 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM4-DIER_CC2IE   %1 2 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM4-DIER_CC1IE   %1 1 lshift TIM4-DIER bis! ;  \ TIM4-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM4-DIER_UIE   %1 0 lshift TIM4-DIER bis! ;  \ TIM4-DIER_UIE    Update interrupt enable

\ TIM4-SR (read-write)
: TIM4-SR_CC4OF   %1 12 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4OF    Capture/compare 1 overcapture  flag
: TIM4-SR_CC3OF   %1 11 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3OF    Capture/compare 3 overcapture  flag
: TIM4-SR_CC2OF   %1 10 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM4-SR_CC1OF   %1 9 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM4-SR_TIF   %1 6 lshift TIM4-SR bis! ;  \ TIM4-SR_TIF    Trigger interrupt flag
: TIM4-SR_CC4IF   %1 4 lshift TIM4-SR bis! ;  \ TIM4-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM4-SR_CC3IF   %1 3 lshift TIM4-SR bis! ;  \ TIM4-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM4-SR_CC2IF   %1 2 lshift TIM4-SR bis! ;  \ TIM4-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM4-SR_CC1IF   %1 1 lshift TIM4-SR bis! ;  \ TIM4-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM4-SR_UIF   %1 0 lshift TIM4-SR bis! ;  \ TIM4-SR_UIF    Update interrupt flag

\ TIM4-EGR (read-write)
: TIM4-EGR_TG   %1 6 lshift TIM4-EGR bis! ;  \ TIM4-EGR_TG    Trigger generation
: TIM4-EGR_CC4G   %1 4 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC4G    Capture/compare 4  generation
: TIM4-EGR_CC3G   %1 3 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC3G    Capture/compare 3  generation
: TIM4-EGR_CC2G   %1 2 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC2G    Capture/compare 2  generation
: TIM4-EGR_CC1G   %1 1 lshift TIM4-EGR bis! ;  \ TIM4-EGR_CC1G    Capture/compare 1  generation
: TIM4-EGR_UG   %1 0 lshift TIM4-EGR bis! ;  \ TIM4-EGR_UG    Update generation

\ TIM4-CCMR1_Output (read-write)
: TIM4-CCMR1_Output_OC2CE   %1 15 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM4-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2M    Output compare 2 mode
: TIM4-CCMR1_Output_OC2PE   %1 11 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM4-CCMR1_Output_OC2FE   %1 10 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM4-CCMR1_Output_CC2S   %1 8 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM4-CCMR1_Output_OC1CE   %1 7 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM4-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1M    Output compare 1 mode
: TIM4-CCMR1_Output_OC1PE   %1 3 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM4-CCMR1_Output_OC1FE   %1 2 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM4-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Output bis! ;  \ TIM4-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM4-CCMR1_Input (read-write)
: TIM4-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2F    Input capture 2 filter
: TIM4-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM4-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM4-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_IC1F    Input capture 1 filter
: TIM4-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM4-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM4-CCMR1_Input bis! ;  \ TIM4-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM4-CCMR2_Output (read-write)
: TIM4-CCMR2_Output_OC4CE   %1 15 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM4-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4M    Output compare 4 mode
: TIM4-CCMR2_Output_OC4PE   %1 11 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM4-CCMR2_Output_OC4FE   %1 10 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM4-CCMR2_Output_CC4S   %1 8 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM4-CCMR2_Output_OC3CE   %1 7 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM4-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3M    Output compare 3 mode
: TIM4-CCMR2_Output_OC3PE   %1 3 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM4-CCMR2_Output_OC3FE   %1 2 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM4-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Output bis! ;  \ TIM4-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM4-CCMR2_Input (read-write)
: TIM4-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4F    Input capture 4 filter
: TIM4-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM4-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM4-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3F    Input capture 3 filter
: TIM4-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM4-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM4-CCMR2_Input bis! ;  \ TIM4-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM4-CCER (read-write)
: TIM4-CCER_CC4NP   %1 15 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4NP    Capture/Compare 4 output  Polarity
: TIM4-CCER_CC4P   %1 13 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4P    Capture/Compare 4 output  Polarity
: TIM4-CCER_CC4E   %1 12 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC4E    Capture/Compare 4 output  enable
: TIM4-CCER_CC3NP   %1 11 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM4-CCER_CC3P   %1 9 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM4-CCER_CC3E   %1 8 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC3E    Capture/Compare 3 output  enable
: TIM4-CCER_CC2NP   %1 7 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM4-CCER_CC2P   %1 5 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM4-CCER_CC2E   %1 4 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC2E    Capture/Compare 2 output  enable
: TIM4-CCER_CC1NP   %1 3 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM4-CCER_CC1P   %1 1 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM4-CCER_CC1E   %1 0 lshift TIM4-CCER bis! ;  \ TIM4-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM4-CNT (read-write)
: TIM4-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CNT bis! ;  \ TIM4-CNT_CNT    TIM2 counter

\ TIM4-PSC (read-write)
: TIM4-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-PSC bis! ;  \ TIM4-PSC_PSC    TIM2 prescaler

\ TIM4-ARR (read-write)
: TIM4-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-ARR bis! ;  \ TIM4-ARR_ARR    Auto-reload value

\ TIM4-CCR1 (read-write)
: TIM4-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR1 bis! ;  \ TIM4-CCR1_CCR1    Capture/Compare 1 value

\ TIM4-CCR2 (read-write)
: TIM4-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR2 bis! ;  \ TIM4-CCR2_CCR2    Capture/Compare 2 value

\ TIM4-CCR3 (read-write)
: TIM4-CCR3_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR3 bis! ;  \ TIM4-CCR3_CCR1    Capture/Compare 1 value

\ TIM4-CCR4 (read-write)
: TIM4-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-CCR4 bis! ;  \ TIM4-CCR4_CCR4    Capture/Compare 4 value

\ TIM4-DCR (read-write)
: TIM4-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBL    DMA burst length
: TIM4-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM4-DCR bis! ;  \ TIM4-DCR_DBA    DMA base address

\ TIM4-DMAR (read-write)
: TIM4-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM4-DMAR bis! ;  \ TIM4-DMAR_DMAB    DMA register for burst  accesses

\ TIM5-CR1 (read-write)
: TIM5-CR1_CKD   ( %XX -- ) 8 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CKD    Clock division
: TIM5-CR1_ARPE   %1 7 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_ARPE    Auto-reload preload enable
: TIM5-CR1_CMS   ( %XX -- ) 5 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CMS    Center-aligned mode  selection
: TIM5-CR1_DIR   %1 4 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_DIR    Direction
: TIM5-CR1_OPM   %1 3 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_OPM    One-pulse mode
: TIM5-CR1_URS   %1 2 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_URS    Update request source
: TIM5-CR1_UDIS   %1 1 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_UDIS    Update disable
: TIM5-CR1_CEN   %1 0 lshift TIM5-CR1 bis! ;  \ TIM5-CR1_CEN    Counter enable

\ TIM5-CR2 (read-write)
: TIM5-CR2_TI1S   %1 7 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_TI1S    TI1 selection
: TIM5-CR2_MMS   ( %XXX -- ) 4 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_MMS    Master mode selection
: TIM5-CR2_CCDS   %1 3 lshift TIM5-CR2 bis! ;  \ TIM5-CR2_CCDS    Capture/compare DMA  selection

\ TIM5-SMCR (read-write)
: TIM5-SMCR_ETP   %1 15 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETP    External trigger polarity
: TIM5-SMCR_ECE   %1 14 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ECE    External clock enable
: TIM5-SMCR_ETPS   ( %XX -- ) 12 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETPS    External trigger prescaler
: TIM5-SMCR_ETF   ( %XXXX -- ) 8 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_ETF    External trigger filter
: TIM5-SMCR_MSM   %1 7 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_MSM    Master/Slave mode
: TIM5-SMCR_TS   ( %XXX -- ) 4 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_TS    Trigger selection
: TIM5-SMCR_OCCS   %1 3 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_OCCS    OCREF clear selection
: TIM5-SMCR_SMS   ( %XXX -- ) 0 lshift TIM5-SMCR bis! ;  \ TIM5-SMCR_SMS    Slave mode selection

\ TIM5-DIER (write-only)
: TIM5-DIER_TDE   %1 14 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TDE    Trigger DMA request enable
: TIM5-DIER_CC4DE   %1 12 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM5-DIER_CC3DE   %1 11 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM5-DIER_CC2DE   %1 10 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM5-DIER_CC1DE   %1 9 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM5-DIER_UDE   %1 8 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UDE    Update DMA request enable
: TIM5-DIER_TIE   %1 6 lshift TIM5-DIER bis! ;  \ TIM5-DIER_TIE    Trigger interrupt enable
: TIM5-DIER_CC4IE   %1 4 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM5-DIER_CC3IE   %1 3 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM5-DIER_CC2IE   %1 2 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM5-DIER_CC1IE   %1 1 lshift TIM5-DIER bis! ;  \ TIM5-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM5-DIER_UIE   %1 0 lshift TIM5-DIER bis! ;  \ TIM5-DIER_UIE    Update interrupt enable

\ TIM5-SR (read-write)
: TIM5-SR_CC4OF   %1 12 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4OF    Capture/compare 1 overcapture  flag
: TIM5-SR_CC3OF   %1 11 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3OF    Capture/compare 3 overcapture  flag
: TIM5-SR_CC2OF   %1 10 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM5-SR_CC1OF   %1 9 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM5-SR_TIF   %1 6 lshift TIM5-SR bis! ;  \ TIM5-SR_TIF    Trigger interrupt flag
: TIM5-SR_CC4IF   %1 4 lshift TIM5-SR bis! ;  \ TIM5-SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM5-SR_CC3IF   %1 3 lshift TIM5-SR bis! ;  \ TIM5-SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM5-SR_CC2IF   %1 2 lshift TIM5-SR bis! ;  \ TIM5-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM5-SR_CC1IF   %1 1 lshift TIM5-SR bis! ;  \ TIM5-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM5-SR_UIF   %1 0 lshift TIM5-SR bis! ;  \ TIM5-SR_UIF    Update interrupt flag

\ TIM5-EGR (read-write)
: TIM5-EGR_TG   %1 6 lshift TIM5-EGR bis! ;  \ TIM5-EGR_TG    Trigger generation
: TIM5-EGR_CC4G   %1 4 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC4G    Capture/compare 4  generation
: TIM5-EGR_CC3G   %1 3 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC3G    Capture/compare 3  generation
: TIM5-EGR_CC2G   %1 2 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC2G    Capture/compare 2  generation
: TIM5-EGR_CC1G   %1 1 lshift TIM5-EGR bis! ;  \ TIM5-EGR_CC1G    Capture/compare 1  generation
: TIM5-EGR_UG   %1 0 lshift TIM5-EGR bis! ;  \ TIM5-EGR_UG    Update generation

\ TIM5-CCMR1_Output (read-write)
: TIM5-CCMR1_Output_OC2CE   %1 15 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM5-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2M    Output compare 2 mode
: TIM5-CCMR1_Output_OC2PE   %1 11 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM5-CCMR1_Output_OC2FE   %1 10 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM5-CCMR1_Output_CC2S   %1 8 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM5-CCMR1_Output_OC1CE   %1 7 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM5-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1M    Output compare 1 mode
: TIM5-CCMR1_Output_OC1PE   %1 3 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM5-CCMR1_Output_OC1FE   %1 2 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM5-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Output bis! ;  \ TIM5-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM5-CCMR1_Input (read-write)
: TIM5-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2F    Input capture 2 filter
: TIM5-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM5-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM5-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_IC1F    Input capture 1 filter
: TIM5-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM5-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM5-CCMR1_Input bis! ;  \ TIM5-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM5-CCMR2_Output (read-write)
: TIM5-CCMR2_Output_OC4CE   %1 15 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM5-CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4M    Output compare 4 mode
: TIM5-CCMR2_Output_OC4PE   %1 11 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM5-CCMR2_Output_OC4FE   %1 10 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM5-CCMR2_Output_CC4S   %1 8 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM5-CCMR2_Output_OC3CE   %1 7 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM5-CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3M    Output compare 3 mode
: TIM5-CCMR2_Output_OC3PE   %1 3 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM5-CCMR2_Output_OC3FE   %1 2 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM5-CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Output bis! ;  \ TIM5-CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM5-CCMR2_Input (read-write)
: TIM5-CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4F    Input capture 4 filter
: TIM5-CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM5-CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM5-CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3F    Input capture 3 filter
: TIM5-CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM5-CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM5-CCMR2_Input bis! ;  \ TIM5-CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM5-CCER (read-write)
: TIM5-CCER_CC4NP   %1 15 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4NP    Capture/Compare 4 output  Polarity
: TIM5-CCER_CC4P   %1 13 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4P    Capture/Compare 4 output  Polarity
: TIM5-CCER_CC4E   %1 12 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC4E    Capture/Compare 4 output  enable
: TIM5-CCER_CC3NP   %1 11 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM5-CCER_CC3P   %1 9 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM5-CCER_CC3E   %1 8 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC3E    Capture/Compare 3 output  enable
: TIM5-CCER_CC2NP   %1 7 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM5-CCER_CC2P   %1 5 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM5-CCER_CC2E   %1 4 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC2E    Capture/Compare 2 output  enable
: TIM5-CCER_CC1NP   %1 3 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1NP    Capture/Compare 1 complementary output  Polarity
: TIM5-CCER_CC1P   %1 1 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM5-CCER_CC1E   %1 0 lshift TIM5-CCER bis! ;  \ TIM5-CCER_CC1E    Capture/Compare 1 output  enable

\ TIM5-CNT (read-write)
: TIM5-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CNT bis! ;  \ TIM5-CNT_CNT    TIM2 counter

\ TIM5-PSC (read-write)
: TIM5-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-PSC bis! ;  \ TIM5-PSC_PSC    TIM2 prescaler

\ TIM5-ARR (read-write)
: TIM5-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-ARR bis! ;  \ TIM5-ARR_ARR    Auto-reload value

\ TIM5-CCR1 (read-write)
: TIM5-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR1 bis! ;  \ TIM5-CCR1_CCR1    Capture/Compare 1 value

\ TIM5-CCR2 (read-write)
: TIM5-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR2 bis! ;  \ TIM5-CCR2_CCR2    Capture/Compare 2 value

\ TIM5-CCR3 (read-write)
: TIM5-CCR3_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR3 bis! ;  \ TIM5-CCR3_CCR1    Capture/Compare 1 value

\ TIM5-CCR4 (read-write)
: TIM5-CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-CCR4 bis! ;  \ TIM5-CCR4_CCR4    Capture/Compare 4 value

\ TIM5-DCR (read-write)
: TIM5-DCR_DBL   ( %XXXXX -- ) 8 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBL    DMA burst length
: TIM5-DCR_DBA   ( %XXXXX -- ) 0 lshift TIM5-DCR bis! ;  \ TIM5-DCR_DBA    DMA base address

\ TIM5-DMAR (read-write)
: TIM5-DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM5-DMAR bis! ;  \ TIM5-DMAR_DMAB    DMA register for burst  accesses

\ TIM6-CR1 (read-write)
: TIM6-CR1_ARPE   %1 7 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_ARPE    Auto-reload preload enable
: TIM6-CR1_OPM   %1 3 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_OPM    One-pulse mode
: TIM6-CR1_URS   %1 2 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_URS    Update request source
: TIM6-CR1_UDIS   %1 1 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_UDIS    Update disable
: TIM6-CR1_CEN   %1 0 lshift TIM6-CR1 bis! ;  \ TIM6-CR1_CEN    Counter enable

\ TIM6-CR2 (read-write)
: TIM6-CR2_MMS   ( %XXX -- ) 4 lshift TIM6-CR2 bis! ;  \ TIM6-CR2_MMS    Master mode selection

\ TIM6-DIER (read-write)
: TIM6-DIER_UDE   %1 8 lshift TIM6-DIER bis! ;  \ TIM6-DIER_UDE    Update DMA request enable
: TIM6-DIER_UIE   %1 0 lshift TIM6-DIER bis! ;  \ TIM6-DIER_UIE    Update interrupt enable

\ TIM6-SR (read-write)
: TIM6-SR_UIF   %1 0 lshift TIM6-SR bis! ;  \ TIM6-SR_UIF    Update interrupt flag

\ TIM6-EGR (write-only)
: TIM6-EGR_UG   %1 0 lshift TIM6-EGR bis! ;  \ TIM6-EGR_UG    Update generation

\ TIM6-CNT (read-write)
: TIM6-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-CNT bis! ;  \ TIM6-CNT_CNT    CNT

\ TIM6-PSC (read-write)
: TIM6-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-PSC bis! ;  \ TIM6-PSC_PSC    Prescaler valueThe counter clock  frequency CK_CNT is equal to fCK_PSC / PSC[15:0] +  1.

\ TIM6-ARR (read-write)
: TIM6-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6-ARR bis! ;  \ TIM6-ARR_ARR    Prescaler value

\ TIM7-CR1 (read-write)
: TIM7-CR1_ARPE   %1 7 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_ARPE    Auto-reload preload enable
: TIM7-CR1_OPM   %1 3 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_OPM    One-pulse mode
: TIM7-CR1_URS   %1 2 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_URS    Update request source
: TIM7-CR1_UDIS   %1 1 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_UDIS    Update disable
: TIM7-CR1_CEN   %1 0 lshift TIM7-CR1 bis! ;  \ TIM7-CR1_CEN    Counter enable

\ TIM7-CR2 (read-write)
: TIM7-CR2_MMS   ( %XXX -- ) 4 lshift TIM7-CR2 bis! ;  \ TIM7-CR2_MMS    Master mode selection

\ TIM7-DIER (read-write)
: TIM7-DIER_UDE   %1 8 lshift TIM7-DIER bis! ;  \ TIM7-DIER_UDE    Update DMA request enable
: TIM7-DIER_UIE   %1 0 lshift TIM7-DIER bis! ;  \ TIM7-DIER_UIE    Update interrupt enable

\ TIM7-SR (read-write)
: TIM7-SR_UIF   %1 0 lshift TIM7-SR bis! ;  \ TIM7-SR_UIF    Update interrupt flag

\ TIM7-EGR (write-only)
: TIM7-EGR_UG   %1 0 lshift TIM7-EGR bis! ;  \ TIM7-EGR_UG    Update generation

\ TIM7-CNT (read-write)
: TIM7-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-CNT bis! ;  \ TIM7-CNT_CNT    CNT

\ TIM7-PSC (read-write)
: TIM7-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-PSC bis! ;  \ TIM7-PSC_PSC    Prescaler valueThe counter clock  frequency CK_CNT is equal to fCK_PSC / PSC[15:0] +  1.

\ TIM7-ARR (read-write)
: TIM7-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM7-ARR bis! ;  \ TIM7-ARR_ARR    Prescaler value

\ TIM9-CR1 (read-write)
: TIM9-CR1_CKD   ( %XX -- ) 8 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CKD    Clock division
: TIM9-CR1_ARPE   %1 7 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_ARPE    Auto-reload preload enable
: TIM9-CR1_OMP   %1 3 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_OMP    One-pulse mode
: TIM9-CR1_URS   %1 2 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_URS    Update request source
: TIM9-CR1_UDIS   %1 1 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_UDIS    Update disable
: TIM9-CR1_CEN   %1 0 lshift TIM9-CR1 bis! ;  \ TIM9-CR1_CEN    Counter enable

\ TIM9-CR2 (read-write)
: TIM9-CR2_MMS   ( %XXX -- ) 4 lshift TIM9-CR2 bis! ;  \ TIM9-CR2_MMS    Master mode selection

\ TIM9-SMCR (read-write)
: TIM9-SMCR_MSM   %1 7 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_MSM    Master/Slave mode
: TIM9-SMCR_TS   ( %XXX -- ) 4 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_TS    Trigger selection
: TIM9-SMCR_SMS   ( %XXX -- ) 0 lshift TIM9-SMCR bis! ;  \ TIM9-SMCR_SMS    Slave mode selection

\ TIM9-DIER (write-only)
: TIM9-DIER_TIE   %1 6 lshift TIM9-DIER bis! ;  \ TIM9-DIER_TIE    Trigger interrupt enable
: TIM9-DIER_CC2IE   %1 2 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM9-DIER_CC1IE   %1 1 lshift TIM9-DIER bis! ;  \ TIM9-DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM9-DIER_UIE   %1 0 lshift TIM9-DIER bis! ;  \ TIM9-DIER_UIE    Update interrupt enable

\ TIM9-SR (read-write)
: TIM9-SR_CC2OF   %1 10 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM9-SR_CC1OF   %1 9 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1OF    Capture/compare 1 overcapture  flag
: TIM9-SR_TIF   %1 6 lshift TIM9-SR bis! ;  \ TIM9-SR_TIF    Trigger interrupt flag
: TIM9-SR_CC2IF   %1 2 lshift TIM9-SR bis! ;  \ TIM9-SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM9-SR_CC1IF   %1 1 lshift TIM9-SR bis! ;  \ TIM9-SR_CC1IF    Capture/Compare 1 interrupt  flag
: TIM9-SR_UIF   %1 0 lshift TIM9-SR bis! ;  \ TIM9-SR_UIF    Update interrupt flag

\ TIM9-EGR (read-write)
: TIM9-EGR_TG   %1 6 lshift TIM9-EGR bis! ;  \ TIM9-EGR_TG    Trigger generation
: TIM9-EGR_CC2G   %1 2 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC2G    Capture/Compare 2  generation
: TIM9-EGR_CC1G   %1 1 lshift TIM9-EGR bis! ;  \ TIM9-EGR_CC1G    Capture/Compare 1  generation
: TIM9-EGR_UG   %1 0 lshift TIM9-EGR bis! ;  \ TIM9-EGR_UG    Update generation

\ TIM9-CCMR1_Output (read-write)
: TIM9-CCMR1_Output_OC2CE   %1 15 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM9-CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2M    Output compare 2 mode
: TIM9-CCMR1_Output_OC2PE   %1 11 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM9-CCMR1_Output_OC2FE   %1 10 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM9-CCMR1_Output_CC2S   %1 8 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM9-CCMR1_Output_OC1CE   %1 7 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM9-CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1M    Output compare 1 mode
: TIM9-CCMR1_Output_OC1PE   %1 3 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM9-CCMR1_Output_OC1FE   %1 2 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM9-CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Output bis! ;  \ TIM9-CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM9-CCMR1_Input (read-write)
: TIM9-CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2F    Input capture 2 filter
: TIM9-CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM9-CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM9-CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_IC1F    Input capture 1 filter
: TIM9-CCMR1_Input_ICPCS   ( %XX -- ) 2 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_ICPCS    Input capture 1 prescaler
: TIM9-CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM9-CCMR1_Input bis! ;  \ TIM9-CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM9-CNT (read-write)
: TIM9-CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CNT bis! ;  \ TIM9-CNT_CNT    TIM9 counter

\ TIM9-PSC (read-write)
: TIM9-PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-PSC bis! ;  \ TIM9-PSC_PSC    TIM9 prescaler

\ TIM9-ARR (read-write)
: TIM9-ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-ARR bis! ;  \ TIM9-ARR_ARR    Auto-reload value

\ TIM9-CCR1 (read-write)
: TIM9-CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR1 bis! ;  \ TIM9-CCR1_CCR1    Capture/Compare 1 value

\ TIM9-CCR2 (read-write)
: TIM9-CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM9-CCR2 bis! ;  \ TIM9-CCR2_CCR2    Capture/Compare 2 value

\ TIM9-OR (read-write)
: TIM9-OR_TI1_RMP   ( %XX -- ) 0 lshift TIM9-OR bis! ;  \ TIM9-OR_TI1_RMP    TIM9 Input 1 remapping  capability

\ USART1-SR ()
: USART1-SR_CTS   %1 9 lshift USART1-SR bis! ;  \ USART1-SR_CTS    CTS flag
: USART1-SR_LBD   %1 8 lshift USART1-SR bis! ;  \ USART1-SR_LBD    LIN break detection flag
: USART1-SR_TXE   %1 7 lshift USART1-SR bis! ;  \ USART1-SR_TXE    Transmit data register  empty
: USART1-SR_TC   %1 6 lshift USART1-SR bis! ;  \ USART1-SR_TC    Transmission complete
: USART1-SR_RXNE   %1 5 lshift USART1-SR bis! ;  \ USART1-SR_RXNE    Read data register not  empty
: USART1-SR_IDLE   %1 4 lshift USART1-SR bis! ;  \ USART1-SR_IDLE    IDLE line detected
: USART1-SR_ORE   %1 3 lshift USART1-SR bis! ;  \ USART1-SR_ORE    Overrun error
: USART1-SR_NF   %1 2 lshift USART1-SR bis! ;  \ USART1-SR_NF    Noise detected flag
: USART1-SR_FE   %1 1 lshift USART1-SR bis! ;  \ USART1-SR_FE    Framing error
: USART1-SR_PE   %1 0 lshift USART1-SR bis! ;  \ USART1-SR_PE    Parity error

\ USART1-DR (read-write)
: USART1-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART1-DR bis! ;  \ USART1-DR_DR    Data value

\ USART1-BRR (read-write)
: USART1-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART1-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART1-BRR bis! ;  \ USART1-BRR_DIV_Fraction    fraction of USARTDIV

\ USART1-CR1 (read-write)
: USART1-CR1_OVER8   %1 15 lshift USART1-CR1 bis! ;  \ USART1-CR1_OVER8    Oversampling mode
: USART1-CR1_UE   %1 13 lshift USART1-CR1 bis! ;  \ USART1-CR1_UE    USART enable
: USART1-CR1_M   %1 12 lshift USART1-CR1 bis! ;  \ USART1-CR1_M    Word length
: USART1-CR1_WAKE   %1 11 lshift USART1-CR1 bis! ;  \ USART1-CR1_WAKE    Wakeup method
: USART1-CR1_PCE   %1 10 lshift USART1-CR1 bis! ;  \ USART1-CR1_PCE    Parity control enable
: USART1-CR1_PS   %1 9 lshift USART1-CR1 bis! ;  \ USART1-CR1_PS    Parity selection
: USART1-CR1_PEIE   %1 8 lshift USART1-CR1 bis! ;  \ USART1-CR1_PEIE    PE interrupt enable
: USART1-CR1_TXEIE   %1 7 lshift USART1-CR1 bis! ;  \ USART1-CR1_TXEIE    TXE interrupt enable
: USART1-CR1_TCIE   %1 6 lshift USART1-CR1 bis! ;  \ USART1-CR1_TCIE    Transmission complete interrupt  enable
: USART1-CR1_RXNEIE   %1 5 lshift USART1-CR1 bis! ;  \ USART1-CR1_RXNEIE    RXNE interrupt enable
: USART1-CR1_IDLEIE   %1 4 lshift USART1-CR1 bis! ;  \ USART1-CR1_IDLEIE    IDLE interrupt enable
: USART1-CR1_TE   %1 3 lshift USART1-CR1 bis! ;  \ USART1-CR1_TE    Transmitter enable
: USART1-CR1_RE   %1 2 lshift USART1-CR1 bis! ;  \ USART1-CR1_RE    Receiver enable
: USART1-CR1_RWU   %1 1 lshift USART1-CR1 bis! ;  \ USART1-CR1_RWU    Receiver wakeup
: USART1-CR1_SBK   %1 0 lshift USART1-CR1 bis! ;  \ USART1-CR1_SBK    Send break

\ USART1-CR2 (read-write)
: USART1-CR2_LINEN   %1 14 lshift USART1-CR2 bis! ;  \ USART1-CR2_LINEN    LIN mode enable
: USART1-CR2_STOP   ( %XX -- ) 12 lshift USART1-CR2 bis! ;  \ USART1-CR2_STOP    STOP bits
: USART1-CR2_CLKEN   %1 11 lshift USART1-CR2 bis! ;  \ USART1-CR2_CLKEN    Clock enable
: USART1-CR2_CPOL   %1 10 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPOL    Clock polarity
: USART1-CR2_CPHA   %1 9 lshift USART1-CR2 bis! ;  \ USART1-CR2_CPHA    Clock phase
: USART1-CR2_LBCL   %1 8 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBCL    Last bit clock pulse
: USART1-CR2_LBDIE   %1 6 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDIE    LIN break detection interrupt  enable
: USART1-CR2_LBDL   %1 5 lshift USART1-CR2 bis! ;  \ USART1-CR2_LBDL    lin break detection length
: USART1-CR2_ADD   ( %XXXX -- ) 0 lshift USART1-CR2 bis! ;  \ USART1-CR2_ADD    Address of the USART node

\ USART1-CR3 (read-write)
: USART1-CR3_ONEBIT   %1 11 lshift USART1-CR3 bis! ;  \ USART1-CR3_ONEBIT    One sample bit method  enable
: USART1-CR3_CTSIE   %1 10 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSIE    CTS interrupt enable
: USART1-CR3_CTSE   %1 9 lshift USART1-CR3 bis! ;  \ USART1-CR3_CTSE    CTS enable
: USART1-CR3_RTSE   %1 8 lshift USART1-CR3 bis! ;  \ USART1-CR3_RTSE    RTS enable
: USART1-CR3_DMAT   %1 7 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAT    DMA enable transmitter
: USART1-CR3_DMAR   %1 6 lshift USART1-CR3 bis! ;  \ USART1-CR3_DMAR    DMA enable receiver
: USART1-CR3_SCEN   %1 5 lshift USART1-CR3 bis! ;  \ USART1-CR3_SCEN    Smartcard mode enable
: USART1-CR3_NACK   %1 4 lshift USART1-CR3 bis! ;  \ USART1-CR3_NACK    Smartcard NACK enable
: USART1-CR3_HDSEL   %1 3 lshift USART1-CR3 bis! ;  \ USART1-CR3_HDSEL    Half-duplex selection
: USART1-CR3_IRLP   %1 2 lshift USART1-CR3 bis! ;  \ USART1-CR3_IRLP    IrDA low-power
: USART1-CR3_IREN   %1 1 lshift USART1-CR3 bis! ;  \ USART1-CR3_IREN    IrDA mode enable
: USART1-CR3_EIE   %1 0 lshift USART1-CR3 bis! ;  \ USART1-CR3_EIE    Error interrupt enable

\ USART1-GTPR (read-write)
: USART1-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART1-GTPR bis! ;  \ USART1-GTPR_GT    Guard time value
: USART1-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART1-GTPR bis! ;  \ USART1-GTPR_PSC    Prescaler value

\ USART2-SR ()
: USART2-SR_CTS   %1 9 lshift USART2-SR bis! ;  \ USART2-SR_CTS    CTS flag
: USART2-SR_LBD   %1 8 lshift USART2-SR bis! ;  \ USART2-SR_LBD    LIN break detection flag
: USART2-SR_TXE   %1 7 lshift USART2-SR bis! ;  \ USART2-SR_TXE    Transmit data register  empty
: USART2-SR_TC   %1 6 lshift USART2-SR bis! ;  \ USART2-SR_TC    Transmission complete
: USART2-SR_RXNE   %1 5 lshift USART2-SR bis! ;  \ USART2-SR_RXNE    Read data register not  empty
: USART2-SR_IDLE   %1 4 lshift USART2-SR bis! ;  \ USART2-SR_IDLE    IDLE line detected
: USART2-SR_ORE   %1 3 lshift USART2-SR bis! ;  \ USART2-SR_ORE    Overrun error
: USART2-SR_NF   %1 2 lshift USART2-SR bis! ;  \ USART2-SR_NF    Noise detected flag
: USART2-SR_FE   %1 1 lshift USART2-SR bis! ;  \ USART2-SR_FE    Framing error
: USART2-SR_PE   %1 0 lshift USART2-SR bis! ;  \ USART2-SR_PE    Parity error

\ USART2-DR (read-write)
: USART2-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART2-DR bis! ;  \ USART2-DR_DR    Data value

\ USART2-BRR (read-write)
: USART2-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART2-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART2-BRR bis! ;  \ USART2-BRR_DIV_Fraction    fraction of USARTDIV

\ USART2-CR1 (read-write)
: USART2-CR1_OVER8   %1 15 lshift USART2-CR1 bis! ;  \ USART2-CR1_OVER8    Oversampling mode
: USART2-CR1_UE   %1 13 lshift USART2-CR1 bis! ;  \ USART2-CR1_UE    USART enable
: USART2-CR1_M   %1 12 lshift USART2-CR1 bis! ;  \ USART2-CR1_M    Word length
: USART2-CR1_WAKE   %1 11 lshift USART2-CR1 bis! ;  \ USART2-CR1_WAKE    Wakeup method
: USART2-CR1_PCE   %1 10 lshift USART2-CR1 bis! ;  \ USART2-CR1_PCE    Parity control enable
: USART2-CR1_PS   %1 9 lshift USART2-CR1 bis! ;  \ USART2-CR1_PS    Parity selection
: USART2-CR1_PEIE   %1 8 lshift USART2-CR1 bis! ;  \ USART2-CR1_PEIE    PE interrupt enable
: USART2-CR1_TXEIE   %1 7 lshift USART2-CR1 bis! ;  \ USART2-CR1_TXEIE    TXE interrupt enable
: USART2-CR1_TCIE   %1 6 lshift USART2-CR1 bis! ;  \ USART2-CR1_TCIE    Transmission complete interrupt  enable
: USART2-CR1_RXNEIE   %1 5 lshift USART2-CR1 bis! ;  \ USART2-CR1_RXNEIE    RXNE interrupt enable
: USART2-CR1_IDLEIE   %1 4 lshift USART2-CR1 bis! ;  \ USART2-CR1_IDLEIE    IDLE interrupt enable
: USART2-CR1_TE   %1 3 lshift USART2-CR1 bis! ;  \ USART2-CR1_TE    Transmitter enable
: USART2-CR1_RE   %1 2 lshift USART2-CR1 bis! ;  \ USART2-CR1_RE    Receiver enable
: USART2-CR1_RWU   %1 1 lshift USART2-CR1 bis! ;  \ USART2-CR1_RWU    Receiver wakeup
: USART2-CR1_SBK   %1 0 lshift USART2-CR1 bis! ;  \ USART2-CR1_SBK    Send break

\ USART2-CR2 (read-write)
: USART2-CR2_LINEN   %1 14 lshift USART2-CR2 bis! ;  \ USART2-CR2_LINEN    LIN mode enable
: USART2-CR2_STOP   ( %XX -- ) 12 lshift USART2-CR2 bis! ;  \ USART2-CR2_STOP    STOP bits
: USART2-CR2_CLKEN   %1 11 lshift USART2-CR2 bis! ;  \ USART2-CR2_CLKEN    Clock enable
: USART2-CR2_CPOL   %1 10 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPOL    Clock polarity
: USART2-CR2_CPHA   %1 9 lshift USART2-CR2 bis! ;  \ USART2-CR2_CPHA    Clock phase
: USART2-CR2_LBCL   %1 8 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBCL    Last bit clock pulse
: USART2-CR2_LBDIE   %1 6 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDIE    LIN break detection interrupt  enable
: USART2-CR2_LBDL   %1 5 lshift USART2-CR2 bis! ;  \ USART2-CR2_LBDL    lin break detection length
: USART2-CR2_ADD   ( %XXXX -- ) 0 lshift USART2-CR2 bis! ;  \ USART2-CR2_ADD    Address of the USART node

\ USART2-CR3 (read-write)
: USART2-CR3_ONEBIT   %1 11 lshift USART2-CR3 bis! ;  \ USART2-CR3_ONEBIT    One sample bit method  enable
: USART2-CR3_CTSIE   %1 10 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSIE    CTS interrupt enable
: USART2-CR3_CTSE   %1 9 lshift USART2-CR3 bis! ;  \ USART2-CR3_CTSE    CTS enable
: USART2-CR3_RTSE   %1 8 lshift USART2-CR3 bis! ;  \ USART2-CR3_RTSE    RTS enable
: USART2-CR3_DMAT   %1 7 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAT    DMA enable transmitter
: USART2-CR3_DMAR   %1 6 lshift USART2-CR3 bis! ;  \ USART2-CR3_DMAR    DMA enable receiver
: USART2-CR3_SCEN   %1 5 lshift USART2-CR3 bis! ;  \ USART2-CR3_SCEN    Smartcard mode enable
: USART2-CR3_NACK   %1 4 lshift USART2-CR3 bis! ;  \ USART2-CR3_NACK    Smartcard NACK enable
: USART2-CR3_HDSEL   %1 3 lshift USART2-CR3 bis! ;  \ USART2-CR3_HDSEL    Half-duplex selection
: USART2-CR3_IRLP   %1 2 lshift USART2-CR3 bis! ;  \ USART2-CR3_IRLP    IrDA low-power
: USART2-CR3_IREN   %1 1 lshift USART2-CR3 bis! ;  \ USART2-CR3_IREN    IrDA mode enable
: USART2-CR3_EIE   %1 0 lshift USART2-CR3 bis! ;  \ USART2-CR3_EIE    Error interrupt enable

\ USART2-GTPR (read-write)
: USART2-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART2-GTPR bis! ;  \ USART2-GTPR_GT    Guard time value
: USART2-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART2-GTPR bis! ;  \ USART2-GTPR_PSC    Prescaler value

\ USART3-SR ()
: USART3-SR_CTS   %1 9 lshift USART3-SR bis! ;  \ USART3-SR_CTS    CTS flag
: USART3-SR_LBD   %1 8 lshift USART3-SR bis! ;  \ USART3-SR_LBD    LIN break detection flag
: USART3-SR_TXE   %1 7 lshift USART3-SR bis! ;  \ USART3-SR_TXE    Transmit data register  empty
: USART3-SR_TC   %1 6 lshift USART3-SR bis! ;  \ USART3-SR_TC    Transmission complete
: USART3-SR_RXNE   %1 5 lshift USART3-SR bis! ;  \ USART3-SR_RXNE    Read data register not  empty
: USART3-SR_IDLE   %1 4 lshift USART3-SR bis! ;  \ USART3-SR_IDLE    IDLE line detected
: USART3-SR_ORE   %1 3 lshift USART3-SR bis! ;  \ USART3-SR_ORE    Overrun error
: USART3-SR_NF   %1 2 lshift USART3-SR bis! ;  \ USART3-SR_NF    Noise detected flag
: USART3-SR_FE   %1 1 lshift USART3-SR bis! ;  \ USART3-SR_FE    Framing error
: USART3-SR_PE   %1 0 lshift USART3-SR bis! ;  \ USART3-SR_PE    Parity error

\ USART3-DR (read-write)
: USART3-DR_DR   ( %XXXXXXXXX -- ) 0 lshift USART3-DR bis! ;  \ USART3-DR_DR    Data value

\ USART3-BRR (read-write)
: USART3-BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART3-BRR bis! ;  \ USART3-BRR_DIV_Mantissa    mantissa of USARTDIV
: USART3-BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART3-BRR bis! ;  \ USART3-BRR_DIV_Fraction    fraction of USARTDIV

\ USART3-CR1 (read-write)
: USART3-CR1_OVER8   %1 15 lshift USART3-CR1 bis! ;  \ USART3-CR1_OVER8    Oversampling mode
: USART3-CR1_UE   %1 13 lshift USART3-CR1 bis! ;  \ USART3-CR1_UE    USART enable
: USART3-CR1_M   %1 12 lshift USART3-CR1 bis! ;  \ USART3-CR1_M    Word length
: USART3-CR1_WAKE   %1 11 lshift USART3-CR1 bis! ;  \ USART3-CR1_WAKE    Wakeup method
: USART3-CR1_PCE   %1 10 lshift USART3-CR1 bis! ;  \ USART3-CR1_PCE    Parity control enable
: USART3-CR1_PS   %1 9 lshift USART3-CR1 bis! ;  \ USART3-CR1_PS    Parity selection
: USART3-CR1_PEIE   %1 8 lshift USART3-CR1 bis! ;  \ USART3-CR1_PEIE    PE interrupt enable
: USART3-CR1_TXEIE   %1 7 lshift USART3-CR1 bis! ;  \ USART3-CR1_TXEIE    TXE interrupt enable
: USART3-CR1_TCIE   %1 6 lshift USART3-CR1 bis! ;  \ USART3-CR1_TCIE    Transmission complete interrupt  enable
: USART3-CR1_RXNEIE   %1 5 lshift USART3-CR1 bis! ;  \ USART3-CR1_RXNEIE    RXNE interrupt enable
: USART3-CR1_IDLEIE   %1 4 lshift USART3-CR1 bis! ;  \ USART3-CR1_IDLEIE    IDLE interrupt enable
: USART3-CR1_TE   %1 3 lshift USART3-CR1 bis! ;  \ USART3-CR1_TE    Transmitter enable
: USART3-CR1_RE   %1 2 lshift USART3-CR1 bis! ;  \ USART3-CR1_RE    Receiver enable
: USART3-CR1_RWU   %1 1 lshift USART3-CR1 bis! ;  \ USART3-CR1_RWU    Receiver wakeup
: USART3-CR1_SBK   %1 0 lshift USART3-CR1 bis! ;  \ USART3-CR1_SBK    Send break

\ USART3-CR2 (read-write)
: USART3-CR2_LINEN   %1 14 lshift USART3-CR2 bis! ;  \ USART3-CR2_LINEN    LIN mode enable
: USART3-CR2_STOP   ( %XX -- ) 12 lshift USART3-CR2 bis! ;  \ USART3-CR2_STOP    STOP bits
: USART3-CR2_CLKEN   %1 11 lshift USART3-CR2 bis! ;  \ USART3-CR2_CLKEN    Clock enable
: USART3-CR2_CPOL   %1 10 lshift USART3-CR2 bis! ;  \ USART3-CR2_CPOL    Clock polarity
: USART3-CR2_CPHA   %1 9 lshift USART3-CR2 bis! ;  \ USART3-CR2_CPHA    Clock phase
: USART3-CR2_LBCL   %1 8 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBCL    Last bit clock pulse
: USART3-CR2_LBDIE   %1 6 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBDIE    LIN break detection interrupt  enable
: USART3-CR2_LBDL   %1 5 lshift USART3-CR2 bis! ;  \ USART3-CR2_LBDL    lin break detection length
: USART3-CR2_ADD   ( %XXXX -- ) 0 lshift USART3-CR2 bis! ;  \ USART3-CR2_ADD    Address of the USART node

\ USART3-CR3 (read-write)
: USART3-CR3_ONEBIT   %1 11 lshift USART3-CR3 bis! ;  \ USART3-CR3_ONEBIT    One sample bit method  enable
: USART3-CR3_CTSIE   %1 10 lshift USART3-CR3 bis! ;  \ USART3-CR3_CTSIE    CTS interrupt enable
: USART3-CR3_CTSE   %1 9 lshift USART3-CR3 bis! ;  \ USART3-CR3_CTSE    CTS enable
: USART3-CR3_RTSE   %1 8 lshift USART3-CR3 bis! ;  \ USART3-CR3_RTSE    RTS enable
: USART3-CR3_DMAT   %1 7 lshift USART3-CR3 bis! ;  \ USART3-CR3_DMAT    DMA enable transmitter
: USART3-CR3_DMAR   %1 6 lshift USART3-CR3 bis! ;  \ USART3-CR3_DMAR    DMA enable receiver
: USART3-CR3_SCEN   %1 5 lshift USART3-CR3 bis! ;  \ USART3-CR3_SCEN    Smartcard mode enable
: USART3-CR3_NACK   %1 4 lshift USART3-CR3 bis! ;  \ USART3-CR3_NACK    Smartcard NACK enable
: USART3-CR3_HDSEL   %1 3 lshift USART3-CR3 bis! ;  \ USART3-CR3_HDSEL    Half-duplex selection
: USART3-CR3_IRLP   %1 2 lshift USART3-CR3 bis! ;  \ USART3-CR3_IRLP    IrDA low-power
: USART3-CR3_IREN   %1 1 lshift USART3-CR3 bis! ;  \ USART3-CR3_IREN    IrDA mode enable
: USART3-CR3_EIE   %1 0 lshift USART3-CR3 bis! ;  \ USART3-CR3_EIE    Error interrupt enable

\ USART3-GTPR (read-write)
: USART3-GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART3-GTPR bis! ;  \ USART3-GTPR_GT    Guard time value
: USART3-GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART3-GTPR bis! ;  \ USART3-GTPR_PSC    Prescaler value

\ USB-USB_EP0R (read-write)
: USB-USB_EP0R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_EA    Endpoint address
: USB-USB_EP0R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP0R_DTOG_TX   %1 6 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP0R_CTR_TX   %1 7 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP0R_EP_KIND   %1 8 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_EP_KIND    Endpoint kind
: USB-USB_EP0R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_EP_TYPE    Endpoint type
: USB-USB_EP0R_SETUP   %1 11 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_SETUP    Setup transaction  completed
: USB-USB_EP0R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP0R_DTOG_RX   %1 14 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP0R_CTR_RX   %1 15 lshift USB-USB_EP0R bis! ;  \ USB-USB_EP0R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP1R (read-write)
: USB-USB_EP1R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_EA    Endpoint address
: USB-USB_EP1R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP1R_DTOG_TX   %1 6 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP1R_CTR_TX   %1 7 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP1R_EP_KIND   %1 8 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_EP_KIND    Endpoint kind
: USB-USB_EP1R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_EP_TYPE    Endpoint type
: USB-USB_EP1R_SETUP   %1 11 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_SETUP    Setup transaction  completed
: USB-USB_EP1R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP1R_DTOG_RX   %1 14 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP1R_CTR_RX   %1 15 lshift USB-USB_EP1R bis! ;  \ USB-USB_EP1R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP2R (read-write)
: USB-USB_EP2R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_EA    Endpoint address
: USB-USB_EP2R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP2R_DTOG_TX   %1 6 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP2R_CTR_TX   %1 7 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP2R_EP_KIND   %1 8 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_EP_KIND    Endpoint kind
: USB-USB_EP2R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_EP_TYPE    Endpoint type
: USB-USB_EP2R_SETUP   %1 11 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_SETUP    Setup transaction  completed
: USB-USB_EP2R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP2R_DTOG_RX   %1 14 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP2R_CTR_RX   %1 15 lshift USB-USB_EP2R bis! ;  \ USB-USB_EP2R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP3R (read-write)
: USB-USB_EP3R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_EA    Endpoint address
: USB-USB_EP3R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP3R_DTOG_TX   %1 6 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP3R_CTR_TX   %1 7 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP3R_EP_KIND   %1 8 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_EP_KIND    Endpoint kind
: USB-USB_EP3R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_EP_TYPE    Endpoint type
: USB-USB_EP3R_SETUP   %1 11 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_SETUP    Setup transaction  completed
: USB-USB_EP3R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP3R_DTOG_RX   %1 14 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP3R_CTR_RX   %1 15 lshift USB-USB_EP3R bis! ;  \ USB-USB_EP3R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP4R (read-write)
: USB-USB_EP4R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_EA    Endpoint address
: USB-USB_EP4R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP4R_DTOG_TX   %1 6 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP4R_CTR_TX   %1 7 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP4R_EP_KIND   %1 8 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_EP_KIND    Endpoint kind
: USB-USB_EP4R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_EP_TYPE    Endpoint type
: USB-USB_EP4R_SETUP   %1 11 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_SETUP    Setup transaction  completed
: USB-USB_EP4R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP4R_DTOG_RX   %1 14 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP4R_CTR_RX   %1 15 lshift USB-USB_EP4R bis! ;  \ USB-USB_EP4R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP5R (read-write)
: USB-USB_EP5R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_EA    Endpoint address
: USB-USB_EP5R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP5R_DTOG_TX   %1 6 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP5R_CTR_TX   %1 7 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP5R_EP_KIND   %1 8 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_EP_KIND    Endpoint kind
: USB-USB_EP5R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_EP_TYPE    Endpoint type
: USB-USB_EP5R_SETUP   %1 11 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_SETUP    Setup transaction  completed
: USB-USB_EP5R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP5R_DTOG_RX   %1 14 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP5R_CTR_RX   %1 15 lshift USB-USB_EP5R bis! ;  \ USB-USB_EP5R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP6R (read-write)
: USB-USB_EP6R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_EA    Endpoint address
: USB-USB_EP6R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP6R_DTOG_TX   %1 6 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP6R_CTR_TX   %1 7 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP6R_EP_KIND   %1 8 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_EP_KIND    Endpoint kind
: USB-USB_EP6R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_EP_TYPE    Endpoint type
: USB-USB_EP6R_SETUP   %1 11 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_SETUP    Setup transaction  completed
: USB-USB_EP6R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP6R_DTOG_RX   %1 14 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP6R_CTR_RX   %1 15 lshift USB-USB_EP6R bis! ;  \ USB-USB_EP6R_CTR_RX    Correct transfer for  reception

\ USB-USB_EP7R (read-write)
: USB-USB_EP7R_EA   ( %XXXX -- ) 0 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_EA    Endpoint address
: USB-USB_EP7R_STAT_TX   ( %XX -- ) 4 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_STAT_TX    Status bits, for transmission  transfers
: USB-USB_EP7R_DTOG_TX   %1 6 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_DTOG_TX    Data Toggle, for transmission  transfers
: USB-USB_EP7R_CTR_TX   %1 7 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_CTR_TX    Correct Transfer for  transmission
: USB-USB_EP7R_EP_KIND   %1 8 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_EP_KIND    Endpoint kind
: USB-USB_EP7R_EP_TYPE   ( %XX -- ) 9 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_EP_TYPE    Endpoint type
: USB-USB_EP7R_SETUP   %1 11 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_SETUP    Setup transaction  completed
: USB-USB_EP7R_STAT_RX   ( %XX -- ) 12 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_STAT_RX    Status bits, for reception  transfers
: USB-USB_EP7R_DTOG_RX   %1 14 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_DTOG_RX    Data Toggle, for reception  transfers
: USB-USB_EP7R_CTR_RX   %1 15 lshift USB-USB_EP7R bis! ;  \ USB-USB_EP7R_CTR_RX    Correct transfer for  reception

\ USB-USB_CNTR (read-write)
: USB-USB_CNTR_FRES   %1 0 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_FRES    Force USB Reset
: USB-USB_CNTR_PDWN   %1 1 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_PDWN    Power down
: USB-USB_CNTR_LPMODE   %1 2 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_LPMODE    Low-power mode
: USB-USB_CNTR_FSUSP   %1 3 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_FSUSP    Force suspend
: USB-USB_CNTR_RESUME   %1 4 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_RESUME    Resume request
: USB-USB_CNTR_ESOFM   %1 8 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_ESOFM    Expected start of frame interrupt  mask
: USB-USB_CNTR_SOFM   %1 9 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_SOFM    Start of frame interrupt  mask
: USB-USB_CNTR_RESETM   %1 10 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_RESETM    USB reset interrupt mask
: USB-USB_CNTR_SUSPM   %1 11 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_SUSPM    Suspend mode interrupt  mask
: USB-USB_CNTR_WKUPM   %1 12 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_WKUPM    Wakeup interrupt mask
: USB-USB_CNTR_ERRM   %1 13 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_ERRM    Error interrupt mask
: USB-USB_CNTR_PMAOVRM   %1 14 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_PMAOVRM    Packet memory area over / underrun  interrupt mask
: USB-USB_CNTR_CTRM   %1 15 lshift USB-USB_CNTR bis! ;  \ USB-USB_CNTR_CTRM    Correct transfer interrupt  mask

\ USB-ISTR (read-write)
: USB-ISTR_EP_ID   ( %XXXX -- ) 0 lshift USB-ISTR bis! ;  \ USB-ISTR_EP_ID    Endpoint Identifier
: USB-ISTR_DIR   %1 4 lshift USB-ISTR bis! ;  \ USB-ISTR_DIR    Direction of transaction
: USB-ISTR_ESOF   %1 8 lshift USB-ISTR bis! ;  \ USB-ISTR_ESOF    Expected start frame
: USB-ISTR_SOF   %1 9 lshift USB-ISTR bis! ;  \ USB-ISTR_SOF    start of frame
: USB-ISTR_RESET   %1 10 lshift USB-ISTR bis! ;  \ USB-ISTR_RESET    reset request
: USB-ISTR_SUSP   %1 11 lshift USB-ISTR bis! ;  \ USB-ISTR_SUSP    Suspend mode request
: USB-ISTR_WKUP   %1 12 lshift USB-ISTR bis! ;  \ USB-ISTR_WKUP    Wakeup
: USB-ISTR_ERR   %1 13 lshift USB-ISTR bis! ;  \ USB-ISTR_ERR    Error
: USB-ISTR_PMAOVR   %1 14 lshift USB-ISTR bis! ;  \ USB-ISTR_PMAOVR    Packet memory area over /  underrun
: USB-ISTR_CTR   %1 15 lshift USB-ISTR bis! ;  \ USB-ISTR_CTR    Correct transfer

\ USB-FNR (read-only)
: USB-FNR_FN  0 lshift USB-FNR bis! ;  \ USB-FNR_FN    Frame number
: USB-FNR_LSOF   ( %XX -- ) 11 lshift USB-FNR bis! ;  \ USB-FNR_LSOF    Lost SOF
: USB-FNR_LCK   %1 13 lshift USB-FNR bis! ;  \ USB-FNR_LCK    Locked
: USB-FNR_RXDM   %1 14 lshift USB-FNR bis! ;  \ USB-FNR_RXDM    Receive data - line status
: USB-FNR_RXDP   %1 15 lshift USB-FNR bis! ;  \ USB-FNR_RXDP    Receive data + line status

\ USB-DADDR (read-write)
: USB-DADDR_ADD   ( %XXXXXXX -- ) 0 lshift USB-DADDR bis! ;  \ USB-DADDR_ADD    Device address
: USB-DADDR_EF   %1 7 lshift USB-DADDR bis! ;  \ USB-DADDR_EF    Enable function

\ USB-BTABLE (read-write)
: USB-BTABLE_BTABLE  3 lshift USB-BTABLE bis! ;  \ USB-BTABLE_BTABLE    Buffer table

\ USB_SRAM-USB_EP0R (read-write)
: USB_SRAM-USB_EP0R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_EA    Endpoint address
: USB_SRAM-USB_EP0R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP0R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP0R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP0R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP0R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP0R_SETUP   %1 11 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP0R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP0R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP0R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP0R bis! ;  \ USB_SRAM-USB_EP0R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP1R (read-write)
: USB_SRAM-USB_EP1R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_EA    Endpoint address
: USB_SRAM-USB_EP1R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP1R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP1R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP1R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP1R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP1R_SETUP   %1 11 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP1R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP1R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP1R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP1R bis! ;  \ USB_SRAM-USB_EP1R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP2R (read-write)
: USB_SRAM-USB_EP2R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_EA    Endpoint address
: USB_SRAM-USB_EP2R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP2R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP2R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP2R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP2R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP2R_SETUP   %1 11 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP2R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP2R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP2R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP2R bis! ;  \ USB_SRAM-USB_EP2R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP3R (read-write)
: USB_SRAM-USB_EP3R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_EA    Endpoint address
: USB_SRAM-USB_EP3R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP3R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP3R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP3R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP3R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP3R_SETUP   %1 11 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP3R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP3R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP3R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP3R bis! ;  \ USB_SRAM-USB_EP3R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP4R (read-write)
: USB_SRAM-USB_EP4R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_EA    Endpoint address
: USB_SRAM-USB_EP4R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP4R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP4R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP4R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP4R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP4R_SETUP   %1 11 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP4R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP4R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP4R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP4R bis! ;  \ USB_SRAM-USB_EP4R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP5R (read-write)
: USB_SRAM-USB_EP5R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_EA    Endpoint address
: USB_SRAM-USB_EP5R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP5R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP5R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP5R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP5R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP5R_SETUP   %1 11 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP5R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP5R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP5R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP5R bis! ;  \ USB_SRAM-USB_EP5R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP6R (read-write)
: USB_SRAM-USB_EP6R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_EA    Endpoint address
: USB_SRAM-USB_EP6R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP6R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP6R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP6R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP6R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP6R_SETUP   %1 11 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP6R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP6R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP6R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP6R bis! ;  \ USB_SRAM-USB_EP6R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_EP7R (read-write)
: USB_SRAM-USB_EP7R_EA   ( %XXXX -- ) 0 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_EA    Endpoint address
: USB_SRAM-USB_EP7R_STAT_TX   ( %XX -- ) 4 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_STAT_TX    Status bits, for transmission  transfers
: USB_SRAM-USB_EP7R_DTOG_TX   %1 6 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_DTOG_TX    Data Toggle, for transmission  transfers
: USB_SRAM-USB_EP7R_CTR_TX   %1 7 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_CTR_TX    Correct Transfer for  transmission
: USB_SRAM-USB_EP7R_EP_KIND   %1 8 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_EP_KIND    Endpoint kind
: USB_SRAM-USB_EP7R_EP_TYPE   ( %XX -- ) 9 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_EP_TYPE    Endpoint type
: USB_SRAM-USB_EP7R_SETUP   %1 11 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_SETUP    Setup transaction  completed
: USB_SRAM-USB_EP7R_STAT_RX   ( %XX -- ) 12 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_STAT_RX    Status bits, for reception  transfers
: USB_SRAM-USB_EP7R_DTOG_RX   %1 14 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_DTOG_RX    Data Toggle, for reception  transfers
: USB_SRAM-USB_EP7R_CTR_RX   %1 15 lshift USB_SRAM-USB_EP7R bis! ;  \ USB_SRAM-USB_EP7R_CTR_RX    Correct transfer for  reception

\ USB_SRAM-USB_CNTR (read-write)
: USB_SRAM-USB_CNTR_FRES   %1 0 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_FRES    Force USB Reset
: USB_SRAM-USB_CNTR_PDWN   %1 1 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_PDWN    Power down
: USB_SRAM-USB_CNTR_LPMODE   %1 2 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_LPMODE    Low-power mode
: USB_SRAM-USB_CNTR_FSUSP   %1 3 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_FSUSP    Force suspend
: USB_SRAM-USB_CNTR_RESUME   %1 4 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_RESUME    Resume request
: USB_SRAM-USB_CNTR_ESOFM   %1 8 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_ESOFM    Expected start of frame interrupt  mask
: USB_SRAM-USB_CNTR_SOFM   %1 9 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_SOFM    Start of frame interrupt  mask
: USB_SRAM-USB_CNTR_RESETM   %1 10 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_RESETM    USB reset interrupt mask
: USB_SRAM-USB_CNTR_SUSPM   %1 11 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_SUSPM    Suspend mode interrupt  mask
: USB_SRAM-USB_CNTR_WKUPM   %1 12 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_WKUPM    Wakeup interrupt mask
: USB_SRAM-USB_CNTR_ERRM   %1 13 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_ERRM    Error interrupt mask
: USB_SRAM-USB_CNTR_PMAOVRM   %1 14 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_PMAOVRM    Packet memory area over / underrun  interrupt mask
: USB_SRAM-USB_CNTR_CTRM   %1 15 lshift USB_SRAM-USB_CNTR bis! ;  \ USB_SRAM-USB_CNTR_CTRM    Correct transfer interrupt  mask

\ USB_SRAM-ISTR (read-write)
: USB_SRAM-ISTR_EP_ID   ( %XXXX -- ) 0 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_EP_ID    Endpoint Identifier
: USB_SRAM-ISTR_DIR   %1 4 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_DIR    Direction of transaction
: USB_SRAM-ISTR_ESOF   %1 8 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_ESOF    Expected start frame
: USB_SRAM-ISTR_SOF   %1 9 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_SOF    start of frame
: USB_SRAM-ISTR_RESET   %1 10 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_RESET    reset request
: USB_SRAM-ISTR_SUSP   %1 11 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_SUSP    Suspend mode request
: USB_SRAM-ISTR_WKUP   %1 12 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_WKUP    Wakeup
: USB_SRAM-ISTR_ERR   %1 13 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_ERR    Error
: USB_SRAM-ISTR_PMAOVR   %1 14 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_PMAOVR    Packet memory area over /  underrun
: USB_SRAM-ISTR_CTR   %1 15 lshift USB_SRAM-ISTR bis! ;  \ USB_SRAM-ISTR_CTR    Correct transfer

\ USB_SRAM-FNR (read-only)
: USB_SRAM-FNR_FN  0 lshift USB_SRAM-FNR bis! ;  \ USB_SRAM-FNR_FN    Frame number
: USB_SRAM-FNR_LSOF   ( %XX -- ) 11 lshift USB_SRAM-FNR bis! ;  \ USB_SRAM-FNR_LSOF    Lost SOF
: USB_SRAM-FNR_LCK   %1 13 lshift USB_SRAM-FNR bis! ;  \ USB_SRAM-FNR_LCK    Locked
: USB_SRAM-FNR_RXDM   %1 14 lshift USB_SRAM-FNR bis! ;  \ USB_SRAM-FNR_RXDM    Receive data - line status
: USB_SRAM-FNR_RXDP   %1 15 lshift USB_SRAM-FNR bis! ;  \ USB_SRAM-FNR_RXDP    Receive data + line status

\ USB_SRAM-DADDR (read-write)
: USB_SRAM-DADDR_ADD   ( %XXXXXXX -- ) 0 lshift USB_SRAM-DADDR bis! ;  \ USB_SRAM-DADDR_ADD    Device address
: USB_SRAM-DADDR_EF   %1 7 lshift USB_SRAM-DADDR bis! ;  \ USB_SRAM-DADDR_EF    Enable function

\ USB_SRAM-BTABLE (read-write)
: USB_SRAM-BTABLE_BTABLE  3 lshift USB_SRAM-BTABLE bis! ;  \ USB_SRAM-BTABLE_BTABLE    Buffer table

\ WWDG-CR ()
: WWDG-CR_WDGA   %1 7 lshift WWDG-CR bis! ;  \ WWDG-CR_WDGA    Activation bit
: WWDG-CR_T   ( %XXXXXXX -- ) 0 lshift WWDG-CR bis! ;  \ WWDG-CR_T    7-bit counter MSB to LSB

\ WWDG-CFR ()
: WWDG-CFR_EWI   %1 9 lshift WWDG-CFR bis! ;  \ WWDG-CFR_EWI    Early wakeup interrupt
: WWDG-CFR_WDGTB1   %1 8 lshift WWDG-CFR bis! ;  \ WWDG-CFR_WDGTB1    Timer base
: WWDG-CFR_WDGTB0   %1 7 lshift WWDG-CFR bis! ;  \ WWDG-CFR_WDGTB0    WDGTB0
: WWDG-CFR_W   ( %XXXXXXX -- ) 0 lshift WWDG-CFR bis! ;  \ WWDG-CFR_W    7-bit window value

\ WWDG-SR (read-write)
: WWDG-SR_EWIF   %1 0 lshift WWDG-SR bis! ;  \ WWDG-SR_EWIF    EWIF

\ ADC-SR ()
: ADC-SR_JCNR   %1 9 lshift ADC-SR bis! ;  \ ADC-SR_JCNR    Injected channel not ready
: ADC-SR_RCNR   %1 8 lshift ADC-SR bis! ;  \ ADC-SR_RCNR    Regular channel not ready
: ADC-SR_ADONS   %1 6 lshift ADC-SR bis! ;  \ ADC-SR_ADONS    ADC ON status
: ADC-SR_OVR   %1 5 lshift ADC-SR bis! ;  \ ADC-SR_OVR    Overrun
: ADC-SR_STRT   %1 4 lshift ADC-SR bis! ;  \ ADC-SR_STRT    Regular channel start flag
: ADC-SR_JSTRT   %1 3 lshift ADC-SR bis! ;  \ ADC-SR_JSTRT    Injected channel start  flag
: ADC-SR_JEOC   %1 2 lshift ADC-SR bis! ;  \ ADC-SR_JEOC    Injected channel end of  conversion
: ADC-SR_EOC   %1 1 lshift ADC-SR bis! ;  \ ADC-SR_EOC    Regular channel end of  conversion
: ADC-SR_AWD   %1 0 lshift ADC-SR bis! ;  \ ADC-SR_AWD    Analog watchdog flag

\ ADC-CR1 (read-write)
: ADC-CR1_OVRIE   %1 26 lshift ADC-CR1 bis! ;  \ ADC-CR1_OVRIE    Overrun interrupt enable
: ADC-CR1_RES   ( %XX -- ) 24 lshift ADC-CR1 bis! ;  \ ADC-CR1_RES    Resolution
: ADC-CR1_AWDEN   %1 23 lshift ADC-CR1 bis! ;  \ ADC-CR1_AWDEN    Analog watchdog enable on regular  channels
: ADC-CR1_JAWDEN   %1 22 lshift ADC-CR1 bis! ;  \ ADC-CR1_JAWDEN    Analog watchdog enable on injected  channels
: ADC-CR1_PDI   %1 17 lshift ADC-CR1 bis! ;  \ ADC-CR1_PDI    Power down during the idle  phase
: ADC-CR1_PDD   %1 16 lshift ADC-CR1 bis! ;  \ ADC-CR1_PDD    Power down during the delay  phase
: ADC-CR1_DISCNUM   ( %XXX -- ) 13 lshift ADC-CR1 bis! ;  \ ADC-CR1_DISCNUM    Discontinuous mode channel  count
: ADC-CR1_JDISCEN   %1 12 lshift ADC-CR1 bis! ;  \ ADC-CR1_JDISCEN    Discontinuous mode on injected  channels
: ADC-CR1_DISCEN   %1 11 lshift ADC-CR1 bis! ;  \ ADC-CR1_DISCEN    Discontinuous mode on regular  channels
: ADC-CR1_JAUTO   %1 10 lshift ADC-CR1 bis! ;  \ ADC-CR1_JAUTO    Automatic injected group  conversion
: ADC-CR1_AWDSGL   %1 9 lshift ADC-CR1 bis! ;  \ ADC-CR1_AWDSGL    Enable the watchdog on a single channel  in scan mode
: ADC-CR1_SCAN   %1 8 lshift ADC-CR1 bis! ;  \ ADC-CR1_SCAN    Scan mode
: ADC-CR1_JEOCIE   %1 7 lshift ADC-CR1 bis! ;  \ ADC-CR1_JEOCIE    Interrupt enable for injected  channels
: ADC-CR1_AWDIE   %1 6 lshift ADC-CR1 bis! ;  \ ADC-CR1_AWDIE    Analog watchdog interrupt  enable
: ADC-CR1_EOCIE   %1 5 lshift ADC-CR1 bis! ;  \ ADC-CR1_EOCIE    Interrupt enable for EOC
: ADC-CR1_AWDCH   ( %XXXXX -- ) 0 lshift ADC-CR1 bis! ;  \ ADC-CR1_AWDCH    Analog watchdog channel select  bits

\ ADC-CR2 (read-write)
: ADC-CR2_SWSTART   %1 30 lshift ADC-CR2 bis! ;  \ ADC-CR2_SWSTART    Start conversion of regular  channels
: ADC-CR2_EXTEN   ( %XX -- ) 28 lshift ADC-CR2 bis! ;  \ ADC-CR2_EXTEN    External trigger enable for regular  channels
: ADC-CR2_EXTSEL   ( %XXXX -- ) 24 lshift ADC-CR2 bis! ;  \ ADC-CR2_EXTSEL    External event select for regular  group
: ADC-CR2_JSWSTART   %1 22 lshift ADC-CR2 bis! ;  \ ADC-CR2_JSWSTART    Start conversion of injected  channels
: ADC-CR2_JEXTEN   ( %XX -- ) 20 lshift ADC-CR2 bis! ;  \ ADC-CR2_JEXTEN    External trigger enable for injected  channels
: ADC-CR2_JEXTSEL   ( %XXXX -- ) 16 lshift ADC-CR2 bis! ;  \ ADC-CR2_JEXTSEL    External event select for injected  group
: ADC-CR2_ALIGN   %1 11 lshift ADC-CR2 bis! ;  \ ADC-CR2_ALIGN    Data alignment
: ADC-CR2_EOCS   %1 10 lshift ADC-CR2 bis! ;  \ ADC-CR2_EOCS    End of conversion  selection
: ADC-CR2_DDS   %1 9 lshift ADC-CR2 bis! ;  \ ADC-CR2_DDS    DMA disable selection
: ADC-CR2_DMA   %1 8 lshift ADC-CR2 bis! ;  \ ADC-CR2_DMA    Direct memory access mode
: ADC-CR2_DELS   ( %XXX -- ) 4 lshift ADC-CR2 bis! ;  \ ADC-CR2_DELS    Delay selection
: ADC-CR2_ADC_CFG   %1 2 lshift ADC-CR2 bis! ;  \ ADC-CR2_ADC_CFG    ADC configuration
: ADC-CR2_CONT   %1 1 lshift ADC-CR2 bis! ;  \ ADC-CR2_CONT    Continuous conversion
: ADC-CR2_ADON   %1 0 lshift ADC-CR2 bis! ;  \ ADC-CR2_ADON    A/D Converter ON / OFF

\ ADC-SMPR1 (read-write)
: ADC-SMPR1_SampletimebitsSMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC-SMPR1 bis! ;  \ ADC-SMPR1_SampletimebitsSMPx_x    Reserved

\ ADC-SMPR2 (read-write)
: ADC-SMPR2_SampletimebitsSMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC-SMPR2 bis! ;  \ ADC-SMPR2_SampletimebitsSMPx_x    Reserved

\ ADC-SMPR3 (read-write)
: ADC-SMPR3_SampletimebitsSMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC-SMPR3 bis! ;  \ ADC-SMPR3_SampletimebitsSMPx_x    Reserved

\ ADC-JOFR1 (read-write)
: ADC-JOFR1_JOFFSET1   ( %XXXXXXXXXXX -- ) 0 lshift ADC-JOFR1 bis! ;  \ ADC-JOFR1_JOFFSET1    Data offset for injected channel  x

\ ADC-JOFR2 (read-write)
: ADC-JOFR2_JOFFSET2   ( %XXXXXXXXXXX -- ) 0 lshift ADC-JOFR2 bis! ;  \ ADC-JOFR2_JOFFSET2    Data offset for injected channel  x

\ ADC-JOFR3 (read-write)
: ADC-JOFR3_JOFFSET3   ( %XXXXXXXXXXX -- ) 0 lshift ADC-JOFR3 bis! ;  \ ADC-JOFR3_JOFFSET3    Data offset for injected channel  x

\ ADC-JOFR4 (read-write)
: ADC-JOFR4_JOFFSET4   ( %XXXXXXXXXXX -- ) 0 lshift ADC-JOFR4 bis! ;  \ ADC-JOFR4_JOFFSET4    Data offset for injected channel  x

\ ADC-HTR (read-write)
: ADC-HTR_HT   ( %XXXXXXXXXXX -- ) 0 lshift ADC-HTR bis! ;  \ ADC-HTR_HT    Analog watchdog higher  threshold

\ ADC-LTR (read-write)
: ADC-LTR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC-LTR bis! ;  \ ADC-LTR_LT    Analog watchdog lower  threshold

\ ADC-SQR1 (read-write)
: ADC-SQR1_L   ( %XXXX -- ) 20 lshift ADC-SQR1 bis! ;  \ ADC-SQR1_L    Regular channel sequence  length
: ADC-SQR1_SQ28   ( %XXXXX -- ) 15 lshift ADC-SQR1 bis! ;  \ ADC-SQR1_SQ28    28th conversion in regular  sequence
: ADC-SQR1_SQ27   ( %XXXXX -- ) 10 lshift ADC-SQR1 bis! ;  \ ADC-SQR1_SQ27    27th conversion in regular  sequence
: ADC-SQR1_SQ26   ( %XXXXX -- ) 5 lshift ADC-SQR1 bis! ;  \ ADC-SQR1_SQ26    26th conversion in regular  sequence
: ADC-SQR1_SQ25   ( %XXXXX -- ) 0 lshift ADC-SQR1 bis! ;  \ ADC-SQR1_SQ25    25th conversion in regular  sequence

\ ADC-SQR2 (read-write)
: ADC-SQR2_SQ24   ( %XXXXX -- ) 25 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ24    24th conversion in regular  sequence
: ADC-SQR2_SQ23   ( %XXXXX -- ) 20 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ23    23rd conversion in regular  sequence
: ADC-SQR2_SQ22   ( %XXXXX -- ) 15 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ22    22nd conversion in regular  sequence
: ADC-SQR2_SQ21   ( %XXXXX -- ) 10 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ21    21st conversion in regular  sequence
: ADC-SQR2_SQ20   ( %XXXXX -- ) 5 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ20    20th conversion in regular  sequence
: ADC-SQR2_SQ19   ( %XXXXX -- ) 0 lshift ADC-SQR2 bis! ;  \ ADC-SQR2_SQ19    19th conversion in regular  sequence

\ ADC-SQR3 (read-write)
: ADC-SQR3_SQ18   ( %XXXXX -- ) 25 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ18    18th conversion in regular  sequence
: ADC-SQR3_SQ17   ( %XXXXX -- ) 20 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ17    17th conversion in regular  sequence
: ADC-SQR3_SQ16   ( %XXXXX -- ) 15 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ16    16th conversion in regular  sequence
: ADC-SQR3_SQ15   ( %XXXXX -- ) 10 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ15    15th conversion in regular  sequence
: ADC-SQR3_SQ14   ( %XXXXX -- ) 5 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ14    14th conversion in regular  sequence
: ADC-SQR3_SQ13   ( %XXXXX -- ) 0 lshift ADC-SQR3 bis! ;  \ ADC-SQR3_SQ13    13th conversion in regular  sequence

\ ADC-SQR4 (read-write)
: ADC-SQR4_SQ12   ( %XXXXX -- ) 25 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ12    12th conversion in regular  sequence
: ADC-SQR4_SQ11   ( %XXXXX -- ) 20 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ11    11th conversion in regular  sequence
: ADC-SQR4_SQ10   ( %XXXXX -- ) 15 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ10    10th conversion in regular  sequence
: ADC-SQR4_SQ9   ( %XXXXX -- ) 10 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ9    9th conversion in regular  sequence
: ADC-SQR4_SQ8   ( %XXXXX -- ) 5 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ8    8th conversion in regular  sequence
: ADC-SQR4_SQ7   ( %XXXXX -- ) 0 lshift ADC-SQR4 bis! ;  \ ADC-SQR4_SQ7    7th conversion in regular  sequence

\ ADC-SQR5 (read-write)
: ADC-SQR5_SQ6   ( %XXXXX -- ) 25 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ6    6th conversion in regular  sequence
: ADC-SQR5_SQ5   ( %XXXXX -- ) 20 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ5    5th conversion in regular  sequence
: ADC-SQR5_SQ4   ( %XXXXX -- ) 15 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ4    4th conversion in regular  sequence
: ADC-SQR5_SQ3   ( %XXXXX -- ) 10 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ3    3rd conversion in regular  sequence
: ADC-SQR5_SQ2   ( %XXXXX -- ) 5 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ2    2nd conversion in regular  sequence
: ADC-SQR5_SQ1   ( %XXXXX -- ) 0 lshift ADC-SQR5 bis! ;  \ ADC-SQR5_SQ1    1st conversion in regular  sequence

\ ADC-JSQR (read-write)
: ADC-JSQR_JL   ( %XX -- ) 20 lshift ADC-JSQR bis! ;  \ ADC-JSQR_JL    Injected sequence length
: ADC-JSQR_JSQ4   ( %XXXXX -- ) 15 lshift ADC-JSQR bis! ;  \ ADC-JSQR_JSQ4    4th conversion in injected  sequence
: ADC-JSQR_JSQ3   ( %XXXXX -- ) 10 lshift ADC-JSQR bis! ;  \ ADC-JSQR_JSQ3    3rd conversion in injected  sequence
: ADC-JSQR_JSQ2   ( %XXXXX -- ) 5 lshift ADC-JSQR bis! ;  \ ADC-JSQR_JSQ2    2nd conversion in injected  sequence
: ADC-JSQR_JSQ1   ( %XXXXX -- ) 0 lshift ADC-JSQR bis! ;  \ ADC-JSQR_JSQ1    1st conversion in injected  sequence

\ ADC-JDR1 (read-only)
: ADC-JDR1_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-JDR1 bis! ;  \ ADC-JDR1_JDATA    Injected data

\ ADC-JDR2 (read-only)
: ADC-JDR2_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-JDR2 bis! ;  \ ADC-JDR2_JDATA    Injected data

\ ADC-JDR3 (read-only)
: ADC-JDR3_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-JDR3 bis! ;  \ ADC-JDR3_JDATA    Injected data

\ ADC-JDR4 (read-only)
: ADC-JDR4_JDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-JDR4 bis! ;  \ ADC-JDR4_JDATA    Injected data

\ ADC-DR (read-only)
: ADC-DR_RegularDATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC-DR bis! ;  \ ADC-DR_RegularDATA    Regular data

\ ADC-SMPR0 (read-write)
: ADC-SMPR0_SampletimebitsSMPx_x   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift ADC-SMPR0 bis! ;  \ ADC-SMPR0_SampletimebitsSMPx_x    Reserved

\ NVIC-ICTR (read-only)
: NVIC-ICTR_INTLINESNUM   ( %XXXX -- ) 0 lshift NVIC-ICTR bis! ;  \ NVIC-ICTR_INTLINESNUM    Total number of interrupt lines in  groups

\ NVIC-STIR (write-only)
: NVIC-STIR_INTID   ( %XXXXXXXXX -- ) 0 lshift NVIC-STIR bis! ;  \ NVIC-STIR_INTID    interrupt to be triggered

\ NVIC-ISER0 (read-write)
: NVIC-ISER0_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER0 bis! ;  \ NVIC-ISER0_SETENA    SETENA

\ NVIC-ISER1 (read-write)
: NVIC-ISER1_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISER1 bis! ;  \ NVIC-ISER1_SETENA    SETENA

\ NVIC-ICER0 (read-write)
: NVIC-ICER0_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER0 bis! ;  \ NVIC-ICER0_CLRENA    CLRENA

\ NVIC-ICER1 (read-write)
: NVIC-ICER1_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICER1 bis! ;  \ NVIC-ICER1_CLRENA    CLRENA

\ NVIC-ISPR0 (read-write)
: NVIC-ISPR0_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR0 bis! ;  \ NVIC-ISPR0_SETPEND    SETPEND

\ NVIC-ISPR1 (read-write)
: NVIC-ISPR1_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ISPR1 bis! ;  \ NVIC-ISPR1_SETPEND    SETPEND

\ NVIC-ICPR0 (read-write)
: NVIC-ICPR0_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR0 bis! ;  \ NVIC-ICPR0_CLRPEND    CLRPEND

\ NVIC-ICPR1 (read-write)
: NVIC-ICPR1_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-ICPR1 bis! ;  \ NVIC-ICPR1_CLRPEND    CLRPEND

\ NVIC-IABR0 (read-only)
: NVIC-IABR0_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR0 bis! ;  \ NVIC-IABR0_ACTIVE    ACTIVE

\ NVIC-IABR1 (read-only)
: NVIC-IABR1_ACTIVE   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC-IABR1 bis! ;  \ NVIC-IABR1_ACTIVE    ACTIVE

\ NVIC-IPR0 (read-write)
: NVIC-IPR0_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N0    IPR_N0
: NVIC-IPR0_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N1    IPR_N1
: NVIC-IPR0_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N2    IPR_N2
: NVIC-IPR0_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR0 bis! ;  \ NVIC-IPR0_IPR_N3    IPR_N3

\ NVIC-IPR1 (read-write)
: NVIC-IPR1_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N0    IPR_N0
: NVIC-IPR1_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N1    IPR_N1
: NVIC-IPR1_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N2    IPR_N2
: NVIC-IPR1_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR1 bis! ;  \ NVIC-IPR1_IPR_N3    IPR_N3

\ NVIC-IPR2 (read-write)
: NVIC-IPR2_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N0    IPR_N0
: NVIC-IPR2_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N1    IPR_N1
: NVIC-IPR2_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N2    IPR_N2
: NVIC-IPR2_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR2 bis! ;  \ NVIC-IPR2_IPR_N3    IPR_N3

\ NVIC-IPR3 (read-write)
: NVIC-IPR3_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N0    IPR_N0
: NVIC-IPR3_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N1    IPR_N1
: NVIC-IPR3_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N2    IPR_N2
: NVIC-IPR3_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR3 bis! ;  \ NVIC-IPR3_IPR_N3    IPR_N3

\ NVIC-IPR4 (read-write)
: NVIC-IPR4_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N0    IPR_N0
: NVIC-IPR4_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N1    IPR_N1
: NVIC-IPR4_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N2    IPR_N2
: NVIC-IPR4_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR4 bis! ;  \ NVIC-IPR4_IPR_N3    IPR_N3

\ NVIC-IPR5 (read-write)
: NVIC-IPR5_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N0    IPR_N0
: NVIC-IPR5_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N1    IPR_N1
: NVIC-IPR5_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N2    IPR_N2
: NVIC-IPR5_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR5 bis! ;  \ NVIC-IPR5_IPR_N3    IPR_N3

\ NVIC-IPR6 (read-write)
: NVIC-IPR6_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N0    IPR_N0
: NVIC-IPR6_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N1    IPR_N1
: NVIC-IPR6_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N2    IPR_N2
: NVIC-IPR6_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR6 bis! ;  \ NVIC-IPR6_IPR_N3    IPR_N3

\ NVIC-IPR7 (read-write)
: NVIC-IPR7_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N0    IPR_N0
: NVIC-IPR7_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N1    IPR_N1
: NVIC-IPR7_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N2    IPR_N2
: NVIC-IPR7_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR7 bis! ;  \ NVIC-IPR7_IPR_N3    IPR_N3

\ NVIC-IPR8 (read-write)
: NVIC-IPR8_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N0    IPR_N0
: NVIC-IPR8_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N1    IPR_N1
: NVIC-IPR8_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N2    IPR_N2
: NVIC-IPR8_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR8 bis! ;  \ NVIC-IPR8_IPR_N3    IPR_N3

\ NVIC-IPR9 (read-write)
: NVIC-IPR9_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N0    IPR_N0
: NVIC-IPR9_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N1    IPR_N1
: NVIC-IPR9_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N2    IPR_N2
: NVIC-IPR9_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR9 bis! ;  \ NVIC-IPR9_IPR_N3    IPR_N3

\ NVIC-IPR10 (read-write)
: NVIC-IPR10_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N0    IPR_N0
: NVIC-IPR10_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N1    IPR_N1
: NVIC-IPR10_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N2    IPR_N2
: NVIC-IPR10_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR10 bis! ;  \ NVIC-IPR10_IPR_N3    IPR_N3

\ NVIC-IPR11 (read-write)
: NVIC-IPR11_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N0    IPR_N0
: NVIC-IPR11_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N1    IPR_N1
: NVIC-IPR11_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N2    IPR_N2
: NVIC-IPR11_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR11 bis! ;  \ NVIC-IPR11_IPR_N3    IPR_N3

\ NVIC-IPR12 (read-write)
: NVIC-IPR12_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N0    IPR_N0
: NVIC-IPR12_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N1    IPR_N1
: NVIC-IPR12_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N2    IPR_N2
: NVIC-IPR12_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR12 bis! ;  \ NVIC-IPR12_IPR_N3    IPR_N3

\ NVIC-IPR13 (read-write)
: NVIC-IPR13_IPR_N0   ( %XXXXXXXX -- ) 0 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N0    IPR_N0
: NVIC-IPR13_IPR_N1   ( %XXXXXXXX -- ) 8 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N1    IPR_N1
: NVIC-IPR13_IPR_N2   ( %XXXXXXXX -- ) 16 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N2    IPR_N2
: NVIC-IPR13_IPR_N3   ( %XXXXXXXX -- ) 24 lshift NVIC-IPR13 bis! ;  \ NVIC-IPR13_IPR_N3    IPR_N3

\ DBG-DBGMCU_IDCODE (read-only)
: DBG-DBGMCU_IDCODE_DEV_ID   ( %XXXXXXXXXXX -- ) 0 lshift DBG-DBGMCU_IDCODE bis! ;  \ DBG-DBGMCU_IDCODE_DEV_ID    DEV_ID
: DBG-DBGMCU_IDCODE_REV_ID   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift DBG-DBGMCU_IDCODE bis! ;  \ DBG-DBGMCU_IDCODE_REV_ID    REV_ID

\ DBG-DBGMCU_CR (read-write)
: DBG-DBGMCU_CR_DBG_SLEEP   %1 0 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_SLEEP    DBG_SLEEP
: DBG-DBGMCU_CR_DBG_STOP   %1 1 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_STOP    DBG_STOP
: DBG-DBGMCU_CR_DBG_STANDBY   %1 2 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_STANDBY    DBG_STANDBY
: DBG-DBGMCU_CR_TRACE_IOEN   %1 5 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_TRACE_IOEN    TRACE_IOEN
: DBG-DBGMCU_CR_TRACE_MODE   ( %XX -- ) 6 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_TRACE_MODE    TRACE_MODE
: DBG-DBGMCU_CR_DBG_I2C2_SMBUS_TIMEOUT   %1 16 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_I2C2_SMBUS_TIMEOUT    DBG_I2C2_SMBUS_TIMEOUT
: DBG-DBGMCU_CR_DBG_TIM8_STOP   %1 17 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_TIM8_STOP    DBG_TIM8_STOP
: DBG-DBGMCU_CR_DBG_TIM5_STOP   %1 18 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_TIM5_STOP    DBG_TIM5_STOP
: DBG-DBGMCU_CR_DBG_TIM6_STOP   %1 19 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_TIM6_STOP    DBG_TIM6_STOP
: DBG-DBGMCU_CR_DBG_TIM7_STOP   %1 20 lshift DBG-DBGMCU_CR bis! ;  \ DBG-DBGMCU_CR_DBG_TIM7_STOP    DBG_TIM7_STOP

\ DBG-DBGMCU_APB1_FZ (read-write)
: DBG-DBGMCU_APB1_FZ_DBG_TIM2_STOP   %1 0 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM2_STOP    DBG_TIM2_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM3_STOP   %1 1 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM3_STOP    DBG_TIM3 _STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM4_STOP   %1 2 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM4_STOP    DBG_TIM4_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM5_STOP   %1 3 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM5_STOP    DBG_TIM5_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM6_STOP   %1 4 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM6_STOP    DBG_TIM6_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM7_STOP   %1 5 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM7_STOP    DBG_TIM7_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM12_STOP   %1 6 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM12_STOP    DBG_TIM12_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM13_STOP   %1 7 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM13_STOP    DBG_TIM13_STOP
: DBG-DBGMCU_APB1_FZ_DBG_TIM14_STOP   %1 8 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_TIM14_STOP    DBG_TIM14_STOP
: DBG-DBGMCU_APB1_FZ_DBG_WWDG_STOP   %1 11 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_WWDG_STOP    DBG_WWDG_STOP
: DBG-DBGMCU_APB1_FZ_DBG_IWDEG_STOP   %1 12 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_IWDEG_STOP    DBG_IWDEG_STOP
: DBG-DBGMCU_APB1_FZ_DBG_J2C1_SMBUS_TIMEOUT   %1 21 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_J2C1_SMBUS_TIMEOUT    DBG_J2C1_SMBUS_TIMEOUT
: DBG-DBGMCU_APB1_FZ_DBG_J2C2_SMBUS_TIMEOUT   %1 22 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_J2C2_SMBUS_TIMEOUT    DBG_J2C2_SMBUS_TIMEOUT
: DBG-DBGMCU_APB1_FZ_DBG_J2C3SMBUS_TIMEOUT   %1 23 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_J2C3SMBUS_TIMEOUT    DBG_J2C3SMBUS_TIMEOUT
: DBG-DBGMCU_APB1_FZ_DBG_CAN1_STOP   %1 25 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_CAN1_STOP    DBG_CAN1_STOP
: DBG-DBGMCU_APB1_FZ_DBG_CAN2_STOP   %1 26 lshift DBG-DBGMCU_APB1_FZ bis! ;  \ DBG-DBGMCU_APB1_FZ_DBG_CAN2_STOP    DBG_CAN2_STOP

\ DBG-DBGMCU_APB2_FZ (read-write)
: DBG-DBGMCU_APB2_FZ_DBG_TIM1_STOP   %1 0 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM1_STOP    TIM1 counter stopped when core is  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM8_STOP   %1 1 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM8_STOP    TIM8 counter stopped when core is  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM9_STOP   %1 16 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM9_STOP    TIM9 counter stopped when core is  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM10_STOP   %1 17 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM10_STOP    TIM10 counter stopped when core is  halted
: DBG-DBGMCU_APB2_FZ_DBG_TIM11_STOP   %1 18 lshift DBG-DBGMCU_APB2_FZ bis! ;  \ DBG-DBGMCU_APB2_FZ_DBG_TIM11_STOP    TIM11 counter stopped when core is  halted
