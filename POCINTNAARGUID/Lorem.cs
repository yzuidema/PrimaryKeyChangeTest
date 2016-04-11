using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POCINTNAARGUID
{
    public class Lorem
    {
     
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }            
    }
}