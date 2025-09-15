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
    public class PieceNonAgreeeTests
    {
        [TestMethod()]
        public void ObtenirInfosTest()
        {
            PieceNonAgreee PNA = new PieceNonAgreee(125, "Anémomètre", 1250,60);
            string expected = "125 - Anémomètre\nEtat : VERT";
            Assert.AreEqual(expected, PNA.ObtenirInfos());
        }

        [TestMethod()]
        public void ChangerEtatTest()
        {
            PieceNonAgreee PNA = new PieceNonAgreee(125, "Anémomètre", 1250, 60);
            Assert.AreEqual("VERT",PNA.GetEtat());
            PNA.ChangerEtat("ORANGE");
            Assert.AreEqual("ORANGE", PNA.GetEtat());
        }

        [TestMethod()]
        public void AControlerTest()
        {
            // Cas 1 : La piece est à contrôler car son état est vert et le seuil est dépassé
            PieceNonAgreee PNA = new PieceNonAgreee(125, "Anémomètre", 1250, 60);
            Assert.AreEqual(false, PNA.AControler());

            // Cas 2 : La piece n'est pas à contrôler car le seuil n'est pas dépassé, même si son état est vert
            PNA.ChangerEtat("ORANGE");
            Assert.AreEqual(true, PNA.AControler());


            // Cas 3 : La piece n'est pas à contrôler car son état n'est pas vert, même si le seuil est dépassé
            PNA.ChangerEtat("ORANGE");
            Assert.AreEqual(true, PNA.AControler());
        }
    } 
}