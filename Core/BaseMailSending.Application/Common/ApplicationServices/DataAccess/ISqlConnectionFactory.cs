namespace BaseMailSending.Application.Common.ApplicationServices.DataAccess;

using System.Data;


public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
