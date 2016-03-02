using LeFrenchMelee.Model;
using System.Collections.Generic;

namespace LeFrenchMelee.Data
{
    public class MemberDao : AbstractDao<Member>
    {
        public MemberDao(MeleeContext context)
            :base(context)
        {
            Table = context.Set<Member>();
        }
        public IEnumerable<Member> GetMembers()
        {
            return GetAll();
        }

        public Member AddMember(string pseudo, string password)
        {
            Member member = new Member
            {
                Pseudo = pseudo,
                ClearPassword = password
            };

            return Add(member);
        }
    }
}
