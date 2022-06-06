using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCapModel
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private int nivel;
        private Bebida bebidaFavorita;

        public string NivelTxt
        {
            get
            {
                string nivelTxt = "";
                switch (nivel)
                {
                    case 1: nivelTxt = "Silver";
                        break;
                    case 2: nivelTxt = "Gold";
                        break;
                    case 3: nivelTxt = "Platinum";
                        break;
                }
                return nivelTxt;
            }
        }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public Bebida BebidaFavorita { get => bebidaFavorita; set => bebidaFavorita = value; }
    }
}
