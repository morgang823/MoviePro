using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Crew
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int CrewId { get; set; }

        public string Department { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }
        [Display(Name = "Profile Image")]
        public byte[] ProfileImage { get; set; }
        [Display(Name = "Content Type")]
        public string ContentType { get; set; }

        public ICollection<movie> MovieID { get; set; } = new HashSet<movie>();
    }

}

