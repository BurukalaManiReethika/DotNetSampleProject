using DotNetSampleProject.Models;
using DotNetSampleProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetSampleProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Item>> GetAll() => Ok(_itemService.GetAll());

    [HttpGet("{id}")]
    public ActionResult<Item> GetById(int id)
    {
        var item = _itemService.GetById(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public ActionResult<Item> Create(Item item)
    {
        var created = _itemService.Create(item);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Item item)
    {
        return _itemService.Update(id, item) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return _itemService.Delete(id) ? NoContent() : NotFound();
    }
}
