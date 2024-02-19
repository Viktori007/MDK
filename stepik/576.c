/*https://stepik.org/lesson/1191297/step/9?unit=1204285
Подвиг 7. Продолжите программу, в которой объявляется строка с именем str и максимальной длиной 50 символов (включая символ конца строки). Инициализируйте str строковым литералом "best string!". Затем, вставьте в начало массива str фрагмент "The ", чтобы получилось "The best string!".

P. S. В консоль ничего выводить не нужно.*/

#include <stdio.h>

int main(void)
{
     char str[50];
    strcpy(str, "best string!");

   for (int i=0; i<sizeof(str);i++)
   {
       if (str[i] == 's')
           memmove(str+1, str, i);
   }
   printf("%s", str);
    //__ASSERT_TESTS__ // макроопределение для тестирования (не убирать и должно идти непосредственно перед return 0)
    return 0;
}
