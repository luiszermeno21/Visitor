using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Mago: IPersonaje
    {
        private string arma = "";

        public Mago()
        {

        }

        public string getArma()
        {
            return this.arma;
        }

        public void setArma(string arma)
        {
            this.arma = arma;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
