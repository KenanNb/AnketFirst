using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketFirst
{
    [DefaultBindingProperty("Name")]
    public class Anket
    {
        [Category("Id Settings"), Description("Name of the former")]
        public string name { get; set; }
        [Category("Id Settings"), Description("Surname of the former")]
        public string surname { get; set; }
        [Category("Id Settings"), Description("Age of the Anketter")]
        public string age { get; set; }
        [Category("Id Settings"), Description("Sex of the Anketter")]
        public string Gender { get; set; }
        [Category("Id Settings"), Description("Email of the Anketter")]
        public string email { get; set; }
        [Category("Id Settings"), Description("Phone number of the Anketter")]
        public string phone { get; set; }
        [Category("Id Settings"), Description("Birthday of the Anketter")]
        public DateTime DateOfBirth { get; set; }
        [Category("Id Settings"), Description("Can speak foreign language")]
        public string language_name { get; set; }
        [Category("Id Settings"), Description("Proffession of the Anketter")]
        public string profession { get; set; }

        public override string ToString()
        {
            return $"Name : {name}  Surname : {surname}  " +
                $"Age : {age}  Gender {Gender} Email : {email} " +
                $"Phone  : {phone} Date of birth : {DateOfBirth} " +
                $"Language : {language_name} Proffession : {profession}";
        }

    }
}
