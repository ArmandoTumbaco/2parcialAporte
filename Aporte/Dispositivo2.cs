using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Dispositivo2 : OrdenBase
{
    public override string reparacion()
    {
        var repa = "En repacion el dispositivo 2";
        return repa;
    }
    public override string software()
    {
        var repa = "Agregando un hardware adicional al dispositivo 2";
        return repa;
    }
}