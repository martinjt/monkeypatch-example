using Microsoft.CodeAnalysis;

namespace ConsolePrefixer;

[Generator]
public class EvilConsolePrefixerGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        context.AddSource("Globals", "global using Console = EvilConsolePrefixer.PrefixConsole;");
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}
