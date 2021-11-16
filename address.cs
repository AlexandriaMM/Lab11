using System;

class Address{

  private string zipCode;
  private string state;

  public string AddressLine1 { get; set;}
  public string AddressLine2 { get; set;}
  public string City { get; set;}
  public string State { 
    get{
      if (!String.IsNullOrEmpty(state))
        return state.ToUpper();
      else
        return String.Empty;
    }
    set{
      if (value.Length==2)
        state = value;
      else
       Console.WriteLine("State code should be 2 characters long");
    }
  }
  public string Zipcode {
    get{
      return zipCode;
    }
    set{
      if (value.Length <= 5)
        zipCode = value;
      else
        Console.WriteLine("Invalid length");
    }
  }

  public void Display()
  {
    Console.WriteLine("Here's the address:");
    Console.WriteLine(AddressLine1);
    Console.WriteLine(AddressLine2);
    Console.WriteLine(City);
    Console.WriteLine(State);
    Console.WriteLine(Zipcode);
  }
}