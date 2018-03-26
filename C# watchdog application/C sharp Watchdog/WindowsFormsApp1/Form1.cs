using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace WindowsFormsApp1
{
        public partial class AK_Watchdog : Form
    {
        public AK_Watchdog()
        {
            InitializeComponent();
            string strAppStatus;
            string strTimer();
        }

        private void AK_Watchdog_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("ihdifh");
        }
    }
}
