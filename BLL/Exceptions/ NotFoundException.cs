using System;

namespace back_usuarios_tg.BLL.Exceptions
{
    public class  NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }

}