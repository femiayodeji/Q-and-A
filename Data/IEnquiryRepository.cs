using System.Collections.Generic;
using Qurious.Models;

namespace Qurious.Data
{
    public interface IEnquiryRepository
    {
        bool SaveChanges();
        IEnumerable<Enquiry> GetAllEnquiries();
        Enquiry GetEnquiryById(int id);
        void CreateEnquiry(Enquiry enquiry);
        void UpdateEnquiry(Enquiry enquiry);
        void DeleteEnquiry(Enquiry enquiry);
    }
}