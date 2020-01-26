using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne2020
{
   
    public class Band : IComparable<Band>
    {
        #region properties
        public string Name { get; set; }
        public int YearFormed { get; set; }
        public List<string> Members { get; set; }
        #endregion properties

        #region constructors
        public Band()
        {


        }
        public Band(string name, int yearFormed, string members)

        {
            Name = name;
            YearFormed = yearFormed;

            Members = new List<string>();

            string[] memberNames = members.Split(',');
            foreach (string n in memberNames)
            {
                Members.Add(n);
            }
        }
        #region ToString()
        public override string ToString()
        {
            var result = string.Join(",", Members.ToArray());
            return $"{Name}  - {YearFormed } - {result}";
        }
        #endregion ToString();

        #endregion constructors

        #region IComparable Method
        public int CompareTo(Band name)
        {
            return this.Name.CompareTo(name.Name);
        }
        #endregion IComparable Method
    }
}
