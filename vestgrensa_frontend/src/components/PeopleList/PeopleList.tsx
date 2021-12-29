import moment from 'moment';
import React, { FunctionComponent, useState, useEffect} from 'react';
// import Container from '@mui/material/Container';
import api from '../../api/api'


interface Person {
    id: number
    birthday: string
    name: string
    age: number
    studyprogram: string
    roomID: string
}

async function getPeople() {
    const result = await api.get('/People')

    return result;
}

const PeopleList: FunctionComponent = () => {

    const [peopleData, setPeople] = useState([]);
    
    useEffect(() => {
        getPeople()
            .then((res) => {
                console.log(res);
                setPeople(res.data);
            })
            .catch((err) => {
                console.log(err);
            });
    }, []);

    return (
        <p>{peopleData.toString()}</p>
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


