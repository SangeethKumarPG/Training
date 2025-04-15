create table emp_backup
   as
      select *
        from emp;

select *
  from emp_backup;

create or replace trigger tgr_del_emp before
   delete on emp
   for each row
begin
   insert into emp_backup values ( :old.empno,
                                   :old.ename,
                                   :old.job,
                                   :old.mgr,
                                   :old.hiredate,
                                   :old.sal,
                                   :old.comm,
                                   :old.deptno );
end;

delete from emp_backup;

select *
  from emp;

delete from emp
 where empno = 7839;
insert into emp values ( 9866,
                         'RAHUL',
                         'G',
                         7839,
                         '12/11/98',
                         1,
                         null,
                         30 );

delete from emp
 where empno = 9876;

drop trigger tgr_del_emp;

create or replace trigger tgr_emp_insert after
   insert on emp
   for each row
begin
   dbms_output.put_line('TRIGGER : A new record is inserted');
end;

create or replace trigger tgr_update_emp after
   update on emp
   for each row
begin
   dbms_output.put_line('TRIGGER: Data Updated');
end;

update emp
   set
   comm = 2
 where comm = 1;

--------------------------------EXCEPTIONS----------------------------------------------------
declare
   empno   emp.empno%type;
   empname emp.ename%type;
begin
   select ename
     into empname
     from emp
    where empno = 7839;
exception
   when no_data_found then
      dbms_output.put_line('EXCEPTION :::EMPNO: Doesnt exist');
end;

-------- RAISING EXCEPTIONS------------------------------------------------

declare
   emp_name emp.ename%type;
   emp_sal  emp.sal%type;
   emp_job  emp.job%type;
   cursor emp_dname_cursor (
      dept_no number
   ) is
   select ename,
          sal,
          job
     from emp
    where deptno = dept_no;
begin
   open emp_dname_cursor(33);
   fetch emp_dname_cursor into
      emp_name,
      emp_sal,
      emp_job;
   if emp_dname_cursor%notfound then
      raise no_data_found;
   else
      loop
         fetch emp_dname_cursor into
            emp_name,
            emp_sal,
            emp_job;
         dbms_output.put_line('NAME: '
                              || emp_name
                              || ' SAL: '
                              || emp_sal
                              || ' JOB:'
                              || emp_job);
         exit when emp_dname_cursor%notfound;
      end loop;
   end if;
   dbms_output.put_line('ROWS FETCHED ' || emp_dname_cursor%rowcount);
   close emp_dname_cursor;
exception
   when no_data_found then
      dbms_output.put_line('No Employees in the given department');
end;

select *
  from student_dtl;
create or replace view product_view as
   select *
     from student_dtl;


select *
  from product_view;

insert into product_view values ( 4006,
                                  'Arjun',
                                  '2243/21 Mumbai',
                                  8811229008,
                                  '01/01/2000',
                                  'M',
                                  'CLS004',
                                  '11/05/2000',
                                  76 );

select e.empno,
       e.ename,
       e.job,
       e.hiredate,
       e.sal,
       e.comm,
       d.deptno,
       d.dname,
       d.loc
  from emp e
  join dept d
on e.deptno = d.deptno;

create or replace view emp_x_dept as
   select e.empno,
          e.ename,
          e.job,
          e.hiredate,
          e.sal,
          e.comm,
          d.deptno,
          d.dname,
          d.loc
     from emp e
     join dept d
   on e.deptno = d.deptno;

select *
  from emp_x_dept;

--- don't work beacuse we cannot insert values through views into multiple tables by default
insert into emp_x_dept values ( 7722,
                                'KUMAR',
                                'ANALYST',
                                '02/02/2000',
                                3500,
                                100,
                                30,
                                'SALES',
                                'CHICAGO' );


create or replace trigger trg_empdp_vw instead of
   insert on emp_x_dept
declare
   check_exists number;
begin
   select count(*)
     into check_exists
     from dept d
    where d.deptno = :new.deptno;
   if check_exists = 0 then
      insert into dept (
         deptno,
         dname,
         loc
      ) values ( :new.deptno,
                 :new.dname,
                 :new.loc );
   end if;
   insert into emp (
      empno,
      ename,
      job,
      hiredate,
      sal,
      comm,
      deptno
   ) values ( :new.empno,
              :new.ename,
              :new.job,
              :new.hiredate,
              :new.sal,
              :new.comm,
              :new.deptno );
end;

-- works
insert into emp_x_dept values ( 7722,
                                'KUMAR',
                                'ANALYST',
                                '02/02/2000',
                                3500,
                                100,
                                30,
                                'SALES',
                                'CHICAGO' );

select *
  from emp_x_dept;
select *
  from dept;

select *
  from student_dtl;
select *
  from class_tbl;
select *
  from teacher_tbl;

select s.admn_no,
       s.name,
       s.address,
       s.phone,
       s.dob,
       s.gender,
       c.class_id,
       c.class_name,
       c.section
  from student_dtl s
  join class_tbl c
on c.class_id = s.class_id;

create or replace view student_x_class as
   select s.admn_no,
          s.name,
          s.address,
          s.phone,
          s.dob,
          s.gender,
          c.class_id,
          c.class_name,
          c.section
     from student_dtl s
     join class_tbl c
   on c.class_id = s.class_id;

select *
  from student_x_class;

create or replace trigger student_class_trg instead of
   insert on student_x_class
declare
   check_class_exists number;
begin
   select count(*)
     into check_class_exists
     from class_tbl c
    where c.class_id = :new.class_id;
   if check_class_exists = 0 then
      insert into class_tbl (
         class_id,
         class_name,
         section
      ) values ( :new.class_id,
                 :new.class_name,
                 :new.section );
   end if;
   insert into student_dtl (
      admn_no,
      name,
      address,
      phone,
      dob,
      gender,
      class_id
   ) values ( :new.admn_no,
              :new.name,
              :new.address,
              :new.phone,
              :new.dob,
              :new.gender,
              :new.class_id );
end;

insert into student_x_class values ( 4007,
                                     'Rahul P',
                                     'Address',
                                     8876124450,
                                     '20/11/2000',
                                     'M',
                                     'CLS005',
                                     '5TH STANDARD',
                                     'E' );