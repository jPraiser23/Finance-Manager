using System;
using System.IO;

namespace GeneralForm.Backend.Main
{
    class MainManager
    {
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + "CORE\\coreTopics";

        public void LibraryValidation()
        {
            Directory.CreateDirectory(path);

            //Test


        }


        public void LoadLibrary()
        {




        }


    }
}
