namespace App_Client
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using App_Client.ServiceReference1;
    public partial class ShowAll : Form
    {
        Service1Client client = new Service1Client();
        public ShowAll()
        {
            InitializeComponent();
            try
            {
                ShowData();
            }
            catch (Exception ex) { MessageBox.Show($"Message Exeption is:\n{ex.Message}", "Exeption!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void ShowData()
        {
            DataSet ds = new DataSet();
            ds = client.ShowAllEntities();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
