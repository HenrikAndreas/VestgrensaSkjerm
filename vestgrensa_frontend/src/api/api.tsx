import axios, { AxiosInstance } from "axios";

const vestgrensaApi: string = process.env.REACT_APP_API_URL!!;

const api: AxiosInstance = axios.create({
    baseURL: "http://127.0.0.1:5011/",
    
})

export default api;