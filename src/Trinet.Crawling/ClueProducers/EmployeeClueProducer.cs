using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Trinet.Core.Models;
using CluedIn.Crawling.Trinet.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Linq;
using CluedIn.Crawling.Trinet.Vocabularies;
using CluedIn.Crawling.Helpers;
using CluedIn.Core.Data.Parts;
using RestSharp;

namespace CluedIn.Crawling.Trinet.ClueProducers
{
    public class EmployeeClueProducer : BaseClueProducer<Employee>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<TrinetClient> _log;

        public EmployeeClueProducer([NotNull] IClueFactory factory, ILogger<TrinetClient> _log)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Employee input, Guid id)
        {
            var clue = _factory.Create("/Employee", input.EmployeeId, id);
            var data = clue.Data.EntityData;

            var vocab = new EmployeeVocabulary();

            //if (!string.IsNullOrEmpty(input.Degree))
            //{
            //    data.Name = input.Degree;
            //}

            if (input.Names != null)
            {
                if (input.Names.Any())
                {
                    data.Name = string.Format("{0} {1}", input.Names.First().FirstName, input.Names.First().LastName);
                    //foreach(var name in input.Names)
                    //{
                    //    data.Aliases.Add(name.);
                    //}
                }
            }

            if (input.EmploymentInfo != null)
            {
                data.Properties[vocab.BusinessTitle] = input.EmploymentInfo.BusinessTitle.PrintIfAvailable();
                data.Properties[vocab.CustomGroupA] = input.EmploymentInfo.CustomGroupA.PrintIfAvailable();
                data.Properties[vocab.CustomGroupB] = input.EmploymentInfo.CustomGroupB.PrintIfAvailable();
                data.Properties[vocab.Department] = input.EmploymentInfo.Department.PrintIfAvailable();
                data.Properties[vocab.EffectiveDate] = input.EmploymentInfo.EffectiveDate.PrintIfAvailable();
                data.Properties[vocab.EmployeeClass] = input.EmploymentInfo.EmployeeClass.PrintIfAvailable();
                data.Properties[vocab.EmployeeType] = input.EmploymentInfo.EmployeeType.PrintIfAvailable();
                data.Properties[vocab.EmploymentStatus] = input.EmploymentInfo.EmploymentStatus.PrintIfAvailable();
                data.Properties[vocab.EventCode] = input.EmploymentInfo.EventCode.PrintIfAvailable();
                data.Properties[vocab.EventDesc] = input.EmploymentInfo.EventDesc.PrintIfAvailable();
                data.Properties[vocab.FlsaCode] = input.EmploymentInfo.FlsaCode.PrintIfAvailable();
                data.Properties[vocab.JobCode] = input.EmploymentInfo.JobCode.PrintIfAvailable();
                data.Properties[vocab.Location] = input.EmploymentInfo.Location.PrintIfAvailable();
                data.Properties[vocab.PayGroup] = input.EmploymentInfo.PayGroup.PrintIfAvailable();

                data.Properties[vocab.ReasonCode] = input.EmploymentInfo.ReasonCode.PrintIfAvailable();
                data.Properties[vocab.ReasonDesc] = input.EmploymentInfo.ReasonDesc.PrintIfAvailable();
                data.Properties[vocab.RegularTemporary] = input.EmploymentInfo.RegularTemporary.PrintIfAvailable();
                data.Properties[vocab.ServiceDate] = input.EmploymentInfo.ServiceDate.PrintIfAvailable();

                data.Properties[vocab.StandardHours] = input.EmploymentInfo.StandardHours.PrintIfAvailable();
                data.Properties[vocab.Supervisor] = input.EmploymentInfo.Supervisor.PrintIfAvailable();
                data.Properties[vocab.TerminationDate] = input.EmploymentInfo.TerminationDate.PrintIfAvailable();

                data.Properties[vocab.WorkEmail] = input.EmploymentInfo.WorkEmail.PrintIfAvailable();
                if (input.EmploymentInfo.WorkEmail != null)
                {
                    var code = new EntityCode("/Employee", "CluedIn", input.EmploymentInfo.WorkEmail);
                    data.Codes.Add(code);
                }

                data.Properties[vocab.WorkersCompCode] = input.EmploymentInfo.WorkersCompCode.PrintIfAvailable();
                data.Properties[vocab.WorkPhone] = input.EmploymentInfo.WorkPhone.PrintIfAvailable();
            }

            data.Properties[vocab.AlternateId] = input.AlternateId.PrintIfAvailable();
            data.Properties[vocab.EmployeeId] = input.EmployeeId.PrintIfAvailable();

            if (input.EmployeePhoto != null)
            {
                if (!string.IsNullOrEmpty(input.EmployeePhoto.Uri))
                {
                    RawDataPart rawDataPart = null;

                    try
                    {
                        var download = new RestClient().DownloadData(new RestRequest(input.EmployeePhoto.Uri));

                        rawDataPart = new RawDataPart
                        {
                            Type = "/RawData/PreviewImage",
                            MimeType = input.EmployeePhoto.MimeType,
                            FileName = input.EmployeePhoto.Uri,
                            RawDataMD5 = FileHashUtility.GetMD5Base64String(download),
                            RawData = Convert.ToBase64String(download)
                        };

                        if (rawDataPart != null)
                        {
                            clue.Details.RawData.Add(rawDataPart);
                            clue.Data.EntityData.PreviewImage = new ImageReferencePart(rawDataPart, 255, 255);
                        }
                    }
                    catch (Exception exception)
                    {
                        _log.LogWarning(exception, "Could not download Trinet Photo Url for Employee");
                    }
                }

                if (!data.OutgoingEdges.Any())
                {
                    _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
                }

            }

            return clue;
        }
    }
}
