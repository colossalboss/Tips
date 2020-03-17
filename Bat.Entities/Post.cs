using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BatWithAsp.Models
{
    public class Post
    {
        public Post()
        {
        }

        public Guid Id { get; set; }

        [Required]
        public Guid AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        [Required]
        public string League { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Fixture { get; set; }

        [Required]
        public string Tip { get; set; }

        //[Required]
        //public string TipType { get; set; }

        public string Thoughts { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
