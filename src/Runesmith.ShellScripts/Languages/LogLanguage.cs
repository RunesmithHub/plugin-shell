using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>Log: its files, highlighting, comments and brackets.</summary>
public sealed class LogLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Log { get; } = new("log", "Log")
    {
        Extensions = [".log"],
        ScopeName = "text.log",
        Brackets = [('(', ')'), ('[', ']'), ('{', '}')],
        Icon = "file-text",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition LogGrammar { get; } = GrammarFiles.Find("text.log", "log/log.tmLanguage.json");
}
