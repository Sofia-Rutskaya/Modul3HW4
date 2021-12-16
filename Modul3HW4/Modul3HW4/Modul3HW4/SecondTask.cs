using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class SecondTask
    {
        public void LINQ()
        {
            string[] listContactName = { "Addison", "Eliot", "Lanselot", "Amy", "Shinderpow", "Powder", "Catlyn", "Leo", "Lin" };
            string[] listContactSurname = { "Rodery", "Shinderpow", "Gant", "Acteryx", "Wister", "Addison", "Akira", "Manshecter", "Chao" };

            Console.WriteLine($"Name, where lenght > 5:");
            var contacts = listContactName.Where(w => w.Length > 5).OrderBy(o => o.Length);
            foreach (var item in contacts)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine($"Name and surname:");
            var count = -1;
            var contact = listContactName.Select(s =>
            {
                count++;
                return s += $"   {listContactSurname[count]}";
           }).ToList().OrderBy(o => o);

            foreach (var item in contact)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine($"First name on 'L':");
            var firstOrDefault = contact.FirstOrDefault(f => f.StartsWith('L'));
            Console.WriteLine($"\t{firstOrDefault}");

            Console.WriteLine($"Start from 3 plase:");
            var skip = contact.Skip(3).OrderBy(o => o);

            foreach (var item in skip)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("Reverse:");

            var revers = contact.Reverse();

            foreach (var item in revers)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("Union:");
            var union = listContactName.Union(listContactSurname);
            foreach (var item in union)
            {
                Console.WriteLine($"\t{item}");
            }

            Console.WriteLine("Intersect:");
            var intersect = listContactName.Intersect(listContactSurname);

            foreach (var item in intersect)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
