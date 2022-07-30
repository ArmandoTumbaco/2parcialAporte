using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dispositivo3 : OrdenBase
{
    public override string reparacion()
    {
        var repa = "en repacion el dispositivo 3";
        return repa;
    }
    public override string software()
    {
        var repa = "Agregando un hardware adicional al dispositivo 3";
        return repa;
    }
}