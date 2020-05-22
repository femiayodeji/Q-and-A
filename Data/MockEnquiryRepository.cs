using System.Collections.Generic;
using Qurious.Models;

namespace Qurious.Data
{
    public class MockEnquiryRepository : IEnquiryRepository
    {
        public void CreateEnquiry(Enquiry enquiry)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Enquiry> GetAllEnquiries()
        {
            var enquiries = new List<Enquiry>(){
                new Enquiry{Id = 0, Question = "Our ______ are our greatest asset.", Answer = "People", Difficulty = 1},
                new Enquiry{Id = 0, Question = "Every business generates _____.", Answer = "Waste", Difficulty = 1},
                new Enquiry{Id = 0, Question = "______ is defined to mean source reduction and other practices that reduce or eliminate the creation of pollutants through increased efficiency in the use of raw materials or other resources.", Answer = "Pollution prevention", Difficulty = 2}
            };
            return enquiries;
        }

        public Enquiry GetEnquiryById(int id)
        {
            return new Enquiry{Id = 0, Question = "Our ______ are our greatest asset.", Answer = "People", Difficulty = 1};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}