import React, { FunctionComponent, useState, useEffect} from 'react';
import Container from '@mui/material/Container';
import api from '../../api/api'
import GoogleLogin from 'react-google-login'
import { gapi } from 'gapi-script';

const gclientId : string = process.env.REACT_APP_GOOGLE_ID!!


const Login: FunctionComponent = (props) => {
    

    useEffect( () => {
        const initClient = () => {
            gapi.client.init({
                clientId: gclientId,
                scope: ''
            })
        gapi.load('client:auth2', initClient);
        }
    }, [])


    const onSuccess = (res:any) => {
        console.log('success:', res);
    };
    const onFailure = (err:any) => {
        console.log('failed:', err);
    };

    return (
        <div className="Login">
            <h1>Login page</h1>
            <GoogleLogin
                clientId={gclientId}
                buttonText="Sign in with Google"
                onSuccess={onSuccess}
                onFailure={onFailure}
                cookiePolicy={'single_host_origin'}
                isSignedIn={true}
            />

        </div>
    );
};

export default Login;


