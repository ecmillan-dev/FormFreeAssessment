# FormFreeAssessment
A collection of solutions to the assessments for FormFree

## Assessment 1

Write a C# application that solves the following problem:

* Take in three integer inputs, representing the sides of a triangle, and return
the triangle type (Scalene, Isosceles, Equilateral).

* Support your application with unit tests.

### Assessment 1 answer
The code is found in the TriangleCalculator.Console project and the TriangleCalculator.UnitTest project contains all of the unit tests

## Assessment 2

Write a C# application that solves the following problem:

* Return the fifth element __from the end__ of a singly linked list of integers.
Do not iterate the list more than once. Assume the list size cannot be known
without traversing the list.

***Note: You must __only__ use your `LinkedList` data structure to solve this problem.
You are not allowed to use any language provided data structures, like `List` or `Dictionary`.***

* Support your application with unit tests.

* Solve the same problem above, but assume the linked list contains strings
instead of integers.

### Assessment 2 answer
The code is found in the LinkedList.Console project and the LinkedList.UnitTest project contains all of the unit tests. The `LinkedList` class utilizes the `TSource` interface to allow it to handle generic data types, which fulfills the requirement of supporting both string and integer lists.

## Assessment 3

Write a C# application that solves the following problem:

* Take, as input, the path to a file containing one integer per line. For each
integer in the file, output to the console a comma-delimited list of the
integer's prime factors. The list of integers on each line of the output should
multiply to produce the integer.

* Support your application with unit tests.

### Assessment 3 answer
The code is found in the PrimeFactor.Console project and the PrimeFactor.UnitTest project contains all of the unit tests. Sample files are included in the project

## Assessment 4

Given a database with the following structure:

```
+------------------------------------------------------------------------------+
| Customers                                                                    |
+------------------------------------------------------------------------------+
| id         | name       | address       | phone_number        | email        |
+------------------------------------------------------------------------------+
```
```
+------------------------------------------------------------------------------+
| Orders                                                                       |
+------------------------------------------------------------------------------+
| id           | customer_id       | order_amount       | order_address        |
+------------------------------------------------------------------------------+
```

Perform the following:

1. Write a SQL query to pull all customers.
2. Write a SQL query to pull all customers that have orders (no duplicates).
3. Write a SQL query to pull all customers that do not have orders.
4. If you had to create an index on these tables, which fields would you most
likely index, and why?
5. Write a query that lists each customer name, email, and the number of orders
they have.
6. Write a query that pulls all customers that have between 2 and 5 orders.

### Assessment 4 answers
The queries for problems 1, 2, 3, 5, and 6 are found in their respective query files (ex- Query1.sql, Query2.sql)

#### Question 4 answer

4. If you had to create an index on these tables, which fields would you most
likely index, and why?

Whenever you are looking to add indexes to tables, the goal is to optimize fields that would be commonly searched against for retrieving data from the table

Given our structures for the tables we have in this assignment

Customers
* id
* name
* address
* phone_number
* email

Orders
* id
* customer_id
* order_amount
* order_address

We can probably assume that Customers.id and Orders.id are both indexed by probably being the primary keys for the table. If they aren't indexed, they would be prime targets for indexing

After taking care of the primary keys being indexed, we probably still want a few other fields of interest.

First we'll talk about Orders. Orders has a foreign key back to Customers via customer_id. Since this will probably be looked up against frequently, we should assign an index to it.

As for Customers, it mainly depends on the nature of the system. For example, if a person's login/identifier is something such as their phone_number or email, then I'd suggest adding an index to one of those fields

However, as it currently stands there's no information to suggest that that is the case, so I would add an index to name since name is a commonly searched on field in most systems.
