﻿


CREATE TABLE QuestionForm1
(
IdQuestion INT IDENTITY PRIMARY KEY,
QuestionText NVARCHAR(1000),
Answer NVARCHAR(1000),
QuestionPoint INT
);

SELECT * FROM QuestionForm1

--TRUNCATE TABLE QuestionForm1

/*

CREATE TABLE "Question" (
	"IdQuestion"	INTEGER NOT NULL UNIQUE,
	"QuestionText"	NVARCHAR(1000),
	"Answer"	NVARCHAR(1000),
	"QuestionPoint"	INTEGER,
	PRIMARY KEY("IdQuestion" AUTOINCREMENT)
);

////  ШАБЛОН         ШАБЛОН           ШАБЛОН          ШАБЛОН          ШАБЛОН       ШАБЛОН         ШАБЛОН       ШАБЛОН  
SELECT * FROM Question

INSERT INTO Question (QuestionText, Answer, QuestionPoint, QuestionCategory)
VALUES 
('Назовите','Гос', 100, 'Это'),
('Назовите','Гос', 200, 'Это'),
('Назовите','Гос', 300, 'Это'),
('Назовите','Гос', 400, 'Это'),
('Назовите','Гос', 500, 'Это')

///       ШАБЛОН         ШАБЛОН           ШАБЛОН           ШАБЛОН            ШАБЛОН           ШАБЛОН    ШАБЛОН    ШАБЛОН


SELECT * FROM Question

INSERT INTO Question (QuestionText, Answer, QuestionPoint)
VALUES 
('Назовите наименование этого гост-а (ГОСТ 50530)','Патроны к гражданскому и служебному огнестрельному оружию, устройствам производственного и специального назначения', 100),
('Как называется допуск расстояния между геометрическим элементом патронника, на который патрон опирается в своем крайнем продвинутом внутрь патронника положении, и срезом затвора или поверхностью коробки оружия переломной конструкции, на которую опирается донная часть гильзы патрона','Зеркальный зазор', 200),
('Дробь, не содержащая свинец, изготовленная из чистого металла или сплава, химический состав и физические свойства которого во всех частях одинаковы или меняются непрерывно, без скачков, без поверхностей раздела','Гомогенная дробь, не содержащая свинец ', 300),
('Требования настоящего стандарта не распространяются на (найти лишнее):
1)	патроны, предназначенные только для ведения боевых действий
2)	патроны, изготовленные или повторно снаряженные для личного пользования
3)	патроны, предназначенные для испытаний 
',' 3) патроны, предназначенные для испытаний ', 400),
('Как называется патрон для оружия с гладким стволом, предназначенный для стрельбы только из соответствующего оружия, которое было подвергнуто усиленному испытанию или испытанию "Стальная дробь"','Мощный патрон', 500)



-- Заполним вторую 5-ку вопросов
INSERT INTO Question (QuestionText, Answer, QuestionPoint)
VALUES 
('Перед стрельбой на гильзах патронов не допускаются следующие дефекты:
1)	продольные трещины у среза гильзы длиной, равной или менее 3 мм, превышающие количество, указанное в таблице 5 пункта 6.3.5.3 настоящего стандарта
2)	продольные трещины у среза гильзы длиной более 3 мм
3)	любые другие продольные и/или поперечные трещины
4)	нарушение целостности донной части гильзы
5)	все вышеперечисленные
','5) все вышеперечисленные', 100),
('Контроль изготовления патронов проводится в процессе изготовления каждой партии патронов:
1)	Каждой партии патронов
2)	Каждой пятой партии патронов
3)	Каждой десятой партии патронов
','1)	Каждой партии патронов', 200),
('Какой вид контроля патронов не осуществляются:
1)	контроль типа патрона
2)	контроль изготовления
3)	инспекционный контроль
4)	контроль на неразрывность
5)	все вышеперечисленные
','4)	контроль на неразрывность', 300),
('Контроль изготовления партии патронов включает:
1)	проверку наличия отличительной маркировки на каждом патроне
2)	контроль среднего значения давления или энергии, контроль среднего значения скорости и количества движения патронов, снаряженных дробью, не содержащей свинец, типов В и С
3)	проверку безопасности функционирования
4)	все вышеперечисленные
','4)	все вышеперечисленные', 400),
('При испытании стрельбой не допускаются следующие дефекты:
1)	утечка газа назад за затвор
2)	застревание в стволе метаемого элемента или его части
3)	нарушение целостности гильзы, которая полностью или частично остается в стволе
4)	разрыв донной части гильзы
','4)	разрыв донной части гильзы', 500)

_______
мои вопросы потом были
___


SELECT * FROM Question

INSERT INTO Question (QuestionText, Answer, QuestionPoint, QuestionCategory)
VALUES 
('Назовите виды испатаний по уровню проведения','Государственные, межведомственные, ведомственные', 100, 'Это база'),
('Назовите виды испатаний по уровню воздействия','Неразрушающие и разрушающие', 200, 'Это база'),
('Что такое пороховая проба?','Старый метод испытания стволов', 300, 'Это база'),
('На какой ствол устанавливается крешерный прибор?','на баллистический', 400, 'Это база'),
('Оружие, прошедшее испытание на прочность и безопасность, подвергается контролю/испытанию на ...','кучность и точность стрельбы', 500, 'Это база')

_____


SELECT * FROM Question

INSERT INTO Question (QuestionText, Answer, QuestionPoint, QuestionCategory)
VALUES 
('Измерения давления пороховых газов в случае дробовых патронов центрального боя к гладкоствольному оружию. Внутренние размеры каналов патронников стволов должны соответствовать ...(max or min?) размерам, предписанным ПМК','минимальным', 100, 'Сертификация служ. и гражд.'),
('Среднее арифметическое максимального давления испытательного патрона должно быть на ???% больше максимального давления, допустимого для коммерческого боеприпаса','25%', 200, 'Сертификация служ. и гражд.'),
('Измерение кинетической энергии вместо давления газов оправдано в следующих случаях:
1) объем камеры горения столь мал, что установка манометра может исказить нормальный характер изменения давления;
2) масса метаемого элемента близка по своему значению массе гильзы(у патронов кольцевого воспламенеия);
3) давление измеряется у боеприпаса с незакрепленным метаемым элементом (снарядом);
4) отсутствует манометр (датчик), адекватный измеряемому давлению (новый или редко используемый боеприпас)
 Укажите лишнее
','2) масса метаемого элемента близка по своему значению массе гильзы - это явный бред', 300, 'Сертификация служ. и гражд.'),
('Скорость пули V определяется посредством измерения времени, в течение которого пуля проходит между двумя точками траектории, при этом:
- первая точка располагается на расстоянии ??? м от дульного среза ствола, а вторая – на расстоянии ??? м;
','0,5 и 1,5 м', 400, 'Сертификация служ. и гражд.'),
('Сертификация модели может проводиться при постановке на производство вновь разработанного образца объекта подтверждения соответствия, при серийном производстве объекта подтверждения соответствия, а также при первичном ввозе на территорию РФ, испытания на: (их 3 шт)','прочность и безопасность функционирования,соответствие медико-биологическим и химико-аналитическим требованиям, соответствие криминалистическим требованиям', 500, 'Сертификация служ. и гражд.')

------------






















*/

