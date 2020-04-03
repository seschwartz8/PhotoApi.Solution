# Photo API and Pinterest Clone MVC Website

#### C#/.NET Core API that allows access to photo URLs. Current version: 04.03.20

#### By Sarah "Sasa" Schwartz and Krista Rutz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [API Documentation](#api-documentation)
4. [Specifications](#user-stories)
5. [Known Bugs](#known-bugs)
6. [Technologies Used](#technologies-used)
7. [License](#license)

---

## Description

C#/.NET Core API that allows access to photo URLs and MVC application that mimics pinterest. The API includes all CRUD functionality to create, view, update, and delete photos in the database. The MVC utilizes this API to display photos and also provides user authentication and authorization.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"

- Change directory to the PhotoApi directory, within the PhotoApi.Solution directory

  - \$dotnet restore
  - Recreate our database structure with migration:
    - \$dotnet ef migrations add Initial
    - \$dotnet ef database update
  - \$dotnet watch run (starts the API server at localhost:5000)

- Change directory to the PinterestClone directory, within the PhotoApi.Solution directory
  - \$dotnet restore
  - Recreate our database structure with migration:
    - \$dotnet ef migrations add Initial
    - \$dotnet ef database update
  - \$dotnet watch run (starts the application server at localhost:5006)
  - Open this in your browser to use the app!

## API Documentation

- Base url: http://localhost:5000

#### Routes

| Action                      | Method | Endpoint          |
| :-------------------------- | :----- | :---------------- |
| List all photos (paginated) | GET    | /api/photos       |
| Retrieve specific photo     | GET    | /api/photos/{id}  |
| Create photo                | POST   | /api/photos       |
| Edit photo                  | PUT    | /api/photos/{id}  |
| Delete photo                | DELETE | /api/photos/{id}  |
| Count all photos            | DELETE | /api/photos/count |

#### Search Parameters

| Parameter | Type   | Example                | Response                                              |
| :-------- | :----- | :--------------------- | :---------------------------------------------------- |
| Title     | String | /?title=spring+break   | Photos with title "spring break"                      |
| Tag       | String | /?tag=cool             | Photos with hashtag "cool"                            |
| Url       | String | /?url=www.hello.com    | Photos with url of "www.hello.com"                    |
| Username  | String | /?username=coolgirl101 | Photos posted by user coolgirl101                     |
| Page      | Int    | /?page=2               | Page 2 of paginated photo results (default is page 1) |
| Size      | Int    | /?size=25              | 25 photos per page (default is 20 and max is 100)     |

#### Pagination

- This API returns paginated results, with a default page size of 20 results per page and a max page size of 100 results per page.
- The default page number is set to 1.
- See the [search parameters](#search-parameters) above for information on how to adjust page size and number.

#### Example Query

- Example query: http://localhost:5000/api/photos/?title=spring+break&tag=cool&page=3&size=5

  - This query returns photos with the title "spring break" and containing the hashtag "cool". It starts at page 3 with 5 results per page.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
