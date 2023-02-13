# Описание

* Перебиранный заданный массив и вычисляем количество элементов с 3 и менее символов.
* Создаем новый массив с длинной равной количеству подходящих элементов.
* Записываем в новый массив все подходящие элементы заданного массива.
* Выводим новый массив


# Блок Схема
```mermaid
%%{ init : {  "flowchart" : { "curve" : "linear" }}}%%
graph TD;
    begin(["Начало"]) 
    b1[/"Вводим array[]"/]
    c1["size = 0<br>i = 0"]
    d1{"i < array.Length"}
    d2{"array[i].Length <= 3"}
    c2["size++"]
    c3["i++"]
    c4["string[] newArray = new string[size]<br>i = 0<br> j = 0"]
    d3{"i <= array.Length"}
    d4{"array[i].Length <= 3"}
    c5["newArray[j] = array[i]<br> j++"]
    c6["i++"]
    b2[/"Выводим newArray"/]
    theEnd(["Конец"])
    begin --> b1
    b1 --> c1
    c1 --> d1
    d1 -- да --> d2
    d2 -- да --> c2
    d2 -- нет --> c3
    c2 --> c3
    c3 --> d1
    d1 -- нет --> c4
    c4 --> d3
    d3 -- да --> d4
    d4 -- да --> c5
    c5 --> c6
    d4 -- нет --> c6
    c6 --> d3
    d3 -- нет --> b2
    b2 --> theEnd
    
```
