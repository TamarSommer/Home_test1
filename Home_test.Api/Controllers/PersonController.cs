using Home_test.Api.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SQLite;
using System;

namespace Home_test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly string connectionString = "Data Source=C:/Users/tamar/source/repos/Home_test1/Home_test.Api/Data base/DatabaseContext.cs;";

        public List<PersonDto> Get()
        {
            var people = new List<PersonDto>();

            using var connection = new SQLiteConnection(connectionString);
            connection.Open();

            var query = "SELECT * FROM Person;";
            using var command = new SQLiteCommand(query, connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var person = new PersonDto
                {
                    Id = reader.GetInt32(0),
                    birthdate = reader.GetDateTime(1),
                    Name = reader.GetString(2),
                    Address = reader.GetString(3),
                    PhoneNumber = reader.GetString(4),
                    TelephoneNumber = reader.GetString(5),
                };
                people.Add(person);
            }

            return people;
        }
    }
}

