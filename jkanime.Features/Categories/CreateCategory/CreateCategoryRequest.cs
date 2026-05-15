namespace jkanime.Features.Categories.CreateCategory;

public record CreateCategoryRequest(string Name, string Description, Guid? UserId = null);