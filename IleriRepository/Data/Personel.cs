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

    }
}
