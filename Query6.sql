/*******************************************************************
* 
* Author - Chris Millan
* Description - Problem 6 - Write a query that pulls all customers that have between 2 and 5 orders.
*
*******************************************************************/


SELECT c.[id], [name], [address], [phone_number], [email]
FROM Customers c
JOIN Orders o ON o.customer_id = c.id
GROUP BY c.[id], [name], [address], [phone_number], [email]
HAVING COUNT(o.customer_id) >= 2 AND COUNT(o.customer_id) <= 2 -- assumption that between is inclusive