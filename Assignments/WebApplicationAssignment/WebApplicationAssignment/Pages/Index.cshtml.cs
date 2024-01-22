using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationAssignment.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime actualTime {  get; set; } 

        public void OnGet()
        {
            UpdateServerTime();
        }
        public void UpdateServerTime()
        {
            actualTime = DateTime.Now;
        }
    }
}
