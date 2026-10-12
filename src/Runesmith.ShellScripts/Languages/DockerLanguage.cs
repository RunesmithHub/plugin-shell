using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>Dockerfile: its files, highlighting, comments and brackets.</summary>
public sealed class DockerLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Dockerfile { get; } = new("dockerfile", "Dockerfile")
    {
        Extensions = [".dockerfile", ".containerfile"],
        FileNames = ["Dockerfile", "Containerfile"],
        ScopeName = "source.dockerfile",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "package",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition DockerfileGrammar { get; } = GrammarFiles.Find("source.dockerfile", "docker/docker.tmLanguage.json");
}
