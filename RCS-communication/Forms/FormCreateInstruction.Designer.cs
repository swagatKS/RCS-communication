namespace RCS_communication.Forms
{
    partial class FormCreateInstruction
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnInbound = new System.Windows.Forms.RadioButton();
            this.rbtnOutbound = new System.Windows.Forms.RadioButton();
            this.cmbInboundSource = new System.Windows.Forms.ComboBox();
            this.groupBoxInbound = new System.Windows.Forms.GroupBox();
            this.txtInboundDestination = new System.Windows.Forms.TextBox();
            this.groupBoxOutbound = new System.Windows.Forms.GroupBox();
            this.txtOutboundSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOutboundDestination = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBoxInbound.SuspendLayout();
            this.groupBoxOutbound.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(739, 456);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 402);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(474, 26);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priority";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Source";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Destination";
            // 
            // rbtnInbound
            // 
            this.rbtnInbound.AutoSize = true;
            this.rbtnInbound.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInbound.Location = new System.Drawing.Point(61, 31);
            this.rbtnInbound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnInbound.Name = "rbtnInbound";
            this.rbtnInbound.Size = new System.Drawing.Size(142, 34);
            this.rbtnInbound.TabIndex = 13;
            this.rbtnInbound.TabStop = true;
            this.rbtnInbound.Text = "Inbound";
            this.rbtnInbound.UseVisualStyleBackColor = true;
            this.rbtnInbound.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnOutbound
            // 
            this.rbtnOutbound.AutoSize = true;
            this.rbtnOutbound.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOutbound.Location = new System.Drawing.Point(467, 31);
            this.rbtnOutbound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnOutbound.Name = "rbtnOutbound";
            this.rbtnOutbound.Size = new System.Drawing.Size(158, 34);
            this.rbtnOutbound.TabIndex = 14;
            this.rbtnOutbound.TabStop = true;
            this.rbtnOutbound.Text = "Outbound";
            this.rbtnOutbound.UseVisualStyleBackColor = true;
            this.rbtnOutbound.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmbInboundSource
            // 
            this.cmbInboundSource.FormattingEnabled = true;
            this.cmbInboundSource.Items.AddRange(new object[] {
            "IB1",
            "IB2",
            "IB3",
            "IB4",
            "IB5"});
            this.cmbInboundSource.Location = new System.Drawing.Point(174, 52);
            this.cmbInboundSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInboundSource.Name = "cmbInboundSource";
            this.cmbInboundSource.Size = new System.Drawing.Size(136, 28);
            this.cmbInboundSource.TabIndex = 15;
            // 
            // groupBoxInbound
            // 
            this.groupBoxInbound.Controls.Add(this.txtInboundDestination);
            this.groupBoxInbound.Controls.Add(this.label5);
            this.groupBoxInbound.Controls.Add(this.label6);
            this.groupBoxInbound.Controls.Add(this.cmbInboundSource);
            this.groupBoxInbound.Location = new System.Drawing.Point(61, 91);
            this.groupBoxInbound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInbound.Name = "groupBoxInbound";
            this.groupBoxInbound.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxInbound.Size = new System.Drawing.Size(331, 211);
            this.groupBoxInbound.TabIndex = 18;
            this.groupBoxInbound.TabStop = false;
            this.groupBoxInbound.Text = "Inbound Option";
            this.groupBoxInbound.Visible = false;
            // 
            // txtInboundDestination
            // 
            this.txtInboundDestination.Location = new System.Drawing.Point(174, 106);
            this.txtInboundDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInboundDestination.Name = "txtInboundDestination";
            this.txtInboundDestination.Size = new System.Drawing.Size(136, 26);
            this.txtInboundDestination.TabIndex = 16;
            // 
            // groupBoxOutbound
            // 
            this.groupBoxOutbound.Controls.Add(this.txtOutboundSource);
            this.groupBoxOutbound.Controls.Add(this.label1);
            this.groupBoxOutbound.Controls.Add(this.label2);
            this.groupBoxOutbound.Controls.Add(this.cmbOutboundDestination);
            this.groupBoxOutbound.Location = new System.Drawing.Point(467, 91);
            this.groupBoxOutbound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxOutbound.Name = "groupBoxOutbound";
            this.groupBoxOutbound.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxOutbound.Size = new System.Drawing.Size(331, 211);
            this.groupBoxOutbound.TabIndex = 19;
            this.groupBoxOutbound.TabStop = false;
            this.groupBoxOutbound.Text = "Outbound Option";
            this.groupBoxOutbound.Visible = false;
            // 
            // txtOutboundSource
            // 
            this.txtOutboundSource.Location = new System.Drawing.Point(174, 55);
            this.txtOutboundSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutboundSource.Name = "txtOutboundSource";
            this.txtOutboundSource.Size = new System.Drawing.Size(136, 26);
            this.txtOutboundSource.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Destination";
            // 
            // cmbOutboundDestination
            // 
            this.cmbOutboundDestination.FormattingEnabled = true;
            this.cmbOutboundDestination.Items.AddRange(new object[] {
            "OB1",
            "OB2",
            "OB3",
            "OB4",
            "OB5"});
            this.cmbOutboundDestination.Location = new System.Drawing.Point(174, 104);
            this.cmbOutboundDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOutboundDestination.Name = "cmbOutboundDestination";
            this.cmbOutboundDestination.Size = new System.Drawing.Size(136, 28);
            this.cmbOutboundDestination.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LoadingAndUnloading"});
            this.comboBox2.Location = new System.Drawing.Point(197, 351);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(474, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // FormCreateInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 570);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBoxOutbound);
            this.Controls.Add(this.groupBoxInbound);
            this.Controls.Add(this.rbtnOutbound);
            this.Controls.Add(this.rbtnInbound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCreateInstruction";
            this.Text = "CREATE INSTRUCTION";
            this.Load += new System.EventHandler(this.FormCreateInstruction_Load);
            this.groupBoxInbound.ResumeLayout(false);
            this.groupBoxInbound.PerformLayout();
            this.groupBoxOutbound.ResumeLayout(false);
            this.groupBoxOutbound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnInbound;
        private System.Windows.Forms.RadioButton rbtnOutbound;
        private System.Windows.Forms.ComboBox cmbInboundSource;
        private System.Windows.Forms.GroupBox groupBoxInbound;
        private System.Windows.Forms.GroupBox groupBoxOutbound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOutboundDestination;
        private System.Windows.Forms.TextBox txtInboundDestination;
        private System.Windows.Forms.TextBox txtOutboundSource;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}