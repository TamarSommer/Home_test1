using Home_test.Api.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Home_test.Api.Controllers
{
    public class InfectedController : Controller
    {
        public List<PersonDto> Get()
        {
            return new List<PersonDto>();
        }
    }
}
