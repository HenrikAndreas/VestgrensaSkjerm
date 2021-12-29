import axios, { AxiosInstance } from "axios";

const vestgrensaApi: string = `https://localhost:7034`;

const api: AxiosInstance = axios.create({
    baseURL: vestgrensaApi
})

export default api;