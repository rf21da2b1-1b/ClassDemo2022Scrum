using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumLib.model
{
    public class UserStory
    {

        // instans felter
        private int _id;
        private string _title;
        private string _description;
        private int _storyPoint;
        private int _businessValue;

        // instans felt til automatisk optælling
        private static int nextId = 1;


        // Konstruktører
        public UserStory():this("","")
        {
            
        }

        public UserStory(String title, String description)
        {
            _id = nextId++; // tilder værdien i nextId og bagefter tæller nextId en op
            Title = title;
            _description = description;
            _storyPoint = 0;
            _businessValue = 0;
        }



        // Properties
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }

        private void CheckTitle(string title)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Titlen må ikke være null eller tom");
            }

            if (title.Length < 3)
            {
                throw new ArgumentException("Titlen skal være 3 tegn lang men var " + title.Length);
            }

        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public int StoryPoint
        {
            get => _storyPoint;
            set => _storyPoint = value;
        }

        public int BusinessValue
        {
            get => _businessValue;
            set => _businessValue = value;
        }


        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}, {nameof(StoryPoint)}: {StoryPoint}, {nameof(BusinessValue)}: {BusinessValue}";
        }
    }
}
