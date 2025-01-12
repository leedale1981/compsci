package graphs

type Vertex struct {
	Connection Node
}

type Node struct {
	Value    int
	Vertices []Vertex
}

type Graph struct {
	Nodes []Node
}

func (g *Graph) Bfs(value int) Node {
	for _, node := range g.Nodes {
		if node.Value == value {
			return node
		}

		for _, vertex := range node.Vertices {
			if vertex.Connection.Value == value {
				return vertex.Connection
			}
		}
	}

	return Node{0, nil}
}
