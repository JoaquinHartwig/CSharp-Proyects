# Development Log — 11/06/2026

## Turn-Based Combat Game

Today I started working on a new C# project: a turn-based combat game.

The goal of this project is to reinforce Object-Oriented Programming concepts while building a simple combat system between units.

## Progress Made

### Created the `Unit` Class

I designed a base `Unit` class containing the core attributes required for combat:

* Current HP
* Maximum HP
* Attack Power
* Heal Power
* Unit Name
* Random number generator

This allows each unit to store its own combat statistics and identity.

### Constructor Initialization

Implemented a constructor to initialize all important values when creating a new unit.

I also learned that:

* `_currentHP` starts equal to `_maxHP`
* Each unit receives its own random generator
* Constructors help ensure objects are created in a valid state

### Attack System

Implemented the first version of the attack mechanic.

The attack system:

1. Generates a random multiplier using `Random.NextDouble()`
2. Scales the multiplier between approximately `0.75` and `1.25`
3. Calculates randomized damage
4. Applies damage to another unit through the `TakeDamage()` method

This creates variation in combat instead of dealing the exact same damage every turn.

### Damage System

Implemented a `TakeDamage()` method.

Current functionality:

* Reduces HP when damage is received

Future improvements will include:

* Preventing HP from dropping below zero
* Death detection
* Battle-ending conditions

## Concepts Reinforced

During this project I practiced:

* Classes and Objects
* Constructors
* Encapsulation with private fields
* Object interaction
* Methods
* Random number generation
* Basic game design logic
* Combat mechanics

## Challenges Encountered

While implementing the attack system, I spent time understanding how:

```text
Random.NextDouble()
```

works and how random multipliers can be used to make combat feel less predictable.

I also learned how one object can directly interact with another object by passing it as a method parameter.

Example:

```text
Unit attacks another Unit
```

instead of simply working with primitive variables.

## Next Steps

Planned features for the next development session:

* Healing system
* Death detection
* Turn management
* Multiple unit types
* Character classes
* Combat loop
* Battle winner detection
* Better combat messages

## Reflection

This project feels like an important step forward because I am no longer writing isolated exercises. Instead, I am beginning to build a complete system where multiple concepts work together.

Although the project is still simple, it is helping me understand how real programs are structured and how object-oriented programming can be used to model game mechanics.


# Development Log - Turn Based Combat Game — 13/06/2026



## Current Version Overview

Today I continued working on my first turn-based combat game in C#. The goal of this project is not only to build a playable game, but also to reinforce Object-Oriented Programming concepts through a practical project.

At this stage, the game is fully playable in the console and includes the core mechanics of a simple RPG battle system.

## Features Implemented

### Unit System

Created a `Unit` class to represent both the player and enemy characters.

Each unit contains:

* Current HP
* Maximum HP
* Attack Power
* Heal Power
* Name
* Random number generator

### Combat System

Implemented an attack system where:

* Units can attack each other.
* Damage is randomized using `Random.NextDouble()`.
* Damage varies between approximately 75% and 125% of the base attack value.
* Combat messages are displayed in the console.

### Healing System

Implemented a healing mechanic:

* Units can restore HP.
* Healing amount is randomized.
* HP cannot exceed the unit's maximum health.

### Death Detection

Added an `IsDead` property that checks if a unit has reached 0 HP or less.

When a unit dies:

* A defeat message is displayed.
* The battle ends.

### Turn-Based Gameplay

Implemented a basic turn loop:

1. Player chooses an action.
2. Player attacks or heals.
3. Enemy takes its turn.
4. Enemy randomly chooses between attacking and healing.
5. Battle continues until one unit is defeated.

## OOP Concepts Practiced

Through this project I reinforced:

* Classes and Objects
* Constructors
* Encapsulation
* Properties (Getters)
* Methods
* Object Interaction
* Random Number Generation
* Basic Game Logic

## Challenges and Lessons Learned

One of the most valuable parts of this project was understanding why certain design decisions are made.

Examples:

* Why a unit stores both `CurrentHP` and `MaxHP`.
* Why private fields should not be accessed directly from outside the class.
* How properties expose information safely.
* How objects can interact with other objects through methods.

Instead of simply writing code, I spent time understanding the reasoning behind each component.

## Future Improvements

Planned features for future versions:

* Character Classes (Warrior, Mage, Archer)
* Special Abilities
* Critical Hits
* Status Effects
* Inventory System
* Potions and Items
* Experience and Leveling
* Multiple Enemy Types
* Better Battle UI
* Save and Load System

## Reflection

This project is the first time I feel that I am building something that resembles a real game instead of a simple programming exercise.

Although the game is still small, I understand almost every line of code, which is more important to me than adding many features quickly.

The main objective going forward is to continue improving the project while keeping the code understandable and maintainable.
