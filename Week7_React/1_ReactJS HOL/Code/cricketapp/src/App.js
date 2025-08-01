import React from 'react';
import { ListOfPlayers, ScoreBelow70 } from './Components/ListOfPlayers.js'; 
import { OddPlayers, EvenPlayers, IndianPlayers as MergedIndianPlayers } from './Components/IndianPlayers.js';

const players = [
    { name: 'Jack', score: 50 },
    { name: 'Michael', score: 70 },
    { name: 'John', score: 40 },
    { name: 'Ann', score: 61 },
    { name: 'Elisabeth', score: 61 },
    { name: 'Sachin', score: 95 },
    { name: 'Dhoni', score: 100 },
    { name: 'Virat', score: 84 },
    { name: 'Jadeja', score: 64 },
    { name: 'Raina', score: 75 },
    { name: 'Rohit', score: 80 },
];

const T20Players = ['First Player', 'Second Player', 'Third Player'];
const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];
const IndianTeam = ['Sachin1', 'Dhoni2', 'Virat3', 'Rohit4', 'Yuvaraj5', 'Raina6'];
function App() {
    var flag = false;

    if (flag === true) {
        return (
            <div>
                <h1>List of Players</h1>
                <ListOfPlayers players={players} />
                <hr />
                <h1>List of Players having Scores Less than 70</h1>
                <ScoreBelow70 players={players} />
            </div>
        );
    } else {
        return (
            <div>
                <h1>Indian Team</h1>
                <h1>Odd Players</h1>
                <OddPlayers IndianTeam={IndianTeam} />
                <hr />
                <h1>Even Players</h1>
                <EvenPlayers IndianTeam={IndianTeam} />
                <hr />
                <h1>List of Indian Players Merged:</h1>
                <MergedIndianPlayers />
            </div>
        );
    }
}

export default App;