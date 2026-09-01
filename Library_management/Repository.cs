using System.ComponentModel;

namespace Library_management;

public class Repository<T>
{
    private List<T> _items = new();
    public void Add(T item) => _items.Add(item);
    public void Remove(T item) => _items.Remove(item);

    public T? Find(Func<T, bool> predicate) => _items.FirstOrDefault(predicate);
    public IEnumerable<T> GetAll() => _items;
}