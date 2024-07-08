namespace OOPs {
    internal class Program {
        static void Main(string[] args) {
            Employee rushi = new Employee("C1159", "Rushi");
            //rushi.Print();

            Employee suraj = new Employee {
                empName = "Suraj"
            };

            suraj.Print();
        }
    }
}

public class Employee {
    public string empId { get; set; }
    public string empName { get; set; }

    public Employee() {

    }

    public Employee(string empId, string empName) {
        this.empId = empId;
        this.empName = empName;
    }

    public void Print() {
        Console.WriteLine($"Employee Id : {empId}");
        Console.WriteLine($"Employee Name : {empName}");
    }

}