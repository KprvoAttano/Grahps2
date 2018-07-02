using System;
using System.Drawing;
using System.Windows.Forms;

namespace Графы1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Graph graph = new Graph();

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (rBtnNode.Checked)
            {
                Node node = new Node(e.X, e.Y, 0);
                graph.AddNode(node);
                Graphics gr = CreateGraphics();
                GraphToForm.DrawGraph(gr, graph);
                gr.Dispose();
            }
            else
            if (rBtnEdge.Checked)
            {
                int n = graph.CheckNode(e.X, e.Y);
                if (n != -1)
                {
                    graph.DrawingEdge = true;
                    graph.NumFromEdge = n;
                }
            }
            else 
            if (rBtnDistInfo.Checked)
            {
                Graphics gr = CreateGraphics();
                gr.Clear(DefaultBackColor);
                GraphToForm.DrawGraph(gr, graph);
                int n = graph.CheckNode(e.X, e.Y);
                if (n != -1)
                {                    
                    GraphToForm.WriteDist(gr, graph, graph.Nodes[n]);
                }
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (graph.DrawingEdge)
            {
                Graphics gr = CreateGraphics();
                Pen pen = new Pen(Color.Black, 1);

                gr.DrawEllipse(pen, e.X, e.Y, 2, 2);
                gr.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 5, 5);
                gr.Dispose();
                pen.Dispose();
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (graph.DrawingEdge)
            {
                graph.DrawingEdge = false;
                FormTakeEdgeValue ftev = new FormTakeEdgeValue();
                int _value = -1;
                if (ftev.ShowDialog() == DialogResult.OK)
                {
                    _value = Convert.ToInt32(ftev.TakeText);
                }
                Graphics gr = CreateGraphics();
                int n = graph.CheckNode(e.X, e.Y);
                if (n != -1)
                {
                    n = graph.CheckName(n);
                    graph.AddEdge(graph.NumFromEdge, n, _value);
                }
                gr.Clear(DefaultBackColor);
                GraphToForm.DrawGraph(gr, graph);
                gr.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            graph.Clear();
            gr.Clear(DefaultBackColor);
            gr.Dispose();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            graph.FindLowestDist();
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);
            GraphToForm.DrawGraph(gr, graph);
        }

        private void btnSaveGraph_Click(object sender, EventArgs e)
        {
            sFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                string safname = sFD.FileName;
                graph.SaveGraph(safname);
            }
        }

        private void btnOpenGraph_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            oFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                gr.Clear(DefaultBackColor);
                string openname = oFD.FileName;
                graph.ReadGraph(openname);
                GraphToForm.DrawGraph(gr, graph);
            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            FormDeleteNode fdn = new FormDeleteNode();
            int n = -1;
            if (fdn.ShowDialog() == DialogResult.OK)
            {
                n = Convert.ToInt32(fdn.TakeText);
            }
            if (n != -1)
            {
                n = graph.CheckName(n) - 1;
                graph.DeleteNode(n);
            }
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);
            GraphToForm.DrawGraph(gr, graph);
        }

        private void btnDeleteEdge_Click(object sender, EventArgs e)
        {
            FormDeleteEdge fde = new FormDeleteEdge();
            int n = -1, n1 = -1;
            if (fde.ShowDialog() == DialogResult.OK)
            {
                n = Convert.ToInt32(fde.Text1);
                n1 = Convert.ToInt32(fde.Text2);
            }
            if (n != -1 && n1 != -1)
            {
                n = graph.CheckName(n) - 1;
                n1 = graph.CheckName(n1) - 1;
                graph.DeleteEdge(n, n1);
            }
            Graphics gr = CreateGraphics();
            gr.Clear(DefaultBackColor);
            GraphToForm.DrawGraph(gr, graph);
        }

        private void btnGearTurn_Click(object sender, EventArgs e)
        {
            tBResult.Text = "";
            Graphics gr = CreateGraphics();
            FormTakeNumberGear ftng = new FormTakeNumberGear();
            int n = -1, t = -1;
            if (ftng.ShowDialog() == DialogResult.OK)
            {
                n = Convert.ToInt32(ftng.TakeText);
                t = ftng.TakeTurn;
            }
            gr.Clear(DefaultBackColor);
            if (n != -1)
            {
                n = graph.CheckName(n) - 1;
                graph.CheckGears(n, t);
                if (graph.Turn)
                {
                    for (int i = 0; i < graph.Nodes.Count; i++)
                    {
                        GraphToForm.WriteTurn(gr, graph, graph.Nodes[i]);
                    }
                    tBResult.Text = graph.NumberGearsToTurn.ToString();
                }
                else
                    tBResult.Text = graph.Turn.ToString();
            }
            GraphToForm.DrawGraph(gr, graph);
        }
    }
}
