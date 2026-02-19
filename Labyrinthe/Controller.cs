namespace Labyrinthe
{
    internal class Controller
    {       
        private View view;
        private Labyrinthe labyrinthe;

        public Controller(View view, Labyrinthe labyrinthe)
        {            
            this.view = view;
            this.labyrinthe = labyrinthe;
        }

        public void Run()
        {
            while (true) 
            {
                Console.Clear();
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); //ConsoleKey key = Console.ReadKey().Key;

                switch (keyInfo.Key) 
                {
                    case ConsoleKey.UpArrow or ConsoleKey.W:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.DownArrow or ConsoleKey.S:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow or ConsoleKey.A:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow or ConsoleKey.D:
                        labyrinthe.MoveRight();
                        break;
                    default:
                        break;
                }

                if(labyrinthe.IsExit())
                {
                    view.AfficherVictoire();
                    break;
                }
            }

        }
    }
}
