using System.Data;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;
            if(buttonText == "=")
            {
                string ifade=label1.Text;
                double netice = İfadeQiymetlendir(ifade);
                label1.Text = netice.ToString();    
            }
            else if(buttonText == "C")
            {
                label1.Text="0";
            }
            else
            {
                if (label1.Text=="0")
                {
                    label1.Text=buttonText;
                }
                else
                {
                    label1.Text+=buttonText;
                }
            }
        }
        private double İfadeQiymetlendir(string ifade)
        {
            var dataTable=new DataTable();
            var result = dataTable.Compute(ifade, "");
            return Convert.ToDouble(result);
        }
    }
}