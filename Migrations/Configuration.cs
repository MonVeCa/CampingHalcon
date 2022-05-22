namespace CampingHalconMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using CampingHalconMVC.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<CampingHalconMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CampingHalconMVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Agregar Productos de la categoría 'Linternas y Lámparas':
            var linternasyLamparasList = new [] {
                new ProductoModel()
                {
                    Id = 1,
                    Nombre = "Linterna plástica 1 LED 200 lm recargable",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Linternas/1.jpg",
                    Precio = 30,
                },
                new ProductoModel()
                {
                    Id = 2,
                    Nombre = "Linterna de minero 1 LED Cree 500 lm recargable",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/2.jpg",
                    Precio = 35
                },
                new ProductoModel()
                {
                    Id = 3,
                    Nombre = "Linterna de minero 1 LED 125 lm recargable",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/3.jpg",
                    Precio = 50
                },
                new ProductoModel()
                {
                    Id = 4,
                    Nombre = "Lámpara recargable con luz emergencia, 480lm",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/4.jpg",
                    Precio = 49
                },
                new ProductoModel()
                {
                    Id = 5,
                    Nombre = "Linterna de minero 1 LED 340 lm recargable",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/5.jpg",
                    Precio = 39
                },
                new ProductoModel()
                {
                    Id = 6,
                    Nombre = "Linterna de aluminio 1 LED 130 lm recargable",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/6.jpg",
                    Precio = 69
                },
                new ProductoModel()
                {
                    Id = 7,
                    Nombre = "Linterna reflectora 5 LEDs 200 lm recargable",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/7.jpg",
                    Precio = 75
                },
                new ProductoModel()
                {
                    Id = 8,
                    Nombre = "Lámpara de 1 LED 270 lm con luz de emergencia",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/8.jpg",
                    Precio = 80
                },
                new ProductoModel()
                {
                    Id = 9,
                    Nombre = "Linterna plástica recargable de LED, 120 lúmenes",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/9.jpg",
                    Precio = 89
                },
                new ProductoModel()
                {
                    Id = 10,
                    Nombre = "Linterna plástica 1 LED 80 lm con 2 pilas AA",
                    Descripcion = "",
                    UrlImagen = $"/Content/Categorias/Linternas/10.jpg",
                    Precio = 30
                }};

            // Agregar Productos de la categoría 'Parrillas y Cocina':
            var parrillasyCocinaList = new[] {
                new ProductoModel()
                {
                    Id = 11,
                    Nombre = "Parrilla 40 cm Eléctrica Acero Inoxidable",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/1.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 12,
                    Nombre = "Parrilla de Inducción 80cm Vidrio Negro GE Profile",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/2.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 13,
                    Nombre = "Parrilla de Inducción 60cm Vidrio Negro GE Profile",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/3.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 14,
                    Nombre = "Parrilla de Vitrocerámica 60cm Vidrio Negro GE Profile",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/4.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 15,
                    Nombre = "Parrilla a gas empotrable acero inoxidable Fline Malmo 5 Fline Malmo 5",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/5.jpg",
                    Precio = 120
                },
                new ProductoModel()
                {
                    Id = 16,
                    Nombre = "Parrilla de Gas Empotrable 4 Quemadores AVERA VT4 Estufa de Mesa",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/6.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 17,
                    Nombre = "Parrilla de Induccion Supra Cristal Templado Color Negro 4 Quemadores 60 cm",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/7.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 18,
                    Nombre = "Combo Parrilla a Gas 5 Quemadores AI5 Campana de Pared 76cm",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/8.jpg",
                    Precio = 130
                },
                new ProductoModel()
                {
                    Id = 19,
                    Nombre = "Parilla gas y campana de cocina para pared supra con cristal templado.",
                    Descripcion = "",
                    UrlImagen = "/Content/Categorias/Parrillas/9.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 20,
                    Nombre = "Parrilla de Inducción Empotrable Supra 90 cm Negra",
                    UrlImagen = "/Content/Categorias/Parrillas/10.jpg",
                    Descripcion = "",
                    Precio = 140
                }
            };

            var bolsasYAccesorios = new[] {
                new ProductoModel()
                {
                    Id = 21,
                    Nombre = "Bolsa De Dormir Coleman Saco Sleeping Bag 187x72cm Colores",
                    UrlImagen = "/Content/Categorias/Bolsas/1.jpg",
                    Precio = 140
                },
                new ProductoModel()
                {
                    Id = 22,
                    Nombre = "Bolsa Dormir Azul Sleeping Bag Campismo Campamento Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/2.jpg",
                    Precio = 120
                },
                new ProductoModel()
                {
                    Id = 23,
                    Nombre = "Bolsa De Dormir Sleeping Bag 223 X 71cm Verde Scout Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/3.jpg",
                    Precio = 110
                },
                new ProductoModel()
                {
                    Id = 24,
                    Nombre = "Bolsa De Dormir Sleeping Bag 215 X 72cm Azul Cirrus Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/4.jpg",
                    Precio = 90
                },
                new ProductoModel()
                {
                    Id = 25,
                    Nombre = "Bolsa De Dormir Sleeping Bag Con Gorro Para Campismo Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/5.jpg",
                    Precio = 95
                },
                new ProductoModel()
                {
                    Id = 26,
                    Nombre = "Bolsa De Dormir 84 Y 191 Cm Rojo Quemadoclear Lake Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/6.jpg",
                    Precio = 80
                },
                new ProductoModel()
                {
                    Id = 27,
                    Nombre = "Bolsa Seca Para Resguardo Contra Agua 24 X 10 Cm Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/7.jpg",
                    Precio = 75
                },
                new ProductoModel()
                {
                    Id = 28,
                    Nombre = "Bolsa De Dormir Brazos Clima Frio 84x190 Azul Marino Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/8.jpg",
                    Precio = 170
                },
                new ProductoModel()
                {
                    Id = 29,
                    Nombre = "Bolsa De Dormir Sleeping Bag Infantil Rosa Brilla Oscuridad",
                    UrlImagen = "/Content/Categorias/Bolsas/9.jpg",
                    Precio = 70
                },
                new ProductoModel()
                {
                    Id = 30,
                    Nombre = "Bolsa De Dormir Cozyfoot Negro Calentador De Pies Coleman",
                    UrlImagen = "/Content/Categorias/Bolsas/10.jpg",
                    Precio = 100
                }
            };
            var hielerasYTermos = new[] {
                new ProductoModel()
                {
                    Id = 31,
                    Nombre = "Hielera 20 Lhiel20 Surtek",
                    UrlImagen = "/Content/Categorias/Hieleras/1.jpg",
                    Precio = 30
                },
                new ProductoModel()
                {
                    Id = 32,
                    Nombre = "Hielera 45.5 L Hiel45 Urrea",
                    UrlImagen = "/Content/Categorias/Hieleras/2.jpg",
                    Precio = 40
                },
                new ProductoModel()
                {
                    Id = 33,
                    Nombre = "Coleman Hielera 30 QT, Negro",
                    UrlImagen = "/Content/Categorias/Hieleras/3.jpg",
                    Precio = 50
                },
                new ProductoModel()
                {
                    Id = 34,
                    Nombre = "Hielera 9 Qt Roja 3000005085 Coleman",
                    UrlImagen = "/Content/Categorias/Hieleras/4.jpg",
                    Precio = 60
                },
                new ProductoModel()
                {
                    Id = 35,
                    Nombre = "Bolsa Hielera Go Azul 2000003281 Coleman",
                    UrlImagen = "/Content/Categorias/Hieleras/5.jpg",
                    Precio = 50
                },
                new ProductoModel()
                {
                    Id = 36,
                    Nombre = "Termo 2l Ter2l Urrea",
                    UrlImagen = "/Content/Categorias/Hieleras/6.jpg",
                    Precio = 40
                },
                new ProductoModel()
                {
                    Id = 37,
                    Nombre = "Termo 5 Gal Ter5g Urrea",
                    UrlImagen = "/Content/Categorias/Hieleras/7.jpg",
                    Precio = 30
                },
                new ProductoModel()
                {
                    Id = 38,
                    Nombre = "Termo 1 Galon Ter1g Surtek",
                    UrlImagen = "/Content/Categorias/Hieleras/8.jpg",
                    Precio = 45
                },
                new ProductoModel()
                {
                    Id = 39,
                    Nombre = "Termo 1 Galon Azul 5696-718 Coleman",
                    UrlImagen = "/Content/Categorias/Hieleras/9.jpg",
                    Precio = 45
                },
                new ProductoModel()
                {
                    Id = 40,
                    Nombre = "Termo 1 Galon Rojo 5696-703 Coleman",
                    UrlImagen = "/Content/Categorias/Hieleras/10.jpg",
                    Precio = 70
                }
            };
            var AccesoriosDeCampismo = new[] {
                new ProductoModel()
                {
                    Id = 41,
                    Nombre = "Cuerda Verde 15 Metros Para Campismo M821c185t Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/1.jpg",
                    Precio = 20
                },
                new ProductoModel()
                {
                    Id = 42,
                    Nombre = "Bomba Inflar Manual Go 12-in Gris 2000025341 Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/2.jpg",
                    Precio = 60
                },
                new ProductoModel()
                {
                    Id = 43,
                    Nombre = "Bomba Inflar Manual Go 16-in Gris 2000025342 Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/3.jpg",
                    Precio = 65
                },
                new ProductoModel()
                {
                    Id = 44 ,
                    Nombre = "Kit De Reparacion Y Sellador 2000004569 Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/4.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 45 ,
                    Nombre = "Repelente De Agua En Aerosol 298 Gr Telas Y Piel Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/5.jpg",
                    Precio = 10
                },
                new ProductoModel()
                {
                    Id = 46,
                    Nombre = "Toldo Shelter Con Luz Integrada 450 Lum Instant All Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/6.jpg",
                    Precio = 20
                },
                new ProductoModel()
                {
                    Id = 47,
                    Nombre = "Compresor Aire Bomba Para Inflar Llantas 12 V Powersports",
                    UrlImagen = "/Content/Categorias/Campismo/7.jpg",
                    Precio = 100
                },
                new ProductoModel()
                {
                    Id = 48,
                    Nombre = "Machete De Acero Negro Para Campismo Con Funda 45cm Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/8.jpg",
                    Precio = 50
                },
                new ProductoModel()
                {
                    Id = 49,
                    Nombre = "Tijeras 12 En 1 Multiusos Tailgating Camping Pesca Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/9.jpg",
                    Precio = 15
                },
                new ProductoModel()
                {
                    Id = 50,
                    Nombre = "Mazo Goma Con Removedor Estacas De Tienda De campaña Coleman",
                    UrlImagen = "/Content/Categorias/Campismo/10.jpg",
                    Precio = 60
                }
            };

            // Agregar categorías a la dB:
            context.Categorias.AddOrUpdate(
                new CategoriaModel()
                {
                    Id = 1,
                    Nombre = "Linternas y Lámparas",
                    UrlImagen = "https://www.mndelgolfo.com/blog/wp-content/uploads/2017/09/como-funciona-una-linterna.jpg",
                    Productos = new List<ProductoModel>(linternasyLamparasList)
                },
                new CategoriaModel()
                {
                    Id = 2,
                    Nombre = "Parrillas y Cocina",
                    UrlImagen = "https://m.media-amazon.com/images/I/51plOOZ02+L.jpg",
                    Productos = new List<ProductoModel>(parrillasyCocinaList)
                },
                new CategoriaModel()
                {
                    Id = 3,
                    Nombre = "Bolsas y Accesorios",
                    UrlImagen = "https://cdn.homedepot.com.mx/productos/142076/142076-z.jpg",
                    Productos = new List<ProductoModel>(bolsasYAccesorios)
                },
                new CategoriaModel()
                {
                    Id = 4,
                    Nombre = "Hieleras y Termos",
                    UrlImagen = "https://ventiapp.blob.core.windows.net/images/3C219AE5/3a36f7f8.jpg",
                    Productos = new List<ProductoModel>(hielerasYTermos)
                },
                new CategoriaModel()
                {
                    Id = 5,
                    Nombre = "Accesorios de Campismo",
                    UrlImagen = "https://http2.mlstatic.com/D_NQ_NP_699214-CBT48100903073_112021-V.jpg",
                    Productos = new List<ProductoModel>(AccesoriosDeCampismo)
                }
                );
        }
    }
}
