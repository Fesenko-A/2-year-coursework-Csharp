namespace kursova.Forms {
    partial class FormMult {
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
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.matrixMult2Cols = new System.Windows.Forms.NumericUpDown();
            this.matrixMult2Rows = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.matrixMult1Cols = new System.Windows.Forms.NumericUpDown();
            this.matrixMult1Rows = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matrixMultResult = new System.Windows.Forms.DataGridView();
            this.matrixMult2 = new System.Windows.Forms.DataGridView();
            this.matrixMult1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 40);
            this.button5.TabIndex = 37;
            this.button5.Text = "Задати";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SetMatrixMult1SizeClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Результат";
            // 
            // matrixMult2Cols
            // 
            this.matrixMult2Cols.Location = new System.Drawing.Point(887, 305);
            this.matrixMult2Cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMult2Cols.Name = "matrixMult2Cols";
            this.matrixMult2Cols.Size = new System.Drawing.Size(52, 30);
            this.matrixMult2Cols.TabIndex = 35;
            this.matrixMult2Cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMult2Cols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matrixMult2Rows
            // 
            this.matrixMult2Rows.Location = new System.Drawing.Point(826, 305);
            this.matrixMult2Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMult2Rows.Name = "matrixMult2Rows";
            this.matrixMult2Rows.Size = new System.Drawing.Size(52, 30);
            this.matrixMult2Rows.TabIndex = 34;
            this.matrixMult2Rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMult2Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Розмірність";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(777, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 32;
            this.button4.Text = "Задати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetMatrixMult2SizeClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(460, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 36);
            this.button6.TabIndex = 31;
            this.button6.Text = "Помножити";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MatrixMultiplicationClick);
            // 
            // matrixMult1Cols
            // 
            this.matrixMult1Cols.Location = new System.Drawing.Point(286, 305);
            this.matrixMult1Cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMult1Cols.Name = "matrixMult1Cols";
            this.matrixMult1Cols.Size = new System.Drawing.Size(52, 30);
            this.matrixMult1Cols.TabIndex = 30;
            this.matrixMult1Cols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMult1Cols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matrixMult1Rows
            // 
            this.matrixMult1Rows.Location = new System.Drawing.Point(225, 305);
            this.matrixMult1Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixMult1Rows.Name = "matrixMult1Rows";
            this.matrixMult1Rows.Size = new System.Drawing.Size(52, 30);
            this.matrixMult1Rows.TabIndex = 29;
            this.matrixMult1Rows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixMult1Rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Розмірність";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(819, 44);
            this.label5.TabIndex = 27;
            this.label5.Text = "Зверніть увагу, що при множенні матриць кількість стовпців лівої матриці повинна " +
    "дорівнювати \r\nкількості рядків в правій матриці";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrixMultResult
            // 
            this.matrixMultResult.AllowUserToAddRows = false;
            this.matrixMultResult.AllowUserToDeleteRows = false;
            this.matrixMultResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixMultResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixMultResult.Location = new System.Drawing.Point(304, 357);
            this.matrixMultResult.Name = "matrixMultResult";
            this.matrixMultResult.ReadOnly = true;
            this.matrixMultResult.RowHeadersWidth = 51;
            this.matrixMultResult.RowTemplate.Height = 24;
            this.matrixMultResult.Size = new System.Drawing.Size(424, 233);
            this.matrixMultResult.TabIndex = 26;
            // 
            // matrixMult2
            // 
            this.matrixMult2.AllowUserToAddRows = false;
            this.matrixMult2.AllowUserToDeleteRows = false;
            this.matrixMult2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixMult2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixMult2.Location = new System.Drawing.Point(604, 60);
            this.matrixMult2.Name = "matrixMult2";
            this.matrixMult2.RowHeadersWidth = 51;
            this.matrixMult2.RowTemplate.Height = 24;
            this.matrixMult2.Size = new System.Drawing.Size(424, 233);
            this.matrixMult2.TabIndex = 25;
            // 
            // matrixMult1
            // 
            this.matrixMult1.AllowUserToAddRows = false;
            this.matrixMult1.AllowUserToDeleteRows = false;
            this.matrixMult1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixMult1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixMult1.Location = new System.Drawing.Point(22, 60);
            this.matrixMult1.Name = "matrixMult1";
            this.matrixMult1.RowHeadersWidth = 51;
            this.matrixMult1.RowTemplate.Height = 24;
            this.matrixMult1.Size = new System.Drawing.Size(424, 233);
            this.matrixMult1.TabIndex = 24;
            // 
            // FormMult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 574);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matrixMult2Cols);
            this.Controls.Add(this.matrixMult2Rows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.matrixMult1Cols);
            this.Controls.Add(this.matrixMult1Rows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matrixMultResult);
            this.Controls.Add(this.matrixMult2);
            this.Controls.Add(this.matrixMult1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMult";
            this.Text = "FormMult";
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMultResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixMult1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown matrixMult2Cols;
        private System.Windows.Forms.NumericUpDown matrixMult2Rows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown matrixMult1Cols;
        private System.Windows.Forms.NumericUpDown matrixMult1Rows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView matrixMultResult;
        private System.Windows.Forms.DataGridView matrixMult2;
        private System.Windows.Forms.DataGridView matrixMult1;
    }
}