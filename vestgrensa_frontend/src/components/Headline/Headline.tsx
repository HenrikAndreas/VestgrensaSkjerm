import React, { FunctionComponent} from 'react';
import Container from '@mui/material/Container';
import Clock from '../Clock/Clock';
import './Headline.css';

const Headline: FunctionComponent = (props) => {

    return (
        <Container className="Headline">
            <h1>Welcome to Vestgrensa!</h1>
            <Clock/>
        </Container>
    );
};

export default Headline;


