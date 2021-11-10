using System;

namespace Trash_Dash
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TrashGame())
                game.Run();
        }
    }
}
