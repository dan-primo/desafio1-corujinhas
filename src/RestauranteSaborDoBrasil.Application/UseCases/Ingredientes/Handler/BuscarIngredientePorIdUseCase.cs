﻿using AutoMapper;
using RestauranteSaborDoBrasil.Application.UseCases.Base;
using RestauranteSaborDoBrasil.Application.UseCases.Ingredientes.Request;
using RestauranteSaborDoBrasil.Application.UseCases.Ingredientes.Response;
using RestauranteSaborDoBrasil.Domain.Core.Interfaces;
using RestauranteSaborDoBrasil.Domain.Core.Notifications;
using RestauranteSaborDoBrasil.Domain.Interfaces.Repositories;
using RestauranteSaborDoBrasil.Domain.Interfaces.Repositories.Base;
using RestauranteSaborDoBrasil.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace RestauranteSaborDoBrasil.Application.UseCases.Ingredientes.Handler
{
    public class BuscarIngredientePorIdUseCase : UseCaseValidationBase<BuscarIngredienteRequest, Ingrediente, IngredienteResponse>
    {
        public BuscarIngredientePorIdUseCase(
            IHandler<DomainNotification> notifications,
            IUnitOfWork unitOfWork,
            IBaseRepository<Ingrediente> baseRepository,
            IMapper mapper) : base(notifications, unitOfWork, baseRepository, mapper)
        {
        }

        public override async Task<IngredienteResponse> Handle(BuscarIngredienteRequest request, CancellationToken cancellationToken)
            => await base.BuscarPorId(request.Id);
    }
}
