O1276(REF*P06U OP10)
(NUM-PLAN*A21131) 
(PHASE*OP10)

#900=94(VALEUR ORIGINE OP10)
M98P9023(CALCUL G30)

M98P9025

M98P9026(M503)

#905=276
(TEST)
(TEST)
(M98P8900)(EFFORTS DE COUPE)

(EFFORTS DE COUPE)
M378A900 (CHARGE EN CRETE)
M376A58 (NIVEAU DE DETECTION)
M377A10 (TEMPS 0.5S)
M379A1 (TABLE)
M371A701 (AXE Z TABLE 1)
M375 (TYPE ARRET BROCHE ET AVANCE)

M378A900
M376A20
M377A10
M379A2
M371A702
M375

G30U0W0
G50S2600
M202
M01

G53.5Z#900

N4
#840=0404.00
T#840(PERCAGE D27)
M98P9027
M371A702
G40G80G99G97S1179M3
G53.5Z#900
G0X0.2Z6M8
G1Z-5F.1
Z-50F.14
Z-54F.1
X0.
G0Z6
G30U0W0
M372
M5
M01

N1
#840=0101.00
T#840(DRESSAGE+CH)
M98P9027
M371A701
G40G80G99G96S220M4
G53.5Z#900
G0X82Z5M8
G1Z-1F.3
X85
G0Z2.2
G1X25F.25
Z3
G0X85
Z1.2
G1X25F.25
Z3
G0X85
Z.1
G1X25F.25
Z2
G0X85
G71U2R1
G71P100Q200U.8W.1F.3
N100G0X75
G1Z.05
X79,R1.5
Z-12
X79.5
Z-29
N200X85
G0G40Z5
G30U0W0
M5
M01

N5
#840=0505.00
T#840(EBAUCHE GORGE EXT)
M98P9027
G40G80G99G96S150M4
G53.5Z#900
G0X82Z2M8
G1Z-21.3F2.

G75R.5
G75X64.8Z-19.6P1.5Q3.5F.12

G1Z-12.5F2.
G75X75.3Z-7.3P1.5Q3.5F.12

G0Z5
G30U0W0
M5
M01

N3
#840=0303.00
T#840(FINI DRESSAGE+CH)
M98P9027
G40G80G99G96S260M4
G53.5Z#900
G0X82Z0M8
G1X55F.24
Z2
G0X85
G42
G70P100Q200F.18
G40
G0Z5
G30U0W0
M5
M01

N4
#840=0404.00
T#840(FIN GORGE 064.5 BAS)
M98P9027
G40G80G99G96S260M4
G53.5Z#900
G0X82Z2M8
G1Z-22.7F2.
X80.6F.1
X78.6Z-21.7F.05
X64.5
G0X80.6Z-21
Z-17.25
G1X78.6Z-18.25F.05
X64.45F.1
X64.45Z-21.7F.12
G0X82Z-21
Z5
G30U0W0
M5
M01

N44
#840=0404.01
T#840(FIN GORGE 075.)
(M98P9027)
G40G80G99G96S260M4
G53.5Z#900
G0X82Z2M8
G1Z-13.85F2.
X80.6F.1
X78.6Z-12.85F.05
X74.97
G0X80.1Z-12
Z-5
G1X78.1Z-6F.05
X74.955F.1
X74.955Z-12.85F.12
G0X82Z-12
Z5
G30U0W0
M5
M01

N9
#840=0909.00
T#840(EBAU 0INT)
M98P9027
G40G80G99G96S240M4
G53.5Z#900
G0X27Z2M8
G71U1.6R1
G71P300Q310U-.5W.1F.22
N300G0X63
G1Z.1
X58.5,R1
Z-5.5
X28.045,R1
Z-51
N310X26
G0G40Z5
G30U0W0
M5
M01

N99
#840=0909.00
T#840(FINITION 0INT)
M98P9027
G40G80G99G96S240M4
G53.5Z#900
G0X27Z2M8
G41
G70P300Q310F.18

G0G40Z5
G30U0W0
M5
M01

#904=#905

M30(END)





%
