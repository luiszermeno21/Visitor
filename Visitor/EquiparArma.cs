using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class EquiparArma : IVisitor
    {
        public void visit(Mago m)
        {
            m.setArma("DAGA");
        }

        public void visit(Guerrero g)
        {
            g.setArma("ESPADA");
        }

        public void visit(List<IPersonaje> elementlist)
        {
            foreach(IPersonaje p in elementlist)
                p.Accept(this);
        }
    }
}
