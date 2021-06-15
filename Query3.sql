/*******************************************************************
* 
* Author - Chris Millan
* Description - Problem 3 -  Write a SQL query to pull all customers that do not have orders.
*
*******************************************************************/
SELECT [id], [name], [address], [phone_number], [email]
FROM Customers
WHERE [id] NOT IN (
	SELECT DISTINCT [customer_id] FROM Orders
)