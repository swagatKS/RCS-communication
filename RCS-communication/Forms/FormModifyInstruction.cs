using System;
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
    public partial class FormModifyInstruction : Form
    {
        public FormModifyInstruction()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                InboundgroupBox.Visible = true;
                OutboundgroupBox.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                InboundgroupBox.Visible = false;
                OutboundgroupBox.Visible = true;
            }
        }

        private void InboundDestinationtxtbox_Enter(object sender, EventArgs e)
        {
            if (InboundDestinationtxtbox.Text == "e.g: R1S1C1 to R5S5C5")
            {
                InboundDestinationtxtbox.Text = string.Empty; 
                InboundDestinationtxtbox.ForeColor = SystemColors.WindowText; 
                InboundDestinationtxtbox.Font = new Font(InboundDestinationtxtbox.Font, FontStyle.Regular);
            }
        }

        private void InboundDestinationtxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InboundDestinationtxtbox.Text))
            {
                InboundDestinationtxtbox.Text = "e.g: R1S1C1 to R5S5C5";
                InboundDestinationtxtbox.ForeColor = Color.Gray;
                InboundDestinationtxtbox.Font = new Font(InboundDestinationtxtbox.Font, FontStyle.Italic);
            }
        }

        private void Outboundsourcetxtbox_Enter(object sender, EventArgs e)
        {
            if (Outboundsourcetxtbox.Text == "e.g: R1S1C1 to R5S5C5")
            {
                Outboundsourcetxtbox.Text = string.Empty;
                Outboundsourcetxtbox.ForeColor = SystemColors.WindowText;
                Outboundsourcetxtbox.Font = new Font(Outboundsourcetxtbox.Font, FontStyle.Regular);
            }
        }

        private void Outboundsourcetxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Outboundsourcetxtbox.Text))
            {
                Outboundsourcetxtbox.Text = "e.g: R1S1C1 to R5S5C5";
                Outboundsourcetxtbox.ForeColor = Color.Gray;
                Outboundsourcetxtbox.Font = new Font(Outboundsourcetxtbox.Font, FontStyle.Italic);
            }
        }

        private void FormModifyInstruction_Load_1(object sender, EventArgs e)
        {
            // For Inbound Destination
            InboundDestinationtxtbox.Text = "e.g: R1S1C1 to R5S5C5";
            InboundDestinationtxtbox.ForeColor = Color.Gray;
            InboundDestinationtxtbox.Font = new Font(InboundDestinationtxtbox.Font, FontStyle.Italic);

            // For Outbound Source
            Outboundsourcetxtbox.Text = "e.g: R1S1C1 to R5S5C5";
            Outboundsourcetxtbox.ForeColor = Color.Gray;
            Outboundsourcetxtbox.Font = new Font(Outboundsourcetxtbox.Font, FontStyle.Italic);
        }

        private void modifybutton_Click(object sender, EventArgs e)
        {
            string source = string.Empty;
            string destination = string.Empty;
            bool isValid = true;
            string pattern = @"^[rR][1-5][sS][1-5][cC][1-5]$";
            int priority = (int)numPriority.Value;

            if (radioButton1.Checked)
            {
               
                destination = InboundDestinationtxtbox.Text;

                if (!Regex.IsMatch(destination, pattern))
                {
                    isValid = false;
                    MessageBox.Show("Invalid input. Please enter a valid DESTINATION in the format R1S1C1 to R5S5C5.");
                }

                if (isValid)
                {
                    MessageBox.Show("Valid INBOUND input SUCCESSFULLY STORED!");
                }

            }
            else if (radioButton2.Checked)
            {
                source = Outboundsourcetxtbox.Text;
              

                if (!Regex.IsMatch(source, pattern))
                {
                    isValid = false;
                    MessageBox.Show("Invalid input. Please enter a valid SOURCE in the format R1S1C1 to R5S5C5.");
                }

                if (isValid)
                {
                    MessageBox.Show("Valid OUTBOUND input SUCCESSFULLY STORED!");
                }

            }
        }
    }
}
