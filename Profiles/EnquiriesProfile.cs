using AutoMapper;
using Qurious.DTOs;
using Qurious.Models;

namespace Qurious.Profiles
{
    public class EnquiriesProfile : Profile
    {
        public EnquiriesProfile()
        {
            CreateMap<Enquiry, EnquiryReadDTO>();
        }
    }
}