namespace Studenți
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Student[] v = new Student[30];
        public int n = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            n++;
            v[n] = new Student();
            v[n].nume = textBox1.Text;
            v[n].an = Convert.ToInt32(comboBox1.SelectedItem);
            v[n].varsta = Convert.ToInt32(numericUpDown1.Value);
            v[n].nota1 = Convert.ToInt32(comboBox2.SelectedItem);
            v[n].nota2 = Convert.ToInt32(comboBox3.SelectedItem);
            v[n].nota3 = Convert.ToInt32(comboBox4.SelectedItem);
            v[n].nota4 = Convert.ToInt32(comboBox5.SelectedItem);
            v[n].nota5 = Convert.ToInt32(comboBox6.SelectedItem);
            v[n].medie = (v[n].nota1 + v[n].nota2 + v[n].nota3 + v[n].nota4 + v[n].nota5) / 5.0;
            string s = v[n].Afisare();
            listBox1.Items.Add(s);
            textBox1.Clear();
            numericUpDown1.Value = 0;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
            comboBox6.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (v[i].nume.CompareTo(v[j].nume) > 0)
                    {
                        Student aux = new Student();
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            for (int i = 1; i <= n; i++)
            {
                string s = v[i].Afisare();
                listBox1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (v[i].medie < v[j].medie)
                    {
                        Student aux = new Student();
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            for (int i = 1; i <= n; i++)
            {
                string s = v[i].Afisare();
                listBox1.Items.Add(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= n; i++)
                if (v[i].an == Convert.ToInt32(comboBox7.SelectedItem))
                {
                    string s = v[i].Afisare();
                    listBox1.Items.Add(s);
                }
            comboBox7.SelectedItem = null;
        }
    }
}
