using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1_Delegates_Task5
{
    public partial class Form1 : Form
    {
        private delegate void ToggleHandler(EventHandler ev);
        private ToggleHandler[] toggle;

        private Color[] Colors = { Color.LightGray, Color.Yellow, Color.LightGreen, Color.LightBlue, Color.Plum };
        private int colorIndex = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;

           
            toggle = new ToggleHandler[2];
            toggle[0] = RemoveAction;
            toggle[1] = AddAction;

            btnOpacity.Click += ActionTransparent;
            btnColor.Click += ActionColor;
            btnHello.Click += ActionHello;
        }

        private void AddAction(EventHandler ev) => btnSuper.Click += ev;
        private void RemoveAction(EventHandler ev) => btnSuper.Click -= ev;

        public void ActionTransparent(object sender, EventArgs e) => this.Opacity = (this.Opacity < 1.0) ? 1.0 : 0.7;

        public void ActionColor(object sender, EventArgs e)
        {
            colorIndex = (colorIndex + 1) % Colors.Length;
            this.BackColor = Colors[colorIndex];
        }

        public void ActionHello(object sender, EventArgs e)
        {
            MessageBox.Show("hello World");
        }

        public void buttonSuper(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        public void chbOpacity_CheckedChanged(object sender, EventArgs e)
        {
            toggle[Convert.ToInt32(chbOpacity.Checked)](ActionTransparent);
        }

        public void chbColor_CheckedChanged(object sender, EventArgs e)
        {
            toggle[Convert.ToInt32(chbColor.Checked)](ActionColor);
        }

        public void chbHello_CheckedChanged(object sender, EventArgs e)
        {
            toggle[Convert.ToInt32(chbHello.Checked)](ActionHello);
        }
    }
}