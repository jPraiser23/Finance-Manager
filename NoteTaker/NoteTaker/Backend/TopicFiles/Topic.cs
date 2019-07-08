using GeneralForm.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralForm
{
    [Serializable]
    public class Topic
    {
        public String name;
        public String definition { get => definition; set => name = definition; }


        public bool HasSubTopics { get => HasSubTopics; set => HasSubTopics = value; }
        public bool HasConcepts { get => HasConcepts; set => HasConcepts = value; }
        public bool HasFacts { get => HasFacts; set => HasFacts = value; }
        public bool HasSources { get => HasSources; set => HasSources = value; }


        public List<String> subtopic_nameList = new List<string>();
        public List<String> concept_nameList = new List<string>();
        public List<String> fact_nameList = new List<string>();
        public List<String> source_nameList = new List<string>();


        public List<Topic> subtopicList = new List<Topic>();
        //public List<Concept> conceptList = new List<Concept>();
        //public List<Fact> factList = new List<Fact>();
        //public List<SourcePath> sourcePathList = new List<SourcePath>();


        public Topic (string inputName)
        {
            this.name = inputName;
        }
        public Topic(Topic inputTopic)
        {
            this.name = inputTopic.name;
            this.definition = inputTopic.definition;
        }

       
    }
}
