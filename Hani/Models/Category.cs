using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    [Table("categories")]
    public class Category
    {
        public int id;
        public string c_name;

        public int Id { get => id; set => id = value; }
        public string C_name { get => c_name; set => c_name = value; }
    }
}
