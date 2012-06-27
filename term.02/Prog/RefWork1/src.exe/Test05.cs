
namespace RG.Term02.RefWork1 {

	using System;

	public class Test03 {
		public static int Main(string[] args) {
			var a = new NumericMatrix<int>(3, 3);
			a[0][0] = 101;
			a[0][1] = -102;
			a[0][2] = 103;
			
			a[1][0] = 201;
			a[1][1] = 202;
			a[1][2] = 203;

			a[2][0] = 301;
			a[2][1] = -302;
			a[2][2] = 303;
			
			Console.WriteLine("a: {0}; |a|: {1}", a, a.Det());
			var b = a.Transposed().MultiplyBy(2);
			Console.WriteLine("b: {0}; |b|: {1}", b, b.Det());
			
			return 0;
		}
	}
}

