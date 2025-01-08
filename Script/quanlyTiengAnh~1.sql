SELECT * FROM USER_SYS_PRIVS WHERE PRIVILEGE LIKE '%PROCEDURE%';

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

--=========================================================== MÃ HÓA CEASER ==========================================================


--=========================================================== THỰC THI MÃ HÓA , GIẢI MÃ ==========================================================
-- MÃ HÓA ĐỐI XỨNG CaesarCipher---------------------------------------------------------
-- Tạo hàm shiftChar để dịch chuyển ký tự

create or replace function shiftChar(c char, k number)
return char
is
    baseChar number; -- Ký tự cơ sở (A hoặc a)
    shift number;    -- Kết quả sau khi dịch chuyển
begin
    -- Kiểm tra ký tự hoa (A-Z)
    if regexp_like(c, '[A-Z]') then
        baseChar := ASCII('A');
        shift := mod(ASCII(c) - baseChar + k, 26); -- Dịch chuyển trong phạm vi 26 chữ cái
        return CHR(baseChar + shift);

    -- Kiểm tra ký tự thường (a-z)
    elsif regexp_like(c, '[a-z]') then
        baseChar := ASCII('a');
        shift := mod(ASCII(c) - baseChar + k, 26);
        return CHR(baseChar + shift);

    -- Ký tự không phải chữ cái, giữ nguyên
    else
        return c;
    end if;
end;
/
create or replace function encryptCaesarCipher(str varchar, k number)
return varchar
as
    i number(2);            -- Chỉ số vòng lặp
    len number(5);          -- Độ dài chuỗi
    kq varchar(4000) := ''; -- Kết quả mã hóa
begin
    len := length(str); -- Tính độ dài chuỗi đầu vào

    for i in 1..len loop
        -- Lấy từng ký tự từ chuỗi
        kq := kq || shiftChar(substr(str, i, 1), k);
    end loop;

    return kq; -- Trả về chuỗi mã hóa
end;
/
create or replace function decryptCaesarCipher(str varchar, k number)
return varchar
as
begin
    -- Gọi lại hàm mã hóa với key đảo ngược
    return encryptCaesarCipher(str, 26 - k);
end;
/




-- MÃ HÓA ĐỐI XỨNG CaesarCipher---------------------------------------------------------

-- MÃ HÓA BẤT ĐỐI XỨNG RSA---------------------------------------------------------
-- Thêm độ dài lưu trữ kí tự mã hóa 
ALTER TABLE HOCVIEN MODIFY DIACHI VARCHAR2(500);
-- Mức CSDL : 
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
--START : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
SET define on
SET echo on
SET linesize 2048
SET escape off
SET timing on
SET trimspool on
SET serveroutput on
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--END : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.							 
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++

