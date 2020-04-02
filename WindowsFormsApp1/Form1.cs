using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataSet dsStudent;
        public Form1()
        {
            InitializeComponent();


           

            //Load student information
            try
            {
                //load student information(HO, TEN, NGAYSINH, NAM, MAKH) on dsStudent
                dsStudent = QLSVienDAO.GetStudentInformation();

                //display and set value on combobox
                cbb_StudentCode.DataSource = dsStudent.Tables[0];
                cbb_StudentCode.DisplayMember = "MASV";
                cbb_StudentCode.ValueMember = "MASV";



                // load first student information(HO, TEN, NGAYSINH, NAM, MAKH) by first code in cbb_StudentCode
                DataRow firstRow = dsStudent.Tables[0].Rows[0];
                txt_StudentInfo.Text = firstRow["HO"] + " " + firstRow["TEN"] + "; " + firstRow["NGAYSINH"] + "; "+ firstRow["GIOITINH"] + "; " + firstRow["MAKH"];


                //load student information 
                String studentCode = firstRow["MASV"].ToString();
                dgv_View.DataSource = QLSVienDAO.GetStudentInformationByStudentCode(studentCode).Tables[0];

                //set width size column
                dgv_View.Columns[0].Width = 150;
                dgv_View.Columns[1].Width = 300;
                dgv_View.Columns[2].Width = 100;
            }
            catch (Exception)
            {
                MessageBox.Show("Load data error!");
            }
        }

        private void dgv_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbb_MaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = cbb_StudentCode.SelectedIndex;
            String studentCode = cbb_StudentCode.Text;
            dgv_View.DataSource = QLSVienDAO.GetStudentInformationByStudentCode(studentCode).Tables[0];

            DataRow selectedRow = dsStudent.Tables[0].Rows[rowIndex];
            txt_StudentInfo.Text = selectedRow["HO"] + " " + selectedRow["TEN"] + "; " + selectedRow["NGAYSINH"] + "; " + selectedRow["GIOITINH"] + "; " + selectedRow["MAKH"];

        }

        private void txt_ThongTinSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}
