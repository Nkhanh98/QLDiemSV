using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class Diem_DAO
    {
        static SqlConnection con;

        public static List<Diem_DTO> LayDSdiem()
        {
            //DISTINCT
            string sTruyVan = "SELECT  * FROM Diem";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
           
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Diem_DTO> lstDiem = new List<DTO.Diem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Diem_DTO lo = new Diem_DTO();
                var row = dt.Rows[i];
                lo.MaSV = dt.Rows[i]["MaSV"].ToString();
                lo.MaMH = dt.Rows[i]["MaMH"].ToString();
                lo.HocKy = int.Parse(dt.Rows[i]["HocKy"].ToString());
                lo.DiemLan1  = int.Parse(dt.Rows[i]["DiemLan1"].ToString());
                if(row["DiemLan2"].ToString() == "")
                {
                    lo.DiemLan2 = 0;
                }
                else
                {
                    lo.DiemLan2 = int.Parse(row["DiemLan2"].ToString());
                }
                lstDiem.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstDiem;
        }

        public static List<Diem_DTO> TimTheoMon(string mon)
        {
            string sTruyVan = string.Format(@"select * from Diem where MaMH = N'{0}'", mon);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Diem_DTO> lstDiem = new List<DTO.Diem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Diem_DTO lo = new Diem_DTO();
                var row = dt.Rows[i];
                lo.MaSV = dt.Rows[i]["MaSV"].ToString();
                lo.MaMH = dt.Rows[i]["MaMH"].ToString();
                lo.HocKy = int.Parse(dt.Rows[i]["HocKy"].ToString());
                lo.DiemLan1 = int.Parse(dt.Rows[i]["DiemLan1"].ToString());
                if (row["DiemLan2"].ToString() == "")
                {
                    lo.DiemLan2 = 0;
                }
                else
                {
                    lo.DiemLan2 = int.Parse(row["DiemLan2"].ToString());
                }


                lstDiem.Add(lo);
            }

            DataProvider.DongKetNoi(con); // Đóng kết nối sau khi hoàn tất

            return lstDiem;

        }

        public static Diem_DTO TimTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Diem where MaSV = N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Diem_DTO lo = new Diem_DTO();
            var row = dt.Rows[0];
            lo.MaSV = dt.Rows[0]["MaSV"].ToString();
            lo.MaMH = dt.Rows[0]["MaMH"].ToString();
            lo.HocKy = int.Parse(dt.Rows[0]["HocKy"].ToString());
            lo.DiemLan1 = int.Parse(dt.Rows[0]["DiemLan1"].ToString());
            if (row["DiemLan2"].ToString() == "")
            {
                lo.DiemLan2 = 0;
            }
            else
            {
                lo.DiemLan2 = int.Parse(row["DiemLan2"].ToString());
            }

            DataProvider.DongKetNoi(con);
            return lo;
        }

        // Thêm thông tin điểm
        public static bool ThemThongTinDiem(Diem_DTO di)
        {
            // Tạo chuỗi truy vấn để thêm vào cơ sở dữ liệu
            string sTruyVan = string.Format(@"insert into Diem values (N'{0}',N'{1}','{2}','{3}','{4}')", di.MaSV, di.MaMH, di.HocKy, di.DiemLan1, di.DiemLan2 );

            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;

        }
        // Sửa thông tin
        public static bool CapNhatDiem(Diem_DTO di)
        {
            // Tạo chuỗi truy vấn để cập nhật thông tin trong cơ sở dữ liệu
            string sTruyVan = string.Format(@"UPDATE Diem 
                              SET MaMH = N'{0}', 
                                  HocKy =  '{1}',
                                  DiemLan1 =  '{2}',
                                  DiemLan2 =  '{3}'
                              WHERE MaSV = N'{4}'", di.MaMH, di.HocKy, di.DiemLan1, di.DiemLan2 ,di.MaSV);

            con = DataProvider.MoKetNoi();
            bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return ketqua;
        }

        // Kiểm tra mã sinh viên có trong dữ lịệu không trước khi xóa
        public static bool KiemTra(string ma)
        {
            string sTruyVan = string.Format("SELECT * FROM Diem WHERE MaSV = N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable ketqua = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);

            // Kiểm tra số hàng trong bảng kết quả
            if (ketqua.Rows.Count > 0)
            {
                return true; // Trả về true nếu có ít nhất một hàng được trả về
            }
            return false; // Trả về false nếu không có hàng nào được trả về
        }

        public static bool XoaDiem(Diem_DTO di)
        {
            // Tạo chuỗi truy vấn để xóa khỏi cơ sở dữ liệu
            bool kiemtra = KiemTra(di.MaSV);
            if (kiemtra == false)
            {
                return false;
            }
            else
            {
                string sTruyVan = string.Format("DELETE FROM Diem WHERE MaSV = N'{0}'", di.MaSV);

                // Mở kết nối đến cơ sở dữ liệu
                con = DataProvider.MoKetNoi();
                bool ketqua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return ketqua;
            }
        }
    }
}
