# # MinimalApiPostgreSQLEF

.Net minimal API using PostgreSQL, Entity Framework, and Swagger

## Getting Started

This is an example code following the tutorial by The Coder Cave esp Youtube Channel (https://www.youtube.com/watch?v=L7qYEqnMYBs&ab_channel=TheCoderCaveesp)

## Instructions

### To install entity framework
```
dotnet tool install --global dotnet-ef
```

### To create a migration
```
dotnet ef migrations add firstmigration --project MinimalApiPostgreSQLEF.csproj
```

### To run a migration
```
dotnet ef database update firstmigration --project MinimalApiPostgreSQLEF.csproj
```

### Start the web service    
```
dotnet run
```

### Entry point URL for swagger
```
http://localhost:PORT/swagger/index.html
```

