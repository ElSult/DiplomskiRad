using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_skolaUI
{
    public partial class PotvdaIzlaskaForm : Form
    {
        public PotvdaIzlaskaForm()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void PotvdaIzlaskaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
