# Activity 2 - Code First

## Overview
This project is developed using C# and Windows Presentation Foundation (WPF), integrating Entity Framework for a database-first approach. It demonstrates the utilization of Entity Framework within a WPF application to interact with a database, showcasing CRUD operations (Create, Read, Update, Delete) on a sample database.

## DataBase Structure.
![image](https://github.com/0LE6/DAM2_M06_UF4_Activity_2_Code_First/assets/135649528/a55872e9-ec0f-4006-befa-5bfba73aee8f)

## Features
- **Entity Framework Database-First Approach:** Leverages Entity Framework to generate model classes based on an existing database schema.
- **CRUD Operations:** Implements Create, Read, Update, and Delete operations against the database through a user-friendly WPF interface.
- **Data Binding:** Utilizes data binding features in WPF to synchronize UI components with data sources for an interactive user experience.
- **MVVM Architecture:** Follows the Model-View-ViewModel (MVVM) architectural pattern to separate the UI from business logic, facilitating easier maintenance and testing.

## Getting Started
### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- MySQL (version supporting Entity Framework)

### Setup
1. Clone the repository to your local machine.
2. Open the solution file in Visual Studio.
3. Ensure all NuGet packages are restored and the project builds correctly.
4. Run the application to see it in action.

## Usage
Navigate through the application's UI to perform various database operations. The interface is intuitive, allowing for easy management of data entries through the implemented CRUD functionalities.

##TODO
Comprovar si ya existe un objeto antes de añadirlo
Ajustar nulleables por toda la tabla (imagen, html description .. en caso de las Product Lines)
Interficie del DAOManager

