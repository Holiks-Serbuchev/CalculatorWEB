# How to work with
## How install project:
Before getting started, you need to download the project.
  With this command:
 ```
 git clone https://github.com/Holiks-Serbuchev/CalculatorWEB.git
 cd CalculatorWEB
 dotnet build
 dotnet run
 ```
 ## How to use:
When a new user first logs into the site. He sees the calculator interface itself:
* The calculator interface consists: 
  * From multiple input fields;
  * And also from several buttons.
   
   ![alt text](https://i.imgur.com/r2pxLKO_d.webp?maxwidth=760&fidelity=grand)
   
* The calculator has several functions:
    * Addition;
    * Subtraction;
    * Multiplication;
    * Division;
    * Equal;
    * Purification.
    
To start using the calculator, you just need to start entering the required number and also use the functions that were described above.

An example of using the calculator:

![hippo](https://i.imgur.com/cVhNzft.gif)

# Architecture
The project was developed using __ASP.NET MVC__ technology. Using languages such as __C#__ and __JavaScript__.
1) The <table> element has been selected to simplify markup. Which made it possible to quickly create a grid for the controls.
2) This project used __JavaScript__ to update data in real time. All __JavaScript__ code is stored in __js/site.js__ file.
4) The __AddValuesTB__ function allows you to enter numbers into the input field.
5) The __SelectChar__ function allows you to select (+, -, /, *).
6) The __ClearClick__ function allows you to clear input fields.
7) The __PointClick__ function allows you to add a sign for decimal fractions.
8) Also, in this project, __C#__ was used to calculate examples.
9) __C#__ code has been applied to __HomeController__. And in the __Clicked__ event, examples are calculated.
