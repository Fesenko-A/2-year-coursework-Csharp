using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kursova {
    // Частина класу з описом функцій для роботи дизайну
    public partial class Form1 : Form {

        // Об'єкти для підсвічування натиснутої кнопки
        private Button currBtn;
        private Panel leftBorderBtn;

        // Об'єкт форми для відкриття нової сторінки по натисканню на кнопку
        private Form activeForm;

        public Form1() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 62);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        // Список кольорів для підсвічування лівого краю кнопки
        private static List<Color> colorButton = new List<Color>() {
            Color.FromArgb(235, 102, 0),
            Color.FromArgb(66, 17, 189),
            Color.FromArgb(2, 194, 50),
            Color.FromArgb(194, 20, 14),
            Color.FromArgb(7, 217, 196)

        };

        // Підсвітити натиснуту кнопку
        private void ActivateButton(object sender, Color color) {
            if (sender != null) {
                DisableButton();
                // Змінюємо вигляд кнопки
                currBtn = (Button)sender;
                currBtn.BackColor = Color.FromArgb(38, 39, 59);

                // Невеличке підсвічування кнопки зліва
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Підсвічування верхньої панелі
                panelTitle.BackColor = color;

                // Зміна кольору лівого верхнього кута на темніший
                panelLogo.BackColor = ChangeBrightness(color);
            }
        }

        // Прибрати підсвічування кнопки
        private void DisableButton() {
            if (currBtn != null) {
                currBtn.BackColor = Color.FromArgb(50, 52, 77);
            }
        }

        // Змінити колір та яскравість лівого верхнього кута
        private Color ChangeBrightness(Color color) {
            double red = color.R * 0.6;
            double green = color.G * 0.6;
            double blue = color.B * 0.6;

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        // Відкрити нову сторінку по натисканню на кнопку
        private void OpenChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
