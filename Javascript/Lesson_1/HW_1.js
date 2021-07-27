// Запрашивать данные у пользователя необходимо с помощью 
// prompt(), а выводить результат с помощью alert().
// 1. Запросите у пользователя его имя и выведите в ответ: 
// «Привет, его имя!».

    // function greeting(){
    //     let name = prompt("Как тебя зовут ?", "имя");
    //     alert(`Привет, ${name}!`);
        
    // }
    // greeting();
        
// 2. Запросите у пользователя год его рождения, посчитайте, 
// сколько ему лет и выведите результат. Текущий год укажите 
// в коде как константу.

    // function calculateAge(){
    //     let birthYear = prompt("В каком году Вы родились ?", "год рождения");
    //     const date = new Date();
    //     const currentYear = date.getFullYear();
    //     alert(`Привет, Вам исполнилось ${currentYear-birthYear} лет!`);
        
    // }
    // calculateAge();

// 3. Запросите у пользователя длину стороны квадрата и выведите периметр такого квадрата. 

    // function perimeterOfSquare(){
    //     let length = prompt("Введите длину стороны квадрата (см)", "длина квадрата");
    //     alert(`Периметр квадрата равен ${length*4} (см)`);
    // }
    // perimeterOfSquare();

// 4. Запросите у пользователя радиус окружности и выведите 
// площадь такой окружности.

    // const Pi = 3.14;
    // function areaOfCircle(){
    //     let radius = prompt("Введите радиус окружности (см)", "радиус окружности");
    //     alert(`Площадь круга составляет ${Pi*radius*radius} (см^2)`);
    // }
    // areaOfCircle();

// 5. Запросите у пользователя расстояние в км между двумя 
// городами и за сколько часов он хочет добраться. Посчитайте скорость, с которой необходимо двигаться, чтобы 
// успеть вовремя.

    // function moveSpeed (){
    //     let distance = prompt("Введите растояние между двумя городами (км)", "расстояние между городами");
    //     let timeMove = prompt("За какое время Вы хотите добраться", "время движения");
    //     alert(`Для того, чтобы проехать ${distance} км за ${timeMove} часов Вам необходимо двигаться со скоростью ${distance/timeMove} км/ч`);
    // }
    // moveSpeed();

// 6. Реализуйте конвертор валют. Пользователь вводит доллары, программа переводит в евро. Курс валюты храните в 
// константе.

    // let dollarToEuro = 0.85;
    // function exchangeRates(){
    //     let dollars = prompt("Сколько долларов Вы хотите поменять на евро ?", "сумма в долларах");
    //     alert(`При обменном курсе доллара к евро - ${dollarToEuro} за ${dollars} долларов Вы можете получить ${dollars*dollarToEuro} евро`);
    // }
    // exchangeRates();

// 7. Пользователь указывает объем флешки в Гб. Программа 
// должна посчитать сколько файлов размером в 820 Мб помещается на флешку.

    // let sizeOfFile = 820;
    // function numberOfFlash(){
    //     let volumeOfFlash = prompt("Укажите объем флешки (Гб)", "объем флешки");
    //     let volumeOfFlashMB = volumeOfFlash*1024;

    //     if(volumeOfFlashMB%sizeOfFile===0){
    //         alert(`Во флешке объемом ${volumeOfFlash} Гб помещается ровно ${volumeOfFlashMB/sizeOfFile} флешек по ${sizeOfFile} Мб`);
    //     }
    //     else {
    //         alert(`Во флешке объемом ${volumeOfFlash} Гб помещается ${parseInt(volumeOfFlashMB/sizeOfFile)} флешек по ${sizeOfFile} Мб и остается свободное пространство размером ${volumeOfFlashMB%sizeOfFile} Мб`);
    //     }
    // }
    // numberOfFlash();

// 8. Пользователь вводит сумму денег в кошельке и цену одной шоколадки. Программа выводит сколько шоколадок    // может  купить пользователь и сколько сдачи у него останется. 

    // function numberOfChokolates(){
    //     let money = prompt("Сколько денег у Вас в кошельке ?", "количество денег");
    //     let priceOfChocolate = prompt("Какая цена одной шоколадки ?", "цена шоколадки");
    //     alert(`При наличии в кошельке ${money} гривен Вы можете купить ${parseInt(money/priceOfChocolate)} шоколадок и у Вас останется ${money%priceOfChocolate} гривен сдачи`)
    // }
    // numberOfChokolates();

// 9. Запросите у пользователя трехзначное число и выведите 
// его задом наперед. Для решения задачи вам понадобится 
// оператор % (остаток от деления).

    function flipNumber(){
        let number = prompt("Введите трехзначное число", "число");
        let turnNumber1 = number%10;
        let turnNumber2 = (number%100 - turnNumber1)/10;
        let turnNumber3 = (number%1000 - turnNumber1 - turnNumber2*10)/100;
        let turnNumber = turnNumber1*100 + turnNumber2*10 + turnNumber3;
        alert(`Вы ввели число - ${number}, перевернутое число -  ${turnNumber}`);
    }
    flipNumber();


// 10. Запросите у пользователя целое число и выведите в ответ, 
// четное число или нет. В задании используйте логические 
// операторы. В задании не надо использовать if или switch.
