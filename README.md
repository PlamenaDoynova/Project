# Library
.NET Project 
## Курсов проект на тема "Онлайн библиотека"
### Въведение
Проектът е десктоп .NET приложение за онлайн библиотека. Поддържа връзка с база от данни. 
### Login форма 
При стартирането виждаме форма за вход и/или регистрация със съответните валидации при въвеждане на потребителското име и паролата. Ако въведените данни съвпадат с тези от базата с данни след натискане на бутона "вход" ще се отвори формата с менюто, а ако в базата не съществува потребител с такива данни или паролата е неправилна ще се изведе съобщение за грешка. 
### Форма за регистрация 
Ако искаме да се регистрираме (да добавим нов потребител в базата данни) след кликване върху linklabel-а "Регистрация" ще се отвори нова форма за попълване на съответните данни. Формата за регистрация на нов потребител също притежава валидации при въвеждането на данни.
### Роли 
Ако потребителят е влязъл като Guest т.е. обикновен потребител може да вижда част от менюто. За него ще е достъпна секцията "Книги" и ще има възможност да преглежда списъка с книги и да прави промени по тях. 
Ако потребителят е логнат като Admin ще има право да вижда и останалите секции и да прави поромени по тях, а именно "Издателства", "Жанр", "Потребители". 
### Преглед на книгите в библиотеката
Ако искаме да прегледаме списъка с книги ще се отвори нова форма, в която имаме възможност да филтрираме според издателството и жанра, които искаме. При желание за промяна на някоя от книгите можем да редактираме издателството, заглавието, жанра и цената. Можем да добавим изцяло нова книга, а също така и да изтрием вече съществуваща.
### Промени в издателствата и жанровете
Ако искаме да променим издателствата се отваря съответната форма за промяна и имаме възможност да редактираме името на вече създадено в базата данни издателство или да добавим ново такова. При формата за промяната на жанровете на книгите възможностите са същите както при издателствата. Можем да променява вече съществуващ жанр, но можем и да добавим нов.
### Потребители
При секцията "Потребители" от менюто имаме два бутона. Единият е "Преглед", след натискането на който се отваря нова форма с възможност да прегледаме потребителите, които са в базата с данни. Има филтър, който съдържа ролите т.е. дали потребителите са влезли като Guest или като Admin. Чрез тази форма можем да разберем кой потребител е админ и кой е обикновен потребител. Вторият бутон е "Промяна" и след неговото натискане се отваря нова форма. Чрез нея виждаме отново имената, фамилиите и потребителските имена на потребителите. Също така и ролята на съответния потребител (guest или admin). Имаме възможност да променим ролята на някой от потребителите от администратор да стане обикновен потребител и обратното. Също така имаме възможност да изтриваме потребител от базата с данни. 
