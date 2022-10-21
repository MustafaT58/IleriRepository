namespace IleriRepository.Data
{
    public class Department:BaseInt
    {
        public string DepartmenrName { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}
