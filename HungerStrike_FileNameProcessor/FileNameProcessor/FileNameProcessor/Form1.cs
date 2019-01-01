using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileNameProcessor
{
    public partial class Form1 : Form
    {
        DateTime today;
        DateTime weekStartDay;
        DateTime weekEndDay;

        int startDayDate;
        int startDayMonth;
        int startDayYear;

        int endDayDate;
        int endDayMonth;
        int endDayYear;

        string[] monthNames = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };

        public Form1()
        {
            InitializeComponent();

            today = DateTime.Today;
            textBox_Debug.Text = today.ToString("dd-mm-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileNameString = textBox_EnterFileName.Text;

            textBox_Debug.Text = fileNameString;

            string[] numbers = Regex.Split(fileNameString, @"\D+");
            string[] strings = Regex.Split(fileNameString, @"\d+");

            //It is observed that sometimes empty elements are added to the extracted array of strings while
            //performing regex. Check if such empty elements exist, and smoke'em off if present.
            //Solution Credit: https://stackoverflow.com/questions/8814811/remove-blank-values-in-the-array-using-c-sharp

            var temp = new List<string>();
            foreach (var s in numbers)
            {
                if (!string.IsNullOrEmpty(s))
                    temp.Add(s);
            }
            numbers = temp.ToArray();

            //>>>>Step 1: Find Date and Year of Starting Weekday and Ending Weekday
            //This can be identified by counting number of occurrences of numbers in the file name string.
            //If the filename contains 2 numbers, 
            //then first number is start date, second is end date. Year is to be assigned using current year.
            //
            //If the filename contains 3 numbers, 
            //then first number is start date, second is end date and third is year same for start and end date
            //
            //If the filename contains 4 numbers,
            //then first number is start date, second is year of the start date, third is end date and last is yesr for end date.
            //
            //This is assumming that (and putting a restriction on) naming the file should contain the month in string format
            //like 'Jan', 'Apr', 'Sept' and not in numeric format like '1', '4', '9'.
            //
            //IF THIS IS NOT FOLLOWED, THEN ALL THIS ALGORITHM WILL FAIL.
            if ((numbers.Length >= 2) && (numbers.Length <= 4))
            {
                //First element numbers[0] has been extracted successfully.
                if (numbers.Length == 2u)
                {
                    //where [0] element is date of starting weekday
                    //      [1] element is date of ending weekday
                    startDayDate    = int.Parse(numbers[0]);
                    endDayDate      = int.Parse(numbers[1]);

                    //Since year is not mentioned in the file name, simply assume and assign the current year
                    //to both the dates.
                    startDayYear    = today.Year;
                    endDayYear      = today.Year;
                }
                else if (numbers.Length == 3u)
                {
                    //where [0] element is date of starting weekday
                    //      [1] element is date of ending weekday
                    //      [2] element is year of starting and ending weekdays
                    startDayDate    = int.Parse(numbers[0]);
                    endDayDate      = int.Parse(numbers[1]);
                    startDayYear    = int.Parse(numbers[2]);
                    endDayYear      = int.Parse(numbers[2]);
                }
                else
                {
                    //where [0] element is date of starting weekday
                    //      [1] element is year of starting weekday
                    //      [2] element is date of ending weekday
                    //      [3] element is year of ending weekday
                    startDayDate    = int.Parse(numbers[0]);
                    startDayYear    = int.Parse(numbers[1]);
                    endDayDate      = int.Parse(numbers[2]);
                    endDayYear      = int.Parse(numbers[3]);
                }

                textBox_StartDayDate.Text   = startDayDate.ToString();
                textBox_StartDayYear.Text   = startDayYear.ToString();

                textBox_EndDayDate.Text     = endDayDate.ToString();
                textBox_EndDayYear.Text     = endDayYear.ToString();

            }
            else
            {
                //Invalid number of occurrences of numbers found in filename
                //TODO Exception Handling
                textBox_Debug.Text = "Dates invalid";
            }

            //>>>>Step 2: Find Start Month
            //Fetch names of the month appearing in the file name.
            //If it's just one, then month is same for start and end week days.
            //If there're two, then the months are different in start and end week days, meaning a month crossover in the week.
            List<int> monthIndicesFound = new List<int>();

            for (int i = 0; i < strings.Length; i++)
            {
                if(strings[i] != "")
                {
                    for(int j=0; j < monthNames.Length; j++)
                    {
                        //if (strings[i].Contains(monthNames[j], StringComparer.OrdinalIgnoreCase))
                        if(strings[i].IndexOf(monthNames[j], StringComparison.OrdinalIgnoreCase) > 0 )
                        {
                            monthIndicesFound.Add((j+1));
                        }
                    }
                }
            }

            if ( (monthIndicesFound.Count > 0) && (monthIndicesFound.Count < 3))
            {
                if (monthIndicesFound.Count == 1)
                {
                    startDayMonth = monthIndicesFound[0];
                    endDayMonth = monthIndicesFound[0];
                }
                else
                {
                    startDayMonth = monthIndicesFound[0];
                    endDayMonth = monthIndicesFound[1];
                }

                textBox_StartDayMonth.Text   = startDayMonth.ToString();
                textBox_EndDayMonth.Text     = endDayMonth.ToString();
            }
            else
            {
                //Invalid number of months found in file name.
                //TODO Exception Handling
                textBox_Debug.Text = "Dates invalid";
            }

            if(validateDates() == true)
            {
                textBox_Debug.Text = "Dates valid";
            }
            else
            {
                textBox_Debug.Text = "Dates invalid";
            }

            //foreach (string value in numbers)
            //{
            //    if (!string.IsNullOrEmpty(value))
            //    {
            //        int i = int.Parse(value);
            //        Console.WriteLine("Number: {0}", i);
            //    }
            //}
        }

        private bool validateDates()
        {
            bool result = true;

            //Check if year is in 2 digit for. Convert in 4 digit if required.
            if (startDayYear - 2000 < 0)
            {
                startDayYear = startDayYear + 2000;
            }

            if (endDayYear - 2000 < 0)
            {
                endDayYear = endDayYear + 2000;
            }

            if(startDayYear > endDayYear)
            {
                result = false;
            }
            else
            {
                if ((startDayMonth == 0) || (startDayMonth > 12) || (endDayMonth == 0) || (endDayMonth > 12))
                {
                    result = false;
                }
                else
                {
                    if((startDayYear == endDayYear) && (startDayMonth > endDayMonth))
                    {
                        result = false;
                    }
                    else
                    {
                        if((startDayYear == endDayYear) && (startDayMonth == endDayMonth) && (startDayDate >= endDayDate))
                        {
                            result = false;
                        }
                        else
                        {
                            if( (startDayDate == 0) || (endDayDate == 0) || (startDayDate > 31) || (endDayDate > 31) )
                            {
                                result = false;
                            }
                            else
                            {
                                if ( (startDayMonth == 4) || (startDayMonth == 6) || (startDayMonth == 9) || (startDayMonth == 11) )
                                {
                                    if (startDayDate > 30)
                                    {
                                        result = false;
                                    }
                                }
                                else
                                {
                                    if( (startDayYear %4 != 0) && (startDayMonth == 2) && (startDayDate > 28) )
                                    {
                                        result = false;
                                    }
                                }

                                if ( (endDayMonth == 4) || (endDayMonth == 6) || (endDayMonth == 9) || (endDayMonth == 11) )
                                {
                                    if (endDayDate > 30)
                                    {
                                        result = false;
                                    }
                                }
                                else
                                {
                                    if ((endDayYear % 4 != 0) && (endDayMonth == 2) && (endDayDate > 28))
                                    {
                                        result = false;
                                    }
                                }

                                //Final test - check if the start date and end date cover one entire week
                                if (result == true)
                                {
                                    weekStartDay = new DateTime(startDayYear, startDayMonth, startDayDate);
                                    weekEndDay = new DateTime(endDayYear, endDayMonth, endDayDate);

                                    if ((weekEndDay - weekStartDay).Days != 4)
                                    {
                                        result = false;
                                    }
                                    else
                                    {
                                        //Phew! All test passed.
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
