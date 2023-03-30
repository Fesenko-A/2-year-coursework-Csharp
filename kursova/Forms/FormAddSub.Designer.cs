namespace kursova.Forms {
    partial class FormAddSub {
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
            this.button3 = new System.Windows.Forms.Button();
            this.matrixColsPM = new System.Windows.Forms.NumericUpDown();
            this.matrixRowsPM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixPMResult = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.matrixPM2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixPM1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrixColsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixRowsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPMResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPM1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Задати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SetMatrixPMSizeClick);
            // 
            // matrixColsPM
            // 
            this.matrixColsPM.Location = new System.Drawing.Point(530, 79);
            this.matrixColsPM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixColsPM.Name = "matrixColsPM";
            this.matrixColsPM.Size = new System.Drawing.Size(52, 30);
            this.matrixColsPM.TabIndex = 22;
            this.matrixColsPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixColsPM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // matrixRowsPM
            // 
            this.matrixRowsPM.Location = new System.Drawing.Point(469, 79);
            this.matrixRowsPM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.matrixRowsPM.Name = "matrixRowsPM";
            this.matrixRowsPM.Size = new System.Drawing.Size(52, 30);
            this.matrixRowsPM.TabIndex = 21;
            this.matrixRowsPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixRowsPM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Розмірність";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Результат";
            // 
            // matrixPMResult
            // 
            this.matrixPMResult.AllowUserToAddRows = false;
            this.matrixPMResult.AllowUserToDeleteRows = false;
            this.matrixPMResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixPMResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixPMResult.Location = new System.Drawing.Point(310, 317);
            this.matrixPMResult.Name = "matrixPMResult";
            this.matrixPMResult.ReadOnly = true;
            this.matrixPMResult.RowHeadersWidth = 51;
            this.matrixPMResult.RowTemplate.Height = 24;
            this.matrixPMResult.Size = new System.Drawing.Size(424, 233);
            this.matrixPMResult.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Відняти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MatrixSubtractionClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Скласти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MatrixAdditionClick);
            // 
            // matrixPM2
            // 
            this.matrixPM2.AllowUserToAddRows = false;
            this.matrixPM2.AllowUserToDeleteRows = false;
            this.matrixPM2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixPM2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixPM2.Location = new System.Drawing.Point(605, 40);
            this.matrixPM2.Name = "matrixPM2";
            this.matrixPM2.RowHeadersWidth = 51;
            this.matrixPM2.RowTemplate.Height = 24;
            this.matrixPM2.Size = new System.Drawing.Size(424, 233);
            this.matrixPM2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Зверніть увагу, що при додаванні та відніманні матриць вони повинні мати однакову" +
    " розмірність";
            // 
            // matrixPM1
            // 
            this.matrixPM1.AllowUserToAddRows = false;
            this.matrixPM1.AllowUserToDeleteRows = false;
            this.matrixPM1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixPM1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixPM1.Location = new System.Drawing.Point(23, 40);
            this.matrixPM1.Name = "matrixPM1";
            this.matrixPM1.RowHeadersWidth = 51;
            this.matrixPM1.RowTemplate.Height = 24;
            this.matrixPM1.Size = new System.Drawing.Size(424, 233);
            this.matrixPM1.TabIndex = 13;
            // 
            // FormAddSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 572);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.matrixColsPM);
            this.Controls.Add(this.matrixRowsPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixPMResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrixPM2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixPM1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddSub";
            this.Text = "FormAddSub";
            ((System.ComponentModel.ISupportInitialize)(this.matrixColsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixRowsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPMResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixPM1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown matrixColsPM;
        private System.Windows.Forms.NumericUpDown matrixRowsPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView matrixPMResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView matrixPM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrixPM1;
    }
}