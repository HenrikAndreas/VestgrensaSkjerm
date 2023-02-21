import React from 'react';
import './Board.css';
import Container from '@mui/material/Container';
import PeopleList from '../PeopleList/PeopleList';
import MessageList from '../MessageList/MessageList';
import WashingWeek from '../WashingWeek/WashingWeek';
function Board() {
  return (
    <Container className="Board">
      {/* <PeopleList /> */}
      {/* <MessageList/> */}
      <WashingWeek/>
    </Container>
  );
}

export default Board;
