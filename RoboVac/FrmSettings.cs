using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboVac
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int y = (int)nudWidth.Value;
            int x = (int)nudHeight.Value;
            int scale = (int)nudScale.Value;
            int noObs = (int)nudObstacles.Value;

            this.Hide();
            new FrmMain(x, y, scale, noObs).ShowDialog();
            this.Show();
        }
    }
}
