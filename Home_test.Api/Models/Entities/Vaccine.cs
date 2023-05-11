namespace Home_test.Api.Models.Entities
{
    public class Vaccine
    {
        public int P_Id { get; set; }
        public int V_Id { get; set; }
        public  string Manufacturer { get; set; }
        public DateTime Given { get; set; }
         public Vaccine(int id, string m) {
             V_Id = id;
             Manufacturer = m;
             Given = DateTime.Now;
         }
    }
}
