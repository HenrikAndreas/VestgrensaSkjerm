import React, { FunctionComponent, useState, useEffect} from 'react';
import getPeople from '../../api/people';
import { DataGrid, GridRowsProp, GridColDef } from '@mui/x-data-grid';
import "./WashingWeek.css"
import Person from "../../interfaces/Person"


const WashingWeek: FunctionComponent = () => {

    const [peopleData, setPeople] = useState<Array<Person>>([]);
    
    useEffect(() => {
        getPeople()
        .then((res: Array<Person>) => {
            console.log(res)
            setPeople(res);
        })
        .catch((err) => {
            console.log(err);
        }); 
    }, []);

    // Fill this in with 5-10 weeks, bind weeknumber to person
    const columns: GridColDef[] = [
        {field: "name", headerName: "Beboer", flex: 1},
        {field: "week", headerName: "Ukenummer", flex: 1},
        {field: "dato", headerName: "Dato", flex: 1}
    ]


    return (
        <div>
            <div className="title">
                <h2>Vaskeuke</h2>
            </div>
                        
            <div style={{color:"white", height: 300, width: '100%' }}>
                

            </div>
        </div>
    )


}

export default WashingWeek;