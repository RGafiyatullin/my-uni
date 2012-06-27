
namespace RG.Term02.RefWork1 {

	using System;

	public class Test04 {
		public static int Main(string[] args) {
			var a = new NumericMatrix<double>(2, 3);
			a[0][0] = 1.5;
			a[0][1] = 2.5;
			a[0][2] = 3.5;

			a[1][0] = 3.5;
			a[1][1] = 2.5;
			a[1][2] = 1.5;

			var b = new NumericMatrix<double>(3, 4);

			b[0][0] = 1.5;
			b[0][1] = 2.5;
			b[0][2] = 3.5;
			b[0][3] = 4.5;
			
			b[1][0] = 4.5;
			b[1][1] = 3.5;
			b[1][2] = 2.5;
			b[1][3] = 1.5;
			
			b[2][0] = 5.5;
			b[2][1] = 6.5;
			b[2][2] = 7.5;
			b[2][3] = 8.5;
			
			Console.WriteLine("a: {0}\nb: {1}", a, b);
			Console.WriteLine("a.b is okay as of a: {0}", a.IsCompatibleBeingLeft(b));
			Console.WriteLine("b.a is okay as of a: {0}", a.IsCompatibleBeingRight(b));
			Console.WriteLine("a.b is okay as of b: {0}", b.IsCompatibleBeingRight(a));
			Console.WriteLine("b.a is okay as of b: {0}", b.IsCompatibleBeingLeft(a));

			var ab = a.MultiplyBy(b);
			Console.WriteLine("a.b: {0}", ab );
			var abt = a.Transposed();
			Console.WriteLine("a.b^t: {0}", abt );
			return 0;
		}
	}
}

