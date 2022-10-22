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
        // Variable 1
        bool Start;
        bool Stop;
        bool Motor;
        //Variable 2
        bool Direction;
        int SetLevel;
        int Level;
        //Variable 3
        int Motor_Pos;

        // Import Image
        Image pump_red = Image.FromFile(@"Image\pump_base_red.gif");
        Image pump_green = Image.FromFile(@"Image\pump_base_green.gif");
        Image direction_up = Image.FromFile(@"Image\Slide_switch_up.png");
        Image direction_down = Image.FromFile(@"Image\Slide_switch_down.png");
        Image button_off = Image.FromFile(@"Image\button_red_off.wmf");
        Image button_on = Image.FromFile(@"Image\button_red_on.wmf");

        // Import List Image
        List<Image> agitators = new List<Image>();
        List<Image> screws = new List<Image>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Image agitator = Image.FromFile($@"Image\agitator_{i + 1}.gif");
                Image screw = Image.FromFile($@"Image\screw_{i + 1}.gif");
                agitators.Add(agitator);
                screws.Add(screw);
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //Time
            DateTime Today = DateTime.Now;
            Console.WriteLine(Today.ToString());
            lbNow.Text = Today.ToString();
            //Motor SIM
            lbMotor.Text = Motor ? "Running" : "Stopped";
            lbMotor.ForeColor = Motor ? Color.LimeGreen : Color.Red;
            // Console
            Console.WriteLine($"Direction State: {Direction}");
            Console.WriteLine($"SetLevel is: {SetLevel}");
            Console.WriteLine($"Level is: {Level}");
            Console.WriteLine("===========================");

            lbLevel.Text = Level.ToString();

            if (!Motor)
            {
                pbMotor.BackgroundImage = pump_red;
                pbMotor.BackColor = Color.Transparent;
                pbMotor.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbMotor.BackgroundImage = pump_green;
                pbMotor.BackColor = Color.Transparent;
                pbMotor.BackgroundImageLayout = ImageLayout.Stretch;
            }

            //Config ben form
            //Direction
            if (!Direction)
                pbDirection.BackgroundImage = direction_down;
            else
                pbDirection.BackgroundImage = direction_up;
            // Start
            if (!Start)
                pbStart.BackgroundImage = button_off;
            else
                pbStart.BackgroundImage = button_on;

            //Animation
            pbAgitator.BackgroundImage = agitators[Motor_Pos];
            pbScrew.BackgroundImage = screws[Motor_Pos];
            
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
            
            if (Motor)
            {
                Motor_Pos++;
                if (Motor_Pos == 4)
                    Motor_Pos = 0;
            }
            
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

        private void pbDirection_Click(object sender, EventArgs e)
        {
            Direction = !Direction;
        }

        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            Start = true;
        }

        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            Start = false;
        }
    }
}
