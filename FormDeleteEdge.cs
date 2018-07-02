using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графы1
{
    public partial class FormDeleteEdge : Form
    {
        public FormDeleteEdge()
        {
            InitializeComponent();
        }
        public string Text1
        {
            get { return tbNode1.Text; }
        }
        public string Text2
        {
            get { return tbNode2.Text; }
        }
    }
}
