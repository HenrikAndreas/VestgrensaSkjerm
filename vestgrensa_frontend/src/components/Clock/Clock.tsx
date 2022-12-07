import React, { FunctionComponent, useEffect, useState } from 'react';
import Container from '@mui/material/Container';
import './Clock.css';
import moment from 'moment';    
import { useNavigate } from 'react-router-dom';

const getTime = () => moment().format('HH:mm:ss');
const getDate = () => moment().format('DD-MM-YYYY')

const Clock: FunctionComponent = (props) => {

    const [time, setTime] = useState(getTime());
    const [date, setDate] = useState(getDate());
  
    const tick = () => {
        setTime(getTime());
        setDate(getDate());
    }

    useEffect(() => {
        const interval = setInterval(tick, 1000);
    
        return () => clearInterval(interval);
      }, []);

    
      let navigate = useNavigate();
      const routeChange = () => {
          let path = "/admin"
          navigate(path)
      }
  


    return (
        <div onClick={routeChange}>
            <Container className="Clock">
                <p className="Time">{time}</p>
                <p className="Date">{date}</p>
            </Container>

        </div>
    );
};

export default Clock;