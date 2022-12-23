using System;
using System.Threading;

class Program
{


 static bool closE = false;
 static bool circlE;


 static bool playone = true;
 static bool playtwo = true;
 static bool playthree = true;
 static bool playfour = true;
 static bool playfive = true;
 static bool playsix = true;
 static bool playseven = true;
 static bool playeight = true;
 static bool playnine = true;

 static bool loopcircleSwitch;
 static bool loopcontroL;
 static bool loopLoop;

 static bool playerMoveone;
 static bool playerMovetwo;
 static bool playerMovethree;
 static bool playerMovefour;
 static bool playerMovefive;
 static bool playerMovesix;
 static bool playerMoveseven;
 static bool playerMoveeight;
 static bool playerMovenine;

 static bool aiMoveone;
 static bool aiMovetwo;
 static bool aiMovethree;
 static bool aiMovefour;
 static bool aiMovefive;
 static bool aiMovesix;
 static bool aiMoveseven;
 static bool aiMoveeight;
 static bool aiMovenine;

 static int randomINT;



   static void Main()
   {
     if(closE == false)
     {

       Console.Clear();
       Console.CursorVisible = false;
       Console.ForegroundColor = ConsoleColor.Magenta;

       Console.Write("Do you want to play as circle?  Y/N");

   loopcircleSwitch = true;

    while(loopcircleSwitch == true)
    {

       switch(Console.ReadKey(true).KeyChar)
       {
	    case 'y' : circlE = true; loopcircleSwitch = false;
            break;

            case 'n' : circlE = false; loopcircleSwitch = false;
	    break;

            default :  loopcircleSwitch = true;
            break;

       }

     }


       Console.Clear();
       Console.ForegroundColor = ConsoleColor.Magenta;

       Console.Write
       (
		       
 @"
   | |
 =======
   | |
 =======
   | |
       ");
 

       while (closE == false) { Loop(); WinningCheck(); LosingCheck();}

     }
   }

   static void Controls()
   {

    loopcontroL = true;

     while(loopcontroL == true && closE == false)
     {



      Console.ForegroundColor = ConsoleColor.DarkRed;

      
        switch(Console.ReadKey(true).KeyChar)
	{
	   case 'o' : 

	   if (playone)
           {
		   
           Console.SetCursorPosition(6, 1); if (circlE == false) { Console.Write("X"); } 
           else { Console.Write("O"); }
           playone = false;  loopcontroL = false; playerMoveone = true;

           }
	   break;



           case 'l' : 
	   
	   if (playtwo)
           {

	   Console.SetCursorPosition(6, 3); if (circlE == false) { Console.Write("X"); } 
           else { Console.Write("O"); }
           playtwo = false;  loopcontroL = false; playerMovetwo = true;

	   }
           break;



           case ',' :

	   if (playthree)
	   {

	   Console.SetCursorPosition(6, 5); if (circlE == false) { Console.Write("X"); } 
	   else { Console.Write("O"); }
           playthree = false;  loopcontroL = false; playerMovethree = true;

	   }
           break;



	   case 'i' : 

	   if (playfour)
           {

	   Console.SetCursorPosition(4, 1); if (circlE == false) { Console.Write("X"); } 
	   else { Console.Write("O"); }
           playfour = false;  loopcontroL = false; playerMovefour = true;

	   }
	   break;



	   case 'k' :  

	   if (playfive)
           {

	   Console.SetCursorPosition(4, 3); if (circlE == false) {Console.Write("X"); } 
	   else { Console.Write("O"); }
           playfive = false;  loopcontroL = false; playerMovefive = true;

	   }
	   break;



	   case 'm' : 
	   
	   if (playsix)
           {

	   Console.SetCursorPosition(4, 5); if (circlE == false) {Console.Write("X"); } 
	   else { Console.Write("O"); }
           playsix = false;  loopcontroL = false; playerMovesix = true;

	   }
	   break;



	   case 'u' : 

	   if (playseven)
           {

	   Console.SetCursorPosition(2, 1); if (circlE == false) { Console.Write("X"); } 
	   else { Console.Write("O"); }
           playseven = false;  loopcontroL = false; playerMoveseven = true;

	   }
	   break;



	   case 'j' : 

	   if (playeight)
           {

	   Console.SetCursorPosition(2, 3); if (circlE == false) { Console.Write("X"); } 
	   else { Console.Write("O"); }
           playeight = false;  loopcontroL = false; playerMoveeight = true;

	   }
	   break;



	   case 'n' : 

	   if (playnine)
           {

	   Console.SetCursorPosition(2, 5); if (circlE == false) { Console.Write("X"); } 
	   else { Console.Write("O"); }
           playnine = false;  loopcontroL = false; playerMovenine = true;
	   
	   }
	   break;



           case 'q' : Console.ForegroundColor = ConsoleColor.White; closE = true; loopcontroL = false;
           Console.SetCursorPosition(0,10);
           break;

           default : loopcontroL = true;
           break;

	}     
     }
   }

   

   static void AI()
   {

//THESE 'ifs' ARE HERE TO FIX A BUG

    if
   (

    playone == true || playtwo == true || playthree == true || playfour == true || playfive == true| playsix == true || 
    playseven == true || playeight == true || playnine == true

   )

 {

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    randomINT = new Random().Next(1, 10);


     if (playerMoveone == true && playerMovetwo == true) { randomINT = 3; } else { }
     if (playerMoveone == true && playerMovethree == true) { randomINT = 2; } else { } 
     if (playerMovetwo == true && playerMovethree  == true) { randomINT = 1; } else { }
     //PATTERN 1 AI
     
     

     if (playerMovefour == true && playerMovefive == true) { randomINT = 6; } else { }
     if (playerMovefour == true && playerMovesix == true) { randomINT = 5; } else { }
     if (playerMovefive == true && playerMovesix == true) { randomINT = 4; } else { }
     //PATTERN 2 AI
   
    
     
     if (playerMoveseven == true && playerMoveeight == true) { randomINT = 9; } else {}
     if (playerMoveseven == true && playerMovenine == true) { randomINT = 8; } else { }
     if (playerMoveeight == true && playerMoveseven == true) { randomINT = 7; } else { }
     //PATTERN 3 AI
   
    
     
     if (playerMovethree == true && playerMovesix == true) { randomINT = 9; } else { }
     if (playerMovethree == true && playerMovenine == true) { randomINT = 6; } else { }
     if (playerMovesix == true && playerMovenine == true) { randomINT = 3; } else { }
     //PATTERN 4 AI
     
     
     
     if (playerMovetwo == true && playerMovefive == true) { randomINT = 8; } else { }
     if (playerMovetwo == true && playerMoveeight == true) { randomINT = 5; } else { }
     if (playerMovefive == true && playerMoveeight == true) { randomINT = 2; } else {randomINT = new Random().Next(1, 10);}
     //PATTERN 5 AI
     
     
     
     if (playerMoveone == true && playerMovefour == true) { randomINT = 7; } else { }
     if (playerMoveone == true && playerMoveseven == true) { randomINT = 4; } else { }
     if (playerMovefour == true && playerMoveseven == true) { randomINT = 1; } else { }
     //PATTERN 6 AI
     
     
     
     if (playerMoveone == true && playerMovefive == true) { randomINT = 9; } else { }
     if (playerMoveone == true && playerMovenine == true) { randomINT = 5; } else { }
     if (playerMovefive == true && playerMovenine == true) { randomINT = 1; } else { }
     //PATTERN 7 AI
     
     
     
     if (playerMovethree == true && playerMovefive == true) { randomINT = 7; } else { }
     if (playerMovethree == true && playerMoveseven == true) { randomINT = 5; } else { }
     if (playerMovefive == true && playerMoveseven == true) { randomINT = 3; } else { }
     //PATTERN 8 AI
     
     
     

     if (aiMoveone == true && aiMovetwo == true) { randomINT = 3; }
     if (aiMoveone == true && aiMovethree == true) { randomINT = 2; }
     if (aiMovetwo == true && aiMovethree == true) { randomINT = 1; }
     //PATTERN 1 AI ATTACK



     if (aiMovefour == true && aiMovefive == true) { randomINT = 6; }
     if (aiMovefour == true && aiMovesix == true) { randomINT = 5; }
     if (aiMovefive == true && aiMovesix == true) { randomINT = 4; }
     //PATTERN 2 AI ATTACK
     
     
     
     if (aiMoveseven == true && aiMoveeight == true) { randomINT = 9; }
     if (aiMoveseven == true && aiMovenine == true) { randomINT = 8; }
     if (aiMoveeight == true && aiMovenine == true) { randomINT = 7; }
     //PATTERN 3 AI ATTACK
     
     
     if (aiMovethree == true && aiMovesix == true) { randomINT = 9; }
     if (aiMovethree == true && aiMovenine == true) { randomINT = 6; }
     if (aiMovesix == true && aiMovenine == true) { randomINT = 3; }
     //PATTERN 4 AI ATTACK
     
     
     
     if (aiMovetwo == true && aiMovefive == true) { randomINT = 8; }
     if (aiMovetwo == true && aiMoveeight == true) { randomINT = 5; }
     if (aiMovefive == true && aiMoveeight == true) { randomINT = 2; }
     //PATTERN 5 AI ATTACK
     
     
     
     if (aiMoveone == true && aiMovefour == true) { randomINT = 7; }
     if (aiMoveone == true && aiMoveseven == true) { randomINT = 4; }
     if (aiMovefour == true && aiMoveseven == true) { randomINT = 1; }
     //PATTERN 6 AI ATTACK
     
     
     
     if (aiMoveone == true && aiMovefive == true) { randomINT = 9; }
     if (aiMoveone == true && aiMovenine == true) { randomINT = 5; }
     if (aiMovefive == true && aiMovenine == true) { randomINT = 1; }
     //PATTERN 7 AI ATTACK
     
     
     
     if (aiMovethree == true && aiMovefive == true) { randomINT = 7; }
     if (aiMovethree == true && aiMoveseven == true) { randomINT = 5; }
     if (aiMovefive == true && aiMoveseven == true) { randomINT = 3; }
     


 }

   }




   static void Bot()
   { 

   AI();

   if
   (

    playone == true || playtwo == true || playthree == true || playfour == true || playfive == true| playsix == true || 
    playseven == true || playeight == true || playnine == true

   )

   {
     BotSwitch();
   }

 }



   static void BotSwitch()
   {
       switch(randomINT)
       {
          case 1 : if (playone && aiMoveone == false)
	  {

	  Console.SetCursorPosition(6, 1); if (circlE == true) { Console.Write("X"); }
          else { Console.Write("O"); }  Thread.Sleep(1000);
	  playone = false; aiMoveone = true;

	  }

          else { randomINT = new Random().Next(1, 10); BotSwitch(); }
	  break;


	  case 2 : if (playtwo && aiMovetwo == false)
          {
	  
	  Console.SetCursorPosition(6, 3); if (circlE == true) { Console.Write("X"); } 
          else { Console.Write("O"); } Thread.Sleep(1000);
	  playtwo = false; aiMovetwo = true;

	  }
          else {  randomINT = new Random().Next(1, 10);  BotSwitch(); }
	  break;


	  case 3 : if (playthree && aiMovethree == false)
          {
	  
	  Console.SetCursorPosition(6, 5); if (circlE == true) { Console.Write("X"); }
          else { Console.Write("O"); } Thread.Sleep(1000);
	  playthree = false; aiMovethree = true;

	  }
	  else {  randomINT = new Random().Next(1, 10);  BotSwitch(); }
	  break;


	  case 4 : if (playfour && aiMovefour == false)
          {
	  
	  Console.SetCursorPosition(4, 1); if (circlE == true) { Console.Write("X"); }
	  else { Console.Write("O"); } Thread.Sleep(1000);
	  playfour = false; aiMovefour = true;

	  }
	  else {  randomINT = new Random().Next(1, 10);  BotSwitch(); }
	  break;


	  case 5 : if (playfive && aiMovefive == false)
          {

	    Console.SetCursorPosition(4, 3); if (circlE == true) { Console.Write("X"); }
	    else { Console.Write("O"); }  Thread.Sleep(1000);
	    playfive = false; aiMovefive = true;

          }
          else {   randomINT = new Random().Next(1, 10); BotSwitch();  }
          break;


	  case 6 : if (playsix && aiMovesix == false)
          {

             Console.SetCursorPosition(4, 5); if (circlE == true) {Console.Write("X"); } 
	     else { Console.Write("O"); } Thread.Sleep(1000);
	     playsix = false; aiMovesix = true;

          }
	  else {   randomINT = new Random().Next(1, 10); BotSwitch(); }
	  break;

	  
	  case 7 : if (playseven && aiMoveseven == false)
          {

             Console.SetCursorPosition(2, 1); if (circlE == true) { Console.Write("X"); } 
	     else { Console.Write("O"); } Thread.Sleep(1000);
	     playseven = false; aiMoveseven = true;

          }
          else {   randomINT = new Random().Next(1, 10); BotSwitch(); }
          break;


	  case 8 : if (playeight && aiMoveeight == false)
          {

             Console.SetCursorPosition(2, 3); if (circlE == true) { Console.Write("X"); } 
	     else { Console.Write("O"); } Thread.Sleep(1000);
	     playeight = false;  aiMoveeight = true;

          }
	  else {   randomINT = new Random().Next(1, 10); BotSwitch(); }
          break;

          case 9 : if (playnine && aiMovenine == false)
          {

             Console.SetCursorPosition(2, 5); if (circlE == true) { Console.Write("X"); } 
	     else { Console.Write("O"); } Thread.Sleep(1000);
	     playnine = false;  aiMovenine = true;

          }

          else {   randomINT = new Random().Next(1, 10); BotSwitch(); }
          break;


       }

   }


   static void WinningCheck()
   {

      if
      (
      playone == false && playtwo == false && playthree == false &&
      playerMoveone == true && playerMovetwo == true && playerMovethree == true
      )
 
      {

        Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMoveone = false; playerMovetwo = false; playerMovethree = false;

	loopLoop = false; Loop();
      } //PATTERN 1

      if
      (
         playfour == false && playfive == false && playsix == false  &&
	 playerMovefour == true && playerMovefive == true && playerMovesix == true
      )

      {
        Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMovefour = false; playerMovefive = false; playerMovesix = false;

	 Loop();
      } //PATTERN 2



      if
      (
         playseven == false && playeight == false && playnine == false  &&
	 playerMoveseven == true && playerMoveeight == true && playerMovenine
      )
 
      {
         Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMoveseven = false; playerMoveeight = false; playerMovenine = false;

	 Loop();        
      } //PATTERN 3


 

      if
      (
          playthree == false && playsix == false && playnine == false  &&
	  playerMovethree == true && playerMovesix == true && playerMovenine == true
      )
      
      {
          Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMovethree = false; playerMovesix = false; playerMovenine = false;

	 Loop();
      } //PATTERN 4




      if
      (
         playtwo == false && playfive == false && playeight == false  &&
	 playerMovetwo == true && playerMovefive == true && playerMoveeight == true
      )

      {
        Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMovetwo = false; playerMovefive = false; playerMoveeight = false;

	 Loop();        
      } //PATTERN 5



      if
      (
         playone == false && playfour == false && playseven == false  &&
	 playerMoveone == true && playerMovefour == true && playerMoveseven == true
      )
     
      {
        Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMoveone = false; playerMovefour = false; playerMoveseven = false;

	 Loop();
      } //PATTERN 6



      if
      (
         playone == false && playfive == false && playnine == false  &&
	 playerMoveone == true && playerMovefive == true && playerMovenine == true
      )

      { 

	Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMoveone = false; playerMovefive = false; playerMovenine = false;

	Loop();
      } //PATTERN 7




      if
      (
          playthree == false &&  playfive == false && playseven == false  &&
	  playerMovethree == true && playerMovefive == true && playerMoveseven == true
      )

      {
	Console.Clear(); Console.WriteLine("WINNN!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	playerMovethree = false; playerMovefive = false; playerMoveseven = false;

	Loop();
      } //PATTERN 8

   }




   static void LosingCheck()
   {

      if
      (
      playone == false && playtwo == false && playthree == false &&
      aiMoveone == true && aiMovetwo == true && aiMovethree == true
      )
 
      {
        Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMoveone = false; aiMovetwo = false; aiMovethree = false;

	loopLoop = false; Loop();
      } //PATTERN 1

      if
      (
         playfour == false && playfive == false && playsix == false  &&
	 aiMovefour == true && aiMovefive == true && aiMovesix == true
      )

      {
        Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMovefour = false; aiMovefive = false; aiMovesix = false;

	 Loop();
      } //PATTERN 2



      if
      (
         playseven == false && playeight == false && playnine == false  &&
	 aiMoveseven == true && aiMoveeight == true && aiMovenine
      )
 
      {
         Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMoveseven = false; aiMoveeight = false; aiMovenine = false;

	 Loop();        
      } //PATTERN 3


 

      if
      (
          playthree == false && playsix == false && playnine == false  &&
	  aiMovethree == true && aiMovesix == true && aiMovenine == true
      )
      
      {
          Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false; 
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMovethree = false; aiMovesix = false; aiMovenine = false;

	 Loop();
      } //PATTERN 4




      if
      (
         playtwo == false && playfive == false && playeight == false  &&
	 aiMovetwo == true && aiMovefive == true && aiMoveeight == true
      )

      {
        Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = true;

	aiMovetwo = false; aiMovefive = false; aiMoveeight = false;

	 Loop();        
      } //PATTERN 5



      if
      (
         playone == false && playfour == false && playseven == false  &&
	 aiMoveone == true && aiMovefour == true && aiMoveseven == true
      )
     
      {
        Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMoveone = false; aiMovefour = false; aiMoveseven = false;

	 Loop();
      } //PATTERN 6



      if
      (
         playone == false && playfive == false && playnine == false  &&
	 aiMoveone == true && aiMovefive == true && aiMovenine == true
      )

      { 

	Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMoveone = false; aiMovefive = false; aiMovenine = false;

	Loop();
      } //PATTERN 7




      if
      (
          playthree == false &&  playfive == false && playseven == false  &&
	  aiMovethree == true && aiMovefive == true && aiMoveseven == true
      )

      {
	Console.Clear(); Console.WriteLine("LOSE!!!");  Thread.Sleep(2100);

	playone = false; playtwo = false; playthree = false; playfour = false;
	playfive = false; playfive = false; playsix = false; playseven = false;
	playeight = false; playnine = false;

	aiMovethree = false; aiMovefive = false; aiMoveseven = false;

	Loop();
      } //PATTERN 8

   }



   static void Loop()
   {

    if
    (

      playone == false && playtwo == false && playthree == false && playfour == false &&
      playfive == false && playsix == false && playseven == false && playeight == false && playnine == false

    )
     

    { 

      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.SetCursorPosition(0, 6);
      Console.WriteLine("Do you want to play again? Y / N"); 

  loopLoop = true;

   while(loopLoop == true)
   {

      switch (Console.ReadKey(true).KeyChar)
      {
	 case 'y' :  playone = true; playtwo = true; playthree = true;
         playfour = true; playfive = true; playsix = true;
         playseven = true; playeight = true; playnine = true; 

	 playerMoveone = false; playerMovetwo = false; playerMovethree = false;
	 playerMovefour = false; playerMovefive = false; playerMovesix = false;
	 playerMoveseven = false; playerMoveeight = false; playerMovenine = false;

	 aiMoveone = false; aiMovetwo = false; aiMovethree = false; aiMovefour = false;
	 aiMovefive = false; aiMovesix = false; aiMoveseven = false; aiMoveeight = false; aiMovenine = false;
	 
	 Main(); loopLoop = false;
	 //RESETS THE GAME
         break;

         case 'n' : Console.ForegroundColor = ConsoleColor.White; closE = true; loopLoop = false;
         break;

         default : loopLoop = true;
         break;
      }

    }
   }

           Controls();
           Bot();
  }
}
