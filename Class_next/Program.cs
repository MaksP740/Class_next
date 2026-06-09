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
    private string pib;
    private string birthDate;
    private string telefon;
    private string email;
    private string posada;
    private string descripte;

    public Employee() { }

    public Employee(string pib, string birthDate, string telefon,
                    string email, string posada, string descripte)
    {
        _PIB = pib;
        _birthDate = birthDate;
        _Telefon = telefon;
        _Email = email;
        _Posada = posada;
        _Descripte = descripte;
    }

    public string _PIB
    {
        get { return pib; }
        set
        {
            if (value.Length < 10 || value.Length > 50)
            {
                Console.WriteLine("Помилка: некоректне ПІБ");
                return;
            }

            pib = value;
        }
    }

    public string _birthDate
    {
        get { return birthDate; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Дата народження не може бути порожньою");
                return;
            }

            birthDate = value;
        }
    }

    public string _Telefon
    {
        get { return telefon; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Телефон не може бути порожнім");
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
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Email не може бути порожнім");
                return;
            }

            if (!value.Contains("@"))
            {
                Console.WriteLine("Email повинен містити символ @");
                return;
            }

            email = value;
        }
    }

    public string _Posada
    {
        get { return posada; }
        set { posada = value; }
    }

    public string _Descripte
    {
        get { return descripte; }
        set { descripte = value; }
    }
}