using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddressDemo
{
    public partial class FrmAddressBook : Form
    {
        public FrmAddressBook()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists("addressbook.csv"))
                {
                    string[] arrline = File.ReadAllLines("addressbook.csv");
                    if (arrline.Length > 0)
                    {
                        foreach (string item in arrline)
                        {
                            if (item.Trim() == "") continue;
                            string[] arrItem = item.Split(';');
                            this.dgvData.Rows.Add(new String[] {
                                arrItem[0],arrItem[1],arrItem[2],
                                arrItem[3],arrItem[4],arrItem[5],
                            });
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.lbBanyakRecordData.Text = $"{this.dgvData.Rows.Count.ToString("n0")} Record data.";
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmAddressBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(true);
            if (form.Run(form))
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvData.SelectedRows.Count > 0)
            {

                DataGridViewRow row = this.dgvData.SelectedRows[0];
                AddressBook addrBook = new AddressBook();
                addrBook.Nama = row.Cells[0].Value.ToString();
                addrBook.Alamat = row.Cells[1].Value.ToString();
                addrBook.Kota = row.Cells[2].Value.ToString();
                addrBook.NoHp = row.Cells[3].Value.ToString();
                addrBook.TanggalLahir = Convert.ToDateTime(row.Cells[4].Value).Date;
                addrBook.Email = row.Cells[5].Value.ToString();
                Form1 form = new Form1(false, addrBook);
                if (form.Run(form))
                {
                    LoadData();
                }
            }
        }


    }
}

