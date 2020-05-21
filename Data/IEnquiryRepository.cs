using System.Collections.Generic;
using Qurious.Models;

namespace Qurious.Data
{
    public interface IEnquiryRepository
    {
        IEnumerable<Enquiry> GetAllEnquiries();
        Enquiry GetEnquiryById(int id);
    }
}