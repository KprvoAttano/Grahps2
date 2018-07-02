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
    public partial class FormTakeNumberGear : Form
    {
        public FormTakeNumberGear()
        {
            InitializeComponent();
        }

        public string TakeText
        {
            get { return tbNumberNode.Text; }
        }

        public int TakeTurn
        {
            get
            {
                switch (cBoxTurn.Text)
                {
                    case "Влево": return 0;
                    case "Вправо": return 1;
                    default: return -1;
                }
            }
        }
    }
}
