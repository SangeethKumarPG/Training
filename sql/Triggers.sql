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