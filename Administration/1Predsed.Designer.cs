namespace Administration
{
    partial class _1Predsed
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.people = new System.Windows.Forms.TabPage();
            this.lgoti = new System.Windows.Forms.TabPage();
            this.Eddlgot = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.people.SuspendLayout();
            this.lgoti.SuspendLayout();
            this.Eddlgot.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.bttn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 64);
            this.panel1.TabIndex = 3;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(457, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первый председатель";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.people);
            this.tabControl1.Controls.Add(this.lgoti);
            this.tabControl1.Controls.Add(this.Eddlgot);
            this.tabControl1.Location = new System.Drawing.Point(8, 86);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 600);
            this.tabControl1.TabIndex = 2;
            // 
            // people
            // 
            this.people.Controls.Add(this.button4);
            this.people.Controls.Add(this.dataGridView1);
            this.people.Location = new System.Drawing.Point(4, 34);
            this.people.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.people.Name = "people";
            this.people.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.people.Size = new System.Drawing.Size(1220, 562);
            this.people.TabIndex = 0;
            this.people.Text = "Список населения";
            this.people.UseVisualStyleBackColor = true;
            // 
            // lgoti
            // 
            this.lgoti.Controls.Add(this.button1);
            this.lgoti.Controls.Add(this.dataGridView2);
            this.lgoti.Location = new System.Drawing.Point(4, 34);
            this.lgoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lgoti.Name = "lgoti";
            this.lgoti.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lgoti.Size = new System.Drawing.Size(1220, 562);
            this.lgoti.TabIndex = 1;
            this.lgoti.Text = "Список льгот";
            this.lgoti.UseVisualStyleBackColor = true;
            // 
            // Eddlgot
            // 
            this.Eddlgot.Controls.Add(this.label3);
            this.Eddlgot.Controls.Add(this.textBox1);
            this.Eddlgot.Controls.Add(this.panel2);
            this.Eddlgot.Controls.Add(this.bttn_add);
            this.Eddlgot.Location = new System.Drawing.Point(4, 34);
            this.Eddlgot.Name = "Eddlgot";
            this.Eddlgot.Size = new System.Drawing.Size(1220, 562);
            this.Eddlgot.TabIndex = 2;
            this.Eddlgot.Text = "Добавить льготу";
            this.Eddlgot.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите название/тип льготы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 30);
            this.textBox1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 64);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(462, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавление льготы";
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(493, 277);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(183, 41);
            this.bttn_add.TabIndex = 4;
            this.bttn_add.Text = "Добавить";
            this.bttn_add.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1098, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 548);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1098, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 548);
            this.dataGridView2.TabIndex = 7;
            // 
            // _1Predsed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_1Predsed";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.people.ResumeLayout(false);
            this.lgoti.ResumeLayout(false);
            this.Eddlgot.ResumeLayout(false);
            this.Eddlgot.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage people;
        private System.Windows.Forms.TabPage lgoti;
        private System.Windows.Forms.TabPage Eddlgot;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}