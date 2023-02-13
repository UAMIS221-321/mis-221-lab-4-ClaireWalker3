// start main
int userChoice = GetUserChoice();
while(userChoice!=3){
    RouteEm(userChoice);
    userChoice = GetUserChoice();
    Console.Clear();
}
// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    System.Console.WriteLine("Enter 1 for full triangle \n Enter 2 for partial triangle \n Enter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput=="1" || userInput=="2" || userInput=="3") {
        return true;
    }
    return false;
}

static void GetFull() {
    Random rnd = new Random();
    int Size = rnd.Next(3,10);
    for(int i = 0; i <= Size; i++) {
        for(int j = 0; j < i; j++){
            Console.Write("o");
        }
        System.Console.WriteLine();


    }
    //PauseAction();
}
   

    
static void GetPartial() {
    Random rnd = new Random();
    int Size = rnd.Next(3,10);
    int number = rnd.Next(2); 
    for(int i = 0; i <= Size; i++) {
        for(int j = 0; j < i; j++) {
            number = rnd.Next(2);
            if(number == 0)
            {
                Console.Write("o");
            }
            
            else if(number == 1) 
            {
                Console.Write(" ");
            }

        }
        System.Console.WriteLine();
        
    //PauseAction();
    }
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    //PauseAction();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2) {
       GetPartial(); 
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
}