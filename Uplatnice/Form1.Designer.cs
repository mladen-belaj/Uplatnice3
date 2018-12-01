namespace Uplatnice
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDohvatiPodatke = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avansTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brojRataTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.odgodaTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rokTB = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seillng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDohvatiPodatke
            // 
            this.buttonDohvatiPodatke.Location = new System.Drawing.Point(430, 8);
            this.buttonDohvatiPodatke.Name = "buttonDohvatiPodatke";
            this.buttonDohvatiPodatke.Size = new System.Drawing.Size(114, 23);
            this.buttonDohvatiPodatke.TabIndex = 0;
            this.buttonDohvatiPodatke.Text = "Dohvati podadtke";
            this.buttonDohvatiPodatke.UseVisualStyleBackColor = true;
            this.buttonDohvatiPodatke.Click += new System.EventHandler(this.buttonDohvatiPodatke_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.id,
            this.status,
            this.company,
            this.address,
            this.zip,
            this.city,
            this.seillng,
            this.paid,
            this.remaining,
            this.date});
            this.grid.Location = new System.Drawing.Point(12, 102);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1189, 375);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Location = new System.Drawing.Point(1126, 10);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(75, 23);
            this.buttonIspis.TabIndex = 2;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od datuma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "do datuma:";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(75, 9);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(133, 20);
            this.date1.TabIndex = 5;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(274, 9);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(133, 20);
            this.date2.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Odaberi sve";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Avans %:";
            // 
            // avansTB
            // 
            this.avansTB.Location = new System.Drawing.Point(75, 39);
            this.avansTB.Name = "avansTB";
            this.avansTB.Size = new System.Drawing.Size(59, 20);
            this.avansTB.TabIndex = 9;
            this.avansTB.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj rata:";
            // 
            // brojRataTB
            // 
            this.brojRataTB.Location = new System.Drawing.Point(269, 43);
            this.brojRataTB.Name = "brojRataTB";
            this.brojRataTB.Size = new System.Drawing.Size(59, 20);
            this.brojRataTB.TabIndex = 11;
            this.brojRataTB.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Odgoda avanas (br dana):";
            // 
            // odgodaTB
            // 
            this.odgodaTB.Location = new System.Drawing.Point(558, 43);
            this.odgodaTB.Name = "odgodaTB";
            this.odgodaTB.Size = new System.Drawing.Size(62, 20);
            this.odgodaTB.TabIndex = 13;
            this.odgodaTB.Text = "14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Krajnji rok za ostatak (br dana):";
            // 
            // rokTB
            // 
            this.rokTB.Location = new System.Drawing.Point(861, 43);
            this.rokTB.Name = "rokTB";
            this.rokTB.Size = new System.Drawing.Size(63, 20);
            this.rokTB.TabIndex = 15;
            this.rokTB.Text = "45";
            // 
            // Select
            // 
            this.Select.FalseValue = "False";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.TrueValue = "True";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // company
            // 
            this.company.DataPropertyName = "name";
            this.company.HeaderText = "name";
            this.company.Name = "company";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            // 
            // zip
            // 
            this.zip.DataPropertyName = "zip";
            this.zip.HeaderText = "zip";
            this.zip.Name = "zip";
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "city";
            this.city.Name = "city";
            // 
            // seillng
            // 
            this.seillng.DataPropertyName = "selling";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.seillng.DefaultCellStyle = dataGridViewCellStyle1;
            this.seillng.HeaderText = "selling";
            this.seillng.Name = "seillng";
            // 
            // paid
            // 
            this.paid.DataPropertyName = "paid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.paid.DefaultCellStyle = dataGridViewCellStyle2;
            this.paid.HeaderText = "paid";
            this.paid.Name = "paid";
            // 
            // remaining
            // 
            this.remaining.DataPropertyName = "remaining";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.remaining.DefaultCellStyle = dataGridViewCellStyle3;
            this.remaining.HeaderText = "remainig";
            this.remaining.Name = "remaining";
            // 
            // date
            // 
            this.date.DataPropertyName = "startdate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle4;
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 545);
            this.Controls.Add(this.rokTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.odgodaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brojRataTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avansTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonDohvatiPodatke);
            this.Name = "Form1";
            this.Text = "Uplatnice";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDohvatiPodatke;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button buttonIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avansTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brojRataTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox odgodaTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rokTB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn seillng;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}

