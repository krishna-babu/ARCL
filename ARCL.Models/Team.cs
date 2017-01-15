using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Logo { get; set; }

        public string BannerMessage { get; set; } 

        public DateTime CreatedDate { get; set; }

        
    }
}
