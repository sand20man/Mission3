/*
• Add Food Items
• Delete Food Items
• Print List of Current Food Items
• Exit the Program
*/

using Mission3;

int option = 0;
bool run = true;
string name = "";
string type = "";
int quantity = 0;
string expirationDate = "";
string result = "";




Foodies foodies = new Foodies(); // Create an instance of the Foodies class
while (run == true)
{
    // Ask User for option
    Console.WriteLine("\nWhat would you like to do?");
    Console.WriteLine("1. Add a food item");
    Console.WriteLine("2. Delete a food item");
    Console.WriteLine("3. Print a list of current food items");
    Console.WriteLine("4. Exit the program");

    option = int.Parse(Console.ReadLine());

    if (option == 1) // Add Food Item
    {
        Console.WriteLine("What is the name of the food item?");
        name = Console.ReadLine().ToLower();
        Console.WriteLine("What type of food?");
        type = Console.ReadLine();
        Console.WriteLine("How many?");
        quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the expiration date?");
        expirationDate = Console.ReadLine();

        // Call the addFood method correctly
        result = foodies.addFood(name, type, quantity, expirationDate);
        Console.WriteLine(result); // Output the result of adding the food item
    }
    else if (option == 2) //Delete Food Item
    {
        Console.WriteLine("What is the name of the food item?");
        name = Console.ReadLine().ToLower();
        result = foodies.deleteFood(name);
        Console.WriteLine(result);
    }
    else if (option == 3) //Print List of Current Food Item
    {
        Console.WriteLine("List of current food items: ");
        foodies.listFood();
    }
    else if (option == 4) // Exit
    {
        Console.WriteLine("Existing...");
        run = false;
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}