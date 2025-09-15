using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class Piece
    {
        #region attributs privés
        private int numSerie;       // numéro de série
        private string libelle;     // libellé de la pièce
        protected int nbHeures;       // nombre d'heures de fonctionnement
        #endregion

        #region constructeur
        public Piece(int numSerie, string libelle)
        {
            this.numSerie = numSerie;
            this.libelle = libelle;
        }
        #endregion

        #region méthodes
        public int GetNumSerie() 
        { 
            return this.numSerie; 
        }

        public virtual bool AControler()
        {
            return false;
        }

        public string ObtenirInfos()
        {
            return $"{GetNumSerie()} - {this.libelle}";
        }

        public string GetLibelle()
        {
            return this.libelle;
        }
        #endregion
    }
}
