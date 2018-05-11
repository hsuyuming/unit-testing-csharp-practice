﻿using System;
using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
    public class Stack<T>
    {
        private readonly List<T> _list = new List<T>();

        public int Count => _list.Count;

        //public int Count => 1;

        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            _list.Add(obj);
        }

        public T Pop()
        {
            //If we uncomment that, test need to fail.
            //            if (_list.Count == 0)
            //                throw new InvalidOperationException();

            if (_list.Count == 0)
                throw new InvalidOperationException();

            var result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);

            //return _list[0]
            return result;
        }


        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            return _list[_list.Count - 1];
        }
    }
}