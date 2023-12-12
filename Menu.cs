using System;

namespace EditorHtml
{
  public class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.ForegroundColor = ConsoleColor.Black;
      DrawerScreen(10, 50);

      Options();
      var option = short.Parse(Console.ReadLine());
      handlemenuOption(option);
    }

    protected static void Options()
    {
      Console.SetCursorPosition(2, 2);
      Console.Write("Editor <HTML>");
      Console.SetCursorPosition(2, 3);
      Console.Write("=============");
      Console.SetCursorPosition(2, 4);
      Console.Write("[1] - Novo documento .HTML");
      Console.SetCursorPosition(2, 5);
      Console.Write("[2] - Abrir documento .HTML");
      Console.SetCursorPosition(2, 6);
      Console.Write("[0] - Sair");
      Console.SetCursorPosition(2, 8);
      Console.Write("Option: ");
      Console.SetCursorPosition(10, 8);
    }

    protected static void handlemenuOption(short option)
    {
      switch (option)
      {
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        case 1:; break;
        case 2:; break;
        default: Show(); break;
      }
    }

    protected static void DrawerScreen(int lines, int columns)
    {
      BuildComumnsScreen(columns);
      BuildLinesScreen(lines, columns);
    }

    protected static void BuildComumnsScreen(int columns)
    {
      for (int i = 0; i < columns; i++)
        Console.Write(" ");
      Console.Write("\n");
    }

    protected static void BuildLinesScreen(int lines, int columns)
    {
      for (int i = 0; i < lines; i++)
        BuildComumnsScreen(columns);
      Console.Write("\n");
    }
  }
}