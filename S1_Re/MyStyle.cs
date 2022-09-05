using System;
using System.Windows.Forms;

namespace S1_Re
{
    public class MyStyle
    {
        public static System.Drawing.Font getFont(int fontSize = 12)
        {
            return new System.Drawing.Font("楷体", fontSize);
        }

        public static System.Drawing.ContentAlignment GetAlignment()
        {
            return System.Drawing.ContentAlignment.MiddleCenter;
        }
    }


    public class MyBtn : Button
    {
        public MyBtn()
        {
            Font = new System.Drawing.Font("楷体", 15);
        }
    }

    public class MyLab : Label
    {
        public MyLab()
        {
            Font = new System.Drawing.Font("楷体", 12);
        }
    }

    public class MyLabTit : Label
    {
        public MyLabTit()
        {
            Font = MyStyle.getFont(18);
        }
    }

    public class MyConText : TextBox
    {
        public MyConText()
        {
            Font = MyStyle.getFont();
           
        }

        public String V
        {
            get
            {
                return Text.ToString().Trim();
            }
        }

        public bool checkNull
        {
            get
            {
                return V.Length == 0 ? true : false;
            }
        }
    }

    public class MyPan : Panel
    {
        public MyPan()
        {
            BorderStyle =  BorderStyle.FixedSingle;
        }
    }

    public class MyCb : ComboBox
    {
        public MyCb()
        {
            Font = MyStyle.getFont();
        }
    }

    public class MyDgv : DataGridView
    {
        public MyDgv()
        {
            Font = MyStyle.getFont(12);
            RowHeadersVisible = false;

        }
    }

    public class MyDateTP : DateTimePicker
    {
        public MyDateTP()
        {
            CustomFormat = "yyyy/MM/dd";
            Font = MyStyle.getFont();
        }
    }


    //public class My : Button
    //{
    //    public MyBtn()
    //    {
    //        Font = new System.Drawing.Font("楷体", 18);
    //    }
    //}
}
