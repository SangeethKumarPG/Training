## SQL NOTES
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

Rank, Dense\_rank and row\_number() functions are used to provide an id for each row. 

**Rank** : Rows with the same value in the order by have the same rank. The next row after a tie has the value of N, where N is it's position in the dataset. Just like rank in statistics. 

**Dense\_rank** : Rows with the same value in the order by have the same, rank but there are no gaps in the ranks.

**Row\_number** : each row has a new value. Increased by 1 by default. each row will have a unique number.

```javaScript
select brick_id, weight,
    row_number() over(order by weight) rn,
    rank() over(order by weight) rk,
    dense_rank() over(order by weight) dr
FROM bricks;
```

Consider the above query. This will assign a rank, dense\_rank and row\_number based on the weight column. You don't need to pass any argument to these functions.

The **lead()** and **lag()** are another type of analytical functions which let's us get the next row value of a specified column and previous row value of a specified column. 

  
You need to pass the column name as argument to these functions. also we need to use the over() function. eg:

```javaScript
select b.*, lag(shape) over(order by brick_id) prev_shape,
    lead(shape) over(order by brick_id) next_shape 
from bricks b;
```

this displays the previous and next values of the shapes in columns prev\_shape and next\_shape respectively. **The lag functions output for the first row of a column will be null. and the output of the lead function for the last row of a column will be null.** 

**The first\_value(column) returns the first value of a column for all the rows, the last\_value(column) returns the current value of the column.** consider the below query:

```javaScript
select b.*,
       first_value ( weight ) over (
         order by brick_id
       ) first_weight_by_id,
       last_value ( weight ) over (
         order by brick_id
       ) last_weight_by_id
from   bricks b;
```

The first\_value() will always return the value of the first row for all the rows. The last\_value will return the current value

for all the rows. In the above case the weight of the first row is 1, so if we use the first\_value function and apply it over a window function to display this as a new column we will see 1 for all the rows. But if we use the same thing for last\_value the value of the current row (weight) will be displayed for each respective row in the query result as a column **This is because the default windowing clause stops at current row**. To actually get the last value we can use : 

```javaScript
range between current row and unbounded following
```

inside the window function. 

```javaScript
select b.*,
       first_value ( weight ) over (
         order by brick_id
       ) first_weight_by_id,
       last_value ( weight ) over (
         order by brick_id
         range between current row and unbounded following
       ) last_weight_by_id
from   bricks b;
```

This query will provide the desired result as it will display the value of last row for all the rows. 

Table is an object in the database that stores data. 

**Primary Key** : Is used to uniquely identify each row in a table. If a column is a primary key the data in the column must not repeat. It must not be NULL. It can also be a combination of columns. The primary key should be well thought out early on. Creating a primary key is not mandatory to create a table. 

To create a table we use the syntax.

`CREATE TABLE table_name(column_name DATA_TYPE [constraints]);` 

consider the below example:

```javaScript
CREATE TABLE stores (
    store_id NUMBER NOT NULL,
    city VARCHAR2(50)
);
```

`DESC table_name;` is used to show the description about the table. 

To insert values into the table we use the INSERT command. The syntax is :

`INSERT INTO table_name(column1, column2,...) VALUES (value1, value2..);`   
eg:  
`INSERT INTO stores(store_id, city) VALUES (1, 'San Francisco');  
`As soon as we execute the above statement the data is saved into the table. This is called an **auto/implied commit.** In some systems the commit will not happen automatically, we need to manually perform commit either after each transaction or after a series of transactions. We use the **COMMIT;** keyword for that.  
 If we want to insert multiple rows at a time we use the **INSERT ALL** command.   
syntax :

```javaScript
INSERT ALL
    INTO table_name(column_1, column_2...) VALUES (value1, value2)
    INTO table_name(column_1, column_2...) VALUES (value1, value2)
SELECT * FROM DUAL;
```

