﻿using LRR.Catalogo.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LRR.Catalogo.API.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasColumnType("varchar(250)");
            builder.Property(c => c.Descricao).IsRequired().HasColumnType("varchar(500)");
            builder.Property(c => c.Imagem).IsRequired().HasColumnType("varchar(250)");
            //builder.Property(c => c.Valor).IsRequired().HasColumnType("decimal(12,2)");
            builder.ToTable("Produtos");
        }
    }
}
