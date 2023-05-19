using Restoran;

namespace RestoranDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.PersonelEntryControl(txtSifre.Text, cGenel._PersonelId);

            if (result)
            {

                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId=cGenel._PersonelId;
                ch.Islem = "Giri� Yap�ld�";
                ch.Tarih=DateTime.Now;
                ch.PersonelActionSave(ch);
                
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Hatal� �ifre!", "Uyar� !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)comboBox1.SelectedItem;
            cGenel._PersonelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��k��� Onayl�yor Musunuz?","Uyar� !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}