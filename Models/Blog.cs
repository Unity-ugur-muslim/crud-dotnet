using System;

namespace Crud.Models
{
    public partial class Blog
    {
        public int id { get; set; }
        public string email { get; set; }
        public string blogText { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}