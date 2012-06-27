namespace RG.Term02.RefWork1 {
	using System;

	public class Int32Matrix : Matrix<Int32> {
		public Int32Matrix( Int32Matrix original ) : base( original ) {}
		public Int32Matrix(int rows, int cols) : base(rows, cols) {}

		new
		public Int32Matrix Transposed(){
			var t = new Int32Matrix(DimCols, DimRows);
			FillTranspose(t);
			return t;
		}
		
		new
		public Int32Matrix Minor(int row, int col) {
			var m = new Int32Matrix(DimCols - 1, DimRows - 1);
			FillMinor(m, row, col);
			return m;
		}
	}
}
