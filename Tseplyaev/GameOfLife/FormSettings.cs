using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class FormSettings : Form
    {
        public ushort speedSize;
        public FormSettings(ushort speedSize1, ushort lifeSize)
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;
            speedSize = speedSize1;
            label_Speed.Text = String.Format("Скорость генерации: {0} ms", speedSize);
            numericUpDown1.Value = lifeSize;
            trackBar1.Value = speedSize1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_Speed.Text = String.Format("Скорость генерации: {0} ms", trackBar1.Value);
            speedSize = (ushort)trackBar1.Value;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                // зададим новые данные, по которым будет новая отрисовка
                main.SetData(new Generation((ushort)numericUpDown1.Value), (ushort)numericUpDown1.Value,
                    speedSize);
                this.Close();
            }
        }
    }
}
