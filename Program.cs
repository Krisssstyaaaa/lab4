using System;
using System.Collections.Generic;
using System.Linq;

namespace SaladApp
{
    // Класс "Ингредиент"
    public class Ingredient
    {
        public string Name { get; set; }    // Название ингредиента
        public double Cost { get; set; }    // Стоимость ингредиента

        public Ingredient(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        // Переопределение метода ToString для вывода информации об ингредиенте
        public override string ToString()
        {
            return $"{Name}: {Cost} USD";
        }
    }

    // Класс "Салат"
    public class Salad
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        // Метод для добавления ингредиентов в салат
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        // Метод для вычисления общей стоимости первых трех ингредиентов
        public double GetTotalCostOfFirstThreeIngredients()
        {
            return Ingredients.Take(3).Sum(ingredient => ingredient.Cost);
        }

        // Метод для вывода всех ингредиентов салата
        public void PrintIngredients()
        {
            Console.WriteLine("Ingredients in the salad:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient.ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание ингредиентов
            var ingredient1 = new Ingredient("Tomato", 0.5);
            var ingredient2 = new Ingredient("Cucumber", 0.3);
            var ingredient3 = new Ingredient("Lettuce", 0.2);
            var ingredient4 = new Ingredient("Carrot", 0.4);
            var ingredient5 = new Ingredient("Pepper", 0.6);

            // Создание салата и добавление ингредиентов
            var salad = new Salad();
            salad.AddIngredient(ingredient1);
            salad.AddIngredient(ingredient2);
            salad.AddIngredient(ingredient3);
            salad.AddIngredient(ingredient4);
            salad.AddIngredient(ingredient5);

            // Вывод ингредиентов салата
            salad.PrintIngredients();

            // Вычисление и вывод общей стоимости первых трех ингредиентов
            double totalCost = salad.GetTotalCostOfFirstThreeIngredients();
            Console.WriteLine($"\nTotal cost of the first three ingredients: {totalCost} USD");
        }
    }
}