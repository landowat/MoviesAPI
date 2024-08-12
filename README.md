<h1 align="center"> MoviesAPI </h1>

MoviesAPI is a RESTful API for managing movies and their details. It allows users to perform CRUD operations on movie data, including information such as title, director, genre, and release year.

Features
Create, read, update, and delete movie records.
Search for movies by title, genre, or director.
Pagination support for retrieving large sets of data.
Input validation to ensure data integrity.
Error handling with detailed responses.
Getting Started
Prerequisites
Before you begin, ensure you have met the following requirements:

.NET SDK installed.
An IDE or text editor such as Visual Studio or Visual Studio Code.
A database server (e.g., SQL Server or SQLite) to store the movie data.
Installation
Clone the repository:

bash
Copiar código
git clone https://github.com/landowat/MoviesAPI.git
Navigate to the project directory:

bash
Copiar código
cd MoviesAPI
Restore the dependencies:

bash
Copiar código
dotnet restore
Configure the database connection string in the appsettings.json file.

Apply the database migrations:

bash
Copiar código
dotnet ef database update
Run the application:

bash
Copiar código
dotnet run
Usage
After running the application, you can access the API at https://localhost:5001/api/movies (adjust the URL as per your configuration).

Endpoints
GET /api/movies - Retrieve all movies.
GET /api/movies/{id} - Retrieve a specific movie by ID.
POST /api/movies - Add a new movie.
PUT /api/movies/{id} - Update an existing movie by ID.
DELETE /api/movies/{id} - Delete a movie by ID.

Examples
Get All Movies
bash
Copiar código
curl -X GET https://localhost:5001/api/movies
Add a New Movie
bash
Copiar código
curl -X POST https://localhost:5001/api/movies -H "Content-Type: application/json" -d '{"title":"Inception","director":"Christopher Nolan","genre":"Science Fiction","releaseYear":2010}'
Testing
You can run the tests using the following command:

bash
Copiar código
dotnet test
Contributing
Contributions are welcome! Please fork this repository, create a feature branch, and submit a pull request for review.
