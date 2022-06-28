import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/book-store', //Esto es obviamente el URL
        name: '::Menu:BookStore', //Es el nombre localizado
        iconClass: 'fas fa-book', //Es el icono, en este case usa FontAwesome
        order: 2, //Es el orden del menu
        layout: eLayoutType.application, //
        requiredPolicy: 'BookStore.Books',
      },
      {
        path: '/books',
        name: '::Menu:Books',
        parentName: '::Menu:BookStore',
        layout: eLayoutType.application,
        requiredPolicy: 'BookStore.Books',
      },
    ]);
  };
}
