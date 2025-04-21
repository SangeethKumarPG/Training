namespace SamplePrograms
{
    internal class Parent
    {
        string name = "Test";
        int age = 1;
        public Parent(string name, int age)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine("Parent Class Constructor Called");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Age { get { return age; } set { age = value; } }

        protected void checkValues()
        {
            Console.WriteLine("Check values function called!");
        }
    }

    internal class Child : Parent
    {
        string relationShip = "unknow";
        public Child(string name, int age, string relation) : base(name, age)
        {
            this.relationShip = relation;
            Console.WriteLine("Child class constructor called");
        }
        public string RelationShip
        {
            get { return relationShip; }
            set { relationShip = value; }
        }
        
        public void checkValuesFromParent()
        {
            base.checkValues();
        }
    }
}
