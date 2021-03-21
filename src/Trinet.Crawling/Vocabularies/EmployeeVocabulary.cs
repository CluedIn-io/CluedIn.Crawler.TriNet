using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;


namespace CluedIn.Crawling.Trinet.Vocabularies
{
    public class EmployeeVocabulary : SimpleVocabulary
    {
        public EmployeeVocabulary()
        {
            VocabularyName = "Trinet Employee"; // TODO: Set value
            KeyPrefix = "trinet.Employee"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "/Employee"; // TODO: Check value

            AddGroup("Trinet Details", group =>
            {
                Degree = group.Add(new VocabularyKey("Degree", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey("EndDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Discipline = group.Add(new VocabularyKey("Discipline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchoolName = group.Add(new VocabularyKey("SchoolName", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

        }
     
        public VocabularyKey Degree { get; internal set; }
        public VocabularyKey EndDate { get; internal set; }
        public VocabularyKey Discipline { get; internal set; }
        public VocabularyKey SchoolName { get; internal set; }
        public VocabularyKey StartDate { get; internal set; }
    }
}


