# Exception Handling Basics

This is a beginner level task for practicing exception handling.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

1. Add exception handling constructions (try-catch) to [HandlingExceptions.cs](ExceptionHandling/HandlingExceptions.cs) file. See TODO comments there.
2. Add exception throwing code (throw) to [ThrowingExceptions.cs](ExceptionHandling/ThrowingExceptions.cs) file. See TODO comments there.


## Fix Compiler Issues

Additional style and code checks are enabled for the projects in this solution to help you maintain consistency of the project source code and avoid silly mistakes. [Review the Error List](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-the-error-list) in Visual Studio to see all compiler warnings and errors.

If a compiler error or warning message is not clear, [review errors details](https://docs.microsoft.com/en-us/visualstudio/ide/find-and-fix-code-errors#review-errors-in-detail) or google the error or warning code to get more information about the issue.

### "System.Exception should not be thrown by user code"

You will get a warning message during the compilation process (CA2201: Exception type System.Exception is not sufficiently specific) and in Sonar's output (System.Exception should not be thrown by user code) saying that you should avoid throwing the Exception class instances in your code. Read a [discussion about using non-specific exception types for throwing exceptions](https://stackoverflow.com/questions/22453650/why-are-we-not-to-throw-these-exceptions) and [CA2201 rule documentation](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca2201).

Ignore this warning for the task, but remember - *never ever throw an instance of the Exception class* (unless you have a good reason for doing this).

```cs
// DO
throw new ArgumentNullException();
throw new ArgumentException();
throw new ArgumentOutOfRangeException();

// DON'T
throw new Exception();
throw new ApplicationException();
throw new SystemException();
```

The good solution for fixing the warning is to replace the generic exception type (Exception class) to a specific exception type.


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

* C# Programming Guide
  * [Exceptions and Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/)
  * [Use exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/using-exceptions)
  * [Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/exception-handling)
  * [Creating and Throwing Exceptions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/creating-and-throwing-exceptions)
  * [How to handle an exception using try/catch](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/how-to-handle-an-exception-using-try-catch)
* C# Reference
  * [nameof expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
  * [throw](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw)
  * [try-catch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch)
* .NET API
  * [ArgumentException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)
  * [ArgumentNullException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)
  * [ArgumentOutOfRangeException Class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception)
