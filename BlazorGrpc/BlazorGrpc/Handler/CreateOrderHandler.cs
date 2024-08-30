﻿using BlazorAppData.Interrface;
using BlazorAppData.UnitOfWork;

using BlazorGrpc.Model;
using BlazorGrpcSimpleMediater;
using Grpc.Core;
namespace BlazorGrpc.Handler;

public class CreateProductCommand : IRequest<CreateProductResponse>
{
    public string Name { get;  }
    public decimal Price { get;  }

    public CreateProductCommand(string name, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        Name = name;

        Price = price;
    }
}

public record CreateProductResponse(int Id, string Name, decimal Price);

public class CreateProductHandler : IHandler<CreateProductCommand, CreateProductResponse>
{
    private readonly IProductRepository _productRepository;

    private readonly IUnitOfWork<int> _unitOfWork;

    public CreateProductHandler(IProductRepository productRepository, IUnitOfWork<int> unitOfWork) 
    { 
        _productRepository = productRepository; 

        _unitOfWork = unitOfWork;
    
    }

    public async Task<CreateProductResponse> Handle(CreateProductCommand request)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = (decimal)request.Price
        };

        await _productRepository.CreateProdut(product);

        var isCreated = await _unitOfWork.Commit(CancellationToken.None) > 0;

        if (!isCreated)
            throw new RpcException(new Status(StatusCode.NotFound, "Product Could not be Created !!!!"));

        return new CreateProductResponse(product.Id, product.Name, product.Price);
    }
}
