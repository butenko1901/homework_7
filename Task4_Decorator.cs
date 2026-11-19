using System;
using System.Collections.Generic;

namespace DecoratorTree
{
    interface ITree
    {
        void Show();
        void Light();
    }

    class ChristmasTree : ITree
    {
        public void Show() { Console.WriteLine("Ялинка"); }
        public void Light() { Console.WriteLine("Ялинка не світиться"); }
    }

    abstract class TreeDecorator : ITree
    {
        protected ITree tree;
        public TreeDecorator(ITree tree) { this.tree = tree; }
        public virtual void Show() { tree.Show(); }
        public virtual void Light() { tree.Light(); }
    }

    class OrnamentDecorator : TreeDecorator
    {
        private List<string> ornaments;
        public OrnamentDecorator(ITree tree, List<string> ornaments) : base(tree)
        {
            this.ornaments = ornaments;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("  Прикраси: " + string.Join(", ", ornaments));
        }
    }

    class GarlandDecorator : TreeDecorator
    {
        public GarlandDecorator(ITree tree) : base(tree) { }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("  Гірлянда: є");
        }
        public override void Light()
        {
            Console.WriteLine("Ялинка світиться різнокольоровими вогниками!");
        }
    }

    public class DecoratorTask
    {
        public static void Run()
        {
            ITree tree = new ChristmasTree();
            tree.Show();
            tree.Light();

            Console.WriteLine("\n--- З прикрасами ---");
            tree = new OrnamentDecorator(tree, new List<string> { "кульки", "зірка", "цукерки" });
            tree.Show();
            tree.Light();

            Console.WriteLine("\n--- З прикрасами та гірляндою ---");
            tree = new GarlandDecorator(tree);
            tree.Show();
            tree.Light();
        }
    }
}