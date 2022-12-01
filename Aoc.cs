namespace Aoc {
	class Main {
		public static void runDay(int day) {
			Console.WriteLine("Attempting to run day: " + day); 
			switch(day) {
				case 1: 
					day1(); 
					break; 	
				default: 
					Console.WriteLine("Failed to run the provided day : " + day);
					break; 
			}
		}
		// Main Function for day 1
		static void day1() {
			string[] data = File.ReadAllLines("./data/day1.txt");
			int sum = 0; 
			List<int> listOfSums = new List<int>(); 

			for (int i = 0; i < data.GetLength(0); i++) {
				// check if newline, its a hack, and it works with the data we have. 
				if (data[i].Length < 1) {
					listOfSums.Add(sum); 
					sum = 0; 
				} else {
					sum += int.Parse(data[i]); 
				}
			}

			listOfSums.Sort(); 

			// Output largest Sum
			Console.WriteLine("Largest Sum: " + listOfSums[listOfSums.Count-1]); 

			// get the top 3. 
			int top3 = listOfSums[listOfSums.Count-1] + listOfSums[listOfSums.Count-2] +  listOfSums[listOfSums.Count-3]; 
			Console.WriteLine("Total of top3: " + top3); 
		} 
	}
}
