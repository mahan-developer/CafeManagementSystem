using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtilities
{
    public class ErrorHandler
    {
        public static void LogException(Exception ex)
        {
            // لاگ کردن خطا در یک فایل متنی
            File.AppendAllText("errorLog.txt", $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n\n");
        }

        public static string GetFriendlyMessage(Exception ex)
        {
            // بازگشت پیام کاربرپسند
            return "An error occurred. Please try again or contact support.";
        }
    }
}
