CREATE OR REPLACE PACKAGE emp_package IS
    v_bonus_rate NUMBER := 0.10;
    PROCEDURE add_emp(emp_id IN NUMBER, emp_name IN VARCHAR2, emp_job IN VARCHAR2, 
    emp_doj IN DATE, emp_sal IN NUMBER, emp_comm IN NUMBER, dept_id IN NUMBER);

    FUNCTION calculate_bonus(sal IN NUMBER) RETURN NUMBER;
END emp_package;

CREATE OR REPLACE PACKAGE BODY emp_package IS
    PROCEDURE add_emp(emp_id IN NUMBER, emp_name IN VARCHAR2, emp_job IN VARCHAR2, 
    emp_doj IN DATE, emp_sal IN NUMBER, emp_comm IN NUMBER, dept_id IN NUMBER) IS BEGIN
    INSERT INTO emp(empno, ename, job,hiredate, sal, comm, deptno) VALUES(emp_id, emp_name, emp_job, emp_doj, emp_sal, emp_comm, dept_id);
    DBMS_OUTPUT.PUT_LINE('Employee '||emp_name||' added successfully!');
    END;

    FUNCTION calculate_bonus(sal in NUMBER) RETURN NUMBER IS bonus number;
    BEGIN
        bonus:= sal * v_bonus_rate;
        return bonus;
    END;
END emp_package;

SELECT * from EMP;

BEGIN
    EMP_PACKAGE.ADD_EMP(4010, 'Tinto', 'Manager', SYSDATE, 50000, 3000, 30);
END;

DECLARE
    emp_sal EMP.SAL%TYPE;
    bonus NUMBER;
BEGIN
    SELECT SAL INTO emp_sal FROM emp WHERE ENAME LIKE 'Tin%';
    bonus := EMP_PACKAGE.CALCULATE_BONUS(emp_sal);
    DBMS_OUTPUT.PUT_LINE('Bonus is : '||bonus);
END;