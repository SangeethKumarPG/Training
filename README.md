% is a wild card operator to match the pattern. If you put % after a character, it will show all the rows which starts with that particular column. If you put % first and place it before a character it will show all the rows with characters that end with that character. **We should use LIKE keyword for comparing patterns**

Aliasing is used to change the column name of the output of the query. 

**NOTE: If you don't have spaces in the alias names, you can wrap it in double quotes.** 

**In oracle we use single quotes for comparison and double quotes for aliases.**

**Even we can use quotes for specifying aliases, according to SQL standard we must use the AS keyword.**

|| symbol is used to concatenate strings.

eg:

`SELECT 'My name is '||ENAME FROM EMP;` 

NOTE that you must use single quotes.

Aliasing is used to change the column name of the output of the query. 

**NOTE: If you don't have spaces in the alias names, you can wrap it in double quotes.** 

**In oracle we use single quotes for comparison and double quotes for aliases.**

**Even we can use quotes for specifying aliases, according to SQL standard we must use the AS keyword.**

|| symbol is used to concatenate strings.

eg:

`SELECT 'My name is '||ENAME FROM EMP;` 

NOTE that you must use single quotes. when doing this we get the column name as **'MYNAMEIS'||ENAME'** to fix this you need an alias like :

`SELECT 'My name is '||ENAME AS "EMPLOYEE BIO" FROM EMP;` 

`SELECT ENAME||' makes $'||SAL||' per month' AS "EMPLOYEE SALARY PER MONTH" FROM EMP;` we can also combine pipes like this. 

NOTE that the aliases should not be too long.

**ORDER BY** keyword is used to sort the data according to a particular column in SQL. By default the order by sorts the results in ascending order.

You can also add multiple columns for order by like:

`SELECT DEPTNO, ENAME, SAL FROM EMP ORDER BY DEPTNO, SAL DESC;` 

Single row functions are functions that operate on every row of the table one row at a time.

**CONCAT()** : is used to concatenate two columns. We can use || also. **NOTE**:CONCAT() should have only 2 arguments. If there are multiple concats you should nest them. 

eg: `SELECT concat(concat(LOWER(ename),UPPER(' is the name ')),concat('and their job is:',UPPER(job))) from emp;`

**UPPER()** : used to convert the value to upper case. 

**NOTE: Whatever we pass in the select statement be it string or any function it will be applied to all the rows if there is no where condition.** 

DUAL is a special table. When you do a select \* from dual we will get one row and one column with value x and column name 'DUMMY'. You can select any value from dual.

You can combine multiple functions together.

**Single row functions can also be used for filtering data in WHERE clause also.** 

**INITCAP ():** Capitalizes the first letter of each word in the character sequence.

**LENGTH ()** : Gives the length of the given sequence.

**SUBSTR(input\_string, start\_position, number\_of\_characters)** : Extracts parts of a string. If you don't specify the third argument it will extract till the end of the string.

**LPAD(input\_string, total\_width\_of\_result, character\_to\_pad)** : Add characters to the left side of the string. 

**RPAD(input\_string, total\_width\_of\_result, character\_to\_pad)** : Add characters to the right side of the string.

**LTRIM(string, character\_to\_trim)** : It will trim characters from only the left side of the string(begining).

**RTRIM(string, character\_to\_trim)** : It will trim characters from only the right side of the string(end).

The trim function trims any number of occurrences of characters from the specified position.

Numeric Single Row Functions accepts numbers as their argument. 

**ROUND(number\_to\_round, places\_to\_round)** : Rounds the specified number by specified number of places. **If you don't specify the number of places it will give you a rounded whole number.** 

**TRUNC(number\_to\_truncate, decimal\_places\_to\_keep)** : If you don't specify the number of decimal places to keep it will simply remove all the digits after the '.' . if you specify a number it will keep that many digits after decimal point. **NOTE: TRUNC doesn't round numbers**

  
**SYSDATE** is used to select current date.

**SYSTIMESTAMP:** Returns the date, time(hour, minute, seconds, fractional seconds) AM/PM along with the timezone.

