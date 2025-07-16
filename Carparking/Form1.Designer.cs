namespace Carparking
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_platnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btt_add = new System.Windows.Forms.Button();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.btnF1P1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_F1P1 = new System.Windows.Forms.Label();
            this.btnF1P3 = new System.Windows.Forms.Button();
            this.lbl_F1P3 = new System.Windows.Forms.Label();
            this.btnF1P2 = new System.Windows.Forms.Button();
            this.lbl_F1P2 = new System.Windows.Forms.Label();
            this.btnF2P2 = new System.Windows.Forms.Button();
            this.lbl_F2P2 = new System.Windows.Forms.Label();
            this.btnF2P3 = new System.Windows.Forms.Button();
            this.lbl_F2P3 = new System.Windows.Forms.Label();
            this.btnF2P1 = new System.Windows.Forms.Button();
            this.btnF3P2 = new System.Windows.Forms.Button();
            this.lbl_F3P2 = new System.Windows.Forms.Label();
            this.btnF3P3 = new System.Windows.Forms.Button();
            this.lbl_F3P3 = new System.Windows.Forms.Label();
            this.btnF3P1 = new System.Windows.Forms.Button();
            this.lbl_F2P1 = new System.Windows.Forms.Label();
            this.lbl_F3P1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car parking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(29, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(708, 189);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_platnumber
            // 
            this.txt_platnumber.Location = new System.Drawing.Point(141, 86);
            this.txt_platnumber.Name = "txt_platnumber";
            this.txt_platnumber.ReadOnly = true;
            this.txt_platnumber.Size = new System.Drawing.Size(150, 20);
            this.txt_platnumber.TabIndex = 3;
            this.txt_platnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(445, 86);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(292, 20);
            this.txt_phonenumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FLoor 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "FLoor 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "FLoor 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Booking Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 368);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(492, 369);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(75, 23);
            this.btt_add.TabIndex = 12;
            this.btt_add.Text = "ADD";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt_cancel
            // 
            this.btt_cancel.Location = new System.Drawing.Point(571, 369);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_cancel.TabIndex = 13;
            this.btt_cancel.Text = "CANCEL";
            this.btt_cancel.UseVisualStyleBackColor = true;
            // 
            // btnF1P1
            // 
            this.btnF1P1.BackColor = System.Drawing.Color.Green;
            this.btnF1P1.Location = new System.Drawing.Point(100, 182);
            this.btnF1P1.Name = "btnF1P1";
            this.btnF1P1.Size = new System.Drawing.Size(33, 22);
            this.btnF1P1.TabIndex = 29;
            this.btnF1P1.UseVisualStyleBackColor = false;
            this.btnF1P1.Click += new System.EventHandler(this.btnF1P1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(485, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 20);
            this.label21.TabIndex = 28;
            // 
            // lbl_F1P1
            // 
            this.lbl_F1P1.AutoSize = true;
            this.lbl_F1P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F1P1.Location = new System.Drawing.Point(109, 166);
            this.lbl_F1P1.Name = "lbl_F1P1";
            this.lbl_F1P1.Size = new System.Drawing.Size(20, 13);
            this.lbl_F1P1.TabIndex = 14;
            this.lbl_F1P1.Text = "P1";
            this.lbl_F1P1.Click += new System.EventHandler(this.label22_Click);
            // 
            // btnF1P3
            // 
            this.btnF1P3.BackColor = System.Drawing.Color.Green;
            this.btnF1P3.Location = new System.Drawing.Point(100, 281);
            this.btnF1P3.Name = "btnF1P3";
            this.btnF1P3.Size = new System.Drawing.Size(33, 22);
            this.btnF1P3.TabIndex = 31;
            this.btnF1P3.UseVisualStyleBackColor = false;
            this.btnF1P3.Click += new System.EventHandler(this.btnF1P3_Click);
            // 
            // lbl_F1P3
            // 
            this.lbl_F1P3.AutoSize = true;
            this.lbl_F1P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F1P3.Location = new System.Drawing.Point(109, 264);
            this.lbl_F1P3.Name = "lbl_F1P3";
            this.lbl_F1P3.Size = new System.Drawing.Size(20, 13);
            this.lbl_F1P3.TabIndex = 30;
            this.lbl_F1P3.Text = "P3";
            this.lbl_F1P3.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnF1P2
            // 
            this.btnF1P2.BackColor = System.Drawing.Color.Green;
            this.btnF1P2.Location = new System.Drawing.Point(100, 229);
            this.btnF1P2.Name = "btnF1P2";
            this.btnF1P2.Size = new System.Drawing.Size(33, 22);
            this.btnF1P2.TabIndex = 33;
            this.btnF1P2.UseVisualStyleBackColor = false;
            this.btnF1P2.Click += new System.EventHandler(this.btnF1P2_Click);
            // 
            // lbl_F1P2
            // 
            this.lbl_F1P2.AutoSize = true;
            this.lbl_F1P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F1P2.Location = new System.Drawing.Point(109, 213);
            this.lbl_F1P2.Name = "lbl_F1P2";
            this.lbl_F1P2.Size = new System.Drawing.Size(20, 13);
            this.lbl_F1P2.TabIndex = 32;
            this.lbl_F1P2.Text = "P2";
            // 
            // btnF2P2
            // 
            this.btnF2P2.BackColor = System.Drawing.Color.Green;
            this.btnF2P2.Location = new System.Drawing.Point(346, 239);
            this.btnF2P2.Name = "btnF2P2";
            this.btnF2P2.Size = new System.Drawing.Size(33, 22);
            this.btnF2P2.TabIndex = 38;
            this.btnF2P2.UseVisualStyleBackColor = false;
            this.btnF2P2.Click += new System.EventHandler(this.btnF2P2_Click);
            // 
            // lbl_F2P2
            // 
            this.lbl_F2P2.AutoSize = true;
            this.lbl_F2P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F2P2.Location = new System.Drawing.Point(355, 223);
            this.lbl_F2P2.Name = "lbl_F2P2";
            this.lbl_F2P2.Size = new System.Drawing.Size(20, 13);
            this.lbl_F2P2.TabIndex = 37;
            this.lbl_F2P2.Text = "P2";
            // 
            // btnF2P3
            // 
            this.btnF2P3.BackColor = System.Drawing.Color.Green;
            this.btnF2P3.Location = new System.Drawing.Point(346, 291);
            this.btnF2P3.Name = "btnF2P3";
            this.btnF2P3.Size = new System.Drawing.Size(33, 22);
            this.btnF2P3.TabIndex = 36;
            this.btnF2P3.UseVisualStyleBackColor = false;
            this.btnF2P3.Click += new System.EventHandler(this.btnF2P3_Click);
            // 
            // lbl_F2P3
            // 
            this.lbl_F2P3.AutoSize = true;
            this.lbl_F2P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F2P3.Location = new System.Drawing.Point(355, 274);
            this.lbl_F2P3.Name = "lbl_F2P3";
            this.lbl_F2P3.Size = new System.Drawing.Size(20, 13);
            this.lbl_F2P3.TabIndex = 35;
            this.lbl_F2P3.Text = "P3";
            // 
            // btnF2P1
            // 
            this.btnF2P1.BackColor = System.Drawing.Color.Green;
            this.btnF2P1.Location = new System.Drawing.Point(346, 192);
            this.btnF2P1.Name = "btnF2P1";
            this.btnF2P1.Size = new System.Drawing.Size(33, 22);
            this.btnF2P1.TabIndex = 34;
            this.btnF2P1.UseVisualStyleBackColor = false;
            this.btnF2P1.Click += new System.EventHandler(this.btnF2P1_Click);
            // 
            // btnF3P2
            // 
            this.btnF3P2.BackColor = System.Drawing.Color.Green;
            this.btnF3P2.Location = new System.Drawing.Point(590, 239);
            this.btnF3P2.Name = "btnF3P2";
            this.btnF3P2.Size = new System.Drawing.Size(33, 22);
            this.btnF3P2.TabIndex = 43;
            this.btnF3P2.UseVisualStyleBackColor = false;
            this.btnF3P2.Click += new System.EventHandler(this.btnF3P2_Click);
            // 
            // lbl_F3P2
            // 
            this.lbl_F3P2.AutoSize = true;
            this.lbl_F3P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F3P2.Location = new System.Drawing.Point(599, 223);
            this.lbl_F3P2.Name = "lbl_F3P2";
            this.lbl_F3P2.Size = new System.Drawing.Size(20, 13);
            this.lbl_F3P2.TabIndex = 42;
            this.lbl_F3P2.Text = "P2";
            // 
            // btnF3P3
            // 
            this.btnF3P3.BackColor = System.Drawing.Color.Green;
            this.btnF3P3.Location = new System.Drawing.Point(590, 291);
            this.btnF3P3.Name = "btnF3P3";
            this.btnF3P3.Size = new System.Drawing.Size(33, 22);
            this.btnF3P3.TabIndex = 41;
            this.btnF3P3.UseVisualStyleBackColor = false;
            this.btnF3P3.Click += new System.EventHandler(this.btnF3P3_Click);
            // 
            // lbl_F3P3
            // 
            this.lbl_F3P3.AutoSize = true;
            this.lbl_F3P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F3P3.Location = new System.Drawing.Point(599, 274);
            this.lbl_F3P3.Name = "lbl_F3P3";
            this.lbl_F3P3.Size = new System.Drawing.Size(20, 13);
            this.lbl_F3P3.TabIndex = 40;
            this.lbl_F3P3.Text = "P3";
            // 
            // btnF3P1
            // 
            this.btnF3P1.BackColor = System.Drawing.Color.Green;
            this.btnF3P1.Location = new System.Drawing.Point(590, 192);
            this.btnF3P1.Name = "btnF3P1";
            this.btnF3P1.Size = new System.Drawing.Size(33, 22);
            this.btnF3P1.TabIndex = 39;
            this.btnF3P1.UseVisualStyleBackColor = false;
            this.btnF3P1.Click += new System.EventHandler(this.btnF3P1_Click);
            // 
            // lbl_F2P1
            // 
            this.lbl_F2P1.AutoSize = true;
            this.lbl_F2P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F2P1.Location = new System.Drawing.Point(351, 176);
            this.lbl_F2P1.Name = "lbl_F2P1";
            this.lbl_F2P1.Size = new System.Drawing.Size(20, 13);
            this.lbl_F2P1.TabIndex = 44;
            this.lbl_F2P1.Text = "P1";
            // 
            // lbl_F3P1
            // 
            this.lbl_F3P1.AutoSize = true;
            this.lbl_F3P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F3P1.Location = new System.Drawing.Point(599, 176);
            this.lbl_F3P1.Name = "lbl_F3P1";
            this.lbl_F3P1.Size = new System.Drawing.Size(20, 13);
            this.lbl_F3P1.TabIndex = 45;
            this.lbl_F3P1.Text = "P1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 607);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Fee";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 604);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 46;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(649, 369);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(88, 23);
            this.btn_checkout.TabIndex = 48;
            this.btn_checkout.Text = "CHECK OUT";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "General Fee: ";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "1h =1000R";
            this.label10.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Plat Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Plat Token";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Phone Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Booking Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_F3P1);
            this.Controls.Add(this.lbl_F2P1);
            this.Controls.Add(this.btnF3P2);
            this.Controls.Add(this.lbl_F3P2);
            this.Controls.Add(this.btnF3P3);
            this.Controls.Add(this.lbl_F3P3);
            this.Controls.Add(this.btnF3P1);
            this.Controls.Add(this.btnF2P2);
            this.Controls.Add(this.lbl_F2P2);
            this.Controls.Add(this.btnF2P3);
            this.Controls.Add(this.lbl_F2P3);
            this.Controls.Add(this.btnF2P1);
            this.Controls.Add(this.btnF1P2);
            this.Controls.Add(this.lbl_F1P2);
            this.Controls.Add(this.btnF1P3);
            this.Controls.Add(this.lbl_F1P3);
            this.Controls.Add(this.btnF1P1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbl_F1P1);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_platnumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_platnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btt_add;
        private System.Windows.Forms.Button btt_cancel;
        private System.Windows.Forms.Button btnF1P1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_F1P1;
        private System.Windows.Forms.Button btnF1P3;
        private System.Windows.Forms.Label lbl_F1P3;
        private System.Windows.Forms.Button btnF1P2;
        private System.Windows.Forms.Label lbl_F1P2;
        private System.Windows.Forms.Button btnF2P2;
        private System.Windows.Forms.Label lbl_F2P2;
        private System.Windows.Forms.Button btnF2P3;
        private System.Windows.Forms.Label lbl_F2P3;
        private System.Windows.Forms.Button btnF2P1;
        private System.Windows.Forms.Button btnF3P2;
        private System.Windows.Forms.Label lbl_F3P2;
        private System.Windows.Forms.Button btnF3P3;
        private System.Windows.Forms.Label lbl_F3P3;
        private System.Windows.Forms.Button btnF3P1;
        private System.Windows.Forms.Label lbl_F2P1;
        private System.Windows.Forms.Label lbl_F3P1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

