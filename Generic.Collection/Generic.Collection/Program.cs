using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //======
            // STACK
            // =====
            // - LAST INPUT, FIRST OUTPUT!
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            foreach (int s in stack)
                Console.WriteLine(s);  // 3, 2, 1

            Console.WriteLine(stack.Peek()); // 3
            Console.WriteLine(stack.Peek()); // 3
            Console.WriteLine(stack.Peek()); // 3

            Console.WriteLine(stack.Pop()); // 3
            Console.WriteLine(stack.Pop()); // 2
            Console.WriteLine(stack.Pop()); // 1
                                            // Console.WriteLine(stack.Pop()); ERROR!

            //======
            // QUEUE
            // =====
            Console.WriteLine("== QUEUE ==");
            // - FIRST INPUT, FIRST OUTPUT!
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();  // REMOVE 1
            queue.Dequeue();  // REMOVE 2
            //queue.Dequeue();  // REMOVE 3
            //queue.Dequeue();  // ERROR!
            foreach (int q in queue)
                Console.WriteLine(q);  // 1, 2, 3

            // ==========
            // SORTED SET
            // ==========
            Console.WriteLine("== SORTED SET ==");
            SortedSet<int> sSet = new SortedSet<int>();
            sSet.Add(2);
            sSet.Add(1);
            sSet.Add(3);

            foreach (int s in sSet)
                Console.WriteLine(s);  // 1, 2, 3

            // ======================
            // OBSERVABLE COLLECTION
            // =====================
            Console.WriteLine("== OBSERVABLE COLLECTION ==");
            System.Collections.ObjectModel.ObservableCollection<int> oList = 
                new System.Collections.ObjectModel.ObservableCollection<int>();

            oList.CollectionChanged += OnCollectionChanged;

            oList.Add(1);
            oList.Add(2);
            oList.Add(3);

            foreach (int value in oList)
                Console.WriteLine(value);

            // ==========
            // DICTIONARY
            // ==========
            Console.WriteLine("== DICTIONARIES ==");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1", "Saab");
            dict.Add("2", "Audi");
            dict.Add("3", "Porsche");

            foreach(KeyValuePair<string,string> value in dict)
                Console.WriteLine(value.Key + "-" + value.Value);

            Console.ReadKey();
        }

        public static void OnCollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("new value added - Action: " + e.Action.ToString());
        }
    }
}
