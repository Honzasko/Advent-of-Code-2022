
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
UInt64 max2 = 0;
UInt64 max3 = 0;

for(int i = 0;i < calories.Count;i++)
{
    if(calories[i] > max)
    {
        max3 = max2;
        max2 = max;
        max = calories[i];
    }
    else if(calories[i] > max2)
    {
        max3 = max2;
        max2 = calories[i];
    }
    else if(calories[i] > max3) {
        max3 = calories[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max + max2 + max3);


