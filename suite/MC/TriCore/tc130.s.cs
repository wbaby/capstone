# CS_ARCH_TRICORE, CS_MODE_TRICORE_130, None
0x0b, 0x00, 0xc0, 0x01 = abs %d0, %d0
0x0b, 0x00, 0xc0, 0x05 = abs.b %d0, %d0
0x0b, 0x00, 0xc0, 0x07 = abs.h %d0, %d0
0x0b, 0x00, 0xe0, 0x00 = absdif %d0, %d0, %d0
0x8b, 0x00, 0xc0, 0x01 = absdif %d0, %d0, 0
0x0b, 0x00, 0xe0, 0x04 = absdif.b %d0, %d0, %d0
0x0b, 0x00, 0xe0, 0x06 = absdif.h %d0, %d0, %d0
0x0b, 0x00, 0xf0, 0x00 = absdifs %d0, %d0, %d0
0x8b, 0x00, 0xe0, 0x01 = absdifs %d0, %d0, 0
0x0b, 0x00, 0xf0, 0x06 = absdifs.h %d0, %d0, %d0
0x0b, 0x00, 0xd0, 0x01 = abss %d0, %d0
0x0b, 0x00, 0xd0, 0x07 = abss.h %d0, %d0
0x12, 0x00 = add %d0, %d15, %d0
0x92, 0x00 = add %d0, %d15, 0
0x1a, 0x00 = add %d15, %d0, %d0
0x42, 0x00 = add %d0, %d0
0x9a, 0x00 = add %d15, %d0, 0
0xc2, 0x00 = add %d0, 0
0x0b, 0x00, 0x00, 0x00 = add %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x00 = add %d0, %d0, 0
0x30, 0x00 = add.a %a0, %a0
0xb0, 0x00 = add.a %a0, 0
0x01, 0x00, 0x10, 0x00 = add.a %a0, %a0, %a0
0x0b, 0x00, 0x00, 0x04 = add.b %d0, %d0, %d0
0x6b, 0x00, 0x21, 0x00 = add.f %d0, %d0, %d0
0x0b, 0x00, 0x00, 0x06 = add.h %d0, %d0, %d0
0x0b, 0x00, 0x50, 0x00 = addc %d0, %d0, %d0
0x8b, 0x00, 0xa0, 0x00 = addc %d0, %d0, 0
0x1b, 0x00, 0x00, 0x00 = addi %d0, %d0, 0
0x9b, 0x00, 0x00, 0x00 = addih %d0, %d0, 0
0x11, 0x00, 0x00, 0x00 = addih.a %a0, %a0, 0
0x22, 0x00 = adds %d0, %d0
0x0b, 0x00, 0x20, 0x00 = adds %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x00 = adds %d0, %d0, 0
0x0b, 0x00, 0x20, 0x06 = adds.h %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x06 = adds.hu %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x00 = adds.u %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x00 = adds.u %d0, %d0, 0
0x10, 0x00 = addsc.a %a0, %a0, %d15, 0
0x01, 0x00, 0x00, 0x06 = addsc.a %a0, %a0, %d0, 0
0x01, 0x00, 0x20, 0x06 = addsc.at %a0, %a0, %d0
0x0b, 0x00, 0x40, 0x00 = addx %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x00 = addx %d0, %d0, 0
0x26, 0x00 = and %d0, %d0
0x16, 0x00 = and %d15, 0
0x0f, 0x00, 0x80, 0x00 = and %d0, %d0, %d0
0x8f, 0x00, 0x00, 0x01 = and %d0, %d0, 0
0x47, 0x00, 0x00, 0x00 = and.and.t %d0, %d0, 0, %d0, 0
0x47, 0x00, 0x60, 0x00 = and.andn.t %d0, %d0, 0, %d0, 0
0x0b, 0x00, 0x00, 0x02 = and.eq %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x04 = and.eq %d0, %d0, 0
0x0b, 0x00, 0x40, 0x02 = and.ge %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x04 = and.ge %d0, %d0, 0
0x0b, 0x00, 0x50, 0x02 = and.ge.u %d0, %d0, %d0
0x8b, 0x00, 0xa0, 0x04 = and.ge.u %d0, %d0, 0
0x0b, 0x00, 0x20, 0x02 = and.lt %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x04 = and.lt %d0, %d0, 0
0x0b, 0x00, 0x30, 0x02 = and.lt.u %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x04 = and.lt.u %d0, %d0, 0
0x0b, 0x00, 0x10, 0x02 = and.ne %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x04 = and.ne %d0, %d0, 0
0x47, 0x00, 0x40, 0x00 = and.nor.t %d0, %d0, 0, %d0, 0
0x47, 0x00, 0x20, 0x00 = and.or.t %d0, %d0, 0, %d0, 0
0x87, 0x00, 0x00, 0x00 = and.t %d0, %d0, 0, %d0, 0
0x0f, 0x00, 0xe0, 0x00 = andn %d0, %d0, %d0
0x8f, 0x00, 0xc0, 0x01 = andn %d0, %d0, 0
0x87, 0x00, 0x60, 0x00 = andn.t %d0, %d0, 0, %d0, 0
0xe0, 0x00 = bisr 0
0xad, 0x00, 0x00, 0x00 = bisr 0
0x4b, 0x00, 0x10, 0x00 = bmerge %d0, %d0, %d0
0x4b, 0x00, 0x90, 0x00 = bsplit %e0, %d0
0x89, 0x00, 0x80, 0x03 = cachea.i [%a0+]0
0xa9, 0x00, 0x80, 0x03 = cachea.i [%p0+r]
0x89, 0x00, 0x80, 0x07 = cachea.i [+%a0]0
0xa9, 0x00, 0x80, 0x07 = cachea.i [%p0+c]0
0x89, 0x00, 0x80, 0x0b = cachea.i [%a0]0
0x89, 0x00, 0x00, 0x03 = cachea.w [%a0+]0
0xa9, 0x00, 0x00, 0x03 = cachea.w [%p0+r]
0x89, 0x00, 0x00, 0x07 = cachea.w [+%a0]0
0xa9, 0x00, 0x00, 0x07 = cachea.w [%p0+c]0
0x89, 0x00, 0x00, 0x0b = cachea.w [%a0]0
0x89, 0x00, 0x40, 0x03 = cachea.wi [%a0+]0
0xa9, 0x00, 0x40, 0x03 = cachea.wi [%p0+r]
0x89, 0x00, 0x40, 0x07 = cachea.wi [+%a0]0
0xa9, 0x00, 0x40, 0x07 = cachea.wi [%p0+c]0
0x89, 0x00, 0x40, 0x0b = cachea.wi [%a0]0
0x8a, 0x00 = cadd %d0, %d15, 0
0x2b, 0x00, 0x00, 0x00 = cadd %d0, %d0, %d0, %d0
0xab, 0x00, 0x00, 0x00 = cadd %d0, %d0, %d0, 0
0xca, 0x00 = caddn %d0, %d15, 0
0x2b, 0x00, 0x10, 0x00 = caddn %d0, %d0, %d0, %d0
0xab, 0x00, 0x20, 0x00 = caddn %d0, %d0, %d0, 0
0x5c, 0x00 = call 0
0x6d, 0x00, 0x00, 0x00 = call 0
0xed, 0x00, 0x00, 0x00 = calla 0
0x2d, 0x00, 0x00, 0x00 = calli %a0
0x0f, 0x00, 0xc0, 0x01 = clo %d0, %d0
0x0f, 0x00, 0xd0, 0x07 = clo.h %d0, %d0
0x0f, 0x00, 0xd0, 0x01 = cls %d0, %d0
0x0f, 0x00, 0xe0, 0x07 = cls.h %d0, %d0
0x0f, 0x00, 0xb0, 0x01 = clz %d0, %d0
0x0f, 0x00, 0xc0, 0x07 = clz.h %d0, %d0
0x2a, 0x00 = cmov %d0, %d15, %d0
0xaa, 0x00 = cmov %d0, %d15, 0
0x6a, 0x00 = cmovn %d0, %d15, %d0
0xea, 0x00 = cmovn %d0, %d15, 0
0x4b, 0x00, 0x00, 0x00 = cmp.f %d0, %d0, %d0
0x2b, 0x00, 0x20, 0x00 = csub %d0, %d0, %d0, %d0
0x2b, 0x00, 0x30, 0x00 = csubn %d0, %d0, %d0, %d0
0x00, 0xa0 = debug
0x0d, 0x00, 0x00, 0x01 = debug
0x77, 0x00, 0x00, 0x00 = dextr %d0, %d0, %d0, 0
0x17, 0x00, 0x80, 0x00 = dextr %d0, %d0, %d0, %d0
0x0d, 0x00, 0x40, 0x03 = disable
0x4b, 0x00, 0x51, 0x00 = div.f %d0, %d0, %d0
0x0d, 0x00, 0x80, 0x04 = dsync
0x6b, 0x00, 0xd0, 0x00 = dvadj %e0, %e0, %d0
0x4b, 0x00, 0xa0, 0x01 = dvinit %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x05 = dvinit.b %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x04 = dvinit.bu %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x03 = dvinit.h %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x02 = dvinit.hu %e0, %d0, %d0
0x4b, 0x00, 0xa0, 0x00 = dvinit.u %e0, %d0, %d0
0x6b, 0x00, 0xf0, 0x00 = dvstep %e0, %e0, %d0
0x6b, 0x00, 0xe0, 0x00 = dvstep.u %e0, %e0, %d0
0x0d, 0x00, 0x00, 0x03 = enable
0x3a, 0x00 = eq %d15, %d0, %d0
0xba, 0x00 = eq %d15, %d0, 0
0x0b, 0x00, 0x00, 0x01 = eq %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x02 = eq %d0, %d0, 0
0x01, 0x00, 0x00, 0x04 = eq.a %d0, %a0, %a0
0x0b, 0x00, 0x00, 0x05 = eq.b %d0, %d0, %d0
0x0b, 0x00, 0x00, 0x07 = eq.h %d0, %d0, %d0
0x0b, 0x00, 0x00, 0x09 = eq.w %d0, %d0, %d0
0x0b, 0x00, 0x60, 0x05 = eqany.b %d0, %d0, %d0
0x8b, 0x00, 0xc0, 0x0a = eqany.b %d0, %d0, 0
0x0b, 0x00, 0x60, 0x07 = eqany.h %d0, %d0, %d0
0x8b, 0x00, 0xc0, 0x0e = eqany.h %d0, %d0, 0
0x01, 0x00, 0x80, 0x04 = eqz.a %d0, %a0
0x17, 0x00, 0x40, 0x00 = extr %d0, %d0, %e0
0x37, 0x00, 0x40, 0x00 = extr %d0, %d0, 0, 0
0x57, 0x00, 0x40, 0x00 = extr %d0, %d0, %d0, 0
0x17, 0x00, 0x60, 0x00 = extr.u %d0, %d0, %e0
0x37, 0x00, 0x60, 0x00 = extr.u %d0, %d0, 0, 0
0x57, 0x00, 0x60, 0x00 = extr.u %d0, %d0, %d0, 0
0x4b, 0x00, 0x01, 0x01 = ftoi %d0, %d0
0x4b, 0x00, 0x11, 0x01 = ftoq31 %d0, %d0, %d0
0x4b, 0x00, 0x21, 0x01 = ftou %d0, %d0
0x0b, 0x00, 0x40, 0x01 = ge %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x02 = ge %d0, %d0, 0
0x01, 0x00, 0x30, 0x04 = ge.a %d0, %a0, %a0
0x0b, 0x00, 0x50, 0x01 = ge.u %d0, %d0, %d0
0x8b, 0x00, 0xa0, 0x02 = ge.u %d0, %d0, 0
0x37, 0x00, 0x20, 0x00 = imask %e0, %d0, 0, 0
0x57, 0x00, 0x20, 0x00 = imask %e0, %d0, %d0, 0
0xb7, 0x00, 0x20, 0x00 = imask %e0, 0, 0, 0
0xd7, 0x00, 0x20, 0x00 = imask %e0, 0, %d0, 0
0x67, 0x00, 0x00, 0x00 = ins.t %d0, %d0, 0, %d0, 0
0x17, 0x00, 0x00, 0x00 = insert %d0, %d0, %d0, %e0
0x37, 0x00, 0x00, 0x00 = insert %d0, %d0, %d0, 0, 0
0x57, 0x00, 0x00, 0x00 = insert %d0, %d0, %d0, %d0, 0
0x97, 0x00, 0x00, 0x00 = insert %d0, %d0, 0, %e0
0xb7, 0x00, 0x00, 0x00 = insert %d0, %d0, 0, 0, 0
0xd7, 0x00, 0x00, 0x00 = insert %d0, %d0, 0, %d0, 0
0x67, 0x00, 0x20, 0x00 = insn.t %d0, %d0, 0, %d0, 0
0x0d, 0x00, 0xc0, 0x04 = isync
0x4b, 0x00, 0x41, 0x01 = itof %d0, %d0
0x6b, 0x00, 0xa0, 0x00 = ixmax %e0, %e0, %d0
0x6b, 0x00, 0xb0, 0x00 = ixmax.u %e0, %e0, %d0
0x6b, 0x00, 0x80, 0x00 = ixmin %e0, %e0, %d0
0x6b, 0x00, 0x90, 0x00 = ixmin.u %e0, %e0, %d0
0x3c, 0x00 = j 0
0x1d, 0x00, 0x00, 0x00 = j 0
0x9d, 0x00, 0x00, 0x00 = ja 0
0x3e, 0x00 = jeq %d15, %d0, 0
0x1e, 0x00 = jeq %d15, 0, 0
0x5f, 0x00, 0x00, 0x00 = jeq %d0, %d0, 0
0xdf, 0x00, 0x00, 0x00 = jeq %d0, 0, 0
0x7d, 0x00, 0x00, 0x00 = jeq.a %a0, %a0, 0
0x7f, 0x00, 0x00, 0x00 = jge %d0, %d0, 0
0xff, 0x00, 0x00, 0x00 = jge %d0, 0, 0
0x7f, 0x00, 0x00, 0x80 = jge.u %d0, %d0, 0
0xff, 0x00, 0x00, 0x80 = jge.u %d0, 0, 0
0xce, 0x00 = jgez %d0, 0
0x4e, 0x00 = jgtz %d0, 0
0xdc, 0x00 = ji %a0
0x2d, 0x00, 0x30, 0x00 = ji %a0
0x5d, 0x00, 0x00, 0x00 = jl 0
0xdd, 0x00, 0x00, 0x00 = jla 0
0x8e, 0x00 = jlez %d0, 0
0x2d, 0x00, 0x20, 0x00 = jli %a0
0x3f, 0x00, 0x00, 0x00 = jlt %d0, %d0, 0
0xbf, 0x00, 0x00, 0x00 = jlt %d0, 0, 0
0x3f, 0x00, 0x00, 0x80 = jlt.u %d0, %d0, 0
0xbf, 0x00, 0x00, 0x80 = jlt.u %d0, 0, 0
0x0e, 0x00 = jltz %d0, 0
0x7e, 0x00 = jne %d15, %d0, 0
0x5e, 0x00 = jne %d15, 0, 0
0x5f, 0x00, 0x00, 0x80 = jne %d0, %d0, 0
0xdf, 0x00, 0x00, 0x80 = jne %d0, 0, 0
0x7d, 0x00, 0x00, 0x80 = jne.a %a0, %a0, 0
0x1f, 0x00, 0x00, 0x80 = jned %d0, %d0, 0
0x9f, 0x00, 0x00, 0x80 = jned %d0, 0, 0
0x1f, 0x00, 0x00, 0x00 = jnei %d0, %d0, 0
0x9f, 0x00, 0x00, 0x00 = jnei %d0, 0, 0
0xee, 0x00 = jnz %d15, 0
0xf6, 0x00 = jnz %d0, 0
0x7c, 0x00 = jnz.a %a0, 0
0xbd, 0x00, 0x00, 0x80 = jnz.a %a0, 0
0xae, 0x00 = jnz.t %d15, 0, 0
0x6f, 0x00, 0x00, 0x80 = jnz.t %d0, 0, 0
0x6e, 0x00 = jz %d15, 0
0x76, 0x00 = jz %d0, 0
0xbc, 0x00 = jz.a %a0, 0
0xbd, 0x00, 0x00, 0x00 = jz.a %a0, 0
0x2e, 0x00 = jz.t %d15, 0, 0
0x6f, 0x00, 0x00, 0x00 = jz.t %d0, 0, 0
0xd8, 0x00 = ld.a %a15, [%sp]0
0xc8, 0x00 = ld.a %a0, [%a15]0
0xcc, 0x00 = ld.a %a15, [%a0]0
0xc4, 0x00 = ld.a %a0, [%a0+]
0xd4, 0x00 = ld.a %a0, [%a0]
0x99, 0x00, 0x00, 0x00 = ld.a %a0, [%a0]0
0x09, 0x00, 0x80, 0x01 = ld.a %a0, [%a0+]0
0x29, 0x00, 0x80, 0x01 = ld.a %a0, [%p0+r]
0x09, 0x00, 0x80, 0x05 = ld.a %a0, [+%a0]0
0x29, 0x00, 0x80, 0x05 = ld.a %a0, [%p0+c]0
0x85, 0x00, 0x00, 0x08 = ld.a %a0, 0
0x09, 0x00, 0x80, 0x09 = ld.a %a0, [%a0]0
0x05, 0x00, 0x00, 0x00 = ld.b %d0, 0
0x09, 0x00, 0x00, 0x00 = ld.b %d0, [%a0+]0
0x29, 0x00, 0x00, 0x00 = ld.b %d0, [%p0+r]
0x09, 0x00, 0x00, 0x04 = ld.b %d0, [+%a0]0
0x29, 0x00, 0x00, 0x04 = ld.b %d0, [%p0+c]0
0x09, 0x00, 0x00, 0x08 = ld.b %d0, [%a0]0
0x14, 0x00 = ld.bu %d0, [%a0]
0x0c, 0x00 = ld.bu %d15, [%a0]0
0x08, 0x00 = ld.bu %d0, [%a15]0
0x04, 0x00 = ld.bu %d0, [%a0+]
0x09, 0x00, 0x40, 0x00 = ld.bu %d0, [%a0+]0
0x29, 0x00, 0x40, 0x00 = ld.bu %d0, [%p0+r]
0x05, 0x00, 0x00, 0x04 = ld.bu %d0, 0
0x09, 0x00, 0x40, 0x04 = ld.bu %d0, [+%a0]0
0x29, 0x00, 0x40, 0x04 = ld.bu %d0, [%p0+c]0
0x09, 0x00, 0x40, 0x08 = ld.bu %d0, [%a0]0
0x09, 0x00, 0x40, 0x01 = ld.d %e0, [%a0+]0
0x29, 0x00, 0x40, 0x01 = ld.d %e0, [%p0+r]
0x85, 0x00, 0x00, 0x04 = ld.d %e0, 0
0x09, 0x00, 0x40, 0x05 = ld.d %e0, [+%a0]0
0x29, 0x00, 0x40, 0x05 = ld.d %e0, [%p0+c]0
0x09, 0x00, 0x40, 0x09 = ld.d %e0, [%a0]0
0x09, 0x00, 0xc0, 0x01 = ld.da %p0, [%a0+]0
0x29, 0x00, 0xc0, 0x01 = ld.da %p0, [%p0+r]
0x09, 0x00, 0xc0, 0x05 = ld.da %p0, [+%a0]0
0x29, 0x00, 0xc0, 0x05 = ld.da %p0, [%p0+c]0
0x09, 0x00, 0xc0, 0x09 = ld.da %p0, [%a0]0
0x85, 0x00, 0x00, 0x0c = ld.da %p0, 0
0x84, 0x00 = ld.h %d0, [%a0+]
0x8c, 0x00 = ld.h %d15, [%a0]0
0x88, 0x00 = ld.h %d0, [%a15]0
0x94, 0x00 = ld.h %d0, [%a0]
0x09, 0x00, 0x80, 0x00 = ld.h %d0, [%a0+]0
0x29, 0x00, 0x80, 0x00 = ld.h %d0, [%p0+r]
0x09, 0x00, 0x80, 0x04 = ld.h %d0, [+%a0]0
0x29, 0x00, 0x80, 0x04 = ld.h %d0, [%p0+c]0
0x05, 0x00, 0x00, 0x08 = ld.h %d0, 0
0x09, 0x00, 0x80, 0x08 = ld.h %d0, [%a0]0
0x09, 0x00, 0xc0, 0x00 = ld.hu %d0, [%a0+]0
0x29, 0x00, 0xc0, 0x00 = ld.hu %d0, [%p0+r]
0x09, 0x00, 0xc0, 0x04 = ld.hu %d0, [+%a0]0
0x29, 0x00, 0xc0, 0x04 = ld.hu %d0, [%p0+c]0
0x09, 0x00, 0xc0, 0x08 = ld.hu %d0, [%a0]0
0x05, 0x00, 0x00, 0x0c = ld.hu %d0, 0
0x45, 0x00, 0x00, 0x00 = ld.q %d0, 0
0x09, 0x00, 0x00, 0x02 = ld.q %d0, [%a0+]0
0x29, 0x00, 0x00, 0x02 = ld.q %d0, [%p0+r]
0x09, 0x00, 0x00, 0x06 = ld.q %d0, [+%a0]0
0x29, 0x00, 0x00, 0x06 = ld.q %d0, [%p0+c]0
0x09, 0x00, 0x00, 0x0a = ld.q %d0, [%a0]0
0x58, 0x00 = ld.w %d15, [%sp]0
0x54, 0x00 = ld.w %d0, [%a0]
0x44, 0x00 = ld.w %d0, [%a0+]
0x4c, 0x00 = ld.w %d15, [%a0]0
0x48, 0x00 = ld.w %d0, [%a15]0
0x19, 0x00, 0x00, 0x00 = ld.w %d0, [%a0]0
0x85, 0x00, 0x00, 0x00 = ld.w %d0, 0
0x09, 0x00, 0x00, 0x01 = ld.w %d0, [%a0+]0
0x29, 0x00, 0x00, 0x01 = ld.w %d0, [%p0+r]
0x09, 0x00, 0x00, 0x05 = ld.w %d0, [+%a0]0
0x29, 0x00, 0x00, 0x05 = ld.w %d0, [%p0+c]0
0x09, 0x00, 0x00, 0x09 = ld.w %d0, [%a0]0
0x15, 0x00, 0x00, 0x08 = ldlcx 0
0x49, 0x00, 0x00, 0x09 = ldlcx [%a0]0
0x49, 0x00, 0x40, 0x00 = ldmst [%a0+]0, %e0
0x69, 0x00, 0x40, 0x00 = ldmst [%p0+r], %e0
0xe5, 0x00, 0x00, 0x04 = ldmst 0, %e0
0x49, 0x00, 0x40, 0x04 = ldmst [+%a0]0, %e0
0x69, 0x00, 0x40, 0x04 = ldmst [%p0+c]0, %e0
0x49, 0x00, 0x40, 0x08 = ldmst [%a0]0, %e0
0x49, 0x00, 0x40, 0x09 = lducx [%a0]0
0x15, 0x00, 0x00, 0x0c = lducx 0
0xc5, 0x00, 0x00, 0x00 = lea %a0, 0
0xd9, 0x00, 0x00, 0x00 = lea %a0, [%a0]0
0x49, 0x00, 0x00, 0x0a = lea %a0, [%a0]0
0xfc, 0x00 = loop %a0, -0x20
0xfd, 0x00, 0x00, 0x00 = loop %a0, 0
0xfd, 0x00, 0x00, 0x80 = loopu 0
0x7a, 0x00 = lt %d15, %d0, %d0
0xfa, 0x00 = lt %d15, %d0, 0
0x0b, 0x00, 0x20, 0x01 = lt %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x02 = lt %d0, %d0, 0
0x01, 0x00, 0x20, 0x04 = lt.a %d0, %a0, %a0
0x0b, 0x00, 0x20, 0x05 = lt.b %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x05 = lt.bu %d0, %d0, %d0
0x0b, 0x00, 0x20, 0x07 = lt.h %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x07 = lt.hu %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x01 = lt.u %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x02 = lt.u %d0, %d0, 0
0x0b, 0x00, 0x20, 0x09 = lt.w %d0, %d0, %d0
0x0b, 0x00, 0x30, 0x09 = lt.wu %d0, %d0, %d0
0x03, 0x00, 0x0a, 0x00 = madd %d0, %d0, %d0, %d0
0x13, 0x00, 0x20, 0x00 = madd %d0, %d0, %d0, 0
0x13, 0x00, 0x60, 0x00 = madd %e0, %e0, %d0, 0
0x03, 0x00, 0x6a, 0x00 = madd %e0, %e0, %d0, %d0
0x6b, 0x00, 0x61, 0x00 = madd.f %d0, %d0, %d0, %d0
0x83, 0x00, 0x60, 0x00 = madd.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x64, 0x00 = madd.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0x68, 0x00 = madd.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0x6c, 0x00 = madd.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x10, 0x00 = madd.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x00, 0x00 = madd.q %d0, %d0, %d0, %d0u, 0
0x43, 0x00, 0x04, 0x00 = madd.q %d0, %d0, %d0, %d0l, 0
0x43, 0x00, 0x08, 0x00 = madd.q %d0, %d0, %d0, %d0, 0
0x43, 0x00, 0x14, 0x00 = madd.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0x60, 0x00 = madd.q %e0, %e0, %d0, %d0u, 0
0x43, 0x00, 0x64, 0x00 = madd.q %e0, %e0, %d0, %d0l, 0
0x43, 0x00, 0x6c, 0x00 = madd.q %e0, %e0, %d0, %d0, 0
0x43, 0x00, 0x70, 0x00 = madd.q %e0, %e0, %d0u, %d0u, 0
0x43, 0x00, 0x74, 0x00 = madd.q %e0, %e0, %d0l, %d0l, 0
0x13, 0x00, 0x40, 0x00 = madd.u %e0, %e0, %d0, 0
0x03, 0x00, 0x68, 0x00 = madd.u %e0, %e0, %d0, %d0
0x83, 0x00, 0x70, 0x00 = maddm.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x74, 0x00 = maddm.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0x78, 0x00 = maddm.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0x7c, 0x00 = maddm.h %e0, %e0, %d0, %d0uu, 0
0x83, 0x00, 0xf0, 0x00 = maddms.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xf4, 0x00 = maddms.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0xf8, 0x00 = maddms.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0xfc, 0x00 = maddms.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x78, 0x00 = maddr.h %d0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0x30, 0x00 = maddr.h %d0, %d0, %d0, %d0ul, 0
0x83, 0x00, 0x34, 0x00 = maddr.h %d0, %d0, %d0, %d0lu, 0
0x83, 0x00, 0x38, 0x00 = maddr.h %d0, %d0, %d0, %d0ll, 0
0x83, 0x00, 0x3c, 0x00 = maddr.h %d0, %d0, %d0, %d0uu, 0
0x43, 0x00, 0x18, 0x00 = maddr.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x1c, 0x00 = maddr.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0xf8, 0x00 = maddrs.h %d0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xb0, 0x00 = maddrs.h %d0, %d0, %d0, %d0ul, 0
0x83, 0x00, 0xb4, 0x00 = maddrs.h %d0, %d0, %d0, %d0lu, 0
0x83, 0x00, 0xb8, 0x00 = maddrs.h %d0, %d0, %d0, %d0ll, 0
0x83, 0x00, 0xbc, 0x00 = maddrs.h %d0, %d0, %d0, %d0uu, 0
0x43, 0x00, 0x98, 0x00 = maddrs.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x9c, 0x00 = maddrs.q %d0, %d0, %d0l, %d0l, 0
0x03, 0x00, 0x8a, 0x00 = madds %d0, %d0, %d0, %d0
0x13, 0x00, 0xa0, 0x00 = madds %d0, %d0, %d0, 0
0x13, 0x00, 0xe0, 0x00 = madds %e0, %e0, %d0, 0
0x03, 0x00, 0xea, 0x00 = madds %e0, %e0, %d0, %d0
0x83, 0x00, 0xe0, 0x00 = madds.h %e0, %e0, %d0, %d0ul, 0
0x83, 0x00, 0xe4, 0x00 = madds.h %e0, %e0, %d0, %d0lu, 0
0x83, 0x00, 0xe8, 0x00 = madds.h %e0, %e0, %d0, %d0ll, 0
0x83, 0x00, 0xec, 0x00 = madds.h %e0, %e0, %d0, %d0uu, 0
0x43, 0x00, 0x90, 0x00 = madds.q %d0, %d0, %d0u, %d0u, 0
0x43, 0x00, 0x80, 0x00 = madds.q %d0, %d0, %d0, %d0u, 0
0x43, 0x00, 0x84, 0x00 = madds.q %d0, %d0, %d0, %d0l, 0
0x43, 0x00, 0x88, 0x00 = madds.q %d0, %d0, %d0, %d0, 0
0x43, 0x00, 0x94, 0x00 = madds.q %d0, %d0, %d0l, %d0l, 0
0x43, 0x00, 0xe0, 0x00 = madds.q %e0, %e0, %d0, %d0u, 0
0x43, 0x00, 0xe4, 0x00 = madds.q %e0, %e0, %d0, %d0l, 0
0x43, 0x00, 0xec, 0x00 = madds.q %e0, %e0, %d0, %d0, 0
0x43, 0x00, 0xf0, 0x00 = madds.q %e0, %e0, %d0u, %d0u, 0
0x43, 0x00, 0xf4, 0x00 = madds.q %e0, %e0, %d0l, %d0l, 0
0x13, 0x00, 0x80, 0x00 = madds.u %d0, %d0, %d0, 0
0x03, 0x00, 0x88, 0x00 = madds.u %d0, %d0, %d0, %d0
0x13, 0x00, 0xc0, 0x00 = madds.u %e0, %e0, %d0, 0
0x03, 0x00, 0xe8, 0x00 = madds.u %e0, %e0, %d0, %d0
0xc3, 0x00, 0x60, 0x00 = maddsu.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0x64, 0x00 = maddsu.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0x68, 0x00 = maddsu.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0x6c, 0x00 = maddsu.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0x70, 0x00 = maddsum.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0x74, 0x00 = maddsum.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0x78, 0x00 = maddsum.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0x7c, 0x00 = maddsum.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0xf0, 0x00 = maddsums.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0xf4, 0x00 = maddsums.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0xf8, 0x00 = maddsums.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0xfc, 0x00 = maddsums.h %e0, %e0, %d0, %d0uu, 0
0xc3, 0x00, 0x30, 0x00 = maddsur.h %d0, %d0, %d0, %d0ul, 0
0xc3, 0x00, 0x34, 0x00 = maddsur.h %d0, %d0, %d0, %d0lu, 0
0xc3, 0x00, 0x38, 0x00 = maddsur.h %d0, %d0, %d0, %d0ll, 0
0xc3, 0x00, 0x3c, 0x00 = maddsur.h %d0, %d0, %d0, %d0uu, 0
0xc3, 0x00, 0xb0, 0x00 = maddsurs.h %d0, %d0, %d0, %d0ul, 0
0xc3, 0x00, 0xb4, 0x00 = maddsurs.h %d0, %d0, %d0, %d0lu, 0
0xc3, 0x00, 0xb8, 0x00 = maddsurs.h %d0, %d0, %d0, %d0ll, 0
0xc3, 0x00, 0xbc, 0x00 = maddsurs.h %d0, %d0, %d0, %d0uu, 0
0xc3, 0x00, 0xe0, 0x00 = maddsus.h %e0, %e0, %d0, %d0ul, 0
0xc3, 0x00, 0xe4, 0x00 = maddsus.h %e0, %e0, %d0, %d0lu, 0
0xc3, 0x00, 0xe8, 0x00 = maddsus.h %e0, %e0, %d0, %d0ll, 0
0xc3, 0x00, 0xec, 0x00 = maddsus.h %e0, %e0, %d0, %d0uu, 0
0x0b, 0x00, 0xa0, 0x01 = max %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x03 = max %d0, %d0, 0
0x0b, 0x00, 0xa0, 0x05 = max.b %d0, %d0, %d0
0x0b, 0x00, 0xb0, 0x05 = max.bu %d0, %d0, %d0
0x0b, 0x00, 0xa0, 0x07 = max.h %d0, %d0, %d0
0x0b, 0x00, 0xb0, 0x07 = max.hu %d0, %d0, %d0
0x0b, 0x00, 0xb0, 0x01 = max.u %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x03 = max.u %d0, %d0, 0
0x4d, 0x00, 0x00, 0x00 = mfcr %d0, 0
0x0b, 0x00, 0x80, 0x01 = min %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x03 = min %d0, %d0, 0
0x0b, 0x00, 0x80, 0x05 = min.b %d0, %d0, %d0
0x0b, 0x00, 0x90, 0x05 = min.bu %d0, %d0, %d0
0x0b, 0x00, 0x80, 0x07 = min.h %d0, %d0, %d0
0x0b, 0x00, 0x90, 0x07 = min.hu %d0, %d0, %d0
0x0b, 0x00, 0x90, 0x01 = min.u %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x03 = min.u %d0, %d0, 0
0x02, 0x00 = mov %d0, %d0
0x82, 0x00 = mov %d0, 0
0xda, 0x00 = mov %d15, 0
0x3b, 0x00, 0x00, 0x00 = mov %d0, 0
0x0b, 0x00, 0xf0, 0x01 = mov %d0, %d0
0xa0, 0x00 = mov.a %a0, 0
0x60, 0x00 = mov.a %a0, %d0
0x01, 0x00, 0x30, 0x06 = mov.a %a0, %d0
0x40, 0x00 = mov.aa %a0, %a0
0x01, 0x00, 0x00, 0x00 = mov.aa %a0, %a0
0x80, 0x00 = mov.d %d0, %a0
0x01, 0x00, 0xc0, 0x04 = mov.d %d0, %a0
0xbb, 0x00, 0x00, 0x00 = mov.u %d0, 0
0x7b, 0x00, 0x00, 0x00 = movh %d0, 0
0x91, 0x00, 0x00, 0x00 = movh.a %a0, 0
0x23, 0x00, 0x0a, 0x00 = msub %d0, %d0, %d0, %d0
0x33, 0x00, 0x20, 0x00 = msub %d0, %d0, %d0, 0
0x33, 0x00, 0x60, 0x00 = msub %e0, %e0, %d0, 0
0x23, 0x00, 0x6a, 0x00 = msub %e0, %e0, %d0, %d0
0x6b, 0x00, 0x71, 0x00 = msub.f %d0, %d0, %d0, %d0
0xa3, 0x00, 0x60, 0x00 = msub.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x64, 0x00 = msub.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0x68, 0x00 = msub.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0x6c, 0x00 = msub.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x10, 0x00 = msub.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x00, 0x00 = msub.q %d0, %d0, %d0, %d0u, 0
0x63, 0x00, 0x04, 0x00 = msub.q %d0, %d0, %d0, %d0l, 0
0x63, 0x00, 0x08, 0x00 = msub.q %d0, %d0, %d0, %d0, 0
0x63, 0x00, 0x14, 0x00 = msub.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0x60, 0x00 = msub.q %e0, %e0, %d0, %d0u, 0
0x63, 0x00, 0x64, 0x00 = msub.q %e0, %e0, %d0, %d0l, 0
0x63, 0x00, 0x6c, 0x00 = msub.q %e0, %e0, %d0, %d0, 0
0x63, 0x00, 0x70, 0x00 = msub.q %e0, %e0, %d0u, %d0u, 0
0x63, 0x00, 0x74, 0x00 = msub.q %e0, %e0, %d0l, %d0l, 0
0x33, 0x00, 0x40, 0x00 = msub.u %e0, %e0, %d0, 0
0x23, 0x00, 0x68, 0x00 = msub.u %e0, %e0, %d0, %d0
0xe3, 0x00, 0x60, 0x00 = msubad.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0x64, 0x00 = msubad.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0x68, 0x00 = msubad.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0x6c, 0x00 = msubad.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0x70, 0x00 = msubadm.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0x74, 0x00 = msubadm.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0x78, 0x00 = msubadm.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0x7c, 0x00 = msubadm.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0xf0, 0x00 = msubadms.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0xf4, 0x00 = msubadms.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0xf8, 0x00 = msubadms.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0xfc, 0x00 = msubadms.h %e0, %e0, %d0, %d0uu, 0
0xe3, 0x00, 0x30, 0x00 = msubadr.h %d0, %d0, %d0, %d0ul, 0
0xe3, 0x00, 0x34, 0x00 = msubadr.h %d0, %d0, %d0, %d0lu, 0
0xe3, 0x00, 0x38, 0x00 = msubadr.h %d0, %d0, %d0, %d0ll, 0
0xe3, 0x00, 0x3c, 0x00 = msubadr.h %d0, %d0, %d0, %d0uu, 0
0xe3, 0x00, 0xb0, 0x00 = msubadrs.h %d0, %d0, %d0, %d0ul, 0
0xe3, 0x00, 0xb4, 0x00 = msubadrs.h %d0, %d0, %d0, %d0lu, 0
0xe3, 0x00, 0xb8, 0x00 = msubadrs.h %d0, %d0, %d0, %d0ll, 0
0xe3, 0x00, 0xbc, 0x00 = msubadrs.h %d0, %d0, %d0, %d0uu, 0
0xe3, 0x00, 0xe0, 0x00 = msubads.h %e0, %e0, %d0, %d0ul, 0
0xe3, 0x00, 0xe4, 0x00 = msubads.h %e0, %e0, %d0, %d0lu, 0
0xe3, 0x00, 0xe8, 0x00 = msubads.h %e0, %e0, %d0, %d0ll, 0
0xe3, 0x00, 0xec, 0x00 = msubads.h %e0, %e0, %d0, %d0uu, 0
0xa3, 0x00, 0x70, 0x00 = msubm.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x74, 0x00 = msubm.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0x78, 0x00 = msubm.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0x7c, 0x00 = msubm.h %e0, %e0, %d0, %d0uu, 0
0xa3, 0x00, 0xf0, 0x00 = msubms.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xf4, 0x00 = msubms.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0xf8, 0x00 = msubms.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0xfc, 0x00 = msubms.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x78, 0x00 = msubr.h %d0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0x30, 0x00 = msubr.h %d0, %d0, %d0, %d0ul, 0
0xa3, 0x00, 0x34, 0x00 = msubr.h %d0, %d0, %d0, %d0lu, 0
0xa3, 0x00, 0x38, 0x00 = msubr.h %d0, %d0, %d0, %d0ll, 0
0xa3, 0x00, 0x3c, 0x00 = msubr.h %d0, %d0, %d0, %d0uu, 0
0x63, 0x00, 0x18, 0x00 = msubr.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x1c, 0x00 = msubr.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0xf8, 0x00 = msubrs.h %d0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xb0, 0x00 = msubrs.h %d0, %d0, %d0, %d0ul, 0
0xa3, 0x00, 0xb4, 0x00 = msubrs.h %d0, %d0, %d0, %d0lu, 0
0xa3, 0x00, 0xb8, 0x00 = msubrs.h %d0, %d0, %d0, %d0ll, 0
0xa3, 0x00, 0xbc, 0x00 = msubrs.h %d0, %d0, %d0, %d0uu, 0
0x63, 0x00, 0x98, 0x00 = msubrs.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x9c, 0x00 = msubrs.q %d0, %d0, %d0l, %d0l, 0
0x23, 0x00, 0x8a, 0x00 = msubs %d0, %d0, %d0, %d0
0x33, 0x00, 0xa0, 0x00 = msubs %d0, %d0, %d0, 0
0x33, 0x00, 0xe0, 0x00 = msubs %e0, %e0, %d0, 0
0x23, 0x00, 0xea, 0x00 = msubs %e0, %e0, %d0, %d0
0xa3, 0x00, 0xe0, 0x00 = msubs.h %e0, %e0, %d0, %d0ul, 0
0xa3, 0x00, 0xe4, 0x00 = msubs.h %e0, %e0, %d0, %d0lu, 0
0xa3, 0x00, 0xe8, 0x00 = msubs.h %e0, %e0, %d0, %d0ll, 0
0xa3, 0x00, 0xec, 0x00 = msubs.h %e0, %e0, %d0, %d0uu, 0
0x63, 0x00, 0x90, 0x00 = msubs.q %d0, %d0, %d0u, %d0u, 0
0x63, 0x00, 0x80, 0x00 = msubs.q %d0, %d0, %d0, %d0u, 0
0x63, 0x00, 0x84, 0x00 = msubs.q %d0, %d0, %d0, %d0l, 0
0x63, 0x00, 0x88, 0x00 = msubs.q %d0, %d0, %d0, %d0, 0
0x63, 0x00, 0x94, 0x00 = msubs.q %d0, %d0, %d0l, %d0l, 0
0x63, 0x00, 0xe0, 0x00 = msubs.q %e0, %e0, %d0, %d0u, 0
0x63, 0x00, 0xe4, 0x00 = msubs.q %e0, %e0, %d0, %d0l, 0
0x63, 0x00, 0xec, 0x00 = msubs.q %e0, %e0, %d0, %d0, 0
0x63, 0x00, 0xf0, 0x00 = msubs.q %e0, %e0, %d0u, %d0u, 0
0x63, 0x00, 0xf4, 0x00 = msubs.q %e0, %e0, %d0l, %d0l, 0
0x33, 0x00, 0x80, 0x00 = msubs.u %d0, %d0, %d0, 0
0x23, 0x00, 0x88, 0x00 = msubs.u %d0, %d0, %d0, %d0
0x33, 0x00, 0xc0, 0x00 = msubs.u %e0, %e0, %d0, 0
0x23, 0x00, 0xe8, 0x00 = msubs.u %e0, %e0, %d0, %d0
0xcd, 0x00, 0x00, 0x00 = mtcr 0, %d0
0xe2, 0x00 = mul %d0, %d0
0x53, 0x00, 0x20, 0x00 = mul %d0, %d0, 0
0x73, 0x00, 0x0a, 0x00 = mul %d0, %d0, %d0
0x53, 0x00, 0x60, 0x00 = mul %e0, %d0, 0
0x73, 0x00, 0x6a, 0x00 = mul %e0, %d0, %d0
0x4b, 0x00, 0x41, 0x00 = mul.f %d0, %d0, %d0
0xb3, 0x00, 0x60, 0x00 = mul.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0x64, 0x00 = mul.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0x68, 0x00 = mul.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0x6c, 0x00 = mul.h %e0, %d0, %d0uu, 0
0x93, 0x00, 0x00, 0x00 = mul.q %d0, %d0, %d0u, 0
0x93, 0x00, 0x04, 0x00 = mul.q %d0, %d0, %d0l, 0
0x93, 0x00, 0x08, 0x00 = mul.q %d0, %d0, %d0, 0
0x93, 0x00, 0x10, 0x00 = mul.q %d0, %d0u, %d0u, 0
0x93, 0x00, 0x14, 0x00 = mul.q %d0, %d0l, %d0l, 0
0x93, 0x00, 0x60, 0x00 = mul.q %e0, %d0, %d0u, 0
0x93, 0x00, 0x64, 0x00 = mul.q %e0, %d0, %d0l, 0
0x93, 0x00, 0x6c, 0x00 = mul.q %e0, %d0, %d0, 0
0x53, 0x00, 0x40, 0x00 = mul.u %e0, %d0, 0
0x73, 0x00, 0x68, 0x00 = mul.u %e0, %d0, %d0
0xb3, 0x00, 0x70, 0x00 = mulm.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0x74, 0x00 = mulm.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0x78, 0x00 = mulm.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0x7c, 0x00 = mulm.h %e0, %d0, %d0uu, 0
0xb3, 0x00, 0xf0, 0x00 = mulms.h %e0, %d0, %d0ul, 0
0xb3, 0x00, 0xf4, 0x00 = mulms.h %e0, %d0, %d0lu, 0
0xb3, 0x00, 0xf8, 0x00 = mulms.h %e0, %d0, %d0ll, 0
0xb3, 0x00, 0xfc, 0x00 = mulms.h %e0, %d0, %d0uu, 0
0xb3, 0x00, 0x30, 0x00 = mulr.h %d0, %d0, %d0ul, 0
0xb3, 0x00, 0x34, 0x00 = mulr.h %d0, %d0, %d0lu, 0
0xb3, 0x00, 0x38, 0x00 = mulr.h %d0, %d0, %d0ll, 0
0xb3, 0x00, 0x3c, 0x00 = mulr.h %d0, %d0, %d0uu, 0
0x93, 0x00, 0x18, 0x00 = mulr.q %d0, %d0u, %d0u, 0
0x93, 0x00, 0x1c, 0x00 = mulr.q %d0, %d0l, %d0l, 0
0x53, 0x00, 0xa0, 0x00 = muls %d0, %d0, 0
0x73, 0x00, 0x8a, 0x00 = muls %d0, %d0, %d0
0x53, 0x00, 0x80, 0x00 = muls.u %d0, %d0, 0
0x73, 0x00, 0x88, 0x00 = muls.u %d0, %d0, %d0
0x0f, 0x00, 0x90, 0x00 = nand %d0, %d0, %d0
0x8f, 0x00, 0x20, 0x01 = nand %d0, %d0, 0
0x07, 0x00, 0x00, 0x00 = nand.t %d0, %d0, 0, %d0, 0
0x0b, 0x00, 0x10, 0x01 = ne %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x02 = ne %d0, %d0, 0
0x01, 0x00, 0x10, 0x04 = ne.a %d0, %a0, %a0
0x01, 0x00, 0x90, 0x04 = nez.a %d0, %a0
0x00, 0x00 = nop
0x0d, 0x00, 0x00, 0x00 = nop
0x46, 0x00 = nor %d0
0x0f, 0x00, 0xb0, 0x00 = nor %d0, %d0, %d0
0x8f, 0x00, 0x60, 0x01 = nor %d0, %d0, 0
0x87, 0x00, 0x40, 0x00 = nor.t %d0, %d0, 0, %d0, 0
0xa6, 0x00 = or %d0, %d0
0x96, 0x00 = or %d15, 0
0x0f, 0x00, 0xa0, 0x00 = or %d0, %d0, %d0
0x8f, 0x00, 0x40, 0x01 = or %d0, %d0, 0
0xc7, 0x00, 0x00, 0x00 = or.and.t %d0, %d0, 0, %d0, 0
0xc7, 0x00, 0x60, 0x00 = or.andn.t %d0, %d0, 0, %d0, 0
0x0b, 0x00, 0x70, 0x02 = or.eq %d0, %d0, %d0
0x8b, 0x00, 0xe0, 0x04 = or.eq %d0, %d0, 0
0x0b, 0x00, 0xb0, 0x02 = or.ge %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x05 = or.ge %d0, %d0, 0
0x0b, 0x00, 0xc0, 0x02 = or.ge.u %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x05 = or.ge.u %d0, %d0, 0
0x0b, 0x00, 0x90, 0x02 = or.lt %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x05 = or.lt %d0, %d0, 0
0x0b, 0x00, 0xa0, 0x02 = or.lt.u %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x05 = or.lt.u %d0, %d0, 0
0x0b, 0x00, 0x80, 0x02 = or.ne %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x05 = or.ne %d0, %d0, 0
0xc7, 0x00, 0x40, 0x00 = or.nor.t %d0, %d0, 0, %d0, 0
0xc7, 0x00, 0x20, 0x00 = or.or.t %d0, %d0, 0, %d0, 0
0x87, 0x00, 0x20, 0x00 = or.t %d0, %d0, 0, %d0, 0
0x0f, 0x00, 0xf0, 0x00 = orn %d0, %d0, %d0
0x8f, 0x00, 0xe0, 0x01 = orn %d0, %d0, 0
0x07, 0x00, 0x20, 0x00 = orn.t %d0, %d0, 0, %d0, 0
0x6b, 0x00, 0x00, 0x00 = pack %d0, %e0, %d0
0x4b, 0x00, 0x20, 0x00 = parity %d0, %d0
0x4b, 0x00, 0x51, 0x01 = q31tof %d0, %d0, %d0
0x4b, 0x00, 0x91, 0x01 = qseed.f %d0, %d0
0x00, 0x90 = ret
0x0d, 0x00, 0x80, 0x01 = ret
0x00, 0x80 = rfe
0x0d, 0x00, 0xc0, 0x01 = rfe
0x0d, 0x00, 0x40, 0x01 = rfm
0x0d, 0x00, 0x40, 0x02 = rslcx
0x2f, 0x00, 0x00, 0x00 = rstv
0x32, 0x50 = rsub %d0
0x8b, 0x00, 0x00, 0x01 = rsub %d0, %d0, 0
0x8b, 0x00, 0x40, 0x01 = rsubs %d0, %d0, 0
0x8b, 0x00, 0x60, 0x01 = rsubs.u %d0, %d0, 0
0x32, 0x00 = sat.b %d0
0x0b, 0x00, 0xe0, 0x05 = sat.b %d0, %d0
0x32, 0x10 = sat.bu %d0
0x0b, 0x00, 0xf0, 0x05 = sat.bu %d0, %d0
0x32, 0x20 = sat.h %d0
0x0b, 0x00, 0xe0, 0x07 = sat.h %d0, %d0
0x32, 0x30 = sat.hu %d0
0x0b, 0x00, 0xf0, 0x07 = sat.hu %d0, %d0
0x2b, 0x00, 0x40, 0x00 = sel %d0, %d0, %d0, %d0
0xab, 0x00, 0x80, 0x00 = sel %d0, %d0, %d0, 0
0x2b, 0x00, 0x50, 0x00 = seln %d0, %d0, %d0, %d0
0xab, 0x00, 0xa0, 0x00 = seln %d0, %d0, %d0, 0
0x06, 0x00 = sh %d0, 0
0x0f, 0x00, 0x00, 0x00 = sh %d0, %d0, %d0
0x8f, 0x00, 0x00, 0x00 = sh %d0, %d0, 0
0x27, 0x00, 0x00, 0x00 = sh.and.t %d0, %d0, 0, %d0, 0
0x27, 0x00, 0x60, 0x00 = sh.andn.t %d0, %d0, 0, %d0, 0
0x0b, 0x00, 0x70, 0x03 = sh.eq %d0, %d0, %d0
0x8b, 0x00, 0xe0, 0x06 = sh.eq %d0, %d0, 0
0x0b, 0x00, 0xb0, 0x03 = sh.ge %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x07 = sh.ge %d0, %d0, 0
0x0b, 0x00, 0xc0, 0x03 = sh.ge.u %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x07 = sh.ge.u %d0, %d0, 0
0x0f, 0x00, 0x00, 0x04 = sh.h %d0, %d0, %d0
0x8f, 0x00, 0x00, 0x08 = sh.h %d0, %d0, 0
0x0b, 0x00, 0x90, 0x03 = sh.lt %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x07 = sh.lt %d0, %d0, 0
0x0b, 0x00, 0xa0, 0x03 = sh.lt.u %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x07 = sh.lt.u %d0, %d0, 0
0xa7, 0x00, 0x00, 0x00 = sh.nand.t %d0, %d0, 0, %d0, 0
0x0b, 0x00, 0x80, 0x03 = sh.ne %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x07 = sh.ne %d0, %d0, 0
0x27, 0x00, 0x40, 0x00 = sh.nor.t %d0, %d0, 0, %d0, 0
0x27, 0x00, 0x20, 0x00 = sh.or.t %d0, %d0, 0, %d0, 0
0xa7, 0x00, 0x20, 0x00 = sh.orn.t %d0, %d0, 0, %d0, 0
0xa7, 0x00, 0x40, 0x00 = sh.xnor.t %d0, %d0, 0, %d0, 0
0xa7, 0x00, 0x60, 0x00 = sh.xor.t %d0, %d0, 0, %d0, 0
0x86, 0x00 = sha %d0, 0
0x0f, 0x00, 0x10, 0x00 = sha %d0, %d0, %d0
0x8f, 0x00, 0x20, 0x00 = sha %d0, %d0, 0
0x0f, 0x00, 0x10, 0x04 = sha.h %d0, %d0, %d0
0x8f, 0x00, 0x20, 0x08 = sha.h %d0, %d0, 0
0x0f, 0x00, 0x20, 0x00 = shas %d0, %d0, %d0
0x8f, 0x00, 0x40, 0x00 = shas %d0, %d0, 0
0xf8, 0x00 = st.a [%sp]0, %a15
0xec, 0x00 = st.a [%a0]0, %a15
0xe8, 0x00 = st.a [%a15]0, %a0
0xe4, 0x00 = st.a [%a0+], %a0
0xf4, 0x00 = st.a [%a0], %a0
0x89, 0x00, 0x80, 0x01 = st.a [%a0+]0, %a0
0xa9, 0x00, 0x80, 0x01 = st.a [%p0+r], %a0
0x89, 0x00, 0x80, 0x05 = st.a [+%a0]0, %a0
0xa9, 0x00, 0x80, 0x05 = st.a [%p0+c]0, %a0
0xa5, 0x00, 0x00, 0x08 = st.a 0, %a0
0x89, 0x00, 0x80, 0x09 = st.a [%a0]0, %a0
0x34, 0x00 = st.b [%a0], %d0
0x28, 0x00 = st.b [%a15]0, %d0
0x2c, 0x00 = st.b [%a0]0, %d15
0x24, 0x00 = st.b [%a0+], %d0
0x25, 0x00, 0x00, 0x00 = st.b 0, %d0
0x89, 0x00, 0x00, 0x00 = st.b [%a0+]0, %d0
0xa9, 0x00, 0x00, 0x00 = st.b [%p0+r], %d0
0x89, 0x00, 0x00, 0x04 = st.b [+%a0]0, %d0
0xa9, 0x00, 0x00, 0x04 = st.b [%p0+c]0, %d0
0x89, 0x00, 0x00, 0x08 = st.b [%a0]0, %d0
0x89, 0x00, 0x40, 0x01 = st.d [%a0+]0, %e0
0xa9, 0x00, 0x40, 0x01 = st.d [%p0+r], %e0
0xa5, 0x00, 0x00, 0x04 = st.d 0, %e0
0x89, 0x00, 0x40, 0x05 = st.d [+%a0]0, %e0
0xa9, 0x00, 0x40, 0x05 = st.d [%p0+c]0, %e0
0x89, 0x00, 0x40, 0x09 = st.d [%a0]0, %e0
0x89, 0x00, 0xc0, 0x01 = st.da [%a0+]0, %p0
0xa9, 0x00, 0xc0, 0x01 = st.da [%p0+r], %p0
0x89, 0x00, 0xc0, 0x05 = st.da [+%a0]0, %p0
0xa9, 0x00, 0xc0, 0x05 = st.da [%p0+c]0, %p0
0x89, 0x00, 0xc0, 0x09 = st.da [%a0]0, %p0
0xa5, 0x00, 0x00, 0x0c = st.da 0, %p0
0xa4, 0x00 = st.h [%a0+], %d0
0xa8, 0x00 = st.h [%a15]0, %d0
0xac, 0x00 = st.h [%a0]0, %d15
0xb4, 0x00 = st.h [%a0], %d0
0x89, 0x00, 0x80, 0x00 = st.h [%a0+]0, %d0
0xa9, 0x00, 0x80, 0x00 = st.h [%p0+r], %d0
0x89, 0x00, 0x80, 0x04 = st.h [+%a0]0, %d0
0xa9, 0x00, 0x80, 0x04 = st.h [%p0+c]0, %d0
0x25, 0x00, 0x00, 0x08 = st.h 0, %d0
0x89, 0x00, 0x80, 0x08 = st.h [%a0]0, %d0
0x65, 0x00, 0x00, 0x00 = st.q 0, %d0
0x89, 0x00, 0x00, 0x02 = st.q [%a0+]0, %d0
0xa9, 0x00, 0x00, 0x02 = st.q [%p0+r], %d0
0x89, 0x00, 0x00, 0x06 = st.q [+%a0]0, %d0
0xa9, 0x00, 0x00, 0x06 = st.q [%p0+c]0, %d0
0x89, 0x00, 0x00, 0x0a = st.q [%a0]0, %d0
0xd5, 0x00, 0x00, 0x00 = st.t 0, 0, 0
0x78, 0x00 = st.w [%sp]0, %d15
0x74, 0x00 = st.w [%a0], %d0
0x64, 0x00 = st.w [%a0+], %d0
0x68, 0x00 = st.w [%a15]0, %d0
0x6c, 0x00 = st.w [%a0]0, %d15
0x59, 0x00, 0x00, 0x00 = st.w [%a0]0, %d0
0xa5, 0x00, 0x00, 0x00 = st.w 0, %d0
0x89, 0x00, 0x00, 0x01 = st.w [%a0+]0, %d0
0xa9, 0x00, 0x00, 0x01 = st.w [%p0+r], %d0
0x89, 0x00, 0x00, 0x05 = st.w [+%a0]0, %d0
0xa9, 0x00, 0x00, 0x05 = st.w [%p0+c]0, %d0
0x89, 0x00, 0x00, 0x09 = st.w [%a0]0, %d0
0x15, 0x00, 0x00, 0x00 = stlcx 0
0x49, 0x00, 0x80, 0x09 = stlcx [%a0]0
0x15, 0x00, 0x00, 0x04 = stucx 0
0x49, 0x00, 0xc0, 0x09 = stucx [%a0]0
0x52, 0x00 = sub %d0, %d15, %d0
0x5a, 0x00 = sub %d15, %d0, %d0
0xa2, 0x00 = sub %d0, %d0
0x0b, 0x00, 0x80, 0x00 = sub %d0, %d0, %d0
0x20, 0x00 = sub.a %sp, 0
0x01, 0x00, 0x20, 0x00 = sub.a %a0, %a0, %a0
0x0b, 0x00, 0x80, 0x04 = sub.b %d0, %d0, %d0
0x6b, 0x00, 0x31, 0x00 = sub.f %d0, %d0, %d0
0x0b, 0x00, 0x80, 0x06 = sub.h %d0, %d0, %d0
0x0b, 0x00, 0xd0, 0x00 = subc %d0, %d0, %d0
0x62, 0x00 = subs %d0, %d0
0x0b, 0x00, 0xa0, 0x00 = subs %d0, %d0, %d0
0x0b, 0x00, 0xa0, 0x06 = subs.h %d0, %d0, %d0
0x0b, 0x00, 0xb0, 0x06 = subs.hu %d0, %d0, %d0
0x0b, 0x00, 0xb0, 0x00 = subs.u %d0, %d0, %d0
0x0b, 0x00, 0xc0, 0x00 = subx %d0, %d0, %d0
0x0d, 0x00, 0x00, 0x02 = svlcx
0x49, 0x00, 0x00, 0x00 = swap.w [%a0+]0, %d0
0x69, 0x00, 0x00, 0x00 = swap.w [%p0+r], %d0
0xe5, 0x00, 0x00, 0x00 = swap.w 0, %d0
0x49, 0x00, 0x00, 0x04 = swap.w [+%a0]0, %d0
0x69, 0x00, 0x00, 0x04 = swap.w [%p0+c]0, %d0
0x49, 0x00, 0x00, 0x08 = swap.w [%a0]0, %d0
0xad, 0x00, 0x80, 0x00 = syscall 0
0x75, 0x00, 0x00, 0x00 = tlbdemap %d0
0x75, 0x00, 0x40, 0x00 = tlbflush.a
0x75, 0x00, 0x50, 0x00 = tlbflush.b
0x75, 0x00, 0x00, 0x04 = tlbmap %e0
0x75, 0x00, 0x80, 0x00 = tlbprobe.a %d0
0x75, 0x00, 0x90, 0x00 = tlbprobe.i %d0
0x0d, 0x00, 0x40, 0x05 = trapsv
0x0d, 0x00, 0x00, 0x05 = trapv
0x4b, 0x00, 0x80, 0x00 = unpack %e0, %d0
0x4b, 0x00, 0xc1, 0x00 = updfl %d0
0x4b, 0x00, 0x61, 0x01 = utof %d0, %d0
0x0f, 0x00, 0xd0, 0x00 = xnor %d0, %d0, %d0
0x8f, 0x00, 0xa0, 0x01 = xnor %d0, %d0, 0
0x07, 0x00, 0x40, 0x00 = xnor.t %d0, %d0, 0, %d0, 0
0xc6, 0x00 = xor %d0, %d0
0x0f, 0x00, 0xc0, 0x00 = xor %d0, %d0, %d0
0x8f, 0x00, 0x80, 0x01 = xor %d0, %d0, 0
0x0b, 0x00, 0xf0, 0x02 = xor.eq %d0, %d0, %d0
0x8b, 0x00, 0xe0, 0x05 = xor.eq %d0, %d0, 0
0x0b, 0x00, 0x30, 0x03 = xor.ge %d0, %d0, %d0
0x8b, 0x00, 0x60, 0x06 = xor.ge %d0, %d0, 0
0x0b, 0x00, 0x40, 0x03 = xor.ge.u %d0, %d0, %d0
0x8b, 0x00, 0x80, 0x06 = xor.ge.u %d0, %d0, 0
0x0b, 0x00, 0x10, 0x03 = xor.lt %d0, %d0, %d0
0x8b, 0x00, 0x20, 0x06 = xor.lt %d0, %d0, 0
0x0b, 0x00, 0x20, 0x03 = xor.lt.u %d0, %d0, %d0
0x8b, 0x00, 0x40, 0x06 = xor.lt.u %d0, %d0, 0
0x0b, 0x00, 0x00, 0x03 = xor.ne %d0, %d0, %d0
0x8b, 0x00, 0x00, 0x06 = xor.ne %d0, %d0, 0
0x07, 0x00, 0x60, 0x00 = xor.t %d0, %d0, 0, %d0, 0
