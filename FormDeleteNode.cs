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
    public partial class FormDeleteNode : Form
    {
        public FormDeleteNode()
        {
            InitializeComponent();
        }

        public string TakeText
        {
            get { return tbNumberNode.Text; }
        }
    }
}
