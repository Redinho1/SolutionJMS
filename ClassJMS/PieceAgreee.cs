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
            return 0;
        }

        public void RenouvelerAgrement(DateTime uneDate)
        {
            this.dateAgrement = uneDate;
        }

        public string ObtenirInfos()
        {
            return this.nomConstructeur;
        }
        #endregion
    }
}
