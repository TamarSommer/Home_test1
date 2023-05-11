using Home_test.Api.Models.Entities;

namespace Home_test.Api.Models.Dtos
{
    public class VaccinatedDto
    {
        public int Id { get; set; }
        public List<Vaccine> vaccines { get; set; }

        public VaccinatedDto(int id) 
        {
            Id = id;
        }
    }
}
