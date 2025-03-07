namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {






        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnglish_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScience_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilipino_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

            
        }

        private void aveg_result_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void General_Average_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double english = Convert.ToDouble(txtEnglish.Text);
            double math = Convert.ToDouble(txtMath.Text);
            double science = Convert.ToDouble(txtScience.Text);
            double filipino = Convert.ToDouble(txtFilipino.Text);
            double history = Convert.ToDouble(txtHistory.Text);

            double average = (english + math + science + filipino + history) / 5;
            string result = (average >= 75) ? "Passed" : "Failed";

            General_Average.Text = "The student {result}.\nThe general average of {name} is {average:F2}.";
        }
    }
}
