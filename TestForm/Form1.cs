using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Numerics;
using System.ComponentModel;
using System.Drawing;

namespace TestForm
{
    public partial class Form1 : Form
    {
        DateTime dtaInclusao;

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black ;
        }

        #region TEMP
        private void button32_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region test data
        private void Form1_Load(object sender, EventArgs e)
        {
            dtaInclusao = DateTime.Now;
            txtDataHora.Text = dtaInclusao.ToString();
        }
        #endregion

        #region ternario com mais de uma opção
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10, y = 100;
            string strResult = x > y ? "x is greater than y" :
                               x < y ? "x is less than y" :
                               x == y ? "x is equal to y" : "No result";
            MessageBox.Show(strResult);
            int number = 2;
            bool isEven;
            isEven = (number % 2 == 1) ? true : false;
            MessageBox.Show("" + isEven);
        }

        #endregion

        #region bool to string
        private void button2_Click(object sender, EventArgs e)
        {
            bool blnA = true;
            string strA = blnA.ToString();

            MessageBox.Show("" + strA);
        }
        #endregion

        #region tooltipo mousehover test
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Tooltip text"); // you can change the first parameter (textbox3) on any control you wanna focus
        }

        #endregion

        #region iniciais nome e sobrenome
        private void button3_Click(object sender, EventArgs e)//https://www.codewars.com/users/felipe-era/completed_solutions
        {
            AbbrevName("Sam Harris");
            AbbrevName("Joao Paulo");
        }
        public static string AbbrevName(string name) //retorna o valor do array vezes 2
        {
            string[] strX = name.Split(' ');
            string strR1 = strX[0].Substring(0, 1);
            string strR2 = strX[1].Substring(0, 1);
            string strEnd = strR1.ToUpper() + "." + strR2.ToUpper();
            MessageBox.Show(strEnd);
            return strEnd;
            //public static string AbbrevName(string name)
            //{
            //  //get the index of the space
            //  int posOfSpace = name.IndexOf(" ");

            //  //build a string with the first character, the period, and the first character AFTER the space
            //  string abbrevName = name.Substring(0, 1) + "." + name.Substring(posOfSpace+1, 1);

            //  //return the result in uppercase (since some random testcases had lowercase names)
            //  return abbrevName.ToUpper();
            //}
        }
        #endregion

        #region array * 2
        private void button4_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 2, 3 };
            Maps(intArray);
        }
        public static int[] Maps(int[] x)
        {
            int[] intArrayReturn = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                int intCalc = x[i] * 2;
                intArrayReturn[i] = intCalc;
            }
            return intArrayReturn;
        }
        #endregion

        #region dna to rna convert
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dnaToRna("TTTT"));
        }

        public string dnaToRna(string dna)
        {
            char[] chrDnaLetter = new char[] { 'G', 'C', 'A', 'T' };
            string strUpCase = dna.ToUpper();
            return strUpCase.Replace('T', 'U'); //o T muda pro u só isso kk
            //string RNA;
            //RNA = dna.Replace("T", "U");
            //return RNA;
            //public string dnaToRna(string dna)
            //{
            //    char[] ch = dna.ToCharArray();
            //    for (int i = 0; i < ch.Length; i++)
            //    {
            //        if (ch[i] == 'T')
            //        {
            //            ch[i] = 'U';
            //        }
            //    }
            //    string rna = new string(ch);
            //    return rna;
            //}
        }
        #endregion

        #region ternario
        private void button6_Click(object sender, EventArgs e)
        {
            string strA = "";
            string strB = " ";
            string strC = "     ";
            string strD = null;

            MessageBox.Show(string.IsNullOrEmpty(strA) ? "xd" : "abc", string.IsNullOrEmpty(strB) + " " + string.IsNullOrEmpty(strC) + string.IsNullOrEmpty(strD));
        }
        #endregion ternario

        #region multiply array
        private void button7_Click(object sender, EventArgs e)
        {
            int[] intA = new int[] { 4, 1, 1, 1, 4 };
            MessageBox.Show("" + Grow(intA));

        }
        public int Grow(int[] x)
        {
            int intB = 1;
            for (int i = 0; i < x.Length; i++)
            {
                intB *= x[i];
                //MessageBox.Show( "" + intB);
            }
            return intB;
            //public static int Grow(int[] y)
            //{
            //    int result = 1;
            //    foreach (int x in y)
            //    {
            //        result *= x;
            //    }
            //    return;
        }
        #endregion

        #region multiply random
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + Multiply(10));
            MessageBox.Show("" + Multiply(2));
            MessageBox.Show("" + Multiply(8));
            MessageBox.Show("" + Multiply(4));
            MessageBox.Show("" + Multiply(5));
        }

        public int Multiply(int x)
        {
            return x % 2 == 1 ? x * 9 : x * 8;
        }
        #endregion

        #region distance do pump
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + ZeroFuel(50, 25, 2));
            MessageBox.Show("" + ZeroFuel(100, 50, 1));
        }

        public bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            fuelLeft *= mpg;
            bool blnResult = fuelLeft >= distanceToPump ? true : false;
            return blnResult;
        }
        #endregion

        #region contador de vogais!?
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + GetVowelCount("I completed the Kata, and submitted my solution,"));

        }

        public int GetVowelCount(string str)
        {
            int vowelCount = 0;
            string[] strVowel = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains(strVowel[0]))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        #endregion

        #region String to int (no padrão)
        private void button11_Click_1(object sender, EventArgs e)
        {
            StringToNumber(textBox1.Text);
        }
        public static int StringToNumber(string str)
        {
            if (Int32.TryParse(str, out _))
            {
                MessageBox.Show("conseguiu" + str);
                int intConvert = int.Parse(str);
                return intConvert;
            }
            else
            {
                MessageBox.Show("não" + str);
                return 0;
            }

        }
        #endregion

        #region soma do num informado para baixo
        private void button12_Click(object sender, EventArgs e) //https://www.codewars.com/kata/55d24f55d7dd296eb9000030
        {


            MessageBox.Show("" + Summation(8));
        }
        public int Summation(int num)
        {
            int intI = num;
            int intA = 0;

            for (int i = 0; i <= num; i++)
            {
                intA = intA + i;
            }

            return intA;
        }
        #endregion

        #region Regex com validador de asci / caractere


        private void button13_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + ValidatePin(textBox1.Text));//true

            MessageBox.Show("" + ValidatePin2(textBox1.Text));//true
            //MessageBox.Show("" + ValidatePin("a234"));//fase

        }
        public static bool ValidatePin(string pin) //https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/train/csharp
        {
            pin = pin.Trim();
            if (pin.Length == 4 || pin.Length == 6)
            {
                if (Int32.TryParse(pin, out _))
                {
                    int intConvert = int.Parse(pin);
                    if (intConvert < 0)
                    {
                        return false;
                    }
                    if (!Regex.IsMatch(pin, "^[0-9]+$"))
                    {
                        MessageBox.Show("tem letras......");
                        return false;
                    }
                    return true;
                }
                else
                {
                    //MessageBox.Show("Não pode ter letras ou caracteres especiais no PIN");
                    return false;
                }
            }
            else
            {
                //MessageBox.Show("nnnnnnnnnnn"); Length invalido
                return false;
            }

        }

        public static bool ValidatePin2(string pin) //https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/train/csharp
        {
            pin = pin.Trim();
            if (pin.Length == 4 || pin.Length == 6)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (pin[i] >= 48 && pin[i] <= 57)
                    {
                        int Int1 = 1;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                //MessageBox.Show("nnnnnnnnnnn"); Length invalido
                return false;
            }

            return false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string pin = textBox1.Text;
            int intA = 1;

            if (Regex.IsMatch(pin, "^[0-9]+$"))
            {
                MessageBox.Show("tem numeros....");
                return;
            }
        }





        #endregion

        #region valida mask
        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btnMasked_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + maskedTextBox1.MaskCompleted);
            maskedTextBox1.Clear();
        }

        #endregion

        #region letras repetidas... /limbo
        private void button16_Click(object sender, EventArgs e)
        {
            Accum("abcd");
        }

        public string Accum(string s)
        {
            int intT = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                char a = s[0];
                char b = s[3];

                MessageBox.Show($" {a} {b}");
            }
            return s;
        }
        #endregion

        #region Calculate avarage https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/csharp
        private void button17_Click(object sender, EventArgs e)
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            FindAverage(array);
            //double[] array2 = new double[] {};
            //FindAverage(array2);

        }

        public static double FindAverage(double[] array)
        {
            double dobTamanho = array.Length;
            double dobSoma = 0;
            double dobTotal = 0;
            double count = 0;
            if (dobTamanho == 0)
            {
                return 0;
            }
            for (int i = 0; count < array.Length; i++)
            {
                dobSoma = array[i];
                dobTotal += dobSoma;
                count++;
            }
            double dobA = dobTotal / count;
            return dobA;
        }





        #endregion

        #region Exes and Ohs https://www.codewars.com/kata/55908aad6620c066bc00002a/solutions/csharp
        private void button18_Click(object sender, EventArgs e)
        {
            string strEntrada = textBox1.Text;
            MessageBox.Show("" + XO(strEntrada));
        }
        public static bool XO(string input)
        {
            string strM = input.ToLower();
            int strX = 0, strO = 0;
            for (int i = 0; i < strM.Length; i++)
            {
                if (strM[i] == 'x')
                {
                    strX++;
                }
                else if (strM[i] == 'o')
                {
                    strO++;
                }
            }

            if (strX == strO)
            {
                return true;
            }
            if (strX != strO)
            {
                return false;
            }
            if (strX == 0 && strO == 0)
            {
                return true;
            }
            return true;
        }
        #endregion

        #region é triangulo?
        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + IsTriangle(5, 7, 10));
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            int aR = a / 3;
            int bR = b / 3;
            int cR = c / 3;
            if (aR > 0 && bR > 0 && cR > 0)
            {
                return true;
            }
            return false;
        }



        #endregion

        #region No Space
        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + NoSpace(" joao a ao          P a Da Silva Sauro"));
        }
        public static string NoSpace(string input)
        {
            string strA = input.Replace(" ", "");
            return strA;
        }


        #endregion

        #region If you can't sleep, just count sheep!!
        private void button21_Click(object sender, EventArgs e) //https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/train/csharp
        {
            MessageBox.Show("" + CountSheep(int.Parse(textBox1.Text)));

        }
        public static string CountSheep(int n)
        {
            string strA = string.Empty;
            int intC = 1;
            for (int i = 0; i < n; i++)
            {
                strA += intC + " sheep...";
                intC++;
            }
            return strA;
            //StringBuilder sheepBuilder = new StringBuilder();
            //for (int i = 1; i <= n; i++)
            //{
            //    sheepBuilder.Append(i).Append(" sheep...");
            //}
            //return sheepBuilder.ToString();
        }

        #endregion

        #region Needle
        private void button22_Click(object sender, EventArgs e)
        {
            var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            MessageBox.Show("AAAA" + FindNeedle(haystack_1));

        }
        public static string FindNeedle(object[] haystack)
        {
            string strN = "needle";
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != null)
                {
                    if (haystack[i].ToString() == strN)
                    {
                        return "found the needle at position " + i.ToString();
                    }
                }
            }
            return "";
        }
        #endregion needle

        #region stringrepeat 
        //https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/train/csharp
        private void button23_Click(object sender, EventArgs e)
        {

            MessageBox.Show(RepeatStr(3, "*"));
            MessageBox.Show(RepeatStr(5, "#"));

        }
        public static string RepeatStr(int n, string s)
        {
            string strS = string.Empty;
            for (int i = 0; i < n; i++)
            {
                strS += s;
            }
            return strS;
        }
        #endregion

        #region bmi / imc
        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test " + Bmi(80, 1.80));
        }
        //public static string Bmi(double w, double h)
        //{
        //   => (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";
        //}
        public static string Bmi(double weight, double height)
        {
            double dobA = (height * height);
            double dobB = weight / dobA;
            if (dobB <= 18)
            {
                return "Underweight";
            }
            if (dobB <= 25.0)
            {
                return "Normal";
            }
            if (dobB <= 30.0)
            {
                return "Overweight";
            }
            if (dobB > 30.0)
            {
                return "Obese";
            }
            return "" + dobB;
        }



        #endregion

        #region  string join 
        private void button25_Click(object sender, EventArgs e)
        {
            string[] strA = new string[] { "this", "is", "a", "really", "long", "sentence" };
            string[] strC = new string[] { "hello", "world" };
            MessageBox.Show("" + Smash(strA));
            MessageBox.Show("" + Smash(strC));

        }
        public static string Smash(string[] words) //https://www.codewars.com/kata/53dc23c68a0c93699800041d/solutions/csharp
        {
            string strB = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                strB += words[i] + " ";
            }
            strB = strB.Trim();
            return strB;
            //return string.Join(" ", words); ninjas do codewar
        }




        #endregion

        #region replace string / regex
        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + FakeBin("45385593107843568"));
        }
        public static string FakeBin(string x)
        {
            x = x.Replace('1', '0').Replace('2', '0').Replace('3', '0').Replace('4', '0');
            x = x.Replace('5', '1').Replace('6', '1').Replace('7', '1').Replace('8', '1').Replace('9', '1');
            return x;
            //return string.Concat(x.Select(a => a < '5' ? "0" : "1")); FROM NINJAS
            //x = Regex.Replace(x, "[4321]", "0");
            //x = Regex.Replace(x, "[56789]", "1");
            //return x;
        }
        #endregion

        #region obj to int
        //https://www.codewars.com/kata/57eaeb9578748ff92a000009/solutions/csharp
        // link do solutions, varios modelos kkj
        private void button27_Click(object sender, EventArgs e)
        {
            object[] obj1 = new object[] { 9, 3, "7", "3" };
            MessageBox.Show("Test" + SumMix(obj1));
        }
        public static int SumMix(object[] x)
        {
            int intA = 0;
            int intB = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int intC = Convert.ToInt32(x[i]);
                intA += intC;
            }
            return intA;
        }
        #endregion

        #region traffic light if ternario

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + UpdateLight("green"));
            MessageBox.Show("" + UpdateLight("yellow"));
            MessageBox.Show("" + UpdateLight("red"));
        }

        public static string UpdateLight(string strX)
        {
            string strResult = strX == "green" ? "yellow" :
                               strX == "yellow" ? "red" :
                               strX == "red" ? "green" : "xd";
            return strResult;
        }





        #endregion

        #region menor num de um array
        //https://www.codewars.com/kata/55a2d7ebe362935a210000b2/solutions/csharp
        private void button29_Click(object sender, EventArgs e)
        {
            int[] intA = new int[] { 78, 56, 232, 12, 11, 43 };
            MessageBox.Show("" + FindSmallestInt(intA));
        }
        public static int FindSmallestInt(int[] args)
        {
            int menor = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (menor > args[i])
                {
                    menor = args[i];
                }
            }
            return menor;
            //return args.Min();  NINJAS
        }
        #endregion

        #region procura par ou impar
        private void button30_Click(object sender, EventArgs e) //https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/csharp
        {
            int[] intA = new int[] { 2, 6, 8, -10, 3 };
            Finda(intA);
        }
        public static int Finda(int[] integers)
        {
            int intPar = 0, intImpar = 0;
            int valPar = 0, ValImpar = 0;
            if (integers[0] == 0)
            {
                return 0;
            }
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    //MessageBox.Show("é par");
                    intPar += 1;
                    valPar = integers[i];
                }
                if (integers[i] % 2 == 1)
                {
                    //MessageBox.Show("é impar");
                    intImpar += 1;
                    ValImpar = integers[i];
                }
            }
            if (intPar < intImpar)
            {
                MessageBox.Show("Test" + valPar);
                return valPar;
            }
            else
            {
                MessageBox.Show("Test" + ValImpar);
                return ValImpar;
            }
        }
        #endregion

        #region ordenação array / remove characteres especiais

        private void button31_Click(object sender, EventArgs e)
        {
            string strA = "is2 Thi1s T4est 3a";
            Order(strA);
            string strB = "4of Fo1r pe6ople g3ood th5e the2";
            Order(strB);
            string strC = "";
            Order(strC);
        }
        public string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return "";
            }
            string[] strArray = new string[10];
            string[] strS = words.Split(' ');

            for (int i = 0; i < strS.Length; i++) //foreach
            {
                MatchCollection matches = Regex.Matches(strS[i], "[0-9]");
                int intA = int.Parse(matches[0].Value);
                strArray[intA] = strS[i];
            }
            string strC = string.Join(" ", strArray).Trim();

            MessageBox.Show("Test" + strC);

            return strC.Trim();
        }


        #endregion

        #region reversor de palavras
        private void button33_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + ReverseWords("This is an example!"));

        }

        public static string ReverseWords(string str)
        {
            string strMonta = string.Empty;
            string[] strS = str.Split(' ');
            for (int i = 0; i < strS.Length; i++)
            {
                int intX = strS[i].Length - 1;
                string str1 = strS[i];
                for (int K = 0; K < str1.Length; K++)
                {
                    strMonta += str1[intX];
                    intX--;
                }
                strMonta += " ";
            }
            return strMonta.Trim();
        }















        #endregion

        #region square digits (separanumeros)
        private void button34_Click(object sender, EventArgs e)
        {
            SquareDigits(9119);
        }
        public static int SquareDigits(int n) //https://www.codewars.com/kata/546e2562b03326a88e000020/solutions/csharp
        {
            string strA = n.ToString();
            string strB = String.Empty;
            for (int i = 0; i < strA.Length; i++)
            {
                int intA = int.Parse(strA[i].ToString());
                intA *= intA;
                strB += intA;
            }
            return int.Parse(strB);
        }




        #endregion

        #region string end with?
        private void button35_Click(object sender, EventArgs e) //https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/solutions/csharp
        {
            MessageBox.Show("Test" + Solution("samurai", "ai"));
        }

        public static bool Solution(string str, string ending)
        {
            int intStr = str.Length;
            int intEnd = ending.Length;
            if (intEnd > intStr)
            {
                return false;
            }
            int intCalc = intStr - intEnd;
            string strA = str.Substring(intCalc);
            if (strA.Equals(ending))
            {
                return true;
            }
            else
            {
                return false;
            }
        }







        #endregion

        #region Count the divisor of number
        //https://www.codewars.com/kata/542c0f198e077084c0000c2e/train/csharp
        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text" + Divisors(1));

        }

        public static int Divisors(int n)
        {
            int intCount = 0;
            for (double dobA = 1; dobA <= n; dobA++)
            {
                double dobAux = n / dobA;
                string strAux = dobAux.ToString();
                bool blnA = Int32.TryParse(strAux, out _);
                if (blnA)
                {
                    intCount++;
                }
                else
                {
                    //do nothing    
                }
            }
            return intCount;
        }


        #endregion

        #region  string to camel case (substring)
        //https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
        private void button37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + ToCamelCase("The-Stealth-Warrior"));
        }
        public static string ToCamelCase(string str)
        {
            string strW = str.Replace("-", " ").Replace("_", " ");
            string[] strX = strW.Split(' ');

            strX[1] = strX[1].Substring(0, 1).ToUpper() + strX[1].Substring(1);
            strX[2] = strX[2].Substring(0, 1).ToUpper() + strX[2].Substring(1);

            str = string.Join("", strX);

            return str;
        }


        #endregion

        #region create phone number
        private void button38_Click(object sender, EventArgs e)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            MessageBox.Show("Test" + CreatePhoneNumber(intArray));
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            string strA = String.Join("", numbers);
            strA = "(" + strA.Substring(0, 3) + ") " + strA.Substring(3, 3) + "-" + strA.Substring(6, 4);
            return strA;
            //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}"
        }


        #endregion

        #region Sum big number


        private void button39_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + sumStrings("3,562,887,067,442,013", "4563,562,887,067,442,013"));
        }

        public static string sumStrings(string a, string b)
        {
            //BigInteger bigInt_Double = new BigInteger(179032.6541); https://www.codewars.com/kata/5324945e2ece5e1f32000370/train/csharp
            //using System.Numerics;
            BigInteger n1;
            BigInteger n2;
            BigInteger n3;
            n1 = BigInteger.Parse(a);
            n2 = BigInteger.Parse(b);
            n3 = n1 + n2;
            return n3.ToString();
        }


        #endregion

        #region ascii value + encrypt
        private void button40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + EncryptThis("Hello"));
            MessageBox.Show("Test" + EncryptThis("good"));
            MessageBox.Show("Test" + EncryptThis("hello world"));
        }

        //https://www.codewars.com/kata/5848565e273af816fb000449/discuss
        //char c = 'e';
        //int ascii = c;
        //Console.Write("The ASCII value of " +
        //                c + " is: " + ascii);

        public static string EncryptThis(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "";
            }
            var encrypted = "";
            var words = input.Split(' ');
            foreach (var word in words)
            {
                var result = $"{(int)word[0]}";
                if (word.Length == 2)
                {
                    result += word[1];
                }
                if (word.Length == 3)
                {
                    result += word[word.Length - 1];
                    result += word[1];
                }
                else if (word.Length > 3)
                {
                    result += word[word.Length - 1];
                    result += word.Substring(2, word.Length - 3);
                    result += word[1];
                }
                encrypted += $"{result} ";
            }
            return encrypted.Trim();
        }

        #endregion

        #region remove '#'
        //https://www.codewars.com/kata/51f2b4448cadf20ed0000386/train/csharp
        // return Regex.Match(url, @"[^#]+").Value; || return Regex.Replace(url, $"#.+", "");   <<tbem resolve kkkk
        private void button41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + RemoveUrlAnchor("www.codewars.com#about"));
            MessageBox.Show("Test" + RemoveUrlAnchor("www.codewars.com / katas /? page = 1#about"));
            MessageBox.Show("Test" + RemoveUrlAnchor("www.codewars.com/katas/"));
        }

        public static string RemoveUrlAnchor(string url)
        {
            if (!url.Contains("#"))
            {
                return url;
            }
            string strB = url.Replace(url.Substring(url.IndexOf('#'), url.Length - url.IndexOf('#')), "");
            return strB;
        }






        #endregion

        #region have?
        private void button42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test" + GetMiddle("test"));
            MessageBox.Show("Test" + GetMiddle("testing"));
        }
        //  You can not have ?, if, or switch in your code
        //https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp
        public static string GetMiddle(string s)
        {
            int intA = s.Length;
            int intB = s.Length;
            double dblA = 0;
            string strA = string.Empty;
            string strB = string.Empty;

            if (intA % 2 == 0)
            {
                intA = intA / 2;
                intB = intA + 1;
                strA += s[intA - 1] + "" + s[intB - 1];
                return strA;
            }
            else
            {
                dblA = intA / 2;
                Math.Round(dblA);
                intB = (int)dblA;
                strA = s[intB] + "";
                return strA;

            }
            return "bug";
        }











        #endregion

        private void button43_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = textBox2.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //DGV(this, e.ToString()); 
        }

        public void DGV(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
        }
    }
}



