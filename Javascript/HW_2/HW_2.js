// Домашнее задание 2.
// Вам необходимо самостоятельно решить, для какого задания какой оператор ветвления лучше использовать: if, switch или тернарный.

// 1. Запросить у пользователя его возраст и определить, кем он является: ребенком (0–2), подростком (12–18), взрослым (18_60) или пенсионером (60– ...).

// function userAge(){
//     let age = prompt("Укажите свой возраст", "18");

//     if(isNaN(age)){
//         alert("Вы ввели не число. Повторите еще раз")
//         return false;
//     }
//     if(age>=0 && age<=2) {
//         alert("Вы младенец");
//     }
//     else if(age>2 && age<=12) {
//         alert("Вы ребенок");
//     }
//     else if(age>12 && age<=18) {
//         alert("Вы подросток");
//     }
//     else if(age>18 && age<=60) {
//         alert("Вы взрослый");
//     }
//     else if(age>60 && age<100) {
//         alert("Вы пенсионер");
//     }
//     else if(age>=100) {
//         alert("Поздравляем! Вы долгожитель!)))");
//     }
//     else {
//         alert("Ошибка ввода. Возможно, вы ввели отрицательное число");
//         return false;
//     }
//     return true;
// }
// userAge();

// 2. Запросить у пользователя число от 0 до 9 и вывести ему спецсимвол, который расположен на этой клавише (1–!, 2–@, 3–# и т. д).

    // function numberToSybol(){
    //     let number = prompt("Введите число от 0 до 9", "0");

    //     if(isNaN(number)){
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }
    //     if(number.length != 1) {
    //         alert("Повторите еще раз. Введите одно число в интервале от 0 до 9");
    //         return false;
    //     }
    //     number = parseInt(number);
        
    //     switch(number){
    //         case 0: alert("Числу '0' соответствует символ ')'");
    //         break;
    //         case 1: alert("Числу '1' соответствует символ '!'");
    //         break;
    //         case 2: alert("Числу '2' соответствует символ '@'");
    //         break;
    //         case 3: alert("Числу '3' соответствует символ '#'");
    //         break;
    //         case 4: alert("Числу '4' соответствует символ '$'");
    //         break;
    //         case 5: alert("Числу '5' соответствует символ '%'");
    //         break;
    //         case 6: alert("Числу '6' соответствует символ '^'");
    //         break;
    //         case 7: alert("Числу '7' соответствует символ '&'");
    //         break;
    //         case 8: alert("Числу '8' соответствует символ '*'");
    //         break;
    //         case 9: alert("Числу '9' соответствует символ '('");
    //         break;
    //         default: alert("Попробуйте еще. Введите число из интервала от '0' до '9'");
    //         break;
    //     }
    // }
    // numberToSybol();

// 3. Запросить у пользователя трехзначное и число и проверить, есть ли в нем одинаковые цифры.

    // function numberCheck(){
    //     const number = prompt("Введите 3-х значное число", "111");
        
    //     if(isNaN(number)){
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }
    //     if(number.length != 3) {
    //         alert("Повторите еще раз. Введите 3-х значное число");
    //         return false;
    //     }
    //     const number1 = parseInt(number%10);
    //     const param1 = parseInt(number/10);
    //     const number2 = parseInt(param1%10);
    //     const param2 = parseInt(param1/10);
    //     const number3 = param2;

    //     alert(`number = ${number3}${number2}${number1}`);
                
    //     if(number1==number2 || number2==number3 || number1==number3){
    //         alert(`Во введенном числе ${number} есть одинаковые цифры`);
    //     }
    //     else {
    //         alert(`Во введенном числе ${number} все три цифры разные`);
    //     }
    //     return true;
    // }
    // numberCheck();

