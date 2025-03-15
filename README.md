# E-commerce full stack Application

This is an Angular-based e-commerce application with NgRx state management and an ASP.NET Core backend.

## Features

- Product managment ( CRUD )  with NgRx state management

- Order management ( CRUD ) using NgRx state management

- API integration with ASP.NET Core backend
  
 - .NET Microservices


- Routing with Angular Router

## Technologies Used

- Frontend: Angular, NgRx, Bootstrap 

- Backend: ASP.NET Core, Entity Framework Core

- Database: SQL Server
## Installation

### Prerequisites

- Node.js & npm installed
- Angular CLI installed (`npm install -g @angular/cli`)
- .NET SDK installed

### Setup & Run

#### Backend:

1. Navigate to the backend folder:
    ```bash
    cd backend
    ```

2. Restore dependencies:
    ```bash
    dotnet restore
    ```

3. Run the API:
    ```bash
    dotnet run
    ```

#### Frontend:

1. Navigate to the frontend folder:
    ```bash
    cd frontend
    ```

2. Install dependencies:
    ```bash
    npm install
    ```

3. Run the application:
    ```bash
    ng serve
    ```



## API Endpoints

- `GET /api/product` - Fetch all products
-  `GET /api/product/{id}` - Fetch a products by Id
- `POST /api/product` - Add a new product
- `DELETE /api/product/{id}` - Delete a product
- `GET /api/order` - Fetch all orders
- `GET /api/order/{id}` - Fetch an order
- `POST /api/order` - create an order by Id
- `DELETE /api/order` - delete an order

## License

This project is open-source under the MIT License.


