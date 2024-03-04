using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program102
{
    public partial class All_Objects : Form
    {
        public All_Objects() => InitializeComponent();

        //Заставка
        private DateTime DT; private int Tic;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DT = DT.AddSeconds(1);

            if (DT.ToString("mm:ss") == "02:30") { GIF_Planets.Enabled = true; GIF_Planets.Visible = true; timer1.Enabled = false; }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) => DT = new DateTime(0, 0);

        private void GIF_Planets_MouseMove(object sender, MouseEventArgs e)
        {
            Tic++;

            if (Tic > 2) { GIF_Planets.Enabled = false; GIF_Planets.Visible = false; timer1.Enabled = false; }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            DT = new DateTime(0, 0); DT = DT.AddMinutes(2); Tic = 0; timer1.Enabled = true;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            DT = new DateTime(0, 0); Tic = 0; timer1.Enabled = true;
        }

        //Настройки приложения по умолчанию
        private void Form1_Load(object sender, EventArgs e)
        {
            GIF_Planets.BringToFront(); GIF_Planets.Enabled = false; GIF_Planets.Visible = false;

            //Подпись космических объектов при наведении
            ToolTip Tylis = new ToolTip();
            Tylis.SetToolTip(SUN, "Солнце");
            Tylis.SetToolTip(Mercury, "Меркурий");
            Tylis.SetToolTip(Venus, "Венера");
            Tylis.SetToolTip(Earth, "Земля");
            Tylis.SetToolTip(Mars, "Марс");
            Tylis.SetToolTip(Jupiter, "Юпитер");
            Tylis.SetToolTip(Saturn, "Сатурн");
            Tylis.SetToolTip(Uranium, "Уран");
            Tylis.SetToolTip(Neptune, "Нептун");
        }

        //Солнце
        private void SUN_Click(object sender, EventArgs e)
        {
            Object.ID = 1; Object.PIC = SUN;
            new Object().ShowDialog();
        }

        //Меркурий
        private void Mercury_Click(object sender, EventArgs e)
        {
            Object.ID = 2; Object.PIC = Mercury;
            new Object().ShowDialog();
        }

        //Венера
        private void Venus_Click(object sender, EventArgs e)
        {
            Object.ID = 3; Object.PIC = Venus;
            new Object().ShowDialog();
        }

        //Земля
        private void Earth_Click(object sender, EventArgs e)
        {
            Object.ID = 4; Object.PIC = Earth;
            new Object().ShowDialog();
        }

        //Марс
        private void Mars_Click(object sender, EventArgs e)
        {
            Object.ID = 5; Object.PIC = Mars;
            new Object().ShowDialog();
        }

        //Юпитер
        private void Jupiter_Click(object sender, EventArgs e)
        {
            Object.ID = 6; Object.PIC = Jupiter;
            new Object().ShowDialog();
        }

        //Сатурн
        private void Saturn_Click(object sender, EventArgs e)
        {
            Object.ID = 7; Object.PIC = Saturn;
            new Object().ShowDialog();
        }

        //Уран
        private void Uranium_Click(object sender, EventArgs e)
        {
            Object.ID = 8; Object.PIC = Uranium;
            new Object().ShowDialog();
        }

        //Нептун
        private void Neptune_Click(object sender, EventArgs e)
        {
            Object.ID = 9; Object.PIC = Neptune;
            new Object().ShowDialog();
        }
    }
}