﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {

            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            //DoTimeConsumingWork();
            Thread BackgroundThread = new Thread(DoTimeConsumingWork);
            BackgroundThread.Start();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;

        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }

        private void DoTimeConsumingWork()
        {
            // Make the thread sleep, to introduce artifical latency
            Thread.Sleep(5000);
        }
    }
}
