using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToCode.SharedKernel
{
	public abstract class Entity<T>
	{
		public T Id { get; set; }
	}
}
