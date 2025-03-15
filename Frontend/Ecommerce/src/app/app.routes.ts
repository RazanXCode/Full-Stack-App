import { Routes } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { OrderListComponent } from './order-list/order-list.component';

export const routes: Routes = [
  { path: 'products', component: ProductListComponent },
  { path: 'orders', component: OrderListComponent },
  { path: '', redirectTo: '/products', pathMatch: 'full' }, // Default route
];
