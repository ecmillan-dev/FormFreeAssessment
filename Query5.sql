/*******************************************************************
* 
* Author - Chris Millan
* Description - Problem 5 - Write a query that lists each customer name, email, and the number of orders they have.
* 
*******************************************************************/

SELECT [name], [email], count(o.customer_id) as [number_of_orders] 
FROM Customers c
LEFT OUTER JOIN Orders o ON o.customer_id = c.id
GROUP BY [name], [email]