**NOTE** : **We need some kind of select statement when using this type of insert. Typically we use select \* from dual, which does not necessarily do anything.** 

Example for this is 

```javaScript
INSERT ALL
    INTO stores (store_id, city) VALUES(4, 'Philadelphia')
    INTO stores (store_id, city) VALUES(5, 'Boston')
    INTO stores (store_id, city) VALUES(6, 'Seattle')
SELECT * FROM DUAL;
```

The above method only works with oracle databases.  
**NOTE : If any of the statement in the insert all fails no record will be inserted.** 

The CONSTRAINT object is used to create a constraint while creating a table. The syntax for creating a constraint is :

```javaScript
CREATE TABLE(
    column_name datatype,
    ......
    CONSTRAINT constaint_name PRIMARY KEY(column_name)
);
```

The name to the key is mandatory. The primary key will enforce uniqueness in the table data. Consider the below example.

```javaScript
CREATE TABLE PRODUCTS(
    product_id NUMBER NOT NULL,
    name VARCHAR(50),
    product_cost NUMBER(5,2),
    product_retail NUMBER(5,2),
    product_type VARCHAR(10),
    store_id NUMBER NOT NULL,
    CONSTRAINT product_pk PRIMARY KEY(product_id)
);
```

The **INSERT ALL** command can be used to insert values into multiple tables at a time. This is much faster when compared into inserting into multiple tables separately. The syntax is :

```javaScript
INSERT ALL
    INTO destination_tbl_1 (column1, column2..) VALUES (column1_of_tbl_4, column2_of_tbl_4)
    INTO destination_tbl_2(column1, column2..) VALUES (column1_of_tbl_4, column2_of_tbl_4)
    INTO destination_tbl_3(column1, column2..) VALUES (column1_of_tbl_4, column2_of_tbl_4)
SELECT column1_of_tbl_4, column2_of_tbl_4 FROM tbl_4;
```

**NOTE : date is not a valid column name is SQL because it is a datatype.** 
**NOTE : The DESCRIBE keyword is used to get a description of a table in oracle.** 

The following is an example of multi table insert:

```javaScript
CREATE TABLE destination_tbl_1
(
    id NUMBER(6) NOT NULL,
    name VARCHAR2(50) NOT NULL,
    hire_date DATE NOT NULL,
    CONSTRAINT destination_tbl_1_pk PRIMARY KEY(id)
);
 
CREATE TABLE destination_tbl_2
(
    id NUMBER(6) NOT NULL,
    name VARCHAR2(50) NOT NULL,
    hire_date DATE NOT NULL,
    CONSTRAINT destination_tbl_2_pk PRIMARY KEY(id)
);
 
CREATE TABLE destination_tbl_3
(
    id NUMBER(6) NOT NULL,
    name VARCHAR2(50) NOT NULL,
    hire_date DATE NOT NULL,
    CONSTRAINT destination_tbl_3_pk PRIMARY KEY(id)
);
 
INSERT ALL 
    INTO destination_tbl_1 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
    INTO destination_tbl_2 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
    INTO destination_tbl_3 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
SELECT employee_id, first_name, last_name, hire_date FROM employees;
```

```javaScript
SELECT * FROM destination_tbl_1;
SELECT * FROM destination_tbl_2;
SELECT * FROM destination_tbl_3;
 
COMMIT;
```

The above 3 select statements will return the same query result. The INSERT ALL statement is more powerful than this, because we can conditionally insert data to multiple tables. eg:

```javaScript
INSERT ALL 
    WHEN salary <= 1500 THEN
        INTO destination_tbl_1 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
    WHEN salary BETWEEN 1501 AND 2500 THEN
        INTO destination_tbl_2 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
    ELSE
        INTO destination_tbl_3 (id, name, hire_date) VALUES(employee_id, first_name||' '||last_name, hire_date)
SELECT employee_id, first_name, last_name, hire_date, salary FROM employees;
COMMIT;
```

