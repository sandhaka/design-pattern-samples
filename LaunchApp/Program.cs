using CliFx;

await new CliApplicationBuilder()
    .SetDescription("Conceptual implementations of some Design Patterns in C#")
    .AddCommandsFromThisAssembly()
    .Build()
    .RunAsync();