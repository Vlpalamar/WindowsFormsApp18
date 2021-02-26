using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public class PrimeNumber
    {
        public static bool isPause { get; set; } = false;
        public static bool isCansel { get; set; } = false;
        public ulong start { get; set; } = 2;
        public ulong end { get; set; }= Int32.MaxValue;

        public ProgressBar progressBar { get; set; }
        public ListBox listBox { get; set; }

        public PrimeNumber(ref ProgressBar progressBar , ref ListBox listBox,ulong start, ulong end)
        {
            this.start = start;
            this.progressBar = progressBar;
            this.listBox = listBox;
            this.end= end;
            
        }
        private  void whenFind(ulong val)
        {
            listBox.Invoke((MethodInvoker) (() =>
                    {
                        listBox.Refresh();
                        listBox.Items.Add(val); 

                    }
            ));
        }

        private void ProgrssUp()
        {
            progressBar.Invoke((MethodInvoker) (() =>
            {

                progressBar.Value = progressBar.Value+1; // значение value увеличевается но на форме progress bar пустой 
                progressBar.Refresh();
                
            }));
        }
        public void run()
        {
            isCansel = false;
            isCansel = false;
          
            for (ulong i = start; i < end; i++)
            {
                if (isCansel)
                {
                    return;
                }

                if (isPause)
                {
                    Thread.Sleep(2000);
                }
                bool Isprime = true;
                for (ulong j = 2; j < (i/2)+1; j++)
                {
                    if ( i%j==0)
                    {
                        Isprime = false;
                        break;
                    }   

                }

                if (Isprime)
                {
                    whenFind(i);
                }

                ProgrssUp();

            }
        }
    }
}