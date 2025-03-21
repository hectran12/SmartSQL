using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSQL
{
    public partial class ViewInfo : Form
    {
        static instance instanceInfo = new instance();
        static sqllocaldb SQLCLI = new sqllocaldb();
        private Form1 mainForm;
        static utils uti = new utils();
        public ViewInfo(instance insInfo, Form1 mainF)
        {
            instanceInfo = insInfo;
            mainForm = mainF;
            InitializeComponent();
        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {
            txb_name.Text = instanceInfo.nameInstance;
            txb_owner.Text = instanceInfo.Owner;
            txb_instance_pipe_name.Text = instanceInfo.instancePipeName;
            txb_state.Text = instanceInfo.state;
            txb_shared_name.Text = instanceInfo.sharedName;
            txb_version.Text = instanceInfo.version;
            if (instanceInfo.autoCreated)
            {
                txb_auto_create.Text = "Auto";
            }
            else
            {
                txb_auto_create.Text = "No";
            }
            txb_last_start_time.Text = instanceInfo.lastStartTime.ToString();

        }

        private void btn_close_tab_click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void btn_delete_instance_click(object sender, EventArgs e)
        {

            instanceInfo = SQLCLI.getInstanceInfo(instanceInfo.nameInstance);



            if (instanceInfo.state == "Running")
            {
                DialogResult askSureDelete = MessageBox.Show("Are you sure about that? (because instance running)", "Ask", MessageBoxButtons.YesNo);
                if (askSureDelete == DialogResult.No)
                {
                    MessageBox.Show("Cancel delete success");
                    return;
                }
            }

            if (SQLCLI.stopInstance((string)instanceInfo.nameInstance) == false)
            {
                MessageBox.Show("Instance stopped error, cannot delete!");
                return;
            }

            if (SQLCLI.deleteInstance((string)instanceInfo.nameInstance))
            {
                MessageBox.Show("Delete instance success");
                mainForm.loadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Delete instance failed");
            }
        }

        private void btn_clone_instance_click(object sender, EventArgs e)
        {
            string newName = instanceInfo.nameInstance + "_copy_" + uti.RandomString(5);

            // check duplicate instance
            instance newInfo = SQLCLI.getInstanceInfo(newName);
            if (newInfo.nameInstance != "ERR_TO_FETCH_INFO")
            {
                btn_clone_instance_click(sender, e); // call back (de quy bili)
            }

            // create new instance 
            if (SQLCLI.createNewInstance(newName) == false)
            {
                MessageBox.Show("Err when clone instance (step: create new instance)");
                return;
            }





        }
    }
}
