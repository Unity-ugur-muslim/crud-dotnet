using System;

namespace Crud.Models
{
    
    public partial class Blog
    {
        const int blogTextLimit = 20;
        public int id { get; set; }
        public string email { get; set; }
        public string blogText { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public string shortText
        {
            get { return blogText.Length > blogTextLimit ? blogText.Substring(0,blogTextLimit) + "...": blogText; }
        }
    }
}