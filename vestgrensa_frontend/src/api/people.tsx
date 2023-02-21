import api from './api'
import Person from '../interfaces/Person'

async function getPeople(): Promise<Array<Person>> {
    let response = await api.get<Array<Person>>('/Resident/GetResidentList')
    let result: Array<Person> =response.data;
    return result;
}


export default getPeople;

