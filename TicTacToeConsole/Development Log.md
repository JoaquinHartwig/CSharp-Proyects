Development Log – Tic-Tac-Toe Project 

13/06/26

Current Progress

Today I continued working on my Tic-Tac-Toe project and spent time understanding the architecture and logic behind the game rather than simply copying code.

This session introduced several new concepts that are helping me improve my understanding of C# and Object-Oriented Programming.

Concepts Studied

Enums

I learned how enums can be used to represent game states in a clean and readable way.

Example:

- None
- X
- O

This makes the game board easier to manage and prevents invalid values from being stored.

Two-Dimensional Arrays

I explored how a Tic-Tac-Toe board can be represented using a 3x3 matrix.

This helped me understand how coordinates work and how positions can be accessed using row and column indexes.

Properties

I continued learning about properties and why developers often expose data through properties instead of directly accessing fields.

I also encountered examples of public getters with private setters and learned how they help protect data from being modified incorrectly.

Events

I was introduced to events and saw examples such as:

public event Action<int, int> MoveMade;

Although I still need more practice with events, I now have a basic understanding that they allow objects to notify other parts of the program when something happens.

Win Detection Logic

One of the most interesting parts was studying how the game determines if a move wins the match.

I learned how rows, columns, and diagonals can be represented using coordinate arrays and checked through reusable methods instead of writing repetitive code.

I also started understanding how additional information about a victory can be stored using a dedicated class such as "WinInfo".

What I Learned

The most valuable lesson today was realizing how larger projects are built from many small pieces working together.

Instead of writing everything inside one huge method, the project separates responsibilities into smaller methods and classes, making the code easier to understand and maintain.

Challenges

Some parts of the code were difficult to understand at first, especially:

- Events
- Out parameters
- Win detection methods
- Arrays of tuples

However, after analyzing them step by step, I began to understand the reasoning behind their implementation.

Next Goals

As I continue developing and studying this project, I would like to learn more about:

- Events and delegates
- Better object-oriented design
- Graphical interfaces
- Game architecture
- More advanced C# features

Personal Reflection

This project is significantly more advanced than the previous projects I have completed.

Even though I do not fully understand every line yet, I can already see how much I am improving by reading, analyzing, and questioning the code instead of simply reproducing it.

My goal is not only to finish the project, but also to understand the design decisions behind it and use that knowledge in my future projects.

# Development Log - 13/06/2026

Today I continued working on my Tic-Tac-Toe project in C#.

One interesting challenge was that the original tutorial I was following was built using WPF, while I had implemented the entire project as a console application. At first I thought I had made a mistake, but after reviewing the code I realized that the most valuable part of the project was the game logic itself.

During this session I worked on:

* Understanding and implementing a 3x3 game board using a two-dimensional array.
* Practicing object-oriented programming concepts.
* Using enums to represent players and winning conditions.
* Implementing turn management between players.
* Detecting valid and invalid moves.
* Detecting victories through rows, columns, and diagonals.
* Detecting draw situations.
* Learning how events work in C# and using them to notify game actions.
* Displaying the game board in the console.
* Creating a fully playable two-player console version of Tic-Tac-Toe.

A large portion of the session was dedicated to understanding the code instead of simply copying it. I spent time analyzing methods, properties, events, enums, multidimensional arrays, and how different classes interact with each other.

Although the project is currently a console application, I plan to revisit it in the future and rebuild it using WPF in order to learn graphical user interface development in C#.

Today's session helped reinforce several important C# concepts while also showing me how different parts of a larger project fit together.
