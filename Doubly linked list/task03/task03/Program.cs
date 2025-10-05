using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task03;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
             MusicPlayer playList = new MusicPlayer();
            playList.insertAtEnd("The song of ice and fire");
            playList.insertAtEnd("Descpacito");
            playList.insertAtEnd("Stereo");
            playList.insertAtEnd("Fairytale");
            playList.insertAtEnd("Billonera");
            playList.DisplayForward();
            Console.WriteLine();
            playList.DisplayBackward();
            playList.delete("Stereo");
            playList.delete("Billonera");
            Console.WriteLine();
            playList.DisplayForward();
        }
    }
}
