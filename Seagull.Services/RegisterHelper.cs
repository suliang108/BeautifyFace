using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using Microsoft.Win32;
using Seagull.Services.Models;

namespace Seagull.Services
{
    public class RegisterHelper
    {

        private static string _section = "Software\\Seagull.BeautifyFace\\Seagull.BeautifyFace";
        private static string _key = "Seagull.BeautifyFace";
        private static string _expiredDate = "20210405";
         
        public static ERegisterStatus InitRegedit()
        {
            /*检查注册表*/
            string SericalNumber = ReadSetting(_section, "SerialNumber", CreatSerialNumber());
            if (SericalNumber == "-1")
            {
                return ERegisterStatus.NotRegister;
            }

            /* 比较CPUid */
            string CpuId = GetSoftEndDateAllCpuId(1, SericalNumber); 
            string CpuIdThis = GetCpuId();
            if (CpuId != CpuIdThis)
            {
                return ERegisterStatus.RegisterCodeError;
            }

            /* 比较时间 */
            string NowDate = RegisterHelper.GetNowDate();
            string EndDate = RegisterHelper.GetSoftEndDateAllCpuId(0, SericalNumber);
            if (Convert.ToInt32(EndDate) - Convert.ToInt32(NowDate) < 0)
            {
                return ERegisterStatus.Expired;
            }

            return ERegisterStatus.Normal;
        }


        /// <summary>
        /// CPUid
        /// </summary>
        /// <returns></returns>
        public static string GetCpuId()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            string strCpuID = null;
            foreach (ManagementObject mo in moc)
            {
                strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                break;
            }
            return strCpuID;
        }

        /// <summary>
        /// 当前时间
        /// </summary>
        /// <returns></returns>
        public static string GetNowDate()
        {
            string NowDate = DateTime.Now.ToString("yyyyMMdd"); 
            return NowDate;
        }

        /// <summary>
        /// 生成序列号
        /// </summary>
        /// <returns></returns>
        public static string CreatSerialNumber()
        {
            string SerialNumber = GetCpuId() + "-" + _expiredDate;
            return SerialNumber;
        }

        /* 
         * i=1 得到 CUP 的id 
         * i=0 得到上次或者 开始时间 
         */
        public static string GetSoftEndDateAllCpuId(int i, string SerialNumber)
        {
            if (i == 1)
            {
                string cupId = SerialNumber.Substring(0, SerialNumber.LastIndexOf("-"));

                return cupId;
            }
            if (i == 0)
            {
                string dateTime = SerialNumber.Substring(SerialNumber.LastIndexOf("-") + 1);
                return dateTime;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 写入注册表
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Setting"></param>
        public static void WriteSetting(string Section, string Key, string Setting)  // name = key  value=setting  Section= path
        {
            string text1 = Section;
            RegistryKey key1 = Registry.CurrentUser.CreateSubKey(Section);
            if (key1 == null)
            {
                return;
            }
            try
            {
                key1.SetValue(Key, Setting);
            }
            catch (Exception ex)
            {
                MyFileHelper.Write(ex.ToString());
            }
            finally
            {
                key1.Close();
            }

        }

        /// <summary>
        /// 读取注册表
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="setValue"></param>
        /// <returns></returns>
        public static string ReadSetting(string Section, string Key, string setValue)
        {
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(Section);
            if (key1 == null)
            {
                var encryValue = Encryption.EncryPW(setValue, _key);
                WriteSetting(Section, Key, encryValue);
                return setValue;
            }
            object obj1 = key1.GetValue(Key, setValue);
            key1.Close();
            if (obj1 != null)
            {
                if (!(obj1 is string))
                {
                    return "-1";
                }
                string obj2 = obj1.ToString();
                obj2 = Encryption.DisEncryPW(obj2, _key);
                return obj2;
            }
            return "-1";
        }
    }
}