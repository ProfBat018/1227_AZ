# Lesson. Dapper

# What we gonna learn
* What's Dapper
* ORM basics
* How to use Dapper

ADO.NET-in mənfi cəhətləri:
* Çox kod yazmaq lazımdır
* SQL-in sintaksisini yadda saxlamaq lazımdır
* İdarə etmək çətindir

ADO.NET-in müsbət cəhətləri: 
* Sürətli

EF-in mənfi cəhətləri:
* Lib-lər çoxdur
* Sürətli deyil

EF-in müsbət cəhətləri:
* SQL-in sintaksisini yadda saxlamaq lazım deyil
* İdarə etmək asandır
* Çox kod yazmaq lazım deyil
* Yeniliklərə açıqdır


Dapper - fiziki olaraq `EF` və `ADO`-nun orta məxrəcidir.

Dapper-in mənfi cəhətləri:
* SQL-in sintaksisini yadda saxlamaq lazımdır
* İnner join-lər bir azca çətindir, amma öyrənilə bilər


Dapper-in müsbət cəhətləri:
* Tezdir
* Ef-core kimi rahat ORM-dir


## Dapper-də select: 
```csharp
var sql = "SELECT * FROM Customers WHERE CustomerId = @Id";

using var connection = new SqlConnection(_connectionString)ı
    var customer = connection.QueryFirstOrDefault<Customer>(sql, new { Id = id });
    return customer;
```

## Dapper-də insert:
```csharp
var sql = "INSERT INTO Customers (CustomerId, FirstName, LastName, Email) VALUES (@CustomerId, @FirstName, @LastName, @Email)";

using var connection = new SqlConnection(_connectionString);
    connection.Execute(sql, customer);
```

## Dapper-də create table:
```csharp
var sql = "CREATE TABLE Customers (CustomerId int, FirstName nvarchar(50), LastName nvarchar(50), Email nvarchar(50))";

using var connection = new SqlConnection(_connectionString);
    connection.Execute(sql);
```



