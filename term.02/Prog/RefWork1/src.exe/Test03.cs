
namespace RG.Term02.RefWork1 {

	using System;

	public class Test03 {
		public static int Main(string[] args) {
			var a = new NumericMatrix<int>(3, 3);
			a[0][0] = 11;
			a[0][1] = 12;
			a[0][2] = 13;
			
			a[1][0] = 21;
			a[1][1] = 22;
			a[1][2] = 23;

			a[2][0] = 31;
			a[2][1] = 32;
			a[2][2] = 33;
			
			var b = new NumericMatrix<int>(5, 3);

			b[0][0] = 11;
			b[0][1] = 12;
			b[0][2] = 13;
			
			b[1][0] = 21;
			b[1][1] = 22;
			b[1][2] = 23;
			
			b[2][0] = 31;
			b[2][1] = 32;
			b[2][2] = 33;
			
			b[3][0] = 41;
			b[3][1] = 42;
			b[3][2] = 43;
			
			b[4][0] = 51;
			b[4][1] = 52;
			b[4][2] = 53;
			
			
			Console.WriteLine("a: {0}\nb: {1}", a, b);
			Console.WriteLine("a.b is okay as of a: {0}", a.IsCompatibleBeingLeft(b));
			Console.WriteLine("b.a is okay as of a: {0}", a.IsCompatibleBeingRight(b));
			Console.WriteLine("a.b is okay as of b: {0}", b.IsCompatibleBeingRight(a));
			Console.WriteLine("b.a is okay as of b: {0}", b.IsCompatibleBeingLeft(a));

			var ba = b.MultiplyBy(a);
			Console.WriteLine("b.a: {0}", ba);
			Console.WriteLine("b.a^t: {0}", ba.Transposed() );

			return 0;
		}
	}
}

