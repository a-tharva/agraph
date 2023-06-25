namespace agraph
{
    public partial class Form1 : Form
    {
        private const int NodeSize = 10; // Size of each graph node
        private const int EdgeThickness = 2; // Thickness of graph edges

        private List<Point> nodes;
        private List<Tuple<int, int>> edges;

        public Form1()
        {
            InitializeComponent();
            nodes = new List<Point>();
            edges = new List<Tuple<int, int>>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Draw edges
            using (Pen edgePen = new Pen(Color.Black, EdgeThickness))
            {
                foreach (var edge in edges)
                {
                    Point source = nodes[edge.Item1];
                    Point target = nodes[edge.Item2];
                    g.DrawLine(edgePen, source, target);
                }
            }

            // Draw nodes
            foreach (var node in nodes)
            {
                int x = node.X - NodeSize / 2;
                int y = node.Y - NodeSize / 2;
                Rectangle nodeRect = new Rectangle(x, y, NodeSize, NodeSize);
                g.FillEllipse(Brushes.Red, nodeRect);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the previous graph
            nodes.Clear();
            edges.Clear();
            Invalidate();

            // Generate random nodes
            Random random = new Random();
            int numNodes = random.Next(5, 10); // Randomly choose the number of nodes
            for (int i = 0; i < numNodes; i++)
            {
                int x = random.Next(NodeSize, ClientSize.Width - NodeSize);
                int y = random.Next(NodeSize, ClientSize.Height - NodeSize);
                nodes.Add(new Point(x, y));
            }

            // Generate random edges
            int numEdges = random.Next(numNodes - 1, numNodes * (numNodes - 1) / 2); // Randomly choose the number of edges
            for (int i = 0; i < numEdges; i++)
            {
                int source = random.Next(numNodes);
                int target = random.Next(numNodes);
                edges.Add(new Tuple<int, int>(source, target));
            }

            Invalidate();
        }
    }
}