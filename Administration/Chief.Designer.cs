namespace Administration
{
    partial class Chief
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.company_and_detsad = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.people_and_lgot = new System.Windows.Forms.TabPage();
            this.DelEmp = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bttn_add = new System.Windows.Forms.Button();
            this.bttn_delite = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.company_and_detsad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.people_and_lgot.SuspendLayout();
            this.DelEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.company_and_detsad);
            this.tabControl1.Controls.Add(this.people_and_lgot);
            this.tabControl1.Controls.Add(this.DelEmp);
            this.tabControl1.Location = new System.Drawing.Point(13, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // company_and_detsad
            // 
            this.company_and_detsad.Controls.Add(this.button1);
            this.company_and_detsad.Controls.Add(this.dataGridView1);
            this.company_and_detsad.Controls.Add(this.dataGridView5);
            this.company_and_detsad.Location = new System.Drawing.Point(4, 37);
            this.company_and_detsad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.company_and_detsad.Name = "company_and_detsad";
            this.company_and_detsad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.company_and_detsad.Size = new System.Drawing.Size(1220, 559);
            this.company_and_detsad.TabIndex = 0;
            this.company_and_detsad.Text = "Списки компаний и детских садов";
            this.company_and_detsad.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(603, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 502);
            this.dataGridView1.TabIndex = 7;
            // 
            // people_and_lgot
            // 
            this.people_and_lgot.Controls.Add(this.button4);
            this.people_and_lgot.Controls.Add(this.dataGridView2);
            this.people_and_lgot.Location = new System.Drawing.Point(4, 37);
            this.people_and_lgot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.people_and_lgot.Name = "people_and_lgot";
            this.people_and_lgot.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.people_and_lgot.Size = new System.Drawing.Size(1220, 559);
            this.people_and_lgot.TabIndex = 1;
            this.people_and_lgot.Text = "Списки населения и льгот";
            this.people_and_lgot.UseVisualStyleBackColor = true;
            // 
            // DelEmp
            // 
            this.DelEmp.Controls.Add(this.dataGridView3);
            this.DelEmp.Controls.Add(this.bttn_add);
            this.DelEmp.Controls.Add(this.bttn_delite);
            this.DelEmp.Location = new System.Drawing.Point(4, 37);
            this.DelEmp.Name = "DelEmp";
            this.DelEmp.Size = new System.Drawing.Size(1220, 559);
            this.DelEmp.TabIndex = 2;
            this.DelEmp.Text = "Список сотрудников";
            this.DelEmp.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 8);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1023, 551);
            this.dataGridView3.TabIndex = 6;
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(1034, 52);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(183, 41);
            this.bttn_add.TabIndex = 4;
            this.bttn_add.Text = "Добавить";
            this.bttn_add.UseVisualStyleBackColor = true;
            // 
            // bttn_delite
            // 
            this.bttn_delite.Location = new System.Drawing.Point(1032, 5);
            this.bttn_delite.Name = "bttn_delite";
            this.bttn_delite.Size = new System.Drawing.Size(183, 41);
            this.bttn_delite.TabIndex = 3;
            this.bttn_delite.Text = "Удалить";
            this.bttn_delite.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.bttn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 64);
            this.panel1.TabIndex = 1;
            // 
            // bttn_exit
            // 
            this.bttn_exit.Location = new System.Drawing.Point(1036, 14);
            this.bttn_exit.Name = "bttn_exit";
            this.bttn_exit.Size = new System.Drawing.Size(183, 41);
            this.bttn_exit.TabIndex = 5;
            this.bttn_exit.Text = "Выйти";
            this.bttn_exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(494, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Глава Управы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1098, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 548);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(7, 54);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(590, 502);
            this.dataGridView5.TabIndex = 6;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1096, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Chief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Chief";
            this.Text = "Chief";
            this.tabControl1.ResumeLayout(false);
            this.company_and_detsad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.people_and_lgot.ResumeLayout(false);
            this.DelEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage company_and_detsad;
        private System.Windows.Forms.TabPage people_and_lgot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DelEmp;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Button bttn_delite;
        private System.Windows.Forms.Button bttn_exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
    }
}