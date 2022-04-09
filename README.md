## Домашнее задание
Таблица в консоли

### Цель:
В этом задании мы закрепим знания, полученные в ходе вебинара, и сможем воспользоваться циклами и условными операторами

### Описание/Пошаговая инструкция выполнения домашнего задания:
Нужно написать программу, которое делает следующее:\
Вывести текст "введите размерность таблицы:". После этого считать вводимую строку от пользователя в виде целого числа. Если введенная строка не соответствует формату целого числа (не парсится), то нужно повторно вывести текст "введите размерность таблицы:" , и выводить его до тех пор, пользователь не введет корректное число. Число должно быть не меньше 1, и не больше 6. Обозначим его как n.\
Вывести текст "введите произвольный текст:". Если пользователь введет пустой текст, снова выводим "введите произвольный текст:" , до тех пор, пока пользователь не введет непустую строку.\
Нужно вывести таблицу, пример работы программы у которой будут следующие свойства\
Ее ширина не должна превышать 40 символов\
Границы таблицы - символ +\
Ширина таблицы (каждой строки) зависит от числа n и длины введенной строки из п.2.\
Вывести 1ю строку таблицы с текстом, введенным в п.2., который находится на расстоянии n-1 от каждой из границ строки.\
Вывести 2ю строку таблицы. Она имеет ту же высоту, что и строка 1, и представляет собой набор символов +, чередующихся в шахматном порядке.\
Вывести 3ю строку таблицы. Она должна быть квадратной, "перечеркнутая" символом + по диагоналям В программе должны использоваться циклы do while, while и for и ?:
