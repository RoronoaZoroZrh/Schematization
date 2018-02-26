using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schematization
{
    //!任务状态
    public enum TaskState
    {
        Finish,
        UnFinish,
    }

    //!任务
    public class Task
    {
        //!任务状态
        public TaskState State
        {
            get
            {
                return m_vTaskState;
            }
            set
            {
                m_vTaskState = value;
            }
        }
        private TaskState m_vTaskState = TaskState.UnFinish;

        //!任务类别
        public String Type
        {
            get
            {
                return m_sTaskType;
            }
            set
            {
                m_sTaskType = value;
            }
        }
        private String m_sTaskType = "";

        //!任务名称
        public String Name
        {
            get
            {
                return m_sTaskName;
            }
            set
            {
                m_sTaskName = value;
            }
        }
        private String m_sTaskName = "";

        //!任务数据
        private Dictionary<String, String> m_vData = new Dictionary<String, String>();
    }
}