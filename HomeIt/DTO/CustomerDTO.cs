using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using API.DTO.Infrastructure;
using API.Models;

namespace API.DTO
{
    public class CustomerDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string IdentityFirstName { get; set; }
        public string IdentityLastName { get; set; }
        public long? IdentityFacebookId { get; set; }
        public string IdentityPictureUrl { get; set; }
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }

    public class CustomerMapper : MapperBase<Customer, CustomerDTO>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<Customer, CustomerDTO>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Customer, CustomerDTO>>)(p => new CustomerDTO()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    Id = p.Id,
                    IdentityId = p.IdentityId,
                    IdentityFirstName = p.Identity != null ? p.Identity.FirstName : default(string),
                    IdentityLastName = p.Identity != null ? p.Identity.LastName : default(string),
                    IdentityFacebookId = p.Identity != null ? p.Identity.FacebookId : default(long?),
                    IdentityPictureUrl = p.Identity != null ? p.Identity.PictureUrl : default(string),
                    Location = p.Location,
                    Locale = p.Locale,
                    Gender = p.Gender
                }));
            }
        }

        public override void MapToModel(CustomerDTO dto, Customer model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.Id = dto.Id;
            model.IdentityId = dto.IdentityId;
            model.Location = dto.Location;
            model.Locale = dto.Locale;
            model.Gender = dto.Gender;

        }
    }
}
