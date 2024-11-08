namespace CsD07
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public SecurityPrivileges Privileges { get; set; }

        public Employee(int id, string name, Gender gender, decimal salary, HireDate hireDate, SecurityPrivileges privileges)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            Privileges = privileges;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary:C}, Hire Date: {HireDate}, Privileges: {Privileges}";
        }

        public int CompareTo(Employee other)
        {
            return HireDate.CompareTo(other.HireDate);
        }
    }
}