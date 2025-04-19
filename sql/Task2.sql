CREATE TABLE project(project_id NUMBER PRIMARY KEY, project_name VARCHAR2(30), start_date DATE, end_date DATE);

CREATE TABLE emp_project(emp_id NUMBER, project_id NUMBER, role VARCHAR2(30), allocation_number NUMBER,
FOREIGN KEY(emp_id) REFERENCES emp(empno),
FOREIGN KEY(project_id) REFERENCES project(project_id)
);

SELECT * FROM project;

INSERT INTO project VALUES(10001, 'Sample Project 1', '19/03/2002', '25/06/2003');
INSERT INTO project VALUES(10002, 'Sample Project 2', '28/03/2005', '22/06/2008');
INSERT INTO project VALUES(10003, 'Sample Project 3', '01/03/2004', '02/10/2005');
INSERT INTO project VALUES(10004, 'Sample Project 4', '14/12/2005', '08/07/2009');
INSERT INTO project VALUES(10005, 'Sample Project 5', '04/01/2007', '09/09/2010');
    
SELECT * FROM EMP;

INSERT INTO emp_project VALUES(7698, 10001,'MANAGER',4001);
INSERT INTO emp_project VALUES(7722, 10001,'ANALYST',4002);
INSERT INTO emp_project VALUES(7876, 10001,'CLERK',4003);
INSERT INTO emp_project VALUES(7902, 10001,'ANALYST',4004);
INSERT INTO emp_project VALUES(7566, 10002,'MANAGER',4005);

SELECT * FROM emp_project;