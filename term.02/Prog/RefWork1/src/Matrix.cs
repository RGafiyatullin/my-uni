
namespace RG.Term02.RefWork1 {
	using System;
	using System.Text;

	public abstract class MatrixBase <VectorT> where VectorT : IHasItemsRepresentableAsString {
		protected abstract VectorT CreateVector( int dim );

		private VectorT[] _Rows;
		public int DimRows { get; private set; }
		public int DimCols { get; private set; }

		protected void InitDims(int rows, int cols) {
			DimRows = rows;
			DimCols = cols;

			_Rows = new VectorT[DimRows];

			for ( var i = 0; i < DimRows; i++ ) {
				_Rows[i] = CreateVector(DimCols);
			}
		}

		public MatrixBase( int rows, int cols ) {
			InitDims(rows, cols);
		}

		public VectorT this[int idx] {
			get { return _Rows[idx]; }
		}

		override
		public String ToString() {
			var ret = new StringBuilder( base.ToString() + " {\n" );
			for ( var i = 0; i < DimRows; i++ ) {
				ret.Append("\t" + _Rows[i].ToStringValuesOnly() + "\n");
			}
			ret.Append("}");

			return ret.ToString();
		}
	}

	public class Matrix <T> : MatrixBase < Vector<T> > {
		public Matrix( int rows, int cols ) : base(rows, cols) {
		}
		override
		protected Vector<T> CreateVector( int dim ) {
			return new Vector<T>(dim);
		}
	}
}
