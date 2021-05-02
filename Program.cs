using System;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("EMPLOYEE LEAVES MANAGEMENT SYSTEM");
		Login();  
		 }
		 
	static void Login()
	{
		
		int count = 0;
		while (count < 5)
		{
			if (count == 4)
			{
				Console.WriteLine("Maximum tries exceeded!");
			return;
			}
			
			
		//email: "employee@leaves.company";
		//password: "password";
		
		Console.WriteLine("Enter email for Login: ");
		string InputEmail= Console.ReadLine();
		Console.WriteLine("Enter Password: ");
		string InputPassword= Console.ReadLine();
		
		if (InputEmail=="employee@leaves.company"&& InputPassword == "password") 
		{
			Console.WriteLine("Welcome User!");
			system();
		}
		
		else {
			count++;
		}
	}	
}
	
	static void system()
	{
		Start1:
		Console.WriteLine("type \"form\" to access request form for leave\ntype \"list\"  to access list of employees' absences");
		string answer1 = Console.ReadLine();
		
		if (answer1 == "form"){
			
			var requestslist = new List<string>();
				
			Console.WriteLine("Employee name (Surname, First Name, Middle Initial): ");
			string eName = Console.ReadLine();
			
			Console.WriteLine("Type of leave requesting: ");
			string tLeave = Console.ReadLine(); 
			
			Console.WriteLine("Request given to: ");
			string dReq = Console.ReadLine();
		
			Console.WriteLine("Date of Request: ");
			string date = Console.ReadLine();
			
			Console.WriteLine("Employee Name: "+eName+"\nType of leave Requesting: "+tLeave+"\nRequest given to: "+dReq+"\nDate of Request: "+date+"\nRequest submitted! Please wait for 3-5 business days for permission.");
			
			requestslist.Add(eName);
			foreach (var employeenames in requestslist) 
			{
				Console.WriteLine("Leave requests: "+employeenames);
			}
			
			goto Start1;
		}
		
		else if (answer1 =="list") {
			Console.WriteLine("Guillen,Judea Nicole S.\nNavarro, Elton John S.");
			string name2 = Console.ReadLine();
			
			var recordslist = new List<string>()
			{"Guillen, Judea Nicole S.", "Navarro, Elton John S."};
			
						foreach(var item in recordslist){
						Console.WriteLine(item);
						}
			
			if (name2.Equals("guillen, judea nicole s.", StringComparison.InvariantCultureIgnoreCase)) 
				{
					Guillen();
				}
			else if (name2.Equals("guillen, judea nicole s.", StringComparison.InvariantCultureIgnoreCase))
			{
				Navarro();
			}
			
			goto Start1;
		}
	}
	
		static void Guillen()
		{
			
			Console.WriteLine("PROFILE:\nFull name: Guillen, Judea Nicole S.\nAge: 24\nAddress:San Pedro, Laguna");
			Console.WriteLine("Record of Leaves:" );
			Console.WriteLine("Vacation: \n used:4 available: 12");
			Console.WriteLine("SICK LEAVE used:2 available:26");
			Console.WriteLine("UNPAID LEAVE used:0 available: 365");
			Console.WriteLine("WORK FROM HOME used:5 available 25");
		}
	
	static void Navarro()
	{
		Console.WriteLine("PROFILE:\nFull name: Navarro, Elton John S.\nAge: 25\nAddress:Tunasan, Muntinlupa");
			Console.WriteLine("Record of Leaves:" );
			Console.WriteLine("Vacation: \n used:5 available: 11");
			Console.WriteLine("SICK LEAVE used:1 available:27");
			Console.WriteLine("UNPAID LEAVE used:0 available: 365");
			Console.WriteLine("WORK FROM HOME used:4 available 26");
	}
	
}

