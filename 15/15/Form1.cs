using System.Media;
using System.Diagnostics;
namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath+ "\\SND\\1.wav");
        SoundPlayer simpleSound2 = new SoundPlayer(Application.StartupPath + "\\SND\\2.wav");
        SoundPlayer simpleSound3 = new SoundPlayer(Application.StartupPath + "\\SND\\3.wav");
        Bitmap[] ar = new Bitmap[16];
        static public Image newImage = Image.FromFile(Application.StartupPath + "\\PZL\\1.jpg");
        Bitmap bmp = new Bitmap(newImage);
        private readonly Stopwatch stopwatch = new Stopwatch();
        bool SoundOrNot = true;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.BackgroundImage == null)
            {
                button2.BackgroundImage = button1.BackgroundImage;
                button1.BackgroundImage = null;
                if(SoundOrNot == true)
                {
                    simpleSound.Play();
                }
                
            }
            if (button5.BackgroundImage == null)
            {
                button5.BackgroundImage = button1.BackgroundImage;
                button1.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button1.BackgroundImage == null)
            {
                button1.BackgroundImage = button2.BackgroundImage;
                button2.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button3.BackgroundImage == null)
            {
                button3.BackgroundImage = button2.BackgroundImage;
                button2.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button6.BackgroundImage == null)
            {
                button6.BackgroundImage = button2.BackgroundImage;
                button2.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.BackgroundImage == null)
            {
                button2.BackgroundImage = button3.BackgroundImage;
                button3.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button4.BackgroundImage == null)
            {
                button4.BackgroundImage = button3.BackgroundImage;
                button3.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button7.BackgroundImage == null)
            {
                button7.BackgroundImage = button3.BackgroundImage;
                button3.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.BackgroundImage == null)
            {
                button3.BackgroundImage = button4.BackgroundImage;
                button4.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button8.BackgroundImage == null)
            {
                button8.BackgroundImage = button4.BackgroundImage;
                button4.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.BackgroundImage == null)
            {
                button1.BackgroundImage = button5.BackgroundImage;
                button5.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button6.BackgroundImage == null)
            {
                button6.BackgroundImage = button5.BackgroundImage;
                button5.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button9.BackgroundImage == null)
            {
                button9.BackgroundImage = button5.BackgroundImage;
                button5.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.BackgroundImage == null)
            {
                button2.BackgroundImage = button6.BackgroundImage;
                button6.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button5.BackgroundImage == null)
            {
                button5.BackgroundImage = button6.BackgroundImage;
                button6.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button7.BackgroundImage == null)
            {
                button7.BackgroundImage = button6.BackgroundImage;
                button6.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button10.BackgroundImage == null)
            {
                button10.BackgroundImage = button6.BackgroundImage;
                button6.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.BackgroundImage == null)
            {
                button3.BackgroundImage = button7.BackgroundImage;
                button7.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button6.BackgroundImage == null)
            {
                button6.BackgroundImage = button7.BackgroundImage;
                button7.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button8.BackgroundImage == null)
            {
                button8.BackgroundImage = button7.BackgroundImage;
                button7.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button11.BackgroundImage == null)
            {
                button11.BackgroundImage = button7.BackgroundImage;
                button7.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.BackgroundImage == null)
            {
                button4.BackgroundImage = button8.BackgroundImage;
                button8.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button7.BackgroundImage == null)
            {
                button7.BackgroundImage = button8.BackgroundImage;
                button8.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button12.BackgroundImage == null)
            {
                button12.BackgroundImage = button8.BackgroundImage;
                button8.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.BackgroundImage == null)
            {
                button5.BackgroundImage = button9.BackgroundImage;
                button9.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button10.BackgroundImage == null)
            {
                button10.BackgroundImage = button9.BackgroundImage;
                button9.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button13.BackgroundImage == null)
            {
                button13.BackgroundImage = button9.BackgroundImage;
                button9.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.BackgroundImage == null)
            {
                button6.BackgroundImage = button10.BackgroundImage;
                button10.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button9.BackgroundImage == null)
            {
                button9.BackgroundImage = button10.BackgroundImage;
                button10.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button11.BackgroundImage == null)
            {
                button11.BackgroundImage = button10.BackgroundImage;
                button10.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button14.BackgroundImage == null)
            {
                button14.BackgroundImage = button10.BackgroundImage;
                button10.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.BackgroundImage == null)
            {
                button7.BackgroundImage = button11.BackgroundImage;
                button11.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button10.BackgroundImage == null)
            {
                button10.BackgroundImage = button11.BackgroundImage;
                button11.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button12.BackgroundImage == null)
            {
                button12.BackgroundImage = button11.BackgroundImage;
                button11.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button15.BackgroundImage == null)
            {
                button15.BackgroundImage = button11.BackgroundImage;
                button11.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.BackgroundImage == null)
            {
                button8.BackgroundImage = button12.BackgroundImage;
                button12.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button11.BackgroundImage == null)
            {
                button11.BackgroundImage = button12.BackgroundImage;
                button12.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button16.BackgroundImage == null)
            {
                button16.BackgroundImage = button12.BackgroundImage;
                button12.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.BackgroundImage == null)
            {
                button9.BackgroundImage = button13.BackgroundImage;
                button13.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button14.BackgroundImage == null)
            {
                button14.BackgroundImage = button13.BackgroundImage;
                button13.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.BackgroundImage == null)
            {
                button10.BackgroundImage = button14.BackgroundImage;
                button14.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button13.BackgroundImage == null)
            {
                button13.BackgroundImage = button14.BackgroundImage;
                button14.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button15.BackgroundImage == null)
            {
                button15.BackgroundImage = button14.BackgroundImage;
                button14.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.BackgroundImage == null)
            {
                button11.BackgroundImage = button15.BackgroundImage;
                button15.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button14.BackgroundImage == null)
            {
                button14.BackgroundImage = button15.BackgroundImage;
                button15.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button16.BackgroundImage == null)
            {
                button16.BackgroundImage = button15.BackgroundImage;
                button15.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.BackgroundImage == null)
            {
                button12.BackgroundImage = button16.BackgroundImage;
                button16.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            if (button15.BackgroundImage == null)
            {
                button15.BackgroundImage = button16.BackgroundImage;
                button16.BackgroundImage = null;
                if (SoundOrNot == true)
                {
                    simpleSound.Play();
                }
            }
            /////Check win or not
           if(button1.BackgroundImage == ar[0] && button2.BackgroundImage == ar[1]
                && button3.BackgroundImage == ar[2] && button4.BackgroundImage == ar[3]
                && button5.BackgroundImage == ar[4] && button6.BackgroundImage == ar[5]
                && button7.BackgroundImage == ar[6] && button8.BackgroundImage == ar[7]
                && button9.BackgroundImage == ar[8] && button10.BackgroundImage == ar[9]
                && button11.BackgroundImage == ar[10] && button12.BackgroundImage == ar[11]
                && button13.BackgroundImage == ar[12] && button14.BackgroundImage == ar[13]
                && button15.BackgroundImage == ar[14])
            
            {
                button16.BackgroundImage = ar[15];
                simpleSound3.Play();
                stopwatch.Stop();
            }


        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.InitialDirectory = Application.StartupPath + "\\PZL";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    newImage = Image.FromFile(ofd.FileName);


                    Bitmap bmp = new Bitmap(newImage);
                    Bitmap[] CutImage(Bitmap bmp, int w, int h)
                    {
                        /// Количество кусков по горизонтали и вертикали.
                        int nX = bmp.Width / w, nY = bmp.Height / h;
                        int n = nX * nY;
                        Bitmap[] ar = new Bitmap[n];
                        for (int i = 0; i < nY; i++)
                        {
                            for (int j = 0; j < nX; j++)
                            {
                                ar[j + i * nX] = new Bitmap(bmp.Clone(new Rectangle(j * w, i * h, w, h), bmp.PixelFormat));
                            }
                        }
                        return ar;

                    }


                    ar = CutImage(bmp, 150, 150);
                    button1.BackgroundImage = ar[0];
                    button2.BackgroundImage = ar[1];
                    button3.BackgroundImage = ar[2];
                    button4.BackgroundImage = ar[3];
                    button5.BackgroundImage = ar[4];
                    button6.BackgroundImage = ar[5];
                    button7.BackgroundImage = ar[6];
                    button8.BackgroundImage = ar[7];
                    button9.BackgroundImage = ar[8];
                    button10.BackgroundImage = ar[9];
                    button11.BackgroundImage = ar[10];
                    button12.BackgroundImage = ar[11];
                    button13.BackgroundImage = ar[12];
                    button14.BackgroundImage = ar[13];
                    button15.BackgroundImage = ar[14];
                    button16.BackgroundImage = ar[15];
                    button19.Visible = true;
                    button18.Visible = true;
                    button19.Enabled = true;
                    button18.Enabled = true;
                    stopwatch.Restart();
                    stopwatch.Stop();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Необходимо окрыть каритнку 600х600.");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            simpleSound2.Play();
            SoundOrNot = false;
            button16.BackgroundImage = null;
           
            for (int i = 0; i < 1000; i++)
            {
                int BTN = new Random().Next(1, 16);
                switch (BTN)
                {
                    case 1:
                        button1_Click(sender, e);
                        break;
                    case 2:
                        button2_Click(sender, e);
                        break;
                    case 3:
                        button3_Click(sender, e);
                        break;
                    case 4:
                        button4_Click(sender, e);
                        break;
                    case 5:
                        button5_Click(sender, e);
                        break;
                    case 6:
                        button6_Click(sender, e);
                        break;
                    case 7:
                        button7_Click(sender, e);
                        break;
                    case 8:
                        button8_Click(sender, e);
                        break;
                    case 9:
                        button9_Click(sender, e);
                        break;
                    case 10:
                        button10_Click(sender, e);
                        break;
                    case 11:
                        button11_Click(sender, e);
                        break;
                    case 12:
                        button12_Click(sender, e);
                        break;
                    case 13:
                        button13_Click(sender, e);
                        break;
                    case 14:
                        button14_Click(sender, e);
                        break;
                    case 15:
                        button15_Click(sender, e);
                        break;
                    case 16:
                        button16_Click(sender, e);
                        break;
                }
            }
            SoundOrNot = true;
            stopwatch.Start();
            stopwatch.Restart();
            timer1.Start();
            button18.Visible = false;
            button18.Enabled = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (newImage != null)
            {
                Form2 form2 = new Form2();
                form2.pictureBox1.Image = newImage;
                form2.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = stopwatch.Elapsed.ToString("mm\\:ss");
        }
    }
}