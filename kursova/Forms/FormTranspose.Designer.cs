namespace kursova.Forms {
    partial class FormTranspose {
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
            this.button9 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.matrixTransposeCols = new System.Windows.Forms.NumericUpDown();
            this.matrixTransposeRows = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.matrixTransposeResult = new System.Windows.Forms.DataGridView();
            this.matrixTranspose = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTranspose)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(693, 102);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 35);
            this.button9.TabIndex = 47;
            this.button9.Text = "Задати";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SetMatrixTransposeSizeClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(502, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "Результат";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(678, 151);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 41);
            this.button10.TabIndex = 45;
            this.button10.Text = "Транспонувати";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MatrixTransposeClick);
            // 
            // matrixTransposeCols
            // 
            this.matrixTransposeCols.Location = new System.Drawing.Point(816, 65);
            this.matrixTransposeCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixTransposeCols.Name = "matrixTransposeCols";
            this.matrixTransposeCols.Size = new System.Drawing.Size(52, 30);
            this.matrixTransposeCols.TabIndex = 44;
            this.matrixTransposeCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixTransposeCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matrixTransposeRows
            // 
            this.matrixTransposeRows.Location = new System.Drawing.Point(755, 65);
            this.matrixTransposeRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixTransposeRows.Name = "matrixTransposeRows";
            this.matrixTransposeRows.Size = new System.Drawing.Size(52, 30);
            this.matrixTransposeRows.TabIndex = 43;
            this.matrixTransposeRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixTransposeRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(633, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 22);
            this.label12.TabIndex = 42;
            this.label12.Text = "Розмірність";
            // 
            // matrixTransposeResult
            // 
            this.matrixTransposeResult.AllowUserToAddRows = false;
            this.matrixTransposeResult.AllowUserToDeleteRows = false;
            this.matrixTransposeResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixTransposeResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTransposeResult.Location = new System.Drawing.Point(344, 323);
            this.matrixTransposeResult.Name = "matrixTransposeResult";
            this.matrixTransposeResult.ReadOnly = true;
            this.matrixTransposeResult.RowHeadersWidth = 51;
            this.matrixTransposeResult.RowTemplate.Height = 24;
            this.matrixTransposeResult.Size = new System.Drawing.Size(424, 233);
            this.matrixTransposeResult.TabIndex = 41;
            // 
            // matrixTranspose
            // 
            this.matrixTranspose.AllowUserToAddRows = false;
            this.matrixTranspose.AllowUserToDeleteRows = false;
            this.matrixTranspose.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixTranspose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixTranspose.Location = new System.Drawing.Point(184, 17);
            this.matrixTranspose.Name = "matrixTranspose";
            this.matrixTranspose.RowHeadersWidth = 51;
            this.matrixTranspose.RowTemplate.Height = 24;
            this.matrixTranspose.Size = new System.Drawing.Size(424, 233);
            this.matrixTranspose.TabIndex = 40;
            // 
            // FormTranspose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.matrixTransposeCols);
            this.Controls.Add(this.matrixTransposeRows);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.matrixTransposeResult);
            this.Controls.Add(this.matrixTranspose);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTranspose";
            this.Text = "FormTranspose";
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTransposeResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixTranspose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.NumericUpDown matrixTransposeCols;
        private System.Windows.Forms.NumericUpDown matrixTransposeRows;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView matrixTransposeResult;
        private System.Windows.Forms.DataGridView matrixTranspose;
    }
}