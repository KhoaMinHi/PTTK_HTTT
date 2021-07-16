create user giaovu;
alter user giaovu identified by 1;
grant create session to giaovu;

create user thungan identified by 1;
grant create session to thungan;

create user hocvien identified by 1;
grant create session to hocvien;

/*/user chứa các bảng để tiện sử dụng
create user trungtam identified by 1;
grant create table to trungtam;
grant create session to trungtam;
grant unlimited tablespace to trungtam;


select * from hocvien;
select * from dba_tables;*/