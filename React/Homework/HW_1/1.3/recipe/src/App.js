import React from "react";
import './App.css';

let dishes = [
  { id: 1, nameDish: "Вареники с картофелем", 
            ingredients: [{"мука": "200 гр"}, {"яйцо": 1}, {"картофель": "400 гр"}, {"соль": "5 гр"}, {"перец": "2 гр"}], 
            subsequence: ["Помыть и почистить продукты", "", "", ""], 
            foto: "" },
  { id: 2, nameDish: "Пельмени", 
            ingredients: ["мука", "яйцо", "свинина/говядина", "соль", "перец"], 
            subsequence: ["Помыть и почистить продукты", "", "", ""], 
            foto: "" },
  { id: 3, nameDish: "Бифф Веллингтон", 
            ingredients: ["говядина", "грибы", "мука", "соль", "перец"], 
            subsequence: ["Помыть и почистить продукты", "", "", ""], 
            foto: "" },
  { id: 4, nameDish: "Сациви", 
            ingredients: ["мука", "яйцо", "соль", "картофель", "перец"], 
            subsequence: ["Помыть и почистить продукты", "", "", ""], 
            foto: "" },
  { id: 5, nameDish: "Шашлыки", 
            ingredients: ["свинина", "лук", "майонез", "соль", "перец"], 
            subsequence: ["Помыть и почистить продукты", "", "", ""], 
            foto: "" },
]

class Header1 extends React.Component {
  render() {
    return (
      <div className="header1">
        <h1>{this.props.title}</h1>
        <hr/>
      </div>
    );
  }
}

class Header3 extends React.Component {
  render() {
    return (
      <div className="header3">
        <h3>{this.props.title}</h3>
        <hr/>
      </div>
    );
  }
}

class NameOfDish extends React.Component {
  render() {
    return (
      <div>
        <h3>Название блюда: <text className="dishName">"{this.props.nameDish}"</text></h3>
      </div>
    );
  }
}

// class IngredientsOfDish extends React.Component {
//   render() {
//     return (
//       <div className="ingredientsBlock">
//         <text>{this.props.ingredients.map(item => ("Компонент" + item.ingredients.key +  item.ingredients.key['value']))}</text>
//       </div>
//     );
//   }
// }
// class IngredienstList extends React.Component {
//   render() {
//     return (
//       <div>
//         { dishes.map(item => (<IngredientsOfDish key={item.id} {...item} />))}
//       </div>
//     );
//   }
// }

export default class App extends React.Component {
  render(){
    return (
      <div>
        <Header1 title="Лучшие кулинарные рецепты: " />
        <NameOfDish nameDish="Блюдо" />
        <Header3 title="Составные инградиенты: " />
        {/* <IngredienstList /> */}
        <Header3 title="Способ приготовления: " />
      </div>
    );
  }  
}
