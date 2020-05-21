using System.Collections.Generic;
using Qurious.Data;
using Qurious.Models;
using Microsoft.AspNetCore.Mvc;

namespace Qurious.Controllers
{
    //api/enquiries
    [Route("api/{controller}")]
    [ApiController]
    public class EnquiriesController: ControllerBase
    {
        private readonly IEnquiryRepository _respository;
        public EnquiriesController(IEnquiryRepository repository)
        {
            _respository = repository;
        }
        //GET api/enquiries
        [HttpGet]
        public ActionResult <IEnumerable<Enquiry>> GetAllEnquiries()
        {
            var enquiryItems = _respository.GetAllEnquiries();
            return Ok(enquiryItems);
        }

        //GET api/enquiries/5
        [HttpGet("{id}")]
        public ActionResult <Enquiry> GetEnquiryById(int id){
            var enquiryItem = _respository.GetEnquiryById(id);
            return Ok(enquiryItem);
        }
    }
}