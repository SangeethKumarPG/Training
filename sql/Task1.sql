SELECT * FROM STUDENT_DTL;

SELECT * FROM RESULT ORDER BY ADMN_NO;

SELECT * FROM EXAM_TBL;

SELECT * FROM SUBJECT_TBL;

    SELECT s.name, sb.subject_name, r.marks FROM  student_dtl s JOIN result r ON s.ADMN_NO = r.ADMN_NO JOIN subject_tbl sb ON sb.subj_id = r.SUBJ_ID where s.ADMN_NO=40004;



CREATE OR REPLACE PROCEDURE student_report(in_admn_no IN NUMBER) AS 
    s_name student_dtl.name%TYPE;
    subject subject_tbl.subject_name%TYPE;
    admn_number student_dtl.admn_no%TYPE;
    marks result.marks%TYPE;
    total_marks NUMBER :=0;
    number_of_subjects NUMBER :=0;
    percentage NUMBER:=0;
    grade VARCHAR2(3);
    CURSOR student_report_cursor IS SELECT s.name,s.admn_no, sb.subject_name, r.marks FROM  student_dtl s 
    JOIN result r ON s.ADMN_NO = r.ADMN_NO JOIN subject_tbl sb 
    ON sb.subj_id = r.SUBJ_ID WHERE s.admn_no = in_admn_no;
BEGIN
    OPEN student_report_cursor;
    FETCH student_report_cursor INTO s_name, admn_number,subject, marks;
    DBMS_OUTPUT.PUT_LINE('Name : '||s_name);
    DBMS_OUTPUT.PUT_LINE('ADMN NO : '||admn_number);
    CLOSE student_report_cursor;
    OPEN student_report_cursor;
    LOOP
        FETCH student_report_cursor INTO s_name, admn_number, admn_number,marks;
        EXIT WHEN student_report_cursor%NOTFOUND;
        DBMS_OUTPUT.PUT_LINE(subject||' : '||marks);
        total_marks:= total_marks + marks;
        number_of_subjects := number_of_subjects + 1;
    END LOOP;
    percentage := total_marks / (number_of_subjects * 100) * 100;
    DBMS_OUTPUT.PUT_LINE('Total Marks : '||total_marks);
    DBMS_OUTPUT.PUT_LINE('Percentage : '||percentage||'%');
    IF percentage >= 90 THEN
        DBMS_OUTPUT.PUT_LINE('Grade : A');
    ELSIF percentage <90 AND percentage >=80 THEN
        DBMS_OUTPUT.PUT_LINE('Grade : B');
    ELSIF percentage <80 AND percentage >=70 THEN
        DBMS_OUTPUT.PUT_LINE('Grade : C');
    ELSIF percentage <70 AND percentage >=60 THEN
        DBMS_OUTPUT.PUT_LINE('Grade : D');
    ELSIF percentage <60 AND percentage >=50 THEN
        DBMS_OUTPUT.PUT_LINE('Grade : E');
    ELSE
        DBMS_OUTPUT.PUT_LINE('Grade : FAIL');
    END IF;
    CLOSE student_report_cursor;
END;



BEGIN
    student_report(40001);
END;