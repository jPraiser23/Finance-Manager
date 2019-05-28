using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralForm
{
    public partial class form : Form
    {

   

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,     // x-coordinate of upper-left corner
       int nTopRect,      // y-coordinate of upper-left corner
       int nRightRect,    // x-coordinate of lower-right corner
       int nBottomRect,   // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse // width of ellipse
   );

        List<Panel> panelList = new List<Panel>();

        public form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panelList.Add(pnl1);
            panelList.Add(pnl2);
            panelList.Add(pnl3);
            panelList.Add(pnl4);
            panelList.Add(pnl5);


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TopPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }




        bool moving;
        Point offset;
        Point original;

        private void TopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            TOP_PNL.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void TopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void TopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            TOP_PNL.Capture = false;
        }

 

        private void Button24_Click(object sender, EventArgs e)
        {

        }



        private void MenuBtn1_Click(object sender, EventArgs e)
        {
            switchPanel(1);
        }

        private void MenuBtn2_Click(object sender, EventArgs e)
        {
            switchPanel(2);
        }

        private void MenuBtn3_Click(object sender, EventArgs e)
        {
            switchPanel(3);
        }

        private void MenuBtn4_Click(object sender, EventArgs e)
        {
            switchPanel(4);
        }

        private void MenuBtn5_Click(object sender, EventArgs e)
        {
            switchPanel(5);

        }




        private void switchPanel(int index)
        {


            for(int i = 0; i < panelList.Count; i++)
            {
                if( i + 1 == index )
                {
                    panelList[i].Show();
                }
                else
                {
                    panelList[i].Hide();
                }

            }


        }

        private void CircularProgressBar14_Click(object sender, EventArgs e)
        {

        }
    }
}
