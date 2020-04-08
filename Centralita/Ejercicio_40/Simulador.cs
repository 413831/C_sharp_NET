using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Simulador
    {
        private Centralita central;
        private List<Llamada> llamadas;
        Random random;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.llamadas;
            }
        }

        public Centralita Central
        {
            get
            {
                return this.central;
            }
        }

        public Simulador(Centralita centralita)
        {
            this.central = centralita;
            this.llamadas = new List<Llamada>();
        }

        public void AgregarLlamada()
        {
            random = new Random();

            foreach(Llamada llamada in this.Llamadas)
            {
                this.central += llamada;
                Thread.Sleep(random.Next(1000, 20000));
            }
        }
    }
}
