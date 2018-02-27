using System;
using System.Collections.Generic;

namespace Schematization
{
    //!数据层
    public class DataLayer
    {
        //!创建任务
        public void CreateTask(String sTaskType, String sTaskName)
        {
            m_vTaskList.Add(new Task { Type = sTaskType, Name = sTaskName });
            m_vTaskList[m_vTaskList.Count - 1].Serialize();
        }

        //!获取任务类别
        public List<String> GetTaskTypes()
        {
            List<String> vTaskTypes = new List<String>();
            m_vTaskList.ForEach(vTask =>
                {
                    if (vTaskTypes.Contains(vTask.Type))
                    {
                        vTaskTypes.Add(vTask.Type);
                    }
                });
            return vTaskTypes;
        }

        //!任务
        private List<Task> m_vTaskList = new List<Task>();
    }
}