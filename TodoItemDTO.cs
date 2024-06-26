public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() {}
    public TodoItemDTO(Todo todoItem) => 
    (Id, Name, IsComeplete) = (todoItem.Id, todoItem.Name, todoItem.IsComeplete);
}