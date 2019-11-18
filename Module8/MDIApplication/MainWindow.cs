using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // code for small control button on form
        private void btnClickThis_Click(object sender, EventArgs e)
        {  
            // message for basic button control
            lblHelloWorld.Text = "Mike's Button Works!";
        }

        // dialog box code added for big button on form
        private void button1_Click(object sender, EventArgs e)
        {
            // show message box with the message box title, message displayed
            // and the desired buttons (in this case ok or cancel)
            MessageBox.Show("Yay! Mike's message button works!", 
                "Mike's Message Window", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);
        }
    }
}
