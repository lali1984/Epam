# Morse Code Alphabet

A beginner level task for practicing branching (if and switch statements).

The task is to implement two methods that should return Morse code sequence for Lating characters (A-Z, a-z). Use [International Morse Code](https://en.wikipedia.org/wiki/Morse_code) table.


## Get the Project

* [Open a project from your remote repository](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo) or [get your local copy](https://docs.microsoft.com/en-us/azure/devops/repos/git/clone#clone-from-another-git-provider) with Visual Studio.


## Complete the Task

1. Implement "GetMorseCode" method in the [UsingIf.cs](MorseCodeAlphabet/UsingIf.cs) file using "if" statement only. The methods should return a Morse code letter as a string using "." symbol as dot and "-" symbol as dash.
1. Implement "GetMorseCode" method in the [UsingSwitch.cs](MorseCodeAlphabet/UsingSwitch.cs) file using "switch/case" statements only. The method should return a byte that represents a Morse code letter.

Read more about hexadecimal and binary numbers first!

[Byte is C#](https://docs.microsoft.com/en-us/dotnet/api/system.byte) is a data structure that can store 8-bit unsigned integer. Each bit in byte has its own position that starts with 0. The first bit has position 0, the last bit has position 7. Usually, we put the first bit on the right side, and the last bit on the left side.

An example of a 0 number in binary form.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Bit           | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

Each bit can be set to 1 or 0. Here's an example of decimal number 15. In binary form the literal looks like 0b0000_1111 and it is equals to 0x0F in hex form.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Bit           | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 |

For storing an information about a Morse code letter we will divide the bit into two parts - the high 4 bits (positions 4-7) and the low 4 bits (positions 0-3). The high part will contain a mask that should represents how many symbols a morse code has. The low part will contain the value that should represent a morse code.

Here's an example for 'A' character. The Morse code is ".-". The first symbol is "dot" (.), and the second is "dash" (-).

Let's put the Morse code for 'A' character to the table for both high (mask) and low (value) parts (beginning from lower bits).

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Morse code    |   |   | - | . |   |   | - | . |
| Mask          |   |   | 1 | 1 |   |   |   |   |
| Value         |   |   |   |   |   |   | 0 | 1 |
| Result byte   | 0 | 0 | 1 | 1 | 0 | 0 | 0 | 1 |

The code has two characters that means we put 1 in the mask part on positions 4 and 5. "Dot" in the value part is represented by 1 (position 0), and "dash" is represented by 0 (position 1).

The result literal in binary form is 0b0011_0001 and it is equal to 0x31 in hex form.


Another example - 'X' character. The Morse code is "-..-", 4 symbols. That means all bits in mask part should be set to 1. There are two "dots" in the value part on 1 and 2 positions.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Morse code    | - | . | . | - | - | . | . | - |
| Mask          | 1 | 1 | 1 | 1 |   |   |   |   |
| Value         |   |   |   |   | 0 | 1 | 1 | 0 |
| Result byte   | 1 | 1 | 1 | 1 | 0 | 1 | 1 | 0 |

The result literal in binary form is 0b1111_0110 and it is equal to 0xF6 in hex form.


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
* [Hexadecimal](https://en.wikipedia.org/wiki/Hexadecimal)
* [Binary number](https://en.wikipedia.org/wiki/Binary_number)
* C# Reference
  * [if-else](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else)
  * [switch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)
  * [static](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)
  * [Integral numeric types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
* C# Programming Guide
  * [Static Classes and Static Class Members](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
