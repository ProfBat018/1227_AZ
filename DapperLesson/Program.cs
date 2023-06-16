using Dapper;
using DapperLesson;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

// ODBC - Open Database Connectivity. Driver for SQL Server

// Connection String
var builder = new ConfigurationBuilder();

builder.AddJsonFile("appsettings.json");

IConfiguration configuration = builder.Build(); // Build the configuration

string connectionString = configuration.GetConnectionString("DefaultConnection");

using SqlConnection conn = new(connectionString);
conn.Open();

#region DapperSelectQuery
/*
Console.WriteLine("Enter a name: ");
var enteredName = Console.ReadLine(); // Rube

var command = "SELECT * FROM People where Name = @name"; // @name - SQL Parameter

var people = conn.Query<Person>(command, new { name = enteredName});

foreach (var person in people)
{
    Console.WriteLine(person);
}
*/
#endregion 

#region DapperInsertQuery
/*
Console.WriteLine("Enter a name: ");
var enteredName = Console.ReadLine(); // Elvin

Console.WriteLine("Enter an age: ");
int age = 0;
bool res = Int32.TryParse(Console.ReadLine(), out age); 

var command = "INSERT INTO People (Name, Age) VALUES (@name, @age)";

var affectedRows = conn.Execute(command, new { name = enteredName, age = age });

Console.WriteLine($"Affected Rows: {affectedRows}");
*/
#endregion

#region DapperUpdateQuery
/*
Console.WriteLine("Enter a name: ");
var enteredName = Console.ReadLine(); // Elvin

Console.WriteLine("Enter an age: ");
int age = 0;
bool res = Int32.TryParse(Console.ReadLine(), out age);

var command = "UPDATE People SET Age = @age WHERE Name = @name";

var affectedRows = conn.Execute(command, new { name = enteredName, age = age });

Console.WriteLine($"Affected Rows: {affectedRows}");
*/
#endregion

#region DapperJoins

// Basic SQL Join query
var command =  "Select * from Students " +
                    "INNER JOIN People on Students.PersonId = People.Id ";

var students = conn.Query<Student, Person, Student>(command, (student, person) =>
{
    student.Person = person;
    return student;
});

foreach (var student in students)
{
    Console.WriteLine(student);
}


#endregion