using System;

namespace Chess_App
{
    class Queen:Piece
    {
        public Queen(char id, int pos, bool col): base(id,pos,col){

        }
         public override  bool moveIsValid(int[] current, int[] newPosit){
            return true;
        }
    }
}