// 4. Запросить у пользователя год и проверить, високосный он или нет. Високосный год либо кратен 400, либо кратен 4 и при этом не кратен 100.

    // function isLeapYear(){
    //     const currentYear = parseInt(prompt("Введите год", "2000"));

    //     if(currentYear%400 == 0 || (currentYear%4 == 0 && currentYear%100 != 0)){
    //         alert(`Введенный год - ${currentYear} является высокосным`);
    //         return true;
    //     }
    //     else {
    //         alert(`Введенный год - ${currentYear} не является высокосным`);
    //         return false;
    //     }
    // }
    // isLeapYear();

// 5. Запросить у пользователя пятиразрядное число и определить, является ли оно палиндромом.

    // function isNumberPolyndrom(){
    //     const number = prompt("Введите пятизначное число", "12345");
        
    //     if(isNaN(number)) {
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }         
    //     if(number.length != 5){
    //         alert("Повторите еще раз. Введите 5-ти значное число");
    //         return false;
    //     }
    //     let array = number.split("");
    //     let arrayReverse = array;
    //     arrayReverse = arrayReverse.reverse();
    //     const numberReverse = arrayReverse.join("");

    //     if(number==numberReverse){
    //         alert(`Число ${number} является полиморфным. Проверка: ${number} равно ${numberReverse}`);
    //         return true;
    //     }
    //     else{
    //         alert(`Число ${number} не является полиморфным. Проверка: ${number} не равно ${numberReverse}`);
    //         return false;
    //     }
    // }
    // isNumberPolyndrom();

// 6. Написать конвертор валют. Пользователь вводит количество USD, выбирает, в какую валюту хочет перевести: EUR, UAN или AZN, и получает в ответ соответствующую сумму.

    // function currencyConverter(){
    //     const cursDollarToEuro = 0.8454;
    //     const cursDollarToGryvnia = 26.7744;
    //     const cursDollarToManat = 1.6964;
        
    //     let dollars = prompt("Введите количество долларов, которые вы хотите поменять", "100");

    //     if(isNaN(dollars)) {
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }

    //     let currency = prompt("Курс валют: \n 1 - Евро: продажа - 0.8454 \n 2 - Гривна: продажа - 26.7744 \n 3 - Манат: продажа - 1.6964 \n Введите, какую валюту вы хотите купить", "");
        
    //     switch(currency){
    //         case "1":
    //         case "Евро":
    //         case "евро": {
    //             let summaInCurrency = dollars * cursDollarToEuro;
    //             alert(`Вы получите ${summaInCurrency} евро`);
    //             break;
    //         }
    //         case "2":
    //         case "Гривна":
    //         case "Гривня":
    //         case "гривна": 
    //         case "гривня": {
    //             let summaInCurrency = dollars * cursDollarToGryvnia;
    //             alert(`Вы получите ${summaInCurrency} гривен`);
    //             break;
    //         }
    //         case "3":
    //         case "Манат":
    //         case "манат": {
    //             let summaInCurrency = dollars * cursDollarToManat;
    //             alert(`Вы получите ${summaInCurrency} манат`);
    //             break;
    //         }
    //         default: {
    //             alert(`Ошибка ввода. Повторите еще раз`);
    //             break;
    //         }
    //     }
    // }
    // currencyConverter();

// 7. Запросить у пользователя сумму покупки и вывести сумму к оплате со скидкой: от 200 до 300 – скидка будет 3%, от 300 до 500 – 5%, от 500 и выше – 7%. 
    // const discount3persent = 0.03;
    // const discount5persent = 0.05;
    // const discount7persent = 0.07;
    
    // function calcSummaToBuyWithDiscount(){
    //     let summaBuy = prompt("Введите сумму вашей покупки", "100");

    //     if(isNaN(summaBuy)){
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }

    //     summaBuy = parseInt(summaBuy);
    //     if(summaBuy>=200 && summaBuy<300){
    //         let allSummaToBuy = summaBuy * (1 - discount3persent);
    //         alert(`С учетом скидки ${(discount3persent*100).toFixed(2)}% вам нужно заплатить ${allSummaToBuy.toFixed(2)} гривен`);
    //         return true;
    //     }
    //     else if(summaBuy>=300 && summaBuy<500){
    //         let allSummaToBuy = summaBuy * (1 - discount5persent);
    //         alert(`С учетом скидки ${(discount5persent*100).toFixed(2)}% вам нужно заплатить ${allSummaToBuy.toFixed(2)} гривен`);
    //         return true;
    //     }
    //     else if(summaBuy>=500){
    //         let allSummaToBuy = summaBuy * (1 - discount7persent);
    //         alert(`С учетом скидки ${(discount7persent*100).toFixed(2)}% вам нужно заплатить ${allSummaToBuy.toFixed(2)} гривен`);
    //         return true;
    //     }
    //     else{
    //         let allSummaToBuy = summaBuy;
    //         alert(`У вас нет скидок. Вам нужно заплатить ${allSummaToBuy.toFixed(2)} гривен`);
    //         return true;
    //     }
    // }
    // calcSummaToBuyWithDiscount();

