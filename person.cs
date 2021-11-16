using System;
  
  class Person
  {
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public Address PermanentAddress;

        public Person() 
        {
          PermanentAddress = new Address();
          Console.WriteLine("Person constructor");
        }

        public Person(string fname, string lname) 
        {
          FirstName = fname;
          LastName = lname;
          PermanentAddress = new Address();
          Console.WriteLine("Person constructor");
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is *** "+ FirstName +" "+ LastName);
            PermanentAddress.Display();
        }

        public void IsBirthday()
        {
          if ((DateTime.Today.Month == DateOfBirth.Month)&&(DateTime.Today.Day == DateOfBirth.Day))
            Console.WriteLine("It's your birthday!!!");
          else
            Console.WriteLine("Today is not your birthday.");
        }

      
    }