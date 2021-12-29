import axios, { AxiosInstance } from "axios";

const vestgrensaApi: string = `${process.env.REACT_APP_API_URL}/`;

const api: AxiosInstance = axios.create({
    baseURL: vestgrensaApi
})

export default api;