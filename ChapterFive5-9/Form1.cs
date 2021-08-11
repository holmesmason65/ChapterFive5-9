
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ChapterFive5_9
{
    public partial class frmPublishers : Form
    {
        SqlConnection booksConnection;
        SqlCommand publisherCommand;
        SqlDataAdapter publisherAdapter;
        DataTable publisherTable;
        CurrencyManager publisherManager;

        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            try
            {
                hlpPublishers.HelpNamespace = Application.StartupPath + "\\Publishers.chm"; 
                string path = Path.GetFullPath("SQLBooksDB.mdf");

                booksConnection = new SqlConnection($@"Data Source=.\SQLEXPRESS; AttachDbFilename={path};
                                                    Integrated Security=True; Connect Timeout=30; User Instance=True");
                booksConnection.Open();

                // establish command object 
                publisherCommand = new SqlCommand("SELECT * FROM Publishers ORDER BY Name", booksConnection);

                // establish data adpater 
                publisherAdapter = new SqlDataAdapter();
                publisherAdapter.SelectCommand = publisherCommand;
                publisherTable = new DataTable();
                publisherAdapter.Fill(publisherTable);

                // bind controls to data table 
                txtPubID.DataBindings.Add("Text", publisherTable, "PubID");
                txtPubName.DataBindings.Add("Text", publisherTable, "Name");
                txtCompanyName.DataBindings.Add("Text", publisherTable, "Company_Name");
                txtPubCity.DataBindings.Add("Text", publisherTable, "City");
                txtPubAddress.DataBindings.Add("Text", publisherTable, "Address");
                txtPubState.DataBindings.Add("Text", publisherTable, "State");
                txtPubTelephone.DataBindings.Add("Text", publisherTable, "Telephone");
                txtPubFax.DataBindings.Add("Text", publisherTable, "FAX");
                txtPubComments.DataBindings.Add("Text", publisherTable, "Comments");

                // establish currency manager
                publisherManager = (CurrencyManager)this.BindingContext[publisherTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Publisher Table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show(); 
            // SetState("View") 
        }

        private void frmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close the connection 
            booksConnection.Close();
            // dispose of the objects 
            booksConnection.Dispose();
            publisherCommand.Dispose();
            publisherAdapter.Dispose();
            publisherTable.Dispose();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (publisherManager.Position == 0)
            {
                Console.Beep();
            }
            publisherManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (publisherManager.Position == publisherManager.Count - 1)
            {
                Console.Beep();
            }
            publisherManager.Position++;
        }

        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtPubID.BackColor = Color.White;
                    txtPubID.ForeColor = Color.Black;
                    txtPubName.ReadOnly = true;
                    txtCompanyName.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnExit.Enabled = true; // supposed to be exit
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    txtPubName.Focus();
                    break;
                default: // Add or Edit if not in view 
                    txtPubID.BackColor = Color.Red;
                    txtPubID.ForeColor = Color.White;
                    txtPubName.ReadOnly = false;
                    txtCompanyName.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnExit.Enabled = false; // should be edit 
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    txtPubName.Focus();
                    break;
            }
        }

        private void txtPubName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private bool ValidateDate() 
        {
            string message = "";
            bool allOK = true;
            // check for name
            if (txtPubName.Text.Trim().Equals("")) 
            {
                message = "You must enter a Publisher Name" + "\r\n";
                txtPubName.Focus();
                allOK = false; 
            }
            if (!allOK) 
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return allOK; 
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPublishers.HelpNamespace); 
        }
    }
}
