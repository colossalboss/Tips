using System;
using System.ComponentModel.DataAnnotations;

namespace BatWithAsp.Models
{
    public class Comment
    {
        public Comment()
        {
        }

        public Guid Id { get; set; }

        [Required]
        public Guid PostId { get; set; }

        public Post Post { get; set; }

        public string Message { get; set; }

        public Guid AppUserId { get; set; }

        public AppUser AppUser { get; set; }

    }
}
