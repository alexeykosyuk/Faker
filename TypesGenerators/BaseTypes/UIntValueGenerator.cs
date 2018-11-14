﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesGenerators.BaseTypes
{
    public class UIntValueGenerator : IBaseGenerator
    {
        private readonly Random _random;

        public Type GenerateType { get; protected set; }

        public UIntValueGenerator()
        {
            GenerateType = typeof(uint);
            _random = new Random();
        }

        public object Generate()
        {
            return (uint)_random.Next();
        }
    }
}
