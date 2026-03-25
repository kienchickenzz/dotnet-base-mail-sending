namespace BaseMailSending.Application.Common.Messaging;

using MediatR;

using BaseMailSending.Domain.Common;


public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
