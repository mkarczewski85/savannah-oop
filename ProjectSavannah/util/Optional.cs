using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavannah.util
{
    public struct Optional<T>
    {
        public bool HasValue { get; private set; }
        private readonly T value;
        public T Value
        {
            get
            {
                if (HasValue)
                    return value;
                else
                    throw new InvalidOperationException();
            }
        }

        public static Optional<T> Of(T value)
        { 
            return new Optional<T>(value);
        }

        public static Optional<T> Empty()
        { 
            return new Optional<T> { HasValue = false };
        }

        private Optional(T value)
        {
            this.value = value;
            HasValue = true;
        }

    }
}
