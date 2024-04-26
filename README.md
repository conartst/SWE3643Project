# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator

Our repository currently contains Calculator3 which holds our Calculator Logic. The WebsiteCal which is using ASP.NET Blazor Server.

## Table of Contents

-  [Introduction](#-KSU-SWE-3643-Software-Testing-and-Quality-Assurance-Semester-Project:-Web-Based-Calculator)
-  [Table of Contents](#Table-of-Contents)
-  [Team Members](#Team-Members)
-  [Architecture](#Architecture)
-  [Environment](#Environment)
-  [Executing the Web Application](#Executing-the-Web-Application)
-  [Executing Unit Tests](#Executing-Unit-Tests)
-  [Reviewing Unit Test Coverage](#Reviewing-Unit-Test-Coverage)
-  [Executing End-To-End Tests](#Executing-End-To-End-Tests)
-  [OPTIONAL EXTRA CREDIT: Static Analysis](#application-structure-requirements)
-  [Final Video Presentation](#Final-Video-Presentation)

# Team Members
Conner Abel  
Basile Sounantharak 

# Architecture
(Insert Image of our logic)

# Environment
This is a non-platform application and should work only in Windows 10.  

To prepare your environment to execute this application:
 1. [Install the latest Visual Studio for your system.](https://visualstudio.microsoft.com/downloads/)
 2. [Install ASP.NET Blazor Server](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install)  
 3. [Install .NET Core 3.1 ](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)

## Executing the Web Application

1. Open CMD (Command Prompt)

2. Type path to the project (Ex: 
cd C:\Users\yourname\Downloads\SWE3643Project-main\SWE3643Project-main\WebsiteCal\WebsiteCal)  

3. Build project with dotnet run.

4. After the application starts, launch a browser and connect to localhost provided (Ex localhost:5001)

Sample Output

>Starting IIS Express ...
Successfully registered URL "http://localhost:24477/" for site "WebsiteCal" application "/"
Successfully registered URL "https://localhost:44335/" for site "WebsiteCal" application "/"
Registration completed for site "WebsiteCal"
IIS Express is running.
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\basil\source\repos\WebsiteCal\WebsiteCal

## Executing Unit Tests

1. Open CMD (Command Prompt)

2. Type path to the project (Ex: 
cd C:\Users\yourname>cd C:\Users\yourname\source\repos\Calculator)  

3. Run project with dotnet test.



Sample Output
>Starting test execution, please wait...
A total of 1 test files matched the specified pattern.  

>Passed!  - Failed:     0, Passed:    19, Skipped:     0, Total:    19, Duration: 10 ms - Calculator.dll (net6.0)

## Reviewing Unit Test Coverage

<img src="CalculatorCoverage.png" alt="CalculatorCoverage.png" style="zoom: 50%;" />

## Executing End-To-End Tests
1. steps

Sample Output
>lmao

## Final Video Presentation
(Video Link Here)
Either link to youtube or vimeo  
or place into our repository


