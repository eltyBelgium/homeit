using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using API.DTO.Infrastructure;
using API.Models;
using Microsoft.AspNetCore.Identity;

namespace API.DTO
{
    public class AppUserDTO : IdentityUser
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? FacebookId { get; set; }
        public string PictureUrl { get; set; }
    }

    public class AppUserMapper : MapperBase<AppUser, AppUserDTO>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        private AppUserMapper _identityUserMapper = new AppUserMapper();
        public override Expression<Func<AppUser, AppUserDTO>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<AppUser, AppUserDTO>>)(p => new AppUserDTO()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    FacebookId = p.FacebookId,
                    PictureUrl = p.PictureUrl
                })).MergeWith(this._identityUserMapper.SelectorExpression);
            }
        }

        public override void MapToModel(AppUserDTO dto, AppUser model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.FirstName = dto.FirstName;
            model.LastName = dto.LastName;
            model.FacebookId = dto.FacebookId;
            model.PictureUrl = dto.PictureUrl;
            this._identityUserMapper.MapToModel(dto, model);
        }
    }
}
