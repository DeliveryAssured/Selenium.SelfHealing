using NUnit.Framework;

[assembly: LevelOfParallelism(4)]
[assembly: Parallelizable(ParallelScope.All)]

namespace Sample.NUnit
{
    public class ParallelismSettings
    {
    }
}