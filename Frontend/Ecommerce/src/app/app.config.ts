// import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
// import { provideRouter } from '@angular/router';
// import { routes } from './app.routes';
// import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
// import { provideStore } from '@ngrx/store';
// import { productReducer } from './states/product/product.reducer';
// import { provideEffects } from '@ngrx/effects';
// import { ProductEffects } from './states/product/product.effect';
// import { provideHttpClient } from '@angular/common/http';
// import { orderReducer } from './states/order/order.reducer';
// import { OrderEffects } from './states/order/order.effect';

// export const appConfig: ApplicationConfig = {
//   providers: [
//     provideRouter(routes),
//     // Provide store for orders with their reducer
//     provideStore({ orders: orderReducer }),
//     provideEffects([OrderEffects]),

//     // // Provide store for products with their reducer
//     // provideStore({ products: productReducer }),  // 🔥 Must match feature selector for products
//     // provideEffects([ProductEffects]),  // 🔥 Effects must be provided for products

//     provideHttpClient(),  // 🔥 HttpClient is required for the effect
//   ],
// };
import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { provideHttpClient } from '@angular/common/http';

// Import reducers and effects
import { productReducer } from './states/product/product.reducer';
import { ProductEffects } from './states/product/product.effect';
import { orderReducer } from './states/order/order.reducer';
import { OrderEffects } from './states/order/order.effect';

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideHttpClient(),  

   
    provideStore({
      orders: orderReducer,
      products: productReducer
    }),

 
    provideEffects([OrderEffects, ProductEffects])
  ],
};
