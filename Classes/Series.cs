using System;

namespace CrudSeries
{
    public class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set; }

        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }
        
        public override string ToString()
        {
            string returnMyString = "";
            returnMyString += "Genre: " + this.Genre + Environment.NewLine;
            returnMyString += "Title: " + this.Title + Environment.NewLine;
            returnMyString += "Description: " + this.Description + Environment.NewLine;
            returnMyString += "Start year: " + this.Year + Environment.NewLine;
            returnMyString += "Deleted: " + this.Deleted;
            return returnMyString;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        internal int returnId()
        {
            return this.Id;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }
}