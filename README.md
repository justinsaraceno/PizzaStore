#Pizza Store
###### A .NET Core Tutorial Project
![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Herb_Chanelo_making_pizza_in_Tallahassee%2C_Florida_%2812085847996%29.jpg/474px-Herb_Chanelo_making_pizza_in_Tallahassee%2C_Florida_%2812085847996%29.jpg "pizza maker")

###Overview
This is a simple .NET Core solution that demonstrates key concepts to .NET Core including: project structure; service providers; dependency injection; using configuration; consuming NuGet packages; referencing a project; unit testing.

###How To Use This Repository
This repository is broken out in to several branches, each containing a small step towards demonstrating the above mentioned concepts.  Toggle between these branches based on the structure defined below to see these code demonstrations.

###Lesson 1: .NET Core Project Structure & Dependency Injection
Step | Branch Name | Concept Shown
--- | --- | ---
1 | [step-1](https://github.com/justinsaraceno/PizzaStore/tree/step-1) | Create new console project; output Hello World.
2 | [step-2](https://github.com/justinsaraceno/PizzaStore/tree/step-2) | Add new class library containing interface.
3 | [step-3](https://github.com/justinsaraceno/PizzaStore/tree/step-3) | Referencing another project.
4 | [step-4](https://github.com/justinsaraceno/PizzaStore/tree/step-4) | Create concrete implementations of interface.
5 | [step-5](https://github.com/justinsaraceno/PizzaStore/tree/step-5) | Using dependency injection.
6 | [step-6](https://github.com/justinsaraceno/PizzaStore/tree/step-6) | Setting up a ServiceProvider.
7 | [step-7](https://github.com/justinsaraceno/PizzaStore/tree/step-7) | Using DI to create an instance of a class.
8 | [step-8](https://github.com/justinsaraceno/PizzaStore/tree/step-8) | Using DI to call a method defined via an interface.
9 | [step-9](https://github.com/justinsaraceno/PizzaStore/tree/step-9) | Showing the power of DI to swap out a concrete implementation.

###Lesson 2: .NET Core Configuration
Step | Branch Name | Concept Shown
--- | --- | ---
1 | [lesson2-step1](https://github.com/justinsaraceno/PizzaStore/tree/lesson2-step1) | Create an appsettings.json file.
2 | [lesson2-step2](https://github.com/justinsaraceno/PizzaStore/tree/lesson2-step2) | Reading the configuration values from appsettings.json.
3 | [lesson2-step3](https://github.com/justinsaraceno/PizzaStore/tree/lesson2-step3) | Using and reading configuration values from environment variables.
4 | [lesson2-step4](https://github.com/justinsaraceno/PizzaStore/tree/lesson2-step4) | Allowing config values to seamlessly live in either appsettings.json or environment variables.

###Lesson 3: Unit Testing in .NET Core
Step | Branch Name | Concept Shown
--- | --- | ---
1 | [unit-tests](https://github.com/justinsaraceno/PizzaStore/tree/unit-tests) | Adding a unit test project; using MSTest test framework; asserting test results with FluentAssertions.
