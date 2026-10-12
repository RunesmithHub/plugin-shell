using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>PowerShell: its files, highlighting, comments and brackets.</summary>
public sealed class PowerShellLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Powershell { get; } = new("powershell", "PowerShell")
    {
        Extensions = [".ps1", ".psm1", ".psd1", ".pssc", ".psrc"],
        ScopeName = "source.powershell",
        LineComment = "#",
        BlockComment = ("<#", "#>"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "terminal",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition PowershellGrammar { get; } = GrammarFiles.Find("source.powershell", "powershell/powershell.tmLanguage.json");
}
