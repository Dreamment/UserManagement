﻿namespace Entities.Exceptions.NotFound
{
    public abstract class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
