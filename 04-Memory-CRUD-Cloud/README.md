In step two, we add middleware to the application that responds with "Hello World" to all HTTP requests. 
This illustrates how easy it is to go from a console app to a hello world microservice, as well as the use of basic middleware.

Go over the classes
<todo> make a diagram of different classes
<walkthrough files created>
dotnet restore
<pulling down dependencies>
dotnet build
dotnet run

Run on the cloud

Make sure that supported .net core version from project.json file matches the buildpack version.

cf push <app name>