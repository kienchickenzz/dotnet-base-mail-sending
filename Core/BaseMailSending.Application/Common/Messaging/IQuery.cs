namespace BaseMailSending.Application.Common.Messaging;

using MediatR;

using BaseMailSending.Domain.Common;


public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
