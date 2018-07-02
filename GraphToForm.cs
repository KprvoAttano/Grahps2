using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Графы1
{
    class GraphToForm
    {
        const int radius = 15;
        private static void DrawNode(Graphics graphics, Node node)
        {
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 12, FontStyle.Regular);
            SolidBrush sb = new SolidBrush(node.Color);
            SolidBrush sbstring = new SolidBrush(Color.Black);

            graphics.DrawEllipse(pen, node.X - radius, node.Y - radius, 3 * radius, 3 * radius);
            graphics.FillEllipse(sb, node.X - radius, node.Y - radius, 3 * radius, 3 * radius);
            graphics.DrawString(node.Name.ToString(), font, sbstring, node.X, node.Y);
        }

        public static void DrawGraph(Graphics graphics, Graph graph)
        {
            Font font = new Font("Arial", 10, FontStyle.Regular);
            int NumNodes = graph.Nodes.Count;
            for (int i = 0; i < NumNodes; i++)
            {
                int numE = graph.Nodes[i].Edges.Count;
                int curX = graph.Nodes[i].X;
                int curY = graph.Nodes[i].Y;

                for (int j = 0; j < numE; j++)
                {
                    int toX = graph.Nodes[graph.Nodes[i].Edges[j].Num].X;
                    int toY = graph.Nodes[graph.Nodes[i].Edges[j].Num].Y;
                    Color cl = graph.Nodes[i].Edges[j].Color;
                    Pen pen = new Pen(cl, 1);
                    graphics.DrawLine(pen, curX + 21, curY + 11, toX + 21, toY + 11);
                    int captionX = (curX + toX) / 2;
                    int captionY = (curY + toY) / 2;
                    Rectangle rec = new Rectangle(captionX, captionY, 50, 21);
                    graphics.DrawString(graph.Nodes[i].Edges[j].Value.ToString(), font, Brushes.Black, rec);
                }
            }

            for (int i = 0; i < NumNodes; i++)
                DrawNode(graphics, graph.Nodes[i]);
        }

        public static void WriteDist(Graphics gr, Graph graph, Node node)
        {
            Font font = new Font("Arial", 11, FontStyle.Italic);
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int i = 0; i < node.Distances.Length; i++)
            {
                if (i != node.Value - 1)
                gr.DrawString(node.Distances[i].ToString(), font, brush, graph.Nodes[i].X + 20, graph.Nodes[i].Y - 20);
                else gr.DrawString(node._dist.ToString(), font, brush, graph.Nodes[i].X + 20, graph.Nodes[i].Y - 20);
            }
        }

        public static void WriteTurn(Graphics gr, Graph graph, Node node)
        {
            Font font = new Font("Arial", 11, FontStyle.Italic);
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush, 2);
            int sX = node.X;
            int sY = node.Y - radius - 5;
            if (node.TurnRate == -1)
            {
                gr.DrawString("Don't move", font, brush, sX, sY);
                return;
            }
            
            int eY = sY;
            int eX = sX;
            if (node.TurnRate == 0) eX = sX - radius;
            else if (node.TurnRate == 1) eX = sX + radius;

            gr.DrawLine(pen, sX, sY, eX, eY);
            if (eX < sX)
            {
                gr.DrawLine(pen, eX, eY, eX + 5, eY - 5);
                gr.DrawLine(pen, eX, eY, eX + 5, eY + 5);
            }
            else
            {
                gr.DrawLine(pen, eX, eY, eX - 5, eY - 5);
                gr.DrawLine(pen, eX, eY, eX - 5, eY + 5);
            }
        }
    }
}
