using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Menu :BaseEntity
    {

        public string MenuAdi { get; set; }
        public string? Area { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? CssClass { get; set; }
        public string? IconClass { get; set; }
        public string? CssClass2 { get; set; }
        public string? IconClass2 { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }



    }
}