**NOTE: We need to select the column if we are using the column in our condition in the above example we are using the salary column to check the condition.** 

**NOTE : If we are inserting to all column of a table, we don't need to specify the column names. But the order of the columns need to matching to the values you are inserting.**   
eg : `INSERT INTO products VALUES(1004, '', 4.00, 8.00, 'clothing',3);` In the above query we are inserting empty product name to the products table where we haven't specified the NOT NULL condition for the NAME column. To fix this, we use the **ALTER TABLE** command. The syntax is:

` **ALTER TABLE table_name MODIFY column_name data_type constraints;**`

We can use the above syntax to modify the column like: 

`ALTER TABLE products MODIFY name VARCHAR2 NOT NULL;  
`This will not work because the column already has null values in it, so in-order to modify it we need to delete that entire row and alter it. 

```javaScript
DELETE FROM products WHERE name IS NULL;
 
ALTER TABLE products MODIFY name VARCHAR2(50) NOT NULL;
```

After altering the column the above query to insert empty name will not work. 

We can alter multiple columns of a table at a time using the below syntax:

```javaScript
ALTER TABLE table_name MODIFY ( column_name1 data_type constraints,
column_name2 data_type constraints,
column_name3 data_type constrains);
```

eg:

```javaScript
ALTER TABLE products MODIFY(
    product_cost NUMBER(5,2) NOT NULL,
    product_retail NUMBER(5,2) NOT NULL
);
```

To rename a particular column of a table we use the **RENAME** **COLUMN** command instead of **MODIFY**. The syntax is :

`ALTER TABLE table_name RENAME column_name TO new_column_name;`   
eg:

```javaScript
ALTER TABLE products RENAME COLUMN name TO product_name;
```

We can create a table from the SELECT query by using CREATE + SELECT syntax like:

`CREATE TABLE new_table_name AS SELECT column1, column2, column3... FROM table_name;`   
By this method all the features of the original table along with the data will be copied over to the new table. For example if we want to create a copy of our employee table we can use:

```javaScript
CREATE TABLE emp AS 
SELECT e.EMPLOYEE_ID, e.FIRST_NAME, 
e.LAST_NAME, e.SALARY, e.HIRE_DATE FROM employees e;
```

This will have the selected columns from the employee table.

We can also add columns to an existing table using the ALTER TABLE ADD command. syntax is:

`ALTER TABLE table_name ADD column_name data_type constaints;`   
**NOTE : When adding a column with NOT NULL constraint to an existing table there must not be any data in the existing table.** 
For example the below query will not work:

```javaScript
ALTER TABLE emp ADD store_id NUMBER NOT NULL;
```

If we remove the NOT NULL constraint the column will be added. 

The UPDATE command is used to update the data of existing columns in a table. The syntax is like:

`UPDATE table_name SET column = value WHERE condition;`   
If you don't use the WHERE clause all the data in that column will be updated. example:

```javaScript
UPDATE emp SET store_id = 3 WHERE last_name IN ('King', 'Blake','Clark');
```

```javaScript
// REFER LATER
UPDATE emp e SET job = (SELECT j.JOB_TITLE from jobs j 
LEFT JOIN employees em ON em.job_id = j.job_id 
WHERE e.EMPLOYEE_ID = em.EMPLOYEE_ID) WHERE job IS NULL AND EXISTS
(
    SELECT 1 FROM employees em 
    JOIN jobs j ON em.job_id = j.JOB_ID
    WHERE em.EMPLOYEE_ID = e.EMPLOYEE_ID
);
// REFER LATER
```

To update the the particular column of a table we can also use:

```javaScript
UPDATE emp e SET e.store_id = 
(
    CASE
        WHEN e.JOB LIKE 'Presi%' OR  e.job LIKE '%Vice%' THEN 3
        WHEN e.JOB = 'Sales Representative' THEN 4
        WHEN e.JOB = 'Purchasing Clerk' THEN 3
        ELSE 2
    END 
);
```

  
We can modify/add constraints to a column of a table using **ALTER TABLE table\_name MODIFY()** funciton. eg:

