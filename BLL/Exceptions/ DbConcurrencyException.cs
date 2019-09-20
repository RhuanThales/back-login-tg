using System;

namespace back_usuarios_tg.BLL.Exceptions
{
    public class  DbConcurrencyException: ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }

}