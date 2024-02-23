using System;

string[] array = new string[] { "Tomato", "Cucumber", "Milk", "Bread", "Cheese", "Beer" };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
while (true)
{
    Console.WriteLine("Enter bought item ");
    string input = Console.ReadLine();
    bool found = false; 

    for (int i = 0; i < array.Length; i++)
    {
        if (string.Equals(array[i], input))
        {
            Console.WriteLine("Item found");
            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Item not found");
        Console.WriteLine("Please follow in Shopping list");
    }
    
}