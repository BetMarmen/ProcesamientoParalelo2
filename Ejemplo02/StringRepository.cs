﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public class StringRepository : IRepository<string>
    {
        private List<string> _list = new List<string>();
        public StringRepository(int count,int length) 
        { 
            GenerateRandomsStrings(count, length);
        }

        private void GenerateRandomsStrings(int count, int length)
        {
            var random=new Random();
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxy0123456789";
            for(int i = 0; i < count; i++)
            {
                char[] stringChars= new char[length];
                for(int j = 0; j < length; j++)
                    stringChars[j] = characters[random.Next(characters.Length)];
                _list.Add(new string(stringChars));
            }
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public List<string> GetAll()
        {
            return _list;
        }
    }
}
