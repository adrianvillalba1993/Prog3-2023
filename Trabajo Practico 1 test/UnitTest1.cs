using System.Collections;
using System.ComponentModel.Design;
using Trabajo_Practico_1;
namespace Trabajo_Practico_1_test
{
    public class UnitTest1
    {
        [Fact]       
        public void alumnosPares()
        {
            bool dato = false;
            Dictionary<int, int> nuevo = new Dictionary<int, int>();
            nuevo.Add(25,40);
            nuevo.Add(20,49);
            nuevo.Add(22,20);
            nuevo.Add(30,2);

            foreach(KeyValuePair<int,int> valor in nuevo)
            {
                if (valor.Value % 2 == 0)
                    dato = true;
                Assert.True(dato);
            }
        }

        [Fact]
        public void pruebaDeRecorrido()
        {
            
            Dictionary<int, int> nuevo = new Dictionary<int, int>();
            nuevo.Add(25, 40);
            nuevo.Add(20, 49);
            nuevo.Add(22, 20);
            nuevo.Add(30, 2);

            //acceso al ultimo dato del diccionario sin tener que recorrer
            Assert.Equal(2, nuevo[30]);
        }


        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        public void alumnosCantidadHashtable(int cantidad)
        {
            
            Hashtable nuevo = new Hashtable();
            nuevo.Add(25, 40);
            nuevo.Add(20, 49);
            nuevo.Add(22, 20);
            nuevo.Add(30, 2);

            for(int i = cantidad; i< 1; i--)
            {
                nuevo.Add((20+i), 50-i);
            }
            foreach (DictionaryEntry elemento in nuevo)
            {
                Assert.NotEqual(cantidad, nuevo.Count);
            }          
            Assert.NotNull(nuevo);
        }


        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        public void alumnosCantidad(int cantidad)
        {

            Dictionary<int, int> nuevo = new Dictionary<int, int>();
            nuevo.Add(25, 40);
            nuevo.Add(20, 49);
            nuevo.Add(22, 20);
            nuevo.Add(30, 2);

            for (int i = cantidad; i < 1; i--)
            {
                nuevo.Add((20 + i), 50 - i);
            }

            Assert.NotEqual(cantidad, nuevo.Count);
            Assert.NotNull(nuevo);
        }
    }
}