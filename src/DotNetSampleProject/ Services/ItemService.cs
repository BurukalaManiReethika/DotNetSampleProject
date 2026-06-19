using DotNetSampleProject.Models;

namespace DotNetSampleProject.Services;

public class ItemService : IItemService
{
    private readonly List<Item> _items = new();
    private int _nextId = 1;

    public IEnumerable<Item> GetAll() => _items;

    public Item? GetById(int id) => _items.FirstOrDefault(i => i.Id == id);

    public Item Create(Item item)
    {
        item.Id = _nextId++;
        item.CreatedAt = DateTime.UtcNow;
        _items.Add(item);
        return item;
    }

    public bool Update(int id, Item item)
    {
        var existing = GetById(id);
        if (existing is null) return false;

        existing.Name = item.Name;
        existing.Description = item.Description;
        return true;
    }

    public bool Delete(int id)
    {
        var existing = GetById(id);
        if (existing is null) return false;

        _items.Remove(existing);
        return true;
    }
}
