namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
             tree.TraversePreorder(tree.Root);

        }
    }
}