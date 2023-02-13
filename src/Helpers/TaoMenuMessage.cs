/*
 * Phần thông báo được tổng hợp để tránh lặp đi lặp lại nhiều lần không cần thiết.
 */
using static System.Console;
namespace KTLT2_TAODOITUONG.src.Helpers
{
    /// <summary>
    /// Thông điệp menu khi nhấn key trên bàn phím
    /// </summary>
    public class TaoMenuMessage
    {
        public static string pressKeyToBye = "Good bye!";
        public static string pressKeyToContinue = "Press any key to continue.";
        public static string pressKeyToExit = "Press any key to exit.";
        public static string pressKeyToEnterCommandOrExit = "Please enter your command or '-1' to exit.";

        internal static void PrintRequestMenu(string[] arrMenu, int stt)
        {
            WriteLine(arrMenu[stt]);
        }
    }
}
