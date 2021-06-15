/*******************************************************************
* 
* Author - Chris Millan
* Description - Problem 2 -  Write a SQL query to pull all customers that have orders (no duplicates).
*
*******************************************************************/

SELECT [id], [name], [address], [phone_number], [email]
FROM Customers
WHERE [id] IN (
	SELECT DISTINCT [customer_id] FROM Orders
)
	