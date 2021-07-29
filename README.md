# Valocity Technical Assessment

This assessment is designed to test how you follow instructions and think about
the holistic impact of your entire code. It's purpose is not to try and trick
you or catch you out but to get an understanding of how you think about software.

Take as much or as little time as you like, however we suggest around
**90 minutes** to get through as much as you can. Feel free to search for
solutions, read documentation, ask for help. Just make sure that you try to
understand any code that you do not directly come up with before copy pasting
it in here.

It is up to you to manage your time. The answers will be assessed against the
role you have applied for so ensure you demonstrate the key objectives expected
by the role.

## Getting started

You will need [git](https://git-scm.com/) and a code editor of your choice.
We recommend [Visual Studio Code](https://code.visualstudio.com/) with
[Remote development in Containers](https://code.visualstudio.com/docs/remote/containers-tutorial),
this project contains a [development container definition](./.devcontainer/devcontainer.json).
Once this workspace has re-opened in the remote container run the following
commands to ensure you are setup and ready to go.

```pwsh
dotnet restore
dotnet build
dotnet test
```

## Submitting

**Commit** to the local git repo **often** to show progress and workflow. Ensure
the comments explain **why** you did the change.

To submit your solution:

 1. Ensure you have committed all your changes
 1. Run `git clean -xdf` to clear our any build artifacts
 1. Compress the solution source into a single archive
    - > ⚠ Ensure the .git folder and other hidden files are included in the archive
 1. Send on through!

### Exercise 1: Code Review

This will asses your knowledge of clean code and ability to critique code.
The code in [CodeToReview.cs](CodeToReview.cs) has been submitted by an intern
from another team to a code base you depend on. Using inline comments, review
the code with enough context for the author to learn and enhance the code.

### Exercise 2: Working with legacy code

This will asses your ability to [refactor](https://www.lexico.com/definition/refactor)
code. Open the [CodingAssessment solution](./ReFactor/CodeToRefactor.cs) and improve
the code base. Use comments, commit messages and automated tests to express your
reasoning, assumptions and issues encountered.

### Exercise 3: Clean green fields project

This will asses your


- Ability to design solutions

- Ability to decompose problems

- Knowledge of clean architecture
- Knowledge of continuous delivery and devops

> **As** an enthusiastic card player and developer </br>
> **I want to** create a program to play cards against the computer </br>
> **So that** when I am bored I can play against an intelligent opponent.

#### Constraints

Unsure of what UI to build for, or what card game I should code for. We will figure that out later. At this stage I know I need a concept of a Deck, Cards and a Shuffle function.

How would you setup your new solution and why?

- Show me your initial to do list with some reasoning, for example:
  - Development environment setup
  - Scaffold / structure of your solution
  - What would your delivery pipeline look like
- Scaffold your solution
  - See how much you can scaffold out to hand to another team member to continue with
  - Bonus points if you have something working
