using System;

namespace Repository.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException() 
            : base() { }

        public RepositoryException(string msg) 
            : base(msg) { }

        public RepositoryException(string msg, Exception innerException) 
            : base(msg,innerException)
        { }
    }
}
