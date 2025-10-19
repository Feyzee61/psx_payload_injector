namespace PayloadInjector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbElfFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbElfPort = new System.Windows.Forms.TextBox();
            this.btnSendElf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBinFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBinPort = new System.Windows.Forms.TextBox();
            this.btnSendBin = new System.Windows.Forms.Button();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendPs4ElfLdr = new System.Windows.Forms.Button();
            this.btnSendPs5ElfLdr = new System.Windows.Forms.Button();
            this.lbBinSize = new System.Windows.Forms.Label();
            this.lbElfSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbElfSize);
            this.groupBox1.Controls.Add(this.tbElfFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbElfPort);
            this.groupBox1.Controls.Add(this.btnSendElf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELF Injector";
            // 
            // tbElfFile
            // 
            this.tbElfFile.Location = new System.Drawing.Point(6, 22);
            this.tbElfFile.Name = "tbElfFile";
            this.tbElfFile.ReadOnly = true;
            this.tbElfFile.Size = new System.Drawing.Size(324, 22);
            this.tbElfFile.TabIndex = 7;
            this.tbElfFile.TabStop = false;
            this.tbElfFile.Text = "Drag & Drop .elf file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // tbElfPort
            // 
            this.tbElfPort.Location = new System.Drawing.Point(194, 78);
            this.tbElfPort.MaxLength = 5;
            this.tbElfPort.Name = "tbElfPort";
            this.tbElfPort.Size = new System.Drawing.Size(50, 22);
            this.tbElfPort.TabIndex = 8;
            this.tbElfPort.Text = "9021";
            this.tbElfPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbElfPort.TextChanged += new System.EventHandler(this.tbElfPort_TextChanged);
            this.tbElfPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBinPort_KeyPress);
            // 
            // btnSendElf
            // 
            this.btnSendElf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendElf.Location = new System.Drawing.Point(250, 73);
            this.btnSendElf.Name = "btnSendElf";
            this.btnSendElf.Size = new System.Drawing.Size(80, 32);
            this.btnSendElf.TabIndex = 9;
            this.btnSendElf.Text = "Inject Elf";
            this.btnSendElf.UseVisualStyleBackColor = true;
            this.btnSendElf.Click += new System.EventHandler(this.btnSendElf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBinSize);
            this.groupBox2.Controls.Add(this.tbBinFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbBinPort);
            this.groupBox2.Controls.Add(this.btnSendBin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BIN Injector";
            // 
            // tbBinFile
            // 
            this.tbBinFile.Location = new System.Drawing.Point(6, 22);
            this.tbBinFile.Name = "tbBinFile";
            this.tbBinFile.ReadOnly = true;
            this.tbBinFile.Size = new System.Drawing.Size(324, 22);
            this.tbBinFile.TabIndex = 4;
            this.tbBinFile.TabStop = false;
            this.tbBinFile.Text = "Drag & Drop .bin file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port:";
            // 
            // tbBinPort
            // 
            this.tbBinPort.Location = new System.Drawing.Point(194, 78);
            this.tbBinPort.MaxLength = 5;
            this.tbBinPort.Name = "tbBinPort";
            this.tbBinPort.Size = new System.Drawing.Size(50, 22);
            this.tbBinPort.TabIndex = 5;
            this.tbBinPort.Text = "9090";
            this.tbBinPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBinPort.TextChanged += new System.EventHandler(this.tbBinPort_TextChanged);
            this.tbBinPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBinPort_KeyPress);
            // 
            // btnSendBin
            // 
            this.btnSendBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBin.Location = new System.Drawing.Point(250, 73);
            this.btnSendBin.Name = "btnSendBin";
            this.btnSendBin.Size = new System.Drawing.Size(80, 32);
            this.btnSendBin.TabIndex = 6;
            this.btnSendBin.Text = "Inject Bin";
            this.btnSendBin.UseVisualStyleBackColor = true;
            this.btnSendBin.Click += new System.EventHandler(this.btnSendBin_Click);
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbIPAddress.Location = new System.Drawing.Point(95, 9);
            this.tbIPAddress.MaxLength = 15;
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(170, 22);
            this.tbIPAddress.TabIndex = 3;
            this.tbIPAddress.Text = "192.168.1.30";
            this.tbIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIPAddress.TextChanged += new System.EventHandler(this.tbIPAddress_TextChanged);
            this.tbIPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIPAddress_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address:";
            // 
            // btnSendPs4ElfLdr
            // 
            this.btnSendPs4ElfLdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPs4ElfLdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendPs4ElfLdr.ForeColor = System.Drawing.Color.White;
            this.btnSendPs4ElfLdr.Location = new System.Drawing.Point(6, 55);
            this.btnSendPs4ElfLdr.Name = "btnSendPs4ElfLdr";
            this.btnSendPs4ElfLdr.Size = new System.Drawing.Size(150, 32);
            this.btnSendPs4ElfLdr.TabIndex = 1;
            this.btnSendPs4ElfLdr.Text = "Inject PS4 Elf Loader";
            this.btnSendPs4ElfLdr.UseVisualStyleBackColor = true;
            this.btnSendPs4ElfLdr.Click += new System.EventHandler(this.btnSendPs4ElfLdr_Click);
            // 
            // btnSendPs5ElfLdr
            // 
            this.btnSendPs5ElfLdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPs5ElfLdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendPs5ElfLdr.ForeColor = System.Drawing.Color.White;
            this.btnSendPs5ElfLdr.Location = new System.Drawing.Point(180, 55);
            this.btnSendPs5ElfLdr.Name = "btnSendPs5ElfLdr";
            this.btnSendPs5ElfLdr.Size = new System.Drawing.Size(150, 32);
            this.btnSendPs5ElfLdr.TabIndex = 2;
            this.btnSendPs5ElfLdr.Text = "Inject PS5 Elf Loader";
            this.btnSendPs5ElfLdr.UseVisualStyleBackColor = true;
            this.btnSendPs5ElfLdr.Click += new System.EventHandler(this.btnSendPs5ElfLdr_Click);
            // 
            // lbBinSize
            // 
            this.lbBinSize.AutoSize = true;
            this.lbBinSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBinSize.Location = new System.Drawing.Point(6, 47);
            this.lbBinSize.Name = "lbBinSize";
            this.lbBinSize.Size = new System.Drawing.Size(139, 16);
            this.lbBinSize.TabIndex = 8;
            this.lbBinSize.Text = "Load a bin file to inject";
            // 
            // lbElfSize
            // 
            this.lbElfSize.AutoSize = true;
            this.lbElfSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbElfSize.Location = new System.Drawing.Point(6, 47);
            this.lbElfSize.Name = "lbElfSize";
            this.lbElfSize.Size = new System.Drawing.Size(142, 16);
            this.lbElfSize.TabIndex = 10;
            this.lbElfSize.Text = "Load an elf file to inject";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSendPs4ElfLdr);
            this.groupBox3.Controls.Add(this.btnSendPs5ElfLdr);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 93);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elf Loader";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inject Elf Loader payload to support Elf Injection";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(360, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payload Injector v1.1 by Feyzee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendElf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendBin;
        private System.Windows.Forms.TextBox tbElfFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbElfPort;
        private System.Windows.Forms.TextBox tbBinFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBinPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendPs4ElfLdr;
        private System.Windows.Forms.Button btnSendPs5ElfLdr;
        private System.Windows.Forms.Label lbElfSize;
        private System.Windows.Forms.Label lbBinSize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}


