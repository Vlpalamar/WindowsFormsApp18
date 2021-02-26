
namespace WindowsFormsApp18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrimePause_btn = new System.Windows.Forms.Button();
            this.MaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.StartPrimeButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrimeListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FibPause_btn = new System.Windows.Forms.Button();
            this.Fibanachi_progress = new System.Windows.Forms.ProgressBar();
            this.Fibanachi_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FibanachiStart_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FibanachiBox = new System.Windows.Forms.ListBox();
            this.FibCansel_btn = new System.Windows.Forms.Button();
            this.PrimeCansel_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fibanachi_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrimePause_btn);
            this.panel1.Controls.Add(this.MaxUpDown);
            this.panel1.Controls.Add(this.MinUpDown);
            this.panel1.Controls.Add(this.PrimeProgressBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StartPrimeButt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 124);
            this.panel1.TabIndex = 0;
            // 
            // PrimePause_btn
            // 
            this.PrimePause_btn.Location = new System.Drawing.Point(84, 25);
            this.PrimePause_btn.Name = "PrimePause_btn";
            this.PrimePause_btn.Size = new System.Drawing.Size(75, 23);
            this.PrimePause_btn.TabIndex = 8;
            this.PrimePause_btn.Text = "Pause";
            this.PrimePause_btn.UseVisualStyleBackColor = true;
            this.PrimePause_btn.Click += new System.EventHandler(this.PrimePause_btn_Click);
            // 
            // MaxUpDown
            // 
            this.MaxUpDown.Location = new System.Drawing.Point(83, 68);
            this.MaxUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.MaxUpDown.Name = "MaxUpDown";
            this.MaxUpDown.Size = new System.Drawing.Size(41, 20);
            this.MaxUpDown.TabIndex = 7;
            // 
            // MinUpDown
            // 
            this.MinUpDown.Location = new System.Drawing.Point(9, 68);
            this.MinUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.MinUpDown.Name = "MinUpDown";
            this.MinUpDown.Size = new System.Drawing.Size(41, 20);
            this.MinUpDown.TabIndex = 2;
            // 
            // PrimeProgressBar
            // 
            this.PrimeProgressBar.Location = new System.Drawing.Point(0, 94);
            this.PrimeProgressBar.Name = "PrimeProgressBar";
            this.PrimeProgressBar.Size = new System.Drawing.Size(237, 23);
            this.PrimeProgressBar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prime";
            // 
            // StartPrimeButt
            // 
            this.StartPrimeButt.Location = new System.Drawing.Point(3, 25);
            this.StartPrimeButt.Name = "StartPrimeButt";
            this.StartPrimeButt.Size = new System.Drawing.Size(75, 23);
            this.StartPrimeButt.TabIndex = 4;
            this.StartPrimeButt.Text = "Start";
            this.StartPrimeButt.UseVisualStyleBackColor = true;
            this.StartPrimeButt.Click += new System.EventHandler(this.StartPrimeButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // PrimeListBox
            // 
            this.PrimeListBox.FormattingEnabled = true;
            this.PrimeListBox.Location = new System.Drawing.Point(13, 201);
            this.PrimeListBox.Name = "PrimeListBox";
            this.PrimeListBox.Size = new System.Drawing.Size(187, 173);
            this.PrimeListBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FibPause_btn);
            this.panel2.Controls.Add(this.Fibanachi_progress);
            this.panel2.Controls.Add(this.Fibanachi_UpDown);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.FibanachiStart_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(314, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 124);
            this.panel2.TabIndex = 2;
            // 
            // FibPause_btn
            // 
            this.FibPause_btn.Location = new System.Drawing.Point(84, 25);
            this.FibPause_btn.Name = "FibPause_btn";
            this.FibPause_btn.Size = new System.Drawing.Size(75, 23);
            this.FibPause_btn.TabIndex = 10;
            this.FibPause_btn.Text = "Pause";
            this.FibPause_btn.UseVisualStyleBackColor = true;
            this.FibPause_btn.Click += new System.EventHandler(this.FibPause_btn_Click);
            // 
            // Fibanachi_progress
            // 
            this.Fibanachi_progress.Location = new System.Drawing.Point(0, 94);
            this.Fibanachi_progress.Name = "Fibanachi_progress";
            this.Fibanachi_progress.Size = new System.Drawing.Size(240, 23);
            this.Fibanachi_progress.Step = 1;
            this.Fibanachi_progress.TabIndex = 8;
            // 
            // Fibanachi_UpDown
            // 
            this.Fibanachi_UpDown.Location = new System.Drawing.Point(77, 68);
            this.Fibanachi_UpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.Fibanachi_UpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Fibanachi_UpDown.Name = "Fibanachi_UpDown";
            this.Fibanachi_UpDown.Size = new System.Drawing.Size(41, 20);
            this.Fibanachi_UpDown.TabIndex = 9;
            this.Fibanachi_UpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max";
            // 
            // FibanachiStart_btn
            // 
            this.FibanachiStart_btn.Location = new System.Drawing.Point(3, 25);
            this.FibanachiStart_btn.Name = "FibanachiStart_btn";
            this.FibanachiStart_btn.Size = new System.Drawing.Size(75, 23);
            this.FibanachiStart_btn.TabIndex = 8;
            this.FibanachiStart_btn.Text = "Start";
            this.FibanachiStart_btn.UseVisualStyleBackColor = true;
            this.FibanachiStart_btn.Click += new System.EventHandler(this.FibanachiStart_btn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fibanachi";
            // 
            // FibanachiBox
            // 
            this.FibanachiBox.FormattingEnabled = true;
            this.FibanachiBox.Location = new System.Drawing.Point(314, 201);
            this.FibanachiBox.Name = "FibanachiBox";
            this.FibanachiBox.Size = new System.Drawing.Size(187, 173);
            this.FibanachiBox.TabIndex = 3;
            // 
            // FibCansel_btn
            // 
            this.FibCansel_btn.Location = new System.Drawing.Point(479, 68);
            this.FibCansel_btn.Name = "FibCansel_btn";
            this.FibCansel_btn.Size = new System.Drawing.Size(75, 23);
            this.FibCansel_btn.TabIndex = 11;
            this.FibCansel_btn.Text = "Cansel";
            this.FibCansel_btn.UseVisualStyleBackColor = true;
            this.FibCansel_btn.Click += new System.EventHandler(this.FibCansel_btn_Click);
            // 
            // PrimeCansel_btn
            // 
            this.PrimeCansel_btn.Location = new System.Drawing.Point(169, 68);
            this.PrimeCansel_btn.Name = "PrimeCansel_btn";
            this.PrimeCansel_btn.Size = new System.Drawing.Size(75, 23);
            this.PrimeCansel_btn.TabIndex = 9;
            this.PrimeCansel_btn.Text = "Cansel";
            this.PrimeCansel_btn.UseVisualStyleBackColor = true;
            this.PrimeCansel_btn.Click += new System.EventHandler(this.PrimeCansel_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrimeCansel_btn);
            this.Controls.Add(this.FibCansel_btn);
            this.Controls.Add(this.FibanachiBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PrimeListBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fibanachi_UpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar PrimeProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartPrimeButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PrimeListBox;
        private System.Windows.Forms.NumericUpDown MaxUpDown;
        private System.Windows.Forms.NumericUpDown MinUpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar Fibanachi_progress;
        private System.Windows.Forms.NumericUpDown Fibanachi_UpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FibanachiStart_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox FibanachiBox;
        private System.Windows.Forms.Button PrimePause_btn;
        private System.Windows.Forms.Button FibPause_btn;
        private System.Windows.Forms.Button FibCansel_btn;
        private System.Windows.Forms.Button PrimeCansel_btn;
    }
}

