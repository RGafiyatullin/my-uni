
namespace RG.Term02.RefWork1 {
	using System;
	using System.Text;

	public class Vector <T> {
		public int Dim {
			get; private set;
		}
		private T[] _Items;

		private void InitDim( int dim ) {
			Dim = dim;
			_Items = new T[Dim];
		}

		public Vector( int dim ) {
			InitDim( dim );
		}

		public Vector( T[] items ) {
			InitDim( items.Length );
			for ( var i = 0; i < Dim; i++ ) {
				_Items[i] = items[i];
			}
		}

		public void EnsureIDX(int idx) {
			if ( idx < 0 || idx > Dim - 1 )
				throw new ArgumentException("Invalid idx: " + idx + "; Expected: [0, " + (Dim - 1) + "]");
		}

		public T this[int idx] {
			get { EnsureIDX(idx); return _Items[idx]; }
			set { EnsureIDX(idx); _Items[idx] = value; }
		}

		override 
		public string ToString() {
			var ret = new StringBuilder( TypeName + " " );
			ret.Append(ToStringValuesOnly());
			return ret.ToString();
		}

		public string ToStringValuesOnly() {
			var ret = new StringBuilder();
			ret.Append("{ ");
			for ( var i = 0; i < Dim; i++ ) {
				if ( this[i] == null )
					ret.Append("null, ");
				else
					ret.Append( "'" + this[i] + "'" );

				if ( i != Dim - 1 ) {
					ret.Append(", ");
				}
			}
			ret.Append(" }");
			return ret.ToString();
		}

		public string TypeName {
			get {
				return base.ToString();
			}
		}
	}
}
