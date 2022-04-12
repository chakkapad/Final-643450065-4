namespace Final_643450065_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadProductFormfile(string filelocation)
        {
            string[] lines = System.IO.File.ReadAllLines(filelocation);
            if(lines.Length > 0)
            {
                string oneline = lines[0];
                string[] head = oneline.Split(',');

                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                Name.HeaderText = head[0];
                DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                Price.HeaderText = head[1];
                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.HeaderText = head[2];
                DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();
                Amount.HeaderText = "Amount";
                dataGridView1.Columns.Add(Name);
                dataGridView1.Columns.Add(Price);
                dataGridView1.Columns.Add(Select);
                dataGridView1.Columns.Add(Amount);

                for (int a = 1; a < lines.Length; a++)
                {
                    string[] data = lines[a].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2]);   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalSum = 0;
            for(int a = 0; a < dataGridView1.Rows.Count; a++)
            {

                bool checkedCell = Convert.ToBoolean(dataGridView1.Rows[a].Cells[2].Value);
                if (checkedCell== true)
                {
                    DataGridViewRow row = dataGridView1.Rows[a];
                    double totals = Convert.ToDouble(row.Cells[1].Value);
                    double amount = Convert.ToDouble(row.Cells[3].Value);
                    totals *= amount;
                    totalSum += totals;
                    textBox1.Text = totalSum.ToString();
                    
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(textBox2.Text);
            double total = Convert.ToDouble(textBox1.Text);
            double change = money - total;
            if(change > 0)
            {
                label1.Text = "เรียบร้อย";
                label2.Text = "เงินทอน = " + change.ToString();
            }
            else
            {
                label1.Text = "ไม่สำเร็จ";
                label2.Text = "ยังเหลืองตัง = " + change.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            loadProductFormfile(file);

        }
    }
}