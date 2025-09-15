using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class PieceAgreee : Piece
    {
        #region Attributs privées
        private DateTime dateAgrement;
        private string nomConstructeur;
        #endregion

        #region Constructeur
        public PieceAgreee(int unNumero, string unLibelle, int unNombre, DateTime uneDate, string unConstructeur)
            : base(unNumero,unLibelle,unNombre)
        {
            this.dateAgrement = uneDate;
            this.nomConstructeur = unConstructeur;
        }
        #endregion

        #region Méthodes
        public int CalculerDureeAgrement()
        {
            return DateTime.Now.Year - this.dateAgrement.Year;
        }

        public void RenouvelerAgrement(DateTime uneDate)
        {
            this.dateAgrement = uneDate;
        }

        public string ObtenirInfos()
        {
            return $"{base.ObtenirInfos()}\nConstructeur : {this.nomConstructeur}\nDate Agrément : {this.dateAgrement}";
        }

        public override bool AControler()
        {
            if (DateTime.Now.Year - 2 < this.dateAgrement.Year)
                return false;
            return true;
        }

        public DateTime GetDateAgrement()
        { 
            return this.dateAgrement; 
        }
        #endregion
    }
}