```javaScript
ALTER TABLE emp MODIFY(
    store_id NUMBER NOT NULL
);
```

**NOTE: When you create a table using select the constraints like primary key and foreign key will not be copied.**

The MERGE statement helps to insert or update data in a table depending upon weather the data already exists in the table. This is similar to INSERT INTO SELECT statement. The syntax is :

```javaScript
MERGE INTO destination_table USING source_table ON(condition) WHEN MATCHED THEN 
UPDATE SET source_table.column1 = destination_table.column1,
source_table.column2 = destination_table.column2,
source_table.column3 = destination_table.column3;
WHEN NOT MATCHED THEN
INSERT (destination_table.column1, destination_table.column2, destination_table.column3)
VALUES (source_table.column1, source_table.column2, source_table.column3);
```

Like this we can perform the insertion when the data doesn't exist and update the data if it already exists. For example:

```javaScript
MERGE INTO existing_customers c USING 
new_customers n ON (c.customer_id = n.customer_id)
WHEN MATCHED THEN
UPDATE SET c.first_name = n.first_name, c.last_name = n.last_name, 
c.address_state = n.address_state, c.email_address = n.email_address
WHEN NOT MATCHED THEN
INSERT (customer_id, first_name, last_name, address_state, email_address)
VALUES(n.customer_id, n.first_name, n.last_name, n.address_state, n.email_address);
```

**NOTE: This is specific to oracle.** 
Even if you run the statement multiple times you won't get any error. The matching rows will be updated but the non matching columns will not be inserted again. You can add delete conditions in between the MERGE. 

```javaScript
MERGE INTO existing_customers c USING 
new_customers n ON (c.customer_id = n.customer_id)
WHEN MATCHED THEN
UPDATE SET c.first_name = n.first_name, c.last_name = n.last_name, 
c.address_state = n.address_state, c.email_address = n.email_address
DELETE WHERE c.first_name = 'John'
WHEN NOT MATCHED THEN
INSERT (customer_id, first_name, last_name, address_state, email_address)
VALUES(n.customer_id, n.first_name, n.last_name, n.address_state, n.email_address);
```

Sequence is a counter which keeps track of a numeric sequence. A sequence can be used as a tool to auto increment values when data is inserted to a table. To create a sequence we use the syntax:

```javaScript
CREATE SEQUENCE sequence_name_seq 
    MINVALUE minimum_value
    MAXVALUE maximum_value 
    START WITH starting_number
    INCREMENT BY value
    CACHE value[NOCACHE];
```

By default if you don't provide any value for maximum value it will automatically use 99999999999999999999999 which is a very large number. The **START WITH** can be any value you can choose to start the sequence from. INCREMENT BY is the value which you choose to increment the next value generated the sequence. **CACHE** is specified to let the oracle know that that many next values should be in the memory. **NOCACHE** means that there will be no cache, but using cache is recommended because it is more performant. The default value of CACHE is 20\. Example of creating a sequence.

```javaScript
CREATE SEQUENCE product_seq
   MINVALUE 1
   MAXVALUE 999999999999999999999999999
   START WITH 1
   INCREMENT BY 1
   CACHE 20;
```

To get the next value of the sequence we use the **sequence\_name.NEXTVAL;** statement. You cannot directly use this command. If you need to see the next value you can use   
`SELECT sequence_name.NEXTVAL FROM dual;`   
When caching is used the above statement will not consistently return a value in order. To alter a sequence we use the following command:

`ALTER SEQUENCE sequence_name ATTRIBUTE;` 

Example:

`ALTER SEQUENCE product_seq NOCACHE;`   
If you disable caching every time you create a value from the sequence always a new value will be created. It will not go back to the previous generated value(when directly selecting from dual).

**NOTE**: you cannot alter the starting value of a sequence after creating it.

Example usage of sequence:

