using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IleriRepository.Data
{
    public class Personel:BaseInt
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public string GradeId { get; set; }
        public char Gender { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        private string Phone { get; set; }
        public int No { get; set; }
        public int CountyId { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - DateOfBirth.Year;
            DateTime birtDay=DateOfBirth.AddYears(age);
            if (today > birtDay)
                age++;
            return age;
        }
        public string FullName()
        {
            //if (Gender == 'E')
            //{
            //    return $"Sn. Bay {Name}  {SurName}";
            //}
            //else return $"Sn. Bayan {Name}  {SurName}";

            return Gender == 'E' ? $"Sn. Bay {Name}  {SurName}" : $"Sn. Bayan {Name}  {SurName}";
        }
        public List<string> GetAdress()
        {
            List<string> adress = new List<string>();
            adress.Add(FullName());
            adress.Add(Street);
            adress.Add(Avenue);
            adress.Add(No.ToString());
            adress.Add(County.CountyName+"/"+County.City.CityName);
            return adress;

        }

    }
}