// 8. Запросить у пользователя длину окружности и периметр квадрата. Определить, может ли такая окружность поместиться в указанный квадрат. 

    // const PI = 3.141592;
    
    // function isCircleInSquare(){
    //     let circumference = prompt("Введите длину окружности", "0");
    //     if(isNaN(circumference)){
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }
    //     let perimeterSquare = prompt("Введите периметр квадрата", "0");
    //     if(isNaN(perimeterSquare)){
    //         alert("Вы ввели не число. Повторите еще раз")
    //         return false;
    //     }
        
    //     let diameter = parseFloat(circumference/Math.PI);
    //     let squareLenght = parseFloat(perimeterSquare/4);

    //     if(squareLenght >= diameter){
    //         alert(`В квадрат со стороной ${squareLenght.toFixed(2)}(периметр - ${perimeterSquare}) можно вписать окружность диаметром ${diameter.toFixed(2)} (длина окружности - ${circumference})`);
    //     }
    //     else{
    //         alert(`В квадрат со стороной ${squareLenght.toFixed(2)} (периметр - ${perimeterSquare}) нельзя вписать окружность диаметром ${diameter.toFixed(2)} (длина окружности - ${circumference})`);
    //     }
    // }
    // isCircleInSquare();

// 9. Задать пользователю 3 вопроса, в каждом вопросе по 3 варианта ответа. За каждый правильный ответ начисляется 2 балла. После вопросов выведите пользователю количество набранных баллов.

    function victirina(){
        let arr = [0, 0, 0];
        
        let summaOfPoints = 0;
        let option1 = prompt("Вопрос 1:\n Какая самая высока гора в мире ?\n Варианты ответа:\n 1 - Говерла\n 2 - Джомолунгма\n 3 - Килиманджаро", "0");
        

        let option2 = prompt("Вопрос 2:\n Какая самая длинная река в мире ?\n Варианты ответа:\n 1 - Хуанхе\n 2 - Днепр\n 3 - Нил", "0");


        let option3 = prompt("Вопрос 3:\n Какое самое мелкое море в мире ?\n Варианты ответа:\n 1 - Азовское  море\n 2 - Аральское море\n 3 - Баренцово море", "0");

        if(option1 == 2) {
            arr[0] = 2; 
            summaOfPoints+=arr[0];
        }
        if(option2 ==3) {
            arr[1] = 2;
            summaOfPoints+=arr[1];
        }
        if(option3 == 1) {
            arr[2]= 2;
            summaOfPoints+=arr[2];
        }
        alert(`Вы набрали ${summaOfPoints} баллов за правильные ответы`);
        alert(`Правильные ответы:\n Вопрос 1:\n Какая самая высока гора в мире ? ?\n Джомолунгма - ${arr[0]} баллов\n Вопрос 2:\n Какая самая длинная река в мире ?\n Нил - ${arr[1]} баллов\n Вопрос 3:\n Какое самое мелкое море в мире ?\n Азовское море - ${arr[2]} баллов\n`);
    }
    victirina();

// 10. Запросить дату (день, месяц, год) и вывести следующую за ней дату. Учтите возможность перехода на следующий месяц, год, а также високосный год.