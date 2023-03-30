using MatrixOperationsDLL;
using System;
using System.Windows.Forms;

namespace kursova.Forms {
    public partial class FormMultNum : Form {
        public FormMultNum() {
            InitializeComponent();
        }

        private void SetMatrixNumSizeClick(object sender, EventArgs e) {    // Задати розміри матриці для множення на число
            int rows = Convert.ToInt32(matrixMultNumRows.Value);
            int cols = Convert.ToInt32(matrixMultNumCols.Value);
            MatrixHelper.SetMatrixSize(matrixMultNum, rows, cols);
        }

        private void MatrixMultiplicationByNumberClick(object sender, EventArgs e) {    // Кнопка "Помножити"
            double[,] arr = MatrixHelper.GetMatrix(matrixMultNum);
            double number = Convert.ToDouble(multNumber.Value);
            double[,] res = MatrixOperations.MultiplyMatrixByNumber(arr, number);
            MatrixHelper.FillDataGridView(matrixMultNumResult, res);
        }
    }
}
