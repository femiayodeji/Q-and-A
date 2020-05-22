using AutoMapper;
using Qurious.DTOs;
using Qurious.Models;

namespace Qurious.Profiles
{
    public class EnquiriesProfile : Profile
    {
        public EnquiriesProfile()
        {
            //Source -> Target
            CreateMap<Enquiry, EnquiryReadDTO>();
            CreateMap<EnquiryCreateDTO, Enquiry>();
            CreateMap<EnquiryUpdateDTO, Enquiry>();
            CreateMap<Enquiry, EnquiryUpdateDTO>();
        }
    }
}