using static System.Console;

int[][] jagetArray = new int[24][];  //Comment for commit

Random r = new Random();        //Next comment for commit 

int count = 0;                  //Git pull))) 3 comment for commit

for (int i = 0; i < jagetArray.Length; i++) // цикл заполненя зубчатого массива
{
    jagetArray[i] = (i > 9 && i < 21) ? new int[12] : new int[4];
}

for (int i = 0; i < jagetArray.Length; i++)
{
    count++;
    
    Write($"{count}:");
    
    for (int j = 0; j < jagetArray[i].Length; j++)
    {
        jagetArray[i][j] = r.Next(20);
        Write($"{jagetArray[i][j]} ");
    }
    WriteLine();
}

ReadLine();