namespace Utils
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.boxIP = new System.Windows.Forms.Panel();
            this.ipAddr = new System.Windows.Forms.TextBox();
            this.ipMask = new System.Windows.Forms.TextBox();
            this.ipGateway = new System.Windows.Forms.TextBox();
            this.interfaceSelected = new System.Windows.Forms.ComboBox();
            this.setIpAddr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isDynamic = new System.Windows.Forms.RadioButton();
            this.isStatic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.wpawpa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.passwd = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.macBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resultMac = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.boxIP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxIP
            // 
            this.boxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxIP.Controls.Add(this.ipAddr);
            this.boxIP.Controls.Add(this.ipMask);
            this.boxIP.Controls.Add(this.ipGateway);
            this.boxIP.Controls.Add(this.interfaceSelected);
            this.boxIP.Controls.Add(this.setIpAddr);
            this.boxIP.Controls.Add(this.label5);
            this.boxIP.Controls.Add(this.label4);
            this.boxIP.Controls.Add(this.label3);
            this.boxIP.Controls.Add(this.label2);
            this.boxIP.Controls.Add(this.isDynamic);
            this.boxIP.Controls.Add(this.isStatic);
            resources.ApplyResources(this.boxIP, "boxIP");
            this.boxIP.Name = "boxIP";
            this.boxIP.Paint += new System.Windows.Forms.PaintEventHandler(this.boxIP_Paint);
            // 
            // ipAddr
            // 
            this.ipAddr.AcceptsTab = true;
            resources.ApplyResources(this.ipAddr, "ipAddr");
            this.ipAddr.Name = "ipAddr";
            this.ipAddr.TextChanged += new System.EventHandler(this.ipAddr_TextChanged);
            this.ipAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyNum);
            // 
            // ipMask
            // 
            resources.ApplyResources(this.ipMask, "ipMask");
            this.ipMask.Name = "ipMask";
            this.ipMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyNum);
            // 
            // ipGateway
            // 
            resources.ApplyResources(this.ipGateway, "ipGateway");
            this.ipGateway.Name = "ipGateway";
            this.ipGateway.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyNum);
            // 
            // interfaceSelected
            // 
            this.interfaceSelected.FormattingEnabled = true;
            resources.ApplyResources(this.interfaceSelected, "interfaceSelected");
            this.interfaceSelected.Name = "interfaceSelected";
            this.interfaceSelected.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.interfaceSelected.Click += new System.EventHandler(this.addbox);
            // 
            // setIpAddr
            // 
            resources.ApplyResources(this.setIpAddr, "setIpAddr");
            this.setIpAddr.Name = "setIpAddr";
            this.setIpAddr.UseVisualStyleBackColor = true;
            this.setIpAddr.Click += new System.EventHandler(this.setIpAddr_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // isDynamic
            // 
            resources.ApplyResources(this.isDynamic, "isDynamic");
            this.isDynamic.Name = "isDynamic";
            this.isDynamic.UseVisualStyleBackColor = true;
            this.isDynamic.CheckedChanged += new System.EventHandler(this.isDynamic_CheckedChanged);
            // 
            // isStatic
            // 
            resources.ApplyResources(this.isStatic, "isStatic");
            this.isStatic.Checked = true;
            this.isStatic.Name = "isStatic";
            this.isStatic.TabStop = true;
            this.isStatic.UseVisualStyleBackColor = true;
            this.isStatic.CheckedChanged += new System.EventHandler(this.isStatic_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.wpawpa);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wpawpa
            // 
            resources.ApplyResources(this.wpawpa, "wpawpa");
            this.wpawpa.Name = "wpawpa";
            this.wpawpa.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.passwd);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwd
            // 
            resources.ApplyResources(this.passwd, "passwd");
            this.passwd.Name = "passwd";
            this.passwd.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.resultBox);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // resultBox
            // 
            resources.ApplyResources(this.resultBox, "resultBox");
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyNum);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.macBox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.resultMac);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // macBox
            // 
            resources.ApplyResources(this.macBox, "macBox");
            this.macBox.Name = "macBox";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // resultMac
            // 
            resources.ApplyResources(this.resultMac, "resultMac");
            this.resultMac.Name = "resultMac";
            this.resultMac.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.statusBox);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // statusBox
            // 
            resources.ApplyResources(this.statusBox, "statusBox");
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.loadStatus);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Interface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loadStatus);
            this.boxIP.ResumeLayout(false);
            this.boxIP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel boxIP;
        private System.Windows.Forms.Button setIpAddr;
        private System.Windows.Forms.RadioButton isDynamic;
        private System.Windows.Forms.RadioButton isStatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox interfaceSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wpawpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox resultMac;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox macBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ipAddr;
        private System.Windows.Forms.TextBox ipGateway;
        private System.Windows.Forms.TextBox ipMask;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox statusBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
    }
}

