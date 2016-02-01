﻿using System;
using Zeal.Compiler.Data;

namespace Zeal.Compiler.Data
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class OpcodeAttribute : Attribute
    {
        public byte Opcode { get; private set; }
        public CpuAddressingMode AddressingMode { get; private set; }

        public OpcodeAttribute(byte opcode)
        {
            AddressingMode = CpuAddressingMode.Implied;
            Opcode = opcode;
        }

        public OpcodeAttribute(CpuAddressingMode addressing, byte opcode)
        {
            AddressingMode = addressing;
            Opcode = opcode;
        }
    }
}
