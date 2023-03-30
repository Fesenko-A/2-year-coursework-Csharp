namespace kursova {
    partial class Form1 {
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTranspose = new System.Windows.Forms.Button();
            this.btnMultNum = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnAddSub = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnTranspose);
            this.panelMenu.Controls.Add(this.btnMultNum);
            this.panelMenu.Controls.Add(this.btnMult);
            this.panelMenu.Controls.Add(this.btnAddSub);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(325, 729);
            this.panelMenu.TabIndex = 0;
            // 
            // btnTranspose
            // 
            this.btnTranspose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTranspose.FlatAppearance.BorderSize = 0;
            this.btnTranspose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranspose.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnTranspose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTranspose.Image = global::kursova.Properties.Resources.trans;
            this.btnTranspose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranspose.Location = new System.Drawing.Point(0, 307);
            this.btnTranspose.Name = "btnTranspose";
            this.btnTranspose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTranspose.Size = new System.Drawing.Size(325, 62);
            this.btnTranspose.TabIndex = 4;
            this.btnTranspose.Text = "   Транспонування\r\n";
            this.btnTranspose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranspose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTranspose.UseVisualStyleBackColor = true;
            this.btnTranspose.Click += new System.EventHandler(this.btnTranspose_Click);
            // 
            // btnMultNum
            // 
            this.btnMultNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMultNum.FlatAppearance.BorderSize = 0;
            this.btnMultNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultNum.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnMultNum.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMultNum.Image = global::kursova.Properties.Resources.multnum;
            this.btnMultNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultNum.Location = new System.Drawing.Point(0, 245);
            this.btnMultNum.Name = "btnMultNum";
            this.btnMultNum.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMultNum.Size = new System.Drawing.Size(325, 62);
            this.btnMultNum.TabIndex = 3;
            this.btnMultNum.Text = "   Множення \r\n   на число";
            this.btnMultNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMultNum.UseVisualStyleBackColor = true;
            this.btnMultNum.Click += new System.EventHandler(this.btnMultNum_Click);
            // 
            // btnMult
            // 
            this.btnMult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnMult.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMult.Image = global::kursova.Properties.Resources.mult;
            this.btnMult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMult.Location = new System.Drawing.Point(0, 183);
            this.btnMult.Name = "btnMult";
            this.btnMult.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMult.Size = new System.Drawing.Size(325, 62);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "   Множення";
            this.btnMult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSub.FlatAppearance.BorderSize = 0;
            this.btnAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSub.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnAddSub.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSub.Image = global::kursova.Properties.Resources.add;
            this.btnAddSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSub.Location = new System.Drawing.Point(0, 121);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddSub.Size = new System.Drawing.Size(325, 62);
            this.btnAddSub.TabIndex = 1;
            this.btnAddSub.Text = "   Додавання й \r\n   віднімання";
            this.btnAddSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(325, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(325, 121);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1047, 608);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(325, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1047, 121);
            this.panelTitle.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 729);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор матриць";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnTranspose;
        private System.Windows.Forms.Button btnMultNum;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitle;
    }
}

