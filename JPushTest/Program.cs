using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using cn.jpush.api;
using Newtonsoft.Json;
using cn.jpush.api.push.mode;
using cn.jpush.api.push.notification;
using cn.jpush.api.common.resp;
using cn.jpush.api.common;

namespace JPushTest
{
    class Program
    {
        static void Main(string[] args)
        {
            JPushUtil jpush = new JPushUtil();
            try
            {
                Hashtable extras = new Hashtable();
                extras.Add("PCode", 145);
                extras.Add("Type", 1);
                extras.Add("Count", 8);
                jpush.sendNotification(new HashSet<string>() {"335"}, TargetType.ALIAS, "测试，请忽略","告警", extras);
            }catch(APIRequestException e){
                //包含http错误码：如401,404等，http错误信息
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorCode);
            }
            catch (APIConnectionException e)
            {
                //包含错误的信息：比如超时，无网络等情况
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }

    }
}
