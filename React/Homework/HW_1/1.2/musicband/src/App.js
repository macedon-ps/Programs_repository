import React from "react";
import './App.css';

let musicBand = [
  { id: 1, name: "Владислав", surname: "Вакарчук", role: "вокал", isCurrentMusician: "true" },
  { id: 2, name: "Павел", surname: "Гудимов", role: "гитара", isCurrentMusician: "false" },
  { id: 3, name: "Юрий", surname: "Хусточка", role: "бас-гитара", isCurrentMusician: "false" },
  { id: 4, name: "Денис", surname: "Глинин", role: "ударные", isCurrentMusician: "true" },
  { id: 5, name: "Дмитрий", surname: "Шуров", role: "клавишные", isCurrentMusician: "false" },
  { id: 6, name: "Денис", surname: "Дудко", role: "бас-гитара", isCurrentMusician: "true" },
  { id: 7, name: "Милош", surname: "Елич", role: "клавишные", isCurrentMusician: "true" },
  { id: 8, name: "Петр", surname: "Чернявский", role: "гитара", isCurrentMusician: "false" },
  { id: 9, name: "Владимир", surname: "Опсеница", role: "гитара", isCurrentMusician: "true" },
]

let albums = [
  { id: 1, nameAlbum: "Там, де нас нема", year: 1998, cover: "Tam_de_nas_nema.jpg" },
  { id: 2, nameAlbum: "Янанебібув", year: 2000, cover: "Ja_na_nebi_buv.jpg" },
  { id: 3, nameAlbum: "Модель", year: 2001, cover: "Model.jpg" },
  { id: 4, nameAlbum: "Суперсиметрія", year: 2003, cover: "Supersymetria.jpg" },
  { id: 5, nameAlbum: "GLORIA", year: 2005, cover: "Gloria.jpg" },
  { id: 6, nameAlbum: "Міра", year: 2007, cover: "Mira.jpg" },
  { id: 7, nameAlbum: "Dolce Vita", year: 2010, cover: "Dolce_Vita.jpg" },
  { id: 8, nameAlbum: "Земля", year: 2013, cover: "Zemlya.jpg" },
  { id: 9, nameAlbum: "Без меж", year: 2016, cover: "Bez_mezh.jpg" },
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
class NameOfGroup extends React.Component {
  render() {
    return (
      <div className="App-header">
        <h3>Название группы: <text className="bandName">"{this.props.nameBand}"</text></h3>
      </div>
    );
  }
}
class MembersOfGroup extends React.Component {
  render() {
    return (
      <div className="memberBlock">
        <div className="block1"> <text>{this.props.name} {this.props.surname} </text></div> 
        <div className="block2"> {this.props.role !== "вокал" ? ' Инструмент: ' + this.props.role : this.props.role}</div>
        <div className="block3">{this.props.isCurrentMusician === 'true' ? "В нынешнем составе" : ""}</div> 
      </div>
    );
  }
}
class MemberGroupList extends React.Component {
  render() {
    return (
      <div>
        { musicBand.map(item => (<MembersOfGroup key={item.id} {...item} />))}
      </div>
    );
  }
}

class AlbumssOfGroup extends React.Component {
  render() {
    return (
      <div className="imageBlock">
        <div className="block1"><img src={this.props.cover} alt={this.props.nameAlbum } /> </div>
        <div className="block2">Альбом: {this.props.nameAlbum} </div>
        <div className="block3"> Год создания: {this.props.year} </div>
      </div>
    );
  }
}

class AlbumsList extends React.Component {
  render() {
    return(
      <div>
        {albums.map(item => (<AlbumssOfGroup key={item.id} {...item} />))}
    </div>


    );
  }
}

export default class App extends React.Component {
  render(){
    return (
      <div>
        <Header1 title="Лучшая музыкальная группа: " />
        <NameOfGroup nameBand="Океан Єльзи" />
        <Header3 title="Состав группы: " />
        <MemberGroupList />
        <Header3 title="Альбомы разных лет: " />
        <AlbumsList />
      </div>
    );
  }  
}
