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

namespace CluedIn.Crawling.Trinet.ClueProducers
{
    public class EducationClueProducer : BaseClueProducer<Employee>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<TrinetClient> _log;

        public EducationClueProducer([NotNull] IClueFactory factory, ILogger<TrinetClient> _log)
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

            //data.Properties[vocab.Degree] = input.Degree.PrintIfAvailable();
            //data.Properties[vocab.EndDate] = input.EndDate.PrintIfAvailable();
            //data.Properties[vocab.Discipline] = input.Discipline.PrintIfAvailable();
            //data.Properties[vocab.StartDate] = input.StartDate.PrintIfAvailable();
            //data.Properties[vocab.SchoolName] = input.SchoolName.PrintIfAvailable();

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}
