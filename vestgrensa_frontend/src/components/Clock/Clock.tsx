import React, { FunctionComponent, useEffect, useState } from 'react';
import './Clock.css';
import moment from 'moment';    

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

    return (
        <div className="Clock">
            <p className="Time">{time}</p>
            <p className="Date">{date}</p>
        </div>
    );
};

export default Clock;