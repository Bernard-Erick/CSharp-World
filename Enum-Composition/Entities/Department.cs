
namespace CursoProg.Entities
{
    class Department
    {
        public string Name { get; set; }
        public Department()
        {
            //padrão
        }
        public Department(string name)
        {
            Name = name;
        }

    }
}
