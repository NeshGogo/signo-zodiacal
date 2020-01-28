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
            
            var signosZodiacles = SignoZodiacales();
            var zodiacalsigno = from sz in signosZodiacles
                                where (sz.StartDate.Month == userDate.Month && userDate.Day >= sz.StartDate.Day && userDate.Day <= 31) || 
                                (sz.EndDate.Month == userDate.Month && userDate.Day >= 1 && userDate.Day <= sz.EndDate.Day )
                                select sz;
            return zodiacalsigno.FirstOrDefault();
        }
        private List<ZodiacalSigno> SignoZodiacales()
        {
            var ListsignosZodiacales = new List<ZodiacalSigno>
            {
               
               new ZodiacalSigno(){ Id=1, Name = "Aries", StartDate = Convert.ToDateTime("03/21/2000"), EndDate = Convert.ToDateTime("04/19/2000"), ImgUrl= "../css/img/aries.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Tauro", StartDate = Convert.ToDateTime("04/20/2000"), EndDate = Convert.ToDateTime("05/20/2000"), ImgUrl= "../css/img/Tauro.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Géminis", StartDate = Convert.ToDateTime("05/21/2000"), EndDate = Convert.ToDateTime("06/20/2000"), ImgUrl= "../css/img/Geminis.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Cáncer", StartDate = Convert.ToDateTime("06/21/2000"), EndDate = Convert.ToDateTime("07/22/2000"), ImgUrl= "../css/img/Cancer.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Leo", StartDate = Convert.ToDateTime("07/23/2000"), EndDate = Convert.ToDateTime("08/22/2000"), ImgUrl= "../css/img/Leo.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Virgo", StartDate = Convert.ToDateTime("08/23/2000"), EndDate = Convert.ToDateTime("09/22/2000"), ImgUrl= "../css/img/Virgo.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Libra", StartDate = Convert.ToDateTime("09/23/2000"), EndDate = Convert.ToDateTime("10/22/2000"), ImgUrl= "../css/img/Libra.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Escorpio", StartDate = Convert.ToDateTime("10/23/2000"), EndDate = Convert.ToDateTime("11/21/2000"), ImgUrl= "../css/img/Escorpion.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Sagitario", StartDate = Convert.ToDateTime("11/22/2000"), EndDate = Convert.ToDateTime("12/21/2000"), ImgUrl= "../css/img/Sagitario.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Capricornio", StartDate = Convert.ToDateTime("12/22/2000"), EndDate = Convert.ToDateTime("01/19/2000"), ImgUrl= "../css/img/Capricornio.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Acuario", StartDate = Convert.ToDateTime("01/20/2000"), EndDate = Convert.ToDateTime("02/18/2000"), ImgUrl= "../css/img/Acuario.jpg" },
               new ZodiacalSigno(){ Id=1, Name = "Piscis", StartDate = Convert.ToDateTime("02/19/2000"), EndDate = Convert.ToDateTime("03/20/2000"), ImgUrl= "../css/img/Piscis.jpg" },
            };
            return ListsignosZodiacales;
        }
    }
}
