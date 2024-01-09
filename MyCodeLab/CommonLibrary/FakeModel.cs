using Prism.Mvvm;

namespace CommonLibrary
{
    public class FakeModel : BindableBase
    {
        private string name;
        private int age;
        private string email;
        private double salary;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
