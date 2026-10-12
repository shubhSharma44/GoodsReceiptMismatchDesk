# Goods Receipt Mismatch Desk

A full-stack application for managing purchase orders, purchase order line items, and goods receipts, with a foundation for identifying discrepancies between ordered and received quantities.

## Tech Stack

### Backend
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI

### Frontend
- Angular 22
- TypeScript
- HTML and SCSS

## Features

- Create and retrieve purchase orders
- Add line items to purchase orders
- Record goods receipts against purchase order line items
- Validate purchase order and line item relationships
- Persist data using Entity Framework Core and SQL Server
- Configure entity relationships and database constraints
- Integrate the Angular frontend with the Web API

## Project Structure

```text
GoodsReceiptMismatchDesk/
├── GoodsReceiptMismatchDesk.API/
│   ├── Controllers/
│   ├── Data/
│   │   └── Configurations/
│   ├── DTOs/
│   ├── Entities/
│   ├── Migrations/
│   ├── Program.cs
│   └── appsettings.json
└── goods-receipt-mismatch-desk/
    └── src/
        └── app/
            └── services/
```

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET SDK compatible with the API target framework
- SQL Server LocalDB or another configured SQL Server instance
- Node.js and npm
- Angular CLI

### 1. Configure the Database

Update the `DefaultConnection` connection string in `GoodsReceiptMismatchDesk.API/appsettings.json` to match your SQL Server environment.

### 2. Apply Database Migrations

Open a terminal in the API project directory and run:

```bash
dotnet ef database update
```

If the EF Core CLI is not installed, install it first:

```bash
dotnet tool install --global dotnet-ef
```

### 3. Run the Backend

From the API project directory:

```bash
dotnet restore
dotnet run
```

Use the API URL printed in the terminal. In the current local setup, the Angular service is configured to use `https://localhost:7182/api`.

Swagger is available when the API runs in the Development environment.

### 4. Run the Frontend

Open a second terminal in the Angular project directory:

```bash
npm install
ng serve
```

Open `http://localhost:4200` in your browser.

## API Endpoints

| Method | Endpoint | Purpose |
|---|---|---|
| POST | `/api/PurchaseOrders` | Create a purchase order |
| GET | `/api/PurchaseOrders/{id}` | Retrieve a purchase order and its lines |
| POST | `/api/PurchaseOrderLines` | Add a line to a purchase order |
| POST | `/api/GoodsReceipts` | Record a goods receipt |

## Current Scope

The current implementation establishes the core purchase order and goods receipt workflow. Automated discrepancy detection, reporting, and additional validation can be expanded in subsequent iterations.

## Future Enhancements

- Detect over-receipts and under-receipts
- Display ordered versus received quantity comparisons
- Add a goods receipt history view
- Introduce dedicated response DTOs and improved API validation
- Add automated tests and reporting

## License

No license has been specified yet.
