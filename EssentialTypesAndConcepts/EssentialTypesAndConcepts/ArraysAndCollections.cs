using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.Specialized;

namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// Arrays :
    ///    - Arrays are fiexed size
    ///    - Zero-indexed
    ///    - Multidimensional
    ///    
    /// Collections :
    ///    - Generic collections (Lists, Stacks, Dictionaries, Queues, Linked List, HashSet ...)
    ///    
    ///    - Specialized collections (BitVector32<T> => bool values and small integers, 
    ///         ListDictionary, OrderedDictionary, StringCollection, StringEnumerator ...)
    ///         
    ///    - Concurrent collections (BlockingCollection<T>, ConcurrentBag<T>, ConcurrentStack<T>, 
    ///         Partitioner<TSource>, OrderablePartitioner<TSource>, IProducerConsumerCollection<T> ...)
    ///         
    ///    - Immutable collections (ImmutableDictionary<TKey, TValue>, ImmutableList<T>, ImmutableSet<T> ...)
    /// </summary>
    public class ArraysAndCollections
    {
        // Arrays
        public int[] arrayU { get; set; }
        public int[,] arrayB { get; set; }

        // Generic Collections
        public List<int> list { get; set; }
        public Stack<int> stack { get; set; }
        public Queue<int> queue { get; set; }
        public Dictionary<int, int> dictionary { get; set; }
        public LinkedList<int> linkedList { get; set; }

        // Specialized Collections
        public BitVector32 vector { get; set; }
        public ListDictionary listDictionary { get; set; }
        public OrderedDictionary orderedDictionary { get; set; }
        public StringCollection strings { get; set; }
        public StringEnumerator stringEnumerator { get; set; }

        // Concurrent Collections
        public BlockingCollection<int> blockingCollection { get; set; }
        public ConcurrentBag<int> concurrentBag { get; set; }
        public ConcurrentStack<int> concurrentStack { get; set; }
        public Partitioner<int> partitioner { get; set; }
        public OrderablePartitioner<int> orderablePartitioner { get; set; }
        public IProducerConsumerCollection<int> producerConsumerCollection { get; set; }

        // Immutable Collections
        public ImmutableDictionary<string, string> keyValuePairs { get; set; }
        public ImmutableList<int> immutableList { get; set; }
        public ImmutableArray<int> immutableArray { get; set; }
        public ImmutableHashSet<int> ImmutableHashSet { get; set; }
        public IImmutableSet<int> immutableSet { get;}

    }
}
