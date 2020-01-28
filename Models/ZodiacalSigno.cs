using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SignoZodiacal.Models
{
    public class ZodiacalSigno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM}")]
        public DateTime  EndDate { get; set; }
        public string ImgUrl { get; set; }
    }
}
