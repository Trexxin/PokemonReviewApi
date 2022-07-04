# PokemonReviewApi
An api for reviewing pokemons and their owners using Asp.net, Entity Framwork, and Swagger. The api grants the ability to get, put, update, and delete entities with a script to seed a starter database.


# USAGE

The usage of the api is described below with the placeholders from the seed script for context.
To note: All requests apply to all entities in the api so the format for `Get /Category/` would be the same if you wanted to `Get /Country/`.

## Get list of Categories

### Request

`GET /Category/`

    curl -X 'GET' \ 'https://localhost:7142/api/Category' \ -H 'accept: text/plain'

### Response

[
  {
    "id": 1,
    "name": "Electric"
  },
  {
    "id": 2,
    "name": "Water"
  },
  {
    "id": 3,
    "name": "Leaf"
  },
]


## Create a new Category

### Request

`POST /Category/`

    curl -X 'POST' \ 'https://localhost:7142/api/Category' \ -H 'accept: */*' \ -H 'Content-Type: application/json' \ -d '{ "name": "SomeCategoryName" }'

### Response

If code 204 (Successful Request):
Sucessfully Created

## Get a specific Category with id

### Request

`GET /Category/{categoryId}`

    curl -X 'GET' \ 'https://localhost:7142/api/Category/1' \ -H 'accept: text/plain'

### Response

{
  "id": 1,
  "name": "Electric"
}


## Update a Category

### Request

`PUT /Category/{categoryId}`

    curl -X 'PUT' \ 'https://localhost:7142/api/Category/1' \ -H 'accept: */*' \ -H 'Content-Type: application/json' \ -d '{ "id": 1, "name": "Lightning" }'

### Response

 date: Mon,04 Jul 2022 18:33:37 GMT 
 server: Kestrel


## Delete a Category

### Request

`DELETE /Category/{categoryId}`

    curl -X 'DELETE' \ 'https://localhost:7142/api/Category/1002' \ -H 'accept: */*'

### Response

date: Mon,04 Jul 2022 18:39:48 GMT 
 server: Kestrel 


## Getting the contents of a Category

### Request

`GET /Category/pokemon/{categoryId}`

    curl -X 'GET' \ 'https://localhost:7142/api/Category/pokemon/1' \ -H 'accept: text/plain'
    
### Response

[
  {
    "id": 1,
    "name": "Pikachu",
    "birthDate": "1903-01-01T00:00:00"
  },
  {
    "id": 1002,
    "name": "string",
    "birthDate": "2022-07-01T14:04:04.921"
  },
  {
    "id": 1003,
    "name": "Evevee",
    "birthDate": "2022-07-01T15:39:48.712"
  }
]

