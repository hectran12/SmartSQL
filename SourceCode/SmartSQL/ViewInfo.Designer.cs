namespace SmartSQL
{
    partial class ViewInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txb_name = new TextBox();
            txb_version = new TextBox();
            label3 = new Label();
            txb_shared_name = new TextBox();
            label4 = new Label();
            txb_owner = new TextBox();
            lbl_owner = new Label();
            txb_auto_create = new TextBox();
            label6 = new Label();
            txb_state = new TextBox();
            label5 = new Label();
            txb_last_start_time = new TextBox();
            label7 = new Label();
            txb_instance_pipe_name = new TextBox();
            label8 = new Label();
            btn_clone_instance = new Button();
            button2 = new Button();
            btn_close_tab = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "Infomation:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(24, 68);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(274, 23);
            txb_name.TabIndex = 2;
            // 
            // txb_version
            // 
            txb_version.Location = new Point(24, 113);
            txb_version.Name = "txb_version";
            txb_version.Size = new Size(274, 23);
            txb_version.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 96);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Version";
            // 
            // txb_shared_name
            // 
            txb_shared_name.Location = new Point(24, 160);
            txb_shared_name.Name = "txb_shared_name";
            txb_shared_name.Size = new Size(274, 23);
            txb_shared_name.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 142);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 5;
            label4.Text = "Shared name:";
            // 
            // txb_owner
            // 
            txb_owner.Location = new Point(24, 208);
            txb_owner.Name = "txb_owner";
            txb_owner.Size = new Size(274, 23);
            txb_owner.TabIndex = 8;
            // 
            // lbl_owner
            // 
            lbl_owner.AutoSize = true;
            lbl_owner.Location = new Point(21, 191);
            lbl_owner.Name = "lbl_owner";
            lbl_owner.Size = new Size(42, 15);
            lbl_owner.TabIndex = 7;
            lbl_owner.Text = "Owner";
            // 
            // txb_auto_create
            // 
            txb_auto_create.Location = new Point(24, 257);
            txb_auto_create.Name = "txb_auto_create";
            txb_auto_create.Size = new Size(274, 23);
            txb_auto_create.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 239);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 9;
            label6.Text = "Auto-create";
            // 
            // txb_state
            // 
            txb_state.Location = new Point(24, 313);
            txb_state.Name = "txb_state";
            txb_state.Size = new Size(274, 23);
            txb_state.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 295);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 11;
            label5.Text = "State";
            // 
            // txb_last_start_time
            // 
            txb_last_start_time.Location = new Point(24, 357);
            txb_last_start_time.Name = "txb_last_start_time";
            txb_last_start_time.Size = new Size(274, 23);
            txb_last_start_time.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 339);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 13;
            label7.Text = "Last start time:";
            // 
            // txb_instance_pipe_name
            // 
            txb_instance_pipe_name.Location = new Point(24, 410);
            txb_instance_pipe_name.Name = "txb_instance_pipe_name";
            txb_instance_pipe_name.Size = new Size(274, 23);
            txb_instance_pipe_name.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 392);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 15;
            label8.Text = "Instance pipe name:";
            // 
            // btn_clone_instance
            // 
            btn_clone_instance.Location = new Point(319, 67);
            btn_clone_instance.Name = "btn_clone_instance";
            btn_clone_instance.Size = new Size(125, 23);
            btn_clone_instance.TabIndex = 17;
            btn_clone_instance.Text = "Clone instance";
            btn_clone_instance.UseVisualStyleBackColor = true;
            btn_clone_instance.Click += btn_clone_instance_click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 111);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 18;
            button2.Text = "Delete instance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_delete_instance_click;
            // 
            // btn_close_tab
            // 
            btn_close_tab.Location = new Point(165, 445);
            btn_close_tab.Name = "btn_close_tab";
            btn_close_tab.Size = new Size(158, 23);
            btn_close_tab.TabIndex = 19;
            btn_close_tab.Text = "Close tab";
            btn_close_tab.UseVisualStyleBackColor = true;
            btn_close_tab.Click += btn_close_tab_click;
            // 
            // ViewInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 480);
            Controls.Add(btn_close_tab);
            Controls.Add(button2);
            Controls.Add(btn_clone_instance);
            Controls.Add(txb_instance_pipe_name);
            Controls.Add(label8);
            Controls.Add(txb_last_start_time);
            Controls.Add(label7);
            Controls.Add(txb_state);
            Controls.Add(label5);
            Controls.Add(txb_auto_create);
            Controls.Add(label6);
            Controls.Add(txb_owner);
            Controls.Add(lbl_owner);
            Controls.Add(txb_shared_name);
            Controls.Add(label4);
            Controls.Add(txb_version);
            Controls.Add(label3);
            Controls.Add(txb_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewInfo";
            Text = "View info instance";
            Load += ViewInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_name;
        private TextBox txb_version;
        private Label label3;
        private TextBox txb_shared_name;
        private Label label4;
        private TextBox txb_owner;
        private Label lbl_owner;
        private TextBox txb_auto_create;
        private Label label6;
        private TextBox txb_state;
        private Label label5;
        private TextBox txb_last_start_time;
        private Label label7;
        private TextBox txb_instance_pipe_name;
        private Label label8;
        private Button btn_clone_instance;
        private Button button2;
        private Button btn_close_tab;
    }
}