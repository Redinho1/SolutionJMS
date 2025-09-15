using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS
{
    public class Magasin
    {
        #region attributs privés
        private List<Piece> lesPieces;  // ensemble des pièces du magasin
        #endregion

        #region constructeur
        
        #endregion

        #region méthodes
       
                
                
        // Méthodes utiles pour les tests unitaires
        public List<Piece> GetLesPieces()
        {
            return this.lesPieces;
        }

        public void SetLesPieces(List<Piece> lesPieces)
        {
            this.lesPieces = lesPieces;
        }

        #endregion
    }
}
