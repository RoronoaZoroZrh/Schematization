using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schematization
{
    //!主窗体
    public partial class FormSchematization : Form
    {
        //!构造函数
        public FormSchematization()
        {
            InitializeComponent();
        }

        //!创建任务
        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            List<String> vTaskTypes = m_vData.GetTaskTypes();
            FormCreateTask vForm = new FormCreateTask(vTaskTypes);
            if (vForm.ShowDialog(this) == DialogResult.OK)
            {
                m_vData.CreateTask(vForm.TaskType, vForm.TaskName);
            }
        }

        //!数据
        private DataLayer m_vData = new DataLayer();
    }
}