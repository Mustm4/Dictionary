//DEL 1


/*
string[] names = File.ReadAllLines("../../../Husdjur.txt");

List<int> str = new List<int>();
Dictionary<string, int> Djur = new Dictionary<string, int>();


foreach (var item in names)
{
    List<string> animal = new List<string>(item.Split(" , "));
    int a = int.Parse(animal[1]);
    str.Add(a);
    animal.RemoveAt(1);
    Djur.Add(animal[0], a);

}
var choice = Console.ReadLine();

Console.WriteLine(Djur[choice]);
*/



//DEL 2

string[] names;

names = File.ReadAllLines("../../../Husdjur.txt");


List<int> str = new List<int>();
Dictionary<string, int> Djur = new Dictionary<string, int>();


foreach (var item in names)
{
    List<string> animal = new List<string>(item.Split(" , "));
    if (animal.Count == 2 && int.TryParse(animal[1], out int number))
    {
        str.Add(number);
        Djur.Add(animal[0], number);
    }
    else
    {
        Console.WriteLine($"Ogiltig rad: {item}");
    }
}

sort(str);

Console.WriteLine("Sorterade siffror: ");
foreach (int item in str)
{
    Console.WriteLine(item);
}


void sort(List<int> numbers)
{
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        for (int j = 0; j < numbers.Count - i - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
}

File.WriteAllLines("../../../Sort.txt", str.Select(x => x.ToString()));