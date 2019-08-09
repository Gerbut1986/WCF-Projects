namespace App_Client
{
    using System;
    using System.Windows.Forms;
    using App_Client.ServiceReference1;

    public partial class MainForm : Form
    {
        Service1Client serviceClient = new Service1Client();
        Employers em = null;
        public MainForm()
        {
            InitializeComponent();
            findID.Visible = false;
            label8.Visible = false;
            listBox1.Visible = false;
            findedBtn.Visible = false;
            Size = new System.Drawing.Size(264, 297);
            labelReturn.Visible = false;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            em = new Employers();
            if (fioTXT.Text == "" && addrTXT.Text == "" && phoneTXT.Text == "" && emailTXT.Text == "" && birthTXT.Text == "" && salaryTXT.Text == "")
                MessageBox.Show("All Fields is Empty!\n\tTry fill them", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (fioTXT.Text == "" || addrTXT.Text == "" || phoneTXT.Text == "" || emailTXT.Text == "" || birthTXT.Text == "" || salaryTXT.Text == "")
                MessageBox.Show("Some fild isEmpty\n\tTry fill them", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                try
                {
                    em.FIO = fioTXT.Text;
                    em.Address = addrTXT.Text;
                    em.Phone = int.Parse(phoneTXT.Text);
                    em.Email = emailTXT.Text;
                    em.Datebirthday = birthTXT.Text;
                    em.Salary = salaryTXT.Text;
                    serviceClient.InsertEmployer(em);
                    serviceClient.Close();
                    MessageBox.Show("Added!", "Congratulate!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    fioTXT.Text = null;
                    addrTXT.Text = null;
                    phoneTXT.Text = null;
                    emailTXT.Text = null;
                    birthTXT.Text = null;
                    salaryTXT.Text = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Message Exeption is: {ex.Message}", "Exeption!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void showAllEntities_Click(object sender, EventArgs e)
        {
            ShowAll all = new ShowAll();
            all.ShowDialog();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(280, 225);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            addBtn.Visible = false;
            fioTXT.Visible = false;
            addrTXT.Visible = false;
            emailTXT.Visible = false;
            salaryTXT.Visible = false;
            phoneTXT.Visible = false;
            birthTXT.Visible = false;
            listBox1.Visible = false;
            findBtn.Visible = false;
            findID.Visible = true;
            label8.Visible = true;
            findedBtn.Visible = false;
        }

        private void findedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.AddRange(serviceClient.FindEmployerById(int.Parse(findID.Text)));
                //listBox1.Items.Add(serviceClient.Find(int.Parse(findID.Text)));
                listBox1.Items.Add("-------------------------------------------------------");
                listBox1.Visible = true;
                Size = new System.Drawing.Size(280, 452);
                findID.Text = "";
            }
            catch(Exception ex) { MessageBox.Show($"Message Exeption is:\n{ex.Message}", "Exeption!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void findID_TextChanged(object sender, EventArgs e)
        {
            labelReturn.Visible = true;
            findedBtn.Visible = true;
        }

        private void labelReturn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            addBtn.Visible = true;
            fioTXT.Visible = true;
            addrTXT.Visible = true;
            emailTXT.Visible = true;
            salaryTXT.Visible = true;
            phoneTXT.Visible = true;
            birthTXT.Visible = true;
            listBox1.Visible = true;
            findBtn.Visible = true;
            findID.Visible = false;
            label8.Visible = false;
            findedBtn.Visible = true;
            findID.Visible = false;
            label8.Visible = false;
            listBox1.Visible = false;
            findedBtn.Visible = false;
            Size = new System.Drawing.Size(280, 338);
            labelReturn.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
