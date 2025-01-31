﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public enum EVersionBebida
    {
        BotellaDosLitros = 2000,
        BotellaLitro = 1000,
        LataGrande = 355,
        LataMediana = 300,
        LataChica = 255
    }

    public class Bebida : Producto
    {
        bool tieneAlcohol;
        EVersionBebida formato;


        public Bebida(string nombre, int cantDisp, float precio, bool conAlcohol, EVersionBebida formato)
            : base(nombre, cantDisp, precio)
        {

            this.formato = formato;
            this.tieneAlcohol = conAlcohol;

        }

        protected override int PedirAlProveedor
        {
            set
            {
                this.cantidadDisponible += value * 6;
            }
        }

        public override bool ReponerProducto(int cantidad)
        {
            if (this.cantidadDisponible < 200 && cantidad > 0)
            {
                PedirAlProveedor = cantidad;
                return true;
            }
            return false;

        }
    }
}
