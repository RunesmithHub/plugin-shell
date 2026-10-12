using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>Makefile: its files, highlighting, comments and brackets.</summary>
public sealed class MakeLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Makefile { get; } = new("makefile", "Makefile")
    {
        Extensions = [".mak", ".mk"],
        FileNames = ["Makefile", "makefile", "GNUmakefile", "OCamlMakefile"],
        ScopeName = "source.makefile",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "settings",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition MakefileGrammar { get; } = GrammarFiles.Find("source.makefile", "make/make.tmLanguage.json");
}
