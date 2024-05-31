using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fina.core.Models;
using Microsoft.EntityFrameworkCore;

namespace fina.api.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        
        builder.Property(x => x.Type)
            .IsRequired(true)
            .HasColumnType("SMALLINT");
        
        builder.Property(x => x.Amount)
            .IsRequired(true)
            .HasColumnType("MONEY");
        
        builder.Property(x => x.CreatedAt)
            .IsRequired(true);
        
        builder.Property(x => x.PaidOrReceivedAt)
            .IsRequired(false);
        
        builder.Property(x => x.UserId)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);
        }
    }
}