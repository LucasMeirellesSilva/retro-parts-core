using Microsoft.EntityFrameworkCore;
using RetroPecasAPI.Domain.Entities;
using RetroPecasAPI.Infrastructure.Helpers;

namespace RetroPecasAPI.Infrastructure.Data.Seeds;

public static class CategorySeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(

            // Motor
            new Category
            {
                Id = 1,
                Name = "Motor",
                Slug = SlugGenerator.Generate("Motor")
            },
            new Category
            {
                Id = 2,
                Name = "Pistões",
                Slug = SlugGenerator.Generate("Pistões"),
                ParentId = 1
            },
            new Category
            {
                Id = 3,
                Name = "Anéis de Segmento",
                Slug = SlugGenerator.Generate("Anéis de Segmento"),
                ParentId = 1
            },
            new Category
            {
                Id = 4,
                Name = "Cilindros",
                Slug = SlugGenerator.Generate("Cilindros"),
                ParentId = 1
            },
            new Category
            {
                Id = 5,
                Name = "Camisas",
                Slug = SlugGenerator.Generate("Camisas"),
                ParentId = 4
            },
            new Category
            {
                Id = 6,
                Name = "Cabeçotes",
                Slug = SlugGenerator.Generate("Cabeçotes"),
                ParentId = 1
            },
            new Category
            {
                Id = 7,
                Name = "Tampas de Cabeçote",
                Slug = SlugGenerator.Generate("Tampas de Cabeçote"),
                ParentId = 1
            },
            new Category
            {
                Id = 8,
                Name = "Bielas",
                Slug = SlugGenerator.Generate("Bielas"),
                ParentId = 1
            },
            new Category
            {
                Id = 9,
                Name = "Virabrequins",
                Slug = SlugGenerator.Generate("Virabrequins"),
                ParentId = 1
            },
            new Category
            {
                Id = 10,
                Name = "Comando de Válvulas",
                Slug = SlugGenerator.Generate("Comando de Válvulas"),
                ParentId = 1
            },
            new Category
            {
                Id = 11,
                Name = "Válvulas",
                Slug = SlugGenerator.Generate("Válvulas"),
                ParentId = 1
            },
            new Category
            {
                Id = 12,
                Name = "Correntes de Comando",
                Slug = SlugGenerator.Generate("Correntes de Comando"),
                ParentId = 1
            },
            new Category
            {
                Id = 13,
                Name = "Juntas",
                Slug = SlugGenerator.Generate("Juntas"),
                ParentId = 1
            },
            new Category
            {
                Id = 14,
                Name = "Retentores",
                Slug = SlugGenerator.Generate("Retentores"),
                ParentId = 1
            },
            new Category
            {
                Id = 15,
                Name = "Rolamentos",
                Slug = SlugGenerator.Generate("Rolamentos"),
                ParentId = 1
            },
            new Category
            {
                Id = 16,
                Name = "Tampas de Motor",
                Slug = SlugGenerator.Generate("Tampas de Motor"),
                ParentId = 1
            },
            new Category
            {
                Id = 17,
                Name = "Bombas de Óleo",
                Slug = SlugGenerator.Generate("Bombas de Óleo"),
                ParentId = 1
            },
            new Category
            {
                Id = 18,
                Name = "Radiadores",
                Slug = SlugGenerator.Generate("Radiadores"),
                ParentId = 1
            },
            new Category
            {
                Id = 19,
                Name = "Peças de Partida",
                Slug = SlugGenerator.Generate("Peças de Partida"),
                ParentId = 1
            },
            new Category
            {
                Id = 20,
                Name = "Outras Peças de Motor",
                Slug = SlugGenerator.Generate("Outras Peças de Motor"),
                ParentId = 1
            },

            // Alimentação
            new Category
            {
                Id = 21,
                Name = "Alimentação",
                Slug = SlugGenerator.Generate("Alimentação")
            },
            new Category
            {
                Id = 22,
                Name = "Carburadores",
                Slug = SlugGenerator.Generate("Carburadores"),
                ParentId = 21
            },
            new Category
            {
                Id = 23,
                Name = "Peças de Carburador",
                Slug = SlugGenerator.Generate("Peças de Carburador"),
                ParentId = 21
            },
            new Category
            {
                Id = 24,
                Name = "Coletores de Admissão",
                Slug = SlugGenerator.Generate("Coletores de Admissão"),
                ParentId = 21
            },
            new Category
            {
                Id = 25,
                Name = "Corpos de Borboleta",
                Slug = SlugGenerator.Generate("Corpos de Borboleta"),
                ParentId = 21
            },
            new Category
            {
                Id = 26,
                Name = "Injetores",
                Slug = SlugGenerator.Generate("Injetores"),
                ParentId = 21
            },
            new Category
            {
                Id = 27,
                Name = "Filtros de Ar",
                Slug = SlugGenerator.Generate("Filtros de Ar"),
                ParentId = 21
            },
            new Category
            {
                Id = 28,
                Name = "Caixas de Filtro de Ar",
                Slug = SlugGenerator.Generate("Caixas de Filtro de Ar"),
                ParentId = 21
            },
            new Category
            {
                Id = 29,
                Name = "Outras Peças de Alimentação",
                Slug = SlugGenerator.Generate("Outras Peças de Alimentação"),
                ParentId = 21
            },

            // Ignição e Elétrica
            new Category
            {
                Id = 30,
                Name = "Ignição e Elétrica",
                Slug = SlugGenerator.Generate("Ignição e Elétrica")
            },
            new Category
            {
                Id = 31,
                Name = "CDI",
                Slug = SlugGenerator.Generate("CDI"),
                ParentId = 30
            },
            new Category
            {
                Id = 32,
                Name = "Bobinas de Ignição",
                Slug = SlugGenerator.Generate("Bobinas de Ignição"),
                ParentId = 30
            },
            new Category
            {
                Id = 33,
                Name = "Estatores",
                Slug = SlugGenerator.Generate("Estatores"),
                ParentId = 30
            },
            new Category
            {
                Id = 34,
                Name = "Reguladores e Retificadores",
                Slug = SlugGenerator.Generate("Reguladores e Retificadores"),
                ParentId = 30
            },
            new Category
            {
                Id = 35,
                Name = "Velas de Ignição",
                Slug = SlugGenerator.Generate("Velas de Ignição"),
                ParentId = 30
            },
            new Category
            {
                Id = 36,
                Name = "Cachimbos e Cabos de Vela",
                Slug = SlugGenerator.Generate("Cachimbos e Cabos de Vela"),
                ParentId = 30
            },
            new Category
            {
                Id = 37,
                Name = "Interruptores e Chaves",
                Slug = SlugGenerator.Generate("Interruptores e Chaves"),
                ParentId = 30
            },
            new Category
            {
                Id = 38,
                Name = "Outras Peças Elétricas",
                Slug = SlugGenerator.Generate("Outras Peças Elétricas"),
                ParentId = 30
            },

            // Transmissão e Embreagem
            new Category
            {
                Id = 39,
                Name = "Transmissão e Embreagem",
                Slug = SlugGenerator.Generate("Transmissão e Embreagem")
            },
            new Category
            {
                Id = 40,
                Name = "Embreagens",
                Slug = SlugGenerator.Generate("Embreagens"),
                ParentId = 39
            },
            new Category
            {
                Id = 41,
                Name = "Peças de Embreagem",
                Slug = SlugGenerator.Generate("Peças de Embreagem"),
                ParentId = 39
            },
            new Category
            {
                Id = 42,
                Name = "Correntes",
                Slug = SlugGenerator.Generate("Correntes"),
                ParentId = 39
            },
            new Category
            {
                Id = 43,
                Name = "Coroas",
                Slug = SlugGenerator.Generate("Coroas"),
                ParentId = 39
            },
            new Category
            {
                Id = 44,
                Name = "Pinhões",
                Slug = SlugGenerator.Generate("Pinhões"),
                ParentId = 39
            },
            new Category
            {
                Id = 45,
                Name = "Kits de Transmissão",
                Slug = SlugGenerator.Generate("Kits de Transmissão"),
                ParentId = 39
            },
            new Category
            {
                Id = 46,
                Name = "Engrenagens",
                Slug = SlugGenerator.Generate("Engrenagens"),
                ParentId = 39
            },
            new Category
            {
                Id = 47,
                Name = "Eixos de Câmbio",
                Slug = SlugGenerator.Generate("Eixos de Câmbio"),
                ParentId = 39
            },
            new Category
            {
                Id = 48,
                Name = "Seletores de Marchas",
                Slug = SlugGenerator.Generate("Seletores de Marchas"),
                ParentId = 39
            },
            new Category
            {
                Id = 49,
                Name = "Garfos Seletores",
                Slug = SlugGenerator.Generate("Garfos Seletores"),
                ParentId = 39
            },
            new Category
            {
                Id = 50,
                Name = "Pedais de Câmbio",
                Slug = SlugGenerator.Generate("Pedais de Câmbio"),
                ParentId = 39
            },
            new Category
            {
                Id = 51,
                Name = "Outras Peças de Transmissão",
                Slug = SlugGenerator.Generate("Outras Peças de Transmissão"),
                ParentId = 39
            },

            // Freios
            new Category
            {
                Id = 52,
                Name = "Freios",
                Slug = SlugGenerator.Generate("Freios")
            },
            new Category
            {
                Id = 53,
                Name = "Pastilhas",
                Slug = SlugGenerator.Generate("Pastilhas"),
                ParentId = 52
            },
            new Category
            {
                Id = 54,
                Name = "Discos",
                Slug = SlugGenerator.Generate("Discos"),
                ParentId = 52
            },
            new Category
            {
                Id = 55,
                Name = "Cabos de Freio",
                Slug = SlugGenerator.Generate("Cabos de Freio"),
                ParentId = 52
            },
            new Category
            {
                Id = 56,
                Name = "Outras Peças de Freio",
                Slug = SlugGenerator.Generate("Outras Peças de Freio"),
                ParentId = 52
            },

            // Suspensão
            new Category
            {
                Id = 57,
                Name = "Suspensão",
                Slug = SlugGenerator.Generate("Suspensão")
            },
            new Category
            {
                Id = 58,
                Name = "Bengalas",
                Slug = SlugGenerator.Generate("Bengalas"),
                ParentId = 57
            },
            new Category
            {
                Id = 59,
                Name = "Tubos de Bengala",
                Slug = SlugGenerator.Generate("Tubos de Bengala"),
                ParentId = 57
            },
            new Category
            {
                Id = 60,
                Name = "Retentores de Bengala",
                Slug = SlugGenerator.Generate("Retentores de Bengala"),
                ParentId = 57
            },
            new Category
            {
                Id = 61,
                Name = "Amortecedores",
                Slug = SlugGenerator.Generate("Amortecedores"),
                ParentId = 57
            },
            new Category
            {
                Id = 62,
                Name = "Molas",
                Slug = SlugGenerator.Generate("Molas"),
                ParentId = 57
            },
            new Category
            {
                Id = 63,
                Name = "Outras Peças de Suspensão",
                Slug = SlugGenerator.Generate("Outras Peças de Suspensão"),
                ParentId = 57
            },

            // Rodas
            new Category
            {
                Id = 64,
                Name = "Rodas",
                Slug = SlugGenerator.Generate("Rodas")
            },
            new Category
            {
                Id = 65,
                Name = "Cubos",
                Slug = SlugGenerator.Generate("Cubos"),
                ParentId = 64
            },
            new Category
            {
                Id = 66,
                Name = "Aros",
                Slug = SlugGenerator.Generate("Aros"),
                ParentId = 64
            },
            new Category
            {
                Id = 67,
                Name = "Raios",
                Slug = SlugGenerator.Generate("Raios"),
                ParentId = 64
            },
            new Category
            {
                Id = 68,
                Name = "Rolamentos de Roda",
                Slug = SlugGenerator.Generate("Rolamentos de Roda"),
                ParentId = 64
            },
            new Category
            {
                Id = 69,
                Name = "Eixos de Roda",
                Slug = SlugGenerator.Generate("Eixos de Roda"),
                ParentId = 64
            },
            new Category
            {
                Id = 70,
                Name = "Outras Peças de Roda",
                Slug = SlugGenerator.Generate("Outras Peças de Roda"),
                ParentId = 64
            },

            // Chassi e Estrutura
            new Category
            {
                Id = 71,
                Name = "Chassi e Estrutura",
                Slug = SlugGenerator.Generate("Chassi e Estrutura")
            },
            new Category
            {
                Id = 72,
                Name = "Quadros",
                Slug = SlugGenerator.Generate("Quadros"),
                ParentId = 71
            },
            new Category
            {
                Id = 73,
                Name = "Tanques",
                Slug = SlugGenerator.Generate("Tanques"),
                ParentId = 71
            },
            new Category
            {
                Id = 74,
                Name = "Bancos",
                Slug = SlugGenerator.Generate("Bancos"),
                ParentId = 71
            },
            new Category
            {
                Id = 75,
                Name = "Paralamas",
                Slug = SlugGenerator.Generate("Paralamas"),
                ParentId = 71
            },
            new Category
            {
                Id = 76,
                Name = "Rabetas",
                Slug = SlugGenerator.Generate("Rabetas"),
                ParentId = 71
            },
            new Category
            {
                Id = 77,
                Name = "Plásticos",
                Slug = SlugGenerator.Generate("Plásticos"),
                ParentId = 71
            },
            new Category
            {
                Id = 78,
                Name = "Pedaleiras",
                Slug = SlugGenerator.Generate("Pedaleiras"),
                ParentId = 71
            },
            new Category
            {
                Id = 79,
                Name = "Pedais",
                Slug = SlugGenerator.Generate("Pedais"),
                ParentId = 71
            },
            new Category
            {
                Id = 80,
                Name = "Guidões",
                Slug = SlugGenerator.Generate("Guidões"),
                ParentId = 71
            },
            new Category
            {
                Id = 81,
                Name = "Manoplas",
                Slug = SlugGenerator.Generate("Manoplas"),
                ParentId = 71
            },
            new Category
            {
                Id = 82,
                Name = "Manetes",
                Slug = SlugGenerator.Generate("Manetes"),
                ParentId = 71
            },
            new Category
            {
                Id = 83,
                Name = "Cabos",
                Slug = SlugGenerator.Generate("Cabos"),
                ParentId = 71
            },
            new Category
            {
                Id = 84,
                Name = "Outras Peças de Chassi",
                Slug = SlugGenerator.Generate("Outras Peças de Chassi"),
                ParentId = 71
            },

            // Escapamento
            new Category
            {
                Id = 85,
                Name = "Escapamento",
                Slug = SlugGenerator.Generate("Escapamento")
            },
            new Category
            {
                Id = 86,
                Name = "Escapamentos",
                Slug = SlugGenerator.Generate("Escapamentos"),
                ParentId = 85
            },
            new Category
            {
                Id = 87,
                Name = "Silenciosos",
                Slug = SlugGenerator.Generate("Silenciosos"),
                ParentId = 85
            },
            new Category
            {
                Id = 88,
                Name = "Ponteiras",
                Slug = SlugGenerator.Generate("Ponteiras"),
                ParentId = 85
            },
            new Category
            {
                Id = 89,
                Name = "Coletores",
                Slug = SlugGenerator.Generate("Coletores"),
                ParentId = 85
            },
            new Category
            {
                Id = 90,
                Name = "Suportes de Escapamento",
                Slug = SlugGenerator.Generate("Suportes de Escapamento"),
                ParentId = 85
            },

            // Iluminação
            new Category
            {
                Id = 91,
                Name = "Iluminação",
                Slug = SlugGenerator.Generate("Iluminação")
            },
            new Category
            {
                Id = 92,
                Name = "Faróis",
                Slug = SlugGenerator.Generate("Faróis"),
                ParentId = 91
            },
            new Category
            {
                Id = 93,
                Name = "Lanternas",
                Slug = SlugGenerator.Generate("Lanternas"),
                ParentId = 91
            },
            new Category
            {
                Id = 94,
                Name = "Piscas",
                Slug = SlugGenerator.Generate("Piscas"),
                ParentId = 91
            },
            new Category
            {
                Id = 95,
                Name = "Lâmpadas",
                Slug = SlugGenerator.Generate("Lâmpadas"),
                ParentId = 91
            },
            new Category
            {
                Id = 96,
                Name = "Outras Peças de Iluminação",
                Slug = SlugGenerator.Generate("Outras Peças de Iluminação"),
                ParentId = 91
            },

            // Acessórios e Outros
            new Category
            {
                Id = 97,
                Name = "Acessórios e Outros",
                Slug = SlugGenerator.Generate("Acessórios e Outros")
            },
            new Category
            {
                Id = 98,
                Name = "Retrovisores",
                Slug = SlugGenerator.Generate("Retrovisores"),
                ParentId = 97
            },
            new Category
            {
                Id = 99,
                Name = "Cavaletes",
                Slug = SlugGenerator.Generate("Cavaletes"),
                ParentId = 97
            },
            new Category
            {
                Id = 100,
                Name = "Bauletos",
                Slug = SlugGenerator.Generate("Bauletos"),
                ParentId = 97
            },
            new Category
            {
                Id = 101,
                Name = "Suportes",
                Slug = SlugGenerator.Generate("Suportes"),
                ParentId = 97
            },
            new Category
            {
                Id = 102,
                Name = "Protetores",
                Slug = SlugGenerator.Generate("Protetores"),
                ParentId = 97
            },
            new Category
            {
                Id = 103,
                Name = "Outros",
                Slug = SlugGenerator.Generate("Outros"),
                ParentId = 97
            }
        );
    }
}w