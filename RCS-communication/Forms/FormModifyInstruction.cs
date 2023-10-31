using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
