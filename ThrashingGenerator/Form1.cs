namespace ThrashingGenerator
{
    public partial class Form1 : Form
    {
        Thread thrasher;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            flag = true;
            for (int i = 0; i < 10; i++)
            {
                thrasher = new Thread(() => Thrash());
                thrasher.Start();

            }

        }

        private void Thrash()
        {
            int size = 2048;
            while (flag)
            {
                int[,] data = new int[size, size];
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;

            flag = false;
            
        }
    }
}