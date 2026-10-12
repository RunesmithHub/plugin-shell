using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>Batch: its files, highlighting, comments and brackets.</summary>
public sealed class BatchLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Bat { get; } = new("bat", "Batch")
    {
        Extensions = [".bat", ".cmd"],
        ScopeName = "source.batchfile",
        LineComment = "@REM",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "terminal",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition BatGrammar { get; } = GrammarFiles.Find("source.batchfile", "bat/batchfile.tmLanguage.json");
}
