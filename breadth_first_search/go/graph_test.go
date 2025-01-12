package graphs

import "testing"

func BenchmarkBfs(b *testing.B) {
	for i := 0; i < b.N; i++ {
		node1 := Node{1, make([]Vertex, 2)}
		node2 := Node{2, make([]Vertex, 4)}
		node3 := Node{3, make([]Vertex, 2)}
		node4 := Node{4, make([]Vertex, 3)}
		node5 := Node{5, make([]Vertex, 3)}

		node1.Vertices = append(node1.Vertices, Vertex{node2}, Vertex{node3})
		node2.Vertices = append(node2.Vertices, Vertex{node1}, Vertex{node5}, Vertex{node3}, Vertex{node4})
		node3.Vertices = append(node3.Vertices, Vertex{node2}, Vertex{node4})
		node4.Vertices = append(node4.Vertices, Vertex{node2}, Vertex{node5}, Vertex{node3})
		node5.Vertices = append(node5.Vertices, Vertex{node4}, Vertex{node1}, Vertex{node2})

		graph := Graph{make([]Node, 5)}
		graph.Nodes = append(graph.Nodes, node1, node2, node3, node4, node5)

		graph.Bfs(3)
	}
}
