namespace Travel_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string haradan = comboBox1.Text;
            string haraya = comboBox2.Text;
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox2.Text;
            string yer = textBox1.Text;
            string adsoyad = textBox3.Text;
            string seriya = maskedTextBox4.Text;
            string telefon = maskedTextBox3.Text;
            string email = textBox2.Text;

            string melumat = $"Marşrut: {haradan} - {haraya} | Tarix: {tarix} | Saat: {saat} | Yer: {yer} | " +
                     $"Ad Soyad: {adsoyad} | Ş/V: {seriya} | Telefon: {telefon} | Email: {email}";

            listBox1.Items.Add(melumat);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
             {
               if (listBox1.SelectedIndex != -1)
                 {
                   listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                 }
               else
                 {
                   MessageBox.Show("Zəhmət olmasa siyahıdan silmək istədiyiniz məlumatı seçin.");
                 }
             }
    }
    
}