-- Заполним первуя 5-ку вопросов
INSERT INTO QuestionForm1
VALUES 
(N'Назовите наименование этого гост-а (ГОСТ 50530)',N'Патроны к гражданскому и служебному огнестрельному оружию, устройствам производственного и специального назначения', 100),
(N'Как называется допуск расстояния между геометрическим элементом патронника, на который патрон опирается в своем крайнем продвинутом внутрь патронника положении, и срезом затвора или поверхностью коробки оружия переломной конструкции, на которую опирается донная часть гильзы патрона',N'Зеркальный зазор', 200),
(N'Дробь, не содержащая свинец, изготовленная из чистого металла или сплава, химический состав и физические свойства которого во всех частях одинаковы или меняются непрерывно, без скачков, без поверхностей раздела',N'Гомогенная дробь, не содержащая свинец ', 300),
(N'Требования настоящего стандарта не распространяются на (найти лишнее):
1)	патроны, предназначенные только для ведения боевых действий
2)	патроны, изготовленные или повторно снаряженные для личного пользования
3)	патроны, предназначенные для испытаний 
',N' 3) патроны, предназначенные для испытаний ', 400),
(N'Как называется патрон для оружия с гладким стволом, предназначенный для стрельбы только из соответствующего оружия, которое было подвергнуто усиленному испытанию или испытанию "Стальная дробь"',N'Мощный патрон', 500)


-- Заполним вторую 5-ку вопросов
INSERT INTO QuestionForm1
VALUES 
(N'Перед стрельбой на гильзах патронов не допускаются следующие дефекты:
1)	продольные трещины у среза гильзы длиной, равной или менее 3 мм, превышающие количество, указанное в таблице 5 пункта 6.3.5.3 настоящего стандарта
2)	продольные трещины у среза гильзы длиной более 3 мм
3)	любые другие продольные и/или поперечные трещины
4)	нарушение целостности донной части гильзы
5)	все вышеперечисленные
',N'5) все вышеперечисленные', 100),
(N'Контроль изготовления патронов проводится в процессе изготовления каждой партии патронов:
1)	Каждой партии патронов
2)	Каждой пятой партии патронов
3)	Каждой десятой партии патронов
',N'1)	Каждой партии патронов', 200),
(N'Какой вид контроля патронов не осуществляются:
1)	контроль типа патрона
2)	контроль изготовления
3)	инспекционный контроль
4)	контроль на неразрывность
5)	все вышеперечисленные
',N'4)	контроль на неразрывность', 300),
(N'Контроль изготовления партии патронов включает:
1)	проверку наличия отличительной маркировки на каждом патроне
2)	контроль среднего значения давления или энергии, контроль среднего значения скорости и количества движения патронов, снаряженных дробью, не содержащей свинец, типов В и С
3)	проверку безопасности функционирования
4)	все вышеперечисленные
',N'4)	все вышеперечисленные', 400),
(N'При испытании стрельбой не допускаются следующие дефекты:
1)	утечка газа назад за затвор
2)	застревание в стволе метаемого элемента или его части
3)	нарушение целостности гильзы, которая полностью или частично остается в стволе
4)	разрыв донной части гильзы
',N'4)	разрыв донной части гильзы', 500)





