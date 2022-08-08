# factory engineer certification tracked

#### By _**Jacob Palaoro**_  

#### _this is an application made to show examples of many to many relationship._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)**

---

## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is an MVC application that was built using C#. The purpose of this application is to allow the user to view engineers and the machines they are cerified to work on. When the application runs, the user can add a engineer or machine. the user is able to add engineers to machines they are certified for and view by either looking at the specified machines details or engineers._

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url
<li>Open a shell program and navigate to your desktop.
<li>Clone the repository for this project using the "git clone" command and including the copied URL.
<li>While still in the shell program, navigate to the root directory of the newly created file named "Salon.Solution".
<li>From the root directory, navigate to the "Factory" directory.

<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "Factory" directory of the project*  
   <pre>Factory.Solution
   └── Factory
    └── appsetting.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=jacob_palaoro;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
 project.<br><br>
How to Import a Database:
<ol> 
  <li>Open your terminal 
  <li>Move to factory folder in the project
  <li>run dotnet ef migrations add Initial
  <li> dotnet ef database update
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>Factory.Solution
   └── <strong>Factory</strong></pre>

Run ```$ dotnet restore``` in the console.<br>
Run ```$ dotnet run``` in the console
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _No known issues_

## License

_[MIT License](license)_

Copyright (c) July 28th, 2022 Jacob Palaoro