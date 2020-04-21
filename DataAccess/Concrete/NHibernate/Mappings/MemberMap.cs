using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DataAccess.Concrete.NHibernate.Mappings
{
    public class MemberMap:ClassMap<Member>
    {
        public MemberMap()
        {
            Table(@"Members");
            LazyLoad();

            Id(x => x.Id).Column("Id");

            Map(x => x.FirstName).Column("FirstName");
            Map(x => x.LastName).Column("LastName");
            Map(x => x.Email).Column("Email");
            Map(x => x.TCNO).Column("TCNO");
            Map(x => x.DateOfBirth).Column("DateOfBirth");
        }
    }
}
