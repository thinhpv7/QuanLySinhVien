using System;
using System.Data;
using System.Data.SqlClient;
using DataProvider;

namespace DBBusiness
{
   
    public class DBBusinessLayer
    {
        DBLayer db;
        public DBBusinessLayer()
        {
            db = new DBLayer();
        }
        //lấy danh sách thành phố
        public DataSet getThanhPho()
        {
            return db.ExecuteQueryDataSet("getThanhPho",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách sinh viên
        public DataSet getSinhVien()
        {
            return db.ExecuteQueryDataSet("getSinhVien",
                CommandType.StoredProcedure,
                null);
        }
        //Lấy danh sách lớp
        public DataSet getLop()
        {
            return db.ExecuteQueryDataSet("getLop",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách ngành
        public DataSet getNganhHoc()
        {
            return db.ExecuteQueryDataSet("getNganhHoc",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách môn học
        public DataSet getMonHoc()
        {
            return db.ExecuteQueryDataSet("getMonHoc",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách giáo viên
        public DataSet getGiaoVien()
        {
            return db.ExecuteQueryDataSet("getGiaoVien",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách điểm
        public DataSet getDiem()
        {
            return db.ExecuteQueryDataSet("getDiem",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách khóa học
        public DataSet getKhoaHoc()
        {
            return db.ExecuteQueryDataSet("getKhoaHoc",
                CommandType.StoredProcedure,
                null);
        }
        //lấy danh sách khoa
        public DataSet getKhoa()
        {
            return db.ExecuteQueryDataSet("getKhoa",
                CommandType.StoredProcedure,
                null);
        }
        //thêm lớp mới
        public bool insertLop(ref string err, string maLop, string tenLop, string siSo, string maKhoaHoc, string maNganh)
        {
            return db.MyExecuteNonQuery("spInsertLop",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@tenLop", tenLop),
                new SqlParameter("@siSo", siSo),
                new SqlParameter("@maKhoaHoc", maKhoaHoc),
                new SqlParameter("@maNganh", maNganh));
        }
        //xóa lớp
        public bool deleteLop(ref string err, string maLop)
        {
            return db.MyExecuteNonQuery("spDeleteLop2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maLop", maLop));
        }
        //cập nhật lại lớp
        public bool updateLop(ref string err, string maLop, string tenLop, string siSo, string maKhoaHoc, string maNganh)
        {
            return db.MyExecuteNonQuery("spUpdateLop",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maLop", maLop),
                new SqlParameter("@tenLop", tenLop),
                new SqlParameter("@siSo", siSo),
                new SqlParameter("@maKhoaHoc", maKhoaHoc),
                new SqlParameter("@maNganh", maNganh));
        }

        //thêm sinh viên
        public bool insertSinhVien(ref string err, int MSSV, string tenSV, string gioiTinh,
            string ngaySinh, string noiSinh, string diaChi, string soDienThoai, string maLop)
        {
            return db.MyExecuteNonQuery("spInsertSinhVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MSSV", MSSV),
                new SqlParameter("@tenSV", tenSV),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@noiSinh", noiSinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@maLop", maLop));
        }
        //xóa sinh viên
        public bool deleteSinhVien(ref string err, int maSV)
        {
            return db.MyExecuteNonQuery("spDeleteSinhVien2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maSV", maSV));
        }
        //cập nhật lại sinh viên
        public bool updateSinhVien(ref string err, int MSSV, string tenSV, string gioiTinh, 
            string ngaySinh, string noiSinh, string diaChi, string soDienThoai, string maLop)
        {
            return db.MyExecuteNonQuery("spUpdateSinhVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MSSV", MSSV),
                new SqlParameter("@tenSV", tenSV),
                new SqlParameter("@gioiTinh", gioiTinh),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@noiSinh", noiSinh),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@maLop", maLop));
        }
        //thêm môn học mới
        public bool insertMonHoc(ref string err, string maMonHoc, string tenMonHoc, string soTinChi)
        {
            return db.MyExecuteNonQuery("spInsertMonHoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maMonHoc", maMonHoc),
                new SqlParameter("@tenMonHoc", tenMonHoc),
                new SqlParameter("@soTinChi", soTinChi));
        }

        //xóa môn học
        public bool deleteMonHoc(ref string err, string maMonHoc)
        {
            return db.MyExecuteNonQuery("spDeleteMonHoc2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maMonHoc", maMonHoc));
        }

        //cập nhật môn học
        public bool updateMonHoc(ref string err, string maMonHoc, string tenMonHoc, string soTinChi)
        {
            return db.MyExecuteNonQuery("spUpdateMonHoc",
               CommandType.StoredProcedure, ref err,
                new SqlParameter("@maMonHoc", maMonHoc),
                new SqlParameter("@tenMonHoc", tenMonHoc),
                new SqlParameter("@soTinChi", soTinChi));
        }

        //thêm khóa học mới
        public bool insertKhoaHoc(ref string err, string maKhoaHoc, string tenKhoaHoc)
        {
            return db.MyExecuteNonQuery("spInsertKhoaHoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maKhoaHoc", maKhoaHoc),
                new SqlParameter("@tenKhoaHoc", tenKhoaHoc));
        }

        //xóa khóa học
        public bool deleteKhoaHoc(ref string err, string maKhoaHoc)
        {
            return db.MyExecuteNonQuery("spDeleteKhoaHoc2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maKhoaHoc", maKhoaHoc));
        }

        //cập nhật khóa học
        public bool updateKhoaHoc(ref string err, string maKhoaHoc, string tenKhoaHoc)
        {
            return db.MyExecuteNonQuery("spUpdateKhoaHoc",
                 CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maKhoaHoc", maKhoaHoc),
                 new SqlParameter("@tenKhoaHoc", tenKhoaHoc));
        }
        //thêm ngành học mới
        public bool insertNganhHoc(ref string err, string maNganh, string tenNganh, string maKhoa)
        {
            return db.MyExecuteNonQuery("spInsertNganhHoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maNganh", maNganh),
                new SqlParameter("@tenNganh", tenNganh),
                new SqlParameter("@maKhoa", maKhoa));
        }

        //xóa ngành học
        public bool deleteNganhHoc(ref string err, string maNganh)
        {
            return db.MyExecuteNonQuery("spDeleteNganhHoc2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maNganh", maNganh));
        }

