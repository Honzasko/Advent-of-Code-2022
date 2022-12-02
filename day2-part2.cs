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
Dictionary<string,string> secret_patterns = new Dictionary<string, string>();
secret_patterns["A X"] = "A Z";
secret_patterns["A Z"] = "A Y";
secret_patterns["A Y"] = "A X";
secret_patterns["B X"] = "B X";
secret_patterns["B Z"] = "B Z";
secret_patterns["B Y"] = "B Y";
secret_patterns["C X"] = "C Y";
secret_patterns["C Z"] = "C X";
secret_patterns["C Y"] = "C Z";


foreach (string line in lines)
{
    score += patterns[secret_patterns[line]];
}

Console.WriteLine(score);