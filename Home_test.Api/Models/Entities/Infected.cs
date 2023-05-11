namespace Home_test.Api.Models.Entities
{
    public class Infected
    {   
        public int Id { get; set; }
        public DateTime Positive { get; set; }
        public DateTime Recovery { get; set; }
        public Infected(int id) { 
            Id = id;
            Positive = DateTime.Now;
        }
    }
}
