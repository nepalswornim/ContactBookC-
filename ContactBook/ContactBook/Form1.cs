using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace ContactBook
{
    public partial class Form1 : Form
    {
        BLLContact blc = new BLLContact();
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (emptyfields() == true)
            {
                MessageBox.Show("Must Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataTable dt = blc.GetAllUser();
                i = dt.Rows.Count;
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells["colName"].Value = txtName.Text;
                dataGridView1.Rows[i].Cells["colEmail"].Value = txtEmail.Text;
                dataGridView1.Rows[i].Cells["colAddress"].Value = txtAddress.Text;
                dataGridView1.Rows[i].Cells["colPhone"].Value = txtPhone.Text;
                dataGridView1.Rows[i].Cells["colCountry"].Value = cboCountry.Text;
                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;

                i++;


                Clear();


            }
        }

        private void Clear()
        {
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtName.Clear();
            cboCountry.Text = "Choose Country";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DefaultCellStyle.ForeColor == Color.Blue)
            {
            }
            MessageBox.Show("Nothing to remove");
        }
        private bool emptyfields()
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || cboCountry.Text == "")
            {
                errorProvider1.SetError(txtName, "Must Enter Name");
                errorProvider1.SetError(txtEmail, "Must Enter Email");
                errorProvider1.SetError(txtAddress, "Must Enter Address");
                errorProvider1.SetError(txtPhone, "Must Enter Phone");
                errorProvider1.SetError(cboCountry, "Choose Country");
                return true;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
                errorProvider1.SetError(txtEmail, "");
                errorProvider1.SetError(txtAddress, "");
                errorProvider1.SetError(txtPhone, "");
                errorProvider1.SetError(cboCountry, "Choose Country");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.ButtonText != "Update")
            {

                if (emptyfields() == true)
                {
                    MessageBox.Show("Must Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int i = blc.AddContact(txtName.Text, txtEmail.Text, txtAddress.Text, Convert.ToInt64(txtPhone.Text), cboCountry.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("Inserted Successfully");
                        Clear();
                        txtName.Focus();
                        LoadGrid();

                    }

                }
            }

            else
            {
                int i = blc.UpdateContact(txtName.Text, txtEmail.Text, txtAddress.Text, Convert.ToInt32(txtPhone.Text), cboCountry.Text, k);
                if (i > 0)
                {
                    MessageBox.Show("Updated Successfully, Updates will be shown prior to restart.");
                    dataGridView1.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Yellow;
                    Clear();
                    LoadGrid();

                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;


            LoadGrid();


        }


        private void LoadGrid()
        {
            int k = 0;


            DataTable dt = blc.GetAllUser();

            if (dt.Rows.Count > 0)
            {

                for (int j = 0; j < dt.Rows.Count; j++)
                {

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[k].Cells["colName"].Value = dt.Rows[j]["Name"].ToString();
                    dataGridView1.Rows[k].Cells["colEmail"].Value = dt.Rows[j]["Email"].ToString();
                    dataGridView1.Rows[k].Cells["colAddress"].Value = dt.Rows[j]["Address"].ToString();
                    dataGridView1.Rows[k].Cells["colPhone"].Value = dt.Rows[j]["Phone"].ToString();
                    dataGridView1.Rows[k].Cells["colCountry"].Value = dt.Rows[j]["Country"].ToString();
                    dataGridView1.Rows[k].Cells["colContactId"].Value = dt.Rows[j]["ContactId"].ToString();

                    k++;


                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int k = 0;
        public void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



            txtName.Text = dataGridView1.CurrentRow.Cells["colName"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["colEmail"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["colAddress"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["colPhone"].Value.ToString();
            cboCountry.Text = dataGridView1.CurrentRow.Cells["colCountry"].Value.ToString();
            k = Convert.ToInt32(dataGridView1.CurrentRow.Cells["colContactId"].Value.ToString());
            btnDelete.Enabled = true;
            btnSave.ButtonText = "Update";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = blc.GetContactbyName(txtSearch.Text);

            lvSearch.Items.Add(dt.Rows[0]["Name"].ToString());


            lvSearch.Items.Add(dt.Rows[0]["Email"].ToString());


            lvSearch.Items.Add(dt.Rows[0]["Address"].ToString());
            lvSearch.Items.Add(dt.Rows[0]["Phone"].ToString());
            lvSearch.Items.Add(dt.Rows[0]["Country"].ToString());


        }

        private void cloudTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = blc.DeleteContact(k);
            if (i > 0)
            {
                MessageBox.Show("Contact Deleted");
                dataGridView1.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
                Clear();
                LoadGrid();
                btnDelete.Enabled = false;

            }

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
           



        }

        private void txtPhone_TabIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(txtPhone.Text, out i))
            {
                MessageBox.Show("Enter a valid number");
                return;

                
            }
        }
    }
}