**ADD\_MONTHS(date\_as\_string, months\_to\_add)** : used to add months to the given date. If you pass the months to add as negative it will reduce the number of months from the given date.

**MONTHS\_BETWEEN(date1\_as\_string, date2\_as\_string)** : Returns the number of months between the specified dates. If date 1 comes after date2 it will return a negative number. If there is a difference in days also present the returned value will return a floating point number.

**TRUN(date\_string, 'MONTH/YEAR'):** can also be used to truncate dates. If you call trunc function on timestamp without any arguments it will return just the date.

**If you pass the 'YEAR' as argument it will return the first day of that year. If you pass 'MONTH' it will return the first day of that month**. Note that it will return the full date.

**TO\_CHAR(date/number, date\_format/currency\_format)** : It is used to convert a date or a number to a character string. It is used to display the date in a format other than the system default format. 

eg: TO\_CHAR(sysdate, 'Month DD,YYYY');

or TO\_CHAR(123, '$999.99');

'YEAR' - will give the entire year name as string eg: Two Thousand

'MONTH' - will give the entire month name as sting eg: March.

DY - Gives the 3 letter abbreviation of day.

DAY - will give the full day name.

MON - gives the 3 letter abbreviation of month.

  
You can use " " inside of a single quote when formatting when you are using non formatting elements such as english words.

You can also use TO\_CHAR() function to format numbers. The number 9 is used as the placeholder for a digit. We can also force 0's if we place 0 as placeholder eg: 0000.00\. On this if we pass the number 278.6 it will output 02780.60.

We can place $ signs commas for formatting.

eg:

`SELECT EMPNO, ENAME, TO_CHAR(SAL, '$99,999.99') FROM EMP; ` 

**TO\_DATE('str','format')**: Used to convert a string into a date format.

eg: `TO_DATE('2021-08-27','yyyy-mm-dd');`

`SELECT TO_DATE('3 of June, 2012','dd "of" MONTH, YYYY') FROM DUAL;` will work.

**LAST\_DAY(_d):_**

last\_day is a date function that requires a date as an argument. It returns the last day of the month in which the given date falls. The argument is required for this function to work properly.

**NEXT\_DAY(d, c):**

The first argument is the date and the second argument is a text reference to a day of the week. Both arguments are required for this function to work properly. This function returns a valid date representing the first occurrence of the _c_ day following the date represented in _d_.

  
**NVL(column\_name, value)** : is used to replace NULL value with the specified value. Note that we can only pass supported types as value. Let's say if we want to use a string indicate a null value in a numeric column it will give us an error. To work around this we need to first convert the column to character using TO\_CHAR() function then wrap it with an NVL() function.  
eg: 

`SELECT EMPNO,ENAME,NVL(TO_CHAR(COMM),'NO DATA FOUND') FROM EMP;`   
**NULLIF(argument1, argument2)** : Is used to return null if both the arguments are equal to one another. eg:

`SELECT ename, LENGTH(ename), NULLIF(LENGTH(ename),5) FROM emp;`   
This will return null columns when the length of the ename is equal to 5\. We can also combine multiple single row functions like this:

`SELECT ename, LENGTH(ename), NVL(TO_CHAR(NULLIF(LENGTH(ename),5)), 'LENGTH EQUALS 5') FROM emp;` 

Single row functions run on every row i.e for every row n if we apply a single row function it will return n rows as output. For Grouping function if there are n rows the output will be a single datapoint(single row). 

**MAX(column)** : Return the max of the column

**MIN(column)** : Return the minimum of the column.

**SUM(column)** : Returns the sum of all the rows of the specified column

**AVG(column)** : Returns the average of the specified column.

**COUNT(column)** : Returns the number of rows in the specified column. If you don't want the count of a specific column you can use the \* inside the count function.

**NOTE that the count function counts non null values.**

 You can use these to perform mathematical operations.

We can use GROUP BY to group the query results based on certain attributes. Let's say we want to find the average salary according to the job type. As we know the avg() function returns a single row. We have to use multiple select statements to filter out the average salary of each job title. To simplify this we can use the GROUP BY clause.

