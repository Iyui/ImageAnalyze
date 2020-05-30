﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GmageIF;
using System.IO;
using System.Reflection;
using System.Drawing;
namespace Gmage
{
    internal static class Program
    {
        internal static string[] MyArgs;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            MyArgs = args;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mf = new MainForm();
            ReadExpansionDll(mf);
            Application.Run(mf);
        }

        internal static void ReadExpansionDll(MainForm mf)
        {
            //搜索某路径下所有dll
            foreach (string fn in Directory.GetFiles(Application.StartupPath+"\\expansion\\", "*.dll"))
            {
                //获取程序集
                Assembly ass = Assembly.LoadFrom(fn);
                //遍历包含的类型
                foreach (Type t in ass.GetTypes())
                {
                    //判断是否是实现了插件接口
                    if (t.GetInterface("IGmage",true) !=null)
                    {
                        Set_ToolStripMenuItem(mf);
                        //创建实例
                        object o = ass.CreateInstance(t.ToString());
                        //获取方法
                        MethodInfo mi = t.GetMethod("Mage");
                        //执行方法
                        mi.Invoke(o, new object[] { new Bitmap(1, 1) });
                    }
                }
            }
        }

        internal static void Set_ToolStripMenuItem(MainForm f)
        {
            string IName = "接口测试";
            ToolStripMenuItem items = new ToolStripMenuItem()
            {
                Name = "tsmi_" + IName,
                Text = IName,
                Tag = "tp_" + IName,
            };
            //items.Click += tsmi_Index_Click;
            f.滤镜ToolStripMenuItem.DropDownItems.Add(items);
        }
    }
}
