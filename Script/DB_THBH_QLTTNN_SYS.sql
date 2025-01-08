CREATE TABLE HOCVIEN
(
    MAHV CHAR(15) NOT NULL,
    HOTENHV NVARCHAR2(50),
    GIOITINH NVARCHAR2(5),
    DIACHI NVARCHAR2(50),
    EMAIL CHAR(50),
    SDT CHAR(10),
    CONSTRAINT PK_HOCVIEN PRIMARY KEY (MAHV)
);


CREATE TABLE LOPHOCPHAN
(
    MALOPHP CHAR(15) NOT NULL,
    TENLOPHP NVARCHAR2(50),
    TENKHOA NVARCHAR2(50),
    NGAYKHAIGIANG DATE,
    NGAYKT DATE,
    LICHHOC NVARCHAR2(50),
    SISO NUMBER,
    HOCPHI NUMBER,
    CONSTRAINT PK_LOPHOCPHAN PRIMARY KEY (MALOPHP)
);

CREATE TABLE DIEMDANH
(
    NGAYVANG TIMESTAMP NOT NULL,
    MAHV CHAR(15) NOT NULL,
    MALOPHP CHAR(15),
    CONSTRAINT PK_DIEMDANH PRIMARY KEY (MAHV, NGAYVANG),
    CONSTRAINT FK_DIEMDANH_HOCVIEN FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
    CONSTRAINT FK_DIEMDANH_LOPHOCPHAN FOREIGN KEY (MALOPHP) REFERENCES LOPHOCPHAN(MALOPHP)
);


CREATE TABLE HOCTAP
(
    MABT CHAR(15) NOT NULL,
    MAHV CHAR(15) NOT NULL,
    DIEM NUMBER,
    DIEMTOIDA NUMBER,
    MALOPHP CHAR(15),
    CONSTRAINT PK_HOCTAP PRIMARY KEY (MABT, MAHV),
    CONSTRAINT FK_HOCTAP_HOCVIEN FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
    CONSTRAINT FK_HOCTAP_LOPHOCPHAN FOREIGN KEY (MALOPHP) REFERENCES LOPHOCPHAN(MALOPHP)
);


CREATE TABLE PHANLOP
(
    MALOPHP CHAR(15) NOT NULL,
    MAHV CHAR(15) NOT NULL,
    CONSTRAINT PK_PHANLOP PRIMARY KEY (MALOPHP, MAHV),
    CONSTRAINT FK_PHANLOP_HOCVIEN FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
    CONSTRAINT FK_PHANLOP_LOPHOCPHAN FOREIGN KEY (MALOPHP) REFERENCES LOPHOCPHAN(MALOPHP)
);

CREATE TABLE GIAOVIEN
(
    MAGV CHAR(15) NOT NULL,
    TENGV NVARCHAR2(50),
    TENTKGV CHAR(30),
    MATKHAU CHAR(20),
    CONSTRAINT PK_GIAOVIEN PRIMARY KEY (MAGV)
);

CREATE TABLE PHANCONG
(
    MAGV CHAR(15) NOT NULL,
    MALOPHP CHAR(15) NOT NULL,
    CONSTRAINT PK_PHANCONG PRIMARY KEY (MAGV, MALOPHP),
    CONSTRAINT FK_PHANCONG_LOPHOCPHAN FOREIGN KEY (MALOPHP) REFERENCES LOPHOCPHAN(MALOPHP),
    CONSTRAINT FK_PHANCONG_GIAOVIEN FOREIGN KEY (MAGV) REFERENCES GIAOVIEN(MAGV)
);


CREATE TABLE KHUYENMAI
(
    MAKM CHAR(15) NOT NULL,
    SOHVNHOM NUMBER,
    SOTIENGIAM NUMBER,
    CONSTRAINT PK_KHUYENMAI PRIMARY KEY (MAKM)
);


CREATE TABLE NHANVIEN
(
    TENTKNV CHAR(30) NOT NULL,
    MATKHAU CHAR(20),
    CONSTRAINT PK_NHANVIEN PRIMARY KEY (TENTKNV)
);

CREATE TABLE HOADON
(
    MAHD CHAR(15) NOT NULL,
    MAHV CHAR(15),
    NGAYLAP TIMESTAMP,
    MALOPHP CHAR(15),
    MAKM CHAR(15),
    TENTKNV CHAR(30),
    THANHTIEN NUMBER,
    CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
    CONSTRAINT FK_HOADON_HOCVIEN FOREIGN KEY (MAHV) REFERENCES HOCVIEN(MAHV),
    CONSTRAINT FK_HOADON_LOPHOCPHAN FOREIGN KEY (MALOPHP) REFERENCES LOPHOCPHAN(MALOPHP),
    CONSTRAINT FK_HOADON_KHUYENMAI FOREIGN KEY (MAKM) REFERENCES KHUYENMAI(MAKM),
    CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (TENTKNV) REFERENCES NHANVIEN(TENTKNV)
);

