using Business.Utilities.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Güven",
                LastName = "Topal",
                TCNO = "45529796164",
                DateOfBirth = new DateTime(1988, 09, 01),
                Email = "guven@topal.com"
            });
            Console.WriteLine("Eklendi!");
        }
    }
}
