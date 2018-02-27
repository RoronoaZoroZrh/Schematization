using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schematization
{
    //!创建任务窗体
    public partial class FormCreateTask : Form
    {
        //!构造函数
        public FormCreateTask(List<String> vTaskTypes)
        {
            //!初始化控件
            InitializeComponent();

            //!添加类型
            ComboBoxTaskType.Items.AddRange(vTaskTypes.ToArray());
        }

        //!任务类型
        public String TaskType
        {
            get
            {
                return ComboBoxTaskType.Text.Trim();
            }
        }

        //!任务名称
        public String TaskName
        {
            get
            {
                return TextBoxTaskName.Text.Trim();
            }
        }
    }
}