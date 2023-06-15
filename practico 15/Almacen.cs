using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class Almacen
    {
        List<List<Estante>> estanterias = new List<List<Estante>>();

        public Almacen(List<List<Estante>> estanterias)
        {
            this.estanterias = estanterias;
        }

        public List<List<Estante>> Estanterias
        {
            get { return estanterias; }
        }

        public int precioTotalAlmacen()
        {
            int cont = 0;
            foreach(List<Estante> est in estanterias) {
                foreach (Estante b in est) {
                    if (b.Bebida == null) continue;
                    cont += b.Bebida.Precio;
                }
            } 
            return cont;
        }
        public int precioTotalPorMarca(string marca)
        {
            int cont = 0;
            foreach (List<Estante> est in estanterias)
            {
                foreach (Estante b in est)
                {
                    if (b.Bebida == null) continue;
                    if(b.Bebida.MarcaGet == marca) cont += b.Bebida.Precio;
                }
            }
            return cont;
        }
        public int precioTotalEstanteria(int numeroDeEstante)
        {
            int cont = 0;
            foreach(Estante b in estanterias[numeroDeEstante])
            {
                if (b.Bebida == null) continue;
                cont += b.Bebida.Precio;
            }
            return cont;
        }
        public string agregarBebida(Bebida b)
        {
            if (estanterias.Exists(v => v.Exists(y => y.Bebida != null && y.Bebida.Id == b.Id))) return "No se agrego la bebida porque ya existia una bebida con el id "+b.Id;
            foreach(List<Estante> est in estanterias)
            {
                for(int i = 0; i < estanterias.Count(); i++)
                {
                    if(est[i].Bebida == null)
                    {
                        est[i].Bebida = b;
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
                foreach(Estante b in estanterias[i])
                {
                    if (b.Bebida == null) continue;
                    if(b.Bebida.Id == id)
                    {
                        estanterias[i][estanterias[i].IndexOf(b)].Bebida = null;
                        return "Se elimino la bebida";
                    }
                }
            }
            return "No se elimino la bebida";
        }
        public string mostrarInformacion()
        {
            if (!estanterias.Exists(v => v.Exists(y => y.Bebida != null))) return "No hay bebidas";
            string conc = "Almacen\nPrecio total de las bebidas que hay: "+precioTotalAlmacen()+" pesos";
            foreach(List<Estante> est in estanterias)
            {
                conc += "\n\nEstante "+(estanterias.IndexOf(est)+1)+"\nPrecio de las bebidas de este estante: "+precioTotalEstanteria(estanterias.IndexOf(est));
                foreach(Estante b in est)
                {
                    if (b.Bebida == null) continue;
                    if (b.Bebida is AguaMineral)
                    {
                        AguaMineral am = (AguaMineral)b.Bebida;
                        conc += "\n\n"+am.MarcaGet+"\nId: "+am.Id+"\nPrecio: "+am.Precio+"\nCantidad de Litros: "+am.Litros+"\nOrigen: "+am.Origen;
                    }
                    else
                    {
                        BebidaAzucarada am = (BebidaAzucarada)b.Bebida;
                        conc += "\n\n"+am.MarcaGet+"\nId: "+am.Id+"\nPrecio: "+am.Precio+"\nCantidad de Litros: "+am.Litros+"\nPorcentaje de azucares: "+am.Azucar+"%\nPromoción: "+am.Promocion;
                    }
                }
            }
            return conc;
        }
    }
}
