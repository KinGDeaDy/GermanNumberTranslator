using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace GermanNumberTranslator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ArrayList units = new ArrayList
        {
            "eins","zwei","drei","vier","funf","sechs","sieben","acht","neun","zehn",
            "elf","zwolf","dreizehn","vierzehn","funfzehn","sechzehn","siebzehn","achtzehn","neunzehn"
        };
        Dictionary<int, string> dozens = new Dictionary<int, string>
            {
                {20,"zwanzig" },
                {30,"dreibig" },
                {40,"vierzig" },
                {50,"funfzig" },
                {60,"sechzig" },
                {70,"siebzig" },
                {80,"achtzig" },
                {90,"neunzig" }
            };
        private void MainForm_Load(object sender, EventArgs e)
        {     
        }
        public bool checkCorrectness(ArrayList words)
        {
            try
            {
                bool isCorrect = true;
                foreach (string word in words)
                    if (!(units.Contains(word) || dozens.ContainsValue(word) || word == "und" || word == "ein" || word == "hundert"))
                        throw new Exception("Ошибка в слове "+word);
                return isCorrect;
            }
            catch (Exception ex)
            {
                debugBox.Clear();
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        public int toArabic(ArrayList words)
        {
            int sum = 0;
            if (words.Contains("hundert"))
            {
                if (words[0].ToString() == "ein")
                    sum += 100;
                else
                {
                    for (int i = 0; i < 9; i++)
                        if (units[i].ToString() == words[0].ToString())
                            sum += (i + 1) * 100;
                }
                words.RemoveAt(0);
                words.RemoveAt(0);
                if (words.Count>=1)
                    sum += calcDozens(words);
            }
            else
                sum = calcDozens(words);
            return sum;
        }
        public int calcDozens(ArrayList words)
        {
            int sum = 0;
            if (words.Count==1)
            {
                if (words[0].ToString() == "ein")
                    return 1;
                for (int i=0; i<units.Count;i++)
                {
                    if (units[i].ToString() == words[0].ToString())
                        return i + 1;
                }
                foreach (var pair in dozens)
                {
                    if (pair.Value == words[0].ToString())
                        return pair.Key;
                }
            }
            else
            {
                if (words[0].ToString() == "ein")
                    sum += 1;
                for (int i = 0; i < units.Count; i++)
                {
                    if (units[i].ToString() == words[0].ToString())
                        sum = i + 1;
                }
                foreach (var pair in dozens)
                {
                    if (pair.Value == words[2].ToString())
                        sum += pair.Key;
                }
            }
            return sum;    
        }
        public bool checkErrors(ArrayList words)
        {
            bool hasError = false;
            try
            {
                //ПРОВЕРКИ UND
                int index=words.IndexOf("und");
                //Десятичный разряд слева от слова 'und'
                if (index!=0 && index!= words.Count-1 && index != -1)
                {
                    if (containsForDozens(words[index - 1].ToString()))
                        throw new Exception("Десятичный разряд перед соединителем");
                    //Сотенный разряд перед и после слова 'und'
                    if (words[index - 1].ToString() == "hundert")
                        throw new Exception("Специальные слова 'und' и 'hundert' не могут стоять вместе");
                    if (containsForUnits(words[index + 1].ToString()))
                        throw new Exception("Единичный разряд после соединителя");
                    if (words[index + 1].ToString() == "hundert")
                        throw new Exception("Специальные слова 'und' и 'hundert' не могут стоять вместе");
                    for (int i=9; i<18;i++)
                        if (words[index + 1].ToString()==units[i].ToString())
                            throw new Exception("После соединителя должно стоять число десятичного разряда");
                }
                if (index==0)
                    throw new Exception("Перед соединителем должно стоять число единичного разряда");
                if (index== words.Count - 1 && index!=-1)
                {
                    if (containsForDozens(words[index-1].ToString()))
                        throw new Exception("Десятичный разряд перед соединителем");
                    else if (words[index-1].ToString()=="hundert")
                        throw new Exception("Специальные слова 'und' и 'hundert' не могут стоять вместе");
                    else throw new Exception("После соединителя должно стоять число десятичного разряда");
                }
                //ПРОВЕРКА ПОВТОРОВ ОДНОГО ЖЕ РАЗРЯДА
                if (words.Count>1)
                {
                    for (int i=0;i<words.Count-1;i++)
                    {
                        if (containsForDozens(words[i].ToString()) && containsForDozens(words[i+1].ToString()))
                            throw new Exception("Повтор чисел десятичного разряда");    
                        if (containsForUnits(words[i].ToString()) && containsForUnits(words[i + 1].ToString()))
                            throw new Exception("Повтор чисел единичного разряда");
                        if (words[i].ToString()=="hundert" && words[i+1].ToString()=="hundert")
                            throw new Exception("Повтор чисел сотенного разряда");
                    }
                }
                int countHundert = 0;
                for (int i=0;i<words.Count;i++)
                {
                    if (words[i].ToString()=="hundert")
                    {
                        countHundert++;
                        if (i!=0)
                            if (containsForDozens(words[i - 1].ToString()))
                                throw new Exception("Десятичный разряд перед сотенным разрядом");
                        if (i==0) throw new Exception("Отсутствует число единичного разряда перед разрядом сотен");
                        if (countHundert>1) throw new Exception("Повтор чисел сотенного разряда");
                    }    
                }        
                if (words.Count > 1)
                {
                    for (int i = 0; i < words.Count - 1; i++)
                    {
                        if (containsForDozens(words[i].ToString()) && containsForUnits(words[i+1].ToString()))
                            throw new Exception("Единичный разряд после десятичного разряда");
                        if (containsForUnits(words[i ].ToString()) && containsForDozens(words[i+1].ToString()))
                            throw new Exception("Десятичный разряд после единичного разряда");
                    }
                }
                return hasError;
            }
            catch (Exception ex)
            {
                debugBox.Clear();
                MessageBox.Show(ex.Message);
                return true;
            }
        }
        public string ToRoman(int anArabic)
        {
            string result = string.Empty;
            var symbol = new Dictionary<int, string>{{1000,"M"},
                                {900,"CM"},
                                {500,"D"},
                                {400,"CD"},
                                {100,"C"},
                                {90,"XC"},
                                {50,"L"},
                                {40,"XL"},
                                {10,"X"},
                                {9,"IX"},
                                {5,"V"},
                                {4,"IV"},
                                {1,"I"}};
            foreach (var level in new List<int>{1000,900,500,400,100,90,50,40,10,9,5,4,1})
            {
                if (anArabic >= level)
                {
                    do
                    {
                        result += symbol[level];
                        anArabic -= level;
                    } while (anArabic >= level);
                }
            }
            return result;
        }
        public bool containsForDozens(string number)
        {
            if (dozens.ContainsValue(number))
                return true;
            for (int i=9;i<units.Count;i++)
                if (units[i].ToString() == number)
                    return true;
            return false;
        }
        public bool containsForUnits(string number)
        {
            for (int i = 0; i < 9; i++)
                if (units[i].ToString() == number || number=="ein")
                    return true;
            return false;
        }
        private void hideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void translateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rx = new Regex(@"\s+", RegexOptions.Compiled);
                ArrayList words = new ArrayList(rx.Split(inputBox.Text.ToLower()));
                words.Remove("");
                if (checkCorrectness(words) && !checkErrors(words) && words.Count > 0)
                    debugBox.Text = toArabic(words).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void translateRoman_Click(object sender, EventArgs e)
        {
            try
            {
                var rx = new Regex(@"\s+", RegexOptions.Compiled);
                ArrayList words = new ArrayList(rx.Split(inputBox.Text.ToLower()));
                words.Remove("");
                if (checkCorrectness(words) && !checkErrors(words) && words.Count > 0)
                    debugBox.Text = ToRoman(toArabic(words)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}