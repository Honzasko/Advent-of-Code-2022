
String[] lines = File.ReadAllLines("input.txt");
List<UInt64> calories = new List<UInt64>();
UInt64 kcal = 0;
foreach (string line in lines)
{
    if(line == "")
    {
        calories.Add(kcal);
        kcal = 0;
    }
    else {
        UInt64 k = UInt64.Parse(line);
        kcal += k;
    }
}

UInt64 max = 0;


for(int i = 0;i < calories.Count;i++)
{
    if(calories[i] > max)
    {

        max = calories[i];
    }

}

Console.WriteLine(max);


