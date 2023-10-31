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
            this.OutboundgroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InboundDestinationtxtbox = new System.Windows.Forms.TextBox();
            this.Outboundsourcetxtbox = new System.Windows.Forms.TextBox();
            this.modifybutton = new System.Windows.Forms.Button();
            this.InboundgroupBox.SuspendLayout();
            this.OutboundgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // InboundgroupBox
            // 
            this.InboundgroupBox.Controls.Add(this.InboundDestinationtxtbox);
            this.InboundgroupBox.Controls.Add(this.label3);
            this.InboundgroupBox.Location = new System.Drawing.Point(41, 209);
            this.InboundgroupBox.Name = "InboundgroupBox";
            this.InboundgroupBox.Size = new System.Drawing.Size(354, 68);
            this.InboundgroupBox.TabIndex = 0;
            this.InboundgroupBox.TabStop = false;
            this.InboundgroupBox.Text = "InboundgroupBox";
            this.InboundgroupBox.Visible = false;
            // 
            // OutboundgroupBox
            // 
            this.OutboundgroupBox.Controls.Add(this.Outboundsourcetxtbox);
            this.OutboundgroupBox.Controls.Add(this.label4);
            this.OutboundgroupBox.Location = new System.Drawing.Point(425, 212);
            this.OutboundgroupBox.Name = "OutboundgroupBox";
            this.OutboundgroupBox.Size = new System.Drawing.Size(338, 65);
            this.OutboundgroupBox.TabIndex = 1;
            this.OutboundgroupBox.TabStop = false;
            this.OutboundgroupBox.Text = "OutboundgroupBox";
            this.OutboundgroupBox.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(48, 165);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 26);
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
            this.radioButton2.Location = new System.Drawing.Point(425, 165);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 26);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Outbound";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Priority";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Source";
            // 
            // InboundDestinationtxtbox
            // 
            this.InboundDestinationtxtbox.Location = new System.Drawing.Point(98, 34);
            this.InboundDestinationtxtbox.Name = "InboundDestinationtxtbox";
            this.InboundDestinationtxtbox.Size = new System.Drawing.Size(237, 22);
            this.InboundDestinationtxtbox.TabIndex = 1;
            this.InboundDestinationtxtbox.Enter += new System.EventHandler(this.InboundDestinationtxtbox_Enter);
            this.InboundDestinationtxtbox.Leave += new System.EventHandler(this.InboundDestinationtxtbox_Leave);
            // 
            // Outboundsourcetxtbox
            // 
            this.Outboundsourcetxtbox.Location = new System.Drawing.Point(80, 28);
            this.Outboundsourcetxtbox.Name = "Outboundsourcetxtbox";
            this.Outboundsourcetxtbox.Size = new System.Drawing.Size(252, 22);
            this.Outboundsourcetxtbox.TabIndex = 1;
            this.Outboundsourcetxtbox.Enter += new System.EventHandler(this.Outboundsourcetxtbox_Enter);
            this.Outboundsourcetxtbox.Leave += new System.EventHandler(this.Outboundsourcetxtbox_Leave);
            // 
            // modifybutton
            // 
            this.modifybutton.Location = new System.Drawing.Point(573, 317);
            this.modifybutton.Name = "modifybutton";
            this.modifybutton.Size = new System.Drawing.Size(189, 62);
            this.modifybutton.TabIndex = 8;
            this.modifybutton.Text = "Modify";
            this.modifybutton.UseVisualStyleBackColor = true;
            // 
            // FormModifyInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifybutton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.OutboundgroupBox);
            this.Controls.Add(this.InboundgroupBox);
            this.Name = "FormModifyInstruction";
            this.Text = "FormModifyInstruction";
            this.InboundgroupBox.ResumeLayout(false);
            this.InboundgroupBox.PerformLayout();
            this.OutboundgroupBox.ResumeLayout(false);
            this.OutboundgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox InboundDestinationtxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Outboundsourcetxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifybutton;
    }
}