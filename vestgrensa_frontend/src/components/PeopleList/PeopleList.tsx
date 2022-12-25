import React, { FunctionComponent, useState, useEffect} from 'react';
import api from '../../api/api'
import { DataGrid, GridRowsProp, GridColDef } from '@mui/x-data-grid';
import "./PeopleList.css"
import Person from "../../interfaces/Person"
 

async function getPeople(): Promise<Array<Person>> {
    let response = await api.get<Array<Person>>('/Resident/GetResidentList')
    let result: Array<Person> =response.data;
    return result;
}


const PeopleList: FunctionComponent = () => {
    
    const [peopleData, setPeople] = useState<Array<Person>>([]);
    
    useEffect(() => {
        getPeople()
        .then((res: Array<Person>) => {

            setPeople(res);
        })
        .catch((err) => {
            console.log(err);
        }); 
    }, []);

    const columns: GridColDef[] = [
        {field: "name", headerName: "Navn", flex: 1},
        {field: "roomID", headerName: "Romnummer", flex: 1},
        {field: "programme", headerName: "Studie", flex: 1},
        {field: "birthday", headerName: "Fødselsdag", flex: 1}
    ]

    return (
        <div>

            <div className="title">
                <h2>Vestgrensa Beboere</h2>
            </div>
            
            <div style={{color:"white", height: 300, width: '100%' }}>
                <DataGrid rows={peopleData} columns={columns}
                hideFooter
                    sx={{
                        color: "white",
                        boxShadow: 0,
                        border: 0,
                        borderColor: 'white',
                        '& .MuiDataGrid-cell:hover': {
                        color: 'white',
                        },
                    }}
                />
            </div>

        </div>
       
    );
};

export default PeopleList;


