using IleriRepository.DTO;

namespace IleriRepository.Repositories.Abstract
{
    public interface IPersonelRep
    {
        public int GetAge();
        public string FullName();
        List<string> GetAdres();
        List<PersonelGradeList> ListByGrade();
        List<PesonelDepartmentList> ListByDepartment();
    }
}
