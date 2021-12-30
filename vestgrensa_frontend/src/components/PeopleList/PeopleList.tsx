import moment from 'moment';
import React, { FunctionComponent, useState, useEffect} from 'react';
// import Container from '@mui/material/Container';
import api from '../../api/api'


interface Person {
    id: number
    birthday: string
    name: string
    age: number
    studyprogramme: string
    roomID: string
}

async function getPeople(): Promise<Array<Person>> {
    let response = await api.get<Array<Person>>('/People')
    let result: Array<Person> =response.data;
    return result;
}

const PeopleList: FunctionComponent = () => {

    const [peopleData, setPeople] = useState(Array<Person>());

    useEffect(() => {
        getPeople()
            .then((res: Array<Person>) => {
                setPeople(res);
            })
            .catch((err) => {
                console.log(err);
            }); 
    }, []);

    return (
        
        <div>
            {peopleData.length > 0 ? peopleData[0].studyprogramme : "NONE"}
            <p>a</p>
            {/* {peopleData.map((person) => {
                return(
                    <p>{person}</p>
                )
            })} */}
        </div>
       
    );
};

export default PeopleList;


