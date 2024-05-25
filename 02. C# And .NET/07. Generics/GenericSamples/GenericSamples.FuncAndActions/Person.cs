﻿namespace GenericSamples.FuncAndActions
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string GetFullName() => $"{Id}. {Name}";
    }
}
