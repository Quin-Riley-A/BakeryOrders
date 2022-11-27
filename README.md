# Pierre's Bakery

#### Place your order for Pierre's Delicious Breads and Pastries

## Authored by: 
Quin Asselin, November 2022

***

## Table of Contents
1. [Repository Description](#repository-description)
2. [Technologies Used](#technologies-used)
3. [Setup Instructions](#setup-installation-requirements)
4. [Known Bugs](#known-bugs)
5. [License Information](#license)

*** 

## Repository Description:
This project written and compiled in C-Sharp will initially welcome the user to an instance of Pierre's Bakery in the terminal. From there, the user will be prompted to select their desired quantity of the two goods Pierre has on offer. Afterwards, the terminal will display the price of the breads, the price of the pastries, and a total price for all items including any relevant discounts mentioned in the welcome message.

This project was hand-built in tandem with a programming class taught by Epicodus. It contains use of C-Sharp, .NET, and Markdown. This project also uses Text To ASCII Art Generator linked below along with licensing information.
***

## Technologies Used

- C#
- .NET
- Git
- Github
- Markdown
- Text To ASCII Art Generator (TAAG)

***

## Setup Installation Requirements

1. Download this repository from its Github Repository located [here.](https://github.com/Quin-Riley-A/BakeryOrders)
2. Open the folder titled "BakeryOrders.Solutions"
3. Unzip the downloaded folder if necessary.
4. Verify this directory contains all of the following:
  - BakeryOrders folder:
    -  Models folder:
      - Bread.cs
      - Pastry.cs
    - BakeryOrders.csproj
    - Program.cs
  - BakeryOrders.Tests folder:
    - ModelTests
      -BreadTests.cs
      PastryTests.cs
    - BakeryOrders.Tests.csproj
  - .gitignore
  - LICENSE
  - README.md
5. In the terminal navigate to within the "BakeryOrders.Tests" folder.
6. Run the following command in bash or an equivalent from within this directory:
```bash
dotnet restore
```
You should receive a message stating 
```bash
"All projects are up-to-date for restore"
```
7. Within the bash terminal afterwards navigate from the "BakeryOrders.Tests" folder to the "BakeryOrders" folder
8. Run the following command: 
```bash
dotnet build
```
9. After the sucessful completion of the previous command, the following command will start an instance of the program
```bash
dotnet run
```

## Known Bugs

* This program may experience issues of formatting to the welcome message when opening in the terminal. If the terminal is not of sufficient width, the initial message will not print properly.
  * If the welcome message appears poorly formatted try increasing the width of the terminal until each line can fully print within th confines of the terminal window.
* Some care has gone into ensuring that the user input is verified to be of the correct format before allowing the continuation of the program. As such, if any novel errors are found while making entries to the order form, please record the input that produced the error.
* If you experience any of these issues, please message the producer of your current repository and include any relevant form/page information. Thank you for your patience as I work on any issues!


## License
*Quin Asselin, 2022. Available for distribution, modification, inspection, and application under [GPLv3 License](https://www.gnu.org/licenses/gpl-3.0.en.html)*

This application makes use of the DOOM font by Frans P. de Vries (18 June, 1996) which can be found [here](https://patorjk.com/software/taag/#p=display&f=Doom), along with more information regarding sourcing and licensing. 