using System.Collections.Generic;
using Qurious.Data;
using Qurious.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Qurious.DTOs;

namespace Qurious.Controllers
{
    //api/enquiries
    [Route("api/{controller}")]
    [ApiController]
    public class EnquiriesController: ControllerBase
    {
        private readonly IEnquiryRepository _respository;
        private IMapper _mapper;

        public EnquiriesController(IEnquiryRepository repository, IMapper mapper)
        {
            _respository = repository;
            _mapper = mapper;
        }

        //GET api/enquiries
        [HttpGet]
        public ActionResult <IEnumerable<EnquiryReadDTO>> GetAllEnquiries()
        {
            var enquiryItems = _respository.GetAllEnquiries();
            return Ok(_mapper.Map<IEnumerable<EnquiryReadDTO>>(enquiryItems));
        }

        //GET api/enquiries/{id}
        [HttpGet("{id}")]
        public ActionResult <EnquiryReadDTO> GetEnquiryById(int id){
            var enquiryItem = _respository.GetEnquiryById(id);
            if(enquiryItem != null){
                return Ok(_mapper.Map<EnquiryReadDTO>(enquiryItem));
            }
            return NotFound();
        }
    }
}