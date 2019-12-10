using System;

namespace Chess_App
{
    class Rook:Piece
    {
        public Rook(char id, int pos, bool col): base(id,pos,col){

        }
         public override  bool moveIsValid(int[] current, int[] newPosit){
            
             
             if(!((current[0] == newPosit[0])&&(current[1]==newPosit[1])) && ((current[0]==newPosit[0])||(current[1]==newPosit[1]))){
               

                 return true;
             }else{
                 return false;
             }

            
        }
    }
}