﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCS_communication.Forms
{
    public partial class FormCreateInstruction : Form
    {
        public FormCreateInstruction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInbound.Checked)
            {
         
                groupBoxInbound.Visible = true;
                groupBoxOutbound.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOutbound.Checked)
            {
                groupBoxInbound.Visible = false;
                groupBoxOutbound.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCreateInstruction_Load(object sender, EventArgs e)
        {
            // For Inbound Destination
            txtInboundDestination.Text = "e.g: R1S1C1 to R5S5C5";
            txtInboundDestination.ForeColor = Color.Gray;
            txtInboundDestination.Font = new Font(txtInboundDestination.Font, FontStyle.Italic);

            // For Outbound Source
            txtOutboundSource.Text = "e.g: R1S1C1 to R5S5C5";
            txtOutboundSource.ForeColor = Color.Gray;
            txtOutboundSource.Font = new Font(txtOutboundSource.Font, FontStyle.Italic);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = string.Empty;
            string destination = string.Empty;
            bool isValid = true;
            string pattern = @"^[rR][1-5][sS][1-5][cC][1-5]$";
            string generatedId = string.Empty;

            int priority = (int)numPriority.Value;


            if (rbtnInbound.Checked)
            {
                source = cmbInboundSource.Text;
                destination = txtInboundDestination.Text;

                string[] InboundvalidOptions = { "IB1", "IB2", "IB3", "IB4", "IB5" };

                if (!InboundvalidOptions.Contains(source))
                {
                    isValid = false;
                    MessageBox.Show("Invalid Inbound Source selection. Please choose one of IB1-5.");
                }

                else if (!Regex.IsMatch(destination, pattern))
                {
                    isValid = false;
                    MessageBox.Show("Invalid input. Please enter a valid DESTINATION in the format R1S1C1 to R5S5C5.");
                }
                if (isValid)
                {
                    generatedId = BusinessLogic.GenerateId();
                    MessageBox.Show("Valid INBOUND input!\nGenerated ID: " + generatedId + "\nPriority: " + priority);
                }

            }
            else if (rbtnOutbound.Checked)
            {
                source = txtOutboundSource.Text;
                destination = cmbOutboundDestination.Text;
                string[] OutboundvalidOptions = { "OB1", "OB2", "OB3", "OB4", "OB5" };

                if (!Regex.IsMatch(source, pattern))
                {
                    isValid = false;
                    MessageBox.Show("Invalid input. Please enter a valid SOURCE in the format R1S1C1 to R5S5C5.");
                }

                else if (!OutboundvalidOptions.Contains(destination))
                {
                    isValid = false;
                    MessageBox.Show("Invalid Outbound Destination selection. Please choose one of OB1-5.");
                }
                
                if (isValid)
                {
                    generatedId = BusinessLogic.GenerateId();
                    MessageBox.Show("Valid OUTBOUND input!\nGenerated ID: " + generatedId + "\nPriority: " + priority);
                }

            }
          
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInboundDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInboundDestination_Enter(object sender, EventArgs e)
        {
            if (txtInboundDestination.Text == "e.g: R1S1C1 to R5S5C5")
            {
                txtInboundDestination.Text = string.Empty; // Clear the placeholder text
                txtInboundDestination.ForeColor = SystemColors.WindowText; // Restore the default text color
                txtInboundDestination.Font = new Font(txtInboundDestination.Font, FontStyle.Regular); // Restore the regular style
            }
        }

        private void txtInboundDestination_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInboundDestination.Text))
            {
                txtInboundDestination.Text = "e.g: R1S1C1 to R5S5C5";
                txtInboundDestination.ForeColor = Color.Gray;
                txtInboundDestination.Font = new Font(txtInboundDestination.Font, FontStyle.Italic);
            }
        }

        private void txtOutboundSource_Enter(object sender, EventArgs e)
        {
            if (txtOutboundSource.Text == "e.g: R1S1C1 to R5S5C5")
            {
                txtOutboundSource.Text = string.Empty; // Clear the placeholder text
                txtOutboundSource.ForeColor = SystemColors.WindowText; // Restore the default text color
                txtOutboundSource.Font = new Font(txtOutboundSource.Font, FontStyle.Regular); // Restore the regular style
            }

        }

        private void txtOutboundSource_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutboundSource.Text))
            {
                txtOutboundSource.Text = "e.g: R1S1C1 to R5S5C5";
                txtOutboundSource.ForeColor = Color.Gray;
                txtOutboundSource.Font = new Font(txtOutboundSource.Font, FontStyle.Italic);
            }
        }

        private void txtOutboundSource_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
