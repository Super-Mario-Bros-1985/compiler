﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeal.Compiler.CodeGeneration;
using Zeal.Compiler.Data;

namespace Zeal.Compiler.Helper
{
    static class EnumHelper
    {
        public static T[] GetAttributes<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString())[0];
            var attributes = memberInfo.GetCustomAttributes(typeof(T), false) as T[];
            return attributes;
        }
    }
}
