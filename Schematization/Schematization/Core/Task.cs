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
            XmlElement vRootElem = vXmlDoc.CreateElement("TaskData");
            vXmlDoc.AppendChild(vRootElem);

            //!数据节点
            foreach (KeyValuePair<String, String> vPair in m_vData)
            {
                XmlElement vDataElem = vXmlDoc.CreateElement("Data");
                vRootElem.AppendChild(vDataElem);

                XmlAttribute vDataAttr = vXmlDoc.CreateAttribute(vPair.Key);
                vDataAttr.Value = vPair.Value;
                vDataElem.Attributes.Append(vDataAttr);
            }

            //!保存文档
            String sFileName = "../../Data/" + m_sTaskName + ".xml";
            Directory.CreateDirectory(Path.GetDirectoryName(sFileName));
            if (File.Exists(sFileName)) File.SetAttributes(sFileName, FileAttributes.Normal);
            vXmlDoc.Save(sFileName);
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