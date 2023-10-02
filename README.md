# location-app

This application comprises two components that provides a UI for displaying a list of suburbs and finding the nearest on of those suburbs to a given set of coordinates.

1. React SPA - this is in the sub-directory ReactSPA and includes a basic nav bar, some routing and two pages.

2. ASP.NET Web API - this is a Visual Studio .NET application that provides an API endpoint for processing requests from the SPA. This can be built and run from Visual Studio 2022 and requires .NET 7.0 to be available.

## React SPA - React, TypeScript and Redux Toolkit
The SPA is built using React functional components with Typescript and uses Redux Toolkit to deliver global state management.The key advantage of using this approach is that components are self contained and do not require propr drilling. Components dispatch commands to the redux slice and subscribe to changes in the state properties they are interested in and update accordingly. Overall, this makes components self contained and independent. React Hooks are used to handle local state and lifecycle methods. 

### Configuration
The SPA is configured to interact with the back end Web Api endpoint using axios and this is set up in http-common.ts. 

## ASP.NET Web Api 
This is back end api uses a controller to handle requests and delegates processing logic to a number of services. Dependencies between different classes are handled using Dependency Injection to ensure loosely coupled code and improve testability. 

### Configuration
The Web Api uses launchSettings.json to define the endpint that it exposes and makes available to clients such as the ReactSPA

## Running the app
1. To run the app first issue the command 'npm install' from the root directory.
2. Build and start the ASP.NET Web Api.
3. issue the command 'npm run start' and open your browser at http://localhost:3000/

