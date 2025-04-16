-- Table based records
DECLARE
    v_emp_rec emp%ROWTYPE;
    BEGIN
        SELECT * INTO v_emp_rec FROM emp WHERE EMPNO=7839;
        DBMS_OUTPUT.PUT_LINE('Employee name : '||v_emp_rec.ename);
        DBMS_OUTPUT.PUT_LINE('Employee Role : '||v_emp_rec.job);
        DBMS_OUTPUT.PUT_LINE('Employee salary : '||v_emp_rec.sal);
    END;

-- Cursor based records
DECLARE
CURSOR emp_cursor IS SELECT * FROM EMP;
emp_record emp_cursor%ROWTYPE;
BEGIN
    OPEN emp_cursor;
    LOOP
        FETCH emp_cursor INTO emp_record;
        DBMS_OUTPUT.PUT_LINE('Employee name : '||emp_record.ename);
        DBMS_OUTPUT.PUT_LINE('Employee id : '|| emp_record.empno);
        DBMS_OUTPUT.PUT_LINE('Employee salary : '||emp_record.sal);
        DBMS_OUTPUT.NEW_LINE();
        EXIT WHEN emp_cursor%NOTFOUND;
    END LOOP;
END;

-- User defined records
DECLARE

TYPE emp_record_type IS RECORD(ename VARCHAR2(10), empno NUMBER(4), sal NUMBER(7,2));
emp_record emp_record_type;
BEGIN
    SELECT ename, empno, sal into emp_record FROM emp WHERE ename LIKE 'KI%';
    DBMS_OUTPUT.PUT_LINE('Employee name : '||emp_record.ename);
    DBMS_OUTPUT.PUT_LINE('Employee id : '|| emp_record.empno);
    DBMS_OUTPUT.PUT_LINE('Employee salary : '||emp_record.sal);
END;

-- Bulk collection
DECLARE
    TYPE emp_record_type  IS RECORD(ename VARCHAR2(10), empno NUMBER(4), sal NUMBER(7,2));
    TYPE table_record_type IS TABLE of emp_record_type;
    table_emp_record table_record_type;
    BEGIN
        SELECT ename, empno, sal BULK COLLECT INTO table_emp_record FROM emp;
        DBMS_OUTPUT.PUT_LINE('Employee Data');
        FOR i IN table_emp_record.FIRST..table_emp_record.LAST
        LOOP
            DBMS_OUTPUT.PUT_LINE(table_emp_record(i).empno||' : '||table_emp_record(i).ename||' is having salary of $'||table_emp_record(i).sal);
            DBMS_OUTPUT.NEW_LINE();
        END LOOP;
    END;

-- Bulk collect used for limiting
DECLARE
row_limit CONSTANT PLS_INTEGER DEFAULT 2;
CURSOR emp_cursor IS SELECT * FROM emp;
TYPE emp_table_type IS TABLE OF emp%ROWTYPE INDEX BY BINARY_INTEGER;
emp_table emp_table_type; 
BEGIN
    OPEN emp_cursor;
    LOOP
        FETCH emp_cursor BULK COLLECT INTO emp_table LIMIT row_limit;
        DBMS_OUTPUT.PUT_LINE('Retrieved Rows'||emp_table.count);
        FOR i IN 1..emp_table.count
        LOOP
            DBMS_OUTPUT.PUT_LINE(emp_table(i).empno||' - '||emp_table(i).ename);
            DBMS_OUTPUT.NEW_LINE();
        END LOOP;
        EXIT WHEN emp_table.count = 0;
    END LOOP;
    CLOSE emp_cursor;
END;


