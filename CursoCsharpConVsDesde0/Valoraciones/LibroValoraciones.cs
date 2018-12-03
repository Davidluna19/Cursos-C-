using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        /// EL CAMPO DE ACCION (SCOPE) DE ESTA LISTA
        /// ES DENTRO DE TODA LA CLASE
        List<float> valoraciones;

        public LibroValoraciones()
        {
            /// METODO CONSTRUCTOR DE LA CLASE
            valoraciones = new List<float>();
        }
        
        public void AgregarValoracion(float valoracion)
        {
            /// METODO PARA RECIBIR UNA VALORACION
            valoraciones.Add(valoracion);
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach (float valoracion in valoraciones)
            {
                calculo.valoracionMin = Math.Min(valoracion,calculo.valoracionMin);
                calculo.valoracionMax = Math.Max(valoracion, calculo.valoracionMax);
                sumaValoraciones += valoracion;
            }

            calculo.promedioValoraciones = sumaValoraciones / valoraciones.Count;
            return calculo;
        }
    }
}