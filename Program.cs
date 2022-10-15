using System;
using System.IO;

public class progam
{
    public static void Main (){
        FileStream filestream = new FileStream("myfile.txt", FileMode.Create);
        var streamwriter = new StreamWriter(filestream);
        streamwriter.AutoFlush = true;
       Console.SetOut(streamwriter);
       
    
        double cont;
        int i;
        int j;
        double[,] matrix = new double[10,10];
       
        cont = 0;

        for (i=1;i<=10;i++) {

            matrix[0,i-1] = cont;
            matrix[i-1,0] = cont;
            cont = cont+1;
    }
        for (i=2;i<=10;i++) {
             for (j=2;j<=10;j++) {
                 matrix[i-1,j-1] =  matrix[i-1,0]*matrix[0,j-1];
       }
    }   
       for (i=1;i<=10;i++) {
             for (j=1;j<=10;j++) {
                Console.Write(matrix[i-1,j-1]+" ");
       }
       Console.WriteLine(" ");
    }
 
    }

}
