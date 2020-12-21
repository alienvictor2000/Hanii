using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hani.Models
{
    [Table("transactions")]
    public class Transaction
    {
        public int Id { get; set; }
        public string Tr_name { get; set; }
        public int Tr_total { get; set; }
        public string Tr_address { get; set; }
        public string Tr_phone { get; set; }
        public string Tr_note { get; set; }
        public bool Tr_status { get; set; }

    }
}
