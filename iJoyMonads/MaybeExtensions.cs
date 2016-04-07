using System;

namespace NetMonads
{
    public static class MaybeExtensions
    {
        public static TResult Get<TInput, TResult>(this TInput obj, Func<TInput, TResult> checker) 
            where TInput: class 
            where TResult: class => obj == null ? null : checker(obj);
    }
}