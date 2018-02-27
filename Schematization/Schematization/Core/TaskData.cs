using System;

namespace Schematization
{
    public class TaskData
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

        //!任务描述
        public String Desc
        {
            get
            {
                return m_sTaskDesc;
            }
            set
            {
                m_sTaskDesc = value;
            }
        }
        private String m_sTaskDesc = "";
    }
}