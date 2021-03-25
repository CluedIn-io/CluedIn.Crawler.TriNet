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
                BusinessTitle = group.Add(new VocabularyKey("BusinessTitle", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGroupA = group.Add(new VocabularyKey("CustomGroupA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomGroupB = group.Add(new VocabularyKey("CustomGroupB", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey("Department", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey("EffectiveDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeClass = group.Add(new VocabularyKey("EmployeeClass", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeType = group.Add(new VocabularyKey("EmployeeType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStatus = group.Add(new VocabularyKey("EmploymentStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventCode = group.Add(new VocabularyKey("EventCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventDesc = group.Add(new VocabularyKey("EventDesc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlsaCode = group.Add(new VocabularyKey("FlsaCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobCode = group.Add(new VocabularyKey("JobCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey("Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayGroup = group.Add(new VocabularyKey("PayGroup", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey("ReasonCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDesc = group.Add(new VocabularyKey("ReasonDesc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegularTemporary = group.Add(new VocabularyKey("RegularTemporary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceDate = group.Add(new VocabularyKey("ServiceDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardHours = group.Add(new VocabularyKey("StandardHours", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Supervisor = group.Add(new VocabularyKey("Supervisor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminationDate = group.Add(new VocabularyKey("TerminationDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkEmail = group.Add(new VocabularyKey("WorkEmail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkersCompCode = group.Add(new VocabularyKey("WorkersCompCode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkPhone = group.Add(new VocabularyKey("WorkPhone", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternateId = group.Add(new VocabularyKey("AlternateId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeId = group.Add(new VocabularyKey("EmployeeId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            this.AddMapping(this.WorkEmail, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            this.AddMapping(this.WorkPhone, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);

        }
     
        public VocabularyKey BusinessTitle { get; internal set; }
        public VocabularyKey CustomGroupA { get; internal set; }
        public VocabularyKey CustomGroupB { get; internal set; }
        public VocabularyKey Department { get; internal set; }
        public VocabularyKey EffectiveDate { get; internal set; }
        public VocabularyKey EmployeeClass { get; internal set; }
        public VocabularyKey EmployeeType { get; internal set; }
        public VocabularyKey EmploymentStatus { get; internal set; }
        public VocabularyKey EventCode { get; internal set; }
        public VocabularyKey EventDesc { get; internal set; }
        public VocabularyKey FlsaCode { get; internal set; }
        public VocabularyKey JobCode { get; internal set; }
        public VocabularyKey Location { get; internal set; }
        public VocabularyKey PayGroup { get; internal set; }
        public VocabularyKey ReasonCode { get; internal set; }
        public VocabularyKey ReasonDesc { get; internal set; }
        public VocabularyKey RegularTemporary { get; internal set; }
        public VocabularyKey ServiceDate { get; internal set; }
        public VocabularyKey StandardHours { get; internal set; }
        public VocabularyKey Supervisor { get; internal set; }
        public VocabularyKey TerminationDate { get; internal set; }
        public VocabularyKey WorkEmail { get; internal set; }
        public VocabularyKey WorkersCompCode { get; internal set; }
        public VocabularyKey WorkPhone { get; internal set; }
        public VocabularyKey AlternateId { get; internal set; }
        public VocabularyKey EmployeeId { get; internal set; }
    }
}


