import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

import Screen from './pages/Screen/Screen';
import Admin from './pages/Admin/Admin';
import Login from './pages/Login/Login';
ReactDOM.render(
  <React.StrictMode>

    <BrowserRouter>
      <Routes>
        <Route element={<Screen/>} path='/skjerm'/>
        <Route element={<Admin/>} path='/admin'/>
        <Route element={<Login/>} path='/login'/>
        <Route path='/'/>

      </Routes>
    </BrowserRouter>



  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();