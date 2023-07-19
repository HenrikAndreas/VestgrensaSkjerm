# VestgrensaSkjerm

A project for our housing collective to keep track of important messages to each other, schedules, events etc.

## _TODO_

- [Current] Setting up messages and rooms with relation to Residents


## _Backend_

### _VestgrensaSkjerm_

Swagger: https://localhost:7176/swagger/index.html

This project contains the startup script, configuration and the API endpoints. All other parts of the project are abstracted in Data, Common and Services projects..

Running on .NET 6.0

### _VestgrensaSkjerm.Data_

This projects exists to handle and seyup what we need in order to connect to our database

The DatabaseContext is set to singleton lifecycle.

To create the database locally:

- cd VestgrensaSkjerm.Data
- docker-compose build database && docker-compose up database

To Initially create a migration (Stay in root directory):

- dotnet ef migrations add InitialCreate --startup-project VestgrensaSkjerm --project VestgrensaSkjerm.Data --context VestgrensaDataContext

To create new migrations (cd into VestgrensaSkjerm) (project should not be running)

- dotnet ef database update --project VestgrensaSkjerm

To remove a migration (cd into VestgrensaSkjerm.Data)

- dotnet ef migrations remove

To list migrations (cd VestgrensaSkjerm.Data)

- dotnet ef migrations list

#### Starting new local database

We need dotnet ef

- dotnet tool install dotnet-ef
  Then update database
- dotnet ef database update --project VestgrensaSkjerm


Calculating Washingweek by giving the rooms type 1-4, and calulcating from there since its circular.

### _VestgrensaSkjerm.Common_

This projects contains functions and classes that are shared between projects, and to make the main project more minimal all helper / utility functions are placed here.

### _VestgrensaSkjerm.Services_

This project is a middleware for communicating with the database. When an API endpoint wishes to send a request to the database, the service is what actually communicates.

### _Nuget Packages_

- Microsoft EntityFrameworkCore v7.0.0
- Npgsql.EntityFrameworkcore.PostgreSQL v7.0.0-preview.6
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer

## _Database_

Currently only local solution.
Later -> Create prod database server to use instead of local docker container.

Connect via terminal in docker:
- psql -d vestgrensa -U henrik -h localhost


useful psql commands: \dt To view tables


## _Frontend_

Using Node version 16
