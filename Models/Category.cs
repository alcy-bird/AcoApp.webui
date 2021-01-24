
using System;
using System.Collections.Generic;

public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }

    public static implicit operator List<object>(Category v)
    {
        throw new NotImplementedException();
    }
}

