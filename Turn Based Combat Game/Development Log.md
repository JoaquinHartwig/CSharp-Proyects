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
