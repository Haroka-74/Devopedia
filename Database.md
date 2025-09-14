<div style = "font-family: 'Roboto', sans-serif;">

# Fundamentals

- [Database Roadmap 2024](https://www.youtube.com/watch?v=GBeWKa1Lc6I)
- [Database Design](https://www.youtube.com/watch?v=gZ5iYMkrcfQ)
    - Entities ⟶ `strong` `weak`.
    - Attributes ⟶ `simple` `composite` `single-valued` `multi-valued` `derived` `stored` `key` `complex`.
- [Relationships in ER Diagrams](https://www.youtube.com/watch?v=hp1gX4kh3lw)
- [Extended ER Features](https://www.youtube.com/watch?v=uujDdvDQsaE)
- [Extended ER Constraints](https://www.youtube.com/watch?v=aLMb2HppQZw)
- [Introduction to Relational Data Model](https://www.youtube.com/watch?v=Q45sr5p_NmQ)
- [Characteristics of Relations](https://www.youtube.com/watch?v=J4hZbuTLyhI)
- [Instances and Schemas in DBMS](https://www.youtube.com/watch?v=cOzq67n2yN4)
- [Three-Schema Architecture and Data Independence](https://www.youtube.com/watch?v=vuXnRRG-m5M)
- [Relational Model Constraints](https://www.youtube.com/watch?v=uPOGPL2C0_8)
    - [Dealing with Constraint Violations](https://www.youtube.com/watch?v=lMthy1iwR3s)
    - Cascade Deletes ⟶ `CASCADE` `RESTRICT` `SET NULL` `SET DEFAULT` `NO ACTION`.
- [Database Keys](https://www.youtube.com/watch?v=kgpiD3Z_swg)
- [Database Normalization](https://www.youtube.com/watch?v=1HEHa_EJa0k)
- [Relational Algebra](https://www.youtube.com/watch?v=OuFS0tcQXh8)

# Storage

- [Database Storage 01](https://www.youtube.com/watch?v=-HtHhBQbMB4)
- [Database Storage 02](https://www.youtube.com/watch?v=8-LJyyAjOhE)

# Indexes

- [B and B+ Trees](https://www.youtube.com/watch?v=1ZhBULsbZGw)
- [Hash and Composite Indexes](https://www.youtube.com/watch?v=ddWoqXw6Qic)
- [Intersection, Union, Clustered vs. Non-Clustered](https://www.youtube.com/watch?v=KTEViriyc-Q)
- [Indexing Questions](https://www.youtube.com/watch?v=wY_SxRMLTvA)

# Transactions

- [Database Transactions](https://www.youtube.com/watch?v=ziH5Y4tvQJE)
    - [Understanding SQL Transactions](https://www.datacamp.com/tutorial/sql-transactions)
- [Transaction Atomicity](https://www.datacamp.com/tutorial/atomicity)
- [Transaction Consistency](https://en.wikipedia.org/wiki/Consistency_(database_systems))
    - [Strong Consistency vs. Eventual Consistency](https://www.youtube.com/watch?v=WZqGS-wczaY)
- [Transaction Isolation](https://en.wikipedia.org/wiki/Isolation_(database_systems))
- [Transaction Durability](https://en.wikipedia.org/wiki/Durability_(database_systems))
    - [Transaction Durability](https://medium.com/@jayantnehra18/database-fundamentals-durability-in-transactions-ef7d907b01c6)
- [Transaction Schedules](https://www.youtube.com/watch?v=KRZTwTWiUek&list=PLE8kQVoC67PzGwMMsSk3C8MvfAqcYjusF&index=19)

# Concurrency Control

- [Two-Phase Locking 01](https://www.youtube.com/watch?v=s8w-GplT6K4)
- [Two-Phase Locking 02](https://www.youtube.com/watch?v=4Ll7zlC9f4w)
- [Timestamp Ordering and Optimistic Concurrency Control](https://www.youtube.com/watch?v=f6sl5XFnAr4)
- [Multiversion Concurrency Control](https://www.youtube.com/watch?v=RDry1RyIw1s)

# Partitioning vs. Sharding

- [Data Partitioning](https://www.youtube.com/watch?v=XnCnIWMxEhA)
    - [Data Partitioning](https://www.datacamp.com/blog/what-is-data-partitioning)
- [Distributed Databases](https://www.youtube.com/watch?v=LujY8mdibGk)
    - [Distributed Database Architecture](https://www.scylladb.com/glossary/distributed-database-architecture)
- [Database Sharding](https://www.youtube.com/watch?v=-GXQwCIRANA)

# Columnar Databases

- [Columnar Databases 01](https://www.youtube.com/watch?v=8bDJPLhleeo)
- [Columnar Databases 02](https://www.youtube.com/watch?v=4IJ9hK4BuiI)

# SQL Practice

### `WHERE`

- [1683. Invalid Tweets](https://leetcode.com/problems/invalid-tweets)
- [584. Find Customer Referee](https://leetcode.com/problems/find-customer-referee)
- [1148. Article Views I](https://leetcode.com/problems/article-views-i)
- [1527. Patients With a Condition](https://leetcode.com/problems/patients-with-a-condition)
- [1517. Find Users With Valid E-Mails](https://leetcode.com/problems/find-users-with-valid-e-mails)
- [626. Exchange Seats](https://leetcode.com/problems/exchange-seats)
- [176. Second Highest Salary](https://leetcode.com/problems/second-highest-salary)
- [1978. Employees Whose Manager Left the Company](https://leetcode.com/problems/employees-whose-manager-left-the-company)
- [1907. Count Salary Categories](https://leetcode.com/problems/count-salary-categories)

### `JOIN`

- [1068. Product Sales Analysis I](https://leetcode.com/problems/product-sales-analysis-i)
- [1378. Replace Employee ID With The Unique Identifier](https://leetcode.com/problems/replace-employee-id-with-the-unique-identifier)
- [196. Delete Duplicate Emails](https://leetcode.com/problems/delete-duplicate-emails)
- [577. Employee Bonus](https://leetcode.com/problems/employee-bonus)
- [197. Rising Temperature](https://leetcode.com/problems/rising-temperature)
- [180. Consecutive Numbers](https://leetcode.com/problems/consecutive-numbers)

### `GROUP BY`

- [1045. Customers Who Bought All Products](https://leetcode.com/problems/customers-who-bought-all-products)
- [1633. Percentage of Users Attended a Contest](https://leetcode.com/problems/percentage-of-users-attended-a-contest)
- [1484. Group Sold Products By The Date](https://leetcode.com/problems/group-sold-products-by-the-date)
- [602. Friend Requests II: Who Has the Most Friends](https://leetcode.com/problems/friend-requests-ii-who-has-the-most-friends)
- [1193. Monthly Transactions I](https://leetcode.com/problems/monthly-transactions-i)

### `Miscellaneous`

- [570. Managers with at Least 5 Direct Reports](https://leetcode.com/problems/managers-with-at-least-5-direct-reports)
- [1204. Last Person to Fit in the Bus](https://leetcode.com/problems/last-person-to-fit-in-the-bus)
- [619. Biggest Single Number](https://leetcode.com/problems/biggest-single-number)
- [1581. Customer Who Visited but Did Not Make Any Transactions](https://leetcode.com/problems/customer-who-visited-but-did-not-make-any-transactions)
- [1075. Project Employees I](https://leetcode.com/problems/project-employees-i)
- [185. Department Top Three Salaries](https://leetcode.com/problems/department-top-three-salaries)
- [1327. List the Products Ordered in a Period](https://leetcode.com/problems/list-the-products-ordered-in-a-period)
- [1731. The Number of Employees Which Report to Each Employee](https://leetcode.com/problems/the-number-of-employees-which-report-to-each-employee)
- [1251. Average Selling Price](https://leetcode.com/problems/average-selling-price)
- [1934. Confirmation Rate](https://leetcode.com/problems/confirmation-rate)
- [1661. Average Time of Process per Machine](https://leetcode.com/problems/average-time-of-process-per-machine)
- [1789. Primary Department for Each Employee](https://leetcode.com/problems/primary-department-for-each-employee)
- [1174. Immediate Food Delivery II](https://leetcode.com/problems/immediate-food-delivery-ii)
- [1280. Students and Examinations](https://leetcode.com/problems/students-and-examinations)
- [550. Game Play Analysis IV](https://leetcode.com/problems/game-play-analysis-iv)
- [1164. Product Price at a Given Date](https://leetcode.com/problems/product-price-at-a-given-date)
- [585. Investments in 2016](https://leetcode.com/problems/investments-in-2016)
- [1321. Restaurant Growth](https://leetcode.com/problems/restaurant-growth)
- [1341. Movie Rating](https://leetcode.com/problems/movie-rating)

# Indexes Practice

```sql
CREATE TABLE test (
    id SERIAL PRIMARY KEY,
    a INTEGER,
    b INTEGER,
    c VARCHAR(100),
    d TIMESTAMP,
    created_at TIMESTAMP DEFAULT NOW()
);
```
```sql
INSERT INTO test (a, b, c, d, created_at)
SELECT
    floor(random() * 1000)::integer as a,
    floor(random() * 5000)::integer as b,
    (
        SELECT string_agg
        (
            substr('ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789',
            ceil(random() * 62)::integer, 1), ''
        )
        FROM generate_series(1, floor(random() * 50 + 1)::integer)) as c,
    NOW() - (random() * INTERVAL '365 days') as d,
    NOW() - (random() * INTERVAL '365 days') as created_at
FROM generate_series(1, 10000);
```
```sql
CREATE INDEX a_idx ON test(a);

EXPLAIN SELECT MIN(a) FROM test;
EXPLAIN SELECT MAX(a) FROM test;
```
```sql
CREATE INDEX a_idx ON test(a DESC);

EXPLAIN SELECT MIN(a) FROM test;
EXPLAIN SELECT MAX(a) FROM test;
```
```sql
CREATE INDEX a_idx ON test(a);

EXPLAIN SELECT * FROM test WHERE a = 500;
EXPLAIN SELECT * FROM test WHERE a != 500;

EXPLAIN SELECT * FROM test WHERE a BETWEEN 500 AND 1000;
EXPLAIN SELECT * FROM test WHERE a NOT BETWEEN 500 AND 1000;

EXPLAIN SELECT * FROM test WHERE a IN (100, 200, 300);
EXPLAIN SELECT * FROM test WHERE a NOT IN (100, 200, 300);
```
```sql
CREATE INDEX b_idx ON test(b);

EXPLAIN SELECT * FROM test ORDER BY b ASC;
EXPLAIN SELECT * FROM test ORDER BY b DESC;
```
```sql
CREATE INDEX b_idx ON test(b DESC);

EXPLAIN SELECT * FROM test ORDER BY b ASC;
EXPLAIN SELECT * FROM test ORDER BY b DESC;
```
```sql
CREATE INDEX b_idx ON test(b) INCLUDE (created_at);

EXPLAIN SELECT b FROM test WHERE b = 500;
EXPLAIN SELECT created_at FROM test WHERE b = 500;
EXPLAIN SELECT b, created_at FROM test WHERE b = 500;
EXPLAIN SELECT COUNT(*) FROM test WHERE b = 500;
```
```sql
-- Collation: The set of rules that determines how strings are compared and ordered.

-- This index uses the column's default collation (usually inherited from the database or column definition).
CREATE INDEX c_idx ON test(c);

-- This index explicitly uses the "C" collation, which means binary ordering based on byte values.
CREATE INDEX c_idx_collation ON test (c COLLATE "C");

EXPLAIN SELECT * FROM test WHERE c LIKE '54CVf5SFLMBYc';
EXPLAIN SELECT * FROM test WHERE c LIKE '54CVf5SFLM%';
EXPLAIN SELECT * FROM test WHERE c LIKE '54CVf5S%LMBYc';
EXPLAIN SELECT * FROM test WHERE c LIKE '%4CVf5SFLMBYc';
EXPLAIN SELECT * FROM test WHERE c LIKE '54CVf5SFLMBY_';
EXPLAIN SELECT * FROM test WHERE c LIKE '54CVf5S_LMBYc';
EXPLAIN SELECT * FROM test WHERE c LIKE '_4CVf5SFLMBYc';
```

</div>