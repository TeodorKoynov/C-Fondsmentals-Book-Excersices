using System;
using System.Collections.Generic;

namespace Chapter17Excercises
{
    public class Tree<T>
        where T : IComparable<T>
    {
        private NodeTree<T> root;
        public class NodeTree<T>
            where T: IComparable<T>
        {
            private T value = default;

            private List<NodeTree<T>> childern = new List<NodeTree<T>>();

            private bool hasParent = false;

            public NodeTree(T value)
            {
                this.value = value;
            }

            public T Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }

            public int ChildCount
            { 
                get
                {
                    return this.childern.Count;
                }
            }

            public void AddChild(NodeTree<T> child)
            {
                if (child == null)
                {
                    throw new ArgumentException("Cannot insert Null");
                }
                if (child.hasParent == true)
                {
                    throw new ArgumentException("The Child has a parent!");
                }
                child.hasParent = true;
                this.childern.Add(child);
            }

            public NodeTree<T> GetChild(int index)
            {
                return this.childern[index];
            }
        }

        public Tree(T value)
        {
            this.root = new NodeTree<T>(value);
        }

        public Tree(T value, params Tree<T>[] childern)
        {
            foreach (Tree<T> child in childern)
            {
                root.AddChild(child.root);
            }
        }

        public NodeTree<T> Root
        { 
            get
            {
                return this.root;
            }
        }



        public int GetNumberCount(T number)
        {
            dFS(this.root, number);
            retunr 

        }
    }
}
