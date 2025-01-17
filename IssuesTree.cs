using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10229540_PROG7312_POE
{
    public class IssuesTreeNode<T>
    {
        public T Value { get; set; }
        public IssuesTreeNode<T> Left { get; set; }
        public IssuesTreeNode<T> Right { get; set; }

        public IssuesTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }
}
