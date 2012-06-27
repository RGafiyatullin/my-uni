
namespace RG.Term02.RefWork1 {
	using System;
	using System.Text;

	public class Matrix <T> : Vector < Vector<T> > {
		public int DimRows { get; private set; }
		public int DimCols { get; private set; }

		private void InitDims( int rows, int cols ) {
			if ( rows < 1 || cols < 1 ) {
				throw new ArgumentException("Invalid dimensions [" + rows + ", " + cols + "]");
			}
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
		public Matrix( Matrix<T> original ) : base( original.DimRows ) {
			InitDims(original.DimRows, original.DimCols);
			original.Fill(this);
		}
		public void EnsureDimensions(int rows, int cols) {
			if ( rows != DimRows || cols != DimCols ) {
				throw new ArgumentException("Dimensions mismatch");
			}
		}
		/*
		public void EnsurePosition(int? row, int? col) {
			if ( row != null ) {
				if ( row < 1 || row > DimRows - 1 )
					throw new ArgumentException("Invalid row: " + row + "; Expected: [0, " + (DimRows - 1) + "]");
			}
			if ( col != null ) {
				if ( col < 1 || col > DimCols - 1 )
					throw new ArgumentException("Invalid col: " + col + "; Expected: [0, " + (DimCols - 1) + "]");
			}
		}
		*/

		internal void Fill( Matrix<T> copy ) {
			copy.EnsureDimensions(DimRows, DimCols);
			for (var i = 0; i < DimRows; i++) {
				for (var j = 0; j < DimCols; j++) {
					copy[i][j] = this[i][j];
				}
			}
		}
		internal void FillTranspose( Matrix<T> transposedCopy ) {
			transposedCopy.EnsureDimensions(DimCols, DimRows);
			for (var i = 0; i < DimRows; i++) {
				for (var j = 0; j < DimCols; j++) {
					transposedCopy[j][i] = this[i][j];
				}
			}
		}
		internal void FillMinor(Matrix<T> minor, int row, int col) {
			for (var i = 0; i < DimRows; i++) {
				for (var j = 0; j < DimCols; j++) {
					if ( i != row && j != col ) {
						int i_ = i;
						int j_ = j;
						if ( i > row )
							i_ = i - 1;
						if ( j > col )
							j_ = j - 1;
						//Console.WriteLine("Minor: Filling - [{0},{1}]->[{2},{3}] / [{4},{5}]", i, j, i_, j_, row, col);
						minor[i_][j_] = this[i][j];
					}
					//else {
					//	Console.WriteLine("Minor: Skipping - [{0},{1}] / [{2},{3}]", i, j, row, col);
					//}
				}
			}
		}

		public Matrix<T> Transposed(){
			var t = new Matrix<T>(DimCols, DimRows);
			FillTranspose(t);
			return t;
		}
		public Matrix<T> Minor(int row, int col) {
			var m = new Matrix<T>(DimCols - 1, DimRows - 1);
			FillMinor(m, row, col);
			return m;
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
