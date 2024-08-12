## MoviesAPI 

<h3>🎥🎬🎞️</h3>

Creating an API using C#, .NET, Entity Framework, and LINQ

MoviesAPI is a RESTful API for managing movies and their details. It allows users to perform CRUD in the following data:
+ Movie
+ Cinema
+ Address
+ Session

Features
Create, read, update, and delete records.
Pagination support for retrieving large sets of data.
Input validation to ensure data integrity.
Error handling with detailed responses.

## Prerequisites
Before you begin, ensure you have met the following requirements:

+ .NET SDK installed.
+ An IDE or text editor such as Visual Studio or Visual Studio Code.
+ A database server (e.g., SQL Server or SQLite) to store the movie data.

## Installation
1. Clone the repository:

   **git clone https://github.com/landowat/MoviesAPI.git**

2. Navigate to the project directory:

    **cd MoviesAPI**

3. Restore the dependencies:

    **dotnet restore**

4. Apply the database migrations:

    **dotnet ef database update**

5. Run the application:

    **dotnet run**

## Endpoints
### Movies
+ GET **/api/movies** - Retrieve all movies.
+ GET **/api/movies/{id}** - Retrieve a specific movie by ID.
+ POST **/api/movies** - Add a new movie.
+ PUT **/api/movies/{id}** - Update an existing movie by ID.
+ DELETE **/api/movies/{id}** - Delete a movie by ID.

### Cinemas
+ GET **/api/cinema** - Retrieve all cinemas.
+ GET **/api/cinema/{id}** - Retrieve a specific cinema by ID.
+ POST **/api/cinema** - Add a new cinema.
+ PUT **/api/cinema/{id}** - Update an existing cinema by ID.
+ DELETE **/api/cinema/{id}** - Delete a cinema by ID.

### Addresses
+ GET **/api/address** - Retrieve all addresses.
+ GET **/api/address/{id}** - Retrieve a specific address by ID.
+ POST **/api/address** - Add a new address.
+ PUT **/api/address/{id}** - Update an existing address by ID.
+ DELETE **/api/address/{id}** - Delete a address by ID.

### Sessions
+ GET **/api/session** - Retrieve all sessions.
+ GET **/api/session/{id}** - Retrieve a specific session by ID.
+ POST **/api/session** - Add a new session.
+ PUT **/api/session/{id}** - Update an existing session by ID.
+ DELETE **/api/session/{id}** - Delete a session by ID.

## Examples
### Get All Movies
**curl -X GET https://localhost:5001/api/movies**

### Add a New Movie
**curl -X POST https://localhost:5001/api/movies -H "Content-Type: application/json" -d '{"title":"Rush Hour","genre":"Action","duration": 160}'**

## Testing
You can run the tests using the following command:
dotnet test

## Contributing
Contributions are welcome! Please fork this repository, create a feature branch, and submit a pull request for review.
