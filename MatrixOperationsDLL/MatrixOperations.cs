using System;

namespace MatrixOperationsDLL {
    public static class MatrixOperations {
        // Додавання матриць
        public static double[,] AddMatrix(double[,] matrix1, double[,] matrix2) {
            if ((matrix1.GetLength(0) != matrix2.GetLength(0)) || (matrix1.GetLength(1) != matrix2.GetLength(1)))
                throw new Exception("Додавання та віднімання матриць різних розмірів неможливе");

            double[,] matrix3 = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++) {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }

            return matrix3;
        }

        // Віднімання матриць
        public static double[,] SubtractMatrix(double[,] matrix1, double[,] matrix2) {
            if ((matrix1.GetLength(0) != matrix2.GetLength(0)) || (matrix1.GetLength(1) != matrix2.GetLength(1)))
                throw new Exception("Додавання та віднімання матриць різних розмірів неможливе");

            double[,] matrix3 = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++) {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
            }

            return matrix3;
        }

        // Множення двох матриць
        public static double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2) {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new Exception("Кількість стовпців першої матриці не дорівнює кількості рядків другої матриці");

            double[,] matrix3 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++) {
                for (int j = 0; j < matrix2.GetLength(1); j++) {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }

            return matrix3;
        }

        // Множення матриці на число
        public static double[,] MultiplyMatrixByNumber(double[,] matrix, double number) {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    result[i, j] = matrix[i, j] * number;
            }

            return result;
        }

        // Транспонування матриці
        public static double[,] TransposeMatrix(double[,] matrix) {
            double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result[j, i] = matrix[i, j];
            }

            return result;
        }
    }
}
