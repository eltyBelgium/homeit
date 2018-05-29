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
    public class BaseUtilityDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int Id { get; set; }
        public decimal Used { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid UserGuid { get; set; }
    }

    public class BaseUtilityMapper : MapperBase<BaseUtility, BaseUtilityDTO>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<BaseUtility, BaseUtilityDTO>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<BaseUtility, BaseUtilityDTO>>)(p => new BaseUtilityDTO()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    Id = p.Id,
                    Used = p.Used,
                    TimeStamp = p.TimeStamp,
                    UserGuid = p.UserGuid
                }));
            }
        }

        public override void MapToModel(BaseUtilityDTO dto, BaseUtility model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.Id = dto.Id;
            model.Used = dto.Used;
            model.TimeStamp = dto.TimeStamp;
            model.UserGuid = dto.UserGuid;

        }
    }
}
