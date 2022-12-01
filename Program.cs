using Aoc;

class AOC {
	static void Main(string[] args) {
		string selected_day = "none";
		if (args.GetLength(0) == 0) {
			Console.WriteLine("ADVENT OF CODE 2022!"); 
			Console.WriteLine("Select which day to run: (1 -> 25)"); 
			selected_day = Console.ReadLine(); 
		} else {
			selected_day = args[0];
		}
		// Run the Selected day
		Aoc.Main.runDay(int.Parse(selected_day)); 	
		// Peak User Experience right here.
		Console.WriteLine("Press enter/return to exit..."); 
		Console.ReadLine();
	}
}

