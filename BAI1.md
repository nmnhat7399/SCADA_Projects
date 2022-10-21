# BÀI 1: Khảo sát Windows Forms App (.NET framwork)
# GRAPHIC ELLEMENTS
# Các nội dung quan trọng
## Tính chất của các phần tử
*Tính chất của các phần tử* có thể được thay đổi trong `property` hoặc trong chương trình `Main.designer.cs`

## Tạo Timer cho hệ thống
Khi tạo `Timer` cần set thời gian trong `property` $\to$ `interval`. Đơn vị sẽ là `milisecond`. Đồng thời cần `Enable` Timer lên thành `true` hoặc có thể đổi trong chương trình.
Event của Timer này là `Tick` đóng vai trò tương tự như ngắt timer trong vi điều khiển.

## Hàm lấy thời gian hệ thống
```c#
DateTime Today = DateTime.Now;
Console.WriteLine(Today.ToString());
```
Lệnh này sẽ được viết trong hàm `MainTimer_Tick`

## Lệnh mô phỏng Motor hoạt động
    Motor = (Start || Motor) && !Stop;

## Hàm chuyển `string` textbox sang `interger`
Trong hàm `btConfirm_click`:
```c#
int temp;
bool ret = int32.TryParse(tbSetLevel.Text, out temp); //Chuyển ra số, có thể có lỗi nếu nhập chữ nên phải xử lý lỗi.
if(ret)
SetLevel = temp;
```

## Để dùng phím Enter thay cho nút Confirm
Dùng hàm `keydown` trong `event` của **textbox**
 ```c#
if (e.KeyCode == Keys.Enter)
{
int temp;
bool ret = int32.TryParse(tbSetLevel.Text, out temp);
if(ret)
    SetLevel = temp;
}
 ```
## Mọi hoạt động *mô phỏng* nên để trong `CtrlTimer_Tick`

# Code Project
## `Main.cs`
```c#
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
```