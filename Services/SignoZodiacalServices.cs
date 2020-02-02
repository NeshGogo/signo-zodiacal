using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignoZodiacal.Models;

namespace SignoZodiacal.Services
{
    public class ZodiacalSignoServices
    {
        public ZodiacalSigno  GetSignoZodiacalByDate( DateTime userDate)
        {
            var signosZodiacles = SignoZodiacales(userDate.Year);
            ZodiacalSigno zodiacalsigno;

            if (userDate.Month == 12 && userDate.Day > 21)
            {
                DateTime mewUserDate;
                mewUserDate = userDate.AddYears(-1);
                zodiacalsigno = signosZodiacles.FirstOrDefault(sz => mewUserDate >= sz.StartDate && mewUserDate <= sz.EndDate);
                return zodiacalsigno;
            }

            zodiacalsigno = signosZodiacles.FirstOrDefault(sz => userDate >= sz.StartDate && userDate <= sz.EndDate);


            return zodiacalsigno;
        }
        private List<ZodiacalSigno> SignoZodiacales(int year)
        {
            var ListsignosZodiacales = new List<ZodiacalSigno>
            {
               
               new ZodiacalSigno(){ Id=1, Name = "Aries", StartDate = Convert.ToDateTime("03/21/"+year), EndDate = Convert.ToDateTime("04/19/"+year), ImgUrl= "../css/img/aries.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Tauro", StartDate = Convert.ToDateTime("04/20/"+year), EndDate = Convert.ToDateTime("05/20/"+year), ImgUrl= "../css/img/Tauro.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Géminis", StartDate = Convert.ToDateTime("05/21/"+year), EndDate = Convert.ToDateTime("06/20/"+year), ImgUrl= "../css/img/Geminis.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Cáncer", StartDate = Convert.ToDateTime("06/21/"+year), EndDate = Convert.ToDateTime("07/22/"+year), ImgUrl= "../css/img/Cancer.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Leo", StartDate = Convert.ToDateTime("07/23/"+year), EndDate = Convert.ToDateTime("08/22/"+year), ImgUrl= "../css/img/Leo.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Virgo", StartDate = Convert.ToDateTime("08/23/"+year), EndDate = Convert.ToDateTime("09/22/"+year), ImgUrl= "../css/img/Virgo.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Libra", StartDate = Convert.ToDateTime("09/23/"+year), EndDate = Convert.ToDateTime("10/22/"+year), ImgUrl= "../css/img/Libra.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Escorpio", StartDate = Convert.ToDateTime("10/23/"+year), EndDate = Convert.ToDateTime("11/21/"+year), ImgUrl= "../css/img/Escorpion.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Sagitario", StartDate = Convert.ToDateTime("11/22/"+year), EndDate = Convert.ToDateTime("12/21/"+year), ImgUrl= "../css/img/Sagitario.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Capricornio", StartDate = Convert.ToDateTime("12/22/"+(year-1)), EndDate = Convert.ToDateTime("01/19/"+year), ImgUrl= "../css/img/Capricornio.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Acuario", StartDate = Convert.ToDateTime("01/20/"+year), EndDate = Convert.ToDateTime("02/18/"+year), ImgUrl= "../css/img/Acuario.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Piscis", StartDate = Convert.ToDateTime("02/19/"+year), EndDate = Convert.ToDateTime("03/20/"+year), ImgUrl= "../css/img/Piscis.jpg" },
            };
            return ListsignosZodiacales;
        }
    }
}
