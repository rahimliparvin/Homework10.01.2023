using Nullable___Delegate___Exceptions;
using Nullable___Delegate___Exceptions.Constans;
using Nullable___Delegate___Exceptions.Exceptions;


#region Nullable

//string name = null;

//if (name ==null)
//{
//    Console.WriteLine("kfvnkn");
//}

////int num = null;
//int? num = null;
//if (num == null )
//{
//    Console.WriteLine("ncsjdnc");
//}


//int? m = 5;

//GetPersonById(m);
//static void GetPersonById(int? id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("null");
//    }
//    else
//    {
//        Console.WriteLine("null deyil");
//    }
//}
#endregion
#region Delegate

//PracticeDelegate calculate = new PracticeDelegate();

//calculate.CheckDelegate();

//calculate.CheckDelegateEven();

//calculate.CheckWord();

//calculate.GetShowStringLentgh();

#endregion
#region Exceptions
//try
//{
//int n = 5;
//int m = 0;
//Divied( n, m);

//var result = n / m;
//int[] array = { 1, 2, 3, 4, };
//array[5] = 100;

//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}
//Divied(5, 1);
//static void Divied(int n,int m)
//{
//	bool IsSuccess = false;
//	try
//	{
//        var result = n / m;
//		IsSuccess = true;
//        Console.WriteLine(result);
//    }
//	catch (Exception ex)
//	{
//     Console.WriteLine(ex.Message);
//    IsSuccess = false;
//    }
//	finally
//	{
//		string message = string.Empty;
//		if (IsSuccess)
//		{
//			message = "Register is ok";
//		}
//		else
//		{
//			message = "Something is wrong";
//		}
//		SendEmail(message);

//	}

//	static  void  SendEmail(string message)
//	{
//		Console.WriteLine(message);
//	}

//}
Login("Pervin1g23", "pervin12345");
static void Login(string username, string password)
{
    try
    {
        if (username == "Pervin123" && password == "pervin12345")
        {
            Console.WriteLine("Login is success");
        }
        else
        {
            throw new InvalidLoginException(ExceptionsMessages.InvalidLogin);
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
#endregion
