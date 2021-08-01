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
            listBox1.DataSource = Ankets;
            listBox1.DisplayMember = "name";

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

            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(nameTxtb.Text + ".json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, Ankets);
                }
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Anket[] Ankets = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(nameTxtb.Text + ".json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    Ankets = serializer.Deserialize<Anket[]>(jr);
                }
                foreach (var item in Ankets)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
