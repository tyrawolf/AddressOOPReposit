using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddressDemo
{
    public class AddressBookController
    {
        public List<AddressBook> listData { get; set; } = null;
        public AddressBookController() //constructer 
        {
            listData = new List<AddressBook>();
            try
            {
                if (File.Exists(Properties.Settings.Default.NamaFile))
                {
                    string[] fileContent = File.ReadAllLines(Properties.Settings.Default.NamaFile);
                    foreach (string item in fileContent)
                    {
                        string[] arrItem = item.Split(';');
                        listData.Add(new AddressBook
                        {
                            Nama = arrItem[0].Trim(),
                            Alamat = arrItem[1].Trim(),
                            Kota = arrItem[2].Trim(),
                            NoHp = arrItem[3].Trim(),
                            TanggalLahir = Convert.ToDateTime(arrItem[4]),
                            Email = arrItem[5].Trim()
                        });

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // method 2

        private void Add(string[] data, bool _addMode)
        {
            try
            {
                //simpan data
                if (_addMode)
                {
                    using (var fs = new FileStream("addressbook.csv", FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine($"{data[0].Trim()};{data[1].Trim()};{data[2].Trim()};{data[3].Trim()};{data[4].Trim()};{data[5].Trim()}");
                        }
                    }

                    MessageBox.Show("Your data has been added Successfully...", "Information", MessageBoxButtons.OK);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Edit(string[] data, bool _addMode, int _row)
        {
            try
            {
                if (!_addMode)
                {
                    using (var fs = new FileStream("addressbook.csv", FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine($"{data[0].Trim()};{data[1].Trim()};{data[2].Trim()};{data[3].Trim()};{data[4].Trim()};{data[5].Trim()}");
                        }
                    }
                    MessageBox.Show("Your data has been edited Successfully...", "Information", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Filter(string[] data, DataGridView dgvData)
        {
            if (File.Exists("addressbook.csv"))
            {

            }
        }
    }
}
