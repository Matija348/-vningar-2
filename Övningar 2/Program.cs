 List<string> leksaker = [
  "Barbie",
  "Lightning Mcqueen",
  "Buzz Lightyear",
  "Thomas the tank engine",    
  "Woody",
  "Ken",
];

// for(int i = 0; i < leksaker.Count; i++)
// {
//     Console.WriteLine($"[{i}]{leksaker[i]}");
// }


List<string> klasskamrater = [
    "Felix.E",
    "Adam",
    "Rasmus",
    "Felix.Ö",
    "Janan",
    "Imad",
];

List<string> numbers = [
    "7",
    "1",
    "5",
    "8",
    "2",
    "0",
];

List<string> cities =[

];

 for(int i = 0; i < klasskamrater.Count; i++)
 { 
     Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {numbers[i]}");
 }

Console.WriteLine("\nAnge städer (skriv 'exit' för att avsluta):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }
            cities.Add(input);
        }

Console.WriteLine("\nDu angav följande städer:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }



Console.ReadLine();