using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080109_24timeto124
{
    public class Class1
    {
        public string MilitaryTimeToRegularTime(string militaryTime)
        {
            string ff = "";
            if (((militaryTime.Length < 5) || (militaryTime.Length > 5) || (militaryTime[2] != ':')))//去除掉大於小於5字元和不是:的
            {
                ff="error";
            }
            else
            {
                if (((militaryTime[0] == '0') || (militaryTime[0] == '1') || (militaryTime[0] == '2')))//只有24小時制012的可以進入
                {
                    if (militaryTime[0] == '2')//2進入
                    {
                        if (((militaryTime[1] == '0') || (militaryTime[1] == '1') || (militaryTime[1] == '2') || (militaryTime[1] == '3')))//只有24制20、21、22、23進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    if (militaryTime[1] == '0')
                                    {
                                        ff="08" + ":" + militaryTime[3] + militaryTime[4] + "PM";
                                    }
                                    if (militaryTime[1] == '1')
                                    {
                                        ff="09" + ":" + militaryTime[3] + militaryTime[4] + "PM";
                                    }
                                    if (militaryTime[1] == '2')
                                    {
                                        ff="10" + ":" + militaryTime[3] + militaryTime[4] + "PM";
                                    }
                                    if (militaryTime[1] == '3')
                                    {
                                        ff="11" + ":" + militaryTime[3] + militaryTime[4] + "PM";
                                    }
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else
                        {
                            ff="error";
                        }
                    }
                    else if (militaryTime[0] == '1')//1進入
                    {
                        if ((militaryTime[1] == '2'))//12進入
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    ff=militaryTime + "PM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else if (((militaryTime[1] == '0') || (militaryTime[1] == '1')))//只有10、11進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    ff=militaryTime + "AM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else if ((militaryTime[1] == '3') || (militaryTime[1] == '4') || (militaryTime[1] == '5') || (militaryTime[1] == '6') || (militaryTime[1] == '7') || (militaryTime[1] == '8') || (militaryTime[1] == '9'))//13~19進入，已解決
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    int a = (int)militaryTime[0];
                                    int b = (int)militaryTime[1];
                                    a = a - 49;
                                    b = b - 50;
                                    ff=a + b + ":" + militaryTime[3] + militaryTime[4] + "PM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else

                        {
                            ff="error";
                        }
                    }
                    else if ((militaryTime[0] == '0'))//0進入，寫好了
                    {
                        if ((militaryTime[1] == '0'))//00進入
                        {
                            if ((militaryTime[3] == '0'))//00:0進入
                            {
                                if ((militaryTime[4] == '0'))//00:00進入
                                {
                                    ff="12:00" + "AM";
                                }
                                else if (((militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的1~9分鐘進入
                                {
                                    ff=militaryTime + "AM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else if (((militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//00:1~00:5進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的1~9分鐘進入
                                {
                                    ff=militaryTime + "AM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else if (((militaryTime[1] == '1') || (militaryTime[1] == '2') || (militaryTime[1] == '3') || (militaryTime[1] == '4') || (militaryTime[1] == '5') || (militaryTime[1] == '6') || (militaryTime[1] == '7') || (militaryTime[1] == '8') || (militaryTime[1] == '9')))//01~09進入
                        {
                            if (((militaryTime[3] == '0') || (militaryTime[3] == '1') || (militaryTime[3] == '2') || (militaryTime[3] == '3') || (militaryTime[3] == '4') || (militaryTime[3] == '5')))//只有十位數的0~5分鐘進入
                            {
                                if (((militaryTime[4] == '0') || (militaryTime[4] == '1') || (militaryTime[4] == '2') || (militaryTime[4] == '3') || (militaryTime[4] == '4') || (militaryTime[4] == '5') || (militaryTime[4] == '6') || (militaryTime[4] == '7') || (militaryTime[4] == '8') || (militaryTime[4] == '9')))//只有個位數的0~9分鐘進入
                                {
                                    ff=militaryTime + "AM";
                                }
                                else
                                {
                                    ff="error";
                                }
                            }
                            else
                            {
                                ff="error";
                            }
                        }
                        else
                        {
                            ff="error";
                        }
                    }
                    else
                    {
                        ff="error";
                    }
                }
                else
                {
                    ff="error";
                }
            }
            return ff;
        }
    }
}
