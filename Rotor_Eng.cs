using System;
using System.Text;
using System.Windows.Forms;


namespace Nigma
{
    public class Rotor_Eng
    {
        //Описание переменных класса
        private string layout;
        private byte offset;
        private Rotor_Eng previous, next;
        private Label lbl;
        private char cIn = '\0', notchPos;

        //Конструктор класса ротора
        public Rotor_Eng(string layout, Label lbl, char notchPos)
        {
            //Присвоение внутренним переменным класса значений
            this.layout = layout;
            this.previous = previous;
            this.next = next;
            this.lbl = lbl;
            this.notchPos = notchPos;
            offset = 0;
        }

        //Получение раскладки
        public string GetLayout()
        {
            return layout;
        }

        //Установить следующий ротор
        public void SetNextRotor(Rotor_Eng next)
        {
            this.next = next;
        }

        //Установить предыдущий ротор
        public void SetPreviousRotor(Rotor_Eng previous)
        {
            this.previous = previous;
        }

        //Получить инверсированный символ
        public char GetInverseCharAt(string ch)
        {
            int pos = layout.IndexOf(ch);
            //Проверка на длину символов
            if (offset > pos)
            {
                pos = 26 - (offset - pos);
            }
            else
            {
                pos = pos - offset;
            }
            if (previous != null)
            {
                pos = (pos + previous.GetOffset()) % 26;
            }
            return (char)(65 + pos);
        }

        //Получение смещения
        public int GetOffset()
        {
            return offset;
        }

        //Получение символа
        public char GetNotchPos()
        {
            return notchPos;
        }

        //Обнуление смещения
        public void ResetOffset()
        {
            offset = 0;
        }

        //Проверка
        public bool HasNext()
        {
            return next != null;
        }
        //Проверка
        public bool HasPrevious()
        {
            return previous != null;
        }

        //Движение ротора вперёд
        public void Move()
        {
            //Проверки
            if (next == null)
            {
                return;
            }
            //Смещение
            offset++;
            //Проверка символов и установка нужного
            if (offset == 26)
            {
                offset = 0;
            }
            if (next != null && (offset + 65) == ((notchPos - 65) % 26) + 66) //оо
            {
                next.Move();
            }
            lbl.Text = "" + ((char)(65 + offset));
        }

        //Движение ротора назад
        public void MoveBack()
        {
            //Проверка переполненности ротора
            if (offset == 0)
            {
                offset = 26;
            }
            offset--;

            lbl.Text = "" + ((char)(65 + offset));
        }

        //Получение данных
        public void PutDataIn(char s)
        {
            cIn = s;
            char c = s;
            c = (char)(((c - 65) + offset) % 26 + 65);
            //Проверки
            if (next != null)
            {
                c = layout.Substring((c - 65), 1).ToCharArray()[0];
                if ((((c - 65) + (-offset)) % 26 + 65) >= 65)
                {
                    c = (char)(((c - 65) + (-offset)) % 26 + 65);
                }
                else
                {
                    c = (char)(((c - 65) + (26 + (-offset))) % 26 + 65);
                }
                next.PutDataIn(c);
            }
        }

        //Вывод данных
        public char GetDataOut()
        {
            char c = '\0';
            if (next != null)
            {
                c = next.GetDataOut();
                c = GetInverseCharAt("" + c);
            }
            else
            { //only in the reflector case
                c = layout.Substring((cIn - 65), 1).ToCharArray()[0];
                c = (char)(((c - 65) + previous.offset) % 26 + 65);
            }
            return c;
        }

    }
}
