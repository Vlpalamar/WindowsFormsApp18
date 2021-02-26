using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public class FibNumbers
    {
        public static bool isCansel { get; set; } = false;
        public static bool isPause { get; set; } = false;

        public static int end { get; set; }
        public ProgressBar fibProgressBar { get; set; }
        public ListBox FibListBox { get; set; }

        private List<int> fibNumbers = new List<int>();


       

        public FibNumbers(ref ProgressBar fibProgressBar, ref ListBox fiblist, int whenEnd)
        {

            this.fibProgressBar = fibProgressBar;
            this.FibListBox = fiblist;
            end = whenEnd;
        }
        public void whenFind(int val)
        {
            FibListBox.Invoke((MethodInvoker)(() =>
                    {
                       
                        FibListBox.Items.Add(val);
                    }
                ));
        }

        public void ProgressUp()
        {
            fibProgressBar.Invoke((MethodInvoker)(() =>
                    {
                        fibProgressBar.Refresh();
                        fibProgressBar.Value = fibProgressBar.Value + 1; 
                    }
                ));
        }
        public void run()
        {
            FibListBox.Invoke((MethodInvoker) (() =>
                    {
                        FibListBox.Items.Clear();
                        FibListBox.Items.Add(0);
                        FibListBox.Items.Add(1);
                    }
                ));
            fibNumbers.Clear();
            fibNumbers.Add(0);
            fibNumbers.Add(1);
            isCansel = false;
            isPause = false;
            int i = 0; //всего итераций
            int j = 2; //чисел которые подошли
            while (j<end)
            {
                if (isCansel==true)
                {
                    return;
                }

                if (isPause==true)
                {
                    Thread.Sleep(2000);
                }
                if (fibNumbers[j-1]+ fibNumbers[j - 2]==i) //можно конечно просто прибавлять эти 2 числа  но нам надо нагрузить программу что бы реализвовать паузу и отмену
                {
                    j++;
                    fibNumbers.Add(i);
                    whenFind(i);
                    ProgressUp();

                }

                i++;
            }
        }

    }
}