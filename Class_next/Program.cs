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
        Employee emp1 = new Employee("Пономаренко Максим", "01.01.2000", "+380671234567", 
            "maks@gmail.com", 
            "Менеджер",
            "Досвід роботи 5 років"
        );
        Console.WriteLine("ПІБ: " + emp1._PIB);
        Console.WriteLine("Дата народження: " + emp1._birthDate);
        Console.WriteLine("Телефон: " + emp1.Telefon);
        Console.WriteLine("Email: " + emp1._Email);
        Console.WriteLine("Посада: " + emp1._posada);
        Console.WriteLine("Опис: " + emp1._descripte);
        
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
    public Employee(string _pib, string _birthDate, string _telefon, string _email, string _posada, string _descripte)
    {
        _PIB = _pib;
        _birthDate = _birthDate;
        Telefon = _telefon;
        _Email = _email;
        posada = _posada;
        descripte = _descripte;
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
        get { return birthDate; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("birthDate is empty");
                return;
            }
            birthDate = value;
        }
    }
    public string Telefon
    {
        get { return telefon; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Telefon is empty");
                return;
            }
            telefon = value;
        }
    }
    public string _Email
    {
        get { return email; }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Email is empty");
                return;
            }
            email = value;
        }
    }
    public string _posada
    {
        get { return posada; }
        set { posada = value; }
    }
    public string _descripte
    {
        get { return descripte; }
        set { descripte = value; }
    }
}