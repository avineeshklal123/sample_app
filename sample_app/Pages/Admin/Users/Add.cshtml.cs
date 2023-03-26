using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample_app.Data;
using sample_app.Models.Domain;
using sample_app.Models.View_model;

namespace sample_app.Pages.Admin.Users
{
    public class AddModel : PageModel
    {
        private readonly SampleDbContext sampleDbContext;

        [BindProperty]
         public Add_users AdduserRequest { get; set; }

        public AddModel(SampleDbContext sampleDbContext)
        {
            this.sampleDbContext = sampleDbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var userdata = new Userdata()
            {
                Name = AdduserRequest.Name,
                Email = AdduserRequest.Email,
                Password = AdduserRequest.Password,
                JoiningDate = AdduserRequest.JoiningDate,
                Visible = AdduserRequest.Visible
            };

            sampleDbContext.User_data.Add(userdata);
            sampleDbContext.SaveChanges();
            return RedirectToPage("/Admin/Users/List");
    }
}
}
