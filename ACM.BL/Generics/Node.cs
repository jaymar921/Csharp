
namespace ACM.BL.Generics
{
    public class Node<T>
    {

        public Node<T> Next { get; set; }
        public T Item { get; set; }
        public bool HasNext()
        {
            return Next != null;
        }
    }
}
