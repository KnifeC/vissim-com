using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VISSIM_COMSERVERLib;

namespace vissim二次开发测试
{
    public partial class Form1 : Form
    {
        Tvissim tv = new Tvissim();

        public Form1()
        {
            InitializeComponent();
            Tvissim tv = new Tvissim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        public void openfiles(string s)
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.ShowDialog();
            open.Filter = s;

        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            //openfiles("*.inp");
            tv.OpenINP("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <=int.Parse(times.Text);i++)
                    tv.Start(double.Parse(SimulationPeriod.Text), double.Parse(SimulationSpeed.Text));
            }
            catch
            {
                MessageBox.Show("请检查输入的数据");
            }
        }

        private void peizhi_Click(object sender, EventArgs e)
        {
            tv.OpenINI("");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.close();
        }
    }
}
