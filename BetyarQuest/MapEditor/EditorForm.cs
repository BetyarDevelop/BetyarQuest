using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

        }

        // Menü eseményvezérlők
        private void MenuFileExit_Click(object sender, EventArgs e) { Close(); }

        private void MenuFileNew_Click(object sender, EventArgs e)
        {
        }

        private void MenuFileLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

    }
}
