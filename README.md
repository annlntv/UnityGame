

как сделать экран победы:

создать Canvas, назвать его например CanvasWin, к нему прикрепить объект Image (по аналогии со смертью). Загрузить саму картинку в ассеты, поставить ей тип Sprite (2D and UI). Загрузить в компонент Source Image у Image. Убрать галочку слева от названия Canvas. (сделать неактивным). 

Далеее в мир добавить, например, из готовых наборов (package manager) 3 ключа. К каждому из них прикрепить Capsule Collider и сделать триггером. 

Далее в папке проекта создать 3 C# скрипта. Один назвать Key, другой KeysCount и Player UI. По аналогии загрузить туда одноименные скрипты из файлов на этом гитхабе. 

Создать еще один Canvas для интерфейса игрока. Добавить к этому канвас TextMeshPro (TMP), везде где надо нажать импорты и тд. Потом просто закрываем окошечко. Пишем в инспекторе текст любой 

Затем каждый из этих скриптов сохранить Ctrl S. К каждому из ключей перетащить скрипт Key, к префабу игрока перетащить KeysCount и PlayerUI
У скрипта PlayerUi в игроке поставить следующие значения: Canvas --> CanvasWin, KeysCount --> там один префаб игрока, KeysCounterText --> TextMeshPro (TMP). В PlayerUI уже заложено условие победы, вам нужно просто всё установить нормально
