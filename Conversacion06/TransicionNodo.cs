using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolSensual
{
    class TransicionNodo<T>
    {
        public TransicionNodo(Nodo n, params T[] condiciones)
        {
            Condiciones = condiciones.ToList();
            Nodo = n;
        }

        public List<T> Condiciones { get; set; }
        public Nodo Nodo { get; set; }

        public bool PuedeTransitar(T entrada) => Condiciones.Any(x => x.Equals(entrada));
        public void Transitar() => Nodo.Entrar();
    }
}