i.e, `SELECT avg(sal), job FROM emp GROUP BY job;` 

We can use any aggregation function with the group by clause. If we just apply a group by clause without an aggregation functions the common values of the columns will be clubbed together and only the unique values will be displayed.

eg:

`SELECT job FROM emp GROUP BY job;` Will display only the unique job roles. The Group by clause is also helpful when we want to group a certain type of data by an aggregation function like we want to find the number of employees in each job title, max or min salary across the job titles etc. The aggregation functions are applied at the grouped level by doing this.

SELECT DISTINCT will also give the unique values of a particular column but it not very useful in grouping columns.

**NOTE: We cannot use WHERE clause in the GROUP functions. Only single row functions can be used with the where clause.**

We use HAVING keyword for filtering group function results. Suppose we want to find the job roles that has exactly 2 employees we can use:

`SELECT count(*), job FROM emp GROUP BY job HAVING count(*) = 2;` 

the count() in the select is optional, if you don't want to display the count. We can also use the where clause before group by for filtering if we are not using any aggregation functions.

The syntax structure for querying single tables is like:

**1\. SELECT clause**

**2\. FROM clause**

**3\. WHERE clause**

**4\. GROUP BY clause**

**5\. HAVING clause**

**6\. ORDER BY clause**

**We can use multiple columns with the group by clause, these columns are not mandatory in the select clause.** 

Eg:

`SELECT job, deptno, count(*) FROM emp GROUP BY job,deptno;` 

Will display count,job and deptno of employees according to the job and deptno.

We use parenthesis for inner queries. The result of the inner query is compared with the condition of the outer query. **You can have an inner query in the WHERE condition of a query**. For example:

`SELECT * FROM dept WHERE deptno = (SELECT deptno FROM dept WHERE deptno=30);` 

The nested portion is executed first. We can also have other conditions after the inner query combined with AND or OR. 

**You can also have the inner query after FROM clause**. for example:

`SELECT * FROM (SELECT * FROM dept);` 

**You can have the inner query inside the SELECT portion of a query also.**

If you are using subquery in the where part of the outer query. The inner query should return a single row otherwise you will get an error. eg:` SELECT * FROM emp WHERE deptno=(SELECT deptno FROM dept);` this will not work because we are using the **\=** operator for comparison, if we are using an **IN** it should work fine. eg:

`SELECT * FROM emp WHERE deptno IN (SELECT deptno FROM dept WHERE deptno IN (20,10));`

  
The **IN** clause also work only if there is **only a list of a values (Single column values).** If the inner query returns multiple columns it will give you a too many values error. 

NOTE that if we are nesting a subquery inside a select clause like : `SELECT ename, job, (SELECT job FROM emp) FROM emp;` we will also get the error like single row subquery returns more than one row. We can fix this by making the inner query return only a single row. 

`SELECT ename, job, (SELECT job FROM emp WHERE ename = 'KING') FROM emp;` but the result of the subquery will be repeated across all the results of the outer query. If there are n rows in the outer query result, there will be n number of results for the inner query which is same across all the rows. 

**NOTE: When using the inner query inside the SELECT clause the inner query must return only a single row. If you are using '=' for comparing the subquery result inside the WHERE you must only have a single row in the subquery.**

Subqueries are an indirect way for combining the result from 2 different tables. Using the JOIN statement is the more direct way.

If there is a common relationship(column) between two tables we can use JOIN statements to combine the two tables. Alternatively we can directly connect them conditionally. eg: 

`SELECT * FROM emp,dept WHERE emp.deptno = dept.deptno; `

By using this approach if there are unrelated data in any of the column those data will not be available in the result. We can also combine conditions together when performing these simple joins like:

`SELECT ename, job, sal FROM emp,dept WHERE emp.deptno = dept.deptno AND dept.loc='DALLAS';` 

If there are columns with the same name in both tables we will get a column ambiguously defined error. To fix that we need to specify the table name along with the column name. This type of error often comes on where conditions if both the column names are the same. If there are no conflicting column names we can use the column name directly without specifying the table name.

