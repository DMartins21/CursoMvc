using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularRoupas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Name,Price,Descricao,Quantidade)" +
                        "VALUES('shorts médios(m)', 20.50 ,'short para o dia a dia tamanho médio', 10)");
            migrationBuilder.Sql("INSERT INTO Produtos(Name,Price,Descricao,Quantidade)" +
            "VALUES('short masculino(p)', 14.99 ,'short para homens tamanho pequeno', 4)");
            migrationBuilder.Sql("INSERT INTO Produtos(Name,Price,Descricao,Quantidade)" +
            "VALUES('Camisa caipira vermelha (g)', 49.99 ,'camisa vermelha e preta com detalhes quadragulares de tamanho grande', 6)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
