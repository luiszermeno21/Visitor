using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        void visit(Mago m);
        void visit(Guerrero g);
        void visit(List<IPersonaje> elementlist);
    }
}
