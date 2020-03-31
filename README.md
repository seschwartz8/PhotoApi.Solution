# Photo API and Pinterest Clone MVC Website

#### C#/.NET Core API that allows access to photo URLs. Current version: 03.31.20

#### By Krista Rutz, Sarah "Sasa" Schwartz

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#user-stories)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

<details>
  <summary>WHAT WE WORKED ON 03.30.20</summary>

- **PhotoApi.Solution application**
- Scaffolding an API using .NET
- Adding CRUD functionality to our photo controller
- Using parameters in GET requests to filter results from the database
- Matching usernames from POSTs to PUT/DELETE requests
- Parsing database objects to match parameter queries (with #hashtags)
- Using Data Annotations, including a RegEx data expression
- Attempted to integrate many-to-many relationships, before realizing this is better suited to NoSQL databases
  </details>

<details>
  <summary>WHAT WE WORKED ON 03.31.20</summary>

- **PhotoApi.Solution application**
  - Reviewed weekend readings and finish this week's readings
  - Styled our app to act like pinterest and show real photos
  - Finished CRUD functionality with MVC
  - Built pagination into the api photosController
    </details>

<details>
  <summary>Still left to do...</summary>
  
  - (PinterestClone) Create MVC part of our app
    - Finish front end implementation of pagination, add page limit so it doesn't break when page is > contents of query, pass variables to apiHelper call to change page number and search for tags
    - Users/account login
    - Search based on tags/username?
  - Swagger documentation
  - (PhotoApi) Add token-based authentication
</details>

- PinterestClone format
  Navbar --
  - "PinterestClone": index home - show a landing page/splash page
    - no API call
  - "Home": photos index - shows all photos
    - API GET - getAll()
  - "You/yourname": photos index with parameter passed - API GET - getAll(userName = "my_name")

## Description

C#/.NET Core API that allows access to photo URLs. This API includes all CRUD functionality to create, view, update, and delete photos in the database.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the PhotoApi directory, within the PhotoApi.Solution directory
- \$dotnet restore
- Recreate my database structure with migration:
  - \$dotnet ef migrations add Initial
  - \$dotnet ef database update
- Call this API with your web application or test out the requests using Postman.

## User Stories

- As a user, I want to be able to GET all photos related to a specific tag.
- As a user, I want to be able to POST photos to a specific tag.
- As a user, I want to be able to see a list of all tags.
- As a user, I want to input date parameters and retrieve only photos posted during that timeframe.
- As a user, I want to be able to PUT and DELETE photos, but only if I posted them.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
