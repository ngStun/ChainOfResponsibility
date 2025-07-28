namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Defines the contract for a handler in the chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="T">The type of request to handle.</typeparam>
    public interface IHandler<T> where T : class
    {
        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="next">The next handler.</param>
        /// <returns>The next handler for chaining.</returns>
        IHandler<T> SetNext(IHandler<T> next);

        /// <summary>
        /// Handles the request asynchronously.
        /// </summary>
        /// <param name="request">The request to handle.</param>
        /// <returns>A task representing the result of the handling operation.</returns>
        Task<object> HandleAsync(T request);
    }
}