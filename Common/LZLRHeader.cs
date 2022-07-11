﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinDataUtil.Common
{
    public struct LZLRHeader
    {
        public uint magic;
        public int unpackedSize;
        public int dataOffset;

        public static uint DefaultMagic => 0x524C5A4C;
        public static int Size => sizeof(int)*3;
    }
}