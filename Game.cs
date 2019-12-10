using System;

namespace Chess_App
{
    class Game
    {
         Board gameBoard; 
        public Game(){
            gameBoard= new Board();
            
            Start();
          
        }
        public void Start(){
           
            bool gameStatus = true;
                while(gameStatus == true){
                    Console.WriteLine("What Would You Like to do? ");
                    Console.WriteLine("1. Move ");
                    Console.WriteLine("2. Resign ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    switch(choice){
                        case 1:
                        Console.Write("Please enter the location of the Piece you want to move: ");
                        int pieceLocation =  translateMove(Console.ReadLine());
                        Console.Write("Please enter the location you wish to move to: ");
                        int desiredLocation =  translateMove(Console.ReadLine());
                        gameBoard.performMove(gameBoard.getPiecebyID(pieceLocation),desiredLocation);
                        break;
                        case 2: 
                        gameStatus = false; 
                        break;
                    }
                    
                   


                }
        }
        public int translateMove(string spot){
            switch(spot){
                case "a1":
                return 56;
                case "a2":
                return 57;
                case "a3":
                return 58;
                case "a4":
                return 59;
                case "a5":
                return 60;
                case "a6":
                return 61;
                case "a7":
                return 62;
                case "a8":
                return 63;
                case "b1":
                return 48;
                case "b2":
                return 49;
                case "b3":
                return 50;
                case "b4":
                return 51;
                case "b5":
                return 52;
                case "b6":
                return 53;
                case "b7":
                return 54;
                case "b8":
                return 55;
                case "c1":
                return 40;
                case "c2":
                return 41;
                case "c3":
                return 42;
                case "c4":
                return 43;
                case "c5":
                return 44;
                case "c6":
                return 45;
                case "c7":
                return 46;
                case "c8":
                return 47;
                case "d1":
                return 32;
                case "d2":
                return 33;
                case "d3":
                return 34;
                case "d4":
                return 35;
                case "d5":
                return 36;
                case "d6":
                return 37;
                case "d7":
                return 38;
                case "d8":
                return 39;
                case "e1":
                return 24;
                case "e2":
                return 25;
                case "e3":
                return 26;
                case "e4":
                return 27;
                case "e5":
                return 28;
                case "e6":
                return 29;
                case "e7":
                return 30;
                case "e8":
                return 31;
                case "f1":
                return 16;
                case "f2":
                return 17;
                case "f3":
                return 18;
                case "f4":
                return 19;
                case "f5":
                return 20;
                case "f6":
                return 21;
                case "f7":
                return 22;
                case "f8":
                return 23;
                case "g1":
                return 8;
                case "g2":
                return 9;
                case "g3":
                return 10;
                case "g4":
                return 11;
                case "g5":
                return 12;
                case "g6":
                return 13;
                case "g7":
                return 14;
                case "g8":
                return 15;
                case "h1":
                return 0;
                case "h2":
                return 1;
                case "h3":
                return 2;
                case "h4":
                return 3;
                case "h5":
                return 4;
                case "h6":
                return 5;
                case "h7":
                return 6;
                case "h8":
                return 7;
               default:
           

                break;

            }
            return 1;

        }
    }
}