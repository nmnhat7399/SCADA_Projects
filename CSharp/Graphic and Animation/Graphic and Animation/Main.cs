using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_and_Animation
{
    public partial class Main : Form
    {
        bool Start;
        bool Stop;
        bool Motor;
        bool Direction;
        int SetLevel;
        int Level;

        public Main()
        {
            InitializeComponent();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            Console.WriteLine(Today.ToString());
            lbNow.Text = Today.ToString();
            lbMotor.Text = Motor ? "Running" : "Stopped";
            Console.WriteLine($"Direction State: {Direction}");
            Console.WriteLine($"SetLevel is: {SetLevel}");
            Console.WriteLine($"Level is: {Level}");
            Console.WriteLine("===========================");

            lbLevel.Text = Level.ToString();
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            Start = true;
        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {
            Start = false;
        }

        private void btStop_MouseDown(object sender, MouseEventArgs e)
        {
            Stop = true;
        }

        private void btStop_MouseUp(object sender, MouseEventArgs e)
        {
            Stop= false;
        }

        private void CtrlTimer_Tick(object sender, EventArgs e)
        {
            Motor = (Start||Motor)&&!Stop;
            if (Direction)
            {
                Level++;
                if (Level > SetLevel)
                    Level = SetLevel;
            }
            else
            {
                Level--;
                if (Level < 0)
                    Level = 0;
            }
        }

        private void btDirection_Click(object sender, EventArgs e)
        {
            Direction = !Direction;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int temp;
            bool ret = Int32.TryParse(tbSetLevel.Text, out temp);//xu ly loi
            if (ret)
                SetLevel = temp;
        }

        private void tbSetLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int temp;
                bool ret = Int32.TryParse(tbSetLevel.Text, out temp);//xu ly loi
                if (ret)
                    SetLevel = temp;
            }
        }
    }
}
