using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)" +
                "VALUES('Masculino', 'Roupas para homens')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)" +
               "VALUES('Feminina', 'Roupas para mulheres')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)" +
               "VALUES('Unisex', 'Roupas para ambos os sexos')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
