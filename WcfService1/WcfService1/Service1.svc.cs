using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    public class Service1 : IService1
    {

        public string TestConnection()
        {
            return "OK";
        }
        public string Auten(string value1, string value2)
        {
           if ((value1 == String.Format("nata") && value2 == String.Format("123")) || (value1 == String.Format("user") && value2 == String.Format("password"))) 
           {
               return "OK";
           }
           else
           {
               return " ";
           }
        }


        public string GetData(string value)
        {
            return string.Format("Здравствуйте, {0}. Как дела?", value);
        }

        public string Message1(string value)
        {

            if (value == String.Format("хорошо") || value == String.Format("Хорошо"))
            {
                return string.Format("Это просто отлично!", value);
            }
            else
            {
                return string.Format("Почему же не отлично?", value);
            }

        }

      
    }
}
