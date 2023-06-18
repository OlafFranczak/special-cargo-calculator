namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int capacity = 0, num = 0, price = 0, sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            capacity = 16;
            button2.Hide();
            button3.Hide();
            button4.Show();
            button5.Show();
            button6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capacity = 42;
            button1.Hide();
            button3.Hide();
            button4.Show();
            button5.Show();
            button6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            capacity = 111;
            button1.Hide();
            button2.Hide();
            button4.Show();
            button5.Show();
            button6.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Hide();
            button6.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to restart application ?"," ",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button6.Hide();

            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();

            num = 2;
            price = 8000;
            if (capacity == 16)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (240000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2*(price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2*(capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (240000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 42)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (735000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (735000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 111)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (4200000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (4200000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Hide();

            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();

            num = 3;
            price = 18000;
            if (capacity == 16)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (240000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (240000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 42)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (735000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (735000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 111)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (4200000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (4200000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = 1;
            button5.Hide();
            button6.Hide();

            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();

            price = 2000;
            if (capacity == 16)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (240000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (240000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 42)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2 * (735000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (735000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
            if (capacity == 111)
            {
                DialogResult dr = MessageBox.Show("Do you have second Warehouse ?", " ",
                 MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        textBox3.Text = (2*(4200000 - (price * ((double)capacity / num)))).ToString("F2");
                        textBox2.Text = (2 * (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (2 * (capacity / num)).ToString();
                        break;
                    case DialogResult.No:
                        textBox3.Text = (4200000 - (price * ((double)capacity / num))).ToString("F2");
                        textBox1.Text = (capacity / num).ToString();
                        textBox2.Text = (price * ((double)capacity / num)).ToString("F2");
                        break;
                }
            }
        }
    }
}