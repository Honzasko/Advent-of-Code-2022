string[] lines = File.ReadAllLines("input.txt");

int score = 0;

Dictionary<string,int> patterns = new Dictionary<string, int>();
patterns["A X"] = 4;
patterns["A Z"] = 3;
patterns["A Y"] = 8;
patterns["B X"] = 1;
patterns["B Z"] = 9;
patterns["B Y"] = 5;
patterns["C X"] = 7;
patterns["C Z"] = 6;
patterns["C Y"] = 2;

foreach (string line in lines)
{
    score += patterns[line];
}

Console.WriteLine(score);