--=========================================================== DỮ LIỆU ==========================================================

INSERT INTO HOCVIEN VALUES ('HV001', N'Trương Lê Bảo Trân', N'Nữ', N'Long An', 'truonglebaotran2201@gmail.com', '0916649072');
INSERT INTO HOCVIEN VALUES ('HV002', N'Phan Trần Minh Tâm', N'Nữ', N'Tây Ninh', 'phantranminhtam1802@gmail.com', '0987138914');
INSERT INTO HOCVIEN VALUES ('HV003', N'Phan Thế Thanh', N'Nam', N'TPHCM', 'phanthethanh0209@gmail.com', '0928366736');
INSERT INTO HOCVIEN VALUES ('HV004', N'Nguyễn Minh Trí', N'Nam', N'Bến Tre', 'nguyenminhtri2404@gmail.com', '0928723561');
INSERT INTO HOCVIEN VALUES ('HV005', N'Lê Viết Tuấn Khải', N'Nam', N'Củ Chi', 'leviettuankhai1002@gmail.com', '0928163618');
INSERT INTO HOCVIEN VALUES ('HV006', N'Hồ Minh Quang', N'Nam', N'Bến Tre', 'hominhquang2903@gmail.com', '0923588195');
INSERT INTO HOCVIEN VALUES ('HV007', N'Hoàng Thị Trường An', N'Nữ', N'Long An', 'hoangthitruongan0211@gmail.com', '0917298137');

INSERT INTO LOPHOCPHAN VALUES ('HP001', N'TOEIC 2 Kỹ Năng 500+ T357', N'TOEIC', TO_DATE('2022-02-15', 'YYYY-MM-DD'), TO_DATE('2022-05-14', 'YYYY-MM-DD'), N'T357 19h45-21h15', 20, 3900000);
INSERT INTO LOPHOCPHAN VALUES ('HP002', N'TOEIC 4 Kỹ Năng 500+ T246', N'TOEIC', TO_DATE('2023-07-03', 'YYYY-MM-DD'), TO_DATE('2023-10-01', 'YYYY-MM-DD'), N'T246 18h-19h30', 20, 8700000);
INSERT INTO LOPHOCPHAN VALUES ('HP003', N'IELTS 4.0 T246', N'IELTS', TO_DATE('2023-04-03', 'YYYY-MM-DD'), TO_DATE('2023-07-03', 'YYYY-MM-DD'), N'T246 18h-19h30', 20, 4000000);
INSERT INTO LOPHOCPHAN VALUES ('HP004', N'IELTS 4.0- 7.5+ T357', N'IELTS', TO_DATE('2023-08-15', 'YYYY-MM-DD'), TO_DATE('2023-12-30', 'YYYY-MM-DD'), N'T357 19h45-21h15', 10, 10500000);
INSERT INTO LOPHOCPHAN VALUES ('HP005', N'HSK3+ HSKK T7CN', N'HSK', TO_DATE('2023-10-21', 'YYYY-MM-DD'), TO_DATE('2023-12-21', 'YYYY-MM-DD'), N'T7CN 9h-11h', 20, 3200000);
INSERT INTO LOPHOCPHAN VALUES ('HP006', N'Tiếng Trung giao tiếp', N'Tiếng Trung', TO_DATE('2024-01-22', 'YYYY-MM-DD'), TO_DATE('2024-04-10', 'YYYY-MM-DD'), N'T7CN 9h-11h', 20, 3200000);
INSERT INTO LOPHOCPHAN VALUES ('HP007', N'Tiếng Anh giao tiếp', N'Tiếng Anh', TO_DATE('2023-12-24', 'YYYY-MM-DD'), TO_DATE('2024-04-12', 'YYYY-MM-DD'), N'T246 18h-19h30', 20, 3200000);

select * from nhanvien


INSERT INTO HOCTAP VALUES ('BTHP001_001', 'HV001', 80, 100, 'HP001');
INSERT INTO HOCTAP VALUES ('BTHP001_001', 'HV002', NULL, 100, 'HP001');
INSERT INTO HOCTAP VALUES ('BTHP001_002', 'HV001', 50, 100, 'HP001');
INSERT INTO HOCTAP VALUES ('BTHP001_002', 'HV002', 70, 100, 'HP001');

