using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace agraph
{
    public class Graph
    {
        public static (List<Tuple<string, Point>>, List<Tuple<int, int>>) GetRandomEdges(int nodeSize, int totalNodes, int edgeConnections, int maxX, int maxY)
        {
            List<Tuple<string, Point>> nodes = new List<Tuple<string, Point>>();
            List<Tuple<int, int>> edges = new List<Tuple<int, int>>();

            
            Random random = new Random();

            for (int i = 0; i < totalNodes; i++)
            {
                int x = random.Next(nodeSize, maxX - nodeSize);
                int y = random.Next(nodeSize, maxY - nodeSize);
                string curPoint = $"Node{i}";
                nodes.Add(new Tuple<string, Point>(curPoint, new Point(x, y)));
            }

            
            for (int i = 0; i < totalNodes - 1; i++)
            {
                for (int j = i + 1; j < totalNodes; j++)
                {
                    edges.Add(new Tuple<int, int>(i, j));
                }
            }

            return (nodes, edges);
        }
    }
}