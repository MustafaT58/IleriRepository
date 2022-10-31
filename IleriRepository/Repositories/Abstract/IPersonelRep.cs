using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstract
{
    public interface IPersonelRep:IBaseRepository<Personel>
    {
        public int GetAge(Personel p);
        public string FullName(Personel p);
        List<string> GetAdres(Personel p);
        List<PersonelGradeList> ListByGrade();
        List<PesonelDepartmentList> ListByDepartment();
    }
}
