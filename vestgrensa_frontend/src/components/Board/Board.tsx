import React from 'react';
import './Board.css';
import Container from '@mui/material/Container';
import PeopleList from '../PeopleList/PeopleList';

function Board() {
  return (
    <Container className="Board">
      <PeopleList />
    </Container>
    // <div className="Board">
    //   <p>Test</p>
    // </div>
  );
}

export default Board;
