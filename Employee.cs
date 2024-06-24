namespace Encapsulation
{
    public class Employee
    {
        private string Name;
        private string Salary;
        private string Department;
        private int PIN; 
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetSalary(string salary)
        {
            Salary = salary;
        }

        public string GetSalary()
        {
            return Salary;
        }

        public void SetDepartment(string department)
        {
            Department = department;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public void SetPIN(int pin)
        {
            PIN = pin;
        }

        public int GetPIN()
        {
            return PIN;
        }

        public void readRecords()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}, Department: {Department}, PIN: {PIN}");
        }
    }
}