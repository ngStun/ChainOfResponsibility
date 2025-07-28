namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Base class for handlers in the chain of responsibility.
    /// </summary>
    /// <typeparam name="T">The type of request to handle.</typeparam>
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        /// <summary>
        /// Gets or sets the next handler in the chain.
        /// </summary>
        protected IHandler<T> Next { get; set; }

        /// <inheritdoc />
        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }

        /// <inheritdoc />
        public virtual async Task<object> HandleAsync(T request)
        {
            if (Next != null)
                return await Next.HandleAsync(request).ConfigureAwait(false);

            return null;
        }
    }
}