using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program {
        static void Main(string[] args) {
            CloneMethod _clone = new CloneMethod(10, "Miagui");
            CloneMethod clone = (CloneMethod)_clone.Clone();
            Console.WriteLine("1o Clone: " +_clone.Id + " | " + _clone.Name);
            Console.WriteLine("2o Clone: " + clone.Id + " | " + clone.Name);
            Console.ReadKey();
        }
    }

    //Prototype Class
    abstract class PrototypeMethod {
        private int _id;
        private string _name;

        public int Id {
            get { return _id; }
        }
        public string Name {
            get { return _name; }
        }

        public PrototypeMethod(int id, string name) {
            this._id = id;
            this._name = name;
        }
        public abstract PrototypeMethod Clone();

    }

    class CloneMethod : PrototypeMethod {
        public CloneMethod(int id, string name) : base(id, name) {
        }
        public override PrototypeMethod Clone() {
            return (PrototypeMethod)this.MemberwiseClone();
        }
    }
}
