// See https://aka.ms/new-console-template for more information

//class AsbstractEmployee
//{
//   public virtual void AskForPromotion()=0 ;
//}

//class Employee:AbstractEmployee
//{

//   string Name;
//    string Company;
//     int Age;

//   public void setName(string name)
//    {
//        this.Name = name;// riceve il parametro e lo assegna a Name 
//    }
//  public  string getName()
//    {
//        return Name;// fa ritornare il valore di Name 
//    }
//    public void setAge(int age)
//    {
//        if (age >=18)
//        Age = age;


//    }
//    public int getAge()
//    {
//        return Age;

//    }
//    public void  setCompany(string company)
//    {
//        Company = company;  
//    }
//    string getCompany()
//    {
//        return Company;
//    }
//public void presentYourself()
//    {
//        Console.WriteLine("name" + Name);
//        Console.WriteLine("Company"+ Company);
//    Console.WriteLine("age" + Age);

//    }


//    public Employee(string name, string company, int age)
//    {
//        Name = name;
//        Company = company;
//        Age = age;
//    }
//};
//Employee employee1 = new Employee();
//employee1.setName("Andrea");
class Car
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}
