using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        //TMDB castID used to indetify cast across movies

        public int CastID { get; set; }

        public string Department{ get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }

        //Profile IMG
        [Display(Name = "Profile Pic")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }

        public ICollection<movie> MovieID { get; set; } = new HashSet<movie>();
    }
}
