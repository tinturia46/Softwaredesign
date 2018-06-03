using System;
using System.Collections.Generic;

namespace L07_DesignPatterns
{
  class GameChar
  {
    public virtual void Threaten()
    {
      Console.WriteLine("Raawwwwrrrrr ");
    }
  }
  class Monster : GameChar
  {
      public override void Threaten()
      {
          base.Threaten();
          Console.WriteLine("Grrrrrrrrrr");
      }
  } 
  class Hero : GameChar
  {
    public override void Threaten()
    {
      Console.WriteLine("You shall not pass");
    }
  }
  class WithAColdChar : GameChar
  {
    private GameChar _original;
    public WithAColdChar(GameChar original)
    {
      _original = original;
    }
    public override void Threaten()
    {
      _original.Threaten();
      base.Threaten();
      Console.Write("Hust!");
    }
  }
  class HoarseChar : GameChar
  {
    private GameChar _original;

    public HoarseChar(GameChar original)
    {
      _original = original;
    }

    public override void Threaten()
    {
      _original.Threaten();
      base.Threaten();
      Console.Write("Räusper....");
    }
  }
}