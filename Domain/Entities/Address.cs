using Domain.Comman;
using Domain.Enums;

namespace Domain.Entities
{
    public class Address : BaseEntity
    {
        public Address(int id, int cityid, int districtid, int neighbourhoodid)
        {
            this.NeighbourhoodId = neighbourhoodid;
            this.Id = id;
            this.CityId = cityid;
            this.DistrictId = districtid;
            
        }
        public Address()
        {

        }
        public AddressTypeEnum AddressType { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int NeighbourhoodId { get; set; }
        public string OpenAddress { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
