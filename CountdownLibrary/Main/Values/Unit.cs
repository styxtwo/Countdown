using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    abstract class Unit : IUnit{
        public abstract int Decimals { get; }
        public abstract string Name { get; }
        public abstract double TimerInterval { get; }
        public abstract UnitType UnitType { get; }
        public abstract String[] FunFacts { get; }

        public abstract double Convert(Date date);

        public string GetFunFact() {
            if (FunFacts == null || !FunFacts.Any()) {
                return "";
            }
            Random random = new Random();
            int next = random.Next(FunFacts.Count());
            return FunFacts[next]; 
        }
    }
}
