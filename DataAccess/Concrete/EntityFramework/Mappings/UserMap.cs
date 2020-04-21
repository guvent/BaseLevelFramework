﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users2", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserName).HasColumnName(@"UserName");
            Property(x => x.Password).HasColumnName(@"Password");
            Property(x => x.FirstName).HasColumnName(@"FirstName");
            Property(x => x.LastName).HasColumnName(@"LastName");
            Property(x => x.Email).HasColumnName(@"Email");
        }
    }
}
