﻿using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public abstract class TypedArray<T> : ArrayBufferView
    {
        [ScriptField]
        public static ulong BYTES_PER_ELEMENT { get; private set; }

        [ScriptField]
        public ulong length { get; private set; }

        [ScriptField]
        public extern T this[ulong index] { get; set; }

        public extern void set(TypedArray<T> array);

        public extern void set(TypedArray<T> array, ulong offset);

        public extern void set(T[] array);

        public extern void set(T[] array, ulong offset);

        public extern TypedArray<T> subarray(long begin);

        public extern TypedArray<T> subarray(long begin, long end);
    }
}
