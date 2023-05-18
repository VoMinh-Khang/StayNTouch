from ProjectHotel.settings import execute_query

class Phong_controller():
    def get_room_item(self, maphong):
        sql = "select * from phong ph,loaiphong lp where lp.MALOAIPHONG = ph.LOAIP and ph.MAPHONG = '{0}'".format(maphong)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0]
     
    def get_typeroom(self):
        sql = "select * from LoaiPhong"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_service(self):
        sql = "select * from dichvu"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_room_empty(self):
        sql = "select * from phong ph,loaiphong lp where lp.MALOAIPHONG = ph.LOAIP and TINHTRANG = 0"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_Allroom():
        sql = "select * from phong ph,loaiphong lp where lp.MALOAIPHONG = ph.LOAIP"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_room(page=1, per_page=6):
        offset = ((page - 1) * per_page)+1
        per_page = per_page*page
        sql = "SELECT * FROM ( SELECT ph.*, ROWNUM rnum FROM phong ph WHERE ROWNUM <= '{0}' ) WHERE rnum >= '{1}'".format(per_page,offset)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result

    def get_typeroom_item(self, malp):
        sql = "select * from phong ph join loaiphong lp on lp.MALOAIPHONG = ph.LOAIP where lp.MALOAIPHONG = '{0}'".format(malp)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_nametype(self,malp):
        sql = "select TENLOAIPHONG from LoaiPhong lp where lp.MALOAIPHONG = '{0}'".format(malp)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def get_typeroom_id(self, malp):
        sql = "select * from loaiphong lp where lp.MALOAIPHONG = '{0}'".format(malp)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0]

class tour_controller():
    def get_tour(self):
        sql = "select * from TourDuLich"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result    

class login_controller():
    def get_login(self):
        sql = "select * from taikhoan"
        result = execute_query('QLKhachSan', 'a' ,sql)
        print(result)
        return result
    
class signup_controller():
    def save_customer(self, cmnd, tenkh, diachi, sdt, email, username):
        sql = "INSERT INTO KhachHang (CMND, TenKH, DiaChi, SDT, Email, Avatar, USERNAME) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', 'https://cdn-icons-png.flaticon.com/512/219/219983.png', '{5}')".format(cmnd, tenkh, diachi, sdt, email, username)
        result, er = execute_query('QLKhachSan', 'a' ,sql)
        return result, er
    
    def save_account(self, username, password):
        sql = "INSERT INTO TaiKhoan (Username, Password, Type) VALUES ('{0}','{1}', 2)".format(username, password)
        result ,er= execute_query('QLKhachSan', 'a' ,sql)
        return result ,er
    
class booking_controller():
    def get_idcus(self, username):
        sql = "SELECT CMND FROM khachhang where USERNAME = '{0}'".format(username)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def get_countpdp(self):
        sql = "SELECT COUNT(*) FROM PhieuDatPhong"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def get_infocus(self, makh):
        sql = "SELECT * FROM khachhang where CMND = '{0}'".format(makh)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0]
    
    def get_countpay(self):
        sql = "SELECT COUNT(*) FROM thongtinthanhtoan"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def save_infopay(self, matt, type):
        if type == 'pay':
            type_new = 1

        if type == 'momo':
            type_new = 2

        if type == 'zalo':
            type_new = 3

        sql = "INSERT INTO thongtinthanhtoan VALUES ('{0}','{1}')".format(matt, type_new)
        result ,er= execute_query('QLKhachSan', 'a' ,sql)
        return result ,er
    
    def save_pay(self, mapay,sothe, tenthe, ngayhethan, cvc, matt):
        sql = "INSERT INTO thenganhang VALUES ('{0}','{1}','{2}', '{3}', '{4}','{5}')".format(mapay, sothe, tenthe, ngayhethan, cvc, matt)
        result ,er= execute_query('QLKhachSan', 'a' ,sql)
        return result ,er
    
    def get_countthe(self):
        sql = "SELECT COUNT(*) FROM thenganhang"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def save_momo(self, mamomo, sdt, matt):
        sql = "INSERT INTO momo VALUES ('{0}','{1}','{2}')".format(mamomo,sdt, matt)
        result ,er= execute_query('QLKhachSan', 'a' ,sql)
        return result ,er
    
    def get_countmomo(self):
        sql = "SELECT COUNT(*) FROM momo"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def save_zalo(self, mazalo, sdt, matt):
        sql = "INSERT INTO zalo VALUES ('{0}','{1}','{2}')".format(mazalo,sdt, matt)
        result ,er= execute_query('QLKhachSan', 'a' ,sql)
        return result ,er
    
    def get_countzalo(self):
        sql = "SELECT COUNT(*) FROM Zalo"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def save_booking(self, mapdp, ngayden, sodem, slng, stc, maphong, makh, matt):
        sql = "INSERT INTO phieudatphong (MAPDP, NGAYDEN, SODEMLUTRU,YEUCAUDACBIET, SOLUONGNGUOI, SOTIENDATCOC,CHECKDC, MAPHONG, MAKH, MATT) VALUES ('{0}', '{1}', '{2}', '', '{3}', '{4}', '', '{5}','{6}','{7}')".format(mapdp, ngayden, sodem, slng, stc, maphong, makh, matt)
        result, er = execute_query('QLKhachSan', 'a' ,sql)
        return result, er
    
class admin_controller():
    def get_room(self):
        sql ="SELECT * FROM phong ph, loaiphong lp where lp.MALOAIPHONG = ph.loaip"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def get_room_note(self):
        sql ="SELECT * FROM Phieudatphong"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def delete_room(self, maphong):
        sql ="DELETE FROM PHONG where MAPHONG = '{0}'".format(maphong)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result

    def delete_room_note(self, maphong):
        sql ="DELETE FROM Phieudatphong where MAPDP = '{0}'".format(maphong)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def add_room(self, maphong, toida, tinhtrang, quydinhphong, tiennghi, loaip, image):
        sql ="INSERT INTO PHONG VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')".format(maphong, toida, tinhtrang, quydinhphong, tiennghi, loaip, image)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
    def add_note(self, maphieu, ngayden, sodemluutru, yeucaudacbiet, soluongnguoi, sotiendatcoc, maphong, makh, matt):
        sql ="INSERT INTO PHIEUDATPHONG VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','', '{6}', '{7}', '{8}')".format(maphieu, ngayden, sodemluutru, yeucaudacbiet, soluongnguoi, sotiendatcoc, maphong, makh, matt)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result
    
class profile_controller():
    def get_idcus(self, username):
        sql = "SELECT CMND FROM khachhang where USERNAME = '{0}'".format(username)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0][0]
    
    def get_profile(self, MAKH):
        sql = "SELECT * FROM KHACHHANG WHERE CMND = '{0}'".format(MAKH)
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result[0]
    
    def update_profile(self, name, address, phone, email, shk, id):
        sql = "UPDATE KHACHHANG SET TENKH = '{0}', DIACHI = '{1}', SDT = '{2}', EMAIL = '{3}', HOCHIEU = '{4}' where CMND = '{5}'".format(name, address, phone, email, shk, id)
        result, er = execute_query('QLKhachSan', 'a' ,sql)
        return result, er
    
class account():
    def get_accounts(selft):
        sql = "select * from taikhoan"
        result = execute_query('QLKhachSan', 'a' ,sql)
        return result