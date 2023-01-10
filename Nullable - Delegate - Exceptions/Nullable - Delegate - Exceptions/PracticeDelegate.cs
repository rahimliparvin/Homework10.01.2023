namespace Nullable___Delegate___Exceptions
{

    public class PracticeDelegate
    {
        #region Predicate
        // public delegate bool CheckNums(int num);

        public bool CheckNumByOdd(int number) => number % 2 == 1;
        //{
        //    return number % 2 == 1;
        //}

        public bool CheckNumByEven(int number) => number % 2 == 0;
        //{
        //    return number % 2 == 0;
        //}
        public bool CheckNumByThanFive(int number) => number > 5;
        //{
        //    return number > 5;
        //}



        public void CheckDelegate()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(GetSumByListItem(CheckNumByOdd, nums));
            //Console.WriteLine(GetSumByListItem(CheckNumByEven, nums));
            //Console.WriteLine(GetSumByListItem(CheckNumByThanFive,nums));
            //  var result = nums.FindAll(m => m > 5).Sum(m=> m);
            // Console.WriteLine(result); 
            //  Console.WriteLine(GetSumByListItem(m=> m > 5 , nums));
        }


        //  public int GetSumNumsByOdd(List<int> nums)
        public int GetSumByListItem(Predicate<int> func, List<int> nums)//CheckNums func ,List<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                // if (item % 2 == 1 )
                if (func(item))
                {
                    sum += item;
                }
            }
            return sum;
        }


        //public void CheckDelegateEven()
        //{
        //    List<int> nums = new List<int>() { 2, 4, 6, 7, 9, 11, 12 };

        //    Console.WriteLine(GetSumsByEven(CheckNumsByEven, nums));
        //}




        //public  int GetSumsByEven(CheckNums func,List<int> nums) 
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))//(item%2==0)
        //        {
        //            sum += item;

        //        }

        //    }
        //    return sum;
        //}

        //public bool CheckNumsByEven(int numbe)
        //{
        //    return numbe % 2 == 0 ;
        //}

        #endregion
        #region Actions
        public delegate void ChangeString(string str);

        public void StringToUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }

        public void StringToLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }

        public void CheckWord()
        {
            //  ShowWord(StringToUpper,"Cavid");
            //ShowWord(StringToLower, "Cavid");
            /// ChangeString changeString = new ChangeString(StringToUpper);
            //ChangeString changeString = StringToUpper;
            // changeString += StringToLower;
            // changeString.Invoke("Pervin");
            //   changeString += (string str) => Console.WriteLine(str.ToLower()) ;
            //{
            //    Console.WriteLine(str.ToLower());
            //};

            // changeString("Pervin");
            //  Action<string> action = StringToUpper;
            //action +=StringToLower;
            //action("Pervin");
        }




        //public void ShowWord(ChangeString func , string str)
        //{
        //    func(str);
        //}

        #endregion
        #region Func
        // public delegate int CheckString(string str, int num);

    //    public int GetStringLength(string str, int num) 
    //    {
    //        return str.Length + num;
    //    }

    //public void GetShowStringLentgh() 
    //    {
    //        ShowString(GetStringLength, "Cavid", 10);
    //    }

    //    public void ShowString(Func<string,int,int> func, string text, int num)
    //    {
    //        Console.WriteLine(func(text, num));
    //    }
        #endregion
    }
}

