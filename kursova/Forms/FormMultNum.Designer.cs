namespace kursova.Forms {
    partial class FormMultNum {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.multNumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.matrixMultNumCols = new System.Windows.Forms.NumericUpDown();
            this.matrixMultNumRows = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.matrixMultNumResult = new System.Windows.Forms.DataGridView();
            this.matrixMultNum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.multNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNum)).BeginInit();
            this.SuspendLayout();
            // 
            // multNumber
            // 
            this.multNumber.DecimalPlaces = 2;
            this.multNumber.Location = new System.Drawing.Point(762, 154);
            this.multNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.multNumber.Name = "multNumber";
            this.multNumber.Size = new System.Drawing.Size(124, 30);
            this.multNumber.TabIndex = 43;
            this.multNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(617, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "Помножити на";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(677, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 35);
            this.button7.TabIndex = 41;
            this.button7.Text = "Задати";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SetMatrixNumSizeClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "Результат";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(677, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 36);
            this.button8.TabIndex = 39;
            this.button8.Text = "Помножити";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MatrixMultiplicationByNumberClick);
            // 
            // matrixMultNumCols
            // 
            this.matrixMultNumCols.Location = new System.Drawing.Point(800, 21);
            this.matrixMultNumCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMultNumCols.Name = "matrixMultNumCols";
            this.matrixMultNumCols.Size = new System.Drawing.Size(52, 30);
            this.matrixMultNumCols.TabIndex = 38;
            this.matrixMultNumCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMultNumCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matrixMultNumRows
            // 
            this.matrixMultNumRows.Location = new System.Drawing.Point(739, 21);
            this.matrixMultNumRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMultNumRows.Name = "matrixMultNumRows";
            this.matrixMultNumRows.Size = new System.Drawing.Size(52, 30);
            this.matrixMultNumRows.TabIndex = 37;
            this.matrixMultNumRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMultNumRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Розмірність";
            // 
            // matrixMultNumResult
            // 
            this.matrixMultNumResult.AllowUserToAddRows = false;
            this.matrixMultNumResult.AllowUserToDeleteRows = false;
            this.matrixMultNumResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixMultNumResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixMultNumResult.Location = new System.Drawing.Point(328, 323);
            this.matrixMultNumResult.Name = "matrixMultNumResult";
            this.matrixMultNumResult.ReadOnly = true;
            this.matrixMultNumResult.RowHeadersWidth = 51;
            this.matrixMultNumResult.RowTemplate.Height = 24;
            this.matrixMultNumResult.Size = new System.Drawing.Size(424, 233);
            this.matrixMultNumResult.TabIndex = 35;
            // 
            // matrixMultNum
            // 
            this.matrixMultNum.AllowUserToAddRows = false;
            this.matrixMultNum.AllowUserToDeleteRows = false;
            this.matrixMultNum.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixMultNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixMultNum.Location = new System.Drawing.Point(168, 17);
            this.matrixMultNum.Name = "matrixMultNum";
            this.matrixMultNum.RowHeadersWidth = 51;
            this.matrixMultNum.RowTemplate.Height = 24;
            this.matrixMultNum.Size = new System.Drawing.Size(424, 233);
            this.matrixMultNum.TabIndex = 34;
            // 
            // FormMultNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 572);
            this.Controls.Add(this.multNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.matrixMultNumCols);
            this.Controls.Add(this.matrixMultNumRows);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.matrixMultNumResult);
            this.Controls.Add(this.matrixMultNum);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMultNum";
            this.Text = "FormMultNum";
            ((System.ComponentModel.ISupportInitialize)(this.multNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNumResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown multNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown matrixMultNumCols;
        private System.Windows.Forms.NumericUpDown matrixMultNumRows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView matrixMultNumResult;
        private System.Windows.Forms.DataGridView matrixMultNum;
    }
}