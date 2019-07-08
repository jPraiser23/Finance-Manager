using System;
using System.Windows.Forms;

namespace GeneralForm.GUI
{
    public partial class ADD_TOPIC_FORM : Form
    {
        public ADD_TOPIC_FORM()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        public string nameTopic = "";
        public string definitionTopic = "";

        private void Accept_BTN_Click(object sender, EventArgs e)
        {
            //Accept New Topic Button

            //Validation:
                //TODO: Add Validation for Topic inputs

            //Valid Return Information:
            string nameTopic = name_topic_TB.Text;
            string definitionTopic = definition_topic_TB.Text;


            //Return Items to Main form
            
            this.nameTopic = nameTopic;
            this.definitionTopic = definitionTopic;
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }
    }
}
