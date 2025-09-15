using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class PieceNonAgreee : Piece
    {
        #region Attributs Privées
        private string etat;
        private int seuil;
        #endregion

        #region Constructeur
        public PieceNonAgreee(int unNumero, string unLibelle, int unNombre, int unSeuil)
    :       base(unNumero, unLibelle, unNombre)
        {
            this.seuil = unSeuil;
            this.etat = "VERT"; //associer vers VERT, ORANGE ou ROUGE
        }
        #endregion

        #region Méthodes 
        public string GetEtat()
        {
            return this.etat;
        }

        public void ChangerEtat(string unEtat)
<<<<<<< HEAD
        {
            if (unEtat == "VERT" || unEtat == "ORANGE" || unEtat == "ROUGE")
                this.etat = unEtat;
            else
                this.etat = "VERT";
=======
        { 
            this.etat = unEtat; 
>>>>>>> 13c17ff578ba6a645bd0e286c1b663c5d3294ae8
        }

        public override string ObtenirInfos()
        {
            return $"{base.ObtenirInfos()}\nEtat : {GetEtat()}";
        }

        public override bool AControler()
        {
            if(GetEtat() == "VERT")
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
