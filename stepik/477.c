/*https://stepik.org/lesson/1191290/step/9?unit=1204278
Подвиг 7 (с повторением). Напишите программу, которая читает из входного потока целое число в переменную count типа int. В каждом байте переменной count нужно включить 3-й и 0-й биты (нумерация бит в байте: 7, 6, 5, 4, 3, 2, 1, 0). Вывести в консоль полученное значение count в виде одного целого числа.*/

#include <stdio.h>

int main(){
    int count;
    scanf("%d", &count);

     for (int i = 0; i < sizeof(int); i++) {
        count |= ((1 << 3) | (1 << 0)) << (8 * i);
    }

    printf("%d", count);
}
