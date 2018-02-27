using System;
using System.Xml;

namespace Schematization
{
    //!任务数据
    public class TaskData
    {
        //!序列化
        public void Serialize(XmlElement vRootElem)
        {
            XmlElement vDataElem = vRootElem.OwnerDocument.CreateElement("Data");
            vRootElem.AppendChild(vDataElem);

            XmlAttribute vStateAttr = vRootElem.OwnerDocument.CreateAttribute("State");
            vStateAttr.Value = m_vTaskState.ToString();
            vDataElem.Attributes.Append(vStateAttr);

            XmlAttribute vNameAttr = vRootElem.OwnerDocument.CreateAttribute("Name");
            vNameAttr.Value = m_sTaskName;
            vDataElem.Attributes.Append(vNameAttr);

            XmlAttribute vDescAttr = vRootElem.OwnerDocument.CreateAttribute("Desc");
            vDescAttr.Value = m_sTaskDesc;
            vDataElem.Attributes.Append(vDescAttr);
        }

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