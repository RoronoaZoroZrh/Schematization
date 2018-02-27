using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

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
        //!序列化
        public void Serialize()
        {
            //!文档
            XmlDocument vXmlDoc = new XmlDocument();

            //!Declaration
            XmlDeclaration vDec = vXmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            vXmlDoc.AppendChild(vDec);

            //!根节点
            XmlElement vRootElem = vXmlDoc.CreateElement("TaskRoot");
            vXmlDoc.AppendChild(vRootElem);

            //!任务节点
            XmlElement vTaskElem = vXmlDoc.CreateElement("Task");
            vRootElem.AppendChild(vTaskElem);

            //!任务类别
            XmlAttribute vTypeAttr = vXmlDoc.CreateAttribute("Type");
            vTypeAttr.Value = m_sTaskType;
            vTaskElem.Attributes.Append(vTypeAttr);

            //!任务状态
            XmlAttribute vStateAttr = vXmlDoc.CreateAttribute("State");
            vStateAttr.Value = m_vTaskState.ToString();
            vTaskElem.Attributes.Append(vStateAttr);

            //!任务名称
            XmlAttribute vNameAttr = vXmlDoc.CreateAttribute("Name");
            vNameAttr.Value = m_sTaskName;
            vTaskElem.Attributes.Append(vNameAttr);

            //!任务数据
            m_vData.ForEach(vData => vData.Serialize(vRootElem));

            //!保存文档
            String sFileName = "../../Data/" + m_sTaskName + ".xml";
            Directory.CreateDirectory(Path.GetDirectoryName(sFileName));
            if (File.Exists(sFileName)) File.SetAttributes(sFileName, FileAttributes.Normal);
            vXmlDoc.Save(sFileName);
        }

        //!反序列化
        public void Deserialize(String sFileName)
        {
            if (File.Exists(sFileName))
            {
                //!文档
                XmlDocument vXmlDoc = new XmlDocument();
                vXmlDoc.Load(sFileName);

                //!根节点
                XmlNode vRootElem = vXmlDoc.SelectSingleNode("TaskRoot");

                //!任务节点
                XmlNode vTaskElem = vRootElem.SelectSingleNode("Task");

                //!任务类别
                m_sTaskType = vTaskElem.Attributes["Type"].Value;

                //!任务状态
                m_vTaskState = vTaskElem.Attributes["State"].Value == "Finish" ? TaskState.Finish : TaskState.UnFinish;

                //!任务名称
                m_sTaskName = vTaskElem.Attributes["Name"].Value;

                //!任务数据
                m_vData.Clear();
                foreach (XmlNode vNodeItr in vTaskElem.SelectNodes("TaskData"))
                {
                    TaskData vNewTaskData = new TaskData();
                    vNewTaskData.Deserialize(vNodeItr);
                }
            }
        }

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

        //!任务数据
        private List<TaskData> m_vData = new List<TaskData>();
    }
}