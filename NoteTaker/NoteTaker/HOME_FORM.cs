using GeneralForm.Backend;
using GeneralForm.Backend.Main;
using GeneralForm.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GeneralForm
{

    public partial class HOME_FORM : Form
    {
        private readonly MainManager main = new MainManager();
        TopicManager topicManager = new TopicManager();

        public List<Topic> topics = new List<Topic>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
        private bool moving;
        private Point offset;
        private Point original;
        private readonly List<Panel> panelList = new List<Panel>();
        public HOME_FORM()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panelList.Add(addTopicPnl);
            panelList.Add(addNotePnl);
        }
        private void HomeFormLoad(object sender, EventArgs e)
        {
            main.LibraryValidation();
        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void TopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            TOP_PNL.Capture = true;
            offset = MousePosition;
            original = Location;
        }
        private void TopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
            {
                return;
            }

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            Location = new Point(x, y);
        }
        private void TopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            TOP_PNL.Capture = false;
        }


        private void MenuBtn1_Click(object sender, EventArgs e)
        {
            using (ADD_TOPIC_FORM addTopicForm = new ADD_TOPIC_FORM())
            {
                if (addTopicForm.ShowDialog() == DialogResult.OK)
                {
                    topics.Add(addTopicForm.topic);
                    UpdateTopicList();

                }
            }
        }
        private void MenuBtn2_Click(object sender, EventArgs e)
        {
            using (VIEW_TOPIC_FORM form = new VIEW_TOPIC_FORM())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
        private void MenuBtn3_Click(object sender, EventArgs e)
        {
            using (EDIT_TOPIC_FORM form = new EDIT_TOPIC_FORM())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }


        //HERE
        private void UpdateTopicList()
        {
            topicList_TBL.Items.Clear();

            foreach (Topic item in topics)
            {
                topicList_TBL.Items.Add(item.name);
                topicManager.AddNewTopic(item);
            }
            topicList_TBL.Refresh();
        }


    }
}
