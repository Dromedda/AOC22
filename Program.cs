// TODO: allow the user to enter an integer as an argument, that integer is the day you want to run.
public class AOC {
	
	static void Main(string[] args) {
  	
		string selected_day = "none";

  	// Go through all the args passed into the application from terminal
  	// for (int i = 0; i < args.GetLength(0); i++) {
			// Console.WriteLine(args[i]);
  	// }

		if (args.GetLength(0) == 0) {
			Console.WriteLine("ADVENT OF CODE 2022!"); 
		
			Console.WriteLine("Select which day to run: (1 -> 25)"); 

			// TODO Validate input.
		
			selected_day = Console.ReadLine(); 

		} else {
			selected_day = args[0];

			// TODO Validate Arg0
		}
	
		// TODO Run the selected_day

		Days.run_day(int.Parse(selected_day)); 	

		Console.WriteLine("YOU SELECTED DAY: " + selected_day); 
		
		// Peak User Experience right here.
		Console.WriteLine("Press enter/return to exit..."); 
		Console.ReadLine();
	}

}

public class Days {

	// Runs the corresponding function for the selected day
	public static void run_day(int day) {
		Console.WriteLine("TRIED TO RUN DAY:" + day); 	

		// ugly switch case for all the days LUL
		switch (day) {
			case 1:	 
				day1(); 	
				break; 
			default: 
				Console.WriteLine("Failed to select the day"); 	
				break; 
		}

	}
	
	// Day 1
	static void day1() {
		Console.WriteLine("RAN DAY 1");
	}

}
