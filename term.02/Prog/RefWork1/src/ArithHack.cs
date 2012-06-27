
namespace RG.Term02.RefWork1 {
	using System;
	using System.Reflection;

	internal class ArithHack <T> {
		static internal T Add( object a, object b ) {
			// MethodInfo mi = typeof(T).GetMethod("op_Addition", BindingFlags.Static | BindingFlags.Public );
			// Console.WriteLine("a: {0}; b: {1}; mi: {2}", a, b, mi == null);
			// return (T) mi.Invoke(a, new Object[]{b});

			var t = typeof(T);
			//if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a + (Int64)b, typeof(T) );
			if ( t == typeof(Int16) ) return (T) Convert.ChangeType( (Int16)a + (Int16)b, typeof(T) );
			if ( t == typeof(Int32) ) return (T) Convert.ChangeType( (Int32)a + (Int32)b, typeof(T) );
			if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a + (Int64)b, typeof(T) );
			if ( t == typeof(Single) ) return (T) Convert.ChangeType( (Single)a + (Single)b, typeof(T) );
			if ( t == typeof(Double) ) return (T) Convert.ChangeType( (Double)a + (Double)b, typeof(T) );
			if ( t == typeof(Decimal) ) return (T) Convert.ChangeType( (Decimal)a + (Decimal)b, typeof(T) );

			throw new NotImplementedException("Sorry mate, not this time...");			
		}
		static internal T Multiply(object a, object b) {
			// MethodInfo mi = typeof(T).GetMethod("op_Multiply", BindingFlags.Static | BindingFlags.Public );
			// Console.WriteLine("a: {0}; b: {1}; mi: {2}", a, b, mi == null);
			// return (T) mi.Invoke(a, new Object[]{b});

			var t = typeof(T);
			//if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a * (Int64)b, typeof(T) );
			if ( t == typeof(Int16) ) return (T) Convert.ChangeType( (Int16)a * (Int16)b, typeof(T) );
			if ( t == typeof(Int32) ) return (T) Convert.ChangeType( (Int32)a * (Int32)b, typeof(T) );
			if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a * (Int64)b, typeof(T) );
			if ( t == typeof(Single) ) return (T) Convert.ChangeType( (Single)a * (Single)b, typeof(T) );
			if ( t == typeof(Double) ) return (T) Convert.ChangeType( (Double)a * (Double)b, typeof(T) );
			if ( t == typeof(Decimal) ) return (T) Convert.ChangeType( (Decimal)a * (Decimal)b, typeof(T) );

			throw new NotImplementedException("Sorry mate, not this time...");
		}
		static internal T Subtract(object a, object b) {
			// MethodInfo mi = typeof(T).GetMethod("op_Subtract", BindingFlags.Static | BindingFlags.Public );
			// Console.WriteLine("a: {0}; b: {1}; mi: {2}", a, b, mi == null);
			// return (T) mi.Invoke(a, new Object[]{b});

			var t = typeof(T);
			//if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a * (Int64)b, typeof(T) );

			if ( t == typeof(Int16) ) return (T) Convert.ChangeType( (Int16)a - (Int16)b, typeof(T) );
			if ( t == typeof(Int32) ) return (T) Convert.ChangeType( (Int32)a - (Int32)b, typeof(T) );
			if ( t == typeof(Int64) ) return (T) Convert.ChangeType( (Int64)a - (Int64)b, typeof(T) );
			if ( t == typeof(Single) ) return (T) Convert.ChangeType( (Single)a - (Single)b, typeof(T) );
			if ( t == typeof(Double) ) return (T) Convert.ChangeType( (Double)a - (Double)b, typeof(T) );
			if ( t == typeof(Decimal) ) return (T) Convert.ChangeType( (Decimal)a - (Decimal)b, typeof(T) );
			throw new NotImplementedException("Sorry mate, not this time...");
		}
	}
}