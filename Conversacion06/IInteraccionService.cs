using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolSensual
{
    interface IInteraccionService
    {
        string Obtener();
        T Obtener<T>();
        void Publicar(string mensaje);
    }
}
