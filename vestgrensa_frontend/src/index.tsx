import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';

import Board from './components/Board/Board';
import Headline from './components/Headline/Headline';
ReactDOM.render(
  <React.StrictMode>
    <video className="wallpaperVideo" autoPlay muted loop id="myVideo">
      <source src="storm.mp4" type="video/mp4"/>
    </video>
    <Headline />
    <Board />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
