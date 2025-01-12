using BenchmarkDotNet.Running;
using Practice.Stack;

// IntStack stack = new();
// stack.Push(10);
// var value = stack.Pop();
// Console.WriteLine(value);


BenchmarkRunner.Run<Benchmarks>();