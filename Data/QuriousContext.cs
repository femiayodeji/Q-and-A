using Microsoft.EntityFrameworkCore;
using Qurious.Models;

namespace Qurious.Data{
    public class QuriousContext: DbContext
    {
     public QuriousContext(DbContextOptions<QuriousContext> opt) : base(opt)
     {
         
     }   
     public DbSet<Enquiry> Enquiries { get; set; }
    }
}