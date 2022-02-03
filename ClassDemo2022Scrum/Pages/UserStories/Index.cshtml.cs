using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumLib.model;

namespace ClassDemo2022Scrum.Pages.UserStories
{
    public class IndexModel : PageModel
    {
        // hack - Laver liste direkte her
        private List<UserStory> _userStories = new List<UserStory>();


        // Get property
        public List<UserStory> UserStories => _userStories;

        public void OnGet()
        {
            // hack fortsætter her
            _userStories.Clear();
            _userStories.Add(new UserStory("Opret X", "Som bruger ønsker jeg at ..."));
            _userStories.Add(new UserStory("Ændre X", "Som bruger ønsker jeg at ..."));
            _userStories.Add(new UserStory("Hente alle X", "Som bruger ønsker jeg at ..."));
            _userStories.Add(new UserStory("Opret Y", "Som bruger ønsker jeg at ..."));
            _userStories.Add(new UserStory("Slette Y", "Som bruger ønsker jeg at ..."));
        }
    }
}
