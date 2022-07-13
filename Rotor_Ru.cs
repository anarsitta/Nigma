using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nigma
{
    public class Rotor_Ru
    {
        //Описание переменных класса
        private string layout;
        private byte offset;
        private Rotor_Ru previous, next;
        private Label lbl;
        private char cIn = '\0', notchPos;

        //Конструктор класса ротора
        public Rotor_Ru(string layout, Label lbl, char notchPos)
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
        public void SetNextRotor(Rotor_Ru next)
        {
            this.next = next;
        }

        //Установить предыдущий ротор
        public void SetPreviousRotor(Rotor_Ru previous)
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
                pos = 32 - (offset - pos);
            }
            else
            {
                pos = pos - offset;
            }
            if (previous != null)
            {
                pos = (pos + previous.GetOffset()) % 32;
            }
            return (char)(1040 + pos);
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
            if (offset == 32)
            {
                offset = 0;
            }
            if (next != null && (offset + 1040) == ((notchPos - 1040) % 32) + 1041)
            {
                next.Move();
            }
            lbl.Text = "" + ((char)(1040 + offset));
        }

        //Движение ротора назад
        public void MoveBack()
        {
            //Проверка переполненности ротора
            if (offset == 0)
            {
                offset = 32;
            }
            offset--;

            lbl.Text = "" + ((char)(1040 + offset));
        }

        //Получение данных
        public void PutDataIn(char s)
        {
            cIn = s;
            char c = s;
            c = (char)(((c - 1040) + offset) % 32 + 1040);
            //Проверки
            if (next != null)
            {
                c = layout.Substring((c - 1040), 1).ToCharArray()[0];
                if ((((c - 1040) + (-offset)) % 32 + 1040) >= 1040)
                {
                    c = (char)(((c - 1040) + (-offset)) % 32 + 1040);
                }
                else
                {
                    c = (char)(((c - 1040) + (32 + (-offset))) % 32 + 1040);
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
                c = layout.Substring((cIn - 1040), 1).ToCharArray()[0];
                c = (char)(((c - 1040) + previous.offset) % 32 + 1040);
            }
            return c;

        }
    }
}
