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
    public partial class FormQueryInstruction : Form
    {
        public FormQueryInstruction()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Instruction instr = await BusinessLogic.InstructionGet(textBox1.Text);
            if (instr == null)
            {
                MessageBox.Show("404 not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("200: Success!");
                textBox2.Text = $"ID: {instr.getId()}{Environment.NewLine}System ID: {instr.getSystemId()}{Environment.NewLine}Source: {instr.getSource()}{Environment.NewLine}Destination: {instr.getDestination()}{Environment.NewLine}Type: {instr.getType()}{Environment.NewLine}Prority: {instr.getPriority()}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void INFO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
