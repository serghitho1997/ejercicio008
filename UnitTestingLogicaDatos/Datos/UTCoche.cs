using LogicaDatos.Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UTLogicaDatos.Datos
{
    [TestClass]
    public class UTCoche
    {

        [TestMethod]
        public void TestBorrame()
        {
            Coche c = new Coche();
            c.ID = 4;
            Assert.AreEqual(4, c.ID);
        }
    }
}
