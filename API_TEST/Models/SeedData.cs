// using Microsoft.EntityFrameworkCore;
// using RazorPagesMovie.Migrations;

// namespace RazorPagesMovie.Models
// {
//     public static class SeedData
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new RazorPagesMovieContext(
//                 serviceProvider.GetRequiredService<
//                     DbContextOptions<RazorPagesMovieContext>>()))
//             {
//                 if (context == null || context.Movie == null)
//                 {
//                     throw new ArgumentNullException("Null RazorPagesMovieContext");
//                 }

//                 // Look for any movies.
//                 if (context.Movie.Any())
//                 {
//                     return;   // DB has been seeded
//                 }

//                 context.Movie.AddRange(
//                     new Movie
//                     {   ID=1,
//                         Title = "When Harry Met Sally",
//                         ReleaseDate = DateTime.Parse("1989-2-12"),
//                         Genre = "Romantic Comedy",
//                         Price = 7.99M
//                     },

//                     new Movie
//                     {   ID=2,
//                         Title = "Ghostbusters ",
//                         ReleaseDate = DateTime.Parse("1984-3-13"),
//                         Genre = "Comedy",
//                         Price = 8.99M
//                     },

//                     new Movie
//                     {   ID=3,
//                         Title = "Ghostbusters 2",
//                         ReleaseDate = DateTime.Parse("1986-2-23"),
//                         Genre = "Comedy",
//                         Price = 9.99M
//                     },

//                     new Movie
//                     {   ID=4,
//                         Title = "Rio Bravo",
//                         ReleaseDate = DateTime.Parse("1959-4-15"),
//                         Genre = "Western",
//                         Price = 3.99M
//                     }
//                 );
//                 context.SaveChanges();
//             }
//         }
//     }
// }