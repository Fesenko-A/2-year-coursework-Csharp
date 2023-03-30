using System;
using System.Windows.Forms;

namespace kursova.Forms {
    // Клас для введення/виведення матриць
    public static class MatrixHelper {

        // Задати розміри матриці
        public static void SetMatrixSize(DataGridView dataGridView, int rows, int cols) {
            dataGridView.RowCount = rows;
            dataGridView.ColumnCount = cols;
        }

        // Записати числові дані із DataGridView в масив
        public static double[,] GetMatrix(DataGridView dataGridView) {
            double[,] arr = new double[dataGridView.RowCount, dataGridView.ColumnCount];

            try {
                foreach (DataGridViewRow i in dataGridView.Rows) {
                    if (i.IsNewRow) continue;
                    foreach (DataGridViewCell j in i.Cells)
                        arr[j.RowIndex, j.ColumnIndex] = Convert.ToDouble(j.Value);
                }
            }
            catch {
                MessageBox.Show("Помилка при введенні");
            }

            return arr;
        }

        // Заповнити DataGridView з масиву
        public static void FillDataGridView(DataGridView dataGridView, double[,] arr) {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = arr.GetLength(1);

            for (int i = 0; i < arr.GetLength(0); i++) {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);

                for (int j = 0; j < arr.GetLength(1); j++)
                    row.Cells[j].Value = arr[i, j];

                dataGridView.Rows.Add(row);
            }
        }
    }
}
