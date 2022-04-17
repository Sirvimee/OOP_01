namespace Sirvi_Meeli_Kodutöö_nr_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tervitus lause=new tervitus();

        private void Form1_Load(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            label2.Text = lause.tere();
            txtNimi.Focus();
        }

        private void btnTere_Click(object sender, EventArgs e)
        {
            lause.nimi = txtNimi.Text;
            label2.Text = lause.tere();
            txtNimi.Text = "";
            txtNimi.Focus();
        }

        private void btnV2lja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas soovite väljuda?", "Lõpp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnArv_Click(object sender, EventArgs e)
        {
            summa arv = new summa();
            //õige
            try
            {
                arv.number1 = Convert.ToSingle(number1.Text);
                arv.number2 = Convert.ToSingle(number2.Text);
                if (chkTehing.Checked)
                {
                    arv.tehing = "+";
                    chkTehing.Text = "Liida";
                }
                else
                {
                    arv.tehing = "-";
                    chkTehing.Text = "Lahuta";
                }
                //tulemus
                Single tulemused = arv.arvutus();
                lblSumma.Text = Convert.ToString(arv.number1) + arv.tehing 
                    + Convert.ToString(arv.number2) + " = " + Convert.ToString(tulemused);
            }
            //vale
            catch
            {
                lblSumma.Text = "";
                MessageBox.Show("Sisesta arv", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnV2rv_Click(object sender, EventArgs e)
        {
            if (btnRed.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (btnBlue.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                MessageBox.Show("Vali värv!", "Vormi värvimine", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnTyhi_Click(object sender, EventArgs e)
        {
            btnBlue.Checked = false;
            btnRed.Checked = false;
            this.BackColor = SystemColors.Control;
        }
    }
}