```javaScript
CREATE SEQUENCE product_seq
   MINVALUE 1001
   MAXVALUE 9999999999999999999999999999
   START WITH 1004 
   INCREMENT BY 1
   CACHE 20;
```

When inserting data:

```javaScript
INSERT INTO products(product_id, product_name, product_cost, product_retail, product_type, store_id)
VALUES (product_seq.NEXTVAL, 'Pepsodent Tooth Paste', 2.00, 3.50, 'hygene',3);
```

This will automatically increment values of the store\_id column whenever we insert a value, we don't need to manually increment the count.  
**NOTE:** When inserting values to a table which already has values to the column which you want to fill with the sequence, you must specify the MINVALUE as the largest value(last value) of that column, otherwise you will run into errors which prevents you from inserting data.

To delete a row from a table we use the syntax:

`DELETE FROM table_name WHERE condition;` 

eg:  
`DELETE FROM departments_copy WHERE department_id=69;`  
**If you don't specify the condition it will delete all the rows in the table**. You can use multiple rows at a time when appropriate condition is used. 

We cannot delete rows if they are referenced by other tables using foreign key constraints. When you try to delete these rows it will show you a constraint violation error. To delete such a row first we need to drop the constraint. To drop a constraint we use the syntax is :

`ALTER TABLE table_name DROP CONSTRAINT constrain_name; `   
The user\_constraints table will have all the constraints of all the tables in oracle. You need to filter out the rows by using the particular table name to get the constraints of that particular table.

eg:

```javaScript
SELECT uc.* FROM user_constraints uc WHERE uc.table_name = 'EMPLOYEES';
```

After this we can drop constraints using:  
`ALTER TABLE employees DROP CONSTRAINT EMP_DEPT_FK;` 

**NOTE: This action is permanent. Even if you roll back the constraint will not be restored.**

**The TRUNCATE command removes all the data from the table. It does not remove the table.**

The syntax is `TRUNCATE TABLE table_name;`   
example:

```javaScript
TRUNCATE TABLE departments_copy;
```

The DROP TABLE command removes the table from the database. This operation is not permanent unless you COMMIT the transaction. The syntax is :

` DROP TABLE table_name;` 

An index is a database object which is used to search for things in the database faster. A table with well defined indexes will be much faster to query when compared to tables with no indexes. All relational databases support the use of indexes. It is like an index of a book, if you have an index you can search for things easily otherwise you will have to scan the entire book to find the information you need. In tables with less number of rows there is not much performance improvement when using indexes. We choose columns of the table to be indexes. These should be important columns which are queried often. Indexes are stored like objects in the database. The syntax is:

`CREATE [UNIQUE] INDEX index_name ON table_name (column1, column2,..) [COMPUTE STATISTIC];`   
Commonly we use the **idx** in the index name as prefix or postfix. Eg:  
`CREATE INDEX first_name_idx ON employees(first_name); `   
We can combine multiple columns to create indexes like:

```javaScript
CREATE INDEX fname_job_hdate_idx ON employees(first_name, job_id, hire_date);
```

**NOTE:** Creating indexes takes up space in the database. You don't need to index every column of every table in the database.   
You can also create unique indexes, note that when creating unique indexes the data in the column should be unique otherwise we will get an error.   
To drop an index we use `DROP INDEX index_name;`   
eg:  
`DROP INDEX first_name_idx;`   
The compute statistic keyword can be used when creating indexes, by this way additional information about the indexed column will be stored in the database. This way the queries become much smarter. i.e, the oracle query optimiser finds the best way possible to execute queries on such indexes. You can add COMPUTE STATISTIC to an already existing index by using the following syntax:

`ALTER INTEX index_name REBUILD COMPUTE STATISTICS;`   

To check for constraints in a particular table we use the all\_constraints and all\_cons\_columns table eg:

