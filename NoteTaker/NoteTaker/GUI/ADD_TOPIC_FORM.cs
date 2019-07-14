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
        public Topic topic;
        private void Accept_BTN_Click(object sender, EventArgs e)
        {

            //Validation:
            //TODO: Validated topic String inputs
            string nameTopic = name_topic_TB.Text;
            string definitionTopic = definition_topic_TB.Text;

            topic = new Topic(nameTopic, definitionTopic);
            DialogResult = DialogResult.OK;
            Hide();

        }
    }
}
