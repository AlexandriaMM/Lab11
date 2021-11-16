using System;

class Faculty : Person 
{
  public string Id{get; set;}
  public string Title{get; set;}
  public DateTime DateOfEmployment{get; set;}
  public string Employer{get; set;}
  public double YearlySalary{get; set;}
  public bool Tenured{get; set;}

  public Faculty() : base()
  {
    Title = "Instructor";
    Console.WriteLine("Faculty Constructor");
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Title = "Instructor";
    Console.WriteLine("Faculty Constructor");
  }

  public bool GrantTenure() 
  {
    int currentYear = DateTime.Today.Year;
    int employmentYear = DateOfEmployment.Year;  
    if((currentYear - employmentYear) > 5)
    {
      Tenured = true;
      Console.WriteLine("Tenure granted");
      return true;
    }
    else 
    {
      Tenured = false;
      Console.WriteLine("Tenure not granted");
      return false;
    }
  }

  public bool Promote()
  {
    int currentYear = DateTime.Today.Year;
    int employmentYear = DateOfEmployment.Year;  
    if(Title == "Instructor" && currentYear - employmentYear > 2)
    {
      Title="Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank");
      return true;
    }
    else if(Title == "Assistant Professor" && currentYear - employmentYear > 5)
    {
      Title="Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank");
      return true;
    }
    else if(Title == "Associate Professor" && currentYear - employmentYear > 10)
    {
      Title="Professor";
      Console.WriteLine("Faculty promoted to Professor rank");
      return true;
    }
    else
    {
      Console.WriteLine("No more promotion possible");
      return false;
    }
  }

  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I work as " + Title + " at " + Employer + " since " + DateOfEmployment.Year);
  }
}
