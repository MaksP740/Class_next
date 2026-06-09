namespace Class_next;

class Program
{
    static void Main(string[] args)
    {
        // var student = new Student("Maks", "Ponomarenko", 18, 35); // Student();
        // var st2 = new Student{Name = "Maks", Surname = "Ponomarenko", GPA = 35,  Age = 18};
        // // student.SetName("John");
        // student.Surname = "Doe";
        // string s = student.Surname;
        // Console.WriteLine(student.Surname);
        // student.Surname = "";
        // Console.WriteLine(student.Id);
        // student.GPA = 10;
        
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        
    }
}

class Student
{ 
    public Student(){}
   public Student(string _name, string _surname, double _gpa, int _age) {
       Random rnd = new Random();
       id = rnd.Next(100);
       
       Name = _name;
       surname = _surname;
       GPA = _gpa;
       Age = _age;
   }
   int id;
   public int Id {
       get { return id; }
   }
   string surname;
   public string Surname {
        get { return surname; }
        set {
            if (value == "") {
                Console.WriteLine("Name is empty");
                return;
            }
            surname = value;
        }
    }
   public double GPA;
   public int Age { get; set; }
   public string Name { get; set; } = "No name";
}

class Employee
{
    public Employee(){}
    public Employee(string pib, string birthDate, string telefon, string email, string posada, string descripte)
    {
        _PIB = pib;
        _PIB = birthDate;
        _Telefon = telefon;
        _Email = email;
        _posada = posada;
        _descripte = descripte;
    }
    public string PIB;
    public string birthDate;
    public string telefon;
    public string email;
    public string posada;
    public string descripte;

    public string _PIB
    {
        get{return PIB;}
        set
        {
            if (value.Length < 10 || value.Length > 20)
            {
                Console.WriteLine("Error: invalid PIB length");
                return;
            }
            PIB = value;
        }
    }
    
    public string _birthDate
    {
        get { return _PIB; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Name is empty");
                return;
            }
            _PIB = value;
        }
    }
    public string _Telefon { get; set; }

    public string _Email
    {
        get { return email; }
        set
        {
            if (value != "")
            {
                Console.WriteLine("Email is empty");
                return;
            }
            email = value;
        }
    }
    
    public string _posada { get; set; }
    public string _descripte { get; set; }
}