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
        public Magasin(List<Piece> unePieces)
        {
            this.lesPieces = unePieces;
        }
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

        public bool AjouterPiece(Piece unePiece)
        {
            foreach (Piece piece in this.lesPieces)
            {
                if (unePiece.GetNumSerie() == piece.GetNumSerie())
                {
                    return false;
                }
            }
            this.lesPieces.Add(unePiece);
            return true;
        }

        public void AfficherMagasin()
        {
            foreach(Piece piece in this.lesPieces)
            {
                Console.WriteLine($"{piece}\n");
            }
        }

        public double ObtenirTauxPNA()
        {
            double tauxPNA = 0;
            foreach(Piece unePiece in this.lesPieces)
            {
                if(unePiece is PieceNonAgreee)
                {
                    tauxPNA += 1;
                }
            }
            return (tauxPNA / this.lesPieces.Count()) * 100;
        }

        public List<Piece> ControlerPieces()
        {
            List<Piece> liste = new List<Piece>();
            foreach(Piece p in lesPieces)
            {
                if(p.AControler() == true)
                {
                    liste.Add(p);
                }
            }
            return liste;
        }
        #endregion
    }
}
