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
    public class ElectricityDTO : BaseUtilityDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

    }

    public class ElectricityMapper : MapperBase<Electricity, ElectricityDTO>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        private BaseUtilityMapper _baseUtilityMapper = new BaseUtilityMapper();
        public override Expression<Func<Electricity, ElectricityDTO>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Electricity, ElectricityDTO>>)(p => new ElectricityDTO()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 

                })).MergeWith(this._baseUtilityMapper.SelectorExpression);
            }
        }

        public override void MapToModel(ElectricityDTO dto, Electricity model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            this._baseUtilityMapper.MapToModel(dto, model);
        }
    }
}
