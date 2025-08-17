## Project Overview
QA Assessment – Selenium (xUnit), Postman, and C# Problem-Solving
This repository contains my solutions to the three sections of the assessment.

- Section 1 – UI Automation with Selenium & xUnit (in Visual Studio)
- Section 2 – API Testing with Postman (PostmanAPITest.JSON included in the repo)
- Section 3 – C# Problem-Solving (Unique Characters) (in Visual Studio)
Note: Section 1 and 3 in one solution in VS.

## Repo Structure
```
src/
├─ TestProject/                        # Section 1: Selenium + xUnit tests (POM)
│  ├─ Pages/                           # Page Object classes
│  │  └─ LoginPage.cs                  
│  ├─ Tests/                           # xUnit test classes
│  │  └─ LoginTests.cs                 
│  ├─ Utilities/                       
│  │  └─ Driver.cs                     # WebDriver helper class
│  └─ TestProject.csproj
└─ UniqueCharactersCheckers/           # Section 3: C# function + unit tests
   ├─ Program.cs                        # Main algorithm program
   └─ UniqueCharactersCheckers.csproj

postman/
└─ Assessment.postman_collection.json  # Section 2: API tests

README.md
TestProject.sln                        # Single VS solution for Sections 1 & 3
```

Note: I completed Sections 1 and 3 in one Visual Studio solution (TestProject.sln). Section 2 was done in Postman; I’ve pushed the Postman collection JSON. (PostmanAPITest.json)

## Section 1 – UI Automation (Selenium + xUnit)
Scenario automated:
1. Open https://the-internet.herokuapp.com/login
2. Enter username tomsmith and password SuperSecretPassword!
3. Click Login
4. Assert success message: “You logged into a secure area!”
   
Tech choices: Page Object Model (POM), xUnit Test

ProjectType: xUnit project

IDE: VisualStudio, Solution: TestProject  

Packages installed:

- Selenium.WebDriver

- Selenium.WebDriver.ChromeDriver

- Selenium.Support

Folder: TestProject  

Files:

For POM setup, I created 3 main classes:
- LoginPage.cs → Represents the login page (locators + actions).
- LoginTests.cs → Test cases for the login scenario which calls LoginPage methods
- Driver.cs → Class that creates the Chrome browser instance.

Run in Visual Studio:
-	Open TestProject.sln in Visual Studio.
-	Go to Test > Test Explorer.
-	Build the solution.
-	In Test Explorer, click Run All Tests or right-click a TestProject to run it individually.
-	Results will appear in Test Explorer.

## Section 2 – API Testing (Postman)
Project Type: Postman Collection (JSON)

API Endpoint: https://jsonplaceholder.typicode.com/posts

Task: Validate a REST API by sending a POST request to create a new post.

Test Scenario:

1.	Send a POST request with JSON body containing title and body.
2.	Validate response using Postman test scripts:
  
   - Status code is 201 Created.
     
   - Response contains an id field.
  
   - title and body match the request payload.

Files:

Postman API Assessment.postman_collection.json 

– exported from Postman collection including.

Run in Postman:

1. Open Postman → Import → select the file

2. Select the Create Post request.

3. Provide JSON body.

4. Send request.

## Section 3 – C# Problem-Solving Task

Task: Implement function to check string Has Only Unique Characters.

Constraints: no additional data structures, optimised for performance.

time complexity: O(n logn)

IDE: Visual Studio, Solution: TestProject  

Project Type: Console Application

Folder: UniqueCharacterChecker

Run in Visual Studio:

•  Open the solution in Visual Studio.

•  Set the Console App as the startup project.

•  Run the program → it prints the results in the console: False, True, False



