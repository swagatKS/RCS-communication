namespace RCS_communication.Forms
{
    partial class FormModifyInstruction
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
            this.InboundgroupBox = new System.Windows.Forms.GroupBox();
            this.InboundDestinationtxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutboundgroupBox = new System.Windows.Forms.GroupBox();
            this.Outboundsourcetxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.modifybutton = new System.Windows.Forms.Button();
            this.InboundgroupBox.SuspendLayout();
            this.OutboundgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // InboundgroupBox
            // 
            this.InboundgroupBox.Controls.Add(this.InboundDestinationtxtbox);
            this.InboundgroupBox.Controls.Add(this.label3);
            this.InboundgroupBox.Location = new System.Drawing.Point(46, 261);
            this.InboundgroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InboundgroupBox.Name = "InboundgroupBox";
            this.InboundgroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InboundgroupBox.Size = new System.Drawing.Size(398, 85);
            this.InboundgroupBox.TabIndex = 0;
            this.InboundgroupBox.TabStop = false;
            this.InboundgroupBox.Text = "InboundgroupBox";
            this.InboundgroupBox.Visible = false;
            // 
            // InboundDestinationtxtbox
            // 
            this.InboundDestinationtxtbox.Location = new System.Drawing.Point(110, 42);
            this.InboundDestinationtxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InboundDestinationtxtbox.Name = "InboundDestinationtxtbox";
            this.InboundDestinationtxtbox.Size = new System.Drawing.Size(266, 26);
            this.InboundDestinationtxtbox.TabIndex = 1;
            this.InboundDestinationtxtbox.Enter += new System.EventHandler(this.InboundDestinationtxtbox_Enter);
            this.InboundDestinationtxtbox.Leave += new System.EventHandler(this.InboundDestinationtxtbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination";
            // 
            // OutboundgroupBox
            // 
            this.OutboundgroupBox.Controls.Add(this.Outboundsourcetxtbox);
            this.OutboundgroupBox.Controls.Add(this.label4);
            this.OutboundgroupBox.Location = new System.Drawing.Point(478, 265);
            this.OutboundgroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutboundgroupBox.Name = "OutboundgroupBox";
            this.OutboundgroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutboundgroupBox.Size = new System.Drawing.Size(380, 81);
            this.OutboundgroupBox.TabIndex = 1;
            this.OutboundgroupBox.TabStop = false;
            this.OutboundgroupBox.Text = "OutboundgroupBox";
            this.OutboundgroupBox.Visible = false;
            // 
            // Outboundsourcetxtbox
            // 
            this.Outboundsourcetxtbox.Location = new System.Drawing.Point(90, 35);
            this.Outboundsourcetxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Outboundsourcetxtbox.Name = "Outboundsourcetxtbox";
            this.Outboundsourcetxtbox.Size = new System.Drawing.Size(283, 26);
            this.Outboundsourcetxtbox.TabIndex = 1;
            this.Outboundsourcetxtbox.Enter += new System.EventHandler(this.Outboundsourcetxtbox_Enter);
            this.Outboundsourcetxtbox.Leave += new System.EventHandler(this.Outboundsourcetxtbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Source";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(54, 206);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 30);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inbound";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(478, 206);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 30);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outbound";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Priority";
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(127, 142);
            this.numPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(154, 26);
            this.numPriority.TabIndex = 7;
            // 
            // modifybutton
            // 
            this.modifybutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifybutton.BackColor = System.Drawing.Color.Transparent;
            this.modifybutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modifybutton.FlatAppearance.BorderSize = 0;
            this.modifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifybutton.ForeColor = System.Drawing.Color.Black;
            this.modifybutton.Location = new System.Drawing.Point(758, 434);
            this.modifybutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(100, 42);
            this.modifybutton.TabIndex = 8;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = false;
            this.modifybutton.Click += new System.EventHandler(this.modifybutton_Click);
            // 
            // FormModifyInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.OutboundgroupBox);
            this.Controls.Add(this.InboundgroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormModifyInstruction";
            this.Text = "FormModifyInstruction";
            this.Load += new System.EventHandler(this.FormModifyInstruction_Load_1);
            this.InboundgroupBox.ResumeLayout(false);
            this.InboundgroupBox.PerformLayout();
            this.OutboundgroupBox.ResumeLayout(false);
            this.OutboundgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox InboundgroupBox;
        private System.Windows.Forms.GroupBox OutboundgroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.TextBox InboundDestinationtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Outboundsourcetxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifybutton;
    }
}