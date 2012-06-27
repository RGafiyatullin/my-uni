namespace RG.Term02.RefWork1 {
	using System;

	public class NumericMatrix <T> : Matrix<T> where T : new() {
		public NumericMatrix( NumericMatrix<T> original ) : base( original ) {}
		public NumericMatrix(int rows, int cols) : base(rows, cols) {}
		public bool IsCompatibleBeingLeft( NumericMatrix<T> right ) {
			return DimCols == right.DimRows;
		}
		public bool IsCompatibleBeingRight( NumericMatrix<T> left ) {
			return left.IsCompatibleBeingLeft(this);
		}

		static private T MultiplicationCellValue(
							NumericMatrix<T> left,
							NumericMatrix<T> right, 
							int i, int j
		) {
			var acc = new T();
			for ( var k = 0; k < left.DimCols; k++ ) {
				acc = ArithHack<T>.Add( acc, ArithHack<T>.Multiply(left[i][k], right[k][j]) );
			}
			return acc;
		}

		public NumericMatrix<T> MultiplyBy( T scalar ) {
			var result = new NumericMatrix<T>( this );
			for (var i = 0; i < result.DimRows; i++ ) {
				for (var j = 0; j < result.DimCols; j++ ) {
					result[i][j] = ArithHack<T>.Multiply(result[i][j], scalar);
				}
			}
			return result;
		}

		public NumericMatrix<T> MultiplyBy( NumericMatrix<T> right ) {
			if ( !IsCompatibleBeingLeft(right) ) {
				throw new InvalidOperationException("Matrices are incompatible");
			}
			var result = new NumericMatrix<T>( DimRows, right.DimCols );
			for (var i = 0; i < result.DimRows; i++ ) {
				for (var j = 0; j < result.DimCols; j++ ) {
					result[i][j] = MultiplicationCellValue( this, right, i, j );
				}
			}
			return result;
		}

		public bool IsSquare {
			get { return DimCols == DimRows; }
		}

		public T Det() {
			return DeterminantLaplaceExpansion();			
		}

		new
		public NumericMatrix<T> Transposed(){
			var t = new NumericMatrix<T>(DimCols, DimRows);
			FillTranspose(t);
			return t;
		}

		new
		public NumericMatrix<T> Minor(int row, int col) {
			var m = new NumericMatrix<T>(DimCols - 1, DimRows - 1);
			FillMinor(m, row, col);
			return m;
		}

		public T DeterminantLaplaceExpansion() {
			if ( ! IsSquare ) {
				throw new InvalidOperationException("Determinant is not defined for a matrix unless it's a square one");
			}
			if ( Dim == 2 ) {
				return ArithHack<T>.Subtract(
						ArithHack<T>.Multiply( this[0][0], this[1][1] ),
						ArithHack<T>.Multiply( this[0][1], this[1][0] )
					);
			}
			else {
				var acc = new T();
				for ( var j = 0; j < DimCols; j++ ) {
					var item = this[0][j];
					var m = Minor(0, j);
					var a = ArithHack<T>.Multiply( item, m.Det() );
					if ( j % 2 == 0 ) 
						acc = ArithHack<T>.Add( acc, a );
					else 
						acc = ArithHack<T>.Subtract( acc, a );
				}
				return acc;
			}
		}
	}
}