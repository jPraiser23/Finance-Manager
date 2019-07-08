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

        public List<Topic> topics = new List<Topic>();
        MainManager main = new MainManager();
       
        //Add Topic Panel
        //public void addTopic()
        //{
        //    string newTopicName = addTopicTBox.Text;

        //    if (topicList.Items.Contains(newTopicName))
        //    {
        //        MessageBox.Show("The " + newTopicName + " is already in use. " );
        //    }
        //    else if(newTopicName != null && !(newTopicName.Length < 2))
        //    {
        //        Topic newTopic = new Topic(newTopicName);
        //        topics.Add(newTopic);
        //        updateTopicList();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid value!");
        //    }

        //}

        //Edit Topic 
        //Select Topic to edit
        public Topic selectedTopic;


        //Add
            //Note

            //Def





        public void updateTopicList()
        {
            topicList.Items.Clear();
            foreach(Topic top in topics)
            {
                topicList.Items.Add(top.name);
            }
        }




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

        public HOME_FORM()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            panelList.Add(addTopicPnl);
            panelList.Add(addNotePnl);
            panelList.Add(pnl3);
            panelList.Add(pnl4);
            panelList.Add(pnl5);


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeFormLoad(object sender, EventArgs e)
        {
            main.LibraryValidation();
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

 

  


        private void MenuBtn1_Click(object sender, EventArgs e)
        {
            //ADD_BTN CLICKED
            using (ADD_TOPIC_FORM addTopicForm = new ADD_TOPIC_FORM())
            {
                string topic_Name = "";
                string topic_Definition = "";

                if(addTopicForm.ShowDialog() == DialogResult.OK)
                {
                    topic_Name = addTopicForm.nameTopic;
                    topic_Definition = addTopicForm.definitionTopic;
                    
                }
                Console.WriteLine("Name: " + topic_Name);
                Console.WriteLine("Definition: " + topic_Definition);
            }



            //current_panelName.Text = "Add Topic";
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




        private void AddNoteBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddNoteTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
