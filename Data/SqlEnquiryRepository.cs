using System;
using System.Collections.Generic;
using System.Linq;
using Qurious.Models;

namespace Qurious.Data
{
    public class SqlEnquiryRepository : IEnquiryRepository
    {
        private readonly QuriousContext _context;

        public SqlEnquiryRepository(QuriousContext context)
        {
            _context = context;
        }

        public void CreateEnquiry(Enquiry enquiry)
        {
            if(enquiry == null){
                throw new ArgumentNullException(nameof(enquiry));
            }
            _context.Enquiries.Add(enquiry);
        }

        public IEnumerable<Enquiry> GetAllEnquiries()
        {
            return _context.Enquiries.ToList();
        }

        public Enquiry GetEnquiryById(int id)
        {
            return _context.Enquiries.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEnquiry(Enquiry enquiry)
        {
            //Nothing
        }
    }
}