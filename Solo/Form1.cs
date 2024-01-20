using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo
{
    public partial class Form1 : Form
    {
        int total_symbols;
        int typed_symbols;
        DateTime start_time;
        DateTime current_time;
        int speed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            try
            {
                label_text.Text = File.ReadAllText("solo.txt");
            }
            catch
            {
                label_text.Text = "Текст для набора нужно разместить в файле solo.txt";
            }
            text_type.Text = "";
            total_symbols = label_text.Text.Length;
            typed_symbols = 0;
            start_time = DateTime.Now;
            current_time = DateTime.Now;
            speed = 0;
            timer.Enabled = true;
        }

        private void text_type_KeyUp(object sender, KeyEventArgs e)
        {
            ShowStat();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowStat();
        }

        private void ShowStat()
        {
            typed_symbols = text_type.Text.Length;
            label_type_info.Text = typed_symbols.ToString() + "/" + total_symbols.ToString()+"сим";
            current_time = DateTime.Now;

            bool error; 
            if (typed_symbols > 0)
            {
                if (label_text.Text.StartsWith(text_type.Text))
                    error = false;
                else
                    error = true;
            }
            else
            {
                error = false;
                start_time = DateTime.Now;
            }
            text_type.BackColor = error ? Color.LightPink : Color.White;

            double seconds = (current_time.Ticks - start_time.Ticks) / 10000000.0;
            label_time_info.Text = seconds.ToString("0.0") + "сек";
            if (seconds > 0.1)
                speed = Convert.ToInt16(typed_symbols * 60 / seconds);
            else
                speed = 0;
            label_speed_info.Text = speed.ToString() + "сим/мин";

            if (!error && typed_symbols == total_symbols)
            {
                FinishGame();
            }
        }

        private void FinishGame()
        {
            timer.Enabled = false;
            MessageBox.Show("Набор закончен. Ваша скорость: " + label_speed_info.Text, "Поздравляем");
            Init();
        }
    }
}
