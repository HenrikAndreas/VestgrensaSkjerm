import React, { FunctionComponent} from 'react';
import Clock from '../Clock/Clock';
import './Headline.css';

const Headline: FunctionComponent = (props) => {

    return (
        <div className="Headline">  
            <p>Welcome to Vestgrensa!</p>
            <Clock/>
        </div>
    );
};

export default Headline;


