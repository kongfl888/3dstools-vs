# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_MICRO, None
0x83,0x00,0x00,0x38 = sll $4, $3, 7
0x65,0x00,0x10,0x10 = sllv $2, $3, $5
0x83,0x00,0x80,0x38 = sra $4, $3, 7
0x65,0x00,0x90,0x10 = srav $2, $3, $5
0x83,0x00,0x40,0x38 = srl $4, $3, 7
0x65,0x00,0x50,0x10 = srlv $2, $3, $5
0x26,0x01,0xc0,0x38 = rotr $9, $6, 7
0xc7,0x00,0xd0,0x48 = rotrv $9, $6, $7
