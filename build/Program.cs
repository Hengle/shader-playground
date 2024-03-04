using Cake.Common;
using Cake.Core;
using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public string ArtifactsPath { get; }

    public bool AlwaysCache { get; }
    public string BuildConfiguration { get; }

    public BuildContext(ICakeContext context)
        : base(context)
    {
        ArtifactsPath = "../artifacts";

        AlwaysCache = context.Argument("always-cache", false);
        BuildConfiguration = context.Argument("configuration", "Release");
    }
}