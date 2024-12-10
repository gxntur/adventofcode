// See https://aka.ms/new-console-template for more information
using adventofcode.Helpers;
using adventofcode.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

DayFactory dayFactory = new();

try {
    Console.WriteLine("Enter day: ");
    int dayInput = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter part: ");
    int partInput = int.Parse(Console.ReadLine());

    IDay day = dayFactory.CreateDay(dayInput);

    if (day == null) return;

    Console.WriteLine($"Day {dayInput} Part {partInput} Solution = {(partInput == 1 ? day.SolvePart1() : day.SolvePart2())}");
} 
catch (Exception e)
{
    Console.WriteLine(e.Message);
}