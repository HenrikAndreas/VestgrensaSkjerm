import React, { FunctionComponent} from 'react';
import Container from '@mui/material/Container';
import api from '../../api/api'

async function getPeople() {
    const result = await api.get('/People')
    return result;
}

const PeopleList: FunctionComponent = (props) => {
    const peeps = getPeople().then((res) => {
        console.log(res);
        return res;
    });

    
    return (
        <p>UNIMPLEMENTED LIST OF PEOPLE</p>
        // <div>
        //     {people.map((p) => {
        //         return(
        //             <p>{p}</p>
        //         )
        //     })}
        // </div>
       
    );
};

export default PeopleList;


