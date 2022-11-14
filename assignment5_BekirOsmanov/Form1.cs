namespace assignment5_BekirOsmanov 
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int randomNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void guess_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNum = random.Next(1,101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = 0;
            if (!(int.TryParse(guess_box.Text, out guess)))
            {
                info_lbl.Text = "Please full the guess box";
                return;
            }
            if(guess < 1 ||  guess > 100)
            {
                info_lbl.Text = "Enter the correct number please";
                return;
            }
            if (guess < randomNum)
            {
                info_lbl.Text = "Too low";
            }
            if (guess > randomNum)
            {
                info_lbl.Text = "Too high";
            }
            if (guess == randomNum)
            {
                info_lbl.Text = "Winner! You are right!";
            }
        }
    }
}