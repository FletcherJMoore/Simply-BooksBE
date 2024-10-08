# Simply-BooksBE

<h3>Simply Books is a storefront for users to buy and sell their books</h3>
<h4> Features Include:</h4>
<ul>Viewing All Books</ul>
<ul>View a Books details by the booksId</ul>
<ul>Posting a new book</ul>
<ul>Updating a new book</ul>
<ul>And Deleting a new book</ul>
<ul>Viewing All Authors</ul>
<ul>View a Author details by the authorsId</ul>
<ul>Posting a new author</ul>
<ul>Updating a new author</ul>
<ul>And Deleting a new author</ul>

<h4>Feel free to test these API's via Postman:</h4>
<link>https://rare-be.postman.co/workspace/My-Workspace~67c6f02b-dbf3-4703-8081-e64d64fbf53d/collection/32292165-41fa1188-a504-485b-8531-4e1e41d86817</link>

<h4>Here is a video walkthrough of these API's being tested via Swagger</h4>
<link>https://www.loom.com/share/e46cd9d3744c4e16bfc83af5d283d6f9?sid=2d1ec211-b0a8-4819-9efb-dd4798a784a1</link>

# Simply Books Server Side

Simply Books is a store front book store for users to purchase their favorite books as well as post new books on the page! 

## Table of Contents

- [About the Project](#about-the-project)
- [Built With](#built-with)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## About the Project

With the rise of online shopping book stores are shutting down left and right and it's only a matter of time before physical copies of books won't be sold anymore. That's what Simply Books plans on preventing. Simply Books will be the online book store for avid readers so even if you don't have a book store nearby they can still purchase a physical copy of their favorite books! 

## Built With

List of the major technologies, frameworks, or libraries used in the project. For example:
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

#### API Calls included in the project!
  
#### `GET /books`
- Description: Get all books
- Example Request:
    ```bash
    curl --location --request GET 'https://localhost:7055/books'
    ```
- Example Response:
    ```json
    [
      {
        "id": 0,
    "title": "string",
    "image": "string",
    "price": 0.00,
    "sale": false,
    "author_Id": 0,
    "uid": "string",
    "description": "string"
      }
    ]
    ```

#### `POST /api/books`
- Description: Create a new book
- Example Request:
    ```bash
    curl --location --request POST 'https://localhost:7055/books' \
    --header 'Content-Type: application/json' \
    --data-raw '{
    "id": 0,
    "title": "string",
    "image": "string",
    "price": 0.00,
    "sale": false,
    "author_Id": 0,
    "uid": "string",
    "description": "string"
    },'
    ```
#### `PATCH /books/{bookId}`
- Description: Update a book
- Example Request:
      ```bash
      curl --location --request PATCH 'https://localhost:7055/books/{bookId}' \
    --header 'Content-Type: application/json' \
    --data-raw '{
    "id": 0,
    "title": "string",
    "image": "string",
    "price": 0.00,
    "sale": false,
    "author_Id": 0,
    "uid": "string",
    "description": "string"
    },'

(Include the rest of the CRUD operations for books and authors)
