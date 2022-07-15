# Getting a Character Index

A beginner level task for practicing loops (for, while, do..while).

In the task you have to implement six "GetIndexOfChar" methods that should return the zero-based index (position) of the first occurence of the specified character ("value" parameter) in the string that is passed as a "str" parameter.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

The implementation details are described in TODO comments in code files. There are six "GetLastIndexOfChar" methods that you can use as examples. Analyze these methods and run unit tests for them before you start to implement methods you have to implement.

It's allowed to use [String.Length](https://docs.microsoft.com/en-us/dotnet/api/system.string.length) and [String.Chars](https://docs.microsoft.com/en-us/dotnet/api/system.string.chars) properties only for solving the task. You are not allowed to use other static or instance methods of the [String class](https://docs.microsoft.com/en-us/dotnet/api/system.string) or any extension method from [System.Linq namespace](https://docs.microsoft.com/en-us/dotnet/api/system.linq).

1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [ForMethods.cs](GettingCharIndex/ForMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #1.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char, int, int)" method in the [ForMethods.cs](GettingCharIndex/ForMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int)" static method. See TODO #2.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [WhileMethods.cs](GettingCharIndex/WhileMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #3.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char, int, int)" method in the [WhileMethods.cs](GettingCharIndex/WhileMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int)" static method. See TODO #4.
1. Analyze the implementation of the "GetLastIndexOfChar(string, char)" method in the [DoWhileMethods.cs](GettingCharIndex/DoWhileMethods.cs) file. Implement the "GetIndexOfChar(string, char)" static method. See TODO #5.
1. Analyze the implementation of the "GetLastIndexofChar(string, char, int, int)" method in the [DoWhileMethods.cs](GettingCharIndex/DoWhileMethods.cs) file. Implement the "GetIndexOfChar(string, char, int, int) static method. See TODO #6.


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
* Share your changes by [pushing them to remote repository](https://docs.microsoft.com/en-us/azure/devops/repos/git/pushing).


## See also

* C# Reference
  * [for statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for)
  * [while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while)
  * [do..while statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do)
  * [foreach..in statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in)
  * [Increment operator ++](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#increment-operator-)
  * [Decrement operator --](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#decrement-operator---)
  * [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions)
* .NET API
  * [String.Length Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.length)
  * [String.Chars Property](https://docs.microsoft.com/en-us/dotnet/api/system.string.chars)
