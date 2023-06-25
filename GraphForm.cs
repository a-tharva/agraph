namespace agraph
{
    public partial class GraphForm : Form
    {
        private const int NodeSize = 10;
        private const int EdgeThickness = 0;

        private List<Tuple<string, Point>> nodes;
        private List<Tuple<int, int>> edges;

        public GraphForm()
        {
            InitializeComponent();
            nodes = new List<Tuple<string, Point>>();
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
                    Point source = nodes[edge.Item1].Item2;
                    Point target = nodes[edge.Item2].Item2;
                    g.DrawLine(edgePen, source, target);
                }
            }

            // Draw nodes
            foreach (var node in nodes)
            {
                int x = node.Item2.X - NodeSize / 2;
                int y = node.Item2.Y - NodeSize / 2;
                string name = node.Item1;
                Rectangle nodeRect = new Rectangle(x, y, NodeSize, NodeSize);
                g.FillEllipse(Brushes.Red, nodeRect);
                g.DrawString(name, Font, Brushes.Black, node.Item2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the previous graph
            nodes.Clear();
            edges.Clear();
            Invalidate();

            (nodes, edges) = Graph.GetRandomEdges(NodeSize, Int32.Parse(NodesInput.Text), Int32.Parse(ConnectionInput.Text), ClientSize.Width, ClientSize.Height);

            Invalidate();
        }
    }
}