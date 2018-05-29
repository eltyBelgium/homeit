using API.Enums;

namespace API.Models
{
    public class Electricity: BaseUtility
    {
        public Electricity()
        {
           UtilityType = UtilityTypes.Electricity;
        }
    }
}