import { createAction, props } from '@ngrx/store';
import { Order } from './order.model';

// Load Orders Actions
export const loadOrders = createAction('[Order] Load Orders');
export const loadOrdersSuccess = createAction(
  '[Order] Load Orders Success',
  props<{ orders: Order[] }>()
);
export const loadOrdersFailure = createAction(
  '[Order] Load Orders Failure',
  props<{ error: string }>()
);

// Add Order Actions
export const addOrder = createAction(
  '[Order] Add Order',
  props<{ order: Order }>()
);
export const addOrderSuccess = createAction(
  '[Order] Add Order Success',
  props<{ order: Order }>()
);
export const addOrderFailure = createAction(
  '[Order] Add Order Failure',
  props<{ error: string }>()
);

// Delete Order Actions
export const deleteOrder = createAction(
  '[Order] Delete Order',
  props<{ id: number }>()
);
export const deleteOrderSuccess = createAction(
  '[Order] Delete Order Success',
  props<{ id: number }>()
);
export const deleteOrderFailure = createAction(
  '[Order] Delete Order Failure',
  props<{ error: string }>()
);
