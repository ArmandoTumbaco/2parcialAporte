using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Parlante : Decorador
{

    public Parlante(OrdenBase ordenBase) : base(ordenBase) { }

    public override string software()
    {
        var teclado = "Has agregado el parlante adicional";
        return teclado;
    }
}