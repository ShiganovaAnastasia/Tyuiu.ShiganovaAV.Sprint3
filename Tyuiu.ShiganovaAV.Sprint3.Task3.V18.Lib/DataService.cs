using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char c in value)
            {
                if (c >= '0' && c <= '9')
                {
                    result += item; 
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
