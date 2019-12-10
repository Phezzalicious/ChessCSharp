using System;

namespace Chess_App
{
    class King:Piece
    {
        public King(char id, int pos, bool col): base(id,pos,col){

        }
         public override  bool moveIsValid(int[] current, int[] newPosit){
            if(!(Math.Abs(current[0] - newPosit[0]) == 1) || !(Math.Abs(current[1] - newPosit[1]) == 1) && !((Math.Abs(current[0] - newPosit[0])==1)&&(Math.Abs(current[1] - newPosit[1])==1))){
                return false;
            }
            return true;
        }
    }
}