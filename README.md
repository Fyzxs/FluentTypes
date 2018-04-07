# FluentTypes
## Avoid Primitive Obsession with Fluent Types

The goal of this project is to avoid Primitive Obsession. It's not a "new primitive" type that exposes all of the behavior. 
The project is meant to be pulled into your solution. Modify the `Type` base class to include only the functionality you need when you need it.
Then it represents exactly what the project needs.

Create objects to represent the concepts you want. A `Name` should be an object; that perhaps is composed of a Text. Text itself doesn't represent a `Name`. 
The FluentTypes help navigate the microObject space and are a style that enables easy functionality and fluidity in the code.

I'm still experimenting with how this functions in the code and where it fails. 