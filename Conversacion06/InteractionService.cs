using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolSensual
{
    class InteractionService : IInteraccionService
    {
        public string Obtener()
        {
            return Console.ReadLine();
        }

        public T Obtener<T>()
        {
            T result = default(T);
            do
            {
                var texto = Obtener();
                if (texto is T)
                    result = (T)((object)texto);
            } while (result != null);

            return result;
        }

        public void Publicar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
