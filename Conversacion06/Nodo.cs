using System.Collections.Generic;
using System.Linq;

namespace ArbolSensual
{
    class Nodo
    {
        private IInteraccionService _intServ;
        private string _msg;

        public Nodo(IInteraccionService intServ, string msg)
        {
            _intServ = intServ;
            _msg = msg;
            Transiciones = new List<TransicionNodo<string>>();
        }

        public void Entrar()
        {
            TransicionNodo<string> transicion = null;
            var palabra = string.Empty;
            do
            {
                if (!string.IsNullOrWhiteSpace(_msg))
                {
                    var opciones = string.Join(", ", Transiciones?.SelectMany(t => t.Condiciones).OrderBy(x => x));
                    _intServ.Publicar(_msg + $" [{opciones}]");
                }
                    
                palabra = _intServ.Obtener();

                transicion = Transiciones.FirstOrDefault(t => t.PuedeTransitar(palabra));
            } while (transicion == null);

            //Accion(new object[] { (object)palabra });

            transicion.Transitar();
        }

        //public void Entrar1(object[] parametros)
        //{
        //    Accion(parametros);
        //    Transiciones.Single().Transitar();
        //}

        //public abstract bool Accion(object[] parametros);

        public List<TransicionNodo<string>> Transiciones { get; set; }
    }

    //public class NExpedirPedido : Nodo
    //{
    //    public NExpedirPedido(Nodo siguiente)
    //    {
    //        Transiciones.Add(new TransicionNodo<string>(siguiente));
    //    }

    //    public override bool Accion(object[] parametros)
    //    {
            
    //    }
    //}


}
