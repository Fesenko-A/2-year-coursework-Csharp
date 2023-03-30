using MatrixOperationsDLL;
using System;
using System.Windows.Forms;

namespace kursova.Forms {
    public partial class FormAddSub : Form {
        public FormAddSub() {
            InitializeComponent();
        }

        private void SetMatrixPMSizeClick(object sender, EventArgs e) {   // Задати розмір матриці для додавання та віднімання
            int rows = Convert.ToInt32(matrixRowsPM.Value);
            int cols = Convert.ToInt32(matrixColsPM.Value);
            MatrixHelper.SetMatrixSize(matrixPM1, rows, cols);
            MatrixHelper.SetMatrixSize(matrixPM2, rows, cols);
        }

        private void MatrixAdditionClick(object sender, EventArgs e) {  // Кнопка "Скласти"
            double[,] arr1 = MatrixHelper.GetMatrix(matrixPM1);
            double[,] arr2 = MatrixHelper.GetMatrix(matrixPM2);
            double[,] res = MatrixOperations.AddMatrix(arr1, arr2);
            MatrixHelper.FillDataGridView(matrixPMResult, res);
        }

        private void MatrixSubtractionClick(object sender, EventArgs e) {   // Кнопка "Відняти"
            double[,] arr1 = MatrixHelper.GetMatrix(matrixPM1);
            double[,] arr2 = MatrixHelper.GetMatrix(matrixPM2);
            double[,] res = MatrixOperations.SubtractMatrix(arr1, arr2);
            MatrixHelper.FillDataGridView(matrixPMResult, res);
        }
    }
}