To avoid using the entire table name we can use aliases for tables. 

To give alias to a table `table_name alias` . We can have an entire subquery which returns multiple rows and columns in the FROM clause. It will be treated like a table. 

eg:

`SELECT e.ename as first_name, job, sal, e.deptno FROM (SELECT * FROM emp) e, dept d WHERE e.deptno = d.deptno AND loc='DALLAS';` 

When doing this we must use an alias for the table. Inside the subquery we can have WHERE clauses which further filters the table data. 

`SELECT e.ename as first_name, job, sal, e.deptno, d.loc FROM (SELECT * FROM emp WHERE job in ('MANAGER','ANALYST')) e, (SELECT * FROM dept WHERE loc IN ('DALLAS')) d WHERE d.deptno = e.deptno;` 

The above joins we have seen is called **INNER JOIN**. The inner joins will give rows which have common column values specified in the WHERE clause. The INNER JOIN keyword can be used to perform the same operation in a more cleaner way. 

eg:

`SELECT * FROM emp INNER JOIN dept ON emp.deptno = dept.deptno;` This is the oracle standard syntax.

To return all the rows of the right table along with the matching rows in the left table we use **RIGHT JOIN.** 

eg: 

`SELECT * FROM emp RIGHT JOIN dept ON emp.deptno = dept.deptno;` 

The same can be done vice versa using the **LEFT JOIN** to display all the rows in the left table and only the matching columns in the right table. If there are only common values both LEFT JOIN and RIGHT JOIN will work as INNER JOIN. The order of the tables are important. 

**LEFT OUTER JOIN** and **RIGHT OUTER JOIN** are the same thing.

NOTE : This will show NULL values in the other if there are no matches in the corresponding table.

The **FULL OUTER JOIN** will return all the columns from the left and right table even if the condition didn't match. NULL values from both the tables will be present in this. 

We can have subqueries in the FROM with joins. note that we must use aliases.

**NOTE** : Queries run slower if you have subqueries. It is recommended to directly reference tables whenever possible.

  
**If we can switch the order of columns of tables regardless of the type of join we used (LEFT, RIGHT) by specifying the column names directly in the required order**. for example : 

`SELECT e.empno, e.ename, e.job, e.mgr, e.hiredate, e.sal, e.comm, e.deptno, d.deptno, d.dname, d.loc FROM (SELECT * FROM dept) d LEFT OUTER JOIN (SELECT * FROM emp WHERE job = 'SALESMAN') e ON e.deptno = d.deptno;` 

If we use an asterisk(\*) to display the output the columns in the dept table will be listed first.

If we want to select all the columns of a table that have an alias we can use `alias.*` 

**EXISTS** is used along with subqueries to check if it returns any rows. For example we can use it in the WHERE clause to return rows from a table only when the subquery returns rows.

`SELECT * FROM emp WHERE EXISTS (SELECT 'random' FROM dual);` 

The opposite of EXISTS is **NOT EXISTS.** 

**NOTE** : This is not an efficient way because the inner query is run for every row in the table in the outer query. 

**You can refer to the aliases of the outer query inside the subquery, But you cannot refer to columns inside of the inner query in outer query's select clause**. EXISTS and NOT EXISTS are called co-related subqueries. 

eg : `SELECT d.* FROM dept d WHERE NOT EXISTS (SELECT * FROM emp e WHERE e.deptno = d.deptno);` 

  
**SELF JOIN** is joining a table by itself. For example if we want to find show the employee name along with their managers name which both are in the same table we can use join the emp table with itself.

eg: `SELECT employee.ename, employer.ename as "MANAGER" FROM emp employee JOIN emp employer ON employer.empno = employee.mgr;` 

alternatively you can use the select clause like : 

```javaScript
SELECT employee.ename as "EMPLOYEE", employer.ename as "MANAGER" FROM emp employee, emp employer WHERE employee.mgr = employer.empno;
```

This is only possible because there is matching data in both columns and we are using different aliases for the same table. If there are no matching value for a particular column we can use LEFT or RIGHT JOIN clauses accordingly. eg:

