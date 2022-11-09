// See https://aka.ms/new-console-template for more information


using ConsoleApp1;


IntSumSummer summer = new IntSumSummer();

List<int> testSet1 = new List<int>() { 1 }; // 0
List<int> testSet2 = new List<int>() { 1, 2}; // 3
List<int> testSet3 = new List<int>() { 5, 2}; // 7
List<int> testSet4 = new List<int>() { 1, 2, 3}; // 18
List<int> testSet5 = new List<int>() { 1, 2, 3, 4}; // 52
List<int> testSet6 = new List<int>() { 1, 2, 3, 4, 5}; // 117
List<int> testSet7 = new List<int>() { 3, 2, 8, 41, 5, 6}; // 1248

Console.WriteLine("summer.GetSum(testSet1): " + summer.GetSum(testSet1));
Console.WriteLine("summer.GetSum(testSet2): " + summer.GetSum(testSet2));
Console.WriteLine("summer.GetSum(testSet3): " + summer.GetSum(testSet3));
Console.WriteLine("summer.GetSum(testSet4): " + summer.GetSum(testSet4));
Console.WriteLine("summer.GetSum(testSet5): " + summer.GetSum(testSet5));
Console.WriteLine("summer.GetSum(testSet6): " + summer.GetSum(testSet6));
Console.WriteLine("summer.GetSum(testSet7): " + summer.GetSum(testSet7));
