
import React, { FunctionComponent} from 'react';
import Container from '@mui/material/Container';
import Clock from '../Clock/Clock';
import Headline from '../Headline/Headline';
import Board from '../Board/Board';

import './Screen.css'

const Screen: FunctionComponent = (props) => {

    return (
        <div className="Screen">
            <video className="wallpaperVideo" autoPlay muted loop id="myVideo">
                <source src="storm.mp4" type="video/mp4"/>
            </video>
            <div className="content">
                <Headline/>
                <Board/>
                
            </div>
        </div>
    );
};

export default Screen;


