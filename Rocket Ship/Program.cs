
printNoseCone();


void printNoseCone() {

	for (int line = 1; line <= (5); line++) {

		//this will print out spaces
		for (int i = 1; i <= (-1 * line + (10)); i++) {
			Console.Write(" ");
		}

		//this will print out forward slashes
		for (int i = 1; i <= line; i++) {
			Console.Write("/");
		}

		//this will print the 2 stars in the center of cone
		Console.Write("**");

		//this will print the backslashes
		for (int i = 1; i <= line; i++) {
			Console.Write("\\");
		}
		Console.WriteLine("");
	}
}



