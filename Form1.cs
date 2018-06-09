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
using System.Text.RegularExpressions;

namespace AddressDemo
{
    public partial class Form1 : Form
    {

        bool _result = false;
        bool _addMode = false; // true  : add item, false : edit Item
        AddressBook _addrBook = null;

        public bool Run(Form1 form)
        {
            form.ShowDialog();
            return _result;
        }
        public Form1(bool addMode, AddressBook addrBook = null) 
        {
            InitializeComponent();
            _addMode = addMode;
            if (addrBook != null)
            {
                _addrBook = addrBook;
                this.txtNama.Text = addrBook.Nama;
                this.txtAlamat.Text = addrBook.Alamat;
                this.textKota.Text = addrBook.Kota;
                this.txtnomor.Text = addrBook.NoHp;
                this.dtpTanggalLahir.Value = addrBook.TanggalLahir.Date;
                this.txtEmail.Text = addrBook.Email;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.txtNama.Text.Trim() == "")// jika nama kosong
            {
                MessageBox.Show("Sorry, Nama wajib isi..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtAlamat.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Alamat wajib isi..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textKota.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Kota wajib isi..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtnomor.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Nomor Telepon wajib isi..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Email wajib isi..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_addMode)
                    {
                        using (FileStream fs = new FileStream("addressbook.csv", FileMode.Append, FileAccess.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                writer.WriteLine($"{txtNama.Text.Trim()};{txtAlamat.Text.Trim()};" +
                                    $"{textKota.Text.Trim()};{txtnomor.Text.Trim()};" +
                                    $"{dtpTanggalLahir.Text.Trim()};{txtEmail.Text.Trim()}");
                            }
                        }
                    }

                    else
                    {

                    }
                    _result = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
    }
}



