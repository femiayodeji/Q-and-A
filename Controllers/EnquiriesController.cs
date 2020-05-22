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
        private readonly IEnquiryRepository _repository;
        private IMapper _mapper;

        public EnquiriesController(IEnquiryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/enquiries
        [HttpGet]
        public ActionResult <IEnumerable<EnquiryReadDTO>> GetAllEnquiries()
        {
            var enquiryItems = _repository.GetAllEnquiries();
            return Ok(_mapper.Map<IEnumerable<EnquiryReadDTO>>(enquiryItems));
        }

        //GET api/enquiries/{id}
        [HttpGet("{id}", Name="GetEnquiryById")]
        public ActionResult <EnquiryReadDTO> GetEnquiryById(int id){
            var enquiryItem = _repository.GetEnquiryById(id);
            if(enquiryItem != null){
                return Ok(_mapper.Map<EnquiryReadDTO>(enquiryItem));
            }
            return NotFound();
        }

        //POST api/enquiries
        [HttpPost]
        public ActionResult <EnquiryReadDTO> CreateEnquiry(EnquiryCreateDTO enquiryCreateDTO)
        {
            var enquiryModel = _mapper.Map<Enquiry>(enquiryCreateDTO);
            _repository.CreateEnquiry(enquiryModel);
            _repository.SaveChanges();
            
            var enquiryReadDTO = _mapper.Map<EnquiryReadDTO>(enquiryModel);
            return CreatedAtRoute(nameof(GetEnquiryById), new {Id = enquiryModel.Id}, enquiryReadDTO);
        }

        //PUT api/enquires/{id}
        [HttpPut("{id}")]
        public ActionResult <EnquiryReadDTO> UpdateEnquiry(int id, EnquiryUpdateDTO enquiryUpdateDTO)
        {
            var enquiryModelFromRepo = _repository.GetEnquiryById(id);
            if(enquiryModelFromRepo == null){
                return NotFound();
            }
            _mapper.Map(enquiryUpdateDTO, enquiryModelFromRepo);            
            _repository.UpdateEnquiry(enquiryModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}