using System;
using System.Net.Security;

class Contacts
{
    public string name { get; set; }
    public int number { get; set; }

    public Contacts(string name, int number)
    {
        this.name = name;
        this.number = number;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Contacts> contacts = new List<Contacts>();

        do
        {

            Console.Clear();

            Console.WriteLine("(1) Add Contact \n(2) View Contacts \n(3) Delete Contacts");
            Console.Write("Input: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());
  
                contacts.Add(new Contacts(Name, num));
            } else if (c == 2)
            {
                Console.WriteLine("Contacts: ");

                for (int x = 0; x < contacts.Count; x++)
                {
                    if (contacts.Count == 0)
                    {
                        Console.WriteLine("No Contacts Yet");
                    }else
                    {
                        Console.WriteLine("( Contact #" + (x + 1) + ") \n" + "Name:" + contacts[x].name + "\n" + "Number: " + contacts[x].number);
                    }
                    Console.WriteLine();
                }
            } else if (c == 3)
            {
                Console.Write("Input: ");
                int i = Convert.ToInt32(Console.ReadLine());

                int con = i - 1;

                contacts.RemoveAt(con);
            }


        } while (true);
        
    }
}
