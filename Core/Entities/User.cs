using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Core.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsEnabled { get; set; }
    }
}
