﻿using System;
using Oct.Framework.DB.Emit.MappingConfiguration.MappingOperations.Interfaces;

namespace Oct.Framework.DB.Emit.MappingConfiguration.MappingOperations
{
	public class ReadWriteSimple : IReadWriteOperation
	{
		public bool ShallowCopy { get; set; }
		public MemberDescriptor Source { get; set; }
		public MemberDescriptor Destination { get; set; }
        public Delegate NullSubstitutor { get; set; }
		public Delegate TargetConstructor { get; set; }
		public Delegate Converter { get; set; }

        public override string ToString()
        {
            return "ReadWriteSimple. Source member:" + Source + " Target member:" + Destination.ToString();
        }
	}
}
