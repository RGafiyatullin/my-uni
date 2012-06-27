namespace RG.Term02.RefWork2 {
	using System;
	using System.Collections.Generic; // For sake of List<T> only!!!

	internal struct HashTableKV<KeyT, ValueT> {
		public KeyT K;
		public ValueT V;
	}

	public class HashTable<KeyT, ValueT> where KeyT : IEquatable<KeyT> {
		public int Mod { get; private set; }
		public IHashing<KeyT> Hasher { get; private set; }

		private List< HashTableKV<KeyT, ValueT> >[] _Table;

		private void Init(int mod, IHashing<KeyT> hasher) {
			Mod = mod;
			Hasher = hasher;
			_Table = new List< HashTableKV<KeyT, ValueT> >[Mod];
			for (var i = 0; i < Mod; i++) {
				_Table[i] = new List< HashTableKV<KeyT, ValueT> >();
			}
		}

		public HashTable( int mod, IHashing<KeyT> hasher ) {
			Init(mod, hasher);
		}

		private HashTableKV<KeyT, ValueT>? FindKV( List< HashTableKV<KeyT, ValueT> > list, KeyT key ) {
			foreach ( var kv in list ) {
				//Console.WriteLine("Trying [{2}]: kv{{ '{0}', '{1}' }}", kv.K, kv.V, key);
				if ( kv.K.Equals(key) ) {
					//Console.WriteLine("Great [{2}]: kv{{ '{0}', '{1}' }}", kv.K, kv.V, key);
					return kv;
				}
			}
			return null;
		}
		private ValueT Find( int hashHint, KeyT key ) {
			//Console.WriteLine("Looking for '{0}'", key);
			var list = _Table[hashHint];
			var kv = FindKV(list, key);
			if (!kv.HasValue) {
				throw new Exception("Key '" + key + "' not found");
			}
			return kv.Value.V;
		}

		private void Store( int hashHint, KeyT key, ValueT val ) {
			//Console.WriteLine("Storing '{0}' -> '{1}'", key, val);
			var list = _Table[hashHint];
			var kv = FindKV( list, key );
			if (kv == null) {
				list.Add( new HashTableKV<KeyT, ValueT>(){
						K = key,
						V = val
					} );
			}
		}

		public ValueT this[KeyT key] {
			get { return Find( Hasher.HashOf(key) % Mod, key ); }
			set { Store( Hasher.HashOf(key) % Mod, key, value ); }
		}

		public void Dump() {
			Console.WriteLine("HashTable dump {");
			for ( var i = 0 ; i < Mod; i++ ) {
				Console.WriteLine("\tBranch '{0}'", i);
				foreach (var kv in _Table[i]) {
					Console.WriteLine("\t\t'{0}' -> '{1}'", kv.K, kv.V);
				}
			}
			Console.WriteLine("}");
		}

	}
}