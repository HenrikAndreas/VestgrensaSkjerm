import React, { FunctionComponent, useState, useEffect} from 'react';
import Container from '@mui/material/Container';
import Person from "../../interfaces/Person"
import Message from '../../interfaces/Message';
import api from '../../api/api'

async function getMe(): Promise<Array<Person>> {
    let response = await api.get<Array<Person>>('/Resident/GetResident', {
        params: {id : 1}
    })
    let result: Array<Person> =response.data;
    return result;
}

// async function getMsg(): Promise<Array<Message>> {
//     let response = await api.get<Array<Person>>('/Resident/GetResident', {
//         params: {id : 1}
//     })
//     let result: Array<Person> =response.data;
//     return result;
// }
async function sendMsg(resident: Person) {
    
    let query = await api.post('Message/AddMessage', {
        headers : {
            "Content-Type":"application/json",  
        },
        "title": "string",
        "text": "string",
        "resident": {
            "residentID": resident.residentID,
            "name": resident.name,
            "roomID": resident.roomID,
            "programme": resident.programme,
            "university": resident.university,
            "birthday": resident.birthday,
            "current": resident.current
        }
    });
    let result = query.data;
    return result;
}


const Admin: FunctionComponent = (props) => {

    const [me, setMe] = useState<Person>();
    
    useEffect(() => {
        getMe()
        .then((res: Array<Person>) => {
            setMe(res[0]);
        })
        .catch((err) => {
            console.log(err);
        }); 
    }, []);


    const addMsg = () => {
        if (me) {
            sendMsg(me)
        }
    }

    return (
        <div className="Admin">
            <h1>Her kan du lage endringer</h1>
            <button onClick={addMsg} >Test getMessages</button>
        </div>
    );
};

export default Admin;