`SELECT employee.ename as "EMPLOYEE", NVL(employer.ename,'NO MANAGER') as "MANAGER" FROM emp employee LEFT JOIN emp employer ON employee.mgr = employer.empno;` 

If you don't have a condition when joining tables(when using , separated joins) the total number of rows returned will be the multiple of rows in each individual table. This will not happen if you use JOIN clauses when joining tables because it will show an error if you don't specify a condition. The join without condition can be simulated using **CROSS JOIN**. eg:

`SELECT * FROM emp CROSS JOIN dept;` 

The cross join will return the cartesian product of both the tables. We are just repeating the data in both the tables. 

If you have columns with the _same name_ in 2 different tables and they have a _primary key- foreign key_ relationship we can use **NATURAL JOIN.** 

eg: `SELECT ename, mgr, loc FROM emp NATURAL JOIN dept;` 

An alternative for this is **USING** clause. We need to specify USING instead of ON clause with the JOIN clause.

eg:

`SELECT ename, mgr, loc FROM emp JOIN dept using (deptno);` 

We can use LEFT or RIGHT join with the USING.

If you don't have any matching column names you can specify column names separated by commas in the USING like **USING(col1, col2) .** 

**EQUIJOIN** is similar to inner join but we use the equality operator '=' for the joining condition. eg:

`SELECT * FROM emp e, dept d WHERE e.deptno = d.deptno;` 

Suppose you want to determine the grade of all the employees according to the salary. If you have a job\_grade table like :

```javaScript
CREATE TABLE job_grade
(Grade_level varchar(2) not null,
lowest_sal number not null,
highest_sal number not null);
```

and we insert values into the table like:

```javaScript
INSERT ALL
 INTO job_grade
 VALUES ('A', 0, 1000)
 INTO job_grade
 VALUES ('B', 1001, 2000)
 INTO job_grade
 VALUES ('C', 2001, 3000)
 INTO job_grade
 VALUES ('D', 3001, 4000)
 INTO job_grade
 VALUES ('E', 4001, 5000)
SELECT * FROM DUAL;
```

We can determine the grade of the employee from this. But the salary value in the employee table is not present in the job\_grade table. It has a range of salary. So we need to use the BETWEEN operator to determine weather a salary falls in the given range.

We can use a query like:

`SELECT e.ename, e.sal, j.grade_level FROM emp e JOIN job_grade j ON e.sal BETWEEN j.lowest_sal and j.highest_sal;`

In the above example there is no common column which we can match to join both the tables such joins are called **NON-EQUIJOINS.** 

CASE statement is equivalent to the IF THEN ELSE in other programming languages. It is used to conditionally display output based on the input values. We can use CASE with an sql query to return value based on a particular column value.

eg:

```javaScript
SELECT ename, job, (CASE job
WHEN 'PRESIDENT' THEN 'big shot'
WHEN 'MANAGER' THEN 'decides the pay'
WHEN 'ANALYST' THEN 'good at math'
WHEN 'CLERK' THEN 'hardworking'
ELSE 'no comment' 
END) as "COMMENT"
FROM emp;
```

We can wrap the CASE statements in parenthesis. We end the CASE statement with the END keyword. We can omit the ELSE condition if we don't want it.

**NOTE** : If you need to check an expression inside the CASE _we don't need to specify the column name along with the CASE keyword. Instead use the column name in the WHEN portion._

eg:

```javaScript
SELECT ename, sal, CASE
    WHEN sal >= 3000 THEN 'big shot'
    WHEN sal < 3000 THEN 'earn more money'
    END as "COMMENT" FROM emp;
```

  
If i want to display the total count as a column along with the table we can use a subquery like:

```javaScript
SELECT b.*,(SELECT count(*) FROM bricks) as "TOTAL_BRICKS_IN_TABLE" FROM bricks b;
```

We cannot directly use count() with the select statements. 

If we want to display the count of each different colour of bricks we need to create a co-related subquery. So the query will be like 

