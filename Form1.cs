using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_11___GUI_assignment_2
{
    public partial class FormTemperatureGauge : Form
    {
        public FormTemperatureGauge()
        {
            InitializeComponent();
        }

        private void FormTemperatureGauge_Load(object sender, EventArgs e)
        {
            trackBarTemperature.Value = 0;
            this.BackgroundImage = Properties.Resources.Neutral;
        }

        private void trackBarTemperature_ValueChanged(object sender, EventArgs e)
        {

        }

        int temperature;

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            if (trackBarTemperature.Value >= 85)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Burnt_to_a_crisp;
            }
            else if (trackBarTemperature.Value >= 65 && trackBarTemperature.Value <= 85)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___On_fire;
            }
            else if (trackBarTemperature.Value >= 40 && trackBarTemperature.Value <= 65)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Really_Hot;
            }
            else if (trackBarTemperature.Value >= 30 && trackBarTemperature.Value <= 40)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Hot;
            }
            else if (trackBarTemperature.Value >= 20 && trackBarTemperature.Value <= 30)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Warm;
            }
            else if (trackBarTemperature.Value >= 10 && trackBarTemperature.Value <= 20)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy;
            }
            else if (trackBarTemperature.Value >= -10 && trackBarTemperature.Value <= 10)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Chilly;
            }
            else if (trackBarTemperature.Value <= -10 && trackBarTemperature.Value >= -50)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Cold;
            }
            else if (trackBarTemperature.Value <= -50)
            {
                imgTempGuy.Image = Properties.Resources.Temperature_guy___Frozen;
            }

            temperature = trackBarTemperature.Value;
            lblTempDegrees.Text = temperature.ToString() + "°C";
        }
    }
}
