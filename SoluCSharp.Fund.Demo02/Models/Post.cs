using System;
using System.Collections.Generic;
using System.Text;

namespace SoluCSharp.Fund.Demo02.Models
{
    public class Post : ISend
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
