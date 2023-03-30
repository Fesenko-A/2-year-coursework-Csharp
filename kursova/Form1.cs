using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova {
    // Клас з логікою програми
    public partial class Form1 : Form {

        // Кнопка "Додавання й віднімання"
        private void btnAddSub_Click(object sender, EventArgs e) {
            ActivateButton(sender, colorButton[0]);
            OpenChildForm(new Forms.FormAddSub());
        }

        // Кнопка "Множення"
        private void btnMult_Click(object sender, EventArgs e) {
            ActivateButton(sender, colorButton[1]);
            OpenChildForm(new Forms.FormMult());
        }

        // Кнопка "Множення на число"
        private void btnMultNum_Click(object sender, EventArgs e) {
            ActivateButton(sender, colorButton[2]);
            OpenChildForm(new Forms.FormMultNum());
        }

        // Кнопка "Транспонування"
        private void btnTranspose_Click(object sender, EventArgs e) {
            ActivateButton(sender, colorButton[3]);
            OpenChildForm(new Forms.FormTranspose());
        }
    }
}