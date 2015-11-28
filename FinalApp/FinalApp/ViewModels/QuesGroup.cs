using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.ViewModels
{
    public class QuesGroup
    {
        public static QuesData CreateNumbersQuestion(int ctr)
        {

            QuesData temp = new QuesData();
            int flag = 0;

            switch (ctr)
            {
                case 1:
                    {
                        flag = 1;
                        temp.Question = "The difference between the palce value and face value of 6 in the numeral 856973 is ?";
                        temp.Option1 = "973";
                        temp.Option2 = "6973";
                        temp.Option3 = "5994";
                        temp.Option4 = "none of these";
                        temp.Id = 1;
                        temp.Answer = 3;
                        break;
                    }
                case 2:
                    {
                        flag = 1;
                        temp.Question = "7589 - ? = 3434";
                        temp.Option1 = "4242";
                        temp.Option2 = "4155";
                        temp.Option3 = "1123";
                        temp.Option4 = "11023";
                        temp.Id = 2;
                        temp.Answer = 2;
                        break;
                    }
            }

            if (flag == 0)
                return null;
            else
                return temp;
        }
        public static QuesData CreateHCFandLCMQuestion(int ctr)
        {

            QuesData temp = new QuesData();
            int flag = 0;

            switch (ctr)
            {

                case 1:
                    {
                        flag = 1;
                        temp.Question = "Find the greatest number that will divide 43, 91 and 183 so as to leave the same remainder in each case.";
                        temp.Option1 = "4";
                        temp.Option2 = "7";
                        temp.Option3 = "9";
                        temp.Option4 = "13";
                        temp.Id = 1;
                        temp.Hint = "Required number = H.C.F. of (91 - 43), (183 - 91) and (183 - 43) = H.C.F. of 48, 92 and 140 = 4.";
                        temp.Answer = 1;
                        break;
                    }
                case 2:
                    {
                        flag = 1;
                        temp.Question = "The H.C.F. of two numbers is 23 and the other two factors of their L.C.M. are 13 and 14. The larger of the two numbers is:";
                        temp.Option1 = "276";
                        temp.Option2 = "299";
                        temp.Option3 = "322";
                        temp.Option4 = "345";
                        temp.Id = 2;
                        temp.Hint = "Clearly, the numbers are (23 x 13) and (23 x 14).	Larger number = (23 x 14) = 322.";
                        temp.Answer = 3;
                        break;
                    }

                case 3:
                    {
                        flag = 1;
                        temp.Question = "Six bells commence tolling together and toll at intervals of 2, 4, 6, 8 10 and 12 seconds respectively. In 30 minutes, how many times do they toll together ?";
                        temp.Option1 = "4";
                        temp.Option2 = "10";
                        temp.Option3 = "15";
                        temp.Option4 = "16";
                        temp.Id = 3;
                        temp.Hint = "L.C.M. of 2, 4, 6, 8, 10, 12 is 120.		So, the bells will toll together after every 120 seconds(2 minutes).	In 30 minutes, they will toll together	30/2 + 1 = 16 times.";
                        temp.Answer = 4;
                        break;
                    }
                case 4:
                    {
                        flag = 1;
                        temp.Question = "Let N be the greatest number that will divide 1305, 4665 and 6905, leaving the same remainder in each case. Then sum of the digits in N is:";
                        temp.Option1 = "4";
                        temp.Option2 = "5";
                        temp.Option3 = "6";
                        temp.Option4 = "18";
                        temp.Id = 4;
                        temp.Hint = "N = H.C.F. of (4665 - 1305), (6905 - 4665) and (6905 - 1305) = H.C.F. of 3360, 2240 and 5600 = 1120. Sum of digits in N = ( 1 + 1 + 2 + 0 ) = 4";
                        temp.Answer = 1;
                        break;
                    }
                case 5:
                    {
                        flag = 1;
                        temp.Question = "The greatest number of four digits which is divisible by 15, 25, 40 and 75 is:";
                        temp.Option1 = "9000";
                        temp.Option2 = "9400";
                        temp.Option3 = "9600";
                        temp.Option4 = "9800";
                        temp.Id = 5;
                        temp.Hint = "Greatest number of 4-digits is 9999.		L.C.M. of 15, 25, 40 and 75 is 600.	On dividing 9999 by 600, the remainder is 399.		Required number (9999 - 399) = 9600.";
                        temp.Answer = 3;
                        break;
                    }

                case 6:
                    {
                        flag = 1;
                        temp.Question = "The product of two numbers is 4107. If the H.C.F. of these numbers is 37, then the greater number is:";
                        temp.Option1 = "101";
                        temp.Option2 = "107";
                        temp.Option3 = "111";
                        temp.Option4 = "185";
                        temp.Id = 6;
                        temp.Hint = "Let the numbers be 37a and 37b.	Then, 37a x 37b = 4107		ab = 3.		Now, co-primes with product 3 are (1, 3).	So, the required numbers are (37 x 1, 37 x 3) i.e., (37, 111).	Thus Greater number = 111.";
                        temp.Answer = 3;
                        break;
                    }
                case 7:
                    {
                        flag = 1;
                        temp.Question = "Three number are in the ratio of 3 : 4 : 5 and their L.C.M. is 2400. Their H.C.F. is:";
                        temp.Option1 = "40";
                        temp.Option2 = "80";
                        temp.Option3 = "120";
                        temp.Option4 = "200";
                        temp.Id = 7;
                        temp.Hint = "Let the numbers be 3x, 4x and 5x.	Then, their L.C.M. = 60x.	So, 60x = 2400 or x = 40.	The numbers are (3 x 40), (4 x 40) and (5 x 40).	Hence, required H.C.F. = 40.";
                        temp.Answer = 1;
                        break;
                    }
                case 8:
                    {
                        flag = 1;
                        temp.Question = "The G.C.D. of 1.08, 0.36 and 0.9 is:";
                        temp.Option1 = "0.03";
                        temp.Option2 = "0.9";
                        temp.Option3 = "0.18";
                        temp.Option4 = "0.108";
                        temp.Id = 8;
                        temp.Hint = "Given numbers are 1.08, 0.36 and 0.90.   H.C.F. of 108, 36 and 90 is 18,	H.C.F. of given numbers = 0.18.";
                        temp.Answer = 3;
                        break;
                    }
                case 9:
                    {
                        flag = 1;
                        temp.Question = "The product of two numbers is 2028 and their H.C.F. is 13. The number of such pairs is:";
                        temp.Option1 = "1";
                        temp.Option2 = "2";
                        temp.Option3 = "3";
                        temp.Option4 = "4";
                        temp.Id = 9;
                        temp.Hint = "Let the numbers 13a and 13b.		Then, 13a x 13b = 2028		ab = 12.	Now, the co-primes with product 12 are (1, 12) and (3, 4).	[Note: Two integers a and b are said to be coprime or relatively prime if they have no common positive factor other than 1 or, equivalently, if their greatest common divisor is 1 ]	So, the required numbers are (13 x 1, 13 x 12) and (13 x 3, 13 x 4).	Clearly, there are 2 such pairs.";
                        temp.Answer = 2;
                        break;
                    }
                case 10:
                    {
                        flag = 1;
                        temp.Question = "The least multiple of 7, which leaves a remainder of 4, when divided by 6, 9, 15 and 18 is:";
                        temp.Option1 = "74";
                        temp.Option2 = "94";
                        temp.Option3 = "184";
                        temp.Option4 = "364";
                        temp.Id = 10;
                        temp.Hint = "L.C.M. of 6, 9, 15 and 18 is 90.	Let required number be 90k + 4, which is multiple of 7.		Least value of k for which (90k + 4) is divisible by 7 is k = 4.	Required number = (90 x 4) + 4   = 364.";
                        temp.Answer = 4;
                        break;
                    }
                case 11:
                    {
                        flag = 1;
                        temp.Question = "Find the lowest common multiple of 24, 36 and 40.";
                        temp.Option1 = "120";
                        temp.Option2 = "240";
                        temp.Option3 = "360";
                        temp.Option4 = "480";
                        temp.Id = 11;
                        temp.Hint = "L.C.M.  = 2 x 2 x 2 x 3 x 3 x 5 = 360";
                        temp.Answer = 3;
                        break;
                    }
                case 12:
                    {
                        flag = 1;
                        temp.Question = "The least number which should be added to 2497 so that the sum is exactly divisible by 5, 6, 4 and 3 is:";
                        temp.Option1 = "3";
                        temp.Option2 = "13";
                        temp.Option3 = "23";
                        temp.Option4 = "33";
                        temp.Id = 12;
                        temp.Hint = "L.C.M. of 5, 6, 4 and 3 = 60.	On dividing 2497 by 60, the remainder is 37.	Number to be added = (60 - 37) = 23.";
                        temp.Answer = 3;
                        break;
                    }
                case 13:
                    {
                        flag = 1;
                        temp.Question = "Reduce	128352 / 238368	to its lowest terms.";
                        temp.Option1 = "3/4";
                        temp.Option2 = "5/13";
                        temp.Option3 = "7/13";
                        temp.Option4 = "9/13";
                        temp.Id = 13;
                        temp.Hint = "128352/18336 = 7	238368 / 18336=13";
                        temp.Answer = 3;
                        break;
                    }
                case 14:
                    {
                        flag = 1;
                        temp.Question = "The least number which when divided by 5, 6 , 7 and 8 leaves a remainder 3, but when divided by 9 leaves no remainder, is:";
                        temp.Option1 = "1677";
                        temp.Option2 = "1683";
                        temp.Option3 = "2523";
                        temp.Option4 = "3363";
                        temp.Id = 14;
                        temp.Hint = "L.C.M. of 5, 6, 7, 8 = 840.		Required number is of the form 840k + 3		Least value of k for which (840k + 3) is divisible by 9 is k = 2.		Required number = (840 x 2 + 3) = 1683.";
                        temp.Answer = 2;
                        break;
                    }
                case 15:
                    {
                        flag = 1;
                        temp.Question = "A, B and C start at the same time in the same direction to run around a circular stadium. A completes a round in 252 seconds, B in 308 seconds and c in 198 seconds, all starting at the same point. After what time will they again at the starting point ?";
                        temp.Option1 = "26 minutes and 18 seconds";
                        temp.Option2 = "42 minutes and 36 seconds";
                        temp.Option3 = "45 minutes";
                        temp.Option4 = "46 minutes and 12 seconds";
                        temp.Id = 15;
                        temp.Hint = "L.C.M. of 252, 308 and 198 = 2772.So, A, B and C will again meet at the starting point in 2772 sec. i.e., 46 min. 12 sec.";
                        temp.Answer = 4;
                        break;
                    }
                case 16:
                    {
                        flag = 1;
                        temp.Question = "The H.C.F. of two numbers is 11 and their L.C.M. is 7700. If one of the numbers is 275, then the other is:";
                        temp.Option1 = "279";
                        temp.Option2 = "283";
                        temp.Option3 = "308";
                        temp.Option4 = "318";
                        temp.Id = 16;
                        temp.Hint = "other number =  (11*7700)/275 = 308";
                        temp.Answer = 3;
                        break;
                    }
                case 17:
                    {
                        flag = 1;
                        temp.Question = "What will be the least number which when doubled will be exactly divisible by 12, 18, 21 and 30 ?";
                        temp.Option1 = "196";
                        temp.Option2 = "630";
                        temp.Option3 = "1260";
                        temp.Option4 = "2520";
                        temp.Id = 17;
                        temp.Hint = "L.C.M. of 12, 18, 21 30 = 2 x 3 x 2 x 3 x 7 x 5 = 1260.  Required number = (1260 ÷ 2) = 630.";
                        temp.Answer = 2;
                        break;
                    }
                case 18:
                    {
                        flag = 1;
                        temp.Question = "The ratio of two numbers is 3 : 4 and their H.C.F. is 4. Their L.C.M. is:";
                        temp.Option1 = "12";
                        temp.Option2 = "16";
                        temp.Option3 = "24";
                        temp.Option4 = "48";
                        temp.Id = 18;
                        temp.Hint = "Let the numbers be 3x and 4x. Then, their H.C.F. = x. So, x = 4.	So, the numbers 12 and 16.	L.C.M. of 12 and 16 = 48.";
                        temp.Answer = 4;
                        break;
                    }
                case 19:
                    {
                        flag = 1;
                        temp.Question = "The smallest number which when diminished by 7, is divisible 12, 16, 18, 21 and 28 is:";
                        temp.Option1 = "1008";
                        temp.Option2 = "1015";
                        temp.Option3 = "1022";
                        temp.Option4 = "1032";
                        temp.Id = 19;
                        temp.Hint = "Required number = (L.C.M. of 12,16, 18, 21, 28) + 7 = 1008 + 7 = 1015";
                        temp.Answer = 2;
                        break;
                    }
                case 20:
                    {
                        flag = 1;
                        temp.Question = "252 can be expressed as a product of primes as:";
                        temp.Option1 = "2 x 2 x 3 x 3 x 7";
                        temp.Option2 = "2 x 2 x 2 x 3 x 7";
                        temp.Option3 = "3 x 3 x 3 x 3 x 7";
                        temp.Option4 = "2 x 3 x 3 x 3 x 7";
                        temp.Id = 20;
                        temp.Hint = "Clearly, 252 = 2 x 2 x 3 x 3 x 7.";
                        temp.Answer = 1;
                        break;
                    }
                case 21:
                    {
                        flag = 1;
                        temp.Question = "The greatest possible length which can be used to measure exactly the lengths 7 m, 3 m 85 cm, 12 m 95 cm is:";
                        temp.Option1 = "15 cm";
                        temp.Option2 = "25 cm";
                        temp.Option3 = "35 cm";
                        temp.Option4 = "42 cm";
                        temp.Id = 21;
                        temp.Hint = "Required length = H.C.F. of 700 cm, 385 cm and 1295 cm = 35 cm.";
                        temp.Answer = 3;
                        break;
                    }
                case 22:
                    {
                        flag = 1;
                        temp.Question = "Three numbers which are co-prime to each other are such that the product of the first two is 551 and that of the last two is 1073. The sum of the three numbers is:";
                        temp.Option1 = "75";
                        temp.Option2 = "81";
                        temp.Option3 = "85";
                        temp.Option4 = "89";
                        temp.Id = 22;
                        temp.Hint = "Since the numbers are co-prime, they contain only 1 as the common factor.	Also, the given two products have the middle number in common.	So, middle number = H.C.F. of 551 and 1073 = 29.  First number = 551/29=19     Third number = 1073/29 = 37	Required sum = (19 + 29 + 37) = 85.";
                        temp.Answer = 3;
                        break;
                    }
                case 23:
                    {
                        flag = 1;
                        temp.Question = "Find the highest common factor of 36 and 84.";
                        temp.Option1 = "4";
                        temp.Option2 = "6";
                        temp.Option3 = "12";
                        temp.Option4 = "18";
                        temp.Id = 23;
                        temp.Hint = "36 = 2^2 x 3^2 	84 = 2^2 x 3 x 7	H.C.F. = 2^2 x 3 = 12.";
                        temp.Answer = 3;
                        break;
                    }
                case 24:
                    {
                        flag = 1;
                        temp.Question = "Which of the following fraction is the largest ?";
                        temp.Option1 = "7/8";
                        temp.Option2 = "13/16";
                        temp.Option3 = "31/40";
                        temp.Option4 = "63/80";
                        temp.Id = 24;
                        temp.Hint = "L.C.M. of 8, 16, 40 and 80 = 80. Then compare.";
                        temp.Answer = 1;
                        break;
                    }
                case 25:
                    {
                        flag = 1;
                        temp.Question = "The least number, which when divided by 12, 15, 20 and 54 leaves in each case a remainder of 8 is:";
                        temp.Option1 = "504";
                        temp.Option2 = "536";
                        temp.Option3 = "544";
                        temp.Option4 = "548";
                        temp.Id = 25;
                        temp.Hint = "Required number = (L.C.M. of 12, 15, 20, 54) + 8 = 540 + 8 = 548.";
                        temp.Answer = 4;
                        break;
                    }
                case 26:
                    {
                        flag = 1;
                        temp.Question = "The greatest number which on dividing 1657 and 2037 leaves remainders 6 and 5 respectively, is:";
                        temp.Option1 = "123";
                        temp.Option2 = "127";
                        temp.Option3 = "235";
                        temp.Option4 = "305";
                        temp.Id = 26;
                        temp.Hint = "Required number = H.C.F. of (1657 - 6) and (2037 - 5) = H.C.F. of 1651 and 2032 = 127.";
                        temp.Answer = 2;
                        break;
                    }
                case 27:
                    {
                        flag = 1;
                        temp.Question = "Which of the following has the most number of divisors?";
                        temp.Option1 = "99";
                        temp.Option2 = "101";
                        temp.Option3 = "176";
                        temp.Option4 = "182";
                        temp.Id = 27;
                        temp.Hint = "99 = 1 x 3 x 3 x 11		101 = 1 x 101		176 = 1 x 2 x 2 x 2 x 2 x 11		182 = 1 x 2 x 7 x 13		So, divisors of 99 are 1, 3, 9, 11, 33, .99		Divisors of 101 are 1 and 101		Divisors of 176 are 1, 2, 4, 8, 11, 16, 22, 44, 88 and 176		Divisors of 182 are 1, 2, 7, 13, 14, 26, 91 and 182.		Hence, 176 has the most number of divisors.";
                        temp.Answer = 3;
                        break;
                    }
                case 28:
                    {
                        flag = 1;
                        temp.Question = "The L.C.M. of two numbers is 48. The numbers are in the ratio 2 : 3. Then sum of the number is:";
                        temp.Option1 = "28";
                        temp.Option2 = "32";
                        temp.Option3 = "40";
                        temp.Option4 = "64";
                        temp.Id = 28;
                        temp.Hint = "Let the numbers be 2x and 3x.	Then, their L.C.M. = 6x.	So, 6x = 48 or x = 8.		The numbers are 16 and 24.	Hence, required sum = (16 + 24) = 40.";
                        temp.Answer = 3;
                        break;
                    }
                case 29:
                    {
                        flag = 1;
                        temp.Question = "The HCF of 9/10 , 12/25 , 18/35 and 21/40 is :";
                        temp.Option1 = "3/5";
                        temp.Option2 = "252/5";
                        temp.Option3 = "3/1400";
                        temp.Option4 = "63/700";
                        temp.Id = 29;
                        temp.Hint = "Required HCF = (HCF of 9,12,18,21)/(LCM of 10,25,35,40)=3/1400";
                        temp.Answer = 3;
                        break;
                    }
                case 30:
                    {
                        flag = 1;
                        temp.Question = "If the sum of two numbers is 55 and the H.C.F. and L.C.M. of these numbers are 5 and 120 respectively, then the sum of the reciprocals of the numbers is equal to:";
                        temp.Option1 = "55/601";
                        temp.Option2 = "601/55";
                        temp.Option3 = "11/120";
                        temp.Option4 = "120/11";
                        temp.Id = 30;
                        temp.Hint = "Let the numbers be a and b.	Then, a + b = 55 and ab = 5 x 120 = 600.  The rrequired sum = (1/a) + (1/b) = (a + b)/ab = 55/600 = 11/120";
                        temp.Answer = 3;
                        break;
                    }
            }

            if (flag == 0)
                return null;
            else
                return temp;
        }    
        public static QuesData CreateAverageQuestion(int ctr)
        {
         
            QuesData temp = new QuesData();
            int flag = 0;

            switch (ctr)
            {
                case 1:
                    {
                        flag = 1;
                        temp.Question = "In the first 10 overs of a cricket game, the run rate was only 3.2. What should be the run rate in the remaining 40 overs to reach the target of 282 runs?";
                        temp.Option1 = "6.25";
                        temp.Option2 = "6.5";
                        temp.Option3 = "6.75";
                        temp.Option4 = "7";
                        temp.Id = 1;
                        temp.Hint = "Required run rate = (282 - (3.2*10))/40 = 250/40 = 6.25";
                        temp.Answer = 1;
                        break;
                    }
                case 2:
                    {
                        flag = 1;
                        temp.Question = "A family consists of two grandparents, two parents and three grandchildren. The average age of the grandparents is 67 years, that of the parents is 35 years and that of the grandchildren is 6 years. What is the average age of the family?";
                        temp.Option1 = "28 4/7 years";
                        temp.Option2 = "31 5/7 years";
                        temp.Option3 = "32 1/7 years";
                        temp.Option4 = "None of these";
                        temp.Id = 2;
                        temp.Hint = "Required average = (67*2 + 35*2 +6*3)/(2+2+3) = (134 + 70 + 18)/7 =  222/7 = 31 5/7 years";
                        temp.Answer = 2;
                        break;
                    }
                case 3:
                    {
                        flag = 1;
                        temp.Question = "A grocer has a sale of Rs. 6435, Rs. 6927, Rs. 6855, Rs. 7230 and Rs. 6562 for 5 consecutive months. How much sale must he have in the sixth month so that he gets an average sale of Rs. 6500?";
                        temp.Option1 = "Rs.4991";
                        temp.Option2 = "Rs.5991";
                        temp.Option3 = "Rs.6001";
                        temp.Option4 = "Rs.6991";
                        temp.Id = 3;
                        temp.Hint = "Total sale for 5 months = Rs. (6435 + 6927 + 6855 + 7230 + 6562) = Rs. 34009.	Required sale = Rs. [ (6500 x 6) - 34009 ] = Rs. (39000 - 34009) = Rs. 4991.";
                        temp.Answer = 1;
                        break;
                    }
                case 4:
                    {
                        flag = 1;
                        temp.Question = "The average of 20 numbers is zero. Of them, at the most, how many may be greater than zero?";
                        temp.Option1 = "0";
                        temp.Option2 = "1";
                        temp.Option3 = "10";
                        temp.Option4 = "19";
                        temp.Id = 4;
                        temp.Hint = "Average of 20 numbers = 0. Sum of 20 numbers (0 x 20) = 0. It is quite possible that 19 of these numbers may be positive and if their sum is a then 20th number is (-a).";
                        temp.Answer = 4;
                        break;
                    }
                case 5:
                    {
                        flag = 1;
                        temp.Question = "The average weight of 8 person's increases by 2.5 kg when a new person comes in place of one of them weighing 65 kg. What might be the weight of the new person?";
                        temp.Option1 = "76 Kg";
                        temp.Option2 = "76.5 Kg";
                        temp.Option3 = "85 Kg";
                        temp.Option4 = "Data inadequate";
                        temp.Id = 5;
                        temp.Hint = "";
                        temp.Answer = 3;
                        break;
                    }
                case 6:
                    {
                        flag = 1;
                        temp.Question = "The captain of a cricket team of 11 members is 26 years old and the wicket keeper is 3 years older. If the ages of these two are excluded, the average age of the remaining players is one year less than the average age of the whole team. What is the average age of the team?";
                        temp.Option1 = "23 years";
                        temp.Option2 = "24 years";
                        temp.Option3 = "25 years";
                        temp.Option4 = "None of these";
                        temp.Id = 6;
                        temp.Hint = "Let the average age of the whole team by x years.	11x - (26 + 29) = 9(x -1)	11x - 9x = 46		2x = 46		x = 23.		So, average age of the team is 23 years.";
                        temp.Answer = 1;
                        break;
                    }
                case 7:
                    {
                        flag = 1;
                        temp.Question = "The average monthly income of P and Q is Rs. 5050. The average monthly income of Q and R is Rs. 6250 and the average monthly income of P and R is Rs. 5200. The monthly income of P is:";
                        temp.Option1 = "3500";
                        temp.Option2 = "4000";
                        temp.Option3 = "4050";
                        temp.Option4 = "5000";
                        temp.Id = 7;
                        temp.Hint = "Let P, Q and R represent their respective monthly incomes. Then, we have:	P + Q = (5050 x 2) = 10100 .... (i)		Q + R = (6250 x 2) = 12500 .... (ii)		P + R = (5200 x 2) = 10400 .... (iii)		Adding (i), (ii) and (iii), we get:  2(P + Q + R) = 33000  or   P + Q + R = 16500 .... (iv)		Subtracting (ii) from (iv), we get P = 4000.		P's monthly income = Rs. 4000.";
                        temp.Answer = 2;
                        break;
                    }
                case 8:
                    {
                        flag = 1;
                        temp.Question = "The average age of husband, wife and their child 3 years ago was 27 years and that of wife and the child 5 years ago was 20 years. The present age of the husband is:";
                        temp.Option1 = "35 years";
                        temp.Option2 = "40 years";
                        temp.Option3 = "50 years";
                        temp.Option4 = "None of these";
                        temp.Id = 8;
                        temp.Hint = "Sum of the present ages of husband, wife and child = (27 x 3 + 3 x 3) years = 90 years.	Sum of the present ages of wife and child = (20 x 2 + 5 x 2) years = 50 years.	Husband's present age = (90 - 50) years = 40 years.";
                        temp.Answer = 2;
                        break;
                    }
                case 9:
                    {
                        flag = 1;
                        temp.Question = "A car owner buys petrol at Rs.7.50, Rs. 8 and Rs. 8.50 per litre for three successive years. What approximately is the average cost per litre of petrol if he spends Rs. 4000 each year?";
                        temp.Option1 = "Rs. 7.98";
                        temp.Option2 = "Rs. 8";
                        temp.Option3 = "Rs. 8.50";
                        temp.Option4 = "Rs. 9";
                        temp.Id = 9;
                        temp.Hint = "Total quantity of petrol consumed in 3 years = (4000/7.5 + 4000/8 + 4000/8.5) litres = 76700/51 litres	Total amount spent = Rs. (3 x 4000) = Rs. 12000.	Average cost = Rs.((12000*51)/76700)= Rs. 7.98 ";
                        temp.Answer = 1;
                        break;
                    }
                case 10:
                    {
                        flag = 1;
                        temp.Question = "In Arun's opinion, his weight is greater than 65 kg but less than 72 kg. His brother doest not agree with Arun and he thinks that Arun's weight is greater than 60 kg but less than 70 kg. His mother's view is that his weight cannot be greater than 68 kg. If all are them are correct in their estimation, what is the average of different probable weights of Arun?";
                        temp.Option1 = "67 kg.";
                        temp.Option2 = "68 kg.";
                        temp.Option3 = "69 kg.";
                        temp.Option4 = "Data inadequate";
                        temp.Id = 10;
                        temp.Hint = "Let Arun's weight by X kg.		According to Arun, 65 < X < 72	According to Arun's brother, 60 < X < 70.	According to Arun's mother, X <= 68	The values satisfying all the above conditions are 66, 67 and 68.	 Required average = (66 + 67 + 68)/3 = 	201/3 = 67 kg.";
                        temp.Answer = 1;
                        break;
                    }


                case 11:
                    {
                        flag = 1;
                        temp.Question = "The average weight of A, B and C is 45 kg. If the average weight of A and B be 40 kg and that of B and C be 43 kg, then the weight of B is:";
                        temp.Option1 = "17 kg";
                        temp.Option2 = "20 kg";
                        temp.Option3 = "26 kg";
                        temp.Option4 = "31 kg";
                        temp.Id = 11;
                        temp.Hint = "Let A, B, C represent their respective weights. Then, we have:A + B + C = (45 x 3) = 135 .... (i)	A + B = (40 x 2) = 80 .... (ii)		B + C = (43 x 2) = 86 ....(iii)		Adding (ii) and (iii), we get: A + 2B + C = 166 .... (iv)	Subtracting (i) from (iv), we get : B = 31.	B's weight = 31 kg.";
                        temp.Answer = 4;
                        break;
                    }
                case 12:
                    {
                        flag = 1;
                        temp.Question = "The average weight of 16 boys in a class is 50.25 kg and that of the remaining 8 boys is 45.15 kg. Find the average weights of all the boys in the class.";
                        temp.Option1 = "47.55 kg";
                        temp.Option2 = "48 kg";
                        temp.Option3 = "48.55 kg";
                        temp.Option4 = "49.25 kg";
                        temp.Id = 12;
                        temp.Hint = "Required average = ( (50.25 * 16) + (45.15*18) )/( 16+8 ) = 48.55";
                        temp.Answer = 3;
                        break;
                    }
                case 13:
                    {
                        flag = 1;
                        temp.Question = "A library has an average of 510 visitors on Sundays and 240 on other days. The average number of visitors per day in a month of 30 days beginning with a Sunday is:";
                        temp.Option1 = "250";
                        temp.Option2 = "276";
                        temp.Option3 = "280";
                        temp.Option4 = "285";
                        temp.Id = 13;
                        temp.Hint = "Since the month begins with a Sunday, to there will be five Sundays in the month.Required average = (510*5 + 240*25)/30 = 285";
                        temp.Answer = 4;
                        break;
                    }
                case 14:
                    {
                        flag = 1;
                        temp.Question = "If the average marks of three batches of 55, 60 and 45 students respectively is 50, 55, 60, then the average marks of all the students is:";
                        temp.Option1 = "53.33";
                        temp.Option2 = "54.68";
                        temp.Option3 = "55";
                        temp.Option4 = "None of these";
                        temp.Id = 14;
                        temp.Hint = "Required Average = (55*50 + 60*55 + 45*60)/(55 + 60 +45) = 54.68";
                        temp.Answer = 2;
                        break;
                    }
                case 15:
                    {
                        flag = 1;
                        temp.Question = "A pupil's marks were wrongly entered as 83 instead of 63. Due to that the average marks for the class got increased by half (1/2). The number of pupils in the class is:";
                        temp.Option1 = "10";
                        temp.Option2 = "20";
                        temp.Option3 = "40";
                        temp.Option4 = "73";
                        temp.Id = 15;
                        temp.Hint = "Let there be x pupils in the class. Total increase in marks = (x*0.5) = x/2		x/2 =(83-63) 		x=40";
                        temp.Answer = 3;
                        break;
                    }

            }

            if (flag == 0)
                return null;
            else
                return temp;
        }
        public static QuesData CreateoddOneOutQuestion(int ctr)
        {

            QuesData temp = new QuesData();
            int flag = 0;

            switch (ctr)
            {
                case 1:
                    {
                        flag = 1;
                        temp.Question = "3, 5, 11, 14, 17, 21";
                        temp.Option1 = "21";
                        temp.Option2 = "17";
                        temp.Option3 = "14";
                        temp.Option4 = "3";
                        temp.Id = 1;
                        temp.Hint = "Each of the numbers except 14 is an odd number.The number '14' is the only EVEN number.";
                        temp.Answer = 3;
                        break;
                    }
                case 2:
                    {
                        flag = 1;
                        temp.Question = "8, 27, 64, 100, 125, 216, 343";
                        temp.Option1 = "27";
                        temp.Option2 = "100";
                        temp.Option3 = "125";
                        temp.Option4 = "343";
                        temp.Id = 2;
                        temp.Hint = "The pattern is 2^3, 3^3, 4^3, 5^3, 6^3, 7^3. But, 100 is not a perfect cube.";
                        temp.Answer = 2;
                        break;
                    }
                case 3:
                    {
                        flag = 1;
                        temp.Question = "10, 25, 45, 54, 60, 75, 80";
                        temp.Option1 = "10";
                        temp.Option2 = "45";
                        temp.Option3 = "54";
                        temp.Option4 = "75";
                        temp.Id = 3;
                        temp.Hint = "Each of the numbers except 54 is multiple of 5.";
                        temp.Answer = 3;
                        break;
                    }
                case 4:
                    {
                        flag = 1;
                        temp.Question = "396, 462, 572, 427, 671, 264";
                        temp.Option1 = "396";
                        temp.Option2 = "427";
                        temp.Option3 = "671";
                        temp.Option4 = "264";
                        temp.Id = 4;
                        temp.Hint = "In each number except 427, the middle digit is the sum of other two.";
                        temp.Answer = 2;
                        break;
                    }
                case 5:
                    {
                        flag = 1;
                        temp.Question = "6, 9, 15, 21, 24, 28, 30";
                        temp.Option1 = "28";
                        temp.Option2 = "21";
                        temp.Option3 = "24";
                        temp.Option4 = "30";
                        temp.Id = 5;
                        temp.Hint = "Each of the numbers except 28, is a multiple of 3.";
                        temp.Answer = 1;
                        break;
                    }
                case 6:
                    {
                        flag = 1;
                        temp.Question = "1, 4, 9, 16, 23, 25, 36";
                        temp.Option1 = "9";
                        temp.Option2 = "23";
                        temp.Option3 = "25";
                        temp.Option4 = "36";
                        temp.Id = 6;
                        temp.Hint = "Each of the numbers except 23, is perfect square.";
                        temp.Answer = 2;
                        break;
                    }
                case 7:
                    {
                        flag = 1;
                        temp.Question = "1, 4, 9, 16, 20, 36, 49";
                        temp.Option1 = "1";
                        temp.Option2 = "9";
                        temp.Option3 = "20";
                        temp.Option4 = "49";
                        temp.Id = 7;
                        temp.Hint = "The pattern is 1^2, 2^2, 3^2, 4^2, 5^2, 6^2, 7^2. But, instead of 5^2, it is 20 which to be turned out.";
                        temp.Answer = 3;
                        break;
                    }
                case 8:
                    {
                        flag = 1;
                        temp.Question = "2, 5, 10, 17, 26, 37, 50, 64";
                        temp.Option1 = "50";
                        temp.Option2 = "26";
                        temp.Option3 = "37";
                        temp.Option4 = "64";
                        temp.Id = 8;
                        temp.Hint = "(1*1)+1 , (2*2)+1 , (3*3)+1 , (4*4)+1 , (5*5)+1 , (6*6)+1 , (7*7)+1 , (8*8)+1  But, 64 is out of pattern.";
                        temp.Answer = 4;
                        break;
                    }
                case 9:
                    {
                        flag = 1;
                        temp.Question = "10, 14, 16, 18, 21, 24, 26";
                        temp.Option1 = "26";
                        temp.Option2 = "24";
                        temp.Option3 = "21";
                        temp.Option4 = "18";
                        temp.Id = 9;
                        temp.Hint = "Each of the numbers except 21 is an even number.";
                        temp.Answer = 3;
                        break;
                    }
                case 10:
                    {
                        flag = 1;
                        temp.Question = "16, 25, 36, 72, 144, 196, 225";
                        temp.Option1 = "36";
                        temp.Option2 = "72";
                        temp.Option3 = "196";
                        temp.Option4 = "225";
                        temp.Id = 10;
                        temp.Hint = "Each of the numbers except 72 is a perfect square.";
                        temp.Answer = 2;
                        break;
                    }
                case 11:
                    {
                        flag = 1;
                        temp.Question = "331, 482, 551, 263, 383, 362, 284";
                        temp.Option1 = "263";
                        temp.Option2 = "383";
                        temp.Option3 = "331";
                        temp.Option4 = "551";
                        temp.Id = 11;
                        temp.Hint = "In each number except 383, the product of first and third digits is the middle one.";
                        temp.Answer = 2;
                        break;
                    }
                case 12:
                    {
                        flag = 1;
                        temp.Question = "835, 734, 642, 751, 853, 981, 532";
                        temp.Option1 = "751";
                        temp.Option2 = "853";
                        temp.Option3 = "981";
                        temp.Option4 = "532";
                        temp.Id = 12;
                        temp.Hint = "In each number except 751, the difference of third and first digit is the middle one.";
                        temp.Answer = 1;
                        break;
                    }
                case 13:
                    {
                        flag = 1;
                        temp.Question = "41, 43, 47, 53, 61, 71, 73, 81";
                        temp.Option1 = "61";
                        temp.Option2 = "71";
                        temp.Option3 = "73";
                        temp.Option4 = "81";
                        temp.Id = 13;
                        temp.Hint = "Each of the numbers except 81 is a prime number.";
                        temp.Answer = 4;
                        break;
                    }
                case 14:
                    {
                        flag = 1;
                        temp.Question = "3, 5, 7, 12, 17, 19";
                        temp.Option1 = "19";
                        temp.Option2 = "17";
                        temp.Option3 = "5";
                        temp.Option4 = "12";
                        temp.Id = 14;
                        temp.Hint = "Each of the numbers is a prime number except 12.";
                        temp.Answer = 4;
                        break;
                    }

            }

            if (flag == 0)
                return null;
            else
                return temp;
        }
        public static QuesData CreatePercentageQuestion(int ctr)
        {

            QuesData temp = new QuesData();
            int flag = 0;

            switch (ctr)
            {
                //case 1:
                //    {
                //        flag = 1;
                //        temp.Question = "the ratio 5:4 expressed as a percent equals : ";
                //        temp.Option1 = "12.5%";
                //        temp.Option2 = "40%";
                //        temp.Option3 = "80%";
                //        temp.Option4 = "125%";
                //        temp.Id = 1;
                //        temp.Answer = 4;
                //        break;
                //    }
                //case 2:
                //    {
                //        flag = 1;
                //        temp.Question = "3.5 can be expressed in terms of percentage as :";
                //        temp.Option1 = "0.35%";
                //        temp.Option2 = "3.5%";
                //        temp.Option3 = "35%";
                //        temp.Option4 = "350%";
                //        temp.Id = 2;
                //        temp.Answer = 4;
                //        break;
                //    }
                case 1:
                    {
                        flag = 1;
                        temp.Question = "a1";
                        temp.Option1 = "1";
                        temp.Option2 = "1";
                        temp.Option3 = "1";
                        temp.Option4 = "1";
                        temp.Id = 1;
                        temp.Answer = 4;
                        break;
                    }
                case 2:
                    {
                        flag = 1;
                        temp.Question = "a2";
                        temp.Option1 = "2";
                        temp.Option2 = "2";
                        temp.Option3 = "2";
                        temp.Option4 = "2";
                        temp.Id = 2;
                        temp.Answer = 4;
                        break;
                    }
                case 3:
                    {
                        flag = 1;
                        temp.Question = "a3";
                        temp.Option1 = "3";
                        temp.Option2 = "3";
                        temp.Option3 = "3";
                        temp.Option4 = "3";
                        temp.Id = 3;
                        temp.Answer = 4;
                        break;
                    }
                case 4:
                    {
                        flag = 1;
                        temp.Question = "a4";
                        temp.Option1 = "4";
                        temp.Option2 = "4";
                        temp.Option3 = "4";
                        temp.Option4 = "4";
                        temp.Id = 4;
                        temp.Answer = 4;
                        break;
                    }
                case 5:
                    {
                        flag = 1;
                        temp.Question = "a5";
                        temp.Option1 = "5";
                        temp.Option2 = "5";
                        temp.Option3 = "5";
                        temp.Option4 = "5";
                        temp.Id = 5;
                        temp.Answer = 4;
                        break;
                    }

            }

            if (flag == 0)
                return null;
            else
                return temp;
        }

        //Generates no. of questions for a particular type of questions
        public static int GenerateMaximum(int lesson)
        {
           
            Dictionary<int,int> numbers = new Dictionary<int,int>();
            //first number is lesson no. and second number is no. of questions i.e no. of cases in switch
            numbers.Add(1, 2);  //numbers
            numbers.Add(2, 30); //HCF and LCM
            numbers.Add(3, 15);  //Average
            numbers.Add(4, 14); //Odd one out
            numbers.Add(5, 5);  //Percentage

            return numbers[lesson];

        }

        //public static string GenerateTitle(int lesson)
        //{
        //    Dictionary<int, string> items = new Dictionary<int, string>();
        //    items.Add(1,"Numbers");
        //}
     
    }
}
