# Counting String Chars

A beginner level task for practicing loops.

The task is to implement four methods using "for", "while" and "do" statements.


## Get the Project

* [Fork the task project (repository)](https://docs.gitlab.com/ee/user/project/repository/forking_workflow.html#creating-a-fork) in GitLab.
* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

The implementation details are described with TODO comments in code files. For all the methods you have to implement, there are functionally equivalent methods implemented with recursion. Analyze these methods and run unit tests for them before starting to implement the methods you have to implement.

 You are not allowed to use any extension method from [System.Linq namespace](https://docs.microsoft.com/en-us/dotnet/api/system.linq).

1. Analyze the implementation of the "GetCharCountRecursive" methods in [ForMethods.cs](CountingStringChars/ForMethods.cs) file. Implement "GetCharCount" static method. See TODO.
1. Analyze the implementation of the "GetUpperCharCountRecursive" methods in [ForMethods.cs](CountingStringChars/ForMethods.cs) file. Implement "GetUpperCharCount" static method. See TODO.
1. Analyze the implementation of the "GetSpaceCountRecursive" method in [WhileMethods.cs](CountingStringChars/WhileMethods.cs) file. Implement "GetSpaceCount" static method. See TODO.
1. Analyze the implementation of the "GetPunctuationCountRecursive" method in [WhileMethods.cs](CountingStringChars/WhileMethods.cs) file. Implement "GetPunctuationCount" static method. See TODO.
1. Analyze the implementation of the "GetDigitCountRecursive" methods in [DoWhileMethods.cs](CountingStringChars/DoWhileMethods.cs) file. Implement "GetDigitCount" static method. See TODO.
1. Analyze the implementation of the "GetLetterCountRecursive" method in [DoWhileMethods.cs](CountingStringChars/DoWhileMethods.cs) file. Implement "GetLetterCount" static method. See TODO.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintaining consistency of the project source code and avoiding silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.


## Save Your Work

* [Rebuild your solution](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio) in Visual Studio.
* Check out the [Error List window](https://docs.microsoft.com/en-us/visualstudio/ide/reference/error-list-window) for compiler errors and warnings. If you have any of those issues, **fix the issues** and rebuild the solution again.
* [Run all unit tests with Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer) and make sure there are **no failed unit tests**. Fix your code to [make all your unit tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing).
* Review all your changes **before** saving your work.
    * Open "Changes" view in [Team Explorer](https://docs.microsoft.com/en-us/visualstudio/ide/reference/team-explorer-reference).
    * Right click on a modified file.
    * Click on "Compare with Unmodified" menu item to open a comparison window.
* [Stage your changes](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#stage-your-changes) and [create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits#create-a-commit).
* Share your changes by [pushing them to a remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* C# Programming Guide
  * [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions)
* C# Reference
  * [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
  * [while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
  * [do..while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
  * [foreach..in statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in)
  * [nameof expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
  * [ref](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref)
* .NET API
  * [String.Length Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.length)
  * [String.Chars Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.chars)
  * [String.IsNullOrEmpty Method](https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty)
  * [Char.IsWhiteSpace Method](https://docs.microsoft.com/en-us/dotnet/api/system.char.iswhitespace)
* What's new in C#
  * C# 8.0 - [Indices and ranges](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges)
