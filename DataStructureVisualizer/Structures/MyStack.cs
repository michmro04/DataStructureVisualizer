using DataStructureVisualizer.Services;


namespace DataStructureVisualizer.Structures
{
    public class MyStack : IVisualizableStructure
    {
        private class Node
        {
            public int Value { get; set;  }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }


        private Node _top;
        public MyStack()
        {
            _top = null;
        }


        public void AddElement(int element)
        {
            throw new NotImplementedException();
        }

        public int RemoveElement()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetElements()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

    }
}
