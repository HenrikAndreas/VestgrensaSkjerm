# VestgrensaSkjerm


## _Backend_

### _VestgrensaSkjerm_
This project contains the startup script, configuration and the API endpoints. All other parts of the project are abstracted in Data, Common and Services projects.

### _VestgrensaSkjerm.Data_
This projects exists to handle and seyup what we need in order to connect to our database

To create the database locally:
- cd VestgrensaSkjerm.Data
- docker-compose build database && docker-compose up database

To Initially create a migration (Stay in root directory):
- dotnet ef migrations add InitialCreate --startup-project VestgrensaSkjerm --project VestgrensaSkjerm.Data --context VestgrensaDataContext

To create new migrations (cd into VestgrensaSkjerm.Data)
- dotnet ef database update --project VestgrensaSkjerm.Data

To remove a migration (cd into VestgrensaSkjerm.Data)
- dotnet ef migrations remove

To list migrations (cd VestgrensaSkjerm.Data)
- dotnet ef migrations list


### _VestgrensaSkjerm.Common_
This projects contains functions and classes that are shared between projects, and to make the main project more minimal all helper / utility functions are placed here.

### _VestgrensaSkjerm.Services_

### _Nuget Packages_
- Microsoft EntityFrameworkCore v7.0.0
- Npgsql.EntityFrameworkcore.PostgreSQL v7.0.0-preview.6
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer

## _Database_
Currently only local solution.
Later -> Create prod database server to use instead of local docker container.

## _Frontend_