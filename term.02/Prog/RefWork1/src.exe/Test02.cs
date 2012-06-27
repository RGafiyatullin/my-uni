
namespace RG.Term02.RefWork1 {

	using System;

	public class Test02 {
		public static int Main(string[] args) {
			var m = new Matrix<int>(5, 5);
			Console.WriteLine("m: {0}", m);
			m[1][3] = 18;
			Console.WriteLine("m: {0}", m);
			return 0;
		}
	}
}

