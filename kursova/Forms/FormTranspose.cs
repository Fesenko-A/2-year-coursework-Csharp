using MatrixOperationsDLL;
using System;
using System.Windows.Forms;

namespace kursova.Forms {
    public partial class FormTranspose : Form {
        public FormTranspose() {
            InitializeComponent();
        }
        
        private void SetMatrixTransposeSizeClick(object sender, EventArgs e) {  // Задати розміри матриці для транспонування
            int rows = Convert.ToInt32(matrixTransposeRows.Value);
            int cols = Convert.ToInt32(matrixTransposeCols.Value);
            MatrixHelper.SetMatrixSize(matrixTranspose, rows, cols);
        }

        private void MatrixTransposeClick(object sender, EventArgs e) { // Кнопка "Транспонувати"
            double[,] arr = MatrixHelper.GetMatrix(matrixTranspose);
            double[,] res = MatrixOperations.TransposeMatrix(arr);
            MatrixHelper.FillDataGridView(matrixTransposeResult, res);
        }
    }
}
