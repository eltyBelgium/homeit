using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using API.DTO.Infrastructure;
using HomeIt.Models;

namespace API.DTO
{
    public class WaterDTO : BaseUtilityDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

    }

    public class WaterMapper : MapperBase<Water, WaterDTO>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        private BaseUtilityMapper _baseUtilityMapper = new BaseUtilityMapper();
        public override Expression<Func<Water, WaterDTO>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Water, WaterDTO>>)(p => new WaterDTO()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 

                })).MergeWith(this._baseUtilityMapper.SelectorExpression);
            }
        }

        public override void MapToModel(WaterDTO dto, Water model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            this._baseUtilityMapper.MapToModel(dto, model);
        }
    }
}
