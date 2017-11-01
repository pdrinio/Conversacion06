using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArbolSensual
{
    public class Shell
    {
        public static void Main()
        {
            IInteraccionService iis = new InteractionService();
            var raiz = new Nodo(iis, "Hola, dicte su comando");

            var salirARaiz = new TransicionNodo<string>(raiz, "salir");

            var expedirPedido = new Nodo(iis, "Nº de pedido");
            var cancelarPedido = new Nodo(iis, "Nº de pedido");

            var expedir = new TransicionNodo<string>(expedirPedido, "expedir", "expide");
            var cancelar = new TransicionNodo<string>(cancelarPedido, "cancelar", "cancela");

            expedir.Nodo.Transiciones.Add(salirARaiz);
            cancelar.Nodo.Transiciones.Add(salirARaiz);

            raiz.Transiciones.Add(expedir);
            raiz.Transiciones.Add(cancelar);
            

            raiz.Entrar();
        }
    }
}
