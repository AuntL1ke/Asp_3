using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework_3.Models;
using homework_3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_3.Pages.Movies
{
    public class InfoModel : PageModel
    {
        public Movie Movie { get; set; }
        public int SessionId { get; set; }
        public void OnGet(int id)
        {
            Movie = MovieService.GetById(id);
        }
        public void SessionOnCLick(int id)
        {
            SessionId = id;
        }
    }
}
