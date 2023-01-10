
printNoseCone();
printBody();


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

static void printBody() {
	printEdge();
	printDiamondTop();
	printDiamondBottom();
	printEdge();
	printDiamondBottom();
	printDiamondTop();

	printEdge();
}

static void printDiamondTop() {

	for (int line = 1; (line <= 10); line++) {

		//print "|" for every line
		Console.Write("|");

		//prints left "."
		for (int i = 1; i <= (10 - line); i++) {
			Console.Write(".");
		}

		//prints left "/\"
		for (int i = 1; i <= (line); i++) {
			Console.Write("/\\");
		}

		//prints middle "."
		for (int i = 1; i <= -2 * line + 2 * 10; i++) {
			Console.Write(".");
		}

		//prints right "/\"
		for (int i = 1; i <= (line); i++) {
			Console.Write("/\\");
		}

		//prints right "."
		for (int i = 1; i <= (10 - line); i++) {
			Console.Write(".");
		}

		//print "|" for every line on right side
		Console.WriteLine("|");
	}
}

//this will print the middle of the body
static void printDiamondBottom() {

	for (int line = 1; (line <= 10); line++) {

		//print "|" for every line
		Console.Write("|");

		//prints left dots
		for (int i = 1; i <= (line - 1); i++) {
			Console.Write(".");
		}

		//prints "\/"
		for (int i = 1; i >= (line - 10 + 1); i--) {
			Console.Write("\\/");
		}

		//prints middle dots
		for (int i = 1; i <= (2 * line - 2); i++) {
			Console.Write(".");
		}

		//prints "\/"
		for (int i = 1; i >= (line - 10 + 1); i--) {
			Console.Write("\\/");
		}

		//prints right "."
		for (int i = 1; i <= (line - 1); i++) {
			Console.Write(".");
		}

		//print "|" for every line on right
		Console.WriteLine("|");

	}
}

static void printEdge() {

	//this will print out + on left
	Console.Write("+");

	//this prints *=
	for (int line = 1; line <= (2 * 10); line++) {
		Console.Write("=*");
	}


	Console.WriteLine("+");
}                





