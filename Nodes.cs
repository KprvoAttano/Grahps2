using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Графы1
{
    public class Node
    {
        public class Edge
        {
            public Color Color { get; set; }
            public int Length { get; set; }
            public int Value { get; set; }
            public int Num { get; set; }
            public bool DrawExist { get; set; }
            public Edge(Color Color, int Length, int Value, int Num)
            {
                this.Color = Color;
                this.Length = Length;
                this.Value = Value;
                this.Num = Num;
                DrawExist = false;
            }
        }

        public List<Edge> Edges;
        public int Value { get; set; }
        public bool Visited = false;
        public int TurnRate = -1;
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Name { get; set; }
        public int radius = 15;
        public int Distance;
        public int[] Distances;
        public int _dist = 0;

        public Node(int X, int Y, int Value)
        {
            Color = Color.LightGray;
            this.X = X;
            this.Y = Y;
            this.Value = Value;
            Edges = new List<Edge>();
        }
    }

    public class Graph
    {
        public List<Node> Nodes;
        public int[,] Matrix { get; set; }
        public int NumFromEdge;
        public bool DrawingEdge = false;
        public int Low = -1;
        public bool Turn = true;
        public int NumberGearsToTurn;

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public void AddNode(Node node)
        {
            bool TF;
            node.Value = Nodes.Count + 1;
            node.Name = 0;
            for (int i = 0; i < Nodes.Count; i++)
            {
                TF = false;
                for (int j = 0; j < Nodes.Count; j++)
                {
                    if (Nodes[j].Name == i + 1)
                    {
                        TF = true;
                    }
                }
                if (!TF) node.Name = i + 1;
            }
            if (node.Name == 0) node.Name = node.Value;
            Nodes.Add(node);
        }

        private bool ExistEdge(int n1, int n2)
        {
            int len = Nodes[n1].Edges.Count;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < Nodes[n2].Edges.Count; j++)
                if ((Nodes[n2].Edges[j].Num == n1) && (Nodes[n1].Edges[i].Num == n2))
                return true; 
            }
            return false;
        }

        public void AddEdge(int n1, int n2, int value)
        {
            if (!ExistEdge(n1, n2))
            {
                int dx = Nodes[n2].X - Nodes[n1].X;
                int dy = Nodes[n2].Y - Nodes[n1].Y;
                double x = dx * dx + dy * dy;
                x = Math.Pow(x, 0.5);
                int dist = Convert.ToInt32(x);
                if (value == -1) value = dist;
                Nodes[n1].Edges.Add(new Node.Edge(Color.Black, dist, value, n2));
                Nodes[n2].Edges.Add(new Node.Edge(Color.Black, dist, value, n1));
            }
        }

        private void ChandgeNumber(int n)
        {
            for (int i = n + 1; i < Nodes.Count; i++)
            {
                Nodes[i].Value--;
                for (int j = 0; j < Nodes[i].Edges.Count; j++)
                {
                    Nodes[i].Edges[j].Num--;
                }
            }
        }

        private void ClearVisit()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].Visited = false;
            }
        }

        public int CheckNode(int X, int Y)
        {
            int result = -1;
            for (int i = 0; i < Nodes.Count; i++)
            {
                int nx = Nodes[i].X;
                int ny = Nodes[i].Y;
                if ((nx - X) * (nx - X) + (ny - Y) * (ny - Y) < (3 * Nodes[i].radius) * (3 * Nodes[i].radius))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private void Short(Node node)
        {
            for (int i = 0; i < Nodes.Count; i++)
                Nodes[i].Distance = int.MaxValue;

            node.Distance = 0;
        }
        public int FindLowestDist()
        {
            int dist, _dist = int.MaxValue;
            for (int i = 0; i < Nodes.Count; i++)
            {
                Array.Resize(ref Nodes[i].Distances, Nodes.Count);
                dist = 0;
                Short(Nodes[i]);
                Dijkstra(Nodes[i]);
                for (int j = 0; j < Nodes.Count; j++)
                {
                    dist += Nodes[j].Distance;
                    Nodes[i].Distances[j] = Nodes[j].Distance;
                }
                Nodes[i]._dist = dist;
                if (dist < _dist)
                {
                    _dist = dist;
                    Low = i;
                }
            }
            Nodes[Low].Color = Color.Blue;
            return _dist;
        }

        private void Dijkstra(Node node)
        {
            if (node.Edges == null)
                return;
            else
            {
                for (int i = 0; i < node.Edges.Count; i++)
                {
                    if (Nodes[node.Edges[i].Num].Distance > node.Distance + node.Edges[i].Value)
                    {
                        Nodes[node.Edges[i].Num].Distance = node.Distance + node.Edges[i].Value;
                        Dijkstra(Nodes[node.Edges[i].Num]);
                    }
                }
            }
        }

        public int CheckName(int n)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].Name == n) return Nodes[i].Value;
            }
            return -1;
        }

        public void DeleteNode(int n)
        {
            int L = Nodes[n].Edges.Count;
            for (int i = 1; i < L + 1; i++)
            {
                DeleteEdge(n, Nodes[n].Edges[0].Num);
            }
            ChandgeNumber(n);
            Nodes.Remove(Nodes[n]);
        }

        public void DeleteEdge(int n1, int n2)
        {
            if (ExistEdge(n1, n2))
            {
                int L = Nodes[n1].Edges.Count;
                int L1 = Nodes[n2].Edges.Count;

                for (int i = 0; i < L; i++)
                {
                    if (Nodes[n1].Edges[i].Num == n2)
                    {
                        Nodes[n1].Edges.RemoveAt(i);
                        break;
                    }
                }
                for (int i = 0; i < L1; i++)
                {
                    if (Nodes[n2].Edges[i].Num == n1)
                    {
                        Nodes[n2].Edges.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void Clear()
        {
            Nodes = new List<Node>();
            Low = -1;
            ClearVisit();
        }        

        private int[,] CreateMatrix()
        {
            int n = Nodes.Count;
            Matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Matrix[i, i] = 0;
                int eL = 0;
                if (Nodes[i].Edges != null)
                {
                    eL = Nodes[i].Edges.Count;
                    for (int j = 0; j < eL; j++)
                    {
                        Matrix[i, Nodes[i].Edges[j].Num] = Nodes[i].Edges[j].Value;
                    }
                }
            }
            return Matrix;
        }

        private int CreateEdge(int[,] a)
        {
            int n = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int dx = Nodes[j].X - Nodes[i].X;
                    int dy = Nodes[j].Y - Nodes[i].Y;
                    double x = dx * dx + dy * dy;
                    x = Math.Pow(x, 0.5);
                    int dist = Convert.ToInt32(x);
                    if (a[i, j] != 0)
                    {
                        Node.Edge edge = new Node.Edge(Color.Black, dist, a[i, j], Nodes[j].Value - 1);
                        Nodes[i].Edges.Add(edge);
                    }
                }
            }
            return n;
        }

        public void SaveGraph(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Nodes.Count);
            for (int i = 0; i < Nodes.Count; i++)
            {
                sw.WriteLine(Nodes[i].Value + " " + Nodes[i].Name);
                sw.WriteLine(Nodes[i].X + " " + Nodes[i].Y);
            }
            int[,] a = CreateMatrix();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sw.Write(a[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
            fs.Close();
        }

        public void ReadGraph(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);
            StreamReader sw = new StreamReader(fs);
            Nodes = new List<Node>();
            int a = int.Parse(sw.ReadLine());
            string names;
            int x, y;
            int name, value;
            for (int i = 0; i < a; i++)
            {
                names = sw.ReadLine();
                string[] val = names.Split();
                value = int.Parse(val[0]);
                if (val.Length > 1)
                    name = int.Parse(val[1]);
                else name = value;
                string s = sw.ReadLine();
                string[] q = s.Split();
                x = int.Parse(q[0]);
                y = int.Parse(q[1]);
                Node node = new Node(x, y, value);
                node.Name = name;
                Nodes.Add(node);
            }
            int[,] c = new int[a, a];

            for (int i = 0; i < a; i++)
            {
                string t = sw.ReadLine();
                string[] p = t.Split();
                for (int j = 0; j < a; j++)
                {
                    c[i, j] = int.Parse(p[j]);
                }
            }
            CreateEdge(c);
            sw.Close();
            fs.Close();
        }

        private bool CheckAllTrue()
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].TurnRate == -1) return false;
            }
            return true;
        }

        public void CheckGears(int n, int way)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                Nodes[i].TurnRate = -1;
            }
            Turn = true;
            Nodes[n].TurnRate = way;
            ClearVisit();
            NumberGearsToTurn = 1;
            CheckGear(n);
        }

        private void CheckGear(int n)
        {
            Nodes[n].Visited = true;
            for (int i = 0; i < Nodes[n].Edges.Count; i++)
            {
                int m = Nodes[n].Edges[i].Num;
                if (Nodes[m].Visited) continue;
                for (int j = 0; j < Nodes[n].Edges.Count; j++)
                {
                    int t = Nodes[n].Edges[j].Num;
                    if (Nodes[t].TurnRate == -1)
                    {
                        if (Nodes[n].TurnRate == 0)
                            Nodes[t].TurnRate = 1;
                        else Nodes[t].TurnRate = 0;
                        NumberGearsToTurn++;
                    }
                    else
                    if (Nodes[t].TurnRate == Nodes[n].TurnRate || !Turn)
                    {
                        Turn = false;
                        return;
                    }
                }
                if (CheckAllTrue()) return;
                CheckGear(m);
            }            
        }
    }
}