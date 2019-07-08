using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralForm.Backend.Main
{
    class MainManager
    {
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void LibraryValidation()
        {
            Directory.CreateDirectory(path + "\\" + "CORE");
            Directory.CreateDirectory(path + "\\" + "CORE\\coreTopics");

            //Test
            TopicManager tm = new TopicManager();
            Topic nTopic = new Topic("testTopic");

            tm.AddNewTopic(nTopic);

        }


    }
}