INSERT INTO HOCTAP VALUES ('BTHP004_001', 'HV003', 85, 100, 'HP004');
INSERT INTO HOCTAP VALUES ('BTHP004_002', 'HV004', 90, 100, 'HP004');
INSERT INTO HOCTAP VALUES ('BTHP006_001', 'HV001', 75, 100, 'HP006');
INSERT INTO HOCTAP VALUES ('BTHP006_001', 'HV005', NULL, 100, 'HP006');
INSERT INTO HOCTAP VALUES ('BTHP007_001', 'HV002', 88, 100, 'HP007');
INSERT INTO HOCTAP VALUES ('BTHP007_001', 'HV006', 76, 100, 'HP007');

INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV001', 'HP001');
INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV002', 'HP001');
INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV003', 'HP001');
INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV004', 'HP002');
INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV005', 'HP002');
INSERT INTO DIEMDANH VALUES (TO_TIMESTAMP('2023-10-30 08:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HV006', 'HP003');

INSERT INTO PHANLOP VALUES ('HP001', 'HV001');
INSERT INTO PHANLOP VALUES ('HP001', 'HV002');
INSERT INTO PHANLOP VALUES ('HP002', 'HV003');
INSERT INTO PHANLOP VALUES ('HP002', 'HV004');
INSERT INTO PHANLOP VALUES ('HP003', 'HV005');
INSERT INTO PHANLOP VALUES ('HP004', 'HV006');
INSERT INTO PHANLOP VALUES ('HP005', 'HV007');

INSERT INTO GIAOVIEN VALUES ('GV001', N'Nguyễn Văn A', 'nguyenvana', 'password123');
INSERT INTO GIAOVIEN VALUES ('GV002', N'Trần Thị B', 'tranthib', 'password123');
INSERT INTO GIAOVIEN VALUES ('GV003', N'Phạm Minh C', 'phamminhc', 'password123');

INSERT INTO PHANCONG VALUES ('GV001', 'HP001');
INSERT INTO PHANCONG VALUES ('GV002', 'HP002');
INSERT INTO PHANCONG VALUES ('GV003', 'HP003');

INSERT INTO KHUYENMAI VALUES ('KM001', 10, 500000);
INSERT INTO KHUYENMAI VALUES ('KM002', 20, 2000000);

INSERT INTO NHANVIEN VALUES ('admin', 'adminpass');

INSERT INTO HOADON VALUES ('HD001', 'HV001', TO_TIMESTAMP('2023-10-30 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP001', 'KM001', 'admin', 3900000);
INSERT INTO HOADON VALUES ('HD002', 'HV002', TO_TIMESTAMP('2023-10-30 10:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP002', 'KM002', 'admin', 8700000);
INSERT INTO HOADON VALUES ('HD003', 'HV003', TO_TIMESTAMP('2023-10-31 09:30:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP003', NULL, 'admin', 500000);
INSERT INTO HOADON VALUES ('HD004', 'HV004', TO_TIMESTAMP('2023-11-01 08:45:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP001', 'KM001', 'admin', 2700000);
INSERT INTO HOADON VALUES ('HD005', 'HV005', TO_TIMESTAMP('2023-11-02 14:00:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP002', NULL, 'admin', 3000000);
INSERT INTO HOADON VALUES ('HD006', 'HV006', TO_TIMESTAMP('2023-11-03 15:30:00', 'YYYY-MM-DD HH24:MI:SS'), 'HP003', 'KM002', 'admin', 600000);
 //TRI//
 -- 1.1. Tạo User có tên là quanlyTiengAnh 
-- Tao user quanlyTiengAnh
create user quanlyTiengAnh IDENTIFIED by 123;

-- Cap quyen dang nhap quanlyTiengAnh
grant create session to quanlyTiengAnh;

-- Cap quyen tao bang cho quanlyTiengAnh
grant create table to quanlyTiengAnh;

-- Cap quyen nhap du lieu cho hoangvantri
alter user quanlyTiengAnh quota 100M on users;

-- Cấp quyền CREATE PROCEDURE để có thể tạo hàm hoặc thủ tục
GRANT CREATE PROCEDURE TO quanlyTiengAnh;
-- Cấp quyền thực thi cho tất cả các hàm và thủ tục 
GRANT EXECUTE ANY PROCEDURE TO quanlyTiengAnh;
-- Kiểm tra lại quyền Sau khi cấp quyền, xác minh bằng lệnh
SELECT * FROM USER_SYS_PRIVS WHERE PRIVILEGE LIKE '%PROCEDURE%';
-----=============================== THAO TÁC QUYỀN VÀ NHÓM NGƯỜI DÙNG ======================================------
---Tạo bằng tài khoản sys
----PROFILE ADMIN
CREATE PROFILE AdminProfile LIMIT 
    SESSIONS_PER_USER UNLIMITED 
    FAILED_LOGIN_ATTEMPTS 5 
    PASSWORD_LIFE_TIME 90;
----PROFILE NHANVIEN
CREATE PROFILE NhanVienProfile LIMIT 
    SESSIONS_PER_USER 2 
    FAILED_LOGIN_ATTEMPTS 5 
    PASSWORD_LIFE_TIME 90;
CREATE PROFILE GiaoVienProfile LIMIT 
    SESSIONS_PER_USER 1 
    FAILED_LOGIN_ATTEMPTS 5 
    PASSWORD_LIFE_TIME 90;
    
    
-- Tạo Role GiaoVien
CREATE ROLE RoleGV;
-- Cấp quyền cho Role GiaoVien
GRANT SELECT ON DuLieu.HOCVIEN TO RoleGV;
GRANT SELECT, INSERT, UPDATE ON DuLieu.DIEMDANH TO RoleGV;
GRANT SELECT ON DuLieu.HOCTAP TO RoleGV;
GRANT CREATE SESSION TO GiaoVien01

-- Tạo role Admin
CREATE ROLE RoleNV;
-- Cấp quyền cho Role
GRANT SELECT ON DuLieu.HOCVIEN TO RoleNV;
GRANT INSERT ON DuLieu.HOCVIEN TO RoleNV;
GRANT UPDATE ON DuLieu.HOCVIEN TO RoleNV;
GRANT DELETE ON DuLieu.HOCVIEN TO RoleNV;

GRANT SELECT ON DuLieu.GIAOVIEN TO RoleNV;
GRANT INSERT ON DuLieu.GIAOVIEN TO RoleNV;
GRANT UPDATE ON DuLieu.GIAOVIEN TO RoleNV;
GRANT DELETE ON DuLieu.GIAOVIEN TO RoleNV;

GRANT SELECT ON DuLieu.NHANVIEN TO RoleNV;
GRANT INSERT ON DuLieu.NHANVIEN TO RoleNV;
GRANT UPDATE ON DuLieu.NHANVIEN TO RoleNV;
GRANT DELETE ON DuLieu.NHANVIEN TO RoleNV;
GRANT DBA TO QUANLYTIENGANH;
GRANT SELECT ON DBA_ROLE_PRIVS TO PUBLIC;
GRANT SELECT ANY TABLE sys.GIAOVIEN, INSERT ON sys.GIAOVIEN, UPDATE ON sys.GIAOVIEN, DELETE ON sys.GIAOVIEN TO RoleNV;
SET ROLE RoleNV;
SET ROLE RoleGV;
SELECT ROLE FROM DBA_ROLES;
SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'RoleNV';
SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'RoleNV';
GRANT CREATE SESSION TO quanlyTiengAnh
-- Cho tài khoản quanly profile và quyền
Alter USER quanlyTiengAnh IDENTIFIED BY 123 PROFILE AdminProfile;
GRANT RoleNV TO quanlyTiengAnh;
GRANT RoleGV TO GiaoVien01;
SET ROLE RoleQuanTri;

SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'quanlyTiengAnh';
SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'quanlyTiengAnh';
SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'GiaoVien01';

select * from USER_ROLE_PRIVS where USERNAME='sys';
select * from USER_TAB_PRIVS where Grantee = 'sys';
select * from USER_SYS_PRIVS where USERNAME = 'sys';

select * from ROLE_ROLE_PRIVS where ROLE IN (select granted_role from USER_ROLE_PRIVS where USERNAME= 'GiaoVien01');
select * from ROLE_TAB_PRIVS  where ROLE IN (select granted_role from USER_ROLE_PRIVS where USERNAME= 'GiaoVien01');
select * from ROLE_SYS_PRIVS  where ROLE IN (select granted_role from USER_ROLE_PRIVS where USERNAME= 'GiaoVien01');

SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'GiaoVien';
SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'RoleQuanTri';


SELECT * FROM SESSION_ROLES; -- Kiểm tra các role đang kích hoạt trong phiên làm việc.
SELECT * FROM SESSION_PRIVS; -- Hiển thị tất cả các quyền mà user đang có trong phiên.

-- Cho tài khoản giaovien role giaovien, profile và quyền
CREATE USER GiaoVien01 IDENTIFIED BY 123 PROFILE GiaoVienProfile;
GRANT GiaoVien TO GiaoVien01;

GRANT ALL PRIVILEGES TO quanlyTiengAnh;
GRANT SYSDBA TO quanlyTiengAnh;
REVOKE ROLEGV FROM NV003;
GRANT ROLENV TO NV003;

--=========================================================== MÃ HÓA CEASER ==========================================================
--=========================================================== MÃ HÓA CHỮ ==========================================================
-- Tạo hàm shiftChar để dịch chuyển ký tự
create or replace function shiftChar (c char, k number) return char is 
    base number(2); -- Biến này dùng để lưu giá trị ASCII của ký tự đầu tiên của alphabet (hoặc số)
begin 
    if REGEXP_LIKE(c, '[a-zA-Z]') then
        -- Kiểm tra chữ hoa hoặc chữ thường và dịch chuyển riêng biệt
        if ASCII(c) >= ASCII('A') and ASCII(c) <= ASCII('Z') then
            -- Dịch chuyển ký tự chữ hoa
            base := ASCII('A');
            return CHR(base + (ASCII(c) - base + k) MOD 26);
        elsif ASCII(c) >= ASCII('a') and ASCII(c) <= ASCII('z') then
            -- Dịch chuyển ký tự chữ thường
            base := ASCII('a');
            return CHR(base + (ASCII(c) - base + k) MOD 26);
        end if;
    elsif REGEXP_LIKE(c, '[0-9]') then
        -- Xử lý ký tự số
        base := ASCII('0');
        return CHR(base + (ASCII(c) - base + k) MOD 10); -- Dịch chuyển trong phạm vi 0-9
    else
        -- Các ký tự không phải chữ cái hoặc số (giữ nguyên)
        return c;
    end if;
end;


-- Tạo hàm encryptCaesarCipher để mã hóa chuỗi đầu vào
-- Mã hóa Ceaser không chuyển đổi thành chữ hoa
create or replace function encryptCaesarCipher(str varchar, k number) return varchar is 
    i number(2);
    len number(5);
    kq varchar(100) := '';
begin
    len := length(str);
    for i in 1..len loop 
        kq := kq || shiftChar(substr(str, i, 1), k); -- Mã hóa từng ký tự
    end loop;
    return kq;
end;


-- Tạo hàm decryptCaesarCipher để giải hóa chuỗi bị mã hóa với key K
create or replace function decryptCaesarCipher(str varchar, k number) return varchar is 
begin
    -- Giải mã bằng cách mã hóa với key ngược lại
    return encryptCaesarCipher(str, 26 - k); 
end;



-- Tạo proc encryptCaesarCipher để mã hóa chuỗi đầu vào
CREATE OR REPLACE PROCEDURE encryptCaesarCipher_Proc(
    str IN VARCHAR2, 
    k IN NUMBER, 
    encrypted_str OUT VARCHAR2)
AS 
    i NUMBER(2);
    len NUMBER(5);
    kq VARCHAR2(100) := '';
BEGIN
    len := LENGTH(str);
    FOR i IN 1..len LOOP 
        kq := kq || shiftChar(SUBSTR(str, i, 1), k); -- Mã hóa từng ký tự
    END LOOP;
    encrypted_str := kq;
END;



-- Tạo proc decryptCaesarCipher để giải hóa chuỗi bị mã hóa với key K
CREATE OR REPLACE PROCEDURE decryptCaesarCipher_Proc(
    str IN VARCHAR2, 
    k IN NUMBER, 
    decrypted_str OUT VARCHAR2)
AS
BEGIN
    -- Giải mã bằng cách mã hóa với key ngược lại
    encryptCaesarCipher_Proc(str, 26 - k, decrypted_str);
END;


--=========================================================== MÃ HÓA SỐ ==========================================================
CREATE OR REPLACE FUNCTION shiftPhoneNumberChar (c CHAR, k NUMBER) RETURN CHAR IS
    base NUMBER := ASCII('0'); -- ASCII của số '0'
BEGIN
    IF REGEXP_LIKE(c, '[0-9]') THEN
        -- Dịch chuyển ký tự số trong phạm vi từ '0' đến '9'
        RETURN CHR(base + (ASCII(c) - base + k) MOD 10); -- Dịch chuyển trong phạm vi 0-9
    ELSE
        -- Giữ nguyên ký tự nếu không phải số
        RETURN c;
    END IF;
END;
/
-- Mã hóa số điện thoại (SDT) bằng Caesar Cipher
CREATE OR REPLACE FUNCTION encryptPhoneNumber (phone_number VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
    i NUMBER;
    len NUMBER;
    encrypted_phone VARCHAR2(400) := '';
BEGIN
    len := LENGTH(phone_number);
    FOR i IN 1..len LOOP
        -- Mã hóa từng ký tự của số điện thoại
        encrypted_phone := encrypted_phone || shiftPhoneNumberChar(SUBSTR(phone_number, i, 1), k);
    END LOOP;
    RETURN encrypted_phone;
END;
/
-- Giải mã số điện thoại (SDT) bằng Caesar Cipher
CREATE OR REPLACE FUNCTION decryptPhoneNumber (encrypted_phone_number VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
    i NUMBER;
    len NUMBER;
    decrypted_phone VARCHAR2(400) := '';
BEGIN
    len := LENGTH(encrypted_phone_number);
    FOR i IN 1..len LOOP
        -- Giải mã từng ký tự của số điện thoại (dùng key ngược lại)
        decrypted_phone := decrypted_phone || shiftPhoneNumberChar(SUBSTR(encrypted_phone_number, i, 1), 10 - (k MOD 10));
    END LOOP;
    RETURN decrypted_phone;
END;
/

--=========================================================== THỰC THI MÃ HÓA , GIẢI MÃ ==========================================================
-- MÃ HÓA ĐỐI XỨNG CaesarCipher---------------------------------------------------------
-- Tạo hàm shiftChar để dịch chuyển ký tự
create or replace function shiftChar(c char, k number)
return char
is
    baseChar number; -- Biến lưu ký tự cơ sở để dịch chuyển
    shift number; -- Biến lưu kết quả sau khi dịch chuyển
begin
    -- Kiểm tra nếu là ký tự in hoa không dấu (A-Z)
    if regexp_like(c, '[A-Z]') then
        baseChar := ASCII('A');
        shift := mod(ASCII(c) - baseChar + k, 26); -- Dịch chuyển trong phạm vi 26 chữ cái
        return CHR(baseChar + shift);
    elsif regexp_like(c, '[a-z]') then
        -- Ký tự in thường không dấu (a-z)
        baseChar := ASCII('a');
        shift := mod(ASCII(c) - baseChar + k, 26);
        return CHR(baseChar + shift);
    else
        -- Ký tự không phải chữ cái hoặc ký tự có dấu, giữ nguyên
        return c;
    end if;
end;

create or replace function encryptCaesarCipher (str varchar , k number )
return varchar 
as 
    i number(2);
    len number(5);
    kq varchar(4000) := ''; -- Tăng kích thước biến để chứa chuỗi dài hơn
    plainText varchar(4000); -- Tăng kích thước biến chuỗi gốc
begin
    plainText := upper(str); -- Chuyển chuỗi thành chữ hoa
    len := length(str); -- Độ dài chuỗi
    for i in 1..len loop 
        -- Kiểm tra nếu ký tự là khoảng trắng hoặc không phải chữ cái thì thêm trực tiếp
        if substr(plainText, i, 1) = ' ' or not regexp_like(substr(plainText, i, 1), '[A-Z]') then
            kq := kq || substr(plainText, i, 1);
        else
            -- Mã hóa ký tự
            kq := kq || shiftChar(substr(plainText, i, 1), k);
        end if;
    end loop;
    return kq; -- Trả về chuỗi mã hóa
end;

create or replace function decryptCaesarCipher (str varchar , k number ) 
return varchar 
as 
begin 
    return encryptCaesarCipher(str, 26-k); -- Gọi hàm mã hóa với key đảo ngược
end;


-- Lệnh thực thi và chạy các hàm đã cài đặt bằng PL/SQL trên Oracle.
-- Mã hóa dữ liệu trong cột DIACHI
UPDATE HOCVIEN
SET DIACHI = encryptCaesarCipher(DIACHI, 1);


-- Giải mã
-- Giải mã dữ liệu trong cột DIACHI
SELECT MAHV, HOTENHV, decryptCaesarCipher(DIACHI, 1) AS DIACHI_GIAIMA, EMAIL, SDT
FROM HOCVIEN;

-- MÃ HÓA ĐỐI XỨNG CaesarCipher---------------------------------------------------------

-- MÃ HÓA BẤT ĐỐI XỨNG DES---------------------------------------------------------
-- Cài đặt DES bằng PL/SQL trên Oracle
--CREATE OR REPLACE PACKAGE DES
--AS
--    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC;
--    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC;
--END;
--/
--
--CREATE OR REPLACE PACKAGE BODY DES
--AS
--    encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_DES
--                                + DBMS_CRYPTO.CHAIN_CBC
--                                + DBMS_CRYPTO.PAD_PKCS5;
--
--    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC
--    IS
--        encryption_key RAW (32) := UTL_RAW.cast_to_raw(priKey); --Private Key DES
--        encrypted_raw RAW (2000);
--    BEGIN
--        encrypted_raw := DBMS_CRYPTO.ENCRYPT
--        (
--            src => UTL_RAW.CAST_TO_RAW (p_plainText),
--            typ => encryption_type,
--            key => encryption_key
--        );
--        RETURN encrypted_raw;
--    END encrypt;
--
--    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC
--    IS
--        encryption_key RAW (32) := UTL_RAW.cast_to_raw(priKey); --Private Key DES
--        decrypted_raw RAW (2000);
--    BEGIN
--        decrypted_raw := DBMS_CRYPTO.DECRYPT
--        (
--            src => p_encryptedText,
--            typ => encryption_type,
--            key => encryption_key
--        );
--        RETURN (UTL_RAW.CAST_TO_VARCHAR2 (decrypted_raw));
--    END decrypt;
--END DES;
--/
--
---- Viết lệnh thực thi package DES đã cài đặt 
--DECLARE
--  plainText VARCHAR2(200) := 'Hello World';
--  cipherText RAW(2000); -- result of encrypted
--
--BEGIN
--  cipherText := DES.encrypt(plainText, 'PRIVATEKEY');
--  dbms_output.put_line('Encrypted: ' || cipherText);
--  dbms_output.put_line('Decrypted: ' || DES.decrypt(cipherText, 'PRIVATEKEY'));
--END;
--
--SELECT * FROM HOCVIEN
---- nếu không thấy kết quả màn hình mà chỉ nhận thông báo chạy thành công thì sử dụng lệnh sau để mở hiển thị
--set SERVEROUTPUT ON
--
--SELECT * FROM HOCTAP
---- MÃ HÓA BẤT ĐỐI XỨNG DES---------------------------------------------------------
GRANT SELECT ON sys.HOCVIEN TO quanlyTiengAnh;
--=========================================================== XÓA DỮ LIỆU ==========================================================
SELECT PROFILE FROM DBA_USERS WHERE USERNAME = 'quanlyTiengAnh';
SELECT * FROM sys.HOCVIEN;

DELETE FROM sys.HOADON;
DELETE FROM sys.KHUYENMAI;
DELETE FROM sys.PHANCONG;
DELETE FROM sys.PHANLOP;
DELETE FROM sys.HOCTAP;
DELETE FROM sys.DIEMDANH;
DELETE FROM sys.HOCVIEN;
DELETE FROM sys.LOPHOCPHAN;
//QUANG//

 
INSERT INTO NHANVIEN VALUES ('MQUANG', 'Test123');
INSERT INTO NHANVIEN VALUES ('test1', 'asdarqwer');
INSERT INTO NHANVIEN VALUES ('test2', 'sdfsdfwerrwww');

SELECT * FROM NHANVIEN
SELECT * FROM GIAOVIEN
SELECT * FROM HOCVIEN
SELECT * FROM TAIKHOAN

CREATE OR REPLACE FUNCTION ChuyenChuoi(
    c IN VARCHAR2,
    k IN NUMBER
) RETURN VARCHAR2 AS
    v_char VARCHAR2(1);
    v_ascii NUMBER;
    v_result VARCHAR2(1);
BEGIN
    v_char := c; -- Ky tu can ma hoa
    v_ascii := ASCII(v_char);

    -- Kiem tra chu cai viet Hoa
    IF v_ascii BETWEEN ASCII('A') AND ASCII('Z') THEN
        v_result := CHR(ASCII('A') + (v_ascii - ASCII('A') + k) MOD 26);

    -- Kiem tra chu cai thuong
    ELSIF v_ascii BETWEEN ASCII('a') AND ASCII('z') THEN
        v_result := CHR(ASCII('a') + (v_ascii - ASCII('a') + k) MOD 26);

    -- Kiem tra so
    ELSIF v_ascii BETWEEN ASCII('0') AND ASCII('9') THEN
        v_result := CHR(ASCII('0') + (v_ascii - ASCII('0') + k) MOD 10);

    ELSE
        -- Giu nguyen neu la cac ky tu khac
        v_result := v_char;
    END IF;

    RETURN v_result;
END;
/


CREATE OR REPLACE FUNCTION MaHoaCipher(str varchar, k number)
RETURN varchar
AS
    i number(2);        
    len number(5);      
    kq varchar(32000):=''; 
    plainText varchar(250); 
BEGIN
    plainText:=UPPER(str);
    len:= length(str);
    FOR i IN 1..len LOOP
        kq:=kq || ChuyenChuoi(substr(plainText,i,1),k);
    END LOOP;
    
    RETURN kq;
END;

CREATE OR REPLACE FUNCTION GiaiMaCipher(str varchar, k number)
RETURN varchar
AS
BEGIN
    RETURN MaHoaCipher(str, 26-k);
END;


SELECT MaHoaCipher('TEST',5) ResultEncrypt FROM dual;

SELECT GiaiMaCipher('YJXY',5) ResultDecrypt FROM dual;
 
SELECT * FROM NHANVIEN

CREATE OR REPLACE PROCEDURE MaHoaCipher_Proc(
    str IN VARCHAR2, 
    k IN NUMBER, 
    encrypted_str OUT VARCHAR2)
AS 
    i NUMBER(2);
    len NUMBER(5);
    kq VARCHAR2(100) := '';
    plainText VARCHAR2(2000);
BEGIN
    plainText := upper(str);
    len := LENGTH(str);
    FOR i IN 1..len LOOP 
        kq := kq || ChuyenChuoi(SUBSTR(plainText, i, 1), k);
    END LOOP;
    encrypted_str := kq;
END;

CREATE OR REPLACE PROCEDURE GiaiMaCipher_Proc(
    str IN VARCHAR2, 
    k IN NUMBER, 
    decrypted_str OUT VARCHAR2)
AS
BEGIN
    MaHoaCipher_Proc(str, 26 - k, decrypted_str);
END;
 
//NHANVIEN//
//TEST MA HOA MAT KHAU//
DECLARE
    v_enc_MATKHAU VARCHAR2(50);
    v_key NUMBER := 6;
BEGIN
    FOR r IN (SELECT TENTKNV, MATKHAU FROM NHANVIEN) LOOP
        MaHoaCipher_Proc(r.MATKHAU, v_key, v_enc_MATKHAU);
        
        UPDATE NHANVIEN
        SET MATKHAU = v_enc_MATKHAU
        WHERE TENTKNV = r.TENTKNV;
        
    END LOOP;
    COMMIT;
END;
//TEST GIAI MA MAT KHAU//
DECLARE
    v_enc_MATKHAU VARCHAR2(50);
    v_key NUMBER := 6;
BEGIN
    FOR r IN (SELECT TENTKNV, MATKHAU FROM NHANVIEN) LOOP
        GiaiMaCipher_Proc(r.MATKHAU, v_key, v_enc_MATKHAU);
        
        UPDATE NHANVIEN
        SET MATKHAU = v_enc_MATKHAU
        WHERE TENTKNV = r.TENTKNV;
        
    END LOOP;
    COMMIT;
END;
SELECT * FROM NHANVIEN
DROP USER quanlyTiengAnh CASCADE; 
SELECT * FROM sys.NHANVIEN

//TEST TAO TAI KHOAN DANG NHAP//
CREATE OR REPLACE PROCEDURE TaoTaiKhoan (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
) AS
    v_enc_password VARCHAR2(50);
    v_key NUMBER := 3;
BEGIN
    -- Thêm thông tin vào bảng TAIKHOAN trước
    INSERT INTO NHANVIEN (TENTKNV, MATKHAU) 
    VALUES (p_username, p_password);

    -- Commit để lưu các thay đổi
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Tài khoản ' || p_username || ' đã được thêm vào bảng NHANVIEN');

    -- Mã hóa mật khẩu sau khi đã thêm vào bảng
    MaHoaCipher_Proc(p_password, v_key, v_enc_password);

    -- Cập nhật lại mật khẩu đã mã hóa vào bảng TAIKHOAN
    UPDATE NHANVIEN
    SET MATKHAU = v_enc_password
    WHERE TENTKNV = p_username;

    -- Commit để lưu các thay đổi
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Tài khoản ' || p_username || ' đã được mã hóa và cập nhật lại');

    -- Tạo người dùng trong Oracle
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    DBMS_OUTPUT.PUT_LINE('Người dùng ' || p_username || ' đã được tạo trong Oracle');

--    -- Cấp quyền CREATE SESSION cho người dùng
--    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || p_username;
--    DBMS_OUTPUT.PUT_LINE('Đã cấp quyền truy cập CREATE SESSION cho người dùng ' || p_username);

    -- Commit để lưu các thay đổi (nếu cần)
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
        -- Rollback nếu có lỗi
        ROLLBACK;
        DBMS_OUTPUT.PUT_LINE('Lỗi: ' || SQLERRM);
END TaoTaiKhoan;
/

/

-- Gọi thủ tục
BEGIN
    TaoTaiKhoan('quanlyTiengAnh', '123');
END;

SELECT username FROM dba_users WHERE username = 'MQUANG';
SELECT username, account_status FROM dba_users WHERE username = 'MQUANG';
SET SERVEROUTPUT ON;


///GIAI MA MK TAIKHOAN//
DECLARE
    v_enc_MATKHAU VARCHAR2(50);
    v_key NUMBER := -3;
BEGIN
    FOR r IN (SELECT TENTK, MATKHAU FROM TAIKHOAN) LOOP
        decryptCaesarCipher_Proc(r.MATKHAU, v_key, v_enc_MATKHAU);
        
        UPDATE TAIKHOAN
        SET MATKHAU = v_enc_MATKHAU
        WHERE TENTK = r.TENTK;
        
    END LOOP;
    COMMIT;
END;

SELECT * FROM TAIKHOAN
CREATE USER DuLieu identified by 123;
Grant DBA TO DuLieu;
//TRUONG//

GRANT ALL PRIVILEGES TO DuLieu;







--------------------==========================AUDIT--------------------


