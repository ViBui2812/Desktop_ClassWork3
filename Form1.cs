using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Desktop_ClassWork3
{
    public partial class Form1 : Form
    {
        Meo meo1;
        Dongvat[] thucung = new Dongvat[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            thucung[0] = new Meo("Be meo", 2, true);
            thucung[1] = new Ech("Chu ech xanh", 1, true);
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(thucung[0].An());
            listBox1.Items.Add(thucung[1].An());
        }

    }
    public class Dongvat
    {
        private string _name;
        private int _age;
        private bool _gender; //true is male; false is female
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { if (!(value < 0 || value > 200)) _age = value; }
        }
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Dongvat()
        {
            Name = string.Empty;
            Age = 0;
            Gender = true;
        }
        public Dongvat(string name_init, int age_init, bool gender_init)
        {
            Name = name_init;
            Age = age_init;
            Gender = gender_init;
        }

        public string Keu()
        {
            return "Động vật kêu";
        }
        public virtual string An()
        {
            return "Động vật ăn";
        }
    }
    class Meo : Dongvat
    {
        private string _maulong;
        public string Maulong { get => _maulong; set => _maulong = value; }
        public override string An()
        {
            return $"Meo { this.Name} {this.Age} tuoi dang an";
        }
        public Meo(string name_meoput, int age_meoput, bool gender_meoput) : base(name_meoput,age_meoput,gender_meoput)
        {
            
        }
    }
    class Ech : Dongvat
    {
        private string _mauda;
        public string Mauda { get => _mauda; set => _mauda = value; }
        public Ech(string name_echput, int age_echput, bool gender_echput) : base(name_echput, age_echput, gender_echput)
        {

        }
        public Ech()
        {

        }
        public override string An()
        {
            return $"Ech {this.Name} {this.Age} tuoi dang an";
        }
    }
}