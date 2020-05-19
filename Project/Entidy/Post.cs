using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entidy
{
    class Post
    {
        public string Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();
        public Post()
        {

        }

        public Post(string moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }
    }
}
