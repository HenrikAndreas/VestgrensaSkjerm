import React from 'react';
import './Board.css';
import Container from '@mui/material/Container';
import PeopleList from '../PeopleList/PeopleList';
import MessageList from '../MessageList/MessageList';

function Board() {
  return (
    <Container className="Board">
      {/* <PeopleList /> */}
      <MessageList/>
    </Container>
  );
}

export default Board;
