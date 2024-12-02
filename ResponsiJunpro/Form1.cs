using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using npgsql;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        String connstring = "Host=localhost;Port=5432;Username=postgres;Password=ZakkysitepU99*;database=Responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtNamaKaryawan.Text = r.Cells["_nama"].ValueToString();
                txtDepKaryawan.Text = r.Cells["_departemen"].ValueToString();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = @"select * from st_insert(:_nama,:_departemen)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_nama", txtNamaKaryawan);
                cmd.Parameters.AddWithValue("_departemen", txtDepKaryawan);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil Dimasukkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memasukkan Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();

                string sql = @"Select * from st_update(:_nama,:_departemen)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_nama", txtNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_departemen", txtDepKaryawan.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("data Users Berhasil Diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close(); //Untuk Memutuskan koneksi ke postgresql setelah melakukan update, dapat dihilangkan jika mau 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan didelete", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();

                string sql = @"Select * from st_delete (:_nama,:_departemen)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql,conn);

                cmd.

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete GAGAL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
