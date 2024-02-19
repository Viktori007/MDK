/*https://stepik.org/lesson/1191288/step/11?unit=1204276
Подвиг 9. Продолжите программу. Объявите указатель ptr_a на переменную a и указатель ptr_b на переменную b. Вычислите произведение значений переменных a и b, используя указатели ptr_a и ptr_b. Результат присвойте переменной res и выведите ее в консоль в виде целого числа.*/
#include <stdio.h>

int main(void)
{
    short a, b;

    scanf("%hd, %hd", &a, &b);
    short* ptr_a = &a;
    short* ptr_b = &b;
    short res = *ptr_a * *ptr_b;
    printf("%hd", res);

    __ASSERT_TESTS__ // макроопределение для тестирования (не убирать и должно идти непосредственно перед return 0)
    return 0;
}
