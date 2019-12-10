using System;
using System.Collections.Generic;

namespace Chess_App
{
    class Board
    {
        List<Piece> pieces;
        List<Piece> isCaptured = new List<Piece>();
        char[] board = new char[64];
        public Board(){
            InitializeBoard();

        }
        void InitializeBoard(){
            pieces = new List<Piece>(){
                new Rook('r',0,false),
                new Knight('n',1,false),
                new Bishop('b',2,false),
                new Queen('q',3,false),
                new King('k',4,false),
                new Bishop('b',5,false),
                new Knight('n',6,false),
                new Rook('r',7,false),
                new Pawn('p',8,false),
                new Pawn('p',9,false),
                new Pawn('p',10,false),
                new Pawn('p',11,false),
                new Pawn('p',12,false),
                new Pawn('p',13,false),
                new Pawn('p',14,false),
                new Pawn('p',15,false),
                //white
                new Pawn('p',48,true),
                new Pawn('p',49,true),
                new Pawn('p',50,true),
                new Pawn('p',51,true),
                new Pawn('p',52,true),
                new Pawn('p',53,true),
                new Pawn('p',54,true),
                new Pawn('p',55,true),
                new Rook('r',56,true),
                new Knight('n',57,true),
                new Bishop('b',58,true),
                new Queen('q',59,true),
                new King('k',60,true),
                new Bishop('b',61,true),
                new Knight('n',62,true),
                new Rook('r',63,true)
            };
            for(int i = 0; i > board.Length; i++){
                foreach(Piece x in pieces){
                    if(i == x.Position){
                        board[i] = x.ID;
                    }
                }
                
            }  
        }
        bool ValidateMove(Piece piece, int newPos){
            int[] current = Piece.getCoord(piece.Position);
            int[] newPosit = Piece.getCoord(newPos);
            int xDiff = Math.Abs(current[0] - newPosit[0]);
            int yDiff = Math.Abs(current[1] - newPosit[1]);
           if( !piece.moveIsValid(current, newPosit)){
               return false;
           } 
           if(!isPathClear(piece.Position,newPos)){
               return false; 
           }
            
            if(piece is Pawn){
                if(Math.Abs(newPosit[1] - current[1]) == 1){
                    if(board[newPos] == 'x'){
                        return false;
                    }
                }
            }  
            
            
                       
            if(!(board[newPos]=='x')){
                capturePiece(newPos);
            }
            return true;
        }
        public void performMove(Piece piece, int newPos){
            if(ValidateMove(piece,newPos)){
            piece.Position = newPos;
            for(int i =0; i < board.Length; i++){
                board[i] = 'x';
                foreach(Piece p in pieces){
                    if(p.Position == i){
                        board[i] = p.ID;
                    }
                }
            }
            }
        }
        public void capturePiece(int newPos){
            foreach(Piece x in pieces){
                if(newPos == x.Position){
                    pieces.Remove(x);
                    isCaptured.Add(x);
                }
            }
        }
        public bool isPathClear(int current, int newPos){//true means it is clear
            
            int[] curr = Piece.getCoord(current);
            int[] newP = Piece.getCoord(newPos); 
            if(Math.Abs(curr[0] - newP[0]) == Math.Abs(curr[1] - newP[1])){//bishop, queen
                if(curr[0] < newP[0]){
                    for(int i = 0;i <= newP[0] - curr[0]; i++){
                        if(!(board[Piece.getPos(curr[0]-i,curr[1]-i)] == 'x')){
                            return false;
                        }
                    }
                }else{
                    for(int i = 1; i<= curr[0] - newP[0]; i++){
                        if(!(board[Piece.getPos(curr[0]+i,curr[1]+i)] == 'x')){
                            return false;
                        }
                    }
                }

            }else if(!(curr[0] == newP[0] && newP[1] == curr[1]) && (curr[0] == newP[0] || curr[1] == newP[1])){//rook, queen
                if(curr[0] == newP[0]){
                    if(curr[1] > newP[1]){
                        for(int i = 1; i <= (curr[1] - newP[1]); i++){
                            if(!(board[Piece.getPos(newP[0],newP[1]+i)] == 'x')){
                                return false;
                            }
                        }
                    }
                     if(curr[1] < newP[1]){
                        for(int i = 1; i <= (newP[1] - curr[1]); i++){
                            if(!(board[Piece.getPos(curr[0],curr[1]+i)] == 'x')){
                                return false;
                            }
                        }
                    }
                }else if(curr[1] == newP[1]){
                     if(curr[0] > newP[0]){
                        for(int i = 1; i <= (curr[0] - newP[0]); i++){
                            if(!(board[Piece.getPos(newP[0]+i,newP[1])] == 'x')){
                                return false;
                            }
                        }
                    }
                     if(curr[0] < newP[0]){
                        for(int i = 1; i <= (newP[1] - curr[1]); i++){
                            if(!(board[Piece.getPos(curr[0]+i,curr[1])] == 'x')){
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
       
       public Piece getPiecebyID(int location){
           Piece fake = new Piece('%',665,true);
           foreach(Piece p in pieces){
               if(p.Position == location){
                   return p;
               }
           }
           return fake; 

       }
    }
}