```javaScript
SELECT b.*,(SELECT count(*) FROM bricks) as "COUNT" FROM bricks b;
```

If we want to find the total weight of the bricks by it's colour we can use 

```javaScript
SELECT b.*,(SELECT count(*) FROM bricks) as "COUNT" FROM bricks b;
```

An easier way to perform the same operation is by using the **OVER** clause. The syntax is 

`SELECT aggregate_function()<space>over() FROM table;`   
eg:

```javaScript
SELECT count(*) over() FROM bricks;
```

This will output 6 rows with a single column with the values as 6\. We can select other rows of the table along with this like:
  
  
```javaScript
SELECT b.*, count(*) over() as "TOTAL_COUNT" FROM bricks b;
```

Another name for analytical functions is window functions. Inside the over clause we specify the window. If we leave it empty we are saying that the entire table is the window.

```javaScript
SELECT b.*, count(*) over(partition by colour) as "COUNT_BY_COLOUR" FROM bricks b;
```

This will provide a window(group) for blue green and red, The aggregate function count will be applied over each window. This is essentially the same as subquery but much more cleaner. We can perform any aggregate operation over the window like

```javaScript
SELECT b.*, sum(weight) over(partition by colour) as "TOTAL_WEIGHT_BY_COLOUR" FROM bricks b;
```

The **PARTITION BY** clause let's us create windows.

We can have disparate columns in the result by using different windows like:

```javaScript
SELECT b.*, SUM(weight) OVER (partition by shape) as SUM_BY_SHAPE,
SUM(weight) OVER(partition by colour) as SUM_BY_COLOUR
FROM bricks b;
```

This allows us to have different kinds of groupings in the same query. 

The **ORDER BY clause inside the OVER()** function let's us create running totals(sum of current row+ sum of previous rows) for example :

```javaScript
SELECT b.*, SUM(weight) OVER (partition by shape) as SUM_BY_SHAPE,
SUM(weight) OVER(partition by colour) as SUM_BY_COLOUR
FROM bricks b;
```

Here we are creating a window which is partitioned by brick\_id thus sum of each brick is calculated by the sum function. The last row will have the total weight. By default the order by selects row in ascending order.

We can combine the partition by with order by clause inside the over function. For example if we want to find the running weight by colour we can use a query like :

```javaScript
SELECT b.*, SUM(weight) 
OVER(partition by colour order by brick_id) as RUNNING_WT_BY_COLOR 
FROM bricks b ORDER BY colour;
```

NOTE : You cannot use group by inside the OVER() function.

When you use order by inside the over() function oracle will automatically add **range between unbounded preceding and current row** along with that. Which means that the specified column value is checked against the current and all of the previous rows. By doing this we must make sure that the specified column value is unique for all rows, other wise values from other rows( rows after the current) row will be considered for calculating the running total. To prevent this we can use **rows between unbounded preceding and current** for example:

```javaScript
SELECT b.*, SUM(weight)
OVER(order by weight rows between unbounded preceding and current row) 
as RUNNING_TOTAL_WT FROM bricks b ORDER BY weight;
```

**By this way we can prevent columns with duplicate values affecting the running total calculation.** 
This makes sure that each individual row is considered for calculation without considering the duplicates. 

You can adjust the sliding window size by specifying the number of preceding rows. For example :

```javaScript
SELECT b.*, SUM(weight) OVER(order by weight rows between 1 preceding and current row) as LIMITED_WINDOW_TOTAL
FROM bricks b ORDER BY weight;
```

We can specify any number of rows instead of 1\. 

You cannot use the having clause with the sliding window for filtering for this you need to use a subquery to specify the select condition of the window function. Use the alias of the window function in the outer query with where clause for filtering for example:

```javaScript
SELECT * FROM (SELECT b.*, COUNT(*) OVER(partition by colour) colour_count
FROM bricks b
) WHERE colour_count >=2;
```

**NOTE** : The database processes analytical functions after the where clause so you can't use something like:

```javaScript
select colour from bricks
where  count(*) over ( partition by colour ) >= 2;
```

This will throw an error.
