using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassJMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassJMS.Tests
{
    [TestClass()]
    public class MagasinTests
    {
        
        [TestMethod()]
        public void AjouterPieceTest()
        {
            // Instanciation d'un magasin et de 3 pièces
            Magasin m = new Magasin();
            Piece p1 = new PieceAgreee(125, "Anémomètre", 1250, DateTime.Parse("12/03/2022"), "ZZZ");
            Piece p2 = new PieceAgreee(477, "Truc", 4500, DateTime.Parse("01/05/2025"), "ZZZ");
            Piece p3 = new PieceNonAgreee(477, "Courroie", 3250, 3000);
            // Etat 0 : Aucune pièce dans le magasin
            Assert.AreEqual(0, m.GetLesPieces().Count);
            // Etat 1 : Ajout d'une pièce au magasin
            Assert.AreEqual(true, m.AjouterPiece(p1));
            Assert.AreEqual(1, m.GetLesPieces().Count);
            // Etat 2 : Ajout d'une autre pièce au magasin avec un numéro de série différent
            Assert.AreEqual(true, m.AjouterPiece(p2));
            Assert.AreEqual(2, m.GetLesPieces().Count);
            // Etat 3 : Ajout d'une pièce déjà présente au magasin avec le même numéro de série
            Assert.AreEqual(false, m.AjouterPiece(p3));
            Assert.AreEqual(2, m.GetLesPieces().Count);
        }

        [TestMethod()]
        public void ObtenirTauxPNATest()
        {
            // Etape 1 : Instanciation d'un magasin, de 5 pièces agréées et de 3 pièces non agréées
                       
            // Etape 2 : Ajout des pièces au magasin - utilisation de la méthode SetLesPieces 
            
            // Etape 3 : Vérification du taux de pièces non agréées
           
        }

        [TestMethod()]
        public void ControlerPiecesTest()
        {
            // Etape 1 : Instanciation d'un magasin,
            // de 5 pièces agréées (dont 3 ont un agrément de plus de 2 ans)
            // et de 3 pièces non agréées (dont une a dépassé le nombre d'heures d'utilisation)

            // Etape 2 : Ajout des pièces au magasin - utilisation de la méthode SetLesPieces 

            // Etape 3 : Vérification du nombre de pièces à contrôler et du contenu de la liste des pièces à contrôler

        }
     
    }
}