
namespace RG.Term02.RefWork1 {
	using System;
	using System.Text;

	public class Matrix <T> : Vector < Vector<T> > {
		public int DimRows { get; private set; }
		public int DimCols { get; private set; }

		private void InitDims( int rows, int cols ) {
			DimRows = rows;
			DimCols = cols;

			InitCols(DimCols);
		}
		private void InitCols( int cols ) {
			for (var i = 0; i < DimRows; i++) {
				this[i] = new Vector<T>(cols);
			}
		}

		public Matrix( int rows, int cols ) : base( rows ) {
			InitDims(rows, cols);
		}

		override
		public String ToString() {
			var ret = new StringBuilder( TypeName + " {\n" );
			for ( var i = 0; i < DimRows; i++ ) {
				ret.Append("\t" + this[i].ToStringValuesOnly() + "\n");
			}
			ret.Append("}");

			return ret.ToString();
		}
		
	}
}
