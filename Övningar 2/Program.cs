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
















Console.ReadLine();