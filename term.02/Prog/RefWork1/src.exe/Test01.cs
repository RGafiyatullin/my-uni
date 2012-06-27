
namespace RG.Term02.RefWork1 {

	using System;

	public class Test01 {
		public static int Main(string[] args) {
			var v = new Vector<int>(new [] { 0, 1, 2, 3, 4, 5 });
			Console.WriteLine("v: {0}", v);
			v[2] = 4;
			v[4] = 2;
			Console.WriteLine("v: {0}", v);
			return 0;
		}
	}
}

