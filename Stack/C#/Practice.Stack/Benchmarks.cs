using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace Practice.Stack;

[Config(typeof(AntiVirusFriendlyConfig))]
[MemoryDiagnoser]
public class Benchmarks
{
    [Benchmark]
    public void BenchmarkCustomStack()
    {
        IntStack stack = new();
        
        for (int index = 0; index < 1_000; index++)
        {
            stack.Push(index);
        }
        
        for (int index = 0; index < 1_000; index++)
        {
            var value = stack.Pop();
        }
    }

    [Benchmark]
    public void BenchmarkBclStack()
    {
        System.Collections.Stack stack = new();

        for (int index = 0; index < 1_000; index++)
        {
            stack.Push(index);
        }
        
        for (int index = 0; index < 1_000; index++)
        {
            var value = stack.Pop();
        }
    }
    
    [Benchmark]
    public void BenchmarkBclStackWithParsedValue()
    {
        System.Collections.Stack stack = new();

        for (int index = 0; index < 1_000; index++)
        {
            stack.Push(index);
        }
        
        for (int index = 0; index < 1_000; index++)
        {
            int value = int.Parse(stack.Pop()?.ToString());
        }
    }

    public void BenchmarkBclGenericStack()
    {
        
    }
}

public class AntiVirusFriendlyConfig : ManualConfig
{
    public AntiVirusFriendlyConfig()
    {
        AddJob(Job.MediumRun
            .WithToolchain(InProcessNoEmitToolchain.Instance));
    }
}