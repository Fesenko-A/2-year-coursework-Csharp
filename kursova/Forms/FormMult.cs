using MatrixOperationsDLL;
using System;
using System.Windows.Forms;

namespace kursova.Forms {
    public partial class FormMult : Form {
        public FormMult() {
            InitializeComponent();
        }

        private void SetMatrixMult1SizeClick(object sender, EventArgs e) {  // Задати розміри першої матриці
            int rows = Convert.ToInt32(matrixMult1Rows.Value);
            int cols = Convert.ToInt32(matrixMult1Cols.Value);
            MatrixHelper.SetMatrixSize(matrixMult1, rows, cols);
        }

        private void SetMatrixMult2SizeClick(object sender, EventArgs e) {  // Задати розміри другої матриці
            int rows = Convert.ToInt32(matrixMult2Rows.Value);
            int cols = Convert.ToInt32(matrixMult2Cols.Value);
            MatrixHelper.SetMatrixSize(matrixMult2, rows, cols);
        }

        private void MatrixMultiplicationClick(object sender, EventArgs e) {    // Кнопка "Помножити"
            double[,] arr1 = MatrixHelper.GetMatrix(matrixMult1);
            double[,] arr2 = MatrixHelper.GetMatrix(matrixMult2);
            try {
                double[,] res = MatrixOperations.MultiplyMatrix(arr1, arr2);
                MatrixHelper.FillDataGridView(matrixMultResult, res);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
