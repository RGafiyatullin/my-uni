
namespace RG.Term02.RefWork2 {
	using System;

	public class StringHasher : IHashing<string> {
		public int HashOf(string arg) {
			//Console.WriteLine("h('{0}') -> {1}", arg, arg.Length);
			return arg.Length;
		}
	}

	public class Test01 {
		public static int Main(string[] args) {
			var ht = new HashTable<string, int>(3, new StringHasher());
			ht["one"] = 1;
			ht["two"] = 2;
			ht["three"] = 3;
			ht["four"] = 4;
			ht["five"] = 5;
			ht["eleven"] = 11;
			ht["fifty five"] = 55;
			
			var keys = new []{"one", "two", "three", "four", "five", "eleven", "fifty five"};
			foreach (var s in keys) {
				Console.WriteLine("ht[{0}] = {1}", s, ht[s]);
			}

			ht.Dump();

			return 0;
		}
	}
}

