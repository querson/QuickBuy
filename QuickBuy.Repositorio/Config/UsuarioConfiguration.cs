using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id); /*u é uma variavel pode ser qualquer coisa, aqui está definindo a chave primária*/
            /* o comando builder aceita comandos
             a frente que vai definindo a configuração*/
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");


            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
    
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            /*  builder
                .Property(u => u.Pedidos)*/


        }
    }
}
