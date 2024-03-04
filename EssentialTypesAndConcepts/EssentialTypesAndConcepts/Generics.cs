namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// This generic class is a simple implementation for Dictionary with key and value .
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class Generics<TKey, TValue> 
        where TKey : class, IEquatable<TKey> 
        where TValue : class, IEquatable<TValue>
    {
        private Dictionary<TKey, TValue> _items;

        public Generics()
        {
            _items = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (_items.ContainsKey(key))
            {
                throw new ArgumentException("An item with the same key has already been added.");
            }
            _items.Add(key, value);
        }

        public TValue Get(TKey key)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (_items.TryGetValue(key, out TValue value))
            {
                return value;
            }
            throw new KeyNotFoundException("The key was not found.");
        }

        public bool ContainsKey(TKey key)
        {
            return _items.ContainsKey(key);
        }
    }
}
