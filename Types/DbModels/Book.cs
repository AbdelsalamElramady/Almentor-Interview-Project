using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Types.DbModels
{
    public class Book
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        [DefaultValue(0)]
        public decimal Price { get; set; }
    }
}
