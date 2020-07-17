#  _Pierre's Bakery_

#### _Console application where the user can select different amounts of bread & pastries, the program will return the net cost of the order_
##### __Created:__ 7/17/2020
##### __Last Updated:__ 7/17/2020 
##### By _**Tyson Lackey**_  


## Description

> Welcome to Pierre's Bakery! In your console, you will be able to place an order for a number of bread loaves and/or pastries. The program will apply discounts for bulk purchases based on the behaviors listed below and return the subtotals for bread and pastry costs along with the total order cost.

## Behaviors

| Spec| Example input | Example Output
| ----------- | ----------- | ----------- |
| non-integer inputs for bread will return an error | "one" | "Please enter a whole number for your bread order" |
| non-integer inputs for pastry will return an error | "two" | "Please enter a whole number for your pastry order" |
| White bread costs 5 | "white" | 5 |
| Sourdough bread costs 8 | "sourdough" | 8 |
| Baguettes costs 3 | "baguette" | 3 |
| Italian bread costs 7 | "italian" | 7 |
| Every 3rd bread costs 0 | "3" | "10" |
| Every 21st bread, total bread cost reduced by 2 x bread cost | "white" "21" | "60" |
| Each pastry costs 2 | "2" | "4" |
| Every 3rd pastry costs 1 | "3" | "5" |
| Every 12th pastry, total pastry cost reduced by 2 | "12" | "18" |
| total cost is equal to cost of bread + cost of pastries | input | output |


## Setup/Installation Requirements

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open by downloading:
1. Internet Browser
2. Code editor like VScode to view the codebase

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open by downloading:

1. Download this repository onto your computer
2. Double click index.html to open it in your web browser

##### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone https://github.com/Lackeyt/PierresBakery.Solution"
2. Navigate into the "PierresBakery.Solution" directory in Visual Studio Code or preferred text editor:
3. Open the project
    "code ."
4. Open your computer's terminal and navigate to the directory PierresBakery within the PierresBakery.Solution folder.
5. Enter the command "dotnet build" in the terminal and press "Enter".
6. Enter the command "dotnet run" in the terminal and press "Enter".

## Known Bugs

* n/a

## Support and contact details

* Discord: TysonL#4409
* Email: lackeyt90@gmail.com


## Technologies Used

* Visual Studio Code
* C#
* .NET core

### License

Copyright (c) 2020 **_Tyson Lackey_**

This software is licensed under the MIT license.