using System;

namespace Chess_App
{
    class Piece
    {
        char id;
        int position;
        bool color; 
        public Piece(char id, int pos, bool col){
            ID=id;
            position=pos;
            color=col;
        }
        public int Position{
            get{return position;}
            set{position = value;}
        }
        
        public char ID{
            get{return id;}
            set{id = (char)value;}
        }
        public bool Color{
            get{return color;}
            set{color = value;}
        }
        public static int[] getCoord(int posit){
           
            int[] coords = new int[2];
             coords[0] = (posit/8) + 1;
             coords[1] = (posit % 8) + 1;
            return coords;
        }
        public virtual bool moveIsValid(int[] current, int[] newPosit){
            return true;
        }
         public static int getPos(int x,int y){
            return 3;

        }
    }
}