using System;

namespace Charts
{
    public partial class Charts : MetroFramework.Forms.MetroForm
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pcCPU.NextValue();
            float fram = pcRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblProgPercentageCPU.Text = string.Format("{0:0.000%}", fcpu);
            lblProgPercentageRAM.Text = string.Format("{0:0.000%}", fram);
            chart.Series["CPU"].Points.AddY(fcpu);
            chart.Series["RAM"].Points.AddY(fram);
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
