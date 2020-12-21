using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    [Table("products")]
    [Serializable]
    public class Product
    {
        private int id;
        private string pro_name;
        private string pro_description;
        private int pro_category_id;
        private int pro_price;
        private string pro_avatar;
        private string pro_slug;

        public int Id { get => id; set => id = value; }
        public string Pro_name { get => pro_name; set => pro_name = value; }
        public int Pro_category_id { get => pro_category_id; set => pro_category_id = value; }
        public int Pro_price { get => pro_price; set => pro_price = value; }
        public string Pro_avatar { get => pro_avatar; set => pro_avatar = value; }
        public string Pro_slug { get => pro_slug; set => pro_slug = value; }
        public string Pro_description { get; set; }
    }
}
