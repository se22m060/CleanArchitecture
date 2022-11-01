using MediatR;
using Microsoft.EntityFrameworkCore;
using se22m060_swe_ca.Application.Common.Interfaces;
using se22m060_swe_ca.Application.TodoLists.Queries.GetTodos;

namespace se22m060_swe_ca.WebUI.Controllers;

public record GetFoodQuery : IRequest<FoodDto[]>;

internal class GetFoodQueryHandler : IRequestHandler<GetFoodQuery, FoodDto[]>
{
    private readonly IApplicationDbContext _context;

    public GetFoodQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<FoodDto[]> Handle(GetFoodQuery request, CancellationToken cancellationToken)
    {
        await _context.FoodItems.AddAsync(new Food("Gemüse Suppe", "Herbstliche Gemüsesuppe", 1.5m, DateTime.Today));
        await _context.FoodItems.AddAsync(new Food("Spinat-Schafkäse Lasagne", "goldbrau paniert", 3.5m, DateTime.Today));
        await _context.FoodItems.AddAsync(new Food("Cordon Blue", "Petersilkartoffel und Preiselbeersauce", 3.5m, DateTime.Today));
        await _context.SaveChangesAsync(cancellationToken);

        return await _context.FoodItems.Where(f => f.MenuDate == DateTime.Today).Select(f => new FoodDto(f)).ToArrayAsync(cancellationToken);
    }
}