import axios, { AxiosInstance } from "axios";

const vestgrensaApi: string = `https://localhost:7176`;

const api: AxiosInstance = axios.create({
    baseURL: vestgrensaApi,
    
})

export default api;