CREATE OR REPLACE PACKAGE CRYPTO AS 
FUNCTION RSA_ENCRYPT(PLAIN_TEXT VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.encrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_DECRYPT(ENCRYPTED_TEXT VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.decrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_SIGN(HASH_MESSAGE VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.sign (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_VERIFY(PLAIN_HASH VARCHAR2,SIGNNED_HASH VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN BOOLEAN
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.verify (java.lang.String,java.lang.String,java.lang.String) return java.lang.Boolean';

FUNCTION RSA_GENERATE_KEYS(KEY_SIZE NUMBER) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/GenerateKey.generateRSAKeys (java.lang.Integer) return java.lang.String';

END CRYPTO;
/

--drop PACKAGE CRYPTO

-- phat sinh khoa cong cong va rieng tu
SELECT CRYPTO.RSA_GENERATE_KEYS(KEY_SIZE=>1024) FROM DUAL;

****publicKey start*****
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCAh2lOd8JLlR7gxMKAnTQIf/ZgwfkpoKRAXBbaNtM6ALtYi4aKbRS89R6993CKhh58uB/cjTGy7xY8LpRFV9Htjie6dkTrIyZqwU0X7CCuyTJJoM2xpaQbUPyYNzrfROgnD4QsGA1M3H3wS1T0eYma+W5aLi0nhG1e2Jkg6gq/YQIDAQAB   
****publicKey end****

****privateKey start****
MIICdQIBADANBgkqhkiG9w0BAQEFAASCAl8wggJbAgEAAoGBAICHaU53wkuVHuDEwoCdNAh/9mDB+SmgpEBcFto20zoAu1iLhoptFLz1Hr33cIqGHny4H9yNMbLvFjwulEVX0e2OJ7p2ROsjJmrBTRfsIK7
JMkmgzbGlpBtQ/Jg3Ot9E6CcPhCwYDUzcffBLVPR5iZr5blouLSeEbV7YmSDqCr9hAgMBAAECgYADYw4cWj2NflV8+NJjT0EyxCR68kGdnjUV2RdlErLIQYKuV6bo+Ozl+dOgj+ewTs543OVCC5p2q6Q7W8
LefOz0OriDyK586GDEbxS32F2wH8H8v7JbeOhuxCAsMNqKOsGpnXJcdhIOdl4bPm4C5XfUixaJNpu6pT14BcpA9DAlQQJBAOw5hvid/TwdEpVyE63FbSQoz7xudotAY/csaL263SPUZ3KLUzxks55yYiWUR/
pe8gOrpa2HFrrK28T7zz9OYakCQQCLSeIUz3VCi4WNqtn8BFGWfluNC+X6PKF6SRjwbG3Z8NvC7Gi6rIWc1J45ufR3pbFF8YCZaYxrV1GHMi8QHPL5AkBA/Pqi/2Qh26W3M7EyR3RlVE0CfClk2gwmfjM6r2
QTbWYgXzBBFztLRhC2YfsDaIeQdvKXsOiR7ylTIiu8MOYxAkA5BVT9KfSZ+l4BIdk9F1ODJVU7R4ytRVbhpb0E546M8tI0WO2Cxg+opU3k2eBffsA0nuoDY7ctVkC09PFZSlCZAkB6ALmPekmbCg2JPHKbJF6
s1zWXJIcehmP1TkG64TVpOIEno/SJew5//zPc6qkpgCDso4JzR6t6mhdsMkoIC4F4  
****privateKey end**** do not copy asteric(*) ****


-- Encrypt and store encrypted text 
SELECT CRYPTO.RSA_ENCRYPT('This is my secret message', 'MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCAh2lOd8JLlR7gxMKAnTQIf/ZgwfkpoKRAXBbaNtM6ALtYi4aKbRS89R6993CKhh58uB/cjTGy7xY8LpRFV9Htjie6dkTrIyZqwU0X7CCuyTJJoM2xpaQbUPyYNzrfROgnD4QsGA1M3H3wS1T0eYma+W5aLi0nhG1e2Jkg6gq/YQIDAQAB')
FROM DUAL;
-- Cipher Text : 
-- P7smjMYrbJVH87yCPGSohc7/Bss3vDLhKxdFOAFYIWJ/WA+3ebCZOA+/wB8WFE49vQHS2jBvnHRRlXmAXV2G/iPmdIbxsohx7VtNFjoYdjhtH8rjYE0+y4OAtnLH4ZkaVlXgYCykJgUAndgO81u/d1VsFGvq939Yea0E7Rc4PHE=
SELECT CRYPTO.RSA_DECRYPT('P7smjMYrbJVH87yCPGSohc7/Bss3vDLhKxdFOAFYIWJ/WA+3ebCZOA+/wB8WFE49vQHS2jBvnHRRlXmAXV2G/iPmdIbxsohx7VtNFjoYdjhtH8rjYE0+y4OAtnLH4ZkaVlXgYCykJgUAndgO81u/d1VsFGvq939Yea0E7Rc4PHE=','MIICdQIBADANBgkqhkiG9w0BAQEFAASCAl8wggJbAgEAAoGBAICHaU53wkuVHuDEwoCdNAh/9mDB+SmgpEBcFto20zoAu1iLhoptFLz1Hr33cIqGHny4H9yNMbLvFjwulEVX0e2OJ7p2ROsjJmrBTRfsIK7JMkmgzbGlpBtQ/Jg3Ot9E6CcPhCwYDUzcffBLVPR5iZr5blouLSeEbV7YmSDqCr9hAgMBAAECgYADYw4cWj2NflV8+NJjT0EyxCR68kGdnjUV2RdlErLIQYKuV6bo+Ozl+dOgj+ewTs543OVCC5p2q6Q7W8LefOz0OriDyK586GDEbxS32F2wH8H8v7JbeOhuxCAsMNqKOsGpnXJcdhIOdl4bPm4C5XfUixaJNpu6pT14BcpA9DAlQQJBAOw5hvid/TwdEpVyE63FbSQoz7xudotAY/csaL263SPUZ3KLUzxks55yYiWUR/pe8gOrpa2HFrrK28T7zz9OYakCQQCLSeIUz3VCi4WNqtn8BFGWfluNC+X6PKF6SRjwbG3Z8NvC7Gi6rIWc1J45ufR3pbFF8YCZaYxrV1GHMi8QHPL5AkBA/Pqi/2Qh26W3M7EyR3RlVE0CfClk2gwmfjM6r2QTbWYgXzBBFztLRhC2YfsDaIeQdvKXsOiR7ylTIiu8MOYxAkA5BVT9KfSZ+l4BIdk9F1ODJVU7R4ytRVbhpb0E546M8tI0WO2Cxg+opU3k2eBffsA0nuoDY7ctVkC09PFZSlCZAkB6ALmPekmbCg2JPHKbJF6s1zWXJIcehmP1TkG64TVpOIEno/SJew5//zPc6qkpgCDso4JzR6t6mhdsMkoIC4F4')
FROM DUAL;


-- MÃ HÓA BẤT ĐỐI XỨNG RSA---------------------------------------------------------

-- MÃ HÓA LAI ---------------------------------------------------------
-- Thêm độ dài lưu trữ kí tự mã hóa 
ALTER TABLE HOCVIEN MODIFY SDT VARCHAR2(500);
-- MÃ HÓA LAI ---------------------------------------------------------

--=========================================================== XÓA DỮ LIỆU ==========================================================
SELECT * FROM HOCVIEN;
SELECT * FROM HOADON;
SELECT * FROM KHUYENMAI;
SELECT * FROM PHANCONG;
SELECT * FROM PHANLOP;
SELECT * FROM HOCTAP;
SELECT * FROM DIEMDANH;
SELECT * FROM LOPHOCPHAN;


DELETE FROM HOADON;
DELETE FROM KHUYENMAI;
DELETE FROM PHANCONG;
DELETE FROM PHANLOP;
DELETE FROM HOCTAP;
DELETE FROM DIEMDANH;
DELETE FROM HOCVIEN;
DELETE FROM LOPHOCPHAN;

---//QUANG//---

CREATE OR REPLACE FUNCTION ChuyenChuoi(
    c IN VARCHAR2,
    k IN NUMBER
) RETURN VARCHAR2 AS
    v_char VARCHAR2(1);
    v_ascii NUMBER;
    v_result VARCHAR2(1);
    is_decrypt BOOLEAN := FALSE;
BEGIN
    v_char := c; -- Ký tự cần mã hóa/giải mã
    v_ascii := ASCII(v_char);

    -- Kiểm tra giải mã hay mã hóa
    IF k < 0 THEN
        is_decrypt := TRUE;
        k := ABS(k); -- Đảm bảo k luôn dương
    END IF;

    -- Kiểm tra chữ cái viết hoa
    IF v_ascii BETWEEN ASCII('A') AND ASCII('Z') THEN
        v_result := CHR(ASCII('A') + MOD(v_ascii - ASCII('A') + k, 26));

    -- Kiểm tra chữ cái thường
    ELSIF v_ascii BETWEEN ASCII('a') AND ASCII('z') THEN
        v_result := CHR(ASCII('a') + MOD(v_ascii - ASCII('a') + k, 26));

    -- Kiểm tra số
    ELSIF v_ascii BETWEEN ASCII('0') AND ASCII('9') THEN
        IF is_decrypt THEN
            -- Xử lý riêng khi giải mã số
            v_result := CHR(ASCII('0') + MOD(v_ascii - ASCII('0') - k + 10, 10));
        ELSE
            v_result := CHR(ASCII('0') + MOD(v_ascii - ASCII('0') + k, 10));
        END IF;

    ELSE
        -- Giữ nguyên nếu là các ký tự khác
        v_result := v_char;
    END IF;

    RETURN v_result;
END;

DECLARE
    result VARCHAR2(100);
BEGIN
    -- Thử mã hóa và giải mã một ký tự
    result := ChuyenChuoi('A', 6);
    DBMS_OUTPUT.PUT_LINE('Ký tự mã hóa: ' || result);

    result := ChuyenChuoi(result, -6);
    DBMS_OUTPUT.PUT_LINE('Ký tự giải mã: ' || result);
END;

DECLARE
    encrypted_str VARCHAR2(2000);
    decrypted_str VARCHAR2(2000);
BEGIN
    MaHoaCipher_Proc('HELLO', 6, encrypted_str);
    DBMS_OUTPUT.PUT_LINE('Chuỗi mã hóa: ' || encrypted_str);

    GiaiMaCipher_Proc(encrypted_str, 6, decrypted_str);
    DBMS_OUTPUT.PUT_LINE('Chuỗi giải mã: ' || decrypted_str);
END;


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

=================
SELECT MaHoaCipher('TEST',5) ResultEncrypt FROM dual;

SELECT GiaiMaCipher('YJXY',5) ResultDecrypt FROM dual;
 
SELECT * FROM DuLieu.NHANVIEN
=================

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
    plainText := (str);
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
    -- Truyền k âm để giải mã đúng cho cả chữ và số
    MaHoaCipher_Proc(str, -k, decrypted_str);
END;

 
//NHANVIEN//
//TEST MA HOA MAT KHAU//
DECLARE
    v_enc_MATKHAU VARCHAR2(50);
    v_key NUMBER := 6;
BEGIN
    FOR r IN (SELECT TENTKNV, MATKHAU FROM DuLieu.NHANVIEN) LOOP
        -- Kiểm tra xem mật khẩu đã mã hóa chưa, ví dụ: bằng cách kiểm tra ký tự đặc biệt hoặc logic khác
        IF LENGTH(r.MATKHAU) < 50 THEN -- Giả sử mật khẩu đã mã hóa có độ dài lớn hơn 50
            MaHoaCipher_Proc(r.MATKHAU, v_key, v_enc_MATKHAU);

            UPDATE DuLieu.NHANVIEN
            SET MATKHAU = v_enc_MATKHAU
            WHERE TENTKNV = r.TENTKNV;

            DBMS_OUTPUT.PUT_LINE('Mã hóa thành công cho tài khoản: ' || r.TENTKNV);
        ELSE
            DBMS_OUTPUT.PUT_LINE('Mật khẩu đã được mã hóa, bỏ qua: ' || r.TENTKNV);
        END IF;
    END LOOP;
    COMMIT;
END;
------------------//TEST GIAI MA MAT KHAU//
UPDATE DuLieu.NHANVIEN
SET MATKHAU = '123'
WHERE TENTKNV = 'QUANLYTIENGANH'
SELECT * FROM DuLieu.NHANVIEN

DECLARE
    v_enc_MATKHAU VARCHAR2(50);
    v_key NUMBER := 6;
BEGIN
    FOR r IN (SELECT TENTKNV, MATKHAU FROM DuLieu.NHANVIEN) LOOP
        -- Gọi hàm giải mã mật khẩu
        GiaiMaCipher_Proc(r.MATKHAU, v_key, v_enc_MATKHAU);
        
        -- Cập nhật giá trị đã giải mã
        UPDATE DuLieu.NHANVIEN
        SET MATKHAU = v_enc_MATKHAU
        WHERE TENTKNV = r.TENTKNV;
    END LOOP;
    
    COMMIT; -- Lưu thay đổi
END;

SELECT * FROM DuLieu.NHANVIEN
-------------------------RSA--------------------------
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
--START : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
SET define on
SET echo on
SET linesize 2048
SET escape off
SET timing on
SET trimspool on
SET serveroutput on
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--END : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.							 
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++

CREATE OR REPLACE PACKAGE CRYPTO AS 
FUNCTION RSA_ENCRYPT(PLAIN_TEXT VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.encrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_DECRYPT(ENCRYPTED_TEXT VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.decrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_SIGN(HASH_MESSAGE VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.sign (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_VERIFY(PLAIN_HASH VARCHAR2,SIGNNED_HASH VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN BOOLEAN
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.verify (java.lang.String,java.lang.String,java.lang.String) return java.lang.Boolean';

FUNCTION RSA_GENERATE_KEYS(KEY_SIZE NUMBER) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/GenerateKey.generateRSAKeys (java.lang.Integer) return java.lang.String';

END CRYPTO;
-----------------------------//TEST TAO TAI KHOAN DANG NHAP//
CREATE OR REPLACE PROCEDURE TaoTaiKhoan (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2,
    p_email    IN VARCHAR2,
    p_sdt      IN VARCHAR2
) AS
    v_enc_password VARCHAR2(50);
    v_key NUMBER := 3;
BEGIN
    -- Mã hóa mật khẩu trước khi lưu
    MaHoaCipher_Proc(p_password, v_key, v_enc_password);

    -- Thêm thông tin vào bảng NHANVIEN với mật khẩu đã mã hóa
    INSERT INTO DuLieu.NHANVIEN (TENTKNV, MATKHAU, EMAIL, SDT) 
    VALUES (p_username, v_enc_password, p_email, p_sdt);

    -- Commit để lưu các thay đổi
    COMMIT;
    DBMS_OUTPUT.PUT_LINE('Tài khoản ' || p_username || ' đã được thêm vào bảng NHANVIEN với mật khẩu mã hóa');

    -- Tạo người dùng trong Oracle
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    DBMS_OUTPUT.PUT_LINE('Người dùng ' || p_username || ' đã được tạo trong Oracle');

    -- Gán role ROLENV cho người dùng
    EXECUTE IMMEDIATE 'GRANT ROLENV TO ' || p_username;
    DBMS_OUTPUT.PUT_LINE('Role ROLENV đã được gán cho ' || p_username);

    -- Gán profile NhanVienProfile cho người dùng
    EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' PROFILE NhanVienProfile';
    DBMS_OUTPUT.PUT_LINE('Profile NhanVienProfile đã được gán cho ' || p_username);

    -- Commit để lưu các thay đổi (nếu cần)
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
        -- Rollback nếu có lỗi
        ROLLBACK;
        DBMS_OUTPUT.PUT_LINE('Lỗi: ' || SQLERRM);
END TaoTaiKhoan;



-- Gọi thủ tục
BEGIN
    TaoTaiKhoan('NV002', '123','nv002@gmail.com','0978534213');
END;

SELECT * FROM DuLieu.NHANVIEN
SELECT * FROM SESSION_PRIVS;
SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = 'quanlyTiengAnh';

SELECT username FROM dba_users WHERE username = 'MQUANG';
SELECT username, account_status FROM dba_users WHERE username = 'MQUANG';
SET SERVEROUTPUT ON;

SELECT * FROM DuLieu.NHANVIEN

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
------------TRUONG------------------
Create Role Nhan_Vien_Role;
GRANT CONNECT TO Nhan_Vien_Role;  -- Cấp quyền kết nối
GRANT SELECT, INSERT, UPDATE, DELETE ON mtruong.GIAOVIEN TO Nhan_Vien_Role;
GRANT SELECT ON mtruong.NHANVIEN TO Nhan_Vien_Role;
GRANT SELECT, INSERT, UPDATE, DELETE ON mtruong.HOCVIEN TO Nhan_Vien_Role;
GRANT SELECT, INSERT, UPDATE, DELETE ON mtruong.LOPHOCPHAN TO Nhan_Vien_Role;
GRANT SELECT, INSERT, UPDATE, DELETE ON mtruong.PHANCONG TO Nhan_Vien_Role;
GRANT Giao_Vien_Role TO Nhan_Vien_Role WITH ADMIN OPTION;
GRANT ALTER USER TO Nhan_Vien_Role;
GRANT CREATE USER TO Nhan_Vien_Role;
GRANT CREATE USER TO TRUONGVO;
GRANT SELECT ON SYS.DUAL TO Nhan_Vien_Role;
GRANT EXECUTE ON mtruong.shiftChar TO Nhan_Vien_Role;
GRANT EXECUTE ON mtruong.encryptCaesarCipher TO Nhan_Vien_Role;
GRANT EXECUTE ON mtruong.decryptCaesarCipher TO Nhan_Vien_Role;

Create Role Giao_Vien_Role;
GRANT CONNECT TO Giao_Vien_Role;  -- Cấp quyền kết nối
GRANT SELECT ON GIAOVIEN TO Giao_Vien_Role;
GRANT SELECT ON mtruong.HOCVIEN TO Giao_Vien_Role;
GRANT SELECT ON mtruong.LOPHOCPHAN TO Giao_Vien_Role;
GRANT SELECT ON mtruong.PHANLOP TO Giao_Vien_Role;

CREATE USER truongvo IDENTIFIED BY 123;
GRANT Nhan_Vien_Role TO mtruong;



CREATE USER dinhphat IDENTIFIED BY 123;
GRANT Giao_Vien_Role TO dinhphat;


--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
--START : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.
--+++++++++++++++++++++++++++++++++++++++++++++++++++++++
SET define on
SET echo on
SET linesize 2048
SET escape off
SET timing on
SET trimspool on
SET serveroutput on
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--END : PLEASE DO NOT MAKE ANY CHANGES TO THIS SECTION.							 
--++++++++++++++++++++++++++++++++++++++++++++++++++++++++

CREATE OR REPLACE PACKAGE CRYPTO AS 
FUNCTION RSA_ENCRYPT(PLAIN_TEXT VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.encrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_DECRYPT(ENCRYPTED_TEXT VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.decrypt (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_SIGN(HASH_MESSAGE VARCHAR2,PUBLIC_KEY VARCHAR2) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.sign (java.lang.String,java.lang.String) return java.lang.String';


FUNCTION RSA_VERIFY(PLAIN_HASH VARCHAR2,SIGNNED_HASH VARCHAR2,PRIVATE_KEY VARCHAR2) RETURN BOOLEAN
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/RSAUtil.verify (java.lang.String,java.lang.String,java.lang.String) return java.lang.Boolean';

FUNCTION RSA_GENERATE_KEYS(KEY_SIZE NUMBER) RETURN VARCHAR2
AS
LANGUAGE JAVA NAME 'com/dishtavar/crypto4ora/GenerateKey.generateRSAKeys (java.lang.Integer) return java.lang.String';

END CRYPTO;
/

-- phat sinh khoa cong cong va rieng tu
SELECT CRYPTO.RSA_GENERATE_KEYS(KEY_SIZE=>1024) FROM DUAL;

-- Tạo và lưu cặp khóa
SELECT CRYPTO.RSA_GENERATE_KEYS(1024) INTO KeyPair FROM DUAL;

-- Hoặc nếu đã có sẵn public key, gán trực tiếp

SELECT CRYPTO.RSA_DECRYPT(CipherText, PrivateKeyRSA) 
FROM DUAL;

GRANT EXECUTE ON mtruong.CRYPTO TO Nhan_Vien_Role;

-- Cập nhật lại hàm shiftChar để giải mã

--=========================================================== MÃ HÓA CEASER ==========================================================
--=========================================================== MÃ HÓA CHỮ ==========================================================
-- Tạo hàm shiftChar để dịch chuyển ký tự
create or replace function quanlyTiengAnh.shiftChar2 (c char, k number) return char is 
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
create or replace function quanlyTiengAnh.encryptCaesarCipher2(str varchar, k number) return varchar is 
    i number(2);
    len number(5);
    kq varchar(100) := '';
begin
    len := length(str);
    for i in 1..len loop 
        kq := kq || quanlyTiengAnh.shiftChar2(substr(str, i, 1), k); -- Mã hóa từng ký tự
    end loop;
    return kq;
end;


-- Tạo hàm decryptCaesarCipher để giải hóa chuỗi bị mã hóa với key K
create or replace function quanlyTiengAnh.decryptCaesarCipher2(str varchar, k number) return varchar is 
begin
    -- Giải mã bằng cách mã hóa với key ngược lại
    return quanlyTiengAnh.encryptCaesarCipher2(str, 26 - k); 
end;



-- Tạo proc encryptCaesarCipher để mã hóa chuỗi đầu vào
CREATE OR REPLACE PROCEDURE quanlyTiengAnh.encryptCaesarCipher_Proc2(
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
        kq := kq || quanlyTiengAnh.shiftChar2(SUBSTR(str, i, 1), k); -- Mã hóa từng ký tự
    END LOOP;
    encrypted_str := kq;
END;



-- Tạo proc decryptCaesarCipher để giải hóa chuỗi bị mã hóa với key K
CREATE OR REPLACE PROCEDURE quanlyTiengAnh.decryptCaesarCipher_Proc2(
    str IN VARCHAR2, 
    k IN NUMBER, 
    decrypted_str OUT VARCHAR2)
AS
BEGIN
    -- Giải mã bằng cách mã hóa với key ngược lại
    quanlyTiengAnh.encryptCaesarCipher_Proc2(str, 26 - k, decrypted_str);
END;


--=========================================================== MÃ HÓA SỐ ==========================================================
CREATE OR REPLACE FUNCTION quanlyTiengAnh.shiftPhoneNumberChar2 (c CHAR, k NUMBER) RETURN CHAR IS
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
CREATE OR REPLACE FUNCTION quanlyTiengAnh.encryptPhoneNumber2 (phone_number VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
    i NUMBER;
    len NUMBER;
    encrypted_phone VARCHAR2(400) := '';
BEGIN
    len := LENGTH(phone_number);
    FOR i IN 1..len LOOP
        -- Mã hóa từng ký tự của số điện thoại
        encrypted_phone := encrypted_phone || quanlyTiengAnh.shiftPhoneNumberChar2(SUBSTR(phone_number, i, 1), k);
    END LOOP;
    RETURN encrypted_phone;
END;
/
-- Giải mã số điện thoại (SDT) bằng Caesar Cipher
CREATE OR REPLACE FUNCTION quanlyTiengAnh.decryptPhoneNumber2 (encrypted_phone_number VARCHAR2, k NUMBER) RETURN VARCHAR2 IS
    i NUMBER;
    len NUMBER;
    decrypted_phone VARCHAR2(400) := '';
BEGIN
    len := LENGTH(encrypted_phone_number);
    FOR i IN 1..len LOOP
        -- Giải mã từng ký tự của số điện thoại (dùng key ngược lại)
        decrypted_phone := decrypted_phone || quanlyTiengAnh.shiftPhoneNumberChar2(SUBSTR(encrypted_phone_number, i, 1), 10 - (k MOD 10));
    END LOOP;
    RETURN decrypted_phone;
END;
/

--=========================================================== THỰC THI MÃ HÓA , GIẢI MÃ ==========================================================
-- MÃ HÓA ĐỐI XỨNG CaesarCipher---------------------------------------------------------
-- Tạo hàm shiftChar để dịch chuyển ký tự
create or replace function mtruong.shiftChar(c char, k number)
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

create or replace function mtruong.encryptCaesarCipher (str varchar , k number )
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

create or replace function mtruong.decryptCaesarCipher (str varchar , k number ) 
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
CREATE OR REPLACE PACKAGE DES
AS
    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC;
    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC;
END;
/

CREATE OR REPLACE PACKAGE BODY DES
AS
    encryption_type PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_DES
                                + DBMS_CRYPTO.CHAIN_CBC
                                + DBMS_CRYPTO.PAD_PKCS5;

    FUNCTION encrypt (p_plainText VARCHAR2, priKey VARCHAR2) RETURN RAW DETERMINISTIC
    IS
        encryption_key RAW (32) := UTL_RAW.cast_to_raw(priKey); --Private Key DES
        encrypted_raw RAW (2000);
    BEGIN
        encrypted_raw := DBMS_CRYPTO.ENCRYPT
        (
            src => UTL_RAW.CAST_TO_RAW (p_plainText),
            typ => encryption_type,
            key => encryption_key
        );
        RETURN encrypted_raw;
    END encrypt;

    FUNCTION decrypt (p_encryptedText RAW, priKey VARCHAR2) RETURN VARCHAR2 DETERMINISTIC
    IS
        encryption_key RAW (32) := UTL_RAW.cast_to_raw(priKey); --Private Key DES
        decrypted_raw RAW (2000);
    BEGIN
        decrypted_raw := DBMS_CRYPTO.DECRYPT
        (
            src => p_encryptedText,
            typ => encryption_type,
            key => encryption_key
        );
        RETURN (UTL_RAW.CAST_TO_VARCHAR2 (decrypted_raw));
    END decrypt;
END DES;

ALTER TABLE DuLieu.GIAOVIEN MODIFY TENTKGV VARCHAR2(4000 BYTE);
ALTER TABLE DuLieu.GIAOVIEN MODIFY MATKHAU VARCHAR2(4000 BYTE);


SELECT * FROM DuLieu.GIAOVIEN
UPDATE DuLieu.GIAOVIEN
SET DuLieu.GIAOVIEN.TENTKGV = 'hoangvanquyet'
WHERE DuLieu.GIAOVIEN.MAGV = 'GV002';
DELETE FROM DuLieu.GIAOVIEN
---------------------------------------------
REVOKE DBA FROM QUANLYTIENGANH;
SELECT GRANTED_ROLE FROM user_role_privs WHERE USERNAME = 'QUANLYTIENGANH';
SELECT * FROM USER_ROLE_PRIVS;
SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'GIAOVIEN01';
SELECT * FROM DuLieu.LOPHOCPHAN
SELECT * FROM DuLieu.NHANVIEN;
SELECT * FROM DuLieu.HOCVIEN;
SELECT MALOPHP FROM DuLieu.LOPHOCPHAN

UPDATE DuLieu.NHANVIEN 
SET EMAIL = 'test235@gmail.com' 
WHERE TENTKNV = 'Testne1';

SELECT * FROM DuLieu.NHANVIEN;

----------AUDIT-------------
AUDIT SELECT TABLE BY quanlyTiengAnh BY ACCESS;
AUDIT INSERT TABLE BY quanlyTiengAnh BY ACCESS;
AUDIT UPDATE TABLE BY quanlyTiengAnh BY ACCESS;
AUDIT DELETE TABLE BY quanlyTiengAnh BY ACCESS;
---Thu tuc select user de kiem tra
CREATE OR REPLACE PROCEDURE PRO_SELECT_ALL_USERS 
(
    v_out OUT SYS_REFCURSOR
)
IS
BEGIN
    -- Mở con trỏ và trả về danh sách tất cả user trong cơ sở dữ liệu
    OPEN v_out FOR
    SELECT USERNAME
    FROM DBA_USERS
    ORDER BY USERNAME ASC;
END;
/

CREATE OR REPLACE PROCEDURE PRO_SYS_SELECT_USER_DML(cur out sys_refcursor)
is
begin
    open cur for
        select username from dba_users order by username ASC;
end;

----connect sys
--Thu tuc xoa giam sat
CREATE OR REPLACE PROCEDURE PRO_DROP_AUDIT(
p_statement IN VARCHAR2, p_username IN VARCHAR2)
    AS
        v_audit_command VARCHAR2(400);
    BEGIN
        --Tao cau lenh AUDIT
        v_audit_command := 'NoAUDIT' || p_statement || ' BY ' || p_username;
        --Thuc thi cau lenh AUDIT
        EXECUTE IMMEDIATE v_audit_command;
        -- In thong bao thanh cong
        DBMS_OUTPUT.PUT_LINE('Thuc thi thanh cong!');
    EXCEPTION
        WHEN OTHERS THEN
            -- Xu ly loi
            DBMS_OUTPUT.PUT_LINE('Loi thuc thi lenh: ' || SQLERRM);
            --NEN LAI LOI CHO C#
            RAISE;
END;

--Thu tuc kie mtra user bi giam sat cac hoat dong nao
CREATE OR REPLACE PROCEDURE PRO_SELECT_STMT_AUDIT_OPTS
(username in VARCHAR2, cur out sys_refcursor)
is
begin
    open cur for
        SELECT * FROM DBA_STMT_AUDIT_OPTS
        WHERE USER_NAME = username;
end;

-- THU TUC XEM, KIEM TRA GIAM SAT HOAT DONG CUA USER
CREATE OR REPLACE PROCEDURE PRO_SELECT_AUDIT_TRAIL_USER
(
    username IN VARCHAR2,
    cur OUT SYS_REFCURSOR
)
IS
BEGIN
    OPEN cur FOR
        SELECT Session_ID, DB_User, Extended_timestamp, UserHost,
               Object_schema, Object_name, Statement_Type, SQL_Bind, SQL_Text
        FROM DBA_COMMON_AUDIT_TRAIL
        WHERE AUDIT_TYPE = 'Standard Audit'
          AND DB_USER = username 
          AND Object_name = 'HOCVIEN'
        ORDER BY Extended_timestamp DESC;
END;
/

SELECT Session_ID, Extended_timestamp, DB_User, UserHost,
       Object_schema, Object_name, Statement_Type, SQL_Bind, SQL_Text
FROM DBA_COMMON_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'Standard Audit'
  AND DB_USER = 'GIAOVIEN01'
  AND Object_name = 'HOCVIEN'
ORDER BY Extended_timestamp DESC;


        
---Kiem tra hanh vi duoc giam sang
SELECT DB_User, UserHost, Object_schema,Object_name,Statement_Type,SQL_Bind,SQL_Text
FROM DBA_COMMON_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'Standard Audit'
and object_schema ='DULIEU';

SELECT DB_User, UserHost, Object_schema, Object_name, Statement_Type, SQL_Bind, SQL_Text
FROM DBA_COMMON_AUDIT_TRAIL
WHERE AUDIT_TYPE = 'Standard Audit'
  AND Object_schema = 'DULIEU'
  AND DB_User = 'GIAOVIEN01';


CREATE USER GV001 IDENTIFIED BY 123;
GRANT RoleGV TO GV001;

-------------------PHÂN QUYỀN----------------------
---CONNECT SYS---
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

--TEST PHAN QUYEN--
CREATE USER HUHU IDENTIFIED BY 123;
--TEST THANH CONG!!

