using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_MOD_3_1302223110_Adib_Faizulhaq_Armadhani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
        }

        private void Submit1_Click(object sender, EventArgs e)
        {
            Output.Text = "Halo " + Input.Text;

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {


        }


        private void Output_Click(object sender, EventArgs e)
        {

        }
    }
}
