using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Llamada
  {
    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas,
    }

    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    #region Propiedades

    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    public string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }

    public string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }

    public abstract float CostoLlamada
    { get; }


    #endregion

    #region Métodos

    public Llamada()
    { }

    public Llamada(float duracion, string destino, string origen)
    {
      this.duracion = duracion;
      this.nroDestino = destino;
      this.nroOrigen = origen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder datos = new StringBuilder("");

      datos.AppendFormat("Duracion: {0} min \n", this.Duracion.ToString());
      datos.AppendFormat("Número de destino: {0} \n", this.NroDestino);
      datos.AppendFormat("Número de origen: {0} \n", this.nroOrigen);

      return datos.ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
    {
      int returnValue = 0;

      if (llamadaUno.Duracion > llamadaDos.Duracion)
      {
        returnValue = 1;
      }
      else if (llamadaUno.Duracion < llamadaDos.Duracion)
      {
        returnValue = -1;
      }
      return returnValue;
    }
    #endregion

    #region Operadores

    public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
    {
      if (llamadaUno.Equals(llamadaDos) && llamadaUno.NroOrigen == llamadaDos.NroOrigen &&
          llamadaUno.NroDestino == llamadaDos.NroDestino)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
    {
      return !(llamadaUno == llamadaDos);
    }

    public override bool Equals(object obj)
    {
      if (obj != null || this.GetType() == obj.GetType())
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public override int GetHashCode()
    {
      return Tuple.Create(duracion, nroDestino, nroOrigen).GetHashCode();
    }
    #endregion
  }
}
