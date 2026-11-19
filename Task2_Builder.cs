using System;

namespace Builder
{
    public class BuilderTask
    {
        class Pizza
        {
            string dough = "";
            string sauce = "";
            string topping = "";
            public void SetDough(string d) { dough = d; }
            public void SetSauce(string s) { sauce = s; }
            public void SetTopping(string t) { topping = t; }
            public void Info()
            {
                Console.WriteLine("Dough: {0}\nSauce: {1}\nTopping: {2}", dough, sauce, topping);
            }
        }

        abstract class PizzaBuilder
        {
            protected Pizza pizza = null!;
            public Pizza GetPizza() { return pizza; }
            public void CreateNewPizza() { pizza = new Pizza(); }
            public abstract void BuildDough();
            public abstract void BuildSauce();
            public abstract void BuildTopping();
        }

        class HawaiianPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("cross"); }
            public override void BuildSauce() { pizza.SetSauce("mild"); }
            public override void BuildTopping() { pizza.SetTopping("ham+pineapple"); }
        }

        class SpicyPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("pan baked"); }
            public override void BuildSauce() { pizza.SetSauce("hot"); }
            public override void BuildTopping() { pizza.SetTopping("pepperoni+salami"); }
        }

        class MargaritaPizzaBuilder : PizzaBuilder
        {
            public override void BuildDough() { pizza.SetDough("thin"); }
            public override void BuildSauce() { pizza.SetSauce("tomato"); }
            public override void BuildTopping() { pizza.SetTopping("mozzarella+basil"); }
        }

        class Waiter
        {
            private PizzaBuilder pizzaBuilder = null!;
            public void SetPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }
            public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
            public void ConstructPizza()
            {
                pizzaBuilder.CreateNewPizza();
                pizzaBuilder.BuildDough();
                pizzaBuilder.BuildSauce();
                pizzaBuilder.BuildTopping();
            }
        }

        public static void Run()
        {
            Waiter waiter = new Waiter();

            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
            waiter.ConstructPizza();
            waiter.GetPizza().Info();

            Console.WriteLine("---");

            PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();
            waiter.SetPizzaBuilder(margaritaPizzaBuilder);
            waiter.ConstructPizza();
            waiter.GetPizza().Info();
        }
    }
}