using System;
using System.Collections.Generic;

namespace Prototype
{
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
