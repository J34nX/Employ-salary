using System.Windows.Forms;

namespace Employ
{
    public partial class Form1 : Form
    {
        private string firstname, lastname, jobtitle, department;
        private double hour, salary;
        private int workhr;

        public Form1()
        {
            InitializeComponent(); 
            this.firstname = string.Empty;
            this.lastname = string.Empty;
            this.jobtitle = string.Empty;
            this.department = string.Empty;
            this.workhr = 0;
            this.hour = 0;
            this.salary = 0;
        }

        public Form1(string fname, string lname, string jobTitle, string depart, double hr, double jSalary, int whour)
        {
            InitializeComponent();
            this.firstname = fname;
            this.lastname = lname;
            this.department = depart;
            this.jobtitle = jobTitle;
            this.workhr = whour;
            this.hour = hr;
            this.salary = jSalary;
        }

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Jobtitle
        {
            get { return this.jobtitle; }
            set { this.jobtitle = value; }
        }

        public int Workinghour
        {
            get { return this.workhr; }
            set { this.workhr = value; }
        }

        public double Hour
        {
            get { return this.hour; }
            set { this.hour = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string invalidMessage = "Please complete your data.";
            double parsedHour, parsedSalary;

           
            Firstname = FnameTB.Text;
            Lastname = LnameTB.Text;
            jobtitle = JobtitetB.Text;
            department = DepartTB.Text;

            
            if (double.TryParse(ratehrTB.Text, out parsedHour) && int.TryParse(WhrTB.Text, out workhr))
            {
                hour = parsedHour;
                
                salary = workhr * hour;

                
                FnameLB.Text = Firstname;
                LnameLB.Text = Lastname;
                BasicSTB.Text = salary.ToString("F2");
            }
            else
            {
                MessageBox.Show(invalidMessage);
            }
        }

        private void FnameLB_Click(object sender, EventArgs e)
        {
            
        }

        private void LnameLB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
