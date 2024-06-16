using DotNetInternal.MemoryLeak;

SampleClass sampleClass = new SampleClass();

for (int i = 0; i < 10; i++)
{
    SampleClass temp = new();

}
//GC
Console.WriteLine(SampleClass.InstanceCount);

Console.ReadLine();