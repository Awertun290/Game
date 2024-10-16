using System.Runtime.InteropServices;
using System;

namespace Практика_7_.Net._8._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random.Shared.Shuffle(CollectionsMarshal.AsSpan(Global.images));

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(90 + 60 * j, 120 + 60 * i);
                    button.Size = new Size(60, 60);
                    //button.Image = Image.FromFile(@"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7\Практика_7\Стрелочки\Шаблон.png");
                    this.Controls.Add(button);
                    Global.buttons.Add(button);
                }
            }

            for (int i = 0; i < Global.buttons.Count; i++)
            {
                Global.buttons[i].Tag = i;
                Global.buttons[i].Image = Image.FromFile(Global.images[i]);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            for (int i = 0; i < Global.buttons.Count; i++)
            {
                Global.buttons[i].Image = Image.FromFile(@"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Шаблон.png");
                Global.buttons[i].Click += new EventHandler(button_Click);
                timer1.Start();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.Image = Image.FromFile(Global.images[(int)clickedButton.Tag]);

            if (!Global.pair.Any())
            {
                Global.pair.Add(clickedButton.Tag);
            }
            else
            {
                Global.pair.Add(clickedButton.Tag);
                popytki.Text = Convert.ToString(Convert.ToInt32(popytki.Text) + 1);

                if (Global.images[(int)Global.pair[0]] == Global.images[(int)Global.pair[1]])
                {
                    sovpadenia.Text = Convert.ToString(Convert.ToInt32(sovpadenia.Text) + 1);
                    Global.pair.Clear();
                }
                else
                {
                    Global.buttons[(int)Global.pair[0]].Image = Image.FromFile(@"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Шаблон.png");
                    Global.buttons[(int)Global.pair[1]].Image = Image.FromFile(@"C:\Users\ptrdm\Desktop\Отчёты\Разработка програмных модулей\Windows Forms\Практика_7_.Net.8.0\Практика_7_.Net.8.0\Стрелочки\Шаблон.png");
                    Global.pair.Clear();
                }
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            popytki.Text = popytki.Text;
            sovpadenia.Text = sovpadenia.Text;
        }
    }
}
