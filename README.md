# Description
This task will recap most of the basic concepts of this chapter but the solution for it is very similar to what we had been practicing in the videos. Your task is to:

1. Write the code for connecting to a server. You can connect to your local server if you have it hosted on your PC, if not, you can enter placeholder values in the connection string. The database name in the connection string should be `school`;
2. Make sure you are correctly closing the connection after use; Use either the `Close()` method or the `using` statement;
3. Enclose the relevant code into a try-catch block;
4. Execute the command for creating a new table called `teachers` which will have four columns namely `id`, `name`, `age`, `experience`. Use the following command: `CREATE TABLE teachers (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), age INT, experience FLOAT)`;
5. Execute the following three commands which will insert 3 rows into the database:
```sql
INSERT INTO teachers (name, age, experience) VALUES ('John Smith', 35, 5.5);
INSERT INTO teachers (name, age, experience) VALUES ('Anna Johnson', 40, 8.2);
INSERT INTO teachers (name, age, experience) VALUES ('Robert Davis', 32, 3.1);
```
6. Finally, read and display the data of the 3 rows. The column `name` is of type `String`, `age` is of type `Int32` and `experience` is of type `Float`;

### Hints
> **Hint 1:** You can use the GetFloat method of the `MySqlDataReader` for reading the `experience` column.
