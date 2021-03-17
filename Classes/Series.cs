using System;

namespace Crud.Series
{
    public class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }

        public override string ToString()
        {
            string returnMyString = "";
            returnMyString += "Genre: " + this.Genre + Environment.NewLine;
            returnMyString += "Title: " + this.Title + Environment.NewLine;
            returnMyString += "Description: " + this.Description + Environment.NewLine;
            returnMyString += "Start year: " + this.Year;
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
    }
}