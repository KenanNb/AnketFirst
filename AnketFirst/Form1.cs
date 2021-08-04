using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketFirst
{
    public partial class Form1 : Form
    {
        string gender = "";
        string english = "";
        public List<Anket> Ankets { get; set; }
        public Form1()
        {
            InitializeComponent();
            Anket anket = new Anket
            {
                name = nameTxtb.Text,
                surname = surnameTxtb.Text,
                age = AgeTxtb.Text,
                Gender = gender,
                email = emailTxtb.Text,
                phone = maskedTextBox1.Text,
                DateOfBirth = Convert.ToDateTime(maskedTextBox2.Text),
                language_name = english,
                profession = professionTxtb.Text
            };

            Ankets.Add(anket);
            //AnketlistBox.DataSource = Ankets;
            //AnketlistBox.DisplayMember = "name";

        }

        private void MaleRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRbtn.Checked)
            {
                gender = "Male";
            }
        }

        private void FemaleRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRBtn.Checked)
            {
                gender = "Female";
            }
        }

        private void englishCckb_CheckedChanged(object sender, EventArgs e)
        {
            if (englishCckb.Checked)
            {
                english = "Knovs English very well!";
            }
            else
            {
                english = "He don't know English!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (var item in Ankets)
            //{
             FileHelper.JsonSerialization<Anket>(ref Ankets,nameTxtb.Text);
            //}
            MessageBox.Show("Anket added to json!");

        }

        private void printBtn_Click(object sender, EventArgs e)
        {            
            AnketlistBox= FileHelper.JsonDeserialize<Anket>(ref Ankets, nameTxtb.Text);
        }
    }
}
