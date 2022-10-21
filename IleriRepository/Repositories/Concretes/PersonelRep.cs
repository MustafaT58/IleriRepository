using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concretes
{
    public class PersonelRep : BaseRepository<Personel>, IPersonelRep
    {
        public PersonelRep(MyContext db) : base(db)
        {
        }

        public string FullName()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAdres()
        {
            throw new NotImplementedException();
        }

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public List<PesonelDepartmentList> ListByDepartment()
        {
            throw new NotImplementedException();
        }

        public List<PersonelGradeList> ListByGrade()
        {
            throw new NotImplementedException();
        }
    }
}
