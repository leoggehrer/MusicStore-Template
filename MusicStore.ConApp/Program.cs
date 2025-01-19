using MusicStore.Logic.DataContext;

namespace MusicStore.ConApp
{
    internal class Program
    {
        static void Main(/*string[] args*/)
        {
            string input = string.Empty;
            MusicStoreContext context = new();

            while (!input.Equals("x", StringComparison.CurrentCultureIgnoreCase))
            {
                int index = 1;
                Console.Clear();
                Console.WriteLine("MusicStore");
                Console.WriteLine("==========================================");

                Console.WriteLine($"{nameof(PrintGenres),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintArtists),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintAlbums),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintTracks),-25}....{index++}");

                Console.WriteLine();
                Console.WriteLine($"Exit...............x");
                Console.Write("Your choice: ");

                input = Console.ReadLine()!;
                if (Int32.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PrintGenres(context);
                            break;
                        case 2:
                            PrintArtists(context);
                            break;
                        case 3:
                            PrintAlbums(context);
                            break;
                        case 4:
                            PrintTracks(context);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Continue with Enter...");
                    Console.ReadLine();
                }
            }
        }

        private static void PrintGenres(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Genres:");
            Console.WriteLine("-------");
            foreach (var item in context.GenreSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintArtists(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Artists:");
            Console.WriteLine("-------");
            foreach (var item in context.ArtistSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintAlbums(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Albums:");
            Console.WriteLine("-------");
            foreach (var item in context.AlbumSet)
            {
                Console.WriteLine($"{item}");
            }
        }
        private static void PrintTracks(MusicStoreContext context)
        {
            Console.WriteLine();
            Console.WriteLine("Tracks:");
            Console.WriteLine("-------");
            foreach (var item in context.TrackSet)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
