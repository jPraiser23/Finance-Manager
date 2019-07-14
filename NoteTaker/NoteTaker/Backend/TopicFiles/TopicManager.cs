using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GeneralForm.Backend
{
    class TopicManager
    {
        //TODO: Create Topic List
        List<Topic> topics;

        //TODO: Load Topic List

        public void AddNewTopic(Topic nTopic)
        {
            this.SaveTopic(nTopic, "\\CORE\\coreTopics");
        }

        public void SaveTopic(Topic topic, string corePath)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += corePath + "\\" + topic.name;

            //Make topic Directory
            Directory.CreateDirectory(path);
            //Make subdir 
            Directory.CreateDirectory(path + "\\" + "tpcList");
            Directory.CreateDirectory(path + "\\" + "cptList");
            Directory.CreateDirectory(path + "\\" + "fctList");
            Directory.CreateDirectory(path + "\\" + "srcList");

            //TODO: Save topic file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path + "\\" +topic.name + ".tpc", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, topic);
            stream.Close();


            //TODO: Verify save
            //Stream stream2 = new FileStream(path +"\\"+ topic.name + ".tpc", FileMode.Open, FileAccess.Read);
        }

    

    }
}
