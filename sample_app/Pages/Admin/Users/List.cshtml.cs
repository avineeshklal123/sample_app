using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample_app.Data;
using sample_app.Models.Domain;

namespace sample_app.Pages.Admin.Users
{
    public class ListModel : PageModel
    {
        private readonly SampleDbContext sampleDbContext;

        public List<Userdata> Userdatas { get; set; }
        public ListModel(SampleDbContext sampleDbContext)
        {
            this.sampleDbContext = sampleDbContext;
        }
     
        public void OnGet()
        {
           Userdatas =  sampleDbContext.User_data.ToList();
        }

    }
}
