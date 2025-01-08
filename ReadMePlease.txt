//BẢNG DB_THBH_QLTTNN_SYS là bảng ban đầu, chứa tùm lum lệnh thực thi của sys và test các câu lệnh, hàm khác


//DuLieu là nơi chứa cơ sở dữ liệu chính, các user khác tham chiếu tới và sử dụng nhớ thêm DuLieu.TableName để không lỗi, lưu ý cần cấp quyền trước mới dùng
//Hiện tại đang có 2 role chính là RoleNV và RoleGV, thi thoảng oracle sẽ lỗi nên trong các trường hợp nên viết in hoa ROLENV và ROLEGV ngoài ra DuLieu mang role DBA, all privs


//GiaoVien01 là giaovien để test trước đó, nhưng bây giờ có thể dùng user quanlyTiengAnh (Mang quyền lớn, trưởng gv nv) để chạy hoặc user GV001

//quanlyTiengAnh là chứa đa số là thủ tục, hàm và audit... xử lý liên quan, bản thân user đó cũng có quyền cao không như GV001~ Nhân viên khác. Có thể sử dụng để thực thi mã hóa nhưng
// lâu lâu sẽ bị chậm, đơ, ưu tiên dùng user DuLieu

//PhanQuyen là file chứa lệnh pkg, proc cho phân quyền được lưu riêng để tiện xem

//taouser_qltrungtamTA ghi lệnh tạo user, không quan trọng lắm

LƯU Ý: Hãy chạy đầy đủ các quyền, user và chuỗi kết nối mặc định là localhost - 1521 - orcl

ĐĂNG NHẬP được duyệt dựa trên 2 yếu tố
1. Kiểm tra tài khoản có tồn tại trong hệ thống oracle hay không và có quyền create session hay không
2. Kiểm tra mã tài khoản, MAGV, TENTKNV để lấy role, sau đó xét kiểm tra có tồn tại trong bảng tài khoản NHANVIEN, GIAOVIEN hay không mới cho truy cập vào ứng dụng
//Đối với role ROLEGV thì sẽ hiển thị theo quyền GV, ROLENV thì hiển thị tổng, DBA thì là ADMIN

--ĐÃ CHẠY ĐƯỢC PHÂN QUYỀN VÀ AUDIT THÀNH CÔNG Ở CSDL VÀ ỨNG DỤNG WINFORM--
Để chạy thì mấy ông nhớ chỉnh lại ở Database và FormDangNhap nhé! Tui note sẵn ở các chỗ cần mở hoặc đóng // để thực hiện chạy form PHANQUYEN và AUDIT rồi nha.

MÌNH CÒN VPD nhưng cái tui tính làm ở VPD là cho select hiển thị/ẩn thông tin dữ liệu theo quyền của mình nhưng làm không kịp, hiện tại ở đồ án mình thì cũng đã chia hiển thị theo MAGV rồi, 
giáo viên nào thì xem được thông tin liên quan đến mình thôi, không xem all như nhân viên được.

LƯU Ý VẬY THÔI, CHÚC MỌI NGƯỜI THUẬN LỢI BÁO CÁO, HỌC TẬP!



==TÊN ĐỒ ÁN==
ỨNG DỤNG QUẢN LÝ TRUNG TÂM NGOẠI NGỮ KẾT HỢP BẢO MẬT MÃ HÓA
==THÀNH VIÊN NHÓM==

2001210517 - Hoàng Văn Trí	

2001216071 - Hồ Minh Quang SDT: 0867585724

2001216268 - Võ Minh Trường
