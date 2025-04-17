namespace Lucky_Numbers
{
    public partial class Form1 : Form
    {

        private List<int> numbers;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            random = new Random();

            this.Text = "Random Number Generator";
            this.Size = new Size(500, 350);
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.MinimumSize = new Size(400, 300);
            this.MaximumSize = new Size(600, 450); 
            this.MaximizeBox = false;  
            this.MinimizeBox = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numbers = new List<int>();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaxNumber.Text, out int maxNumber) && maxNumber > 0)
            {
                if (numbers.Count == maxNumber)
                {
                    MessageBox.Show("All numbers have been generated!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, maxNumber + 1);
                } while (numbers.Contains(randomNumber));

                numbers.Add(randomNumber);
                lblNumber.Text = randomNumber.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
