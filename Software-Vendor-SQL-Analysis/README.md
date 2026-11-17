# Software & Vendor Database — SQL Query Analysis

SQL · Microsoft Access · Relational Databases · CIS 311

For this database assignment, I wrote SQL queries to work with information about software products, their categories, and the vendors selling them. I used subqueries to find categories and vendors without matching records, compared software prices to the overall average, and identified the highest-priced offering. I also joined multiple tables to bring together software, vendor, and category details. This project helped me practice using SQL to answer specific questions from a relational database.

## Database structure

| Table | Records | What it contains |
| --- | ---: | --- |
| `Category` | 5 | Software categories |
| `Software` | 13 | Software products and their categories |
| `Vendor` | 6 | Software vendors |
| `Software_Vendor` | 18 | Vendor–software listings and prices |

## SQL queries

These are the five SQL statements recovered from the saved query definitions in my Microsoft Access coursework database.

### 1. Find categories without software

Uses a `NOT IN` subquery to find categories that have no software assigned to them.

```sql
SELECT CategoryID, CategoryName
FROM Category
WHERE CategoryID NOT IN (SELECT CategoryID FROM Software);
```

### 2. Find vendors that do not sell any software

Checks the vendor table against the software–vendor table to find vendors with no listings.

```sql
SELECT VendorID, VendorName
FROM Vendor
WHERE VendorID NOT IN (SELECT VendorID 
                                          FROM Software_Vendor);
```

### 3. Find software listings priced below the average

Combines three tables, calculates the average listing price with a subquery, and sorts matching results from highest to lowest price.

```sql
SELECT Software.SoftwareID, SoftwareName, Vendor.VendorID, VendorName, Price
FROM Software_Vendor, Software, Vendor
WHERE Software_Vendor.SoftwareID = Software.SoftwareID AND Software_Vendor.VendorID =Vendor.VendorID 
AND Price < (SELECT AVG(Price) FROM Software_Vendor)
ORDER BY Price DESC;
```

### 4. Find the most expensive software listing

Combines four tables to show the software, its category, the vendor, and the highest price in the database.

```sql
SELECT Software.SoftwareID, SoftwareName, Category.CategoryID, CategoryName, Vendor.VendorID, VendorName, Price
FROM Software, Software_Vendor, Vendor, Category
WHERE Software.SoftwareID = Software_Vendor.SoftwareID
AND Software_Vendor.VendorID = Vendor.VendorID
AND Software.CategoryID = Category.CategoryID
AND Price = (SELECT MAX(Price) FROM Software_Vendor);
```

### 5. Find listings for software names containing "wri"

Uses `LIKE` and an `IN` subquery to identify vendor listings for matching software names.

```sql
SELECT SoftwareID, VendorID, Price
FROM Software_Vendor
WHERE SoftwareID IN (
SELECT SoftwareID
FROM Software
WHERE SoftwareName LIKE '%wri%');
```

## About the SQL

The queries were recovered from saved definitions in the original `Homework 10-1.accdb` Microsoft Access database. The extraction document reports that they were run against the original data. The SQL is displayed here so it can be reviewed directly on GitHub without Microsoft Access.

*Note: The `%` wildcard in Query 5 is used in ANSI-92 SQL mode; default Access ANSI-89 mode uses `*`.*

---

[Back to Data Science portfolio](../)
