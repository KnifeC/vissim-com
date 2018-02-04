using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISSIM_COMSERVERLib;

namespace vissim二次开发测试
{
    class Tvissim
    {
        Vissim vis = new Vissim();
        Net net;
        Simulation sim;
        SignalControllers controllers;
        public Tvissim()//构造函数1
        {

        }
        /// <summary>
        /// 构造函数2
        /// </summary>
        /// <param name="s">.inp文件路径</param>
        public Tvissim(string s)//构造函数2
        {
            this.OpenINP(s);
        }
        /// <summary>
        /// 打开路网
        /// </summary>
        /// <param name="s">.inp文件路径</param>
        public void OpenINP(string s)
        {
            //Vissim vis = new Vissim();
            if (vis != null)
            {
                try
                {
                    vis.LoadNet(@s, 0);
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
        /// <summary>
        /// 加载配置文件
        /// </summary>
        /// <param name="s"></param>
        public void OpenINI(string s)
        {
            if(vis!=null)
            {
                vis.LoadLayout(s);
            }
        }
        public void close()
        {
            vis.Exit();
        }

        /// <summary>
        /// 开始仿真
        /// </summary>
        /// <param name="P1">仿真频率</param>
        /// <param name="S1">仿真速度</param>
        public void Start(double P1,double S1)
        {           
            Simulation sim = vis.Simulation;
            if (vis.Net != null)
            {
                try
                {
                    sim.Period = P1;
                    sim.Speed = S1;
                    sim.RunContinuous();
                }
                catch
                {
                    MessageBox.Show("仿真未正常结束！");
                    sim.Stop();
                }
            }
            else
                MessageBox.Show("请先打开路网");
        }
        /// <summary>
        /// 
        /// </summary>
        public void SigControl() 
        {
            SignalController controll;
            //List<SignalController> controller;
            SignalControllers controllers = vis.Net.SignalControllers;
            /*
            foreach(SignalController control in controllers)
            {
                controller.Add(controll);
            }
            */
        }
        public void netcon()
        {
            Net net = vis.Net;
        }
    }
 }
