# Determine Your Scrabble Word's Score

### Authors: *Saoud Rana, Faisal Rana, Tyler Sinks*
_built April 19 and 20, 2021_

## What does this thing do?
* runs in the console using the .Net framework (version 5.0.x)
* asks for a word
* returns your word's score calculated (summed)
* uses these values for scoring:

| Letter                       | Score |
|------------------------------|-------|
| A, E, I, O, U, L, N, R, S, T | 1     |
| D, G                         | 2     |
| B, C, M, P                   | 3     |
| F, H, V, W, Y                | 4     |
| K                            | 5     |
| J, X                         | 8     |
| Q, Z                         | 10    |

## Setup and Installation
_the code only depends on just a few built-in namespaces which will be brought into the picture by following these steps_

1. Use a termainl or console to navigate to the desired directory for this project
2. Clone the project to your machine:
>> ` $ git clone https://github.com/sinkstyt/Scrabble.Solution.git `
3. Change directory into the project's root folder:
>> ` $ cd Scrabble.Solution `
4. Restore the project's dependencies:
>> ` $ dotnet restore Scrabble Scrabble.Tests `
5. To use the project:
>> ` $ dotnet run `
6. Or, to examine the files in VS Code instead of step 5:
>> ` $ code . `

For those completely new to C# and dotnet, please see these detailed instructions:
* [Installing C# and .NET](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* [MSTest Configuration and Setup](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-configuration-and-setup)

## Known Bugs
* No known bugs

### Support and contact details
_Please feel free to open an issue or pull request if you would like to make changes to this repository._
_For contact information, see the Contact section of this README_

### Technologies Used
* _C# and .net5.0_
* _MS Test_
* `git` _and GitHub_
* [C# and .Net curriculum](https://www.learnhowtoprogram.com/c-and-net)
* _VS Code_

### License
* [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/saoud/csharp-TDD-template/blob/main/LICENSE)
* Copyright 2021 :copyright:  Saoud Rana, Faisal Rana, Tyler Sinks

### Contact
[Saoud Rana](mailto:githubissues@saoud.dev)<br>
[Faisal Rana](mailto:inquisitive@gmail.com)<br>
[Tyler Sinks](mailto:tyler.sinks@gmail.com)