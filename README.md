# AirDBnB Database Management App

My project is an **end-to-end** Windows Forms application for managing an AirBnB-style rental system. It covers everything from database schema definition and stored-procedure creation, to data-access layer implementation, WinForms UI design, CRUD wiring, and manual testing.

## Overview

I built a C# .NET WinForms desktop app that performs **CRUD** operations on four entities—Users, Hosts, Properties, and Bookings—backed by SQL Server. All database interactions use ADO.NET (`SqlDataAdapter`, `SqlCommandBuilder`) with stored procedures for consistency and security.

## Database Design and Schema

- **User**  
  - `userName` (PK), `fullName`, `userPhoneNumber`  
- **Host**  
  - `hostID` (PK), `hostName`, `hostPhoneNumber`  
- **Property**  
  - `propertyAddress` (PK), `propertyPrice`, `propertyType`, `propertyCountry`, `hostID` (FK)  
- **Booking**  
  - `userName` (FK), `propertyAddress` (FK), `bookingStartDate`, `bookingEndDate`, `propertyRating`  

**Stored Procedures** for each table:  
`sp_Read<Entity>`, `sp_Create<Entity>`, `sp_Update<Entity>`, `sp_Delete<Entity>`

## Data Access Layer

1. **Connection Setup** (`DataAccessLayer.cs`)  
   - Configures `SqlConnectionStringBuilder` for `DevelopmentAirBnDB`.  
2. **CRUD Methods**  
   - `ReadUsers()`, `AddUser(...)`, `UpdateUser(...)`, `DeleteUser(...)`  
   - Equivalent methods for Host, Property, Booking.  
3. **AdapterManager** (`AdapterManager.cs`)  
   - Provides `SqlDataAdapter` instances per entity.  
   - Maps `SelectCommand` to `sp_Read<Entity>` and parameterized `Insert`/`Update`/`Delete` commands to the corresponding SPs.

## UI Implementation

1. **Tabs & Controls** (`Form1.Designer.cs`)  
   - `TabControl` with tabs: **User**, **Host**, **Property**, **Booking**  
   - Each tab contains:  
     - `DataGridView` to display records  
     - Input controls: `TextBox`, `ComboBox`, `DateTimePicker`, `TrackBar`  
     - **Add**, **Update**, **Delete** buttons  
2. **Event Wiring** (`Form1.cs`)  
   - **PopulateDataGridViews()** on startup to bind datasets  
   - **PopulateComboBoxes()** for host and property lookups  
   - Button handlers: collect form inputs, invoke DAL methods, refresh UI  
   - Helper methods: `GenerateHostID()`, `SplitComboBoxValue()`, `CheckIfFieldsAreEmpty()`

## Testing and Validation

- Verified stored procedures in SQL Server Management Studio.  
- Manual app tests:  
  - Create, update, delete records on each tab  
  - Validate empty-field checks and numeric conversions  

## How to Run the Project

### Prerequisites

- Windows 10 or later  
- .NET Framework 4.x (or .NET 5+ with WinForms)  
- SQL Server instance  
- Visual Studio 2019 or later  

### Steps

1. **Clone Repository**  
   ```bash
   git clone https://github.com/SergioFernizaMarquez/AirBnDB.git

2. **Database Setup**
- Create a database named DevelopmentAirBnDB.
- Execute SQL scripts: create_tables.sql, create_stored_procedures.sql.

3. **Configure Connection**
- Update the connection string in DataAccessLayer.cs or move it to App.config.

4. **Build & Run**
- Open AirBnDBProject.sln in Visual Studio.
- Press F5 to start or run the compiled .exe.

5. **Use the Application**
- Navigate tabs to manage Users, Hosts, Properties, and Bookings.

### Conclusion

This project demonstrates a complete desktop CRUD solution. From schema design and stored procedure usage to data access abstraction and WinForms UI integration. It uses the best practices in separation of concerns, ensures robust data handling with ADO.NET, and uses an intuitive user interfaces.
