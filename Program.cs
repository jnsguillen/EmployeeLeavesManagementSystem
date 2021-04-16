using System;

namespace judiya
{
    class Program
    {
        static void Main(string[] args)
        {
 		Console.WriteLine("EMPLOYEE LEAVES MANAGEMENT SYSTEM");
		
		Console.WriteLine("type \"form\" to access request form for leave\ntype \"list\"  to access list of employees' absences");
		string answer = Console.ReadLine();
		
		if (answer == "form"){
			Console.WriteLine("Employee name (Surname, First Name, Middle Initial): ");
			string eName = Console.ReadLine();
			
			Console.WriteLine("Type of leave requesting: ");
			string tLeave = Console.ReadLine(); 
			
			Console.WriteLine("Request given to: ");
			string dReq = Console.ReadLine();
			
			Console.WriteLine("Date of Request: ");
			string date = Console.ReadLine();
			
			Console.WriteLine("Employee Name: "+eName+"\nType of leave Requesting: "+tLeave+"\nRequest given to: "+dReq+"\nDate of Request: "+date+"\nRequest submitted! Please wait for 3-5 business days for permission.");
		}
		else if (answer == "list" ) 
		{
			Console.WriteLine("Enter an employee's name from the list to access their record: ");
			
			
			Console.WriteLine("Fernandez, Jerrica E.\nGuillen,Judea Nicole S.\nLaluyan, Aliyah Mae Q.\nLiwanag, Hannah Arceli A.\nNavarro, Elton John S.\nOrcega, Jhyzel D.\nTecson, Erika P.");
			string name2 = Console.ReadLine();
			
			{
				if (name2.Equals("Fernandez, Jerrica E.", StringComparison.InvariantCultureIgnoreCase)) 
				{
					Fernandez();
				}
				else if (name2.Equals("Guillen, Judea Nicole S.", StringComparison.InvariantCultureIgnoreCase))
				{
					Guillen();
				}
				else if (name2.Equals("Laluyan, Aliyah Mae Q.", StringComparison.InvariantCultureIgnoreCase))
				{
					Laluyan();
				}
				else if (name2.Equals("Liwanag, Hannah Arceli A.", StringComparison.InvariantCultureIgnoreCase))
				{
					Liwanag();
				}
				else if(name2.Equals("Navarro, Elton John S.", StringComparison.InvariantCultureIgnoreCase))
				{
					Navarro();
				}
				else if (name2.Equals("Orcega, Jhyzel D.", StringComparison.InvariantCultureIgnoreCase))
				{
					Orcega();
				}
			}
					}
			
	}
			
	static void Fernandez()
	{
		Console.WriteLine("PROFILE:\nFull name: Fernandez, Jerrica E.\nAge: 25\nAddress:Biñan, Laguna");
		
		int jerusedvac = 3; int jeravvac = 13;
		int jersickus = 4; int jersickav = 24;
		int jerunus = 0; int jerunav = 365;
		int jerworus = 5; int jerworav = 25;
		
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:" +jerusedvac+ " available: "+jeravvac+"\nSICK LEAVE used:"+jersickus+ " available: "+jersickav+ "\nUNPAID LEAVE used: "+jerunus+" available: "+jerunav+"\nWORK FROM HOME used: "+jerworus+" available: "+jerworav);
		
	}
	
	static void Guillen()
	{
		Console.WriteLine("PROFILE:\nFull name: Guillen, Judea Nicole S.\nAge: 23\nAddress:San Pedro, Laguna");
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:4 available: 12\nSICK LEAVE used:2 available:26\nUNPAID LEAVE used:0 available: 365\nWORK FROM HOME used:5 available 25");
	}
	
	static void Laluyan()
	{
		Console.WriteLine("PROFILE:\nFull name: Laluyan, Aliyah Mae Q.\nAge: 24\nAddress:San Pedro, Laguna");
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:1 available: 15\nSICK LEAVE used:0 available:28\nUNPAID LEAVE used:0 available: 365\nWORK FROM HOME used:6 available 24");
	}
	
	static void Liwanag()
	{
		Console.WriteLine("PROFILE:\nFull name: Liwanag, Hannah Arceli A.\nAge: 29\nAddress:Biñan, Laguna");
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:5 available: 11\nSICK LEAVE used:4 available:24\nUNPAID LEAVE used:3 available: 362\nWORK FROM HOME used:3 available 27");
	}
		
	static void Navarro()
	{
		Console.WriteLine("PROFILE:\nFull name: Navarro, Elton John S.\nAge: 24\nAddress:Muntinlupa, Metro Manila");
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:1 available: 15\nSICK LEAVE used:2 available:26\nUNPAID LEAVE used:0 available: 365\nWORK FROM HOME used:1 available 29");
	}
	
	static void Orcega()
	{
		Console.WriteLine("PROFILE:\nFull name: Orcega, Jhyzel D.\nAge: 22\nAddress: Biñan, Laguna");
		Console.WriteLine("RECORD OF LEAVES:\nVACATION used:6 available: 10\nSICK LEAVE used:5 available:23\nUNPAID LEAVE used:0 available: 365\nWORK FROM HOME used:1 available 29");
	}
	
	}
}