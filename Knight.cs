using System;

namespace Chess_App
{
    class Knight:Piece
    {
        public Knight(char id, int pos, bool col): base(id,pos,col){

        }
        public override  bool moveIsValid(int[] current, int[] newPosit){
            return true;
        }
    }
}