```javaScript
SELECT ac.constraint_name, acc.column_name FROM 
all_constraints ac JOIN all_cons_columns acc ON ac.CONSTRAINT_NAME = acc.CONSTRAINT_NAME
WHERE ac.table_name = 'STORES'
AND ac.constraint_type = 'P';
```

The constraint\_type specified 'P' is for primary key.

**ROWID** is a pseudo column, which you can use with any query. Each record in each table has a unique rowid in string format. We can use the ROWID to delete duplicate records from a table. For example consider the stores\_copy table which has duplicate records. To get these records we can use :  
`SELECT MIN(rowid) FROM stores_copy GROUP BY store_id, city;`   
This will show the lowest rowid for each combination. We can delete these by:

```javaScript
DELETE FROM stores_copy WHERE rowid NOT IN(SELECT MIN(rowid) FROM stores_copy GROUP BY store_id, city);
```

**You must use the MIN() on rowid otherwise all the rowids of all the rows will be used and all the rows will be deleted. NOTE that even though all there are duplicate records the rowids for each row is unique.** You must use GROUP BY on all the column combinations that has duplicate data. For example:

```javaScript
INSERT INTO stores_copy(store_id, city) VALUES(5, 'Houston');
INSERT INTO stores_copy(store_id, city) VALUES(6, 'Dallas');
```

We insert 2 new records whose store\_id is already in the table but the city is unique. To view these records we can use:

```javaScript
SELECT store_id, count(*) FROM stores_copy GROUP BY store_id;
```

And to delete them we can use:

```javaScript
DELETE FROM stores_copy WHERE rowid NOT IN (SELECT MIN(rowid) FROM stores_copy GROUP BY store_id);
```

After deleting the duplicate records we can set a primary key on store\_id using:

```javaScript
ALTER TABLE stores_copy ADD CONSTRAINT store_id_pk PRIMARY KEY (store_id);
```

To get the already existing indexes of a table we use query the **user\_indexes** table by filtering the **table\_name** for example:

```javaScript
SELECT index_name, index_type, uniqueness 
FROM user_indexes WHERE table_name = 'STORES_COPY';
```

**NOTE** : **When you create a PRIMARY KEY on a table it will automatically create a UNIQUE INDEX on the column.** 

```javaScript
CREATE UNIQUE INDEX store_copy_id_unq_idx ON stores_copy (store_id) COMPUTE STATISTICS;
```

This will give us an error like "such column list is already indexed"

**ROWNUM**  is a useful object which assigns a unique number to all the rows sequentially when used with an SQL statement. We can use this to limit the number of rows returned by a select statement like:

```javaScript
SELECT * FROM all_tables WHERE ROWNUM < 10;
```

Which will show only 9 records. This will reduce the load on the database when there are many rows to be returned. note that this will return the first N records.  
SYSTEM TABLES are tables that are managed by the oracle system. You don't need to update or delete from such tables unless it is absolutely necessary. You can query these and find out more information about your database. 

* **ALL\_TABLES :** Has all the tables in the database.  
`SELECT * FROM all_tables;`  
Based on the size of the database this query may take a while. We can search for our tables in this table by using the table\_name. **NOTE: You must always use capital letters for table names when searching in system tables.** eg:  
`SELECT * FROM all_tables WHERE ROWNUM < 10 AND table_name = 'EMPLOYEES';`

* **ALL\_TAB\_COLUMNS :** Gives all the columns of a table. We can filter this table by the table\_name. eg: `SELECT * FROM all_tab_columns WHERE ROWNUM < 30 AND table_name = 'EMPLOYEES';`
* **ALL\_OBJECTS :** Will show all the objects in the database. We can filter this by using the **object\_type** column. eg:  
`SELECT * FROM all_objects WHERE ROWNUM < 50 AND object_type='TABLE';  
`We can change the object\_type to **'INDEX'** to get all the indexes in the database. We can further filter out the data by **OBJECT\_NAME** column.
* **ALL\_SYNONYMS :** Synonyms are nick names that you can assign to a table. You can assign a synonym to a table and query that table using a synonym. PUBLIC SYNONYMS are synonyms that can be used by everyone. eg: `CREATE PUBLIC SYNONYM emp_table FOR employees;  
`_To create public synonyms you must have sufficient privileges(ADMIN)._ You can filter this table by using the synonym\_name column eg: `SELECT * FROM ALL_SYNONYMS sn WHERE sn.synonym_name = 'EMP_TABLE';`

