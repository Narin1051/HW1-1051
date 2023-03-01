class Program{
    static void Main (string[] args){
         
        Console.WriteLine ("Plz enter your Number");
        float number = float.Parse(Console.ReadLine());

        float firstDigit = number % 10 ;
        float secondDigit = (number % 100 - firstDigit) ;
        float thirdDigit = (number % 1000 - secondDigit - firstDigit);
        float fourthDigit = (number % 10000 -thirdDigit -secondDigit - firstDigit) ;
        float fifthiDigit = (number % 100000 -fourthDigit -thirdDigit -secondDigit - firstDigit) ;
        float sixthDigit = (number % 1000000 - fifthiDigit - fourthDigit -thirdDigit -secondDigit - firstDigit);
            
            float _firstDigit = firstDigit / 1;
            float _secondDigit = secondDigit / 10 ;
            float _thirdDigit = thirdDigit / 100;
            float _fourthDigit = fourthDigit / 1000 ;
            float _fifthiDigit = fifthiDigit / 10000 ;
            float _sixthDigit = sixthDigit / 100000 ;

        if (number / 100000 < 10 && number / 100000 > 1){

            Console.WriteLine ("Plz enter your Agency");
            string agency = Console.ReadLine();

            

                if ((agency == "CIA") && 
                ((_firstDigit %3 == 0) && 
                (_secondDigit !=1 && _secondDigit !=3 && _secondDigit != 5) && 
                (_fourthDigit >= 6 && _fourthDigit != 8))){
            
                Console.WriteLine("True");

                }

                else if ((agency == "FBI") && (_sixthDigit >= 4 && _sixthDigit <= 7) && 
                (_thirdDigit % 2 == 0 &&_thirdDigit != 6) && 
                (_fifthiDigit % 2 != 0)){
            
                Console.WriteLine("True");

                }

                else if ((agency == "NSA") &&
                (30 % _firstDigit == 0 ) && 
                (_thirdDigit % 3 == 0 && _thirdDigit % 2 != 0) && 
            (_firstDigit == 7 || _secondDigit == 7 || _thirdDigit == 7 || _fourthDigit == 7 || _fifthiDigit == 7 || _sixthDigit == 7 )){
            
                Console.WriteLine("True");

                }else{
                    
                    Console.WriteLine("Flase");

                }


            } else {

            Console.WriteLine("Flase");
        }

        
    }
}