using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.leftNode;
                }
                else if (value > after.Data)
                {
                    after = after.rightNode;
                }
                else
                {
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.leftNode = newNode;
                }
                else
                {
                    before.rightNode = newNode;
                }
               
            }
            Console.WriteLine("{0} is added in List", newNode.Data);

            return true;
        }
        public void TraversePreorder(Node parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.Data + " ");
                TraversePreorder(parent.leftNode);
                TraversePreorder(parent.rightNode);
            }
        }
    }
}
