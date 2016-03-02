using LeFrenchMelee.Data;
using LeFrenchMelee.Model;
using System;
using System.Collections.Generic;

namespace LeFrenchMelee.ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IEnumerable<Member> members = unitOfWork.MemberProvider.GetMembers();
            foreach(Member member in members)
            {
                Console.WriteLine(member.Pseudo);
            }
            Console.ReadLine();
        }
    }
}
