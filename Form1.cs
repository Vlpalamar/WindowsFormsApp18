using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        Thread tP;
        Thread tF;

        public Form1()
        {
            InitializeComponent();
            MinUpDown.Value = 2;
            MinUpDown.Minimum = 2;
            MaxUpDown.Value = Int32.MaxValue;
            MaxUpDown.Maximum = Int32.MaxValue;
            PrimeProgressBar.Minimum = Convert.ToInt32(MinUpDown.Value);
            PrimeProgressBar.Maximum = Convert.ToInt32(MaxUpDown.Value);


            Fibanachi_UpDown.Minimum = 3;
            Fibanachi_UpDown.Maximum = Int32.MaxValue;
            Fibanachi_progress.Minimum = 2;
            
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartPrimeButt_Click(object sender, EventArgs e)
        {
            PrimeNumber prime = new PrimeNumber(ref PrimeProgressBar, ref PrimeListBox,
                Convert.ToUInt64(MinUpDown.Value), Convert.ToUInt64(MaxUpDown.Value));
            tP = new Thread(prime.run);
            tP.Start();

        }


        private void FibanachiStart_btn_Click_1(object sender, EventArgs e)
        {
            Fibanachi_progress.Maximum = Convert.ToInt32(Fibanachi_UpDown.Value);
            FibNumbers fib = new FibNumbers(ref Fibanachi_progress, ref FibanachiBox,
                Convert.ToInt32(Fibanachi_UpDown.Value));
            tF = new Thread(fib.run);
            tF.Start();
        }

        private void FibPause_btn_Click(object sender, EventArgs e)
        {
            if (FibNumbers.isPause==false)
            {
                FibNumbers.isPause = true;
                FibPause_btn.Text = "Continue";
                return;

            }

            if (FibNumbers.isPause)
            {
                FibNumbers.isPause = false;
                FibPause_btn.Text = "Pause";
                return;
            }
            
        }

        private void FibCansel_btn_Click(object sender, EventArgs e)
        {
            
            FibNumbers.isCansel = true;
            FibanachiBox.Items.Clear();
            Fibanachi_progress.Value=Fibanachi_progress.Minimum;
            Fibanachi_UpDown.Value = Fibanachi_UpDown.Minimum;
        }

        private void PrimePause_btn_Click(object sender, EventArgs e)
        {
            if (PrimeNumber.isPause == false)
            {
                PrimeNumber.isPause = true;
                PrimePause_btn.Text = "Continue";
                return;

            }

            if (PrimeNumber.isPause)
            {
                PrimeNumber.isPause = false;
                PrimePause_btn.Text = "Pause";
                return;
            }

        }

        private void PrimeCansel_btn_Click(object sender, EventArgs e)
        {
            PrimeNumber.isCansel = true;
            PrimeListBox.Items.Clear();
            PrimeProgressBar.Value = PrimeProgressBar.Minimum;
            MaxUpDown.Value = MaxUpDown.Maximum;
            MinUpDown.Value = MinUpDown.Minimum;
        }
    }
}
