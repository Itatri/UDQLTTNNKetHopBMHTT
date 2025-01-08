-- 1.1. Tạo User có tên là quanlyTiengAnh 
-- Tao user quanlyTiengAnh
create user quanlyTiengAnh IDENTIFIED by 123

-- Cap quyen dang nhap quanlyTiengAnh
grant create session to quanlyTiengAnh

-- Cap quyen tao bang cho quanlyTiengAnh
grant create table to quanlyTiengAnh

-- Cap quyen nhap du lieu cho hoangvantri
alter user quanlyTiengAnh quota 100M on users

-- Cấp quyền CREATE PROCEDURE để có thể tạo hàm hoặc thủ tục
GRANT CREATE PROCEDURE TO quanlyTiengAnh;
-- Cấp quyền thực thi cho tất cả các hàm và thủ tục 
GRANT EXECUTE ANY PROCEDURE TO quanlyTiengAnh;
-- Kiểm tra lại quyền Sau khi cấp quyền, xác minh bằng lệnh
SELECT * FROM USER_SYS_PRIVS WHERE PRIVILEGE LIKE '%PROCEDURE%';
