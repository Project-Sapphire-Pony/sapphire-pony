import React from 'react'
import ReactDOM from 'react-dom/client'
import { Auth0Provider } from '@auth0/auth0-react'
import App from './App.tsx'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <Auth0Provider
    domain="dev-foj4121e1ysteapf.us.auth0.com"
    clientId="yLbJczqkRSBS1CIT8EQznp8jPHEOazsB"
    authorizationParams={{
    redirect_uri: window.location.origin
  }}
  >
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  </Auth0Provider>,
)
