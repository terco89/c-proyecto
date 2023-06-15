using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class Almacen
    {
        List<List<Bebida>> estanterias = new List<List<Bebida>>();

        public Almacen(List<List<Bebida>> estanterias)
        {
            this.estanterias = estanterias;
        }

        public List<List<Bebida>> Estanterias
        {
            get { return estanterias; }
        }

        public int precioTotalAlmacen()
        {
            int cont = 0;
            foreach(List<Bebida> est in estanterias) {
                foreach (Bebida b in est) {
                    if (b == null) continue;
                    cont += b.Precio;
                }
            } 
            return cont;
        }
        public int precioTotalPorMarca(string marca)
        {
            int cont = 0;
            foreach (List<Bebida> est in estanterias)
            {
                foreach (Bebida b in est)
                {
                    if (b == null) continue;
                    if(b.MarcaGet == marca) cont += b.Precio;
                }
            }
            return cont;
        }
        public int precioTotalEstanteria(int numeroDeEstante)
        {
            int cont = 0;
            foreach(Bebida b in estanterias[numeroDeEstante])
            {
                if (b == null) continue;
                cont += b.Precio;
            }
            return cont;
        }
        public string agregarBebida(Bebida b)
        {
            if (estanterias.Exists(v => v.Exists(y => y != null && y.Id == b.Id))) return "No se agrego la bebida porque ya existia una bebida con el id "+b.Id;
            foreach(List<Bebida> est in estanterias)
            {
                for(int i = 0; i < estanterias.Count(); i++)
                {
                    if(est[i] == null)
                    {
                        est[i] = b;
                        return "Se agrego una " + b.MarcaGet;
                    }
                }
            }
            return "No se agrego la bebida porque no había ningun espacio libre";
        }
        public string eliminarBebida(int id)
        {
            for(int i = 0; i < estanterias.Count();i++)
            {
                foreach(Bebida b in estanterias[i])
                {
                    if (b == null) continue;
                    if(b.Id == id)
                    {
                        estanterias[i][estanterias[i].IndexOf(b)] = null;
                        return "Se elimino la bebida";
                    }
                }
            }
            return "No se elimino la bebida";
        }
        public string mostrarInformacion()
        {
            if (!estanterias.Exists(v => v.Exists(y => y != null))) return "No hay bebidas";
            string conc = "Almacen\nPrecio total de las bebidas que hay: "+precioTotalAlmacen()+" pesos";
            foreach(List<Bebida> est in estanterias)
            {
                conc += "\n\nEstante "+(estanterias.IndexOf(est)+1)+"\nPrecio de las bebidas de este estante: "+precioTotalEstanteria(estanterias.IndexOf(est));
                foreach(Bebida b in est)
                {
                    if (b == null) continue;
                    if (b is AguaMineral)
                    {
                        AguaMineral am = (AguaMineral)b;
                        conc += "\n\n"+am.MarcaGet+"\nId: "+am.Id+"\nPrecio: "+am.Precio+"\nCantidad de Litros: "+am.Litros+"\nOrigen: "+am.Origen;
                    }
                    else
                    {
                        BebidaAzucarada am = (BebidaAzucarada)b;
                        conc += "\n\n"+am.MarcaGet+"\nId: "+am.Id+"\nPrecio: "+am.Precio+"\nCantidad de Litros: "+am.Litros+"\nPorcentaje de azucares: "+am.Azucar+"%\nPromoción: "+am.Promocion;
                    }
                }
            }
            return conc;
        }
    }
}
