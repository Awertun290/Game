namespace Практика_7_.Net._8._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            popytki = new Label();
            buttonStart = new Button();
            buttonQuit = new Button();
            sovpadenia = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(29, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Количество попыток: ";
            // 
            // popytki
            // 
            popytki.AutoSize = true;
            popytki.Font = new Font("Segoe UI", 14F);
            popytki.Location = new Point(241, 9);
            popytki.Margin = new Padding(2, 0, 2, 0);
            popytki.Name = "popytki";
            popytki.Size = new Size(22, 25);
            popytki.TabIndex = 1;
            popytki.Text = "0";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(29, 260);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(105, 30);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(151, 260);
            buttonQuit.Margin = new Padding(2);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(105, 30);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Выйти";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // sovpadenia
            // 
            sovpadenia.AutoSize = true;
            sovpadenia.Font = new Font("Segoe UI", 14F);
            sovpadenia.Location = new Point(255, 32);
            sovpadenia.Margin = new Padding(2, 0, 2, 0);
            sovpadenia.Name = "sovpadenia";
            sovpadenia.Size = new Size(22, 25);
            sovpadenia.TabIndex = 5;
            sovpadenia.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(29, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 25);
            label3.TabIndex = 4;
            label3.Text = "Количество сопадений:";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 345);
            Controls.Add(sovpadenia);
            Controls.Add(label3);
            Controls.Add(buttonQuit);
            Controls.Add(buttonStart);
            Controls.Add(popytki);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label popytki;
        private Button buttonStart;
        private Button buttonQuit;
        private Label sovpadenia;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
