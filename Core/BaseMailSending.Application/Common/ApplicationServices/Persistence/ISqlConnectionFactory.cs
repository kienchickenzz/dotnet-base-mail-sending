namespace BaseMailSending.Application.Common.ApplicationServices.Persistence;

using System.Data;


public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
