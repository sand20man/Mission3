namespace Mission3;

public class FoodItem
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Quantity { get; set; }
    public string ExpirationDate { get; set; }

    public FoodItem(string name, string type, int quantity, string expirationDate) //FoodItem objects
    {
        Name = name;
        Type = type;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }
}

public class Foodies
{
    private List<FoodItem> foodItems = new List<FoodItem>(); // List to manage FoodItem objects
    
    public string addFood(string name, string type, int quantity, string expirationDate) // Add a food item
    {
        FoodItem newFood = new FoodItem(name, type, quantity, expirationDate); // Create FoodItem object
        foodItems.Add(newFood); // Add to the list
        return $"Added: {newFood.Name}\n";
    }
    
    public string deleteFood(string name) //Delete specific food item
    {
        // Example implementation: return a success message
        foodItems.Remove(foodItems.FirstOrDefault(item => item.Name == name));
        return $"Deleted: {name}\n";
    }

    public void listFood() //List objects in foodItem list
    {
        foreach (var item in foodItems)
        { 
            Console.WriteLine($"- Name: {item.Name}, Type: {item.Type}, Quantity: {item.Quantity}, Expiration Date: {item.ExpirationDate}");
        }
    }
}