        //cập nhật ngành học
        public bool updateNganhHoc(ref string err, string maNganh, string tenNganh, string maKhoa)
        {
            return db.MyExecuteNonQuery("spUpdateNganhHoc",
                 CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maNganh", maNganh),
                 new SqlParameter("@tenNganh", tenNganh),
                  new SqlParameter("@maKhoa", maKhoa));
        }

        //thêm khoa mới
        public bool insertKhoa(ref string err, string maKhoa, string tenKhoa)
        {
            return db.MyExecuteNonQuery("spInsertKhoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maKhoa", maKhoa),
                new SqlParameter("@tenKhoa", tenKhoa));
        }

        //xóa khóa học
        public bool deleteKhoa(ref string err, string maKhoa)
        {
            return db.MyExecuteNonQuery("spDeleteKhoa2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maKhoa", maKhoa));
        }

        //cập nhật khoa
        public bool updateKhoa(ref string err, string maKhoa, string tenKhoa)
        {
            return db.MyExecuteNonQuery("spUpdateKhoa",
                 CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maKhoa", maKhoa),
                 new SqlParameter("@tenKhoa", tenKhoa));
        }
        //thêm điểm mới
        public bool insertDiem(ref string err, string maSV, string maMonHoc, string hocKi, string diemLan1, string diemLan2, string diemThi)
        {
            return db.MyExecuteNonQuery("spInsertDiem",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@maMonHoc", maMonHoc),
                new SqlParameter("@hocKi", hocKi),
                new SqlParameter("@diemLan1", diemLan1),
                new SqlParameter("@diemLan2", diemLan2),
                new SqlParameter("@diemThi", diemThi));
        }

        //xóa khóa học
        public bool deleteDiem(ref string err, string maSV, string maMonHoc)
        {
            return db.MyExecuteNonQuery("spDeleteDiem",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@maMonHoc", maMonHoc));
        }

        //cập nhật điểm
        public bool updateDiem(ref string err, string maSV, string maMonHoc, string hocKi, string diemLan1, string diemLan2, string diemThi)
        {
            return db.MyExecuteNonQuery("spUpdateDiem",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maSV", maSV),
                new SqlParameter("@maMonHoc", maMonHoc),
                new SqlParameter("@hocKi", hocKi),
                new SqlParameter("@diemLan1", diemLan1),
                new SqlParameter("@diemLan2", diemLan2),
                new SqlParameter("@diemThi", diemThi));
        }
        //thêm giáo viên
        public bool insertGiaoVien(ref string err, string maGV, string tenGV, string maKhoa)
        {
            return db.MyExecuteNonQuery("spInsertGiaoVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@tenGV", tenGV),
                new SqlParameter("@maKhoa", maKhoa));
        }
        //xóa giáo viên
        public bool deleteGiaoVien(ref string err, string maGiaoVien)
        {
            return db.MyExecuteNonQuery("spDeleteGiaoVien2",
                CommandType.StoredProcedure,
                ref err,
                new SqlParameter("@maGiaoVien", maGiaoVien));
        }

        //
        public bool updateGiaoVien(ref string err, string maGV, string tenGV, string maKhoa)
        {
            return db.MyExecuteNonQuery("spUpdateGiaoVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@maGV", maGV),
                new SqlParameter("@tenGV", tenGV),
                new SqlParameter("@maKhoa", maKhoa));
        }


        //danh sách lớp theo khóa học
        public DataSet getLopTheoKhoaHoc(string maKhoaHoc)
        {
            return db.ExecuteQueryDataSet1("spLopTheoKhoaHoc",
                CommandType.StoredProcedure,
                new SqlParameter("@maKhoaHoc", maKhoaHoc));
        }
        //danh sách sinh viên theo lớp
        public DataSet getSinhVienTheoLop(string maLop)
        {
            return db.ExecuteQueryDataSet1("spSinhVienTheoLop",
                CommandType.StoredProcedure,
                new SqlParameter("@maLop", maLop));
        }

        //danh sách sinh viên theo khoa học
        public DataSet getSinhVienTheoKhoaHoc(string maKhoaHoc)
        {
            return db.ExecuteQueryDataSet1("spSinhVienTheoKhoaHoc",
                CommandType.StoredProcedure,
                new SqlParameter("@maKhoaHoc", maKhoaHoc));
        }

        //lấy danh sách lớp theo ngành
        public DataSet getLopTheoNganh(string maNganh)
        {
            return db.ExecuteQueryDataSet1("spLopTheoNganh",
                CommandType.StoredProcedure,
                new SqlParameter("@maNganh", maNganh));
        }

        //lấy danh sách sinh viên theo ngành
        public DataSet getSinhVienTheoNganh(string maNganh)
        {
            return db.ExecuteQueryDataSet1("spSinhVienTheoNganh",
                CommandType.StoredProcedure,
                new SqlParameter("@maNganh", maNganh));
        }
        //lấy danh sách lớp theo khoa
        public DataSet getLopTheoKhoa(string maKhoa)
        {
            return db.ExecuteQueryDataSet1("spLopTheoKhoa",
                CommandType.StoredProcedure,
                new SqlParameter("@maKhoa", maKhoa));
        }

        //lấy danh sách sinh viên theo khoa
        public DataSet getSinhVienTheoKhoa(string maKhoa)
        {
            return db.ExecuteQueryDataSet1("spSinhVienTheoKhoa",
                CommandType.StoredProcedure,
                new SqlParameter("@maKhoa", maKhoa));
        }

        //lấy danh sách sinh viên theo môn học
        public DataSet getSinhVienTheoMonHoc(string maMonHoc)
        {
            return db.ExecuteQueryDataSet1("spSinhVienTheoMonHoc",
                CommandType.StoredProcedure,
                new SqlParameter("@maMonHoc", maMonHoc));
        }

        //lấy danh sách giáo viên theo môn học
        public DataSet getGiaoVienTheoMonHoc(string maMonHoc)
        {
            return db.ExecuteQueryDataSet1("spGiaoVienTheoMonHoc",
                CommandType.StoredProcedure,
                new SqlParameter("@maMonHoc", maMonHoc));
        }

    }
}
