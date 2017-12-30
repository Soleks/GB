using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

//1. а) создать приложение показанное на уроке;
//б) изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов, и добавив другие косметические улучшения на свое усмотрение;
//в) добавить в приложение меню “О программе” с информацией о программе(автор, версия, авторские права и др.);
//г) добавить в приложение сообщение с предупреждением при попытке удалить вопрос;
//д) добавить пункт меню Save As в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog);

namespace VeryNotVery
{
    //Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string Text { get; set; } //Текст вопроса
        public bool TrueFalse { get; set; } //Правда или нет

        //Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.Text = text;
            this.TrueFalse = trueFalse;
        }
    }

    public class TrueFalse //Database
    {
        string fileName;
        List<Question> list;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        public void Add(Question question)
        {
            list.Add(question);
        }

        public void Remove(int index)
        {
            list.RemoveAt(index);
        }

        //Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get
            {
                if (list != null && index >= 0 && index < list.Count)
                    return list[index];
                else throw new IndexOutOfRangeException("Выход за пределы списка вопросов");
            }
        }

        public void Save(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public void LoadFromTxt(string filename)
        {
            string[] str=File.ReadAllLines(filename);
            //list = new List<Question>();
            //this.fileName = filename;
            foreach (string s in str)
            {
                string[] temp = s.Split('(');
                string text = temp[0];
                bool tf = temp[1].Contains("Да");
                list.Add(new Question(text, tf));
            }

        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
