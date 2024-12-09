// See https://aka.ms/new-console-template for more information
using adventofcode;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

DayFactory dayFactory = new();

Console.WriteLine("Enter day: ");
int dayInput = int.Parse(Console.ReadLine());

Console.WriteLine("Enter part: ");
int partInput = int.Parse(Console.ReadLine());

IDay day = dayFactory.CreateDay(dayInput);

if (day == null) return;

Console.WriteLine($"Day {dayInput} part {partInput} solution: {(partInput == 1 ? day.SolvePart1() : day.SolvePart2())}");