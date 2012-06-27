
namespace RG.Term02.RefWork1 {
	using System;
	using System.Text;

	public class Vector <T> : IHasItemsRepresentableAsString {
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

		public T this[int idx] {
			get { return _Items[idx]; }
			set { _Items[idx] = value; }
		}

		public T GetItem(int idx){
			return this[idx];
		}
		public void SetItem( int idx, T item ) {
			this[idx] = item;
		}

		override 
		public string ToString() {
			var ret = new StringBuilder( base.ToString() + " " );
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
	}
}
