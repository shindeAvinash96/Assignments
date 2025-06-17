using System;

public class SpaceInSentence{

      public  static void Main(string[] args)
        {


            String name = "My name is avinash";


            int length = name.Length;
            int spaces=0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ') 
                {
                    spaces++;

                }
            }

            Console.WriteLine("Number of spaces: "+spaces);




        }
      }
  
