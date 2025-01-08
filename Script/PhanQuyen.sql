--connect: sys--
create or replace package pkg_CrUser
as 
    procedure pro_create_user(username in varchar2, pass in varchar2);
    
    procedure pro_alter_user(username in varchar2, pass in varchar2);
    
    function fun_check_account(username in varchar2) return int;
    
    procedure Pro_CrUser(username in varchar2, pass in varchar2);
end pkg_CrUser;


create or replace package body pkg_CrUser
as 
    procedure pro_create_user(username in varchar2, pass in varchar2) is
    begin
        execute immediate 'create user ' || username || ' identified by ' || pass
                          || ' quota 10M on USERS';
        execute immediate 'grant create session to ' || username;
    end pro_create_user;
    
    procedure pro_alter_user(username in varchar2, pass in varchar2) is
    begin
        execute immediate 'alter user ' || username || ' identified by ' || pass;
    end pro_alter_user;
    
    function fun_check_account(username in varchar2) 
    return int
    is
        t varchar2(50);
        kq int;
    begin 
        select account_status into t from dba_users where username = upper(username);
        if t is null then
            kq := 0;
        else
            kq := 1;
        end if;
        return kq;
    exception when others then
        kq := 0;
        return kq;
    end fun_check_account;
    
    procedure Pro_CrUser(username in varchar2, pass in varchar2)
    is
        ckUser int := fun_check_account(username);
    begin
        if ckUser = 0 then
            pro_create_user(username, pass);
        else 
            pro_alter_user(username, pass);
        end if;
    end Pro_CrUser;
end pkg_CrUser;

grant execute on pkg_CrUser to sysuser;
grant select on dba_users to sysuser;

begin
    sys.pkg_CrUser.Pro_CrUser('JOHN', '123');
end;
----------
create or replace package pkg_PhanQuyen
as  
    --1
    procedure pro_select_procedure_user (useowner in varchar2, pro_type in varchar2, cur out sys_refcursor); 
    --2
    procedure pro_select_user (cur out sys_refcursor);
    --3 
    procedure pro_select_roles (cur out sys_refcursor); 
    --4 
    procedure pro_user_roles (username in varchar2, cur out sys_refcursor);  
    --5
    procedure pro_user_roles_check(username in varchar2, roles in varchar2, cout out number);   
    --6   
    procedure pro_select_table (usename in varchar2, cur out sys_refcursor);  
    --7
    procedure pro_select_grant(username in varchar2, userschema in varchar2, tablename in varchar2, cur out sys_refcursor);
    --8
    procedure pro_select_grant_user (username in varchar2, cur out sys_refcursor);  
    --9
    procedure pro_grant_revoke (username in varchar2, schema_user in varchar2, pro_tab in varchar2, type_pro in varchar2, dk in number);
    --10
    procedure pro_grant_revoke_Roles (username in varchar2, roles in varchar2, dk in number);
end;

create or replace package body pkg_PhanQuyen
as
    --1
    procedure pro_select_procedure_user (useowner in varchar2, pro_type in varchar2, cur out sys_refcursor)
    is
    begin 
        open cur for
            select object_name from dba_procedures where owner = useowner and object_type = pro_type;
    end;
    --2
    procedure pro_select_user (cur out sys_refcursor)
    is
    begin 
        open cur for
            select username from dba_users where account_status = 'OPEN';
    end;
    --3
    procedure pro_select_roles (cur out sys_refcursor)
    is
    begin 
        open cur for
            select role from dba_roles;
    end;
    --4
    procedure pro_user_roles (username in varchar2, cur out sys_refcursor)
    is
    begin 
        open cur for
            select granted_role from dba_role_privs where grantee = username;
    end;
    --5
    procedure pro_user_roles_check(username in varchar2, roles in varchar2, cout out number)
    is
    begin 
        select COUNT(*) into cout from dba_role_privs where grantee = username and granted_role = roles;
    end;
    --6
    procedure pro_select_table (usename in varchar2, cur out sys_refcursor)
    is
    begin 
        open cur for
            select table_name from dba_all_tables where owner = usename;
    end;
    --7
    procedure pro_select_grant(username in varchar2, userschema in varchar2, tablename in varchar2, cur out sys_refcursor)
    is
    begin 
        open cur for
            select privilege from dba_tab_privs where grantee = username and table_name = tablename and owner = userschema;
    end;
    --8
    procedure pro_select_grant_user (username in varchar2, cur out sys_refcursor)
    is
    begin 
        open cur for
            select table_name, type, owner from dba_tab_privs where grantee = username and type in ('PROCEDURE', 'FUNCTION', 'PACKAGE');
    end;
    --9
    procedure pro_grant_revoke (username in varchar2, schema_user in varchar2, 
                                pro_tab in varchar2, type_pro in varchar2, dk in number)
    is
    begin 
        if dk = 1 then 
            execute immediate 'grant ' || type_pro || ' on ' || schema_user || '.' || pro_tab || ' to ' || username;
        else 
            execute immediate 'revoke ' || type_pro || ' on ' || schema_user || '.' || pro_tab || ' from ' || username;
        end if;
    end;
    --10
    procedure pro_grant_revoke_Roles (username in varchar2, roles in varchar2, dk in number)
    is
    begin 
        if dk = 1 then 
            execute immediate 'grant ' || roles || ' to ' || username;
        else 
            execute immediate 'revoke ' || roles || ' from ' || username;
        end if;
    end;
end;


