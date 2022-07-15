# Morse Code Translator

An intermediate level task for practicing strings.

The task is to implement four methods for translating a text message to a Morse code message and from a Morse code message to a text message.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

1. Implement "TranslateToMorse" method in the [Translator.cs](MorseCodeTranslator/Translator.cs) file. The method should convert a text message to Morse code message using '.' as a dot symbol, '-' as a dash, and ' ' (space) as a space between Morse code letters. The method should ignore all other characters in the source text message. Use the StringBuilder class for creating a result Morse code message, and [MorseCodes](MorseCodeTranslator/MorseCodes.cs) class for translating alpha characters to Morse code letters.
1. Implement "TranslateToText" method in the [Translator.cs](MorseCodeTranslator/Translator.cs) file. The method should convert a Morse code message to a text message using the symbols like in the previous task. Use the StringBuilder class for creating a text message, and [MorseCodes](MorseCodeTranslator/MorseCodes.cs) class for translating Morse code letters to alpha characters.
1. Implement "WriteMorse" method in the [Translator.cs](MorseCodeTranslator/Translator.cs) file. The method should use an external code table for translating a text message to Morse code, and write the Morse code message to a StringBuilder. Also, the method should support additional parameters as a dot, dash and separator symbols.
1. Implement "WriteText" method in the [Translator.cs](MorseCodeTranslator/Translator.cs) file. The method should use an external code table for translating a Morse code message to a text message, and write the text message to a StringBuilder. Also, the method should support additional parameters as a dot, dash and separator symbols.
1. Refactor "TranslateToMorse" method to use "WriteMorse" method for translating messages.
1. Refactor "TranslateToText" method to use "WriteText" method for translating messages.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.


## Save Your Work

* [Rebuild your solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio) in Visual Studio.
* Check out the [Error List window](https://docs.microsoft.com/en-us/visualstudio/ide/reference/error-list-window) for compiler errors and warnings. If you have any of those issues, **fix issues** and rebuild the solution again.
* [Run all unit tests with Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer) and make sure there are **no failed unit tests**. Fix your code to [make all your unit tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing).
* Review all your changes **before** saving your work.
    * Open "Changes" view in [Team Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/reference/team-explorer-reference).
    * Click with your right mouse button on a modified file.
    * Click on "Compare with Unmodified" menu item to open a comparison window.
* [Stage your changes](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#stage-your-changes) and [create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#create-a-commit).
* Share your changes by [pushing them to remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* [Morse code](https://en.wikipedia.org/wiki/Morse_code)
* .NET Fundamentals
  * [Using the StringBuilder Class in .NET](https://docs.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder)
* .NET API
  * [StringBuilder Class](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)
