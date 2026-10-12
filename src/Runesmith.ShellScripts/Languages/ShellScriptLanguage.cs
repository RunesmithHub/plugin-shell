using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.ShellScripts.Languages;

/// <summary>Shell Script: its files, highlighting, comments and brackets.</summary>
public sealed class ShellScriptLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Shellscript { get; } = new("shellscript", "Shell Script")
    {
        Extensions =
        [
            ".sh", ".bash", ".bashrc", ".bash_aliases", ".bash_profile", ".bash_login", ".ebuild", ".profile", ".bash_logout",
            ".xprofile", ".xsession", ".xsessionrc", ".Xsession", ".zsh", ".zshrc", ".zprofile", ".zlogin", ".zlogout", ".zshenv",
            ".zsh-theme", ".ksh", ".csh", ".cshrc", ".tcshrc", ".yashrc", ".yash_profile",
        ],
        FileNames =
        [
            "APKBUILD", "PKGBUILD", ".envrc", ".hushlogin", "zshrc", "zshenv", "zlogin", "zprofile", "zlogout", "bashrc_Apple_Terminal",
            "zshrc_Apple_Terminal",
        ],
        ScopeName = "source.shell",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "terminal",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition ShellscriptGrammar { get; } = GrammarFiles.Find("source.shell", "shellscript/shell-unix-bash.tmLanguage.json");
}
