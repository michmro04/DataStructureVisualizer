namespace DataStructureVisualizer.Services
{
    public interface IVisualizableStructure
    {
        // Generic name to unify Push (Stack), Enqueue (Queue), and Insert (List)
        void AddElement(int element);

        // Generic name to unify Pop (Stack), Dequeue (Queue), and Delete (List)
        int RemoveElement();

        // Provides the current sequence of elements for the UI to draw
        IEnumerable<int> GetElements();

        // Clears all elements from the structure
        void Clear();
    }
}
