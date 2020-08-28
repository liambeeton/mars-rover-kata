<h1 align="center">🚀 Mars Rover Kata</h1>



## ❓ Instructions 

A squad of robotic rovers are to be landed by NASA on a plateau on Mars.

This plateau, which is curiously rectangular, must be navigated by the rovers so that their onboard cameras can get a complete view of the surrounding terrain to send back to Earth.

Your task is to develop an API that moves the rovers around on the plateau.

In this API, the plateau is represented as a 10x10 grid, and a rover has state consisting of two parts:

* its position on the grid (represented by an X,Y coordinate pair)
* the compass direction it's facing (represented by a letter, one of N, S, E, W)

### Input

The input to the program is a string of one-character move commands:

- `L` and `R` rotate the direction the rover is facing
- `M` moves the rover one grid square forward in the direction it is currently facing

If a rover reaches the end of the plateau, it wraps around the end of the grid.

### Output

The program's output is the final position of the rover after all the move commands have been executed. The position is represented as a coordinate pair and a direction, joined by colons to form a string. For example: a rover whose position is `2:3:W` is at square (2,3), facing west.

## 🌍 Quick start

1.  **Run Program**

    Use the .NET Core CLI to run the application.

    ```shell
    dotnet run --project "./src/MarsRover.Kata.App/MarsRover.Kata.App.csproj"
    ```

2.  **Run Tests**

    Use the .NET Core CLI to run the tests for the application.

    ```shell
    dotnet run --project "./test/MarsRover.Kata.App.Tests/MarsRover.Kata.App.Tests.csproj"
    ```

## 🧐 What's inside?

A quick look at the top-level files and directories you'll see in the project.

    .
    ├── src
    ├── test
    ├── .editorconfig
    ├── .gitattributes
    ├── .gitignore
    ├── MarsRover.Kata.sln
    └── README.md

1. **`/src`**: This directory will contain all of the code related to what you will see on the front-end of your site (what you see in the browser) such as your site header or a page template. `src` is a convention for “source code”.

2. **`/test`**: This directory will contain all of the code related to what you will see on the front-end of your site (what you see in the browser) such as your site header or a page template. `src` is a convention for “source code”.

3. **`.editorconfig`**: This file helps maintain consistent coding styles for multiple developers working on the same project across various editors and IDEs.

4. **`.gitattributes`**: This file allows you to specify the files and paths attributes that should be used by git when performing git actions, such as git commit, etc.

5. **`.gitignore`**: This file tells git which files it should not track / not maintain a version history for.

6. **`MarsRover.Kata.sln`**: This file is used to load the information associated with the solution such as projects and any other required information.

7. **`README.md`**: A text file containing useful reference information about your project.