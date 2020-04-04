﻿// ReSharper disable CheckNamespace

// Polyfills to bridge the missing APIs in older versions of the framework/standard.

#if NETSTANDARD2_0 || NET461
namespace System
{
    internal static class Extensions
    {
        public static string[] Split(this string input, params string[] separators) =>
            input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    }
}

namespace System.Collections.Generic
{
    internal static class Extensions
    {
        public static TValue GetValueOrDefault<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dic, TKey key) =>
            dic.TryGetValue(key, out var result) ? result : default;
    }
}
#endif