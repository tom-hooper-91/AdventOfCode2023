using AdventOfCode2023;

// Day 1
var lines = File.ReadAllLines("PuzzleInputs/Day1.txt");

Console.WriteLine($"Day 1 = {Day1.CalculateTotal(lines)}");

// Day 2
var games = File.ReadAllLines("PuzzleInputs/Day2.txt");

Console.WriteLine($"Day 2 = {Day2.CalculateGamesTotal(games)}");