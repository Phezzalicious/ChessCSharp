using System;

namespace Chess_App
{
    class Bishop:Piece
    {
        public Bishop(char id, int pos, bool col): base(id,pos,col){

        }
         public override  bool moveIsValid(int[] current, int[] newPosit){
             if(current[0] == newPosit[0] || current[1] == newPosit[1]){
                 return false;
             }
              if(!(Math.Abs(current[0] - newPosit[0]) == Math.Abs(current[1] - newPosit[1]))){
                   return false;
               }
               int x = current[0] - newPosit[0];
               for(int i = 1; i > x; i++){
                   if(!(Piece.getPos(current[0]+i,current[1]+i)=='x')){
                       return false;
                   }
               }  
            return true;
        }
    }
}