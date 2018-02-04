using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VISSIM_COMSERVERLib;

namespace vissim二次开发测试
{
    public partial class Main : Form
    {
        public double[,] dataCollectionVehiclesNum = new double[100, 100]; //定义检测器车总数记录数组
        public double[,] dataCollectionOccupancyRate = new double[100, 100]; //定义检测器占有率记录数组
        public double[,] dataCollectionSpeed = new double[100, 100]; //定义检测器速度记录数组
        public double[,] linkEvaluationDensity = new double[100, 100];//定义路段密度记录数组
        public double[,] linkEvaluationSpeed = new double[100, 100];//定义路段速度记录数组
        public double[,] linkEvaluationVolume = new double[100, 100];//定义路段流量记录数组

        Vissim vis;
        Simulation sim;
        Net net;
        Links links;
        Link link;
        Evaluation evaluation;
        LinkEvaluation linkEvaluation;
        DataCollections dataCollections;
        DataCollection dataCollection;
        public void InitializeVissim()       //vissim初始化
        {
            vis = new Vissim();
            net = vis.Net;
            sim = vis.Simulation;
            //evaluation;  //定义评价对象
            evaluation = vis.Evaluation; //实例化评价对象
            evaluation.set_AttValue("NETPERFORMANCE", true); //激活路网评价
            evaluation.set_AttValue("LINK", true); //激活路段评价
            evaluation.set_AttValue("DATACOLLECTION", true); //激活检测器
            evaluation.set_AttValue("QUEUECOUNTER", true); //激活排队检测器
            evaluation.set_AttValue("SIGNALCHANGES", true);//激活信号灯变化检测
            //linkEvaluation; //路段评价对象
            linkEvaluation = evaluation.LinkEvaluation; //实例化路段评价对象
            linkEvaluation.AddParameter("DENSITY", 0); //激活密度检测
            linkEvaluation.AddParameter("SPEED", 0); //激活速度检测
            linkEvaluation.AddParameter("Volume", 0);//激活路段流量检测
            dataCollections = net.DataCollections;
            links = net.Links;
        }

        public Main()
        {
            InitializeComponent();
            InitializeVissim();//vissim初始化
            //vis = new Vissim();
        }

        private void OpenInp_Click(object sender, EventArgs e)
        {
            if (vis != null)
            {
                try
                {
                    vis.LoadNet();
                    InitializeVissim();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("请不要关闭vissim");
            }
        }

        private void OpenIni_Click(object sender, EventArgs e)
        {
            if (vis != null)
            {
                try
                {
                    vis.LoadLayout();
                }
                catch
                {

                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                vis.Exit();
            }
            catch
            {

            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            sim = this.sim;
            //link = links.GetEnumerator;
            try
            {
                sim.Speed = double.Parse(SimulationSpeed.Text.ToString());
                sim.Period = double.Parse(SimulationPeriod.Text.ToString());
                sim.Resolution = 1;
                for (int istep = 1; istep <= sim.Period; istep++)
                {
                    sim.RunSingleStep();
                    label4.Text = "仿真时间:" + istep.ToString();
                    if (istep != 0 && istep % int.Parse(evaP.Text.ToString()) == 0)
                    {
                        //link评价触发
                        for (int NOL = 1; NOL <= links.Count; NOL++)
                        {
                        //link = links.GetLinkByNumber(NOL);
                            link = links[NOL];
                            linkEvaluationSpeed[istep / int.Parse(evaP.Text.ToString()), NOL] = link.GetSegmentResult("SPEED", 0, 0, 1);
                            linkEvaluationDensity[istep / int.Parse(evaP.Text.ToString()), NOL] = link.GetSegmentResult("DENSITY", 0, 0, 1);
                            linkEvaluationVolume[istep / int.Parse(evaP.Text.ToString()), NOL] = link.GetSegmentResult("Volume", 0, 0, 1);
                        }
                        //datacollection评价触发
                        for(int NOD=1;NOD<=dataCollections.Count;NOD++)
                        {
                            dataCollection = dataCollections[NOD];
                            dataCollectionSpeed[istep / int.Parse(evaP.Text.ToString()), NOD] = dataCollection.GetResult("SPEED", "MEAN", 0);
                            dataCollectionVehiclesNum[istep / int.Parse(evaP.Text.ToString()), NOD] = dataCollection.GetResult("OCCUPANCYRATE", "MEAN", 0);
                            dataCollectionOccupancyRate[istep / int.Parse(evaP.Text.ToString()), NOD] = dataCollection.GetResult("NVEHICLES", "MEAN", 0);
                        }
                    }
                }

             }
            catch
            {
                MessageBox.Show("请输入正确的参数");
                sim.Stop();
            }
            sim.Stop();
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                sim = this.sim;
                //sim = vis.Simulation;
                sim.Stop();
            }
            catch
            {
                MessageBox.Show("仿真还未开始或已停止");
            }
        }


        private void comboBoxLinkEvaluation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linkNo = int.Parse(comboBoxLinkEvaluation.SelectedItem.ToString());
            dtLinkEvaluation.Rows.Clear();
            int p = int.Parse(sim.Period.ToString());
            int evap = int.Parse(evaP.Text.ToString());
            try
            {
                for (int i = 1; i <= p / evap; i++)
                {
                    int index = dtLinkEvaluation.Rows.Add();
                    dtLinkEvaluation.Rows[index].Cells[0].Value = i.ToString();
                    dtLinkEvaluation.Rows[index].Cells[1].Value = linkEvaluationSpeed[i, linkNo].ToString();
                    dtLinkEvaluation.Rows[index].Cells[2].Value = linkEvaluationDensity[i, linkNo].ToString();
                    dtLinkEvaluation.Rows[index].Cells[3].Value = linkEvaluationVolume[i, linkNo].ToString();
                }
            }
            catch
            {

            }
        }

        private void roadnum_Enter(object sender, EventArgs e)
        {
            comboBoxLinkEvaluation.Items.Clear();
            for (int NOL = 1; NOL <= links.Count; NOL++)
            {
                comboBoxLinkEvaluation.Items.Add(NOL.ToString());
            }
            comboBoxDatacollection.Items.Clear();
            for (int NOD = 1; NOD <= dataCollections.Count; NOD++)
            {
                comboBoxDatacollection.Items.Add(NOD.ToString());
            }
        }

        private void msnum_Enter(object sender, EventArgs e)
        {
            comboBoxDatacollection.Items.Clear();
            for (int NOD = 1; NOD <= dataCollections.Count; NOD++)
            {
                comboBoxDatacollection.Items.Add(NOD.ToString());
            }
        }

        private void comboBoxDatacollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DataNo = int.Parse(comboBoxDatacollection.SelectedItem.ToString());
            dataGridView2.Rows.Clear();
            int p = int.Parse(sim.Period.ToString());
            int evap = int.Parse(evaP.Text.ToString());
            try
            {
                for (int i = 1; i <= p / evap; i++)
                {
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = i.ToString();
                    dataGridView2.Rows[index].Cells[1].Value = dataCollectionSpeed[i, DataNo].ToString();
                    dataGridView2.Rows[index].Cells[2].Value = dataCollectionVehiclesNum[i, DataNo].ToString();
                    dataGridView2.Rows[index].Cells[3].Value = dataCollectionOccupancyRate[i, DataNo].ToString();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
