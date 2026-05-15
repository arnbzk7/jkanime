namespace jkanime.Features.Categories.CreateCategory;

public record CreateCategoryResponse(Guid Id, string Name, string Description, bool isActive, Guid? UserId = null);