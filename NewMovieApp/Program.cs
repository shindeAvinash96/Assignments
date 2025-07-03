using System.Runtime.CompilerServices;

namespace NewMovieApp
{
    public class Program
    {
        List<Movie> movielist = new List<Movie>();
        int maxMovie = 5;
        static void Main(string[] args)
        {
            

            Console.WriteLine("-------------------------Movie Application------------------------");
          
            Program p = new Program();

            while (true)
            {
                Console.WriteLine("1.Add Movie\t2.Display\t3.Clear All\t4.Exit");
                Console.Write("Enter your option from menu: ");
                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        p.AddMovie();
                        break;
                    case 2:
                        p.Display();
                        break;
                    case 3:
                        p.ClearAll();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }


            }
        }

        public void AddMovie()
        {
            List<Movie> tempmovie = new List<Movie>();
            tempmovie = SerialDeserial.Deserialization();
            if (movielist.Count >=  maxMovie)
            {
                Console.WriteLine("cant add elements more than 5");
            }
            else
            {
               
                Movie movie = new Movie();
                //string id, name, genre, year;
                Console.Write("Enter Movie Id: ");
                movie.Id = Console.ReadLine();

                bool exist = tempmovie.Exists(m=> m.Id == movie.Id);

                if (exist)
                {
                    Console.WriteLine("Id is already present .");
                }
                else
                {
                    Console.Write("Enter Movie Name: ");
                    movie.Name = Console.ReadLine();

                    Console.Write("Enter Movie Genre: ");
                    movie.Genre = Console.ReadLine();

                    Console.Write("Enter Movie Year: ");
                    movie.Year = Console.ReadLine();

                    tempmovie.Add(movie);
                    SerialDeserial.Serialization(tempmovie);
                }
            }

        }

        public void Display()
        {
            List<Movie> tempmovie = new List<Movie>();
            tempmovie = SerialDeserial.Deserialization();

            string id;
            Console.Write("Enter Movie Id: ");
            id = Console.ReadLine();

            if(tempmovie.Count == 0)
            {
                Console.WriteLine("List is Empty");
            }
            //foreach(Movie mov in tempmovie)
            //{
            //    Console.WriteLine($"Id: {mov.Id}\tName: {mov.Name}\tGenre: {mov.Genre}\tYear: {mov.Year}");
            //}
            for (int i = 0; i < tempmovie.Count; i++)
            {
                if (tempmovie[i].Id == id)
                {
                    Console.WriteLine($"Id: {tempmovie[i].Id}\t Name: {tempmovie[i].Name}\t Genre: {tempmovie[i].Genre}\t Year: {tempmovie[i].Year}");
                }
                else
                {
                    Console.WriteLine("Id does not exist.");
                }
             }
        }

        public void ClearAll()
        {
            List<Movie> tempmovie = new List<Movie>();
            tempmovie = SerialDeserial.Deserialization();
            tempmovie.Clear();
            SerialDeserial.Serialization(tempmovie) ;
            
        }
    }
}
