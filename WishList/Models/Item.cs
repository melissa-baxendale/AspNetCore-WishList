using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WishList.Models
{
    public class Item
    {
        public int Id;

        [Required]
        [MaxLength(50)]
        public string Description;
    }
}
