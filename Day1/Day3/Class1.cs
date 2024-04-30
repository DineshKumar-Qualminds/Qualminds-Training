namespace Day3
{
    class Class1
    {
        public void Test1() 
        {
            Console.WriteLine("Public Method");
        }

        private void Test2() {
            Console.WriteLine("Private Method");
        }

        internal void Test3()
        {
            Console.WriteLine("Internal Mthod");
        }
        protected void Test4()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test5()
        {
            Console.WriteLine("Protected Method");
        }
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Test1();
            class1.Test2();
            class1.Test3();
            class1.Test4();
            class1.Test5();
        }
    }
}
