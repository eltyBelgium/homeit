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
    public class GasDTO : BaseUtilityDTO
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

    }

    //public class GasMapper : MapperBase<Gas, GasDTO>
    //{
    //    ////BCC/ BEGIN CUSTOM CODE SECTION 
    //    ////ECC/ END CUSTOM CODE SECTION 
    //    private BaseUtilityMapper _baseUtilityMapper = new BaseUtilityMapper();
    //    public override Expression<Func<Gas, GasDTO>> SelectorExpression
    //    {
    //        get
    //        {
    //            return ((Expression<Func<Gas, GasDTO>>)(p => new GasDTO()
    //            {
    //                ////BCC/ BEGIN CUSTOM CODE SECTION 
    //                ////ECC/ END CUSTOM CODE SECTION 

    //            })).MergeWith(this._baseUtilityMapper.SelectorExpression);
    //        }
    //    }

    //    public override void MapToModel(GasDTO dto, Gas model)
    //    {
    //        ////BCC/ BEGIN CUSTOM CODE SECTION 
    //        ////ECC/ END CUSTOM CODE SECTION 
    //        this._baseUtilityMapper.MapToModel(dto, model);
    //    }
    //}
}
