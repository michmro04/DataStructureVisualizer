using DataStructureVisualizer.Services;


namespace DataStructureVisualizer.Structures
{
    public class MyStack : IVisualizableStructure
    {
        private class Node
        {
            public int Value { get; set;  }
            public Node Below { get; set; }

            public Node(int value)
            {
                Value = value;
                Below = null;
            }
        }


        private Node _top;
        public MyStack()
        {
            _top = null;    //empty stack
        }


        public void AddElement(int element)
        {
            Node newNode = new Node(element);
            newNode.Below = _top;               
            _top = newNode;

        }

        public int RemoveElement()
        {
            if(_top != null)
            {
                int elementValue = _top.Value;
                _top = _top.Below;

                return elementValue;
            }
            else
            {
                throw new Exception("Stack is empty!");
            }
        }

        public IEnumerable<int> GetElements()
        {
            Node current = _top;
            while(current != null)
            {
                yield return current.Value;
                current = current.Below;
            }
        }

        public void Clear()
        {
            if (_top != null)
            {
                _top = null;
            }
        }
    }
}
