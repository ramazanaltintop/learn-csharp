using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Grouper
    {
        private int _numberOfGroups;

        public Grouper(int numberOfGroups)
        {
            _numberOfGroups = numberOfGroups;
        }

        public List<List<Measurement>> Group(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();

            for (int i = 0; i < measurements.Count;)
            {
                var group = measurements.Skip(i).Take(_numberOfGroups).ToList();
                groups.Add(group);
                i += _numberOfGroups;
            }

            return groups;
        }
    }
}