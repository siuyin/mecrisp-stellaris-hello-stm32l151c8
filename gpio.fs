\ gpio.fs defines GPIO related constants

$40020400 constant GPIOB ( General-purpose I/Os ) 
GPIOB $0 + constant GPIOB-MODER ( GPIO port mode register ) 
GPIOB $18 + constant GPIOB-BSRR ( GPIO port bit set/reset  register ) 

$40020000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA-MODER ( GPIO port mode register ) 
GPIOA $C + constant GPIOA-PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOA $10 + constant GPIOA-IDR ( GPIO port input data register ) 
GPIOA $20 + constant GPIOA-AFRL ( AFRL ) 
