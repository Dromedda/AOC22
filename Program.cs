// TODO: allow the user to enter an integer as an argument, that integer is the day you want to run.
public class AOC {
	static void Main(string[] args) {
  	
  	// Go through all the args passed into the application from terminal
  	for (int i = 0; i < args.GetLength(0); i++) {
			Console.WriteLine(args[i]);
  	}

		Console.WriteLine("ADVENT OF CODE 2022!"); 
		
		// Peak User Experience right here.
		Console.WriteLine("Press any key to exit..."); 
		Console.ReadLine();
	}
}

