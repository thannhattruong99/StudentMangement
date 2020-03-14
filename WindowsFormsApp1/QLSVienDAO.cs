using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class QLSVienDAO
    {
        //get student information: MASV, HO, TEN, NGAYSINH, NAM, MAKH
        public static DataSet GetStudentInformation()
        {
            SqlConnection scon = DBUtils.GetDBConnection();
            String sqlStr = "SELECT MASV, HO, TEN, NGAYSINH, GIOITINH, MAKH FROM SVIEN";
            try
            {
                scon.Open();

                SqlDataAdapter daStudent = new SqlDataAdapter(sqlStr, scon);
                DataSet dsStudent = new DataSet();
                daStudent.Fill(dsStudent);
                return dsStudent;
            }
            catch (Exception)
            {
                MessageBox.Show("Open Connection error");
            }
            finally
            {
                scon.Close();
            }
            return null;
        }

        //get student information(MAMH, TENMH, DIEM) by student code
        public static DataSet GetStudentInformationByStudentCode(String studentCode)
        {
            SqlConnection scon = DBUtils.GetDBConnection();
            String sqlStr = "SELECT kq.MAMH, mh.TENMH, kq.DIEM " +
                            "FROM MHOC mh, (SELECT kq.DIEM, hp.MAMH " +
                                            "FROM HPHAN hp, (SELECT MAHP, DIEM FROM KQUA WHERE MASV like '" + studentCode + "') kq " +
                                            "WHERE kq.MAHP = hp.MAHP) kq " +
                            "WHERE MH.MAMH = kq.MAMH";
            try
            {
                scon.Open();

                SqlDataAdapter daStudent = new SqlDataAdapter(sqlStr, scon);
                DataSet dsStudent = new DataSet();
                daStudent.Fill(dsStudent);

                return dsStudent;
            }
            catch (Exception)
            {
                MessageBox.Show("Open connection error!");
            }
            finally
            {
                scon.Close();
            }

            return null;
        }
    }
}
