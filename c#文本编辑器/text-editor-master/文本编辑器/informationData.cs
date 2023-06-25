using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文本编辑器
{
    public class informationData
    {
        public static string filePath = "d:\\";      //文本路径
        public static bool isTextChanged = false;        //文本是否改变
        public static bool isTextSaved = false;          //文本是否已保存
        public static bool isOpenFile = false;     //文本是否通过打开方式得到的
        public static string text = "";                //保存文本信息，判断是否保存
        public static bool isOpening = false;         //判断是否正在执行打开操作
    }
}
