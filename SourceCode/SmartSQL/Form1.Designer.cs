namespace SmartSQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn_reload_instance = new Button();
            lbl_sqllocaldb_control = new Label();
            dataGridView_ListInstance = new DataGridView();
            label1 = new Label();
            btn_DeleteInstance = new Button();
            label2 = new Label();
            btn_fastcreated_instance = new Button();
            btnViewInfoInstance = new Button();
            btn_start_instance = new Button();
            btn_stop_instance = new Button();
            btn_setting = new Button();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListInstance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_reload_instance);
            panel1.Controls.Add(lbl_sqllocaldb_control);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 133);
            panel1.TabIndex = 0;
            // 
            // btn_reload_instance
            // 
            btn_reload_instance.Location = new Point(13, 28);
            btn_reload_instance.Name = "btn_reload_instance";
            btn_reload_instance.Size = new Size(153, 29);
            btn_reload_instance.TabIndex = 1;
            btn_reload_instance.Text = "Reloaded List Instance";
            btn_reload_instance.UseVisualStyleBackColor = true;
            btn_reload_instance.Click += btn_reloaded_instance;
            // 
            // lbl_sqllocaldb_control
            // 
            lbl_sqllocaldb_control.AutoSize = true;
            lbl_sqllocaldb_control.Location = new Point(13, 10);
            lbl_sqllocaldb_control.Name = "lbl_sqllocaldb_control";
            lbl_sqllocaldb_control.Size = new Size(114, 15);
            lbl_sqllocaldb_control.TabIndex = 0;
            lbl_sqllocaldb_control.Text = "SQLLocalDB Control";
            // 
            // dataGridView_ListInstance
            // 
            dataGridView_ListInstance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ListInstance.Location = new Point(21, 180);
            dataGridView_ListInstance.Name = "dataGridView_ListInstance";
            dataGridView_ListInstance.Size = new Size(767, 150);
            dataGridView_ListInstance.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 162);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "All instance here:";
            // 
            // btn_DeleteInstance
            // 
            btn_DeleteInstance.Location = new Point(21, 336);
            btn_DeleteInstance.Name = "btn_DeleteInstance";
            btn_DeleteInstance.Size = new Size(127, 23);
            btn_DeleteInstance.TabIndex = 3;
            btn_DeleteInstance.Text = "Delete instance";
            btn_DeleteInstance.UseVisualStyleBackColor = true;
            btn_DeleteInstance.Click += btn_DeleteInstance_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 426);
            label2.Name = "label2";
            label2.Size = new Size(263, 15);
            label2.TabIndex = 4;
            label2.Text = "Software created by NGUYEN PHUC NHAN HOA";
            // 
            // btn_fastcreated_instance
            // 
            btn_fastcreated_instance.Location = new Point(154, 336);
            btn_fastcreated_instance.Name = "btn_fastcreated_instance";
            btn_fastcreated_instance.Size = new Size(130, 23);
            btn_fastcreated_instance.TabIndex = 5;
            btn_fastcreated_instance.Text = "Fast create instance";
            btn_fastcreated_instance.UseVisualStyleBackColor = true;
            btn_fastcreated_instance.Click += btn_fastcreated_instance_Click;
            // 
            // btnViewInfoInstance
            // 
            btnViewInfoInstance.Location = new Point(290, 336);
            btnViewInfoInstance.Name = "btnViewInfoInstance";
            btnViewInfoInstance.Size = new Size(147, 23);
            btnViewInfoInstance.TabIndex = 6;
            btnViewInfoInstance.Text = "View info instance";
            btnViewInfoInstance.UseVisualStyleBackColor = true;
            btnViewInfoInstance.Click += btnViewInfoInstance_Click;
            // 
            // btn_start_instance
            // 
            btn_start_instance.Location = new Point(443, 336);
            btn_start_instance.Name = "btn_start_instance";
            btn_start_instance.Size = new Size(147, 23);
            btn_start_instance.TabIndex = 7;
            btn_start_instance.Text = "Start instance";
            btn_start_instance.UseVisualStyleBackColor = true;
            btn_start_instance.Click += btn_start_instance_Click;
            // 
            // btn_stop_instance
            // 
            btn_stop_instance.Location = new Point(596, 336);
            btn_stop_instance.Name = "btn_stop_instance";
            btn_stop_instance.Size = new Size(137, 23);
            btn_stop_instance.TabIndex = 8;
            btn_stop_instance.Text = "Stop instance";
            btn_stop_instance.UseVisualStyleBackColor = true;
            btn_stop_instance.Click += btn_stop_instance_Click;
            // 
            // btn_setting
            // 
            btn_setting.BackColor = SystemColors.ButtonFace;
            btn_setting.Image = (Image)resources.GetObject("btn_setting.Image");
            btn_setting.Location = new Point(21, 392);
            btn_setting.Name = "btn_setting";
            btn_setting.Size = new Size(55, 46);
            btn_setting.TabIndex = 9;
            btn_setting.UseVisualStyleBackColor = false;
            btn_setting.Click += btn_setting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_setting);
            Controls.Add(btn_stop_instance);
            Controls.Add(btn_start_instance);
            Controls.Add(btnViewInfoInstance);
            Controls.Add(btn_fastcreated_instance);
            Controls.Add(label2);
            Controls.Add(btn_DeleteInstance);
            Controls.Add(label1);
            Controls.Add(dataGridView_ListInstance);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Smart SQL";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ListInstance).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_sqllocaldb_control;
        private Button btn_reload_instance;
        private DataGridView dataGridView_ListInstance;
        private Label label1;
        private Button btn_DeleteInstance;
        private Label label2;
        private Button btn_fastcreated_instance;
        private Button btnViewInfoInstance;
        private Button btn_start_instance;
        private Button btn_stop_instance;
        private Button btn_setting;
        private BindingSource bindingSource1;
    }
}