**VIEW** is a type of database object. All relational databases has views. A view is can be thought of as a stored or a named query. If you have a long complex complex query if you want to save it we can use views. For example :

```javaScript
SELECT * FROM employees emp LEFT JOIN jobs j ON emp.job_id = j.job_id WHERE lower(j.job_title) LIKE '%manager';
```

To create a view we use the syntax :   
`CREATE VIEW view_name AS SELECT QUERY;  
`The above query can be converted into a view like:

```javaScript
CREATE VIEW manager_v AS SELECT emp.*, j.job_title, j.min_salary,
j.max_salary FROM employees emp 
LEFT JOIN jobs j ON emp.job_id = j.job_id
WHERE LOWER(j.job_title) LIKE '%manager';
```

**NOTE : A view must not have duplicate columns, if you have duplicate columns you must use different aliases for each column**.   
It is a normal convention to use **'\_v'** for view names.   
To find the views created by the user we must filter the **user\_objects** table using the **object\_type**. 

eg:  
`SELECT * FROM user_objects WHERE object_type = 'VIEW' AND object_name LIKE 'MANAGER%';`   
We can also specify the owner of the view using OWNER column of the ALL\_OBJECTS table.   
To get the version of the database we can use the SYS.V\_$VERSION eg:  
`SELECT * FROM SYS.V_$VERSION;  
`We can drop views using `DROP VIEW view_name;`   
To get the maximum salary of employee in each department we can use the following query:

```javaScript
SELECT emp.employee_id, emp.first_name, emp.last_name, emp.department_id,
emp.salary, d.DEPARTMENT_NAME, d.LOCATION_ID,
l.CITY
FROM employees emp JOIN departments d 
ON emp.department_id = d.department_id
JOIN locations l
ON d.location_id = l.location_id WHERE
emp.salary = (SELECT MAX(emp2.salary) FROM employees emp2 
WHERE emp2.department_id = emp.department_id);
```

We can create a view from this query like:

  
```javaScript
CREATE VIEW max_salary_v AS 
SELECT emp.employee_id, emp.first_name || emp.last_name as "name",
emp.department_id, d.department_name, d.location_id, l.city
FROM employees emp
JOIN departments d on emp.department_id = d.department_id
JOIN locations l on d.location_id = l.location_id
WHERE emp.salary = (SELECT MAX(emp2.salary) FROM employees emp2 WHERE
emp2.department_id = emp.department_id);
```

The above query can also be written as :

```javaScript
SELECT e1.* FROM employees e1 
INNER JOIN (SELECT department_id, MAX(salary) as salary FROM employees GROUP BY
department_id) e2 ON e1.department_id = e2.department_id
AND e1.salary = e2.salary;
```

We can join select query results to tables like shown in the above. Note that in the above query we cannot select more than 2 columns in the group by query, that is why we are using joins. Also we need to properly filter out the records using the join conditions, here we are joining based on the department\_id and the salary, if we don't use the salary column 

all the records of the employees table will be shown in the result. As mentioned previously the column names in the view should be unique. That is why we are selecting only the columns of the e1\. Alternatively we can use aliases for the column names.   
**UNION: Is used to combine the rows of two queries.** The result of the union will not have duplicate rows. Also when performing union both the select statements should have same columns. eg:

```javaScript
SELECT e1.* FROM employees e1 
INNER JOIN (SELECT department_id, MAX(salary) as salary FROM employees GROUP BY
department_id) e2 ON e1.department_id = e2.department_id
AND e1.salary = e2.salary
UNION
SELECT * FROM employees;
```

