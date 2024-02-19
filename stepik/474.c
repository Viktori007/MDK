/*https://stepik.org/lesson/1191290/step/6?unit=1204278
Подвиг 6. Продолжите программу. Используя указатели p1 и p2 определите сколько переменных типа double уместится в памяти, начиная с адреса p1 и заканчивая адресом p2 (не включая ячейку с адресом p2). Выведите вычисленное число переменных в консоль в виде целого числа.*/

#include <stdio.h>

int main(void)
{
    double value;

    scanf("%lf", &value);

    char* b_ptr = (char*)&value;

    for (int i = 0; i < 8; i++)
    {
        printf("%d ", b_ptr[i]);
    }


    return 0;
}
