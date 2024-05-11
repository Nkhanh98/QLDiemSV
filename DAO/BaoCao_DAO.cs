using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCao_DAO
    {
        static SqlConnection con;

        public static object  LayDSBaoCao()
        {
            string sTruyVan = @"select distinct  sv.masv as 'Mã sinh viên' ,sv.tensv as 'Tên sinh viên' ,m.tenmh as 'Tên môn học' ,d.hocky as 'Học kỳ' ,d.diemlan1 as 'Điểm lần 1' ,d.diemlan2 as 'Điểm lần 2'
                                from diem d , sinhvien sv , MonHoc m
                                where d.masv = sv.masv and m.mamh = d.mamh";

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            return dt;
        }
    }
}
