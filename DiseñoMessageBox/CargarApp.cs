using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectMaster.DiseñoMessageBox
{
    public partial class CargarApp : Form
    {
        private Timer timer;

        public CargarApp()
        {
            InitializeComponent();
            this.CenterToScreen();
            lblEslogan.BringToFront();
            // Configurar el Timer
            timer = new Timer();
            timer.Interval = 5000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private void PcbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
