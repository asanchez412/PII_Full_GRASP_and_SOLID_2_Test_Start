using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void GetStepCost()
        {
            Recipe recipe = new Recipe();
            Equipment equipment = new Equipment("Cafetera", 5);
            Product product = new Product("Café", 1);
            Step step = new Step(product, 10, equipment, 120);
            
            double prueba_GetStepCost() // Cambiá el nombre para indicar qué estás probando
            {
                double prueba = (step.Input.UnitCost * step.Quantity) + (step.Equipment.HourlyCost * step.Time);
                return prueba;
            }   
                Assert.AreEqual(prueba_GetStepCost(), 610);
        }
        [TestCase]
        public void GetProductionCost()
        {
            Recipe recipe = new Recipe();
            Equipment equipment = new Equipment("Cafetera", 5);
            Product product = new Product("Café", 1);
            Step step = new Step(product, 10, equipment, 120);
            Step step1 = new Step(product, 25, equipment, 90);

            double prueba_GetProductionCost()
            {
                double prueba = 0;
                foreach (Step step in recipe.steps)
            {
                prueba = prueba + step.GetStepCost();
            }
            return prueba;
            }
            Assert.AreEqual(prueba_GetProductionCost(), 100);
        }
    }
}