using System;
using System.Xml;

namespace Schematization
{
    //!任务数据
    public class TaskData
    {
        //!序列化
        public void Serialize(XmlElement vTaskElem)
        {
            XmlElement vDataElem = vTaskElem.OwnerDocument.CreateElement("TaskData");
            vTaskElem.AppendChild(vDataElem);

            XmlAttribute vStateAttr = vTaskElem.OwnerDocument.CreateAttribute("State");
            vStateAttr.Value = m_vTaskState.ToString();
            vDataElem.Attributes.Append(vStateAttr);

            XmlAttribute vNameAttr = vTaskElem.OwnerDocument.CreateAttribute("Name");
            vNameAttr.Value = m_sTaskName;
            vDataElem.Attributes.Append(vNameAttr);

            XmlAttribute vDescAttr = vTaskElem.OwnerDocument.CreateAttribute("Desc");
            vDescAttr.Value = m_sTaskDesc;
            vDataElem.Attributes.Append(vDescAttr);
        }

        //!反序列化
        public void Deserialize(XmlNode vDataElem)
        {
            m_vTaskState = vDataElem.Attributes["State"].Value == "Finish" ? TaskState.Finish : TaskState.UnFinish;
            m_sTaskName = vDataElem.Attributes["Name"].Value;
            m_sTaskDesc = vDataElem.Attributes["Desc"].Value;
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