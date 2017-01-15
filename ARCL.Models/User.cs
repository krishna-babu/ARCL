using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCL.Models
{
    public class User
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int CreatedDate { get; set; }

        public byte[] Picture { get; set; }
    }
}
