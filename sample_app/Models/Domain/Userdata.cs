namespace sample_app.Models.Domain
{
    public class Userdata
    {
       public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool Visible { get; set; }
    }
}
