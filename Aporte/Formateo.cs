using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Formateo : Decorador
{

    public Formateo(OrdenBase ordenBase) : base(ordenBase) { }
    public virtual string reparacion()
    {
        var repacion = "El formateo para tu celular esta completo..";
        return repacion;
    }
}