using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    [Table("articles")]

    public class Article
    {
        public int id;
        public string a_name;
        public string a_content;
        public string a_avatar;
        public DateTime created_at;

        public int Id { get => id; set => id = value; }
        public string A_name { get => a_name; set => a_name = value; }
        public string A_content { get => a_content; set => a_content = value; }
        public string A_avatar { get => a_avatar; set => a_avatar = value; }
    }
}
