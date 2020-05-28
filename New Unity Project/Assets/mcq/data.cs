using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class data : MonoBehaviour
{
    public GameObject Test;
    public GameObject Menu;
    public GameObject ScoreScreen;
    
    public static string[] dataset = new string[26];
    public static string[] A = new string[26];
    public static string[] B = new string[26];
    public static string[] C = new string[26];
    public static string[] D = new string[26];
    public static int[] check = new int[26];
    public static int marks = 0;
    public List<int> randomList = new List<int>();

    public Text Score_UIText;
    public Text Score_A;
    public Text Score_B;
    public Text Score_C;
    public Text Score_D;
    public static int counter = 0;
    int index;
    int temp;
    int roo;

    void Start()
    {
        dataset[0] = "What relation is your neice's brother to you ?";
        A[0] = "Son";
        B[0] = "Uncle";
        C[0] = "cousin";
        D[0] = "nephew";

        dataset[1] = "how many birthdays does the average man have ?";
        A[1] = "1";
        B[1] = "10";
        C[1] = "65";
        D[1] = "70";

        dataset[2] = "Some months have 31 days;how many have 28?";
        A[2] = "1";
        B[2] = "2";
        C[2] = "3";
        D[2] = "9";

        dataset[3] = "Devide 30 by 1/2 and add 10.What is the answer?";
        A[3] = "10";
        B[3] = "25";
        C[3] = "50";
        D[3] = "70";

        dataset[4] = "If there are 3 apples and you take 2 away, how many do you have?";
        A[4] = "1";
        B[4] = "2";
        C[4] = "3";
        D[4] = "5";

        dataset[5] = "A doctor gives you three pills telling you to take one every hour. How many minutes will the pills last?";
        A[5] = "20";
        B[5] = "40";
        C[5] = "60";
        D[5] = "80";

        dataset[6] = "A farmer has 17 sheep, and all but 9 die. How many are left?";
        A[6] = "1";
        B[6] = "3";
        C[6] = "5";
        D[6] = "8";

        dataset[7] = "You are participating in a race. you overtake the 2nd person. What position are you in?";
        A[7] = "1st";
        B[7] = "2nd";
        C[7] = "3rd";
        D[7] = "4rth";

        dataset[8] = "Take 1000 and add 40 to it.Now add another1000.Now add 30.Add another 1000.Now add 20. Now add another1000. Now add 10. What is the total? ";
        A[8] = "5000";
        B[8] = "51000";
        C[8] = "4000";
        D[8] = "4100";

        dataset[9] = "Please enter the missing number: 3,4,8,17,33?";
        A[9] = "50";
        B[9] = "68";
        C[9] = "60";
        D[9] = "79";

        dataset[10] = "Please enter the missing number: 4,5,8,15,44?";
        A[10] = "34";
        B[10] = "88";
        C[10] = "32";
        D[10] = "125";

        dataset[11] = "One word in the list doesn,t belong to the same group: Receiver,Reviver,Recacer,Radar.";
        A[11] = "Receiver";
        B[11] = "Reviver";
        C[11] = "Rececar";
        D[11] = "Radar";

        dataset[12] = "A spy is trying to send a secret message, we,re trying to decode this message, we need your help!" +
            "if (shnoppy droppy groppy) means (mission dangerously executed)" +
            "And (swappy trappy droppy) means (abort mission immediately)" +
            "And (drippy groppy wippy) means (plan executed successfully) then what does snoppy means";
        A[12] = "mission";
        B[12] = "dangerously";
        C[12] = "executed";
        D[12] = "abort";
        
        dataset[13] = "Finish the sentence, Gym is to Healthy as Book is to?";
        A[13] = "Good";
        B[13] = "Intelligent";
        C[13] = "Fluent";
        D[13] = "Knowlegeable";

        dataset[14] = "please enter the missing number:2,9,20,37,64,107?";
        A[14] = "-107";
        B[14] = "107";
        C[14] = "173";
        D[14] = "3764";

        dataset[15] = "A UFO was detected on the Radar flying 7400 miles in 3 min, what is the estimated speed per hour?";
        A[15] = "7400 miles/h";
        B[15] = "1480 miles/h";
        C[15] = "14080 miles/h";
        D[15] = "14000 miles/h";

        dataset[16] = "There are 12 pens on the table, You took 3, how many do you have?";
        A[16] = "6";
        B[16] = "7";
        C[16] = "0";
        D[16] = "3";

        dataset[17] = "One word in this list doesn't belong to the same group: Yen, Pound, Franc, Penny, Mark.";
        A[17] = "Yen";
        B[17] = "Pound";
        C[17] = "Franc";
        D[17] = "Mark";

        dataset[18] = "I'm a male. If Albert,s son is my son's father, What is realationship between Albert and me?";
        A[18] = "he is my brother";
        B[18] = "he is my uncle";
        C[18] = "he is my father";
        D[18] = "he is my sister";

        dataset[19] = "How many 2 cent stamps are there in a dozen?";
        A[19] = "1";
        B[19] = "3";
        C[19] = "6";
        D[19] = "12";

        dataset[20] = "How many animal of each sex did Moses take on the ark?";
        A[20] = "3";
        B[20] = "2";
        C[20] = "1";
        D[20] = "0";

        dataset[21] = "A doctor gives you 3 pills telling you to take one every hour. How many minutes will the pills last?";
        A[21] = "20";
        B[21] = "40";
        C[21] = "60";
        D[21] = "80";

        dataset[22] = "Mary's father has 5 daughters: 1.Nana, 2.Nene, 3.Nini, 4.Nono. what is the name of the fifth daughter?";
        A[22] = "Neno";
        B[22] = "Mary";
        C[22] = "Nunu";
        D[22] = "Nani";

        dataset[23] = "Please enter the missing number; 3,6,18,72,?";
        A[23] = "144";
        B[23] = "214";
        C[23] = "372";
        D[23] = "360";

        dataset[24] = "Please enter the missing number: 4,5,8,17,44, ?";
        A[25] = "34";
        B[25] = "88";
        C[25] = "32";
        D[25] = "125";

        callData();
    
    }

    void Update()
    {
        if (AA.mcq == 'A')
        {
            if (index == 1 || index == 2 || index == 4 || index == 9 || index == 11 || index == 7 || index == 12 || index == 15) {
                Debug.Log("marks A ");
                marks++;
            }

            Debug.Log("A is pressed ");
            AA.mcq = 'E';
            callData();

        }

        if (AA.mcq == 'D')
        {
            if (index == 0 || index == 3 || index == 6 || index == 8 || index == 10 || index ==14 || index ==13 || index == 16 || index == 17 || index == 19 || index == 20 || index == 23 || index == 24)
            {
                Debug.Log("marks B ");
                marks++;
            }
            Debug.Log("B is pressed ");
            AA.mcq = 'E';
            callData();
        }

        if (AA.mcq == 'C')
        {
            if (index == 5 || index == 18 || index == 21 )
            {
                Debug.Log("marks C ");
                marks++;
            }
            Debug.Log("C is pressed ");
            AA.mcq = 'E';
            callData();
        }

        if (AA.mcq == 'B')
        {
            if (index == 22 )
            {
                Debug.Log("marks B ");
                marks++;
            }
            Debug.Log("B is pressed ");
            AA.mcq = 'E';
            callData();
        }
    }
    public void callData()
    {
  
        if (counter <= 10)
        {


          System.Random random = new System.Random();
          index = random.Next(0, 25);
            if (randomList.Contains(index))
            {
                callData();
            }
            if (!randomList.Contains(index)){
                randomList.Add(index);
                getData();
            }
            //  for (int i = 0; i < check.Length; i++)
            // {
            //    temp = i;
            //     if (check[i] == index)
            //      {
            //break;
           
            
            //     }
            //   }
            //  if (check[temp] == index)
            // {
            //      callData();
            //  }
            //Debug.Log(roo);
            //check[roo] = index;
            //Debug.Log(roo);
            //roo++;
            //Debug.Log(roo);
            
        }
        else
        {
          Test.active = false;
          ScoreScreen.active = true;
          Debug.Log("score is :" + marks);
        }
    }
    public void getData()
    {
        counter++;
        Score_UIText.text = dataset[index];
        Score_A.text = A[index];
        Score_B.text = B[index];
        Score_C.text = C[index];
        Score_D.text = D[index];
    }
}
