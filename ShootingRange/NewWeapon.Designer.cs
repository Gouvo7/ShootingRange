
namespace ShootingRange
{
    partial class NewWeapon
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BoxAmmoMM = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSoma = new System.Windows.Forms.RadioButton();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.ButtonAth = new System.Windows.Forms.RadioButton();
            this.BoxName = new System.Windows.Forms.ComboBox();
            this.BoxSurname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxADT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Τύπος Όπλου";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Αριθμός άδειας";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Αριθμός όπλου";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(300, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Διαμέτρημα φυσσιγγιών";
            // 
            // BoxAmmoMM
            // 
            this.BoxAmmoMM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxAmmoMM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxAmmoMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxAmmoMM.FormattingEnabled = true;
            this.BoxAmmoMM.ItemHeight = 13;
            this.BoxAmmoMM.Location = new System.Drawing.Point(300, 223);
            this.BoxAmmoMM.Name = "BoxAmmoMM";
            this.BoxAmmoMM.Size = new System.Drawing.Size(124, 21);
            this.BoxAmmoMM.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Καταχώρηση";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButtonSoma
            // 
            this.ButtonSoma.AutoSize = true;
            this.ButtonSoma.Location = new System.Drawing.Point(100, 24);
            this.ButtonSoma.Name = "ButtonSoma";
            this.ButtonSoma.Size = new System.Drawing.Size(109, 17);
            this.ButtonSoma.TabIndex = 37;
            this.ButtonSoma.TabStop = true;
            this.ButtonSoma.Text = "Όπλο Σωματείου";
            this.ButtonSoma.UseVisualStyleBackColor = true;
            this.ButtonSoma.CheckedChanged += new System.EventHandler(this.Check_Changed);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // ButtonAth
            // 
            this.ButtonAth.AutoSize = true;
            this.ButtonAth.Location = new System.Drawing.Point(300, 24);
            this.ButtonAth.Name = "ButtonAth";
            this.ButtonAth.Size = new System.Drawing.Size(90, 17);
            this.ButtonAth.TabIndex = 38;
            this.ButtonAth.TabStop = true;
            this.ButtonAth.Text = "Όπλο Αθλητή";
            this.ButtonAth.UseVisualStyleBackColor = true;
            // 
            // BoxName
            // 
            this.BoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxName.FormattingEnabled = true;
            this.BoxName.Location = new System.Drawing.Point(180, 87);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(121, 21);
            this.BoxName.TabIndex = 42;
            // 
            // BoxSurname
            // 
            this.BoxSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxSurname.FormattingEnabled = true;
            this.BoxSurname.Location = new System.Drawing.Point(20, 87);
            this.BoxSurname.Name = "BoxSurname";
            this.BoxSurname.Size = new System.Drawing.Size(121, 21);
            this.BoxSurname.TabIndex = 41;
            this.BoxSurname.SelectedIndexChanged += new System.EventHandler(this.BoxSurname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Όνομα";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Επώνυμο";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Α.Δ.Τ.";
            // 
            // BoxADT
            // 
            this.BoxADT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxADT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxADT.FormattingEnabled = true;
            this.BoxADT.Location = new System.Drawing.Point(340, 87);
            this.BoxADT.Name = "BoxADT";
            this.BoxADT.Size = new System.Drawing.Size(121, 21);
            this.BoxADT.TabIndex = 45;
            // 
            // NewWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.BoxADT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BoxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonAth);
            this.Controls.Add(this.ButtonSoma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BoxAmmoMM);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NewWeapon";
            this.Text = "Καταχώρηση Όπλου";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewWeapon_Close);
            this.Load += new System.EventHandler(this.NewWeapon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BoxAmmoMM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ButtonSoma;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private System.Windows.Forms.RadioButton ButtonAth;
        private System.Windows.Forms.ComboBox BoxName;
        private System.Windows.Forms.ComboBox BoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxADT;
    }
}