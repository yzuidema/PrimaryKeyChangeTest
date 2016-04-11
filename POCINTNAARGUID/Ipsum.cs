using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POCINTNAARGUID
{
    public class Ipsum
    {
       

        [Key]
        public Guid UniqueIdentifier { get; set; }

        public string Name { get; set; }

        public Lorem Lorem { get; set; }

        public Guid LoremId { get; set; }

    }
}