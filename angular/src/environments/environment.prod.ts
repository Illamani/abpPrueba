import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Libreria',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44311',
    redirectUri: baseUrl,
    clientId: 'Libreria_App',
    responseType: 'code',
    scope: 'offline_access Libreria',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'Libreria',
    },
  },
} as Environment;
