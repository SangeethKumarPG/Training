-- SUM OF TWO NUMBERS
DECLARE
NUM1 NUMBER;
NUM2 NUMBER;
RESULT NUMBER;
BEGIN
    NUM1:=10;
    NUM2:=20;
    RESULT:=NUM1+NUM2;
    DBMS_OUTPUT.PUT_LINE('RESULT IS '||RESULT);
END;


-- SUM OF TWO NUMBERS WITH DYNAMIC INPUT
DECLARE
NUM1 NUMBER := :NUM1;
NUM2 NUMBER := : NUM2;
RESULT NUMBER;
BEGIN
    RESULT:=NUM1+NUM2;
    DBMS_OUTPUT.PUT_LINE('RESULT IS '||RESULT); --TO PERFORM OPERATIONS IN THE OUPUT STATEMENT ITSELF
END;                                            -- WE CAN USE (NUM1 + NUM2)


-- SUM DIFFERRENCE, PRODUCT OF TWO NUMBERS WHICH ARE READ DYNAMICALLY
DECLARE
NUM1 NUMBER:= :NUM1;
NUM2 NUMBER:= :NUM2;
SUM_RESULT NUMBER;
PROD_RESULT NUMBER;
SUB_RESULT NUMBER;
BEGIN
    SUM_RESULT := NUM1 + NUM2;
    SUB_RESULT := NUM1 - NUM2;
    PROD_RESULT := NUM1 * NUM2;
    DBMS_OUTPUT.PUT_LINE('SUM IS : '||SUM_RESULT);
    DBMS_OUTPUT.PUT_LINE('DIFFERRENCE IS : '||SUB_RESULT);
    DBMS_OUTPUT.PUT_LINE('PRODUCT IS : '||PROD_RESULT);
END;

-- DYNAMICALLY READING STRING VALUES
DECLARE
V_NAME VARCHAR2(30):=:V_NAME;
BEGIN
    DBMS_OUTPUT.PUT_LINE('THE STRING IS'||V_NAME);
END;

-- GETTING DATA FROM TABLE
DECLARE
V_EMPID EMP.EMPNO%TYPE; -- SAME TYPE AS THAT OF THE COLUMN OF EMPNO OF EMP TABLE
V_ENAME EMP.ENAME%TYPE;
BEGIN
    SELECT EMPNO, ENAME INTO V_EMPID, V_ENAME FROM EMP WHERE EMPNO=7839;
    DBMS_OUTPUT.PUT_LINE('THE EMPNO '||V_EMPID||' WITH NAME '||V_ENAME);
END;

-- GETTING DATA FROM TABLE WITH DYNAMIC INPUT
DECLARE
V_EMPID EMP.EMPNO%TYPE:=:V_EMPID; -- SAME TYPE AS THAT OF THE COLUMN OF EMPNO OF EMP TABLE
V_ENAME EMP.ENAME%TYPE;
BEGIN
    SELECT EMPNO, ENAME INTO V_EMPID, V_ENAME FROM EMP WHERE EMPNO=V_EMPID;
    DBMS_OUTPUT.PUT_LINE('THE EMPNO '||V_EMPID||' WITH NAME '||V_ENAME);
END;

-- COMPARE TWO NUMBERS
DECLARE
    NUM1 NUMBER:=:NUM1;
    NUM2 NUMBER:=:NUM2;
BEGIN 
    IF NUM1 < NUM2 THEN 
        DBMS_OUTPUT.PUT_LINE('NUM1 IS LESS THAN NUM2');
    ELSIF NUM1 = NUM2 THEN
        DBMS_OUTPUT.PUT_LINE('BOTH NUMBERS ARE EQUAL');
    ELSE
        DBMS_OUTPUT.PUT_LINE('NUM2 IS LESS THAN NUM1');
    END IF;
END;

-- CHECK IF -VE OR +VE
DECLARE
    NUM NUMBER:=:NUM;
BEGIN
    IF NUM > 0 THEN 
        DBMS_OUTPUT.PUT_LINE('NUMBER IS POSITIVE');
    ELSIF NUM = 0 THEN
        DBMS_OUTPUT.PUT_LINE('NUMBER IS ZERO');
    ELSE
        DBMS_OUTPUT.PUT_LINE('NUMBER IS NEGATIVE');
    END IF;
END;

-- ODD OR EVEN
DECLARE
NUM NUMBER :=:NUM;
BEGIN
    IF NUM MOD 2=0 THEN 
        DBMS_OUTPUT.PUT_LINE('NUMBER IS EVEN');
    ELSE 
        DBMS_OUTPUT.PUT_LINE('NUMBER IS ODD');
    END IF;
END;

-- GRADE FROM MARKS
DECLARE
TOTAL_MARKS NUMBER:=:TOTAL_MARKS;
PERCENTAGE NUMBER;
BEGIN
    PERCENTAGE:=(TOTAL_MARKS/100) * 100;
    IF PERCENTAGE >= 90 THEN
        DBMS_OUTPUT.PUT_LINE('GRADE : A');
    ELSIF PERCENTAGE <90 AND PERCENTAGE >= 80 THEN
        DBMS_OUTPUT.PUT_LINE('GRADE : B');
    ELSIF PERCENTAGE <80 AND PERCENTAGE >= 60 THEN
        DBMS_OUTPUT.PUT_LINE('GRADE : C');
    ELSIF PERCENTAGE <60 AND PERCENTAGE >= 50 THEN
        DBMS_OUTPUT.PUT_LINE('GRADE : D');
    ELSIF PERCENTAGE <50 AND PERCENTAGE >= 40 THEN
        DBMS_OUTPUT.PUT_LINE('GRADE : E');
    ELSE
        DBMS_OUTPUT.PUT_LINE('FAIL');
    END IF;
END;
     




