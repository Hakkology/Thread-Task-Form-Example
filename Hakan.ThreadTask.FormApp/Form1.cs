namespace Hakan.ThreadTask.FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        Random rnd;
        Thread th1;
        Thread th2;
        Thread th3;

        private void button3_Click(object? sender, EventArgs e)
        {
            th3 = new Thread(RedLines);
            th3.Start();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            th2 = new Thread(BlueLines);
            th2.Start();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            th1 = new Thread(OrangeLines);
            th1.Start();
        }



        private void Form1_Load(object? sender, EventArgs e)
        {
            rnd = new Random();
        }

        public void OrangeLines()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Orange, 5), 
                                                    new Rectangle(rnd.Next(0, this.Width), 
                                                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }

        public void BlueLines()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 5),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }

        public void RedLines()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 5),
                                                    new Rectangle(rnd.Next(0, this.Width),
                                                                  rnd.Next(0, this.Height), 30, 30));
                Thread.Sleep(100);
            }
        }


    }
}