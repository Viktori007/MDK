/*https://stepik.org/lesson/1191297/step/7?unit=1204285
Подвиг 5. Продолжите программу, в которой объявляется массив text из трех указателей, проиницализированные на строковые литералы:

1-й указатель: "language C"
2-й указатель: "language C++"
3-й указатель: "language Python"

P. S. В консоль ничего выводить не нужно.*/

#include <stdio.h>

int main(void)
{
    char *text[] = { "language C",  "language C++", "language Python"};


    __ASSERT_TESTS__ // макроопределение для тестирования (не убирать и должно идти непосредственно перед return 0)
    return 0;
}
