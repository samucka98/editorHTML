using System;
using System.Text;

namespace EditorHtml
{
  public class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("MODO EDITOR (ESC para sair)");
      Console.WriteLine("...........................");

      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append("\n");
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Menu.Show();
    }

    protected static void Start() { }
  }
}