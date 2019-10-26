using System;
namespace Sample.API.Data
{
    public class BlogPost
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
