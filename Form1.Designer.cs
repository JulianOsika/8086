
namespace Mikroprocesor8086
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
            this.button_MOV = new System.Windows.Forms.Button();
            this.textBox_AX = new System.Windows.Forms.TextBox();
            this.label_AX = new System.Windows.Forms.Label();
            this.textBox_BX = new System.Windows.Forms.TextBox();
            this.textBox_CX = new System.Windows.Forms.TextBox();
            this.textBox_DX = new System.Windows.Forms.TextBox();
            this.label_BX = new System.Windows.Forms.Label();
            this.label_CX = new System.Windows.Forms.Label();
            this.label_DX = new System.Windows.Forms.Label();
            this.comboBox_docelowy = new System.Windows.Forms.ComboBox();
            this.comboBox_zrodlowy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAX = new System.Windows.Forms.Label();
            this.labelBX = new System.Windows.Forms.Label();
            this.labelCX = new System.Windows.Forms.Label();
            this.labelDX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonXCHG = new System.Windows.Forms.Button();
            this.comboBoxXCHG1 = new System.Windows.Forms.ComboBox();
            this.comboBoxXCHG2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_MOV
            // 
            this.button_MOV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MOV.Location = new System.Drawing.Point(29, 373);
            this.button_MOV.Name = "button_MOV";
            this.button_MOV.Size = new System.Drawing.Size(101, 50);
            this.button_MOV.TabIndex = 0;
            this.button_MOV.Text = "MOV";
            this.button_MOV.UseVisualStyleBackColor = true;
            this.button_MOV.Click += new System.EventHandler(this.button_MOV_Click);
            // 
            // textBox_AX
            // 
            this.textBox_AX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_AX.Location = new System.Drawing.Point(71, 42);
            this.textBox_AX.MaxLength = 4;
            this.textBox_AX.Name = "textBox_AX";
            this.textBox_AX.Size = new System.Drawing.Size(60, 34);
            this.textBox_AX.TabIndex = 1;
            this.textBox_AX.Leave += new System.EventHandler(this.textBox_AX_Leave);
            // 
            // label_AX
            // 
            this.label_AX.AutoSize = true;
            this.label_AX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AX.Location = new System.Drawing.Point(30, 50);
            this.label_AX.Name = "label_AX";
            this.label_AX.Size = new System.Drawing.Size(37, 25);
            this.label_AX.TabIndex = 2;
            this.label_AX.Text = "AX";
            // 
            // textBox_BX
            // 
            this.textBox_BX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_BX.Location = new System.Drawing.Point(71, 82);
            this.textBox_BX.MaxLength = 4;
            this.textBox_BX.Name = "textBox_BX";
            this.textBox_BX.Size = new System.Drawing.Size(60, 34);
            this.textBox_BX.TabIndex = 3;
            this.textBox_BX.Leave += new System.EventHandler(this.textBox_BX_Leave);
            // 
            // textBox_CX
            // 
            this.textBox_CX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_CX.Location = new System.Drawing.Point(71, 124);
            this.textBox_CX.MaxLength = 4;
            this.textBox_CX.Name = "textBox_CX";
            this.textBox_CX.Size = new System.Drawing.Size(60, 34);
            this.textBox_CX.TabIndex = 4;
            this.textBox_CX.Leave += new System.EventHandler(this.textBox_CX_Leave);
            // 
            // textBox_DX
            // 
            this.textBox_DX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_DX.Location = new System.Drawing.Point(71, 164);
            this.textBox_DX.MaxLength = 4;
            this.textBox_DX.Name = "textBox_DX";
            this.textBox_DX.Size = new System.Drawing.Size(60, 34);
            this.textBox_DX.TabIndex = 5;
            this.textBox_DX.Leave += new System.EventHandler(this.textBox_DX_Leave);
            // 
            // label_BX
            // 
            this.label_BX.AutoSize = true;
            this.label_BX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_BX.Location = new System.Drawing.Point(31, 90);
            this.label_BX.Name = "label_BX";
            this.label_BX.Size = new System.Drawing.Size(36, 25);
            this.label_BX.TabIndex = 6;
            this.label_BX.Text = "BX";
            // 
            // label_CX
            // 
            this.label_CX.AutoSize = true;
            this.label_CX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CX.Location = new System.Drawing.Point(30, 132);
            this.label_CX.Name = "label_CX";
            this.label_CX.Size = new System.Drawing.Size(35, 25);
            this.label_CX.TabIndex = 7;
            this.label_CX.Text = "CX";
            // 
            // label_DX
            // 
            this.label_DX.AutoSize = true;
            this.label_DX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_DX.Location = new System.Drawing.Point(29, 172);
            this.label_DX.Name = "label_DX";
            this.label_DX.Size = new System.Drawing.Size(36, 25);
            this.label_DX.TabIndex = 8;
            this.label_DX.Text = "DX";
            // 
            // comboBox_docelowy
            // 
            this.comboBox_docelowy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_docelowy.FormattingEnabled = true;
            this.comboBox_docelowy.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox_docelowy.Location = new System.Drawing.Point(162, 387);
            this.comboBox_docelowy.Name = "comboBox_docelowy";
            this.comboBox_docelowy.Size = new System.Drawing.Size(90, 36);
            this.comboBox_docelowy.TabIndex = 9;
            // 
            // comboBox_zrodlowy
            // 
            this.comboBox_zrodlowy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_zrodlowy.FormattingEnabled = true;
            this.comboBox_zrodlowy.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox_zrodlowy.Location = new System.Drawing.Point(341, 387);
            this.comboBox_zrodlowy.Name = "comboBox_zrodlowy";
            this.comboBox_zrodlowy.Size = new System.Drawing.Size(90, 36);
            this.comboBox_zrodlowy.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rejestr 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rejestr 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(267, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "<--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 156);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelAX
            // 
            this.labelAX.AutoSize = true;
            this.labelAX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAX.Location = new System.Drawing.Point(162, 45);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(115, 28);
            this.labelAX.TabIndex = 15;
            this.labelAX.Text = "wartość dec";
            // 
            // labelBX
            // 
            this.labelBX.AutoSize = true;
            this.labelBX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBX.Location = new System.Drawing.Point(162, 90);
            this.labelBX.Name = "labelBX";
            this.labelBX.Size = new System.Drawing.Size(115, 28);
            this.labelBX.TabIndex = 16;
            this.labelBX.Text = "wartość dec";
            // 
            // labelCX
            // 
            this.labelCX.AutoSize = true;
            this.labelCX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCX.Location = new System.Drawing.Point(162, 129);
            this.labelCX.Name = "labelCX";
            this.labelCX.Size = new System.Drawing.Size(115, 28);
            this.labelCX.TabIndex = 17;
            this.labelCX.Text = "wartość dec";
            // 
            // labelDX
            // 
            this.labelDX.AutoSize = true;
            this.labelDX.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDX.Location = new System.Drawing.Point(162, 169);
            this.labelDX.Name = "labelDX";
            this.labelDX.Size = new System.Drawing.Size(115, 28);
            this.labelDX.TabIndex = 18;
            this.labelDX.Text = "wartość dec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(267, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "<->";
            // 
            // buttonXCHG
            // 
            this.buttonXCHG.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXCHG.Location = new System.Drawing.Point(29, 505);
            this.buttonXCHG.Name = "buttonXCHG";
            this.buttonXCHG.Size = new System.Drawing.Size(101, 50);
            this.buttonXCHG.TabIndex = 20;
            this.buttonXCHG.Text = "XCHG";
            this.buttonXCHG.UseVisualStyleBackColor = true;
            this.buttonXCHG.Click += new System.EventHandler(this.buttonXCHG_Click);
            // 
            // comboBoxXCHG1
            // 
            this.comboBoxXCHG1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxXCHG1.FormattingEnabled = true;
            this.comboBoxXCHG1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxXCHG1.Location = new System.Drawing.Point(162, 519);
            this.comboBoxXCHG1.Name = "comboBoxXCHG1";
            this.comboBoxXCHG1.Size = new System.Drawing.Size(90, 36);
            this.comboBoxXCHG1.TabIndex = 21;
            // 
            // comboBoxXCHG2
            // 
            this.comboBoxXCHG2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxXCHG2.FormattingEnabled = true;
            this.comboBoxXCHG2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBoxXCHG2.Location = new System.Drawing.Point(341, 519);
            this.comboBoxXCHG2.Name = "comboBoxXCHG2";
            this.comboBoxXCHG2.Size = new System.Drawing.Size(90, 36);
            this.comboBoxXCHG2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(162, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Rejestr 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(341, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Rejestr 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxXCHG2);
            this.Controls.Add(this.comboBoxXCHG1);
            this.Controls.Add(this.buttonXCHG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDX);
            this.Controls.Add(this.labelCX);
            this.Controls.Add(this.labelBX);
            this.Controls.Add(this.labelAX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_zrodlowy);
            this.Controls.Add(this.comboBox_docelowy);
            this.Controls.Add(this.label_DX);
            this.Controls.Add(this.label_CX);
            this.Controls.Add(this.label_BX);
            this.Controls.Add(this.textBox_DX);
            this.Controls.Add(this.textBox_CX);
            this.Controls.Add(this.textBox_BX);
            this.Controls.Add(this.label_AX);
            this.Controls.Add(this.textBox_AX);
            this.Controls.Add(this.button_MOV);
            this.Name = "Form1";
            this.Text = "Mikroprocesor 8086";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_MOV;
        private System.Windows.Forms.TextBox textBox_AX;
        private System.Windows.Forms.Label label_AX;
        private System.Windows.Forms.TextBox textBox_BX;
        private System.Windows.Forms.TextBox textBox_CX;
        private System.Windows.Forms.TextBox textBox_DX;
        private System.Windows.Forms.Label label_BX;
        private System.Windows.Forms.Label label_CX;
        private System.Windows.Forms.Label label_DX;
        private System.Windows.Forms.ComboBox comboBox_docelowy;
        private System.Windows.Forms.ComboBox comboBox_zrodlowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.Label labelBX;
        private System.Windows.Forms.Label labelCX;
        private System.Windows.Forms.Label labelDX;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonXCHG;
        private System.Windows.Forms.ComboBox comboBoxXCHG1;
        private System.Windows.Forms.ComboBox comboBoxXCHG2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

