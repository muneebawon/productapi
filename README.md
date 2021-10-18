## Read Me

The solution consitons of two parts, ASP.NET Core Web API and Angular App


## Installing the ASP.NET Core Web API (.NET Core 3.1)

Open ProductApi solution file in Visual Studio 2019 and build the project

Deploy ProductApi in IIS, e.g. create a new website (ProductApi) in IIS and optionally bind ports 8000 for http and 8001 for https.


## Installing the Angualr App (Angular 12)

Open product-app in Visual Studio Core

Optionally update the apiUrl value in environment.json, to point to the ProjectApi

Open node.js console and navigate to ..\ProductApi\ProductWeb\product-app folder

Install packages using following command

  npm install

If issue occurs, please restrict to package lock only

  npm install --package-lock-only

Build the solution
  ng build

Run the solution
  ng serve --open
  
You sould be able to see a new page showing list of products.
