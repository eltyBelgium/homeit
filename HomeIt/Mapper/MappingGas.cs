using API.DTO;
using API.Models;
using AutoMapper;

namespace API.Mapper
{
    public class MappingGas : Gas
    {
        public MappingGas()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Gas, GasDTO>(); });

            IMapper mapper = config.CreateMapper();
            var source = new Gas();
            var dest = mapper.Map<Gas, GasDTO>(source);
        }
    }
}