**UNION ALL :** Works same as union except it will show all the rows of both tables, it won't filter out duplicate rows.

**MINUS :** It is used to remove the records from one query based on the second query. For example:

```javaScript
SELECT e1.* FROM employees e1 
INNER JOIN (SELECT department_id, MAX(salary) as salary FROM employees GROUP BY
department_id) e2 ON e1.department_id = e2.department_id
AND e1.salary = e2.salary
MINUS
SELECT * FROM employees WHERE JOB_ID ='SA_MAN';
```

This will remove the record where job\_id is 'SA\_MAN' from the result of the first query.  
We can easily change the view which is already created using: `CREATE OR REPLACE VIEW view_name AS QUERY;` We can also easily drop views using DROP VIEW view\_name command.

**DCL : Data Control Language** mostly used by database administrators. Administrators create users or schemas. Users and schemas are essentially the same. Each user will have access to the tables, views etc in his specific schema. Only admins can access the data from other users or schema. One user can access the schema corresponding to other user only by the approval of admin. The most commonly used commands are GRANT, REVOKE and ROLE. GRANT is used to grand users the privilege to access the data in their schema by other users. A user can grant permission to query the data in their schema by other users. ROLE is a set of privileges assigned to a user. The syntax for granting privileges is like:

`GRANT DML_OPERATION ON TABLE/VIEW TO USER/SCHEMA;`   
The DML can be select, insert, update, delete etc.   
eg:  
Suppose there is an employee schema, If the employee want to give access to the User3 he should use:

`GRANT SELECT ON Products TO User3;`   
For the User3 to be able to query a table in the 

employees schema he should use:

`SELECT * FROM employee.products;`   
To GRANT multiple privileges at the same time we can use:  
`GRANT SELECT, UPDATE, DELETE ON Products To User3, User4;`   
To revoke the privileges we use the following syntax:

`REVOKE DML_COMMAND ON TABLE/VIEW FROM USER/SCHEMA;`   
Eg:  
`REVOKE SELECT, UPDATE, DELETE ON Products FROM USER3, USER4;`   
The database administrator can grant certain privileges to certain roles using:

`CREATE ROLE role_name;`

`GRANT Privilege TO role_name;`   
We can assign a user a particular role using:  
`ALTER USER user_name default ROLE role_name;` 

**To get the current user/schema who is logged in to the database we use the following command:** 
`**SHOW USER;**`   
Alternatively we can use:  
`SELECT sys_context('USERENV', 'CURRENT_SCHEMA') FROM dual;`   
NOTE that the sys\_context is a function, also we should pass the arguments in capital letters inside single quotes.  
To get the current database container:  
`SELECT SYS_CONTEXT('USERENV','CON_NAME') FROM dual;`   
To switch to container database:

```javaScript
ALTER SESSION SET CONTAINER = CDB$ROOT;
```

To switch to pluggable database:  
`ALTER SESSION SET CONTAINER = ORCLPDB1;  
`To Create a pluggable database from docker container use the container id and run `docker exec -it 4530b80baa63 /bin/bash` Then run `sqlplus / as sysdba` then

```javaScript
CREATE PLUGGABLE DATABASE PDB1
   ADMIN USER pdb_admin IDENTIFIED BY pdb_admin_password
   ROLES = (CONNECT, RESOURCE)
   DEFAULT TABLESPACE users
   DATAFILE '/opt/oracle/oradata/ORCLCDB/pdb1/pdb1_users01.dbf'
   SIZE 100M AUTOEXTEND ON
   FILE_NAME_CONVERT = ('/opt/oracle/oradata/ORCLCDB/pdbseed/', '/opt/oracle/oradata/ORCLCDB/pdb1/');
```

After creating the pluggable database we need to open the pluggable database using:  
`ALTER PLUGGABLE DATABASE PDB1 OPEN;`   
After this we can switch to the pluggable database and execute queries.
