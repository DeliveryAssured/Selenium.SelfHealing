using NUnit.Framework;

[assembly: LevelOfParallelism(4)]
[assembly: Parallelizable(ParallelScope.All)]

namespace Sample.NUnit
{
    // ReSharper disable once UnusedMember.Global
    public class ParallelismSettings
    {
    }
}