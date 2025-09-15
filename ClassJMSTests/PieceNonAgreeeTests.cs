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
        }

        [TestMethod()]
        public void ChangerEtatTest()
        {
        }

        [TestMethod()]
        public void AControlerTest()
        {
            // Cas 1 : La piece est à contrôler car son état est vert et le seuil est dépassé
            

            // Cas 2 : La piece n'est pas à contrôler car le seuil n'est pas dépassé, même si son état est vert
            

            // Cas 3 : La piece n'est pas à contrôler car son état n'est pas vert, même si le seuil est dépassé
            
            
        }
    }
}