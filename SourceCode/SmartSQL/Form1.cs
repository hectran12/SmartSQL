
using System.Windows.Forms;

namespace SmartSQL
{
    public partial class Form1 : Form
    {
        static sqllocaldb SQLCLI = new sqllocaldb();
        static utils uti = new utils();
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            dataGridView_ListInstance.DataSource = null; // clear data source
            dataGridView_ListInstance.DataSource = SQLCLI.getAllInstances(); // get all instance
            dataGridView_ListInstance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // resize grid view
            dataGridView_ListInstance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_reloaded_instance(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_DeleteInstance_Click(object sender, EventArgs e)
        {

            int successDeleted = 0, errorDeleted = 0;
            foreach (DataGridViewRow row in dataGridView_ListInstance.SelectedRows)
            {
                instance obj = (instance)row.DataBoundItem;
                if (SQLCLI.deleteInstance(obj.nameInstance))
                {
                    successDeleted++;
                    continue;
                }
                errorDeleted++;

            }
            // refersh data in grid view
            loadData();
            // show Message
            MessageBox.Show("Success deleted: " + successDeleted + " - - - Error deleted: " + errorDeleted);

        }

        private void btn_fastcreated_instance_Click(object sender, EventArgs e)
        {
            string randNameDB = uti.RandomString(15);
            bool statusCreated = SQLCLI.createNewInstance(randNameDB);
            if (statusCreated)
            {
                MessageBox.Show("Created database success with name: " + randNameDB);

            }
            else
            {
                MessageBox.Show("Created database success with name: " + randNameDB);
            }
            loadData();
        }

        private void btnViewInfoInstance_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_ListInstance.SelectedRows)
            {
                instance obj = (instance)row.DataBoundItem;
                ViewInfo view = new ViewInfo(obj, this);
                view.Show();
            }
        }

        private void btn_start_instance_Click(object sender, EventArgs e)
        {
            int successStarted = 0, failStarted = 0;
            foreach (DataGridViewRow row in dataGridView_ListInstance.SelectedRows)
            {
                instance obj = (instance)row.DataBoundItem;
                if (SQLCLI.startInstance(obj.nameInstance))
                {
                    successStarted++;
                    continue;
                }
                failStarted++;

            }

            loadData();

            MessageBox.Show("Success started: " + successStarted + " || Fail started: " + failStarted);
        }

        private void btn_stop_instance_Click(object sender, EventArgs e)
        {
            int successStop = 0, failStop = 0;
            foreach (DataGridViewRow row in dataGridView_ListInstance.SelectedRows)
            {
                instance obj = (instance)row.DataBoundItem;
                if (SQLCLI.stopInstance(obj.nameInstance))
                {
                    successStop++;
                    continue;
                }
                failStop++;
            }
            loadData();

            MessageBox.Show("Success stop: " + successStop + " || Fail stop: " + failStop);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            setting sett = new setting();
            sett.Show();
        }
    }
}
