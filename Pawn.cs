using System;

namespace Chess_App
{
    class Pawn:Piece
    {
        public Pawn(char id, int pos, bool col): base(id,pos,col){

        }
         public override  bool moveIsValid(int[] current, int[] newPosit){
             if(Math.Abs(current[0] - newPosit[0]) == 2 && current[1] - newPosit[1] == 0){
             switch(Position){
             case 8:
             case 9:
             case 10:
             case 11: 
             case 12: 
             case 13:
             case 14:
             case 15:
             case 48:
             case 49:
             case 50:
             case 51:
             case 52:
             case 53:
             case 54:
             case 55:
             return true;
             default:
             return false;
             }
             }
             if(newPosit[0] - current[0] == 1 && Math.Abs(newPosit[1] - current[1]) <= 1){
                 return true;
             }
            return true;